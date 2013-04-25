using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace RTCH_Client
{
    public partial class frmMain : Form
    {
        #region Variables, Delegates, ...
        private TcpListener tcpListener;
        private Thread listenThread;
        private TcpClient client;

        delegate void emptyDelegate();
        delegate void valueDelegate(string value);
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        #region Interface Methods and Events
        /// <summary>
        /// Handles the TCP Connect to Server button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRunServer_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = "Connecting...";
            ((Button)sender).Enabled = false;
            TCPCommunication();
        }

        /// <summary>
        /// Handles the Send TCP Message button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTCPSend_Click(object sender, EventArgs e)
        {
            string message = txtTCPMessage.Text.Trim();
            SendTCPMessage(message);
        }

        /// <summary>
        /// Enables the TCP message panel
        /// </summary>
        private void EnableTCPPanel()
        {
            if (gbxTCP.InvokeRequired)
            {
                gbxTCP.Invoke(new emptyDelegate(EnableTCPPanel));
            }
            else
            {
                gbxTCP.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the Clear Log button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearLog_Click(object sender, EventArgs e)
        {
            rtbLog.Clear();
        }
        #endregion

        #region TCP Communication
        /// <summary>
        /// Initiates all TCP communication
        /// </summary>
        private void TCPCommunication()
        {
            Log("Creating TCP connection");
            try
            {
                this.client = new TcpClient("127.0.0.1", 3000);

                Log("Connecting to client");
                while (!client.Connected)
                {
                }

                Log("Connected to client");
                btnConnectToServer.Text = "Connected";
                EnableTCPPanel();

                this.tcpListener = new TcpListener(IPAddress.Any, 3000);
                this.listenThread = new Thread(new ThreadStart(ListenForClients));
                this.listenThread.IsBackground = true;
                this.listenThread.Start();
            }
            catch (Exception)
            {
                btnConnectToServer.Text = "Connect to Server";
                btnConnectToServer.Enabled = true;
                Log("Could not connect to server application");
                return;
            }
        }

        /// <summary>
        /// Sends a message through TCP
        /// </summary>
        /// <param name="Message"></param>
        private void SendTCPMessage(string Message)
        {
            Log(string.Format("Sending message '{0}' to TCP client", Message));

            NetworkStream clientStream = this.client.GetStream();
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] buffer = encoder.GetBytes(Message);

            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
        }

        /// <summary>
        /// Listens for clients
        /// </summary>
        private void ListenForClients()
        {
            //create a thread to handle communication 
            Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
            clientThread.Start(this.client);
        }

        /// <summary>
        /// Handles the client TCP communication
        /// </summary>
        /// <param name="client"></param>
        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    //blocks until a client sends a message
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    //a socket error has occured
                    break;
                }

                if (bytesRead == 0)
                {
                    //the client has disconnected from the server
                    break;
                }

                //message has successfully been received
                ASCIIEncoding encoder = new ASCIIEncoding();
                //System.Diagnostics.Debug.WriteLine(encoder.GetString(message, 0, bytesRead));

                Log(string.Format("Received message '{0}' through TCP connection", encoder.GetString(message, 0, bytesRead)));
            }

            tcpClient.Close();
        }
        #endregion

        #region Common stuff
        /// <summary>
        /// Writes to the log control
        /// </summary>
        /// <param name="Message"></param>
        private void Log(string Message)
        {
            if (rtbLog.InvokeRequired)
            {
                rtbLog.Invoke(new valueDelegate(Log), Message + '\n');
                //rtbLog.Invoke(new valueDelegate(Log), Environment.NewLine);
            }
            else
            {
                rtbLog.AppendText(Message + '\n');
                //rtbLog.AppendText(Environment.NewLine);
            }
        }
        #endregion        
    }
}
