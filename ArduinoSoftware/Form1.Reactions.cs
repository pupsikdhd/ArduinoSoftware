using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ArduinoSoftware
{
    public sealed partial class Form1 : Form
    {
        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(jsonPath))
            {
                MessageBox.Show("Json file is not found. Please create it in settings", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (comboBoxComs.SelectedIndex.ToString() == "-1")
                {
                    StatusLabelPrint("You did not specify the port", 3000);
                    return;
                }

                var settings = new settings
                {
                    firstCommand = FCommand.Text,
                    secondCommand = SCommand.Text,
                    thirdCommand = TCommand.Text,
                    port = comboBoxComs.Items[comboBoxComs.SelectedIndex].ToString()
                };
                var jsonString = JsonSerializer.Serialize(settings);
                File.WriteAllText(jsonPath, jsonString);
                restartCom();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving settings. More details:" + ex, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenSetting_Click(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fullExit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUpdateInfo();
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