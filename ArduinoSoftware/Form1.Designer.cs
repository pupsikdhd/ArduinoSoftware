using customBtnTest;

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
            this.FCommand = new System.Windows.Forms.TextBox();
            this.TCommand = new System.Windows.Forms.TextBox();
            this.SCommand = new System.Windows.Forms.TextBox();
            this.comboBoxComs = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckLabel = new System.Windows.Forms.Label();
            this.saveBtn = new customBtnTest.MyBtn();
            this.checkArduino = new customBtnTest.MyBtn();
            this.OpenSetting = new customBtnTest.MyBtn();
            this.updateBtn = new customBtnTest.MyBtn();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FCommand
            // 
            this.FCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FCommand.Location = new System.Drawing.Point(15, 12);
            this.FCommand.Name = "FCommand";
            this.FCommand.Size = new System.Drawing.Size(558, 31);
            this.FCommand.TabIndex = 1;
            // 
            // TCommand
            // 
            this.TCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TCommand.Location = new System.Drawing.Point(12, 86);
            this.TCommand.Name = "TCommand";
            this.TCommand.Size = new System.Drawing.Size(560, 31);
            this.TCommand.TabIndex = 2;
            // 
            // SCommand
            // 
            this.SCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SCommand.Location = new System.Drawing.Point(15, 49);
            this.SCommand.Name = "SCommand";
            this.SCommand.Size = new System.Drawing.Size(557, 31);
            this.SCommand.TabIndex = 3;
            // 
            // comboBoxComs
            // 
            this.comboBoxComs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComs.FormattingEnabled = true;
            this.comboBoxComs.Location = new System.Drawing.Point(15, 123);
            this.comboBoxComs.Name = "comboBoxComs";
            this.comboBoxComs.Size = new System.Drawing.Size(141, 21);
            this.comboBoxComs.TabIndex = 5;
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
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // CheckLabel
            // 
            this.CheckLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CheckLabel.AutoSize = true;
            this.CheckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CheckLabel.Location = new System.Drawing.Point(12, 248);
            this.CheckLabel.Name = "CheckLabel";
            this.CheckLabel.Size = new System.Drawing.Size(0, 20);
            this.CheckLabel.TabIndex = 11;
            // 
            // saveBtn
            // 
            this.saveBtn.alphaOnHover = ((byte)(30));
            this.saveBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saveBtn.BorderColorOnHover = System.Drawing.Color.White;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn.Location = new System.Drawing.Point(12, 150);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(144, 42);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // checkArduino
            // 
            this.checkArduino.alphaOnHover = ((byte)(30));
            this.checkArduino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkArduino.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkArduino.BorderColorOnHover = System.Drawing.Color.White;
            this.checkArduino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkArduino.Location = new System.Drawing.Point(12, 271);
            this.checkArduino.Name = "checkArduino";
            this.checkArduino.Size = new System.Drawing.Size(97, 23);
            this.checkArduino.TabIndex = 10;
            this.checkArduino.Text = "Check Arduino";
            this.checkArduino.Click += new System.EventHandler(this.checkArduino_Click);
            // 
            // OpenSetting
            // 
            this.OpenSetting.alphaOnHover = ((byte)(30));
            this.OpenSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenSetting.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OpenSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenSetting.BorderColorOnHover = System.Drawing.Color.White;
            this.OpenSetting.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenSetting.Location = new System.Drawing.Point(518, 271);
            this.OpenSetting.Name = "OpenSetting";
            this.OpenSetting.Size = new System.Drawing.Size(73, 23);
            this.OpenSetting.TabIndex = 7;
            this.OpenSetting.Text = "Settings";
            this.OpenSetting.Click += new System.EventHandler(this.OpenSetting_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.alphaOnHover = ((byte)(30));
            this.updateBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.updateBtn.BorderColorOnHover = System.Drawing.Color.White;
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateBtn.Location = new System.Drawing.Point(162, 123);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(67, 23);
            this.updateBtn.TabIndex = 9;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(603, 306);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.checkArduino);
            this.Controls.Add(this.FCommand);
            this.Controls.Add(this.TCommand);
            this.Controls.Add(this.OpenSetting);
            this.Controls.Add(this.SCommand);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.comboBoxComs);
            this.Controls.Add(this.CheckLabel);
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
        private System.Windows.Forms.TextBox FCommand;
        private System.Windows.Forms.TextBox TCommand;
        private System.Windows.Forms.TextBox SCommand;
        private MyBtn saveBtn;
        private System.Windows.Forms.ComboBox comboBoxComs;
        private MyBtn OpenSetting;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MyBtn updateBtn;
        private MyBtn checkArduino;
        private System.Windows.Forms.Label CheckLabel;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
    }
}

