using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPServer
{
    public partial class fMain : Form
    {
        private TcpListener server = null;
        private TcpClient client = null;
        private BinaryWriter writing = null;
        private BinaryReader reading = null;
        private bool activeCall = false;

        public fMain()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            lbLogger.Items.Add("Starting server ...");
            bwConnection.RunWorkerAsync();
            bStart.Enabled = false;
            bStop.Enabled = true;
            bSend.Enabled = true;
            wbMessage.DocumentText = "";
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            lbLogger.Items.Add("Server stopped ...");
            if (client != null)
            {
                client.Close();
                client = null;
                lbLogger.Items.Add("Closed all connections");
            }
            server.Stop();
            bwConnection.CancelAsync();
            bStart.Enabled = true;
            bStop.Enabled = false;
            bSend.Enabled = false;
        }

        private void bwConnection_DoWork(object sender, DoWorkEventArgs e)
        {
            IPAddress serverIP = null;

            try
            {
                serverIP = IPAddress.Parse(tbAddress.Text);
            }
            catch
            {
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Error: Wrong IP Address format")));
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Server stopping ...")));
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("")));
                this.Invoke((MethodInvoker)(() => tbAddress.Text = String.Empty));
                this.Invoke((MethodInvoker)(() => bStart.Enabled = true));
                this.Invoke((MethodInvoker)(() => bStop.Enabled = false));
                this.Invoke((MethodInvoker)(() => bSend.Enabled = false));
                MessageBox.Show("Wrong IP Address format!", "Error");
                return;
            }

            ushort port = Convert.ToUInt16(nudPort.Value);

            try
            {
                server = new TcpListener(serverIP, port);
                try
                {
                    server.Start();
                    this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Server is listening on [" + serverIP.ToString() + ":" + port.ToString() + "]")));
                    client = server.AcceptTcpClient();
                    NetworkStream ns = client.GetStream();
                    reading = new BinaryReader(ns);
                    writing = new BinaryWriter(ns);
                    if (reading.ReadString() == "password")
                    {
                        bwMessages.RunWorkerAsync();
                        activeCall = true;
                    }
                    else
                    {
                        client.Close();
                        server.Stop();
                        activeCall = false;
                    }
                }
                catch
                {
                    activeCall = false;
                }

                IPEndPoint clientIP = (IPEndPoint)client.Client.RemoteEndPoint;
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("[" + clientIP.ToString() + "]: Client connected")));

                //this.Invoke((MethodInvoker)(() => bStart.Enabled = false));
                //this.Invoke((MethodInvoker)(() => bStop.Enabled = true));
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("No connections to close")));
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("")));
                this.Invoke((MethodInvoker)(() => bStart.Enabled = true));
                this.Invoke((MethodInvoker)(() => bStop.Enabled = false));
            }
        }

        private void bwMessages_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string messageRecieved;
                while ((messageRecieved = reading.ReadString()) != "END")
                {
                    this.Invoke((MethodInvoker)(() => lbLogger.Items.Add(messageRecieved)));
                    this.Invoke((MethodInvoker)(() => wbMessage.DocumentText += DateTime.Now + "<br>" + "Anon: " + messageRecieved + "<br><hr>"));
                }
                client.Close();
                server.Stop();
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Client closed connection unexpectedly")));
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("")));
                this.Invoke((MethodInvoker)(() => bStart.Enabled = true));
                this.Invoke((MethodInvoker)(() => bStop.Enabled = false));
                this.Invoke((MethodInvoker)(() => bSend.Enabled = false));
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Server stopped ...")));
                if (client != null)
                {
                    this.Invoke((MethodInvoker)(() => client.Close()));
                    this.Invoke((MethodInvoker)(() => client = null));
                    this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Closed all connections")));
                }
                this.Invoke((MethodInvoker)(() => server.Stop()));
                this.Invoke((MethodInvoker)(() => bwConnection.CancelAsync()));
                this.Invoke((MethodInvoker)(() => bStart.Enabled = true));
                this.Invoke((MethodInvoker)(() => bStop.Enabled = false));
                this.Invoke((MethodInvoker)(() => bSend.Enabled = false));
            }
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            try
            {
                string messageSent = tbMessage.Text;
                writing.Write(messageSent);
                wbMessage.DocumentText += DateTime.Now + "<br>" + "Me: " + messageSent + "<br><hr>";
            }
            catch
            {
                lbLogger.Items.Add("");
                lbLogger.Items.Add("Client closed connection unexpectedly");
                lbLogger.Items.Add("Server stopped ...");
                if (client != null)
                {
                    client.Close();
                    client = null;
                }
                server.Stop();
                bwConnection.CancelAsync();
                bStart.Enabled = true;
                bStop.Enabled = false;
                bSend.Enabled = false;
            }
        }

        private void rbSettingsStyle0_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSettingsStyle0.Checked)
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = SystemColors.ControlText;
            }
        }

        private void rbSettingsStyle1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSettingsStyle1.Checked)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                this.ForeColor = SystemColors.ControlLight;
            }
        }
    }
}
