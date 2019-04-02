﻿namespace TCPServer
{
    partial class fMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lAddress = new System.Windows.Forms.Label();
            this.lPort = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbLogger = new System.Windows.Forms.ListBox();
            this.bStop = new System.Windows.Forms.Button();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.bwConnection = new System.ComponentModel.BackgroundWorker();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.bwMessages = new System.ComponentModel.BackgroundWorker();
            this.wbMessage = new System.Windows.Forms.WebBrowser();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.gbSettingsChat = new System.Windows.Forms.GroupBox();
            this.cbSettingsUsername = new System.Windows.Forms.CheckBox();
            this.lSettingsUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.gbSettingsStyle = new System.Windows.Forms.GroupBox();
            this.rbSettingsStyle1 = new System.Windows.Forms.RadioButton();
            this.rbSettingsStyle0 = new System.Windows.Forms.RadioButton();
            this.lMessage = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.gbStylization = new System.Windows.Forms.GroupBox();
            this.gbUserColor = new System.Windows.Forms.GroupBox();
            this.lUserColorBlue = new System.Windows.Forms.Label();
            this.lUserColorGreen = new System.Windows.Forms.Label();
            this.lUserColorRed = new System.Windows.Forms.Label();
            this.nudUserColorBlue = new System.Windows.Forms.NumericUpDown();
            this.nudUserColorGreen = new System.Windows.Forms.NumericUpDown();
            this.nudUserColorRed = new System.Windows.Forms.NumericUpDown();
            this.gbMessageColor = new System.Windows.Forms.GroupBox();
            this.lMessageColorBlue = new System.Windows.Forms.Label();
            this.lMessageColorGreen = new System.Windows.Forms.Label();
            this.lMessageColorRed = new System.Windows.Forms.Label();
            this.nudMessageColorBlue = new System.Windows.Forms.NumericUpDown();
            this.nudMessageColorGreen = new System.Windows.Forms.NumericUpDown();
            this.nudMessageColorRed = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.gbSettings.SuspendLayout();
            this.gbSettingsChat.SuspendLayout();
            this.gbSettingsStyle.SuspendLayout();
            this.gbStylization.SuspendLayout();
            this.gbUserColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserColorBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserColorGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserColorRed)).BeginInit();
            this.gbMessageColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMessageColorBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMessageColorGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMessageColorRed)).BeginInit();
            this.SuspendLayout();
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(12, 9);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(45, 13);
            this.lAddress.TabIndex = 0;
            this.lAddress.Text = "Address";
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(209, 9);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(26, 13);
            this.lPort.TabIndex = 1;
            this.lPort.Text = "Port";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(63, 6);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(140, 20);
            this.tbAddress.TabIndex = 2;
            this.tbAddress.Text = "127.0.0.1";
            // 
            // lbLogger
            // 
            this.lbLogger.FormattingEnabled = true;
            this.lbLogger.Location = new System.Drawing.Point(11, 58);
            this.lbLogger.Name = "lbLogger";
            this.lbLogger.Size = new System.Drawing.Size(400, 160);
            this.lbLogger.TabIndex = 4;
            // 
            // bStop
            // 
            this.bStop.Enabled = false;
            this.bStop.Location = new System.Drawing.Point(87, 32);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(70, 20);
            this.bStop.TabIndex = 6;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(241, 6);
            this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(140, 20);
            this.nudPort.TabIndex = 7;
            this.nudPort.Value = new decimal(new int[] {
            5555,
            0,
            0,
            0});
            // 
            // bwConnection
            // 
            this.bwConnection.WorkerSupportsCancellation = true;
            this.bwConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConnection_DoWork);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(11, 531);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(324, 20);
            this.tbMessage.TabIndex = 8;
            // 
            // bSend
            // 
            this.bSend.Enabled = false;
            this.bSend.Location = new System.Drawing.Point(341, 531);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(70, 20);
            this.bSend.TabIndex = 9;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // bwMessages
            // 
            this.bwMessages.WorkerSupportsCancellation = true;
            this.bwMessages.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwMessages_DoWork);
            // 
            // wbMessage
            // 
            this.wbMessage.Location = new System.Drawing.Point(11, 249);
            this.wbMessage.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMessage.Name = "wbMessage";
            this.wbMessage.Size = new System.Drawing.Size(400, 275);
            this.wbMessage.TabIndex = 10;
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.gbSettingsChat);
            this.gbSettings.Controls.Add(this.gbSettingsStyle);
            this.gbSettings.Location = new System.Drawing.Point(418, 58);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(182, 160);
            this.gbSettings.TabIndex = 11;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // gbSettingsChat
            // 
            this.gbSettingsChat.Controls.Add(this.cbSettingsUsername);
            this.gbSettingsChat.Controls.Add(this.lSettingsUsername);
            this.gbSettingsChat.Controls.Add(this.tbUsername);
            this.gbSettingsChat.Location = new System.Drawing.Point(8, 66);
            this.gbSettingsChat.Name = "gbSettingsChat";
            this.gbSettingsChat.Size = new System.Drawing.Size(168, 82);
            this.gbSettingsChat.TabIndex = 2;
            this.gbSettingsChat.TabStop = false;
            this.gbSettingsChat.Text = "Identity";
            // 
            // cbSettingsUsername
            // 
            this.cbSettingsUsername.AutoSize = true;
            this.cbSettingsUsername.Checked = true;
            this.cbSettingsUsername.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSettingsUsername.Location = new System.Drawing.Point(6, 19);
            this.cbSettingsUsername.Name = "cbSettingsUsername";
            this.cbSettingsUsername.Size = new System.Drawing.Size(111, 17);
            this.cbSettingsUsername.TabIndex = 14;
            this.cbSettingsUsername.Text = "Reveal Username";
            this.cbSettingsUsername.UseVisualStyleBackColor = true;
            // 
            // lSettingsUsername
            // 
            this.lSettingsUsername.AutoSize = true;
            this.lSettingsUsername.Location = new System.Drawing.Point(6, 39);
            this.lSettingsUsername.Name = "lSettingsUsername";
            this.lSettingsUsername.Size = new System.Drawing.Size(55, 13);
            this.lSettingsUsername.TabIndex = 13;
            this.lSettingsUsername.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(6, 55);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(156, 20);
            this.tbUsername.TabIndex = 13;
            this.tbUsername.Text = "Anon";
            // 
            // gbSettingsStyle
            // 
            this.gbSettingsStyle.Controls.Add(this.rbSettingsStyle1);
            this.gbSettingsStyle.Controls.Add(this.rbSettingsStyle0);
            this.gbSettingsStyle.Location = new System.Drawing.Point(8, 19);
            this.gbSettingsStyle.Name = "gbSettingsStyle";
            this.gbSettingsStyle.Size = new System.Drawing.Size(168, 41);
            this.gbSettingsStyle.TabIndex = 1;
            this.gbSettingsStyle.TabStop = false;
            this.gbSettingsStyle.Text = "Style";
            // 
            // rbSettingsStyle1
            // 
            this.rbSettingsStyle1.AutoSize = true;
            this.rbSettingsStyle1.Location = new System.Drawing.Point(84, 19);
            this.rbSettingsStyle1.Name = "rbSettingsStyle1";
            this.rbSettingsStyle1.Size = new System.Drawing.Size(78, 17);
            this.rbSettingsStyle1.TabIndex = 1;
            this.rbSettingsStyle1.Text = "Dark Mode";
            this.rbSettingsStyle1.UseVisualStyleBackColor = true;
            this.rbSettingsStyle1.CheckedChanged += new System.EventHandler(this.rbSettingsStyle1_CheckedChanged);
            // 
            // rbSettingsStyle0
            // 
            this.rbSettingsStyle0.AllowDrop = true;
            this.rbSettingsStyle0.AutoSize = true;
            this.rbSettingsStyle0.Checked = true;
            this.rbSettingsStyle0.Location = new System.Drawing.Point(6, 19);
            this.rbSettingsStyle0.Name = "rbSettingsStyle0";
            this.rbSettingsStyle0.Size = new System.Drawing.Size(78, 17);
            this.rbSettingsStyle0.TabIndex = 0;
            this.rbSettingsStyle0.TabStop = true;
            this.rbSettingsStyle0.Text = "Light Mode";
            this.rbSettingsStyle0.UseVisualStyleBackColor = true;
            this.rbSettingsStyle0.CheckedChanged += new System.EventHandler(this.rbSettingsStyle0_CheckedChanged);
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Location = new System.Drawing.Point(8, 233);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(71, 13);
            this.lMessage.TabIndex = 12;
            this.lMessage.Text = "Message Log";
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(11, 32);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(70, 20);
            this.bStart.TabIndex = 14;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(389, 9);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(53, 13);
            this.lPassword.TabIndex = 15;
            this.lPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(448, 6);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(140, 20);
            this.tbPassword.TabIndex = 16;
            this.tbPassword.Text = "zaq1@WSX";
            // 
            // gbStylization
            // 
            this.gbStylization.Controls.Add(this.gbUserColor);
            this.gbStylization.Controls.Add(this.gbMessageColor);
            this.gbStylization.Location = new System.Drawing.Point(418, 249);
            this.gbStylization.Name = "gbStylization";
            this.gbStylization.Size = new System.Drawing.Size(182, 282);
            this.gbStylization.TabIndex = 17;
            this.gbStylization.TabStop = false;
            this.gbStylization.Text = "Message Stylization";
            // 
            // gbUserColor
            // 
            this.gbUserColor.Controls.Add(this.lUserColorBlue);
            this.gbUserColor.Controls.Add(this.lUserColorGreen);
            this.gbUserColor.Controls.Add(this.lUserColorRed);
            this.gbUserColor.Controls.Add(this.nudUserColorBlue);
            this.gbUserColor.Controls.Add(this.nudUserColorGreen);
            this.gbUserColor.Controls.Add(this.nudUserColorRed);
            this.gbUserColor.Location = new System.Drawing.Point(12, 153);
            this.gbUserColor.Name = "gbUserColor";
            this.gbUserColor.Size = new System.Drawing.Size(164, 113);
            this.gbUserColor.TabIndex = 13;
            this.gbUserColor.TabStop = false;
            this.gbUserColor.Text = "Username Color";
            // 
            // lUserColorBlue
            // 
            this.lUserColorBlue.AutoSize = true;
            this.lUserColorBlue.Location = new System.Drawing.Point(6, 73);
            this.lUserColorBlue.Name = "lUserColorBlue";
            this.lUserColorBlue.Size = new System.Drawing.Size(28, 13);
            this.lUserColorBlue.TabIndex = 5;
            this.lUserColorBlue.Text = "Blue";
            // 
            // lUserColorGreen
            // 
            this.lUserColorGreen.AutoSize = true;
            this.lUserColorGreen.Location = new System.Drawing.Point(6, 47);
            this.lUserColorGreen.Name = "lUserColorGreen";
            this.lUserColorGreen.Size = new System.Drawing.Size(36, 13);
            this.lUserColorGreen.TabIndex = 4;
            this.lUserColorGreen.Text = "Green";
            // 
            // lUserColorRed
            // 
            this.lUserColorRed.AutoSize = true;
            this.lUserColorRed.Location = new System.Drawing.Point(6, 21);
            this.lUserColorRed.Name = "lUserColorRed";
            this.lUserColorRed.Size = new System.Drawing.Size(27, 13);
            this.lUserColorRed.TabIndex = 3;
            this.lUserColorRed.Text = "Red";
            // 
            // nudUserColorBlue
            // 
            this.nudUserColorBlue.Location = new System.Drawing.Point(63, 71);
            this.nudUserColorBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudUserColorBlue.Name = "nudUserColorBlue";
            this.nudUserColorBlue.Size = new System.Drawing.Size(95, 20);
            this.nudUserColorBlue.TabIndex = 2;
            // 
            // nudUserColorGreen
            // 
            this.nudUserColorGreen.Location = new System.Drawing.Point(63, 45);
            this.nudUserColorGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudUserColorGreen.Name = "nudUserColorGreen";
            this.nudUserColorGreen.Size = new System.Drawing.Size(95, 20);
            this.nudUserColorGreen.TabIndex = 1;
            // 
            // nudUserColorRed
            // 
            this.nudUserColorRed.Location = new System.Drawing.Point(63, 19);
            this.nudUserColorRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudUserColorRed.Name = "nudUserColorRed";
            this.nudUserColorRed.Size = new System.Drawing.Size(95, 20);
            this.nudUserColorRed.TabIndex = 0;
            // 
            // gbMessageColor
            // 
            this.gbMessageColor.Controls.Add(this.lMessageColorBlue);
            this.gbMessageColor.Controls.Add(this.lMessageColorGreen);
            this.gbMessageColor.Controls.Add(this.lMessageColorRed);
            this.gbMessageColor.Controls.Add(this.nudMessageColorBlue);
            this.gbMessageColor.Controls.Add(this.nudMessageColorGreen);
            this.gbMessageColor.Controls.Add(this.nudMessageColorRed);
            this.gbMessageColor.Location = new System.Drawing.Point(12, 34);
            this.gbMessageColor.Name = "gbMessageColor";
            this.gbMessageColor.Size = new System.Drawing.Size(164, 113);
            this.gbMessageColor.TabIndex = 12;
            this.gbMessageColor.TabStop = false;
            this.gbMessageColor.Text = "Message Color";
            // 
            // lMessageColorBlue
            // 
            this.lMessageColorBlue.AutoSize = true;
            this.lMessageColorBlue.Location = new System.Drawing.Point(6, 73);
            this.lMessageColorBlue.Name = "lMessageColorBlue";
            this.lMessageColorBlue.Size = new System.Drawing.Size(28, 13);
            this.lMessageColorBlue.TabIndex = 5;
            this.lMessageColorBlue.Text = "Blue";
            // 
            // lMessageColorGreen
            // 
            this.lMessageColorGreen.AutoSize = true;
            this.lMessageColorGreen.Location = new System.Drawing.Point(6, 47);
            this.lMessageColorGreen.Name = "lMessageColorGreen";
            this.lMessageColorGreen.Size = new System.Drawing.Size(36, 13);
            this.lMessageColorGreen.TabIndex = 4;
            this.lMessageColorGreen.Text = "Green";
            // 
            // lMessageColorRed
            // 
            this.lMessageColorRed.AutoSize = true;
            this.lMessageColorRed.Location = new System.Drawing.Point(6, 21);
            this.lMessageColorRed.Name = "lMessageColorRed";
            this.lMessageColorRed.Size = new System.Drawing.Size(27, 13);
            this.lMessageColorRed.TabIndex = 3;
            this.lMessageColorRed.Text = "Red";
            // 
            // nudMessageColorBlue
            // 
            this.nudMessageColorBlue.Location = new System.Drawing.Point(63, 71);
            this.nudMessageColorBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMessageColorBlue.Name = "nudMessageColorBlue";
            this.nudMessageColorBlue.Size = new System.Drawing.Size(95, 20);
            this.nudMessageColorBlue.TabIndex = 2;
            // 
            // nudMessageColorGreen
            // 
            this.nudMessageColorGreen.Location = new System.Drawing.Point(63, 45);
            this.nudMessageColorGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMessageColorGreen.Name = "nudMessageColorGreen";
            this.nudMessageColorGreen.Size = new System.Drawing.Size(95, 20);
            this.nudMessageColorGreen.TabIndex = 1;
            // 
            // nudMessageColorRed
            // 
            this.nudMessageColorRed.Location = new System.Drawing.Point(63, 19);
            this.nudMessageColorRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMessageColorRed.Name = "nudMessageColorRed";
            this.nudMessageColorRed.Size = new System.Drawing.Size(95, 20);
            this.nudMessageColorRed.TabIndex = 0;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 563);
            this.Controls.Add(this.gbStylization);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.wbMessage);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.nudPort);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.lbLogger);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lPort);
            this.Controls.Add(this.lAddress);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "fMain";
            this.Text = "Crab Server";
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.gbSettings.ResumeLayout(false);
            this.gbSettingsChat.ResumeLayout(false);
            this.gbSettingsChat.PerformLayout();
            this.gbSettingsStyle.ResumeLayout(false);
            this.gbSettingsStyle.PerformLayout();
            this.gbStylization.ResumeLayout(false);
            this.gbUserColor.ResumeLayout(false);
            this.gbUserColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserColorBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserColorGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserColorRed)).EndInit();
            this.gbMessageColor.ResumeLayout(false);
            this.gbMessageColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMessageColorBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMessageColorGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMessageColorRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.ListBox lbLogger;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.ComponentModel.BackgroundWorker bwConnection;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button bSend;
        private System.ComponentModel.BackgroundWorker bwMessages;
        private System.Windows.Forms.WebBrowser wbMessage;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.GroupBox gbSettingsChat;
        private System.Windows.Forms.CheckBox cbSettingsUsername;
        private System.Windows.Forms.Label lSettingsUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.GroupBox gbSettingsStyle;
        private System.Windows.Forms.RadioButton rbSettingsStyle1;
        private System.Windows.Forms.RadioButton rbSettingsStyle0;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.GroupBox gbStylization;
        private System.Windows.Forms.GroupBox gbUserColor;
        private System.Windows.Forms.Label lUserColorBlue;
        private System.Windows.Forms.Label lUserColorGreen;
        private System.Windows.Forms.Label lUserColorRed;
        private System.Windows.Forms.NumericUpDown nudUserColorBlue;
        private System.Windows.Forms.NumericUpDown nudUserColorGreen;
        private System.Windows.Forms.NumericUpDown nudUserColorRed;
        private System.Windows.Forms.GroupBox gbMessageColor;
        private System.Windows.Forms.Label lMessageColorBlue;
        private System.Windows.Forms.Label lMessageColorGreen;
        private System.Windows.Forms.Label lMessageColorRed;
        private System.Windows.Forms.NumericUpDown nudMessageColorBlue;
        private System.Windows.Forms.NumericUpDown nudMessageColorGreen;
        private System.Windows.Forms.NumericUpDown nudMessageColorRed;
    }
}

