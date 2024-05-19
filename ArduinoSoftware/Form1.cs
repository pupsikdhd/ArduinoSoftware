using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Text.Json;
using System.Threading;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(jsonPath))
            {
                PathLabel.Text = jsonPath;
                return;
            }
            CreateJsonBtn.Enabled = true;
            PathLabel.Text = "File not found";
        }

        private void CreateJsonBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(jsonPath))
            {
                File.Create(jsonPath).Close();
                CreateJsonBtn.Enabled = false;
                button1.PerformClick();
            }
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
            }
            string[] ports = SerialPort.GetPortNames();
            comboBoxComs.Items.AddRange(ports);
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
            }
            catch
            {
                MessageBox.Show("Error an occurred", "Error");
            }

            string[] ports = SerialPort.GetPortNames();
            comboBoxComs.Items.AddRange(ports);
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
            DialogResult dr = MessageBox.Show("If you change the port, we recommend restarting the program", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                isHideProgramm = false;
                Application.Restart();
            }
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
            comboBoxComs.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comboBoxComs.Items.AddRange(ports);
        }
    }
}
