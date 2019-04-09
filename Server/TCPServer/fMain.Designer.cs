namespace TCPServer
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
            this.lPort = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbLogger = new System.Windows.Forms.ListBox();
            this.bStop = new System.Windows.Forms.Button();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.bwConnection = new System.ComponentModel.BackgroundWorker();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.wbMessage = new System.Windows.Forms.WebBrowser();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.gbSettingsChat = new System.Windows.Forms.GroupBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.gbSettingsStyle = new System.Windows.Forms.GroupBox();
            this.rbStyleDark = new System.Windows.Forms.RadioButton();
            this.rbStyleLight = new System.Windows.Forms.RadioButton();
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
            this.gbKick = new System.Windows.Forms.GroupBox();
            this.bKick = new System.Windows.Forms.Button();
            this.cbUserlist = new System.Windows.Forms.ComboBox();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.gbMOTD = new System.Windows.Forms.GroupBox();
            this.rtbMOTD = new System.Windows.Forms.RichTextBox();
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
            this.gbKick.SuspendLayout();
            this.gbAdmin.SuspendLayout();
            this.gbMOTD.SuspendLayout();
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
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(241, 8);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(26, 13);
            this.lPort.TabIndex = 1;
            this.lPort.Text = "Port";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(59, 5);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(108, 20);
            this.tbAddress.TabIndex = 2;
            this.tbAddress.Text = "127.0.0.1";
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
            // bStop
            // 
            this.bStop.Enabled = false;
            this.bStop.Location = new System.Drawing.Point(92, 31);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(75, 20);
            this.bStop.TabIndex = 6;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(273, 5);
            this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(108, 20);
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
            this.tbMessage.Size = new System.Drawing.Size(294, 20);
            this.tbMessage.TabIndex = 8;
            // 
            // bSend
            // 
            this.bSend.Enabled = false;
            this.bSend.Location = new System.Drawing.Point(311, 531);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(70, 20);
            this.bSend.TabIndex = 9;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // wbMessage
            // 
            this.wbMessage.Location = new System.Drawing.Point(11, 242);
            this.wbMessage.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMessage.Name = "wbMessage";
            this.wbMessage.Size = new System.Drawing.Size(370, 282);
            this.wbMessage.TabIndex = 10;
            this.wbMessage.TabStop = false;
            this.wbMessage.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            this.wbMessage.WebBrowserShortcutsEnabled = false;
            this.wbMessage.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbMessage_DocumentCompleted);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.gbSettingsChat);
            this.gbSettings.Controls.Add(this.gbSettingsStyle);
            this.gbSettings.Location = new System.Drawing.Point(387, 242);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(182, 77);
            this.gbSettings.TabIndex = 11;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
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
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(11, 31);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 20);
            this.bStart.TabIndex = 14;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(214, 34);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(53, 13);
            this.lPassword.TabIndex = 15;
            this.lPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(273, 31);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(108, 20);
            this.tbPassword.TabIndex = 16;
            this.tbPassword.Text = "zaq1@WSX";
            // 
            // gbStylization
            // 
            this.gbStylization.Controls.Add(this.gbUserColor);
            this.gbStylization.Controls.Add(this.gbMessageColor);
            this.gbStylization.Location = new System.Drawing.Point(387, 325);
            this.gbStylization.Name = "gbStylization";
            this.gbStylization.Size = new System.Drawing.Size(182, 226);
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
            // gbKick
            // 
            this.gbKick.Controls.Add(this.bKick);
            this.gbKick.Controls.Add(this.cbUserlist);
            this.gbKick.Location = new System.Drawing.Point(6, 19);
            this.gbKick.Name = "gbKick";
            this.gbKick.Size = new System.Drawing.Size(170, 46);
            this.gbKick.TabIndex = 3;
            this.gbKick.TabStop = false;
            this.gbKick.Text = "User Management";
            // 
            // bKick
            // 
            this.bKick.Location = new System.Drawing.Point(122, 19);
            this.bKick.Name = "bKick";
            this.bKick.Size = new System.Drawing.Size(42, 21);
            this.bKick.TabIndex = 1;
            this.bKick.Text = "Kick";
            this.bKick.UseVisualStyleBackColor = true;
            this.bKick.Click += new System.EventHandler(this.bKick_Click);
            // 
            // cbUserlist
            // 
            this.cbUserlist.FormattingEnabled = true;
            this.cbUserlist.Location = new System.Drawing.Point(6, 20);
            this.cbUserlist.MaxDropDownItems = 32;
            this.cbUserlist.Name = "cbUserlist";
            this.cbUserlist.Size = new System.Drawing.Size(110, 21);
            this.cbUserlist.TabIndex = 0;
            this.cbUserlist.Click += new System.EventHandler(this.cbUserlist_Click);
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.gbMOTD);
            this.gbAdmin.Controls.Add(this.gbKick);
            this.gbAdmin.Location = new System.Drawing.Point(387, 6);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(182, 225);
            this.gbAdmin.TabIndex = 18;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Server Settings";
            // 
            // gbMOTD
            // 
            this.gbMOTD.Controls.Add(this.rtbMOTD);
            this.gbMOTD.Location = new System.Drawing.Point(8, 72);
            this.gbMOTD.Name = "gbMOTD";
            this.gbMOTD.Size = new System.Drawing.Size(168, 147);
            this.gbMOTD.TabIndex = 4;
            this.gbMOTD.TabStop = false;
            this.gbMOTD.Text = "Message of the Day";
            // 
            // rtbMOTD
            // 
            this.rtbMOTD.Location = new System.Drawing.Point(7, 20);
            this.rtbMOTD.Name = "rtbMOTD";
            this.rtbMOTD.Size = new System.Drawing.Size(155, 121);
            this.rtbMOTD.TabIndex = 0;
            this.rtbMOTD.Text = "Welcome!\nYou *managed* to connect to my **test server**.\nHave a good day";
            this.rtbMOTD.TextChanged += new System.EventHandler(this.rtbMOTD_TextChanged);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbStylization);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.bStart);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
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
            this.gbKick.ResumeLayout(false);
            this.gbAdmin.ResumeLayout(false);
            this.gbMOTD.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.GroupBox gbSettingsChat;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.GroupBox gbSettingsStyle;
        private System.Windows.Forms.RadioButton rbStyleDark;
        private System.Windows.Forms.RadioButton rbStyleLight;
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
        private System.Windows.Forms.WebBrowser wbMessage;
        private System.Windows.Forms.GroupBox gbKick;
        private System.Windows.Forms.Button bKick;
        private System.Windows.Forms.ComboBox cbUserlist;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.GroupBox gbMOTD;
        private System.Windows.Forms.RichTextBox rtbMOTD;
    }
}

