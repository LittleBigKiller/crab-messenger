﻿namespace TCPClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.lAddress = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lPort = new System.Windows.Forms.Label();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.lbLogger = new System.Windows.Forms.ListBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.bwConnection = new System.ComponentModel.BackgroundWorker();
            this.bwMessages = new System.ComponentModel.BackgroundWorker();
            this.bSend = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lPass = new System.Windows.Forms.Label();
            this.wbMessage = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbSettingsChat = new System.Windows.Forms.GroupBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.gbSettingsStyle = new System.Windows.Forms.GroupBox();
            this.rbStyleDark = new System.Windows.Forms.RadioButton();
            this.rbStyleLight = new System.Windows.Forms.RadioButton();
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
            this.pbPlaceholder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaceholder)).BeginInit();
            this.SuspendLayout();
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(8, 8);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(45, 13);
            this.lAddress.TabIndex = 0;
            this.lAddress.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(59, 5);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(108, 20);
            this.tbAddress.TabIndex = 1;
            this.tbAddress.Text = "127.0.0.1";
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(229, 8);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(26, 13);
            this.lPort.TabIndex = 2;
            this.lPort.Text = "Port";
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(261, 6);
            this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(120, 20);
            this.nudPort.TabIndex = 3;
            this.nudPort.Value = new decimal(new int[] {
            5555,
            0,
            0,
            0});
            // 
            // lbLogger
            // 
            this.lbLogger.FormattingEnabled = true;
            this.lbLogger.HorizontalScrollbar = true;
            this.lbLogger.Location = new System.Drawing.Point(11, 58);
            this.lbLogger.Name = "lbLogger";
            this.lbLogger.Size = new System.Drawing.Size(370, 173);
            this.lbLogger.TabIndex = 4;
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(11, 31);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(75, 20);
            this.bConnect.TabIndex = 5;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bDisconnect
            // 
            this.bDisconnect.Enabled = false;
            this.bDisconnect.Location = new System.Drawing.Point(92, 31);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(75, 20);
            this.bDisconnect.TabIndex = 6;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(11, 531);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(294, 20);
            this.tbMessage.TabIndex = 7;
            // 
            // bwConnection
            // 
            this.bwConnection.WorkerSupportsCancellation = true;
            this.bwConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConnection_DoWork);
            // 
            // bwMessages
            // 
            this.bwMessages.WorkerSupportsCancellation = true;
            this.bwMessages.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwMessages_DoWork);
            // 
            // bSend
            // 
            this.bSend.Enabled = false;
            this.bSend.Location = new System.Drawing.Point(311, 531);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(70, 20);
            this.bSend.TabIndex = 8;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(261, 32);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(120, 20);
            this.tbPassword.TabIndex = 14;
            this.tbPassword.Text = "zaq1@WSX";
            // 
            // lPass
            // 
            this.lPass.AutoSize = true;
            this.lPass.Location = new System.Drawing.Point(202, 35);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(53, 13);
            this.lPass.TabIndex = 15;
            this.lPass.Text = "Password";
            // 
            // wbMessage
            // 
            this.wbMessage.Location = new System.Drawing.Point(11, 242);
            this.wbMessage.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMessage.Name = "wbMessage";
            this.wbMessage.Size = new System.Drawing.Size(370, 282);
            this.wbMessage.TabIndex = 9;
            this.wbMessage.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            this.wbMessage.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbMessage_DocumentCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbSettingsChat);
            this.groupBox1.Controls.Add(this.gbSettingsStyle);
            this.groupBox1.Location = new System.Drawing.Point(387, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 77);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // gbSettingsChat
            // 
            this.gbSettingsChat.Controls.Add(this.tbUsername);
            this.gbSettingsChat.Location = new System.Drawing.Point(69, 13);
            this.gbSettingsChat.Name = "gbSettingsChat";
            this.gbSettingsChat.Size = new System.Drawing.Size(107, 57);
            this.gbSettingsChat.TabIndex = 2;
            this.gbSettingsChat.TabStop = false;
            this.gbSettingsChat.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(6, 19);
            this.tbUsername.MaxLength = 15;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(95, 20);
            this.tbUsername.TabIndex = 13;
            this.tbUsername.Text = "Anon";
            // 
            // gbSettingsStyle
            // 
            this.gbSettingsStyle.Controls.Add(this.rbStyleDark);
            this.gbSettingsStyle.Controls.Add(this.rbStyleLight);
            this.gbSettingsStyle.Location = new System.Drawing.Point(8, 13);
            this.gbSettingsStyle.Name = "gbSettingsStyle";
            this.gbSettingsStyle.Size = new System.Drawing.Size(55, 57);
            this.gbSettingsStyle.TabIndex = 1;
            this.gbSettingsStyle.TabStop = false;
            this.gbSettingsStyle.Text = "Style";
            // 
            // rbStyleDark
            // 
            this.rbStyleDark.AutoSize = true;
            this.rbStyleDark.Location = new System.Drawing.Point(6, 34);
            this.rbStyleDark.Name = "rbStyleDark";
            this.rbStyleDark.Size = new System.Drawing.Size(48, 17);
            this.rbStyleDark.TabIndex = 1;
            this.rbStyleDark.Text = "Dark";
            this.rbStyleDark.UseVisualStyleBackColor = true;
            this.rbStyleDark.CheckedChanged += new System.EventHandler(this.rbStyleDark_CheckedChanged);
            // 
            // rbStyleLight
            // 
            this.rbStyleLight.AllowDrop = true;
            this.rbStyleLight.AutoSize = true;
            this.rbStyleLight.Checked = true;
            this.rbStyleLight.Location = new System.Drawing.Point(6, 17);
            this.rbStyleLight.Name = "rbStyleLight";
            this.rbStyleLight.Size = new System.Drawing.Size(48, 17);
            this.rbStyleLight.TabIndex = 0;
            this.rbStyleLight.TabStop = true;
            this.rbStyleLight.Text = "Light";
            this.rbStyleLight.UseVisualStyleBackColor = true;
            this.rbStyleLight.CheckedChanged += new System.EventHandler(this.rbStyleLight_CheckedChanged);
            // 
            // gbStylization
            // 
            this.gbStylization.Controls.Add(this.gbUserColor);
            this.gbStylization.Controls.Add(this.gbMessageColor);
            this.gbStylization.Location = new System.Drawing.Point(387, 325);
            this.gbStylization.Name = "gbStylization";
            this.gbStylization.Size = new System.Drawing.Size(182, 226);
            this.gbStylization.TabIndex = 19;
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
            this.gbUserColor.Location = new System.Drawing.Point(6, 122);
            this.gbUserColor.Name = "gbUserColor";
            this.gbUserColor.Size = new System.Drawing.Size(164, 98);
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
            this.nudUserColorBlue.Location = new System.Drawing.Point(69, 71);
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
            this.nudUserColorGreen.Location = new System.Drawing.Point(69, 45);
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
            this.nudUserColorRed.Location = new System.Drawing.Point(69, 19);
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
            this.gbMessageColor.Location = new System.Drawing.Point(6, 16);
            this.gbMessageColor.Name = "gbMessageColor";
            this.gbMessageColor.Size = new System.Drawing.Size(170, 100);
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
            this.nudMessageColorBlue.Location = new System.Drawing.Point(69, 71);
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
            this.nudMessageColorGreen.Location = new System.Drawing.Point(69, 45);
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
            this.nudMessageColorRed.Location = new System.Drawing.Point(69, 19);
            this.nudMessageColorRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMessageColorRed.Name = "nudMessageColorRed";
            this.nudMessageColorRed.Size = new System.Drawing.Size(95, 20);
            this.nudMessageColorRed.TabIndex = 0;
            // 
            // pbPlaceholder
            // 
            this.pbPlaceholder.ImageLocation = "https://cdn.discordapp.com/attachments/414841066727145472/563471532790382592/5641" +
    "4077_405962553558971_3543614315762286592_n.jpg";
            this.pbPlaceholder.Location = new System.Drawing.Point(387, 6);
            this.pbPlaceholder.Name = "pbPlaceholder";
            this.pbPlaceholder.Size = new System.Drawing.Size(182, 225);
            this.pbPlaceholder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlaceholder.TabIndex = 20;
            this.pbPlaceholder.TabStop = false;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.pbPlaceholder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbStylization);
            this.Controls.Add(this.lPass);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.wbMessage);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.bDisconnect);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.lbLogger);
            this.Controls.Add(this.nudPort);
            this.Controls.Add(this.lPort);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "fMain";
            this.Text = "Crab Client";
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaceholder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.ListBox lbLogger;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bDisconnect;
        private System.Windows.Forms.TextBox tbMessage;
        private System.ComponentModel.BackgroundWorker bwConnection;
        private System.ComponentModel.BackgroundWorker bwMessages;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lPass;
        private System.Windows.Forms.WebBrowser wbMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbSettingsChat;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.GroupBox gbSettingsStyle;
        private System.Windows.Forms.RadioButton rbStyleDark;
        private System.Windows.Forms.RadioButton rbStyleLight;
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
        private System.Windows.Forms.PictureBox pbPlaceholder;
    }
}

