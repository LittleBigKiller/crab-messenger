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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPServer
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        #region Zmienne
        static readonly object _lock = new object();
        static readonly Dictionary<int, TcpClient> list_clients = new Dictionary<int, TcpClient>();

        IPAddress serverIP = null;
        ushort port;

        private TcpListener server = null;

        string motd = "";
        #endregion

        #region Przyciski
        private void bStart_Click(object sender, EventArgs e)
        {
            lbLogger.Items.Add("Starting server ...");
            bwConnection.RunWorkerAsync();

            bStart.Enabled = false;
            bStop.Enabled = true;
            bSend.Enabled = true;

            wbMessage.Navigate("about:blank");
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            lbLogger.Items.Add("Server stopped ...");
            foreach (KeyValuePair<int, TcpClient> entry in list_clients)
            {
                NetworkStream stream = entry.Value.GetStream();
                BinaryWriter writer = new BinaryWriter(stream);
                MessageObject product = new MessageObject("message", "[" + serverIP.ToString() + ":" + port.ToString() + "]", "Server has been shutdown", "rgb(255, 0, 0)", "rgb(255, 0, 0)");
                string json = JsonConvert.SerializeObject(product);
                string messageSent = json;
                writer.Write(messageSent);

                entry.Value.Client.Shutdown(SocketShutdown.Both);
                entry.Value.Close();
            }

            server.Stop();
            bwConnection.CancelAsync();
            bStart.Enabled = true;
            bStop.Enabled = false;
            bSend.Enabled = false;
        }
        
        private void bSend_Click(object sender, EventArgs e)
        {
            try
            {
                string uColor = "rgb(" + nudUserColorRed.Value + "," + nudUserColorGreen.Value + "," + nudUserColorBlue.Value + ")";
                string msgColor = "rgb(" + nudMessageColorRed.Value + "," + nudMessageColorGreen.Value + "," + nudMessageColorBlue.Value + ")";

                MessageObject product = new MessageObject("message", tbUsername.Text, tbMessage.Text, uColor, msgColor);

                string json = JsonConvert.SerializeObject(product);

                string messageSent = json;
                displayMessage(messageSent);
                broadcast(messageSent);
            }
            catch
            {

            }
            updateClientList();
        }
        #endregion

        #region Połączenie
        private void bwConnection_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke((MethodInvoker)(() => motd = rtbMOTD.Text));

            int count = 0;
            serverIP = null;

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

            port = Convert.ToUInt16(nudPort.Value);

            try
            {
                server = new TcpListener(serverIP, port);
                try
                {
                    server.Start();
                    this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Server is listening on [" + serverIP.ToString() + ":" + port.ToString() + "]")));

                    while (true)
                    {
                        TcpClient client = server.AcceptTcpClient();

                        BinaryReader reader = new BinaryReader(client.GetStream());

                        IPEndPoint clientIP = (IPEndPoint)client.Client.RemoteEndPoint;
                        this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("[" + clientIP.ToString() + "]: New client attempting connection ...")));

                        if (reader.ReadString() == tbPassword.Text)
                        {
                            lock (_lock) list_clients.Add(count, client);

                            this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("[" + clientIP.ToString() + "]: Client connected")));

                            NetworkStream stream = client.GetStream();
                            BinaryWriter writer = new BinaryWriter(stream);
                            MessageObject product = new MessageObject("message", "[Message of the Day]", "" + motd, "rgb(0, 127, 0)", "rgb(0, 127, 0)");
                            writer.Write(JsonConvert.SerializeObject(product));

                            Thread t = new Thread(handle_clients);
                            t.IsBackground = true;
                            t.Start(count);
                            count++;
                        }
                        else
                        {
                            this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("[" + clientIP.ToString() + "]: Incorrect password, dropping")));

                            NetworkStream stream = client.GetStream();
                            BinaryWriter writer = new BinaryWriter(stream);
                            MessageObject product = new MessageObject("message", "[" + serverIP.ToString() + ":" + port.ToString() + "]", "Invalid credentials", "rgb(255, 0, 0)", "rgb(255, 0, 0)");
                            writer.Write(JsonConvert.SerializeObject(product));

                            client.Client.Shutdown(SocketShutdown.Both);
                            client.Close();

                            this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("[" + clientIP.ToString() + "]: Client disconnected")));
                        }

                    }
                }
                catch
                {
                }
            }
            catch
            {
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("No connections to close")));
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("")));
                this.Invoke((MethodInvoker)(() => bStart.Enabled = true));
                this.Invoke((MethodInvoker)(() => bStop.Enabled = false));
            }
        }

        private void rtbMOTD_TextChanged(object sender, EventArgs e)
        {
            motd = rtbMOTD.Text;
        }
        #endregion

        #region Style
        private void rbStyleLight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStyleLight.Checked)
            {
                this.BackColor = SystemColors.Control;

                tbAddress.BackColor = SystemColors.Window;
                tbMessage.BackColor = SystemColors.Window;
                tbPassword.BackColor = SystemColors.Window;
                tbUsername.BackColor = SystemColors.Window;
                rtbMOTD.BackColor = SystemColors.Window;

                cbUserlist.BackColor = SystemColors.Window;
                lbLogger.BackColor = SystemColors.Window;

                nudMessageColorBlue.BackColor = SystemColors.Window;
                nudMessageColorGreen.BackColor = SystemColors.Window;
                nudMessageColorRed.BackColor = SystemColors.Window;

                nudPort.BackColor = SystemColors.Window;

                nudUserColorBlue.BackColor = SystemColors.Window;
                nudUserColorGreen.BackColor = SystemColors.Window;
                nudUserColorRed.BackColor = SystemColors.Window;
                
                wbMessage.Document.Body.Style = "background-color: white";
            }
        }

        private void rbStyleDark_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStyleDark.Checked)
            {
                this.BackColor = SystemColors.ControlDarkDark;

                tbAddress.BackColor = SystemColors.ControlDark;
                tbMessage.BackColor = SystemColors.ControlDark;
                tbPassword.BackColor = SystemColors.ControlDark;
                tbUsername.BackColor = SystemColors.ControlDark;
                rtbMOTD.BackColor = SystemColors.ControlDark;

                cbUserlist.BackColor = SystemColors.ControlDark;
                lbLogger.BackColor = SystemColors.ControlDark;

                nudMessageColorBlue.BackColor = SystemColors.ControlDark;
                nudMessageColorGreen.BackColor = SystemColors.ControlDark;
                nudMessageColorRed.BackColor = SystemColors.ControlDark;

                nudPort.BackColor = SystemColors.ControlDark;

                nudUserColorBlue.BackColor = SystemColors.ControlDark;
                nudUserColorGreen.BackColor = SystemColors.ControlDark;
                nudUserColorRed.BackColor = SystemColors.ControlDark;
                
                wbMessage.Document.Body.Style = "background-color: gray";
            }
        }

        private void wbMessage_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (rbStyleDark.Checked) wbMessage.Document.Body.Style = "background-color: gray";
        }
        #endregion

        #region Kickowanie
        private void updateClientList()
        {
            cbUserlist.Items.Clear();
            cbUserlist.SelectedIndex = -1;
            foreach (KeyValuePair<int, TcpClient> client in list_clients)
            {
                IPEndPoint clientIP = (IPEndPoint)client.Value.Client.RemoteEndPoint;
                cbUserlist.Items.Add("" + clientIP.ToString());
            }
        }
        
        private void cbUserlist_Click(object sender, EventArgs e)
        {
            updateClientList();
        }

        private void bKick_Click(object sender, EventArgs e)
        {
            if (cbUserlist.SelectedIndex != -1)
            {
                TcpClient client;
                List<int> keyList = list_clients.Keys.ToList();

                lock (_lock) client = list_clients[keyList[cbUserlist.SelectedIndex]];
                IPEndPoint clientIP = (IPEndPoint)client.Client.RemoteEndPoint;

                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("[" + clientIP.ToString() + "]: Kicking ...")));

                NetworkStream stream = client.GetStream();
                BinaryWriter writer = new BinaryWriter(stream);
                MessageObject product = new MessageObject("message", "[" + serverIP.ToString() + ":" + port.ToString() + "]", "You have been kicked", "rgb(255, 0, 0)", "rgb(255, 0, 0)");
                writer.Write(JsonConvert.SerializeObject(product));
                
                lock (_lock) list_clients.Remove(keyList[cbUserlist.SelectedIndex]);
                client.Client.Shutdown(SocketShutdown.Both);
                client.Close();
                updateClientList();

                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("[" + clientIP.ToString() + "]: Client disconnected")));
            }
            else
            {
                MessageBox.Show("No user selected");
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

            HtmlDocument doc = null;

            this.Invoke((MethodInvoker)(() => doc = wbMessage.Document));

            HtmlElement msgDiv = doc.CreateElement("DIV");
            msgDiv.Style = "width: 300px; word-wrap: break-word;";
            msgDiv.InnerHtml = "" + DateTime.Now +
            "<br><div  style=\"display: inline; color: " + product.uColor + "\">" +
            product.uName + ": </div><div style=\"display: inline; color: " + product.msgColor +
            "\">" + message + "</div><br><hr><script>document.body.scrollTop = document.body.scrollHeight</script>";

            this.Invoke((MethodInvoker)(() => doc.Body.AppendChild(msgDiv)));
        }

        public void handle_clients(object o)
        {
            int id = (int)o;
            TcpClient client;

            lock (_lock) client = list_clients[id];

            IPEndPoint clientIP = (IPEndPoint)client.Client.RemoteEndPoint;

            BinaryReader reader = new BinaryReader(client.GetStream());
            string messageRecieved;

            try
            {
                while ((messageRecieved = reader.ReadString()) != "END")
                {
                    this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("[" + clientIP.ToString() + "]: uName = " + JsonConvert.DeserializeObject<MessageObject>(messageRecieved).uName)));
                    try
                    {
                        displayMessage(messageRecieved);
                        broadcast(messageRecieved);
                    }
                    catch
                    {

                    }
                }
            }
            catch
            {

            }


            lock (_lock) list_clients.Remove(id);
            try
            {
                client.Client.Shutdown(SocketShutdown.Both);
                client.Close();
                
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("[" + clientIP.ToString() + "]: Client disconnected")));
            }
            catch
            {

            }
        }

        public void broadcast(string data)
        {
            lock (_lock)
            {
                foreach (TcpClient c in list_clients.Values)
                {
                    NetworkStream stream = c.GetStream();
                    BinaryWriter writer = new BinaryWriter(stream);
                    writer.Write(data);
                }
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

    internal class ClientBox
    {
        public TcpClient c;
        public Dictionary<int, TcpClient> list;

        public ClientBox(TcpClient c, Dictionary<int, TcpClient> list)
        {
            this.c = c;
            this.list = list;
        }

    }
}
