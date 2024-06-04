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



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isHideProgramm = false;
            Application.Exit();
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


        private void CloseBtn_Click(object sender, EventArgs e)
        {
            isHideProgramm = false;
            Application.Exit();
        }
    }
}
