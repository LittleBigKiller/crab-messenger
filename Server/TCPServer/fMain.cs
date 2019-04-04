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
        static readonly object _lock = new object();
        static readonly Dictionary<int, TcpClient> list_clients = new Dictionary<int, TcpClient>();
        IPAddress serverIP = null;
        ushort port;

        private TcpListener server = null;

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
            wbMessage.DocumentText = "<body>";
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            lbLogger.Items.Add("Server stopped ...");
            foreach (KeyValuePair<int, TcpClient> entry in list_clients)
            {
                entry.Value.Client.Shutdown(SocketShutdown.Both);
                entry.Value.Close();
            }

            server.Stop();
            bwConnection.CancelAsync();
            bStart.Enabled = true;
            bStop.Enabled = false;
            bSend.Enabled = false;
        }

        private void bwConnection_DoWork(object sender, DoWorkEventArgs e)
        {
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
                        this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("[" + clientIP.ToString() + "]: Attempting connection ...")));

                        if (reader.ReadString() == tbPassword.Text)
                        {
                            lock (_lock) list_clients.Add(count, client);
                            
                            this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("[" + clientIP.ToString() + "]: Client connected")));

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

                            string json = JsonConvert.SerializeObject(product);

                            string messageSent = json;
                            writer.Write(messageSent);

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
            catch //(Exception ex)
            {
                //lbLogger.Items.Add("");
                //lbLogger.Items.Add("Client closed connection unexpectedly W");
                //if (client != null)
                //{
                //    client.Close();
                //    client = null;
                //}
                //server.Stop();
                //bwConnection.CancelAsync();
                //bStart.Enabled = true;
                //bStop.Enabled = false;
                //bSend.Enabled = false;
                //bwConnection.RunWorkerAsync();
                //MessageBox.Show(ex.ToString());
            }
            updateClientList();
        }

        private void rbSettingsStyle0_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSettingsStyle0.Checked)
            {
                this.BackColor = SystemColors.Control;
            }
        }

        private void rbSettingsStyle1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSettingsStyle1.Checked)
            {
                this.BackColor = SystemColors.ControlDark;
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
            message = message.Replace("<img", "<img style=\"width: 300px\"");
            this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("message = " + message)));

            this.Invoke((MethodInvoker)(() => wbMessage.DocumentText +=
            "<div style=\"width: 300px; word-wrap: break-word;\">" + DateTime.Now +
            "<br><div  style=\"display: inline; color: " + product.uColor + "\">" +
            product.uName + ": </div><div style=\"display: inline; color: " + product.msgColor +
            "\">" + message + "</div><br><hr></div>"));

            System.Threading.Thread.Sleep(10);
            Invoke((MethodInvoker)(() => wbMessage.Document.Window.ScrollTo(0, wbMessage.Document.Body.ScrollRectangle.Height)));
        }

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
                lock (_lock) client = list_clients[cbUserlist.SelectedIndex];
                IPEndPoint clientIP = (IPEndPoint)client.Client.RemoteEndPoint;

                MessageBox.Show("" + client.Client.RemoteEndPoint.ToString(), "" + cbUserlist.SelectedIndex);

                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("[" + clientIP.ToString() + "]: Kicking ...")));
                NetworkStream stream = client.GetStream();
                BinaryWriter writer = new BinaryWriter(stream);
                MessageObject product = new MessageObject("message", "[" + serverIP.ToString() + ":" + port.ToString() + "]", "You have been kicked", "rgb(255, 0, 0)", "rgb(255, 0, 0)");

                string json = JsonConvert.SerializeObject(product);

                string messageSent = json;
                writer.Write(messageSent);

                lock (_lock) list_clients.Remove(cbUserlist.SelectedIndex);
                client.Client.Shutdown(SocketShutdown.Both);
                client.Close();

                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("[" + clientIP.ToString() + "]: Client disconnected")));
            }
            else
            {
                MessageBox.Show("No user selected");
            }
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
                        //this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Message dropped")));
                    }
                }
            }
            catch
            {
                //this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Client closed connection unexpectedly R")));
            }


            lock (_lock) list_clients.Remove(id);
            try // Mogą być już usunięte
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
    }
    internal class MessageObject
    {
        public readonly string msgType;
        public readonly string uName;
        public readonly string uMsg;
        public readonly string msgColor;
        public readonly string uColor;

        public MessageObject(string msgtype, string uname, string umsg, string msgcolor, string ucolor)
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
