using Microsoft.Win32;
using System;
using System.IO;
using System.IO.Ports;
using System.Text.Json;
using System.Windows.Forms;

namespace ArduinoSoftware
{
    public sealed partial class Form1 : Form
    {
        public static string jsonPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\settings.json";
        public bool isHideProgramm = true;
        private static SerialPort _serialPort;


        public Form1()
        {
            InitializeComponent();

            notifyIcon1.BalloonTipTitle = "App";
            notifyIcon1.BalloonTipText = "Application minimized to tray";
            notifyIcon1.Text = "Arduino Software";
            notifyIcon1.Visible = false;
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxComs.Items.AddRange(ports);
            string data = File.ReadAllText(jsonPath);
            settings personal = JsonSerializer.Deserialize<settings>(data);
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


            try
            {

                try
                {
                    _serialPort = new SerialPort(personal.port, 9600);
                    _serialPort.Open();
                    _serialPort.DataReceived += DataReceivedHandler;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Open com port error");
                    //CheckLabelPrint("Open com port error.", 5000);
                }
                FCommand.Text = personal.firstCommand;
                SCommand.Text = personal.secondCommand;
                TCommand.Text = personal.thirdCommand;
                comboBoxComs.SelectedIndex = comboBoxComs.Items.IndexOf(personal.port);
            }
            catch
            {
                MessageBox.Show("Error an occurred", "Initialization error");
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (getRegIsHide())
                {
                    if (!isHideProgramm)
                        Application.Exit();
                    else
                    {
                        hideToTray(e);
                    }
                }
            }
            catch
            {
            }
        }

    }
}
