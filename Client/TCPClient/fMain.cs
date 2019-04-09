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
        public fMain()
        {
            InitializeComponent();
        }

        #region Zmienne
        private TcpClient client = null;
        private BinaryWriter writing = null;
        private BinaryReader reading = null;
        #endregion

        #region Przyciski
        private void bConnect_Click(object sender, EventArgs e)
        {
            lbLogger.Items.Add("Attempting connection ...");
            bwConnection.RunWorkerAsync();
            wbMessage.DocumentText = "<body>";
            bConnect.Enabled = false;
        }

        private void bDisconnect_Click(object sender, EventArgs e)
        {
            NetworkStream stream = client.GetStream();
            BinaryWriter writer = new BinaryWriter(stream);
            MessageObject product = new MessageObject("message", "[NOTICE]", "Disconnected from server", "rgb(255, 0, 0)", "rgb(255, 0, 0)");
            string json = JsonConvert.SerializeObject(product);
            string messageSent = json;
            displayMessage(messageSent);

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

        private void bSend_Click(object sender, EventArgs e)
        {
            string uColor = "rgb(" + nudUserColorRed.Value + "," + nudUserColorGreen.Value + "," + nudUserColorBlue.Value + ")";
            string msgColor = "rgb(" + nudMessageColorRed.Value + "," + nudMessageColorGreen.Value + "," + nudMessageColorBlue.Value + ")";

            MessageObject product = new MessageObject("message", tbUsername.Text, tbMessage.Text, uColor, msgColor);

            string json = JsonConvert.SerializeObject(product);

            string messageSent = json;
            writing.Write(messageSent);
        }
        #endregion

        #region Połączenie
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
                bwMessages.RunWorkerAsync();
                this.Invoke((MethodInvoker)(() => bConnect.Enabled = false));
                this.Invoke((MethodInvoker)(() => bDisconnect.Enabled = true));
                this.Invoke((MethodInvoker)(() => bSend.Enabled = true));
            }
            catch
            {
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Failed to connect!")));
                this.Invoke((MethodInvoker)(() => bConnect.Enabled = true));
                this.Invoke((MethodInvoker)(() => bDisconnect.Enabled = false));
                this.Invoke((MethodInvoker)(() => bSend.Enabled = false));
            }
        }
        #endregion

        #region Style
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
        #endregion

        #region Komunikacja
        private void displayMessage(string messageBlock)
        {
            MessageObject product = JsonConvert.DeserializeObject<MessageObject>(messageBlock);

            string message = product.uMsg;
            message = message.Replace("<", "&lt;");
            message = message.Replace(">", "&gt;");

            message = CommonMarkConverter.Convert(message);

            message = message.Replace("<p>", "");
            message = message.Replace("</p>", "");
            message = message.Replace("<img", "<img style=\"width: 300px\"");

            this.Invoke((MethodInvoker)(() => wbMessage.DocumentText +=
            "<div style=\"width: 300px; word-wrap: break-word;\">" + DateTime.Now +
            "<br><div  style=\"display: inline; color: " + product.uColor + "\">" +
            product.uName + ": </div><div style=\"display: inline; color: " + product.msgColor +
            "\">"   + message + "</div><br><hr></div><script>document.body.scrollTop = document.body.scrollHeight</script>"));
        }

        private void bwMessages_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string messageRecieved;
                while ((messageRecieved = reading.ReadString()) != "END")
                {
                    displayMessage(messageRecieved);
                }
                client.Close();
                bwConnection.CancelAsync();
                this.Invoke((MethodInvoker)(() => bConnect.Enabled = true));
                this.Invoke((MethodInvoker)(() => bDisconnect.Enabled = false));
                this.Invoke((MethodInvoker)(() => bSend.Enabled = false));
            }
            catch
            {
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Connection closed")));
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("")));
                this.Invoke((MethodInvoker)(() => bConnect.Enabled = true));
                this.Invoke((MethodInvoker)(() => bDisconnect.Enabled = false));
                this.Invoke((MethodInvoker)(() => bSend.Enabled = false));
            }
        }
        #endregion
    }

    internal class MessageObject
    {
        public readonly string msgType;
        public readonly string uName;
        public readonly string uMsg;
        public readonly string msgColor;
        public readonly string uColor;

        public MessageObject(string msgtype, string uname, string umsg, string ucolor, string msgcolor)
        {
            msgType = msgtype;
            uName = uname;
            uMsg = umsg;
            msgColor = msgcolor;
            uColor = ucolor;
        }
    }
}
