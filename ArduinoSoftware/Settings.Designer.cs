using customBtnTest;

namespace ArduinoSoftware
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new customBtnTest.MyBtn();
            this.AutoStartCheckBox = new System.Windows.Forms.CheckBox();
            this.HideCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new customBtnTest.MyBtn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.PathLabel = new System.Windows.Forms.Label();
            this.CreateJsonBtn = new customBtnTest.MyBtn();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new customBtnTest.MyBtn();
            this.button3 = new customBtnTest.MyBtn();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.alphaOnHover = ((byte)(30));
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.BorderColorOnHover = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(4, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AutoStartCheckBox
            // 
            this.AutoStartCheckBox.AutoSize = true;
            this.AutoStartCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoStartCheckBox.Location = new System.Drawing.Point(4, 12);
            this.AutoStartCheckBox.Name = "AutoStartCheckBox";
            this.AutoStartCheckBox.Size = new System.Drawing.Size(76, 19);
            this.AutoStartCheckBox.TabIndex = 1;
            this.AutoStartCheckBox.Text = "Auto start";
            this.AutoStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // HideCheckBox
            // 
            this.HideCheckBox.AutoSize = true;
            this.HideCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HideCheckBox.Location = new System.Drawing.Point(4, 37);
            this.HideCheckBox.Name = "HideCheckBox";
            this.HideCheckBox.Size = new System.Drawing.Size(111, 19);
            this.HideCheckBox.TabIndex = 2;
            this.HideCheckBox.Text = "Hide for closing";
            this.HideCheckBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.alphaOnHover = ((byte)(30));
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.BorderColorOnHover = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(85, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Settings files|*.json\"";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(12, 64);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(0, 13);
            this.PathLabel.TabIndex = 8;
            // 
            // CreateJsonBtn
            // 
            this.CreateJsonBtn.alphaOnHover = ((byte)(30));
            this.CreateJsonBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CreateJsonBtn.BorderColorOnHover = System.Drawing.Color.White;
            this.CreateJsonBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CreateJsonBtn.Location = new System.Drawing.Point(391, 89);
            this.CreateJsonBtn.Name = "CreateJsonBtn";
            this.CreateJsonBtn.Size = new System.Drawing.Size(75, 27);
            this.CreateJsonBtn.TabIndex = 7;
            this.CreateJsonBtn.Text = "Create json";
            this.CreateJsonBtn.Visible = false;
            this.CreateJsonBtn.Click += new System.EventHandler(this.CreateJsonBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(404, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Json";
            // 
            // button4
            // 
            this.button4.alphaOnHover = ((byte)(30));
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.BorderColorOnHover = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(391, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Export";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.alphaOnHover = ((byte)(30));
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.BorderColorOnHover = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(391, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Import";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(471, 121);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.CreateJsonBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.HideCheckBox);
            this.Controls.Add(this.AutoStartCheckBox);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(487, 160);
            this.MinimumSize = new System.Drawing.Size(487, 160);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyBtn button1;
        private System.Windows.Forms.CheckBox AutoStartCheckBox;
        private System.Windows.Forms.CheckBox HideCheckBox;
        private MyBtn button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label PathLabel;
        private MyBtn CreateJsonBtn;
        private System.Windows.Forms.Label label1;
        private MyBtn button4;
        private MyBtn button3;
    }
}