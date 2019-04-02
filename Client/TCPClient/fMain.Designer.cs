namespace TCPClient
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
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lPort = new System.Windows.Forms.Label();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.lbLogger = new System.Windows.Forms.ListBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.bwConnection = new System.ComponentModel.BackgroundWorker();
            this.bwMessages = new System.ComponentModel.BackgroundWorker();
            this.wbMessage = new System.Windows.Forms.WebBrowser();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.gbIdentity = new System.Windows.Forms.GroupBox();
            this.cbReveal = new System.Windows.Forms.CheckBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lUserName = new System.Windows.Forms.Label();
            this.gbStyle = new System.Windows.Forms.GroupBox();
            this.rbLight = new System.Windows.Forms.RadioButton();
            this.rbDark = new System.Windows.Forms.RadioButton();
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
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.gbSettings.SuspendLayout();
            this.gbIdentity.SuspendLayout();
            this.gbStyle.SuspendLayout();
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
            this.lAddress.Location = new System.Drawing.Point(9, 8);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(45, 13);
            this.lAddress.TabIndex = 0;
            this.lAddress.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(60, 5);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 1;
            this.tbAddress.Text = "127.0.0.1";
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(233, 7);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(26, 13);
            this.lPort.TabIndex = 2;
            this.lPort.Text = "Port";
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(265, 4);
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
            this.lbLogger.Location = new System.Drawing.Point(12, 57);
            this.lbLogger.Name = "lbLogger";
            this.lbLogger.Size = new System.Drawing.Size(407, 160);
            this.lbLogger.TabIndex = 4;
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(12, 31);
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
            this.bDisconnect.Location = new System.Drawing.Point(93, 31);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(75, 20);
            this.bDisconnect.TabIndex = 6;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(12, 510);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(326, 20);
            this.tbMessage.TabIndex = 7;
            // 
            // bSend
            // 
            this.bSend.Enabled = false;
            this.bSend.Location = new System.Drawing.Point(344, 509);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(75, 20);
            this.bSend.TabIndex = 8;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
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
            // wbMessage
            // 
            this.wbMessage.Location = new System.Drawing.Point(12, 248);
            this.wbMessage.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMessage.Name = "wbMessage";
            this.wbMessage.Size = new System.Drawing.Size(407, 255);
            this.wbMessage.TabIndex = 9;
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.gbIdentity);
            this.gbSettings.Controls.Add(this.gbStyle);
            this.gbSettings.Location = new System.Drawing.Point(425, 57);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(187, 160);
            this.gbSettings.TabIndex = 12;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // gbIdentity
            // 
            this.gbIdentity.Controls.Add(this.cbReveal);
            this.gbIdentity.Controls.Add(this.tbUsername);
            this.gbIdentity.Controls.Add(this.lUserName);
            this.gbIdentity.Location = new System.Drawing.Point(6, 72);
            this.gbIdentity.Name = "gbIdentity";
            this.gbIdentity.Size = new System.Drawing.Size(173, 82);
            this.gbIdentity.TabIndex = 6;
            this.gbIdentity.TabStop = false;
            this.gbIdentity.Text = "Identity";
            // 
            // cbReveal
            // 
            this.cbReveal.AutoSize = true;
            this.cbReveal.Checked = true;
            this.cbReveal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbReveal.Location = new System.Drawing.Point(6, 19);
            this.cbReveal.Name = "cbReveal";
            this.cbReveal.Size = new System.Drawing.Size(111, 17);
            this.cbReveal.TabIndex = 2;
            this.cbReveal.Text = "Reveal Username";
            this.cbReveal.UseVisualStyleBackColor = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(6, 55);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(161, 20);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.Text = "Anone";
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Location = new System.Drawing.Point(3, 39);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(58, 13);
            this.lUserName.TabIndex = 1;
            this.lUserName.Text = "Username:";
            // 
            // gbStyle
            // 
            this.gbStyle.Controls.Add(this.rbLight);
            this.gbStyle.Controls.Add(this.rbDark);
            this.gbStyle.Location = new System.Drawing.Point(6, 19);
            this.gbStyle.Name = "gbStyle";
            this.gbStyle.Size = new System.Drawing.Size(174, 47);
            this.gbStyle.TabIndex = 5;
            this.gbStyle.TabStop = false;
            this.gbStyle.Text = "Style";
            // 
            // rbLight
            // 
            this.rbLight.AutoSize = true;
            this.rbLight.Checked = true;
            this.rbLight.Location = new System.Drawing.Point(6, 19);
            this.rbLight.Name = "rbLight";
            this.rbLight.Size = new System.Drawing.Size(78, 17);
            this.rbLight.TabIndex = 3;
            this.rbLight.TabStop = true;
            this.rbLight.Text = "Light Mode";
            this.rbLight.UseVisualStyleBackColor = true;
            this.rbLight.CheckedChanged += new System.EventHandler(this.rbLight_CheckedChanged);
            // 
            // rbDark
            // 
            this.rbDark.AutoSize = true;
            this.rbDark.Location = new System.Drawing.Point(90, 19);
            this.rbDark.Name = "rbDark";
            this.rbDark.Size = new System.Drawing.Size(78, 17);
            this.rbDark.TabIndex = 4;
            this.rbDark.TabStop = true;
            this.rbDark.Text = "Dark Mode";
            this.rbDark.UseVisualStyleBackColor = true;
            this.rbDark.CheckedChanged += new System.EventHandler(this.rbDark_CheckedChanged);
            // 
            // gbStylization
            // 
            this.gbStylization.Controls.Add(this.gbUserColor);
            this.gbStylization.Controls.Add(this.gbMessageColor);
            this.gbStylization.Location = new System.Drawing.Point(425, 248);
            this.gbStylization.Name = "gbStylization";
            this.gbStylization.Size = new System.Drawing.Size(187, 282);
            this.gbStylization.TabIndex = 13;
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
            this.gbUserColor.Size = new System.Drawing.Size(168, 113);
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
            this.nudUserColorBlue.Location = new System.Drawing.Point(67, 71);
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
            this.nudUserColorGreen.Location = new System.Drawing.Point(67, 45);
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
            this.nudUserColorRed.Location = new System.Drawing.Point(67, 19);
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
            this.gbMessageColor.Size = new System.Drawing.Size(168, 113);
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
            this.nudMessageColorBlue.Location = new System.Drawing.Point(67, 71);
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
            this.nudMessageColorGreen.Location = new System.Drawing.Point(67, 45);
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
            this.nudMessageColorRed.Location = new System.Drawing.Point(67, 19);
            this.nudMessageColorRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMessageColorRed.Name = "nudMessageColorRed";
            this.nudMessageColorRed.Size = new System.Drawing.Size(95, 20);
            this.nudMessageColorRed.TabIndex = 0;
            this.nudMessageColorRed.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(496, 4);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(119, 20);
            this.tbPass.TabIndex = 14;
            this.tbPass.Text = "zaq1@WSX";
            // 
            // lPass
            // 
            this.lPass.AutoSize = true;
            this.lPass.Location = new System.Drawing.Point(439, 7);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(53, 13);
            this.lPass.TabIndex = 15;
            this.lPass.Text = "Password";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(627, 542);
            this.Controls.Add(this.lPass);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.gbStylization);
            this.Controls.Add(this.gbSettings);
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
            this.MinimumSize = new System.Drawing.Size(447, 345);
            this.Name = "fMain";
            this.Text = "Crab Client";
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.gbSettings.ResumeLayout(false);
            this.gbIdentity.ResumeLayout(false);
            this.gbIdentity.PerformLayout();
            this.gbStyle.ResumeLayout(false);
            this.gbStyle.PerformLayout();
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
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.ListBox lbLogger;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bDisconnect;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button bSend;
        private System.ComponentModel.BackgroundWorker bwConnection;
        private System.ComponentModel.BackgroundWorker bwMessages;
        private System.Windows.Forms.WebBrowser wbMessage;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.RadioButton rbDark;
        private System.Windows.Forms.RadioButton rbLight;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.GroupBox gbStyle;
        private System.Windows.Forms.GroupBox gbIdentity;
        private System.Windows.Forms.CheckBox cbReveal;
        private System.Windows.Forms.GroupBox gbStylization;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lPass;
        private System.Windows.Forms.GroupBox gbUserColor;
        private System.Windows.Forms.GroupBox gbMessageColor;
        private System.Windows.Forms.NumericUpDown nudUserColorBlue;
        private System.Windows.Forms.NumericUpDown nudUserColorGreen;
        private System.Windows.Forms.NumericUpDown nudUserColorRed;
        private System.Windows.Forms.NumericUpDown nudMessageColorBlue;
        private System.Windows.Forms.NumericUpDown nudMessageColorGreen;
        private System.Windows.Forms.NumericUpDown nudMessageColorRed;
        private System.Windows.Forms.Label lUserColorBlue;
        private System.Windows.Forms.Label lUserColorGreen;
        private System.Windows.Forms.Label lUserColorRed;
        private System.Windows.Forms.Label lMessageColorBlue;
        private System.Windows.Forms.Label lMessageColorGreen;
        private System.Windows.Forms.Label lMessageColorRed;
    }
}

