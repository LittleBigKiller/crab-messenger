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
            this.btItalic = new System.Windows.Forms.Button();
            this.btBold = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.SuspendLayout();
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(12, 8);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(45, 13);
            this.lAddress.TabIndex = 0;
            this.lAddress.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(63, 5);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 1;
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(267, 9);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(26, 13);
            this.lPort.TabIndex = 2;
            this.lPort.Text = "Port";
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(299, 6);
            this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(120, 20);
            this.nudPort.TabIndex = 3;
            // 
            // lbLogger
            // 
            this.lbLogger.FormattingEnabled = true;
            this.lbLogger.Location = new System.Drawing.Point(12, 31);
            this.lbLogger.Name = "lbLogger";
            this.lbLogger.Size = new System.Drawing.Size(407, 43);
            this.lbLogger.TabIndex = 4;
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(15, 301);
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
            this.bDisconnect.Location = new System.Drawing.Point(96, 301);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(75, 20);
            this.bDisconnect.TabIndex = 6;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(15, 275);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(249, 20);
            this.tbMessage.TabIndex = 7;
            // 
            // bSend
            // 
            this.bSend.Enabled = false;
            this.bSend.Location = new System.Drawing.Point(344, 275);
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
            this.wbMessage.Location = new System.Drawing.Point(12, 80);
            this.wbMessage.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMessage.Name = "wbMessage";
            this.wbMessage.Size = new System.Drawing.Size(407, 189);
            this.wbMessage.TabIndex = 9;
            // 
            // btItalic
            // 
            this.btItalic.Location = new System.Drawing.Point(270, 275);
            this.btItalic.Name = "btItalic";
            this.btItalic.Size = new System.Drawing.Size(31, 20);
            this.btItalic.TabIndex = 10;
            this.btItalic.Text = "I";
            this.btItalic.UseVisualStyleBackColor = true;
            this.btItalic.Click += new System.EventHandler(this.btItalic_Click);
            // 
            // btBold
            // 
            this.btBold.Location = new System.Drawing.Point(307, 275);
            this.btBold.Name = "btBold";
            this.btBold.Size = new System.Drawing.Size(31, 20);
            this.btBold.TabIndex = 11;
            this.btBold.Text = "B";
            this.btBold.UseVisualStyleBackColor = true;
            this.btBold.Click += new System.EventHandler(this.btBold_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 327);
            this.Controls.Add(this.btBold);
            this.Controls.Add(this.btItalic);
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
        private System.Windows.Forms.Button btItalic;
        private System.Windows.Forms.Button btBold;
    }
}

