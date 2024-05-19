namespace ArduinoSoftware
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.FCommand = new System.Windows.Forms.TextBox();
            this.TCommand = new System.Windows.Forms.TextBox();
            this.SCommand = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxComs = new System.Windows.Forms.ComboBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.OpenSetting = new System.Windows.Forms.Button();
            this.CreateJsonBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(15, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FCommand
            // 
            this.FCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FCommand.Location = new System.Drawing.Point(12, 12);
            this.FCommand.Name = "FCommand";
            this.FCommand.Size = new System.Drawing.Size(553, 31);
            this.FCommand.TabIndex = 1;
            // 
            // TCommand
            // 
            this.TCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TCommand.Location = new System.Drawing.Point(12, 86);
            this.TCommand.Name = "TCommand";
            this.TCommand.Size = new System.Drawing.Size(553, 31);
            this.TCommand.TabIndex = 2;
            // 
            // SCommand
            // 
            this.SCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SCommand.Location = new System.Drawing.Point(13, 49);
            this.SCommand.Name = "SCommand";
            this.SCommand.Size = new System.Drawing.Size(553, 31);
            this.SCommand.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxComs
            // 
            this.comboBoxComs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComs.FormattingEnabled = true;
            this.comboBoxComs.Location = new System.Drawing.Point(15, 123);
            this.comboBoxComs.Name = "comboBoxComs";
            this.comboBoxComs.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComs.TabIndex = 5;
            // 
            // PathLabel
            // 
            this.PathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathLabel.Location = new System.Drawing.Point(10, 224);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(0, 25);
            this.PathLabel.TabIndex = 6;
            // 
            // OpenSetting
            // 
            this.OpenSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenSetting.Location = new System.Drawing.Point(490, 260);
            this.OpenSetting.Name = "OpenSetting";
            this.OpenSetting.Size = new System.Drawing.Size(79, 23);
            this.OpenSetting.TabIndex = 7;
            this.OpenSetting.Text = "Settings";
            this.OpenSetting.UseVisualStyleBackColor = true;
            this.OpenSetting.Click += new System.EventHandler(this.OpenSetting_Click);
            // 
            // CreateJsonBtn
            // 
            this.CreateJsonBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateJsonBtn.Enabled = false;
            this.CreateJsonBtn.Location = new System.Drawing.Point(96, 252);
            this.CreateJsonBtn.Name = "CreateJsonBtn";
            this.CreateJsonBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateJsonBtn.TabIndex = 8;
            this.CreateJsonBtn.Text = "Create json";
            this.CreateJsonBtn.UseVisualStyleBackColor = true;
            this.CreateJsonBtn.Click += new System.EventHandler(this.CreateJsonBtn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(94, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(142, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 295);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CreateJsonBtn);
            this.Controls.Add(this.OpenSetting);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.comboBoxComs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SCommand);
            this.Controls.Add(this.TCommand);
            this.Controls.Add(this.FCommand);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(449, 334);
            this.Name = "Form1";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FCommand;
        private System.Windows.Forms.TextBox TCommand;
        private System.Windows.Forms.TextBox SCommand;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxComs;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Button OpenSetting;
        private System.Windows.Forms.Button CreateJsonBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button3;
    }
}

