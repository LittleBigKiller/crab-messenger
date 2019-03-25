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
            this.lAddress = new System.Windows.Forms.Label();
            this.lPort = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbLogger = new System.Windows.Forms.ListBox();
            this.bStart = new System.Windows.Forms.Button();
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
            this.tbSettingsUsername = new System.Windows.Forms.TextBox();
            this.gbSettingsStyle = new System.Windows.Forms.GroupBox();
            this.rbSettingsStyle1 = new System.Windows.Forms.RadioButton();
            this.rbSettingsStyle0 = new System.Windows.Forms.RadioButton();
            this.lMessage = new System.Windows.Forms.Label();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.gbSettings.SuspendLayout();
            this.gbSettingsChat.SuspendLayout();
            this.gbSettingsStyle.SuspendLayout();
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
            this.lPort.Location = new System.Drawing.Point(239, 8);
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
            // 
            // lbLogger
            // 
            this.lbLogger.FormattingEnabled = true;
            this.lbLogger.Location = new System.Drawing.Point(11, 58);
            this.lbLogger.Name = "lbLogger";
            this.lbLogger.Size = new System.Drawing.Size(400, 160);
            this.lbLogger.TabIndex = 4;
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bStart.Location = new System.Drawing.Point(12, 32);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(70, 20);
            this.bStart.TabIndex = 5;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
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
            this.nudPort.Location = new System.Drawing.Point(271, 6);
            this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(140, 20);
            this.nudPort.TabIndex = 7;
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
            this.gbSettingsChat.Controls.Add(this.tbSettingsUsername);
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
            // tbSettingsUsername
            // 
            this.tbSettingsUsername.Location = new System.Drawing.Point(6, 55);
            this.tbSettingsUsername.Name = "tbSettingsUsername";
            this.tbSettingsUsername.Size = new System.Drawing.Size(156, 20);
            this.tbSettingsUsername.TabIndex = 13;
            this.tbSettingsUsername.Text = "Anon";
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
            this.rbSettingsStyle1.Location = new System.Drawing.Point(90, 18);
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
            // gbMessage
            // 
            this.gbMessage.Location = new System.Drawing.Point(418, 249);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(182, 302);
            this.gbMessage.TabIndex = 13;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Message Stylization";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(606, 563);
            this.Controls.Add(this.gbMessage);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.wbMessage);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.nudPort);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.ListBox lbLogger;
        private System.Windows.Forms.Button bStart;
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
        private System.Windows.Forms.TextBox tbSettingsUsername;
        private System.Windows.Forms.GroupBox gbSettingsStyle;
        private System.Windows.Forms.RadioButton rbSettingsStyle1;
        private System.Windows.Forms.RadioButton rbSettingsStyle0;
        private System.Windows.Forms.GroupBox gbMessage;
    }
}

