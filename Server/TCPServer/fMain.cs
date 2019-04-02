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
        // Może się przydać:
        // https://stackoverflow.com/questions/43431196/c-sharp-tcp-ip-simple-chat-with-multiple-clients
        //

        static readonly object _lock = new object();
        static readonly Dictionary<int, TcpClient> list_clients = new Dictionary<int, TcpClient>();

        // Sprawdzone

        private TcpListener server = null;
        private TcpClient client = null;
        private BinaryWriter writing = null;
        private BinaryReader reading = null;

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
            //server.Stop();
            bwConnection.CancelAsync();
            bStart.Enabled = true;
            bStop.Enabled = false;
            bSend.Enabled = false;
        }

        private void bwConnection_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = 1;
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

                    while (true)
                    {
                        TcpClient client = server.AcceptTcpClient();
                        lock (_lock) list_clients.Add(count, client);
                        this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Someone connected!!")));

                        Thread t = new Thread(handle_clients);
                        t.Start(count);
                        count++;
                    }

                    client = server.AcceptTcpClient();
                    NetworkStream ns = client.GetStream();
                    reading = new BinaryReader(ns);
                    writing = new BinaryWriter(ns);
                    if (reading.ReadString() == tbPassword.Text)
                    {
                        bwMessages.RunWorkerAsync();
                    }
                    else
                    {
                        client.Close();
                        server.Stop();
                    }
                }
                catch
                {
                }

                IPEndPoint clientIP = (IPEndPoint)client.Client.RemoteEndPoint;
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("[" + clientIP.ToString() + "]: Client connected")));
            }
            catch
            {
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("No connections to close")));
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("")));
                this.Invoke((MethodInvoker)(() => bStart.Enabled = true));
                this.Invoke((MethodInvoker)(() => bStop.Enabled = false));
            }
            //IPAddress serverIP = null;

            //try
            //{
            //    serverIP = IPAddress.Parse(tbAddress.Text);
            //}
            //catch
            //{
            //    this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Error: Wrong IP Address format")));
            //    this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Server stopping ...")));
            //    this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("")));
            //    this.Invoke((MethodInvoker)(() => tbAddress.Text = String.Empty));
            //    this.Invoke((MethodInvoker)(() => bStart.Enabled = true));
            //    this.Invoke((MethodInvoker)(() => bStop.Enabled = false));
            //    this.Invoke((MethodInvoker)(() => bSend.Enabled = false));
            //    MessageBox.Show("Wrong IP Address format!", "Error");
            //    return;
            //}

            //ushort port = Convert.ToUInt16(nudPort.Value);

            //try
            //{
            //    server = new TcpListener(serverIP, port);
            //    try
            //    {
            //        server.Start();
            //        this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Server is listening on [" + serverIP.ToString() + ":" + port.ToString() + "]")));
            //        client = server.AcceptTcpClient();
            //        NetworkStream ns = client.GetStream();
            //        reading = new BinaryReader(ns);
            //        writing = new BinaryWriter(ns);
            //        if (reading.ReadString() == tbPassword.Text)
            //        {
            //            bwMessages.RunWorkerAsync();
            //        }
            //        else
            //        {
            //            client.Close();
            //            server.Stop();
            //        }
            //    }
            //    catch
            //    {
            //    }

            //    IPEndPoint clientIP = (IPEndPoint)client.Client.RemoteEndPoint;
            //    this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("[" + clientIP.ToString() + "]: Client connected")));
            //}
            //catch
            //{
            //    this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("No connections to close")));
            //    this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("")));
            //    this.Invoke((MethodInvoker)(() => bStart.Enabled = true));
            //    this.Invoke((MethodInvoker)(() => bStop.Enabled = false));
            //}
        }

        private void bwMessages_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string messageRecieved;
                while ((messageRecieved = reading.ReadString()) != "END")
                {
                    //messageRecieved = messageRecieved.Replace("<", "&lt;");
                    //messageRecieved = messageRecieved.Replace(">", "&gt;");
                    //this.Invoke((MethodInvoker)(() => lbLogger.Items.Add(messageRecieved)));
                    //this.Invoke((MethodInvoker)(() => wbMessage.DocumentText += "<div style=\"width: 300px; word-wrap: break-word;\">" + DateTime.Now + "<br>" + "Anon: " + messageRecieved + "<br><hr></div>"));
                    displayMessage(messageRecieved);
                }
                client.Close();
                server.Stop();
            }
            catch
            {
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("Client closed connection unexpectedly R")));
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add("")));
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
                MessageObject product = new MessageObject(tbSettingsUsername.Text, tbMessage.Text);

                string json = JsonConvert.SerializeObject(product);

                string messageSent = json; //tbMessage.Text;
                writing.Write(messageSent);
                displayMessage(messageSent);
                //wbMessage.DocumentText += "<div style=\"width: 300px; word-wrap: break-word;\">" + DateTime.Now + "<br>" + product.UName + ": " + product.Message + "<br><hr></div>";
            }
            catch (Exception ex)
            {
                lbLogger.Items.Add("");
                lbLogger.Items.Add("Client closed connection unexpectedly W");
                //lbLogger.Items.Add("Server stopped ...");
                if (client != null)
                {
                    client.Close();
                    client = null;
                }
                //server.Stop();
                bwConnection.CancelAsync();
                //bStart.Enabled = true;
                //bStop.Enabled = false;
                //bSend.Enabled = false;
                //bwConnection.RunWorkerAsync();
                MessageBox.Show(ex.ToString());
            }
        }

        private void rbSettingsStyle0_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSettingsStyle0.Checked)
            {
                this.BackColor = SystemColors.Control;
                //this.ForeColor = SystemColors.ControlText;
            }
        }

        private void rbSettingsStyle1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSettingsStyle1.Checked)
            {
                this.BackColor = SystemColors.ControlDark;
                //this.ForeColor = SystemColors.ControlLight;
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

            this.Invoke((MethodInvoker)(() => wbMessage.DocumentText += "<div style=\"width: 300px; word-wrap: break-word;\">" + DateTime.Now + "<br>" + product.uName + ": " + message + "<br><hr></div>"));
        }

        #region NWM
        public void handle_clients(object o)
        {
            int id = (int)o;
            TcpClient client;

            lock (_lock) client = list_clients[id];

            while (true)
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int byte_count = stream.Read(buffer, 0, buffer.Length);

                if (byte_count == 0)
                {
                    break;
                }

                string data = Encoding.ASCII.GetString(buffer, 0, byte_count);
                broadcast(data);
                this.Invoke((MethodInvoker)(() => lbLogger.Items.Add(data)));
            }

            lock (_lock) list_clients.Remove(id);
            client.Client.Shutdown(SocketShutdown.Both);
            client.Close();
        }

        public static void broadcast(string data)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(data + Environment.NewLine);

            lock (_lock)
            {
                foreach (TcpClient c in list_clients.Values)
                {
                    NetworkStream stream = c.GetStream();

                    stream.Write(buffer, 0, buffer.Length);
                }
            }
        }
        #endregion
    }

    internal class MessageObject
    {
        public readonly string uName;
        public readonly string uMsg;

        public MessageObject(string uname, string umsg)
        {
            uName = uname;
            uMsg = umsg;
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
