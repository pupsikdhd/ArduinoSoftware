using System;
using System.IO;
using System.Windows.Forms;

namespace ArduinoSoftware
{
    public partial class Settings : Form
    {
        private static Form1 form1;
        private Reg reg = new Reg();
        public Settings(Form1 owner)
        {
            InitializeComponent();
            form1 = owner;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        } 

        public static string jsonPath = Form1.jsonPath;

        private void button1_Click(object sender, EventArgs e)
        {
           reg.setRegIsHide(HideCheckBox.Checked);
            reg.setRegIsAutoRun(AutoStartCheckBox.Checked);

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

        private void Settings_Load(object sender, EventArgs e)
        {
            reg.checkRegKey();
            if (reg.getRegIsHide())
            {
                HideCheckBox.Checked = true;
            }

            if (reg.getRegIsAutoRun())
            {
                AutoStartCheckBox.Checked = true;
            }
            CheckJson();
        }

        private void button2_Click(object sender, EventArgs e) => this.Close();

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            openFileDialog1.Title = "Select a JSON File";
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
