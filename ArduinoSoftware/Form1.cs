using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArduinoSoftware
{
    public sealed partial class Form1 : Form
    {
        public static string jsonPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\settings.json";
        public bool isHideProgramm = true;
        private static Functions func = new Functions();
        private static SerialPort _serialPort;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenSetting_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }


        public void FormUpdateInfo()
        {
            if (File.Exists(jsonPath))
            {
                string data = File.ReadAllText(jsonPath);
                settings personal = JsonSerializer.Deserialize<settings>(data);
                FCommand.Text = personal.firstCommand;
                SCommand.Text = personal.secondCommand;
                TCommand.Text = personal.thirdCommand;
                comboBoxComs.Items.Clear();
                string[] ports = SerialPort.GetPortNames();
                comboBoxComs.Items.AddRange(ports);
                comboBoxComs.SelectedIndex = comboBoxComs.Items.IndexOf(personal.port);
            }
            else
            {
                MessageBox.Show("There is no access to the file, check or create it in the settings","Error");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey rkHide = Registry.CurrentUser.OpenSubKey("ArduinoSoft", true);
            if (rkHide == null)
            {
                Registry.CurrentUser.CreateSubKey("ArduinoSoft", true).Close();
                rkHide = Registry.CurrentUser.OpenSubKey("ArduinoSoft", true);
            }

            if (rkHide.GetValue("isHide") == null)
            {
                rkHide.SetValue("isHide", 0);
            }
            notifyIcon1.BalloonTipTitle = "App";
            notifyIcon1.BalloonTipText = "Application minimized to tray";
            notifyIcon1.Text = "Arduino Software";
            notifyIcon1.Visible = false;

            try
            {
                string data = File.ReadAllText(jsonPath);
                settings personal = JsonSerializer.Deserialize<settings>(data);
                try
                {
                    _serialPort = new SerialPort(personal.port, 9600);
                    _serialPort.Open();
                    _serialPort.DataReceived += DataReceivedHandler;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Open com port error");
                }
                FCommand.Text = personal.firstCommand;
                SCommand.Text = personal.secondCommand;
                TCommand.Text = personal.thirdCommand;
                string[] ports = SerialPort.GetPortNames();
                comboBoxComs.Items.AddRange(ports);
                comboBoxComs.SelectedIndex = comboBoxComs.Items.IndexOf(personal.port);
            }
            catch
            {
                MessageBox.Show("Error an occurred", "Error");
            }

        }

        private async void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            new Thread(() =>
            {
                Action action = () =>
                {
                    FormUpdateInfo();
                };
            }).Start();

            try
            {
                if (File.Exists(jsonPath))
                {
                    string data = File.ReadAllText(jsonPath);
                    settings personal = JsonSerializer.Deserialize<settings>(data);
                    int btnNumber = Convert.ToInt32(_serialPort.ReadExisting());

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
                                CheckLabelPrint();
                                break;
                            default:
                                MessageBox.Show("Check if your device is programmed correctly.", "Command not found");
                                break;
                        }
                }
            }
            catch
            {
                MessageBox.Show("Invalid command", "Error");
            }
        }

        private async void CheckLabelPrint()
        {
            if (CheckLabel.InvokeRequired)
            {
                CheckLabel.Invoke(new Action(() =>
                {
                    CheckLabel.Text = "Verification was successful";
                }));
                await Task.Delay(1500);
                CheckLabel.Invoke(new Action(() =>
                {
                    CheckLabel.Text = "";
                }));
            }
            else
            {
                CheckLabel.Text = "Verification was successful";
                await Task.Delay(1500);
                CheckLabel.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxComs.SelectedIndex.ToString() == "-1")
            {
                MessageBox.Show("You did not specify the port", "Error");
                return;
            }
            settings settings = new settings
            {
                firstCommand = FCommand.Text,
                secondCommand = SCommand.Text,
                thirdCommand = TCommand.Text,
                port = comboBoxComs.Items[comboBoxComs.SelectedIndex].ToString(),
            };
            string jsonString = JsonSerializer.Serialize(settings);
            File.WriteAllText(jsonPath, jsonString);
            restartCom();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey rkHide = currentUserKey.OpenSubKey("ArduinoSoft");
            if (rkHide.GetValue("isHide").ToString() == "1")
            {
                if (!isHideProgramm)
                    Application.Exit();
                else
                {
                    e.Cancel = true;
                    Hide();
                    notifyIcon1.Visible = true;
                    notifyIcon1.ShowBalloonTip(1000);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isHideProgramm = false;
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUpdateInfo();
        }
        private void restartCom()
        {
            try
            {
                _serialPort.Close();
                string data = File.ReadAllText(jsonPath);
                settings personal = JsonSerializer.Deserialize<settings>(data);
                _serialPort = new SerialPort(personal.port, 9600);
                _serialPort.Open();
                _serialPort.DataReceived += DataReceivedHandler;
                MessageBox.Show("Device found successfully.","Done");
            }
            catch(Exception ex) 
            {
                DialogResult dr = MessageBox.Show("Device not detected. Try again? \n" + ex, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes) { restartCom(); return; }
            }
        }
        private void checkArduino_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Write(1.ToString());
            }
            catch
            {
                restartCom();
            }
        }
    }
}
