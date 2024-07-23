using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ArduinoSoftware
{
    public sealed partial class Form1 : Form
    {
        //update data from json
        public void FormUpdateInfo()
        {
            comboBoxComs.Items.Clear();
            var ports = SerialPort.GetPortNames();
            comboBoxComs.Items.AddRange(ports);
            if (!File.Exists(jsonPath))
            {
                MessageBox.Show("Json file is not found. Please create it in settings", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                var data = File.ReadAllText(jsonPath);
                var personal = JsonSerializer.Deserialize<settings>(data);
                if (File.Exists(jsonPath))
                {
                    FCommand.Text = personal.firstCommand;
                    SCommand.Text = personal.secondCommand;
                    TCommand.Text = personal.thirdCommand;

                    comboBoxComs.SelectedIndex = comboBoxComs.Items.IndexOf(personal.port);
                }
                else
                {
                    StatusLabelPrint("There is no access to the file, check or create it in the settings", 5000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving settings. More details:" + ex, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //print text
        private async void StatusLabelPrint(string text, int delay)
        {
            if (CheckLabel.InvokeRequired)
            {
                CheckLabel.Invoke(new Action(() => { CheckLabel.Text = text; }));
                await Task.Delay(delay);
                CheckLabel.Invoke(new Action(() => { CheckLabel.Text = null; }));
            }
            else
            {
                CheckLabel.Text = text;
                await Task.Delay(delay);
                CheckLabel.Text = null;
            }
        }

        //restart com port connection
        /*the function accepts text that
         will be output when the com port is restarted*/
        private void restartCom(string text)
        {
            try
            {
                if (File.Exists(jsonPath))
                {
                    var data = File.ReadAllText(jsonPath);
                    var personal = JsonSerializer.Deserialize<settings>(data);

                    try
                    {
                        try
                        {
                            _serialPort.Close();
                        }catch 
                        {}

                        _serialPort = new SerialPort(personal.port, 9600);
                        _serialPort.Open();
                        _serialPort.DataReceived += DataReceivedHandler;
                        StatusLabelPrint(text, 3000);
                    }
                    catch (Exception ex)
                    {
                        var dr = MessageBox.Show(
                            "Device not detected. Try again?  \n If that doesn't work, try restarting the program. \n" +
                            ex, "Error",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            restartCom(text);
                            return;
                        }
                    }

                    return;
                }

                if (comboBoxComs.SelectedIndex.ToString() != "-1")
                {
                    _serialPort.Close();
                    _serialPort = new SerialPort(comboBoxComs.SelectedText, 9600);
                    _serialPort.Open();
                }
            }
            catch
            {
                MessageBox.Show(
                    "The json file does not contain the required settings. \n The \"port\" setting is required",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // close app
        public void fullExit()
        {
            isHideProgramm = false;
            Application.Exit();
        }
        //restart app
        public void restartApp()
        {
            isHideProgramm = false;
            Application.Restart();
        }

        //hide app to tray
        public void hideToTray(FormClosingEventArgs e)
        {
            if (e != null)
            {
                e.Cancel = true;
            }

            Hide();
            notifyIcon1.Visible = true;
        }


        //getting parameters from the registry
        public bool getRegIsHide()
        {
            var currentUserKey = Registry.CurrentUser;
            var rkHide = currentUserKey.OpenSubKey("ArduinoSoft");
            if (rkHide.GetValue("isHide").ToString() == "1") return true;
            return false;
        }

        public bool getRegIsAutoRun()
        {
            RegistryKey rkAuto = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            object cleanValue = rkAuto.GetValue("clean");
            if (cleanValue != null && cleanValue.ToString() != "0")
            {
                return true;
            }
            return false;
        }

        public void checkRegKey()
        {
            var rkHide = Registry.CurrentUser.OpenSubKey("ArduinoSoft", true);
            if (rkHide == null)
            {
                Registry.CurrentUser.CreateSubKey("ArduinoSoft", true).Close();
                rkHide = Registry.CurrentUser.OpenSubKey("ArduinoSoft", true);
            }

            if (rkHide.GetValue("isHide") == null) rkHide.SetValue("isHide", 0);
        }

        //process data from the com port
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            var data = File.ReadAllText(jsonPath);
            var personal = JsonSerializer.Deserialize<settings>(data);
            new Thread(() =>
            {
                Action action = () => { FormUpdateInfo(); };
            }).Start();

            try
            {
                if (File.Exists(jsonPath))
                {
                    var btnNumber = Convert.ToInt32(_serialPort.ReadExisting());

                    switch (btnNumber)
                    {
                        case 1:
                            Process.Start("cmd", "/c " + personal.firstCommand);
                            break;
                        case 2:
                            Process.Start("cmd", "/c " + personal.secondCommand);
                            break;
                        case 3:
                            Process.Start("cmd", "/c " + personal.thirdCommand);
                            break;
                        case 10:
                            StatusLabelPrint(" Device found successfully.", 3000);
                            break;
                        default:
                            StatusLabelPrint("Check if your device is programmed correctly.", 2000);
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid command", "Error");
            }
        }
    }
}