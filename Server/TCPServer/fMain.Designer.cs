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
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
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
            this.lPort.Location = new System.Drawing.Point(264, 9);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(26, 13);
            this.lPort.TabIndex = 1;
            this.lPort.Text = "Port";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(63, 6);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 2;
            // 
            // lbLogger
            // 
            this.lbLogger.FormattingEnabled = true;
            this.lbLogger.Location = new System.Drawing.Point(12, 32);
            this.lbLogger.Name = "lbLogger";
            this.lbLogger.Size = new System.Drawing.Size(404, 43);
            this.lbLogger.TabIndex = 4;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(12, 237);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 20);
            this.bStart.TabIndex = 5;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.Enabled = false;
            this.bStop.Location = new System.Drawing.Point(93, 237);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(75, 20);
            this.bStop.TabIndex = 6;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(296, 7);
            this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(120, 20);
            this.nudPort.TabIndex = 7;
            // 
            // bwConnection
            // 
            this.bwConnection.WorkerSupportsCancellation = true;
            this.bwConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConnection_DoWork);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(174, 237);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(161, 20);
            this.tbMessage.TabIndex = 8;
            // 
            // bSend
            // 
            this.bSend.Enabled = false;
            this.bSend.Location = new System.Drawing.Point(341, 237);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(75, 20);
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
            this.wbMessage.Location = new System.Drawing.Point(12, 82);
            this.wbMessage.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMessage.Name = "wbMessage";
            this.wbMessage.Size = new System.Drawing.Size(404, 149);
            this.wbMessage.TabIndex = 10;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 264);
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
            this.MaximumSize = new System.Drawing.Size(444, 303);
            this.MinimumSize = new System.Drawing.Size(444, 303);
            this.Name = "fMain";
            this.Text = "Crab Server";
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
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
    }
}

