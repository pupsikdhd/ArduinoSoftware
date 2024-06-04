using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoSoftware
{
    public sealed partial class Form1 : Form
    {
        public void FormUpdateInfo()
        {
            if (File.Exists(jsonPath))
            {
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
                CheckLabelPrint("There is no access to the file, check or create it in the settings", 3000);
            }
        }

        private async void CheckLabelPrint(string text, int delay)
        {
            if (CheckLabel.InvokeRequired)
            {
                CheckLabel.Invoke(new Action(() =>
                {
                    CheckLabel.Text = text;
                }));
                await Task.Delay(delay);
                CheckLabel.Invoke(new Action(() =>
                {
                    CheckLabel.Text = "";
                }));
            }
            else
            {
                CheckLabel.Text = text;
                await Task.Delay(delay);
                CheckLabel.Text = "";
            }
        }

        private void restartCom()
        {
            try
            {
                _serialPort.Close();
                _serialPort = new SerialPort(personal.port, 9600);
                _serialPort.Open();
                _serialPort.DataReceived += DataReceivedHandler;
                MessageBox.Show("Device found successfully.", "Done");
            }
            catch (Exception ex)
            {
                DialogResult dr = MessageBox.Show("Device not detected. Try again? \n" + ex, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes) { restartCom(); return; }
            }
        }


        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
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
                            CheckLabelPrint("Verification was successful", 1500);
                            break;
                        default:
                            CheckLabelPrint("Check if your device is programmed correctly.", 2000);
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
