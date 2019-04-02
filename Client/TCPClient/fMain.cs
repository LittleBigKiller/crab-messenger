using CommonMark;
using Newtonsoft.Json;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient
{
    public partial class fMain : Form
    {
        private TcpClient client = null;
        private BinaryWriter writing = null;
        private BinaryReader reading = null;
        private bool activeCall = false;

        public fMain()
        {
            InitializeComponent();
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            lbLogger.Items.Add("Attempting connection ...");
            //if (bwConnection.IsBusy)
            //{
                
                bwConnection.RunWorkerAsync();
           // }
        }

        private void bDisconnect_Click(object sender, EventArgs e)
        {
            lbLogger.Items.Add("Closing connection ...");
            if (client != null)
            {
                client.Close();
                client = null;
                lbLogger.Items.Add("Closed connection");
            }
            bwConnection.CancelAsync();
            bConnect.Enabled = true;
            bDisconnect.Enabled = false;
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
                MessageBox.Show("Wrong IP Address format!", "Error");
                this.Invoke((MethodInvoker)(() => tbAddress.Text = String.Empty));
                this.Invoke((MethodInvoker)(() => bConnect.Enabled = true));
                this.Invoke((MethodInvoker)(() => bDisconnect.Enabled = false));
                this.Invoke((MethodInvoker)(() => bSend.Enabled = false));
                return;
            }

            ushort port = Convert.ToUInt16(nudPort.Value);

            try
            {
                client = new TcpClient(serverIP.ToString(), port); 
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Connected to [" + serverIP.ToString() + ":" + port + "]")));
                NetworkStream ns = client.GetStream();
                reading = new BinaryReader(ns);
                writing = new BinaryWriter(ns);
                writing.Write(tbPass.Text);
                activeCall = true;
                bwMessages.RunWorkerAsync();
                this.Invoke((MethodInvoker)(() => bConnect.Enabled = false));
                this.Invoke((MethodInvoker)(() => bDisconnect.Enabled = true));
                this.Invoke((MethodInvoker)(() => bSend.Enabled = true));
            }
            catch (Exception ex)
            {
                activeCall = false;
            }

            if(!activeCall)
            {
                this.Invoke((MethodInvoker)(() => bConnect.Enabled = true));
                this.Invoke((MethodInvoker)(() => bDisconnect.Enabled = false));
                this.Invoke((MethodInvoker)(() => bSend.Enabled = false));
            }
        }

        private void bwMessages_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string messageRecieved;
                while ((messageRecieved = reading.ReadString()) != "END")
                {
                    //this.Invoke((MethodInvoker)(() => wbMessage.DocumentText += "<div style=\"width:350px; word-wrap:break-word;\">" + DateTime.Now + "<br>" + "Anon: " + messageRecieved + "<br><hr></div>"));
                    //this.Invoke((MethodInvoker)(() => lbLogger.Items.Add(messageRecieved)));
                    displayMessage(messageRecieved);
                }
                client.Close();
                bwConnection.CancelAsync();
                this.Invoke((MethodInvoker)(() => bConnect.Enabled = true));
                this.Invoke((MethodInvoker)(() => bDisconnect.Enabled = false));
                this.Invoke((MethodInvoker)(() => bSend.Enabled = false));
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Connection closed unexpectedly")));
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("")));
                this.Invoke((MethodInvoker)(() => bConnect.Enabled = true));
                this.Invoke((MethodInvoker)(() => bDisconnect.Enabled = false));
                this.Invoke((MethodInvoker)(() => bSend.Enabled = false));
            }
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            string uColor = nudUserColorRed.Value + "," + nudUserColorGreen.Value + "," + nudUserColorBlue.Value;
            string msgColor = nudMessageColorRed.Value + "," + nudMessageColorGreen.Value + "," + nudMessageColorBlue.Value;

            MessageObject product = new MessageObject(tbUsername.Text, tbMessage.Text, uColor, msgColor);

            string json = JsonConvert.SerializeObject(product);

            string messageSent = json; //tbMessage.Text;
            writing.Write(messageSent);
            displayMessage(messageSent);
        }

        private void btBold_Click(object sender, EventArgs e)
        {
            tbMessage.Text += "<b></b>";
        }

        private void btItalic_Click(object sender, EventArgs e)
        {
            tbMessage.Text += "<i></i>";
        }

        private void rbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDark.Checked)
            {
                this.BackColor = SystemColors.ControlDark;
            }
        }

        private void rbLight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLight.Checked)
            {
                this.BackColor = SystemColors.Control;
            }
        }

        private void displayMessage(string messageBlock)
        {
            this.Invoke((MethodInvoker)(() => lbLogger.Items.Add(messageBlock)));
            MessageObject product = JsonConvert.DeserializeObject<MessageObject>(messageBlock);
            this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("UName = " + product.uName)));
            this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("UMsg = " + product.uMsg)));

            string message = product.uMsg;
            message = message.Replace("<", "&lt;");
            message = message.Replace(">", "&gt;");

            message = CommonMarkConverter.Convert(message);
            this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("message = " + message)));

            message = message.Replace("<p>", "");
            message = message.Replace("</p>", "");
            this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("message = " + message)));

            this.Invoke((MethodInvoker)(() => wbMessage.DocumentText += "<div style=\"width: 300px; word-wrap: break-word;\">" + DateTime.Now + "<br>" + product.uName + ": "   + message + "<br><hr></div>"));
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

    internal class MessageObject
    {
        public readonly string uName;
        public readonly string uMsg;
        public readonly string msgColor;
        public readonly string uColor;
        
        public MessageObject(string uname, string umsg, string msgcolor, string ucolor)
        {
            uName = uname;
            uMsg = umsg;
            msgColor = msgcolor;
            uColor = ucolor;
        }
    }
}
