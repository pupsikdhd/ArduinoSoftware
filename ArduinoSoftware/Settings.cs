using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ArduinoSoftware
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public static string jsonPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\settings.json";

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey rkHide = Registry.CurrentUser.OpenSubKey("ArduinoSoft", true) ?? Registry.CurrentUser.CreateSubKey("ArduinoSoft", true);
            RegistryKey rkAuto = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (AutoStartCheckBox.Checked)
            {
                rkAuto.SetValue("clean", Application.ExecutablePath);
            }
            else
            {
                rkAuto.DeleteValue("clean", false);
            }

            if (HideCheckBox.Checked)
            {
                rkHide.SetValue("isHide", 1);
            }
            else
            {
                rkHide.SetValue("isHide", 0);
            }

            this.Close();
        }
        private void CheckJson()
        {
            if (File.Exists(jsonPath))
            {
                PathLabel.Text = jsonPath;
                return;
            }
            CreateJsonBtn.Enabled = true;
            CreateJsonBtn.Visible = true;
            PathLabel.Text = "File not found";
        }

        private void CreateJsonBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(jsonPath))
            {
                File.Create(jsonPath).Close();
                CreateJsonBtn.Enabled = false;
                CheckJson();
            }
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            RegistryKey rkHide = Registry.CurrentUser.OpenSubKey("ArduinoSoft", true) ?? Registry.CurrentUser.CreateSubKey("ArduinoSoft", true);
            object isHideValue = rkHide.GetValue("isHide");
            object lightOnClickValue = rkHide.GetValue("lightOnClick");
            if (isHideValue != null && isHideValue.ToString() == "1")
            {
                HideCheckBox.Checked = true;
            }
            RegistryKey rkAuto = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            object cleanValue = rkAuto.GetValue("clean");
            if (cleanValue != null && cleanValue.ToString() != "0")
            {
                AutoStartCheckBox.Checked = true;
            }
            CheckJson();
        }

        private void button2_Click(object sender, EventArgs e) => this.Close();

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            if (!File.Exists(jsonPath))
            {
                File.Copy(openFileDialog1.FileName, jsonPath);
            }
            else
            {
                File.Delete(jsonPath);
                File.Copy(openFileDialog1.FileName, jsonPath);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            if (File.Exists(saveFileDialog1.FileName))
            {
                File.Delete(saveFileDialog1.FileName);
            }

            File.Copy(jsonPath, saveFileDialog1.FileName);
        }

        private void CreateJsonBtn_Click_1(object sender, EventArgs e)
        {
            File.Create(jsonPath).Close();
            CreateJsonBtn.Visible = false;
            CheckJson();
        }

    }
}
