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
using Ibt.Ortc.Api;
using Ibt.Ortc.Api.Extensibility;
using Newtonsoft.Json;
using Ibt.Ortc.Plugin.IbtRealTimeSJ;

namespace RTCH
{
    public partial class frmMain : Form
    {
        #region Variables, Delegates, ...
        private TcpListener tcpListener;
        private Thread listenThread;
        private TcpClient client;

        delegate void emptyDelegate();
        delegate void valueDelegate(string value);

        private string ortcServerURL = "http://ortc-developers.realtime.co/server/2.1"; // ORTC Server URL
        private string ortcAppKey = "YOUR_APP_KEY"; // Your Realtime Application Key (get your free key at www.realtime.co)
        private string ortcPrivateKey = "YOUR_PRIVATE_KEY"; // Your Realtime Private Key
        private string ortcAuthToken = "AUTHENTICATION_TOKEN"; // Authorization token. Not necessary if you're using a free developer account. Can be whatever you want (a GUID, for example)
        private OrtcClient ortcClient;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        #region Interface Methods and Events
        /// <summary>
        /// Handles the Run Server button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRunServer_Click(object sender, EventArgs e)
        {
            TCPCommunication();
            txtTCPPort.Enabled = false;
            ((Button)sender).Text = "Waiting...";
            ((Button)sender).Enabled = false;
            tssTCPStatus.Text = "TCP Client: Waiting for connection...";
        }

        /// <summary>
        /// Handles the Connect to ORTC button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnectToORTC_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            ((Button)sender).Text = "Connecting...";
            ORTCCommunication();
        }

        /// <summary>
        /// Handles the Send Message to ORTC button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnORTCSendMessage_Click(object sender, EventArgs e)
        {
            string channel = txtORTCChannel.Text.Trim();
            string message = txtORTCMessage.Text.Trim();

            Log(string.Format("Sending message '{0}' through ORTC channel {1}", message, channel));
            ortcClient.Send(channel, message);
        }

        /// <summary>
        /// Handles the Send Message to TCP client button click
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
            this.tcpListener = new TcpListener(IPAddress.Any, Convert.ToInt16(txtTCPPort.Text));
            this.listenThread = new Thread(new ThreadStart(ListenForClients));
            this.listenThread.IsBackground = true;
            this.listenThread.Start();
        }

        /// <summary>
        /// Listens for clients
        /// </summary>
        private void ListenForClients()
        {
            this.tcpListener.Start();
            Log(string.Format("Listening on port {0}", txtTCPPort.Text.Trim()));

            while (true)
            {
                try
                {
                    //blocks until a client has connected to the server
                    this.client = this.tcpListener.AcceptTcpClient();

                    //create a thread to handle communication 
                    //with connected client
                    Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                    clientThread.Start(this.client);
                }
                catch (Exception ex)
                {
                    Log(string.Format("Error occurred: {0}", ex.Message));
                    break;
                }
                
            }
        }

        /// <summary>
        /// Handles the client TCP communication
        /// </summary>
        /// <param name="client"></param>
        private void HandleClientComm(object client)
        {
            Log("Client connected");
            tssTCPStatus.Text = "TCP Client: Connected";
            EnableTCPPanel();

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

                // Deserialize and send it through ORTC
                System.Diagnostics.Debug.WriteLine(encoder.GetString(message, 0, bytesRead));
                CHMessage chMessage = JsonConvert.DeserializeObject<CHMessage>(encoder.GetString(message, 0, bytesRead));
                //string from = CHMessage
                string ortcChannel = chMessage.Channel;
                string ortcMessage = chMessage.Data.ToString();
                
                Log(string.Format("Sending message '{0}' through ORTC channel {1}", ortcMessage, ortcChannel));
                ortcClient.Send(ortcChannel, ortcMessage);
            }

            tcpClient.Close();
        }

        /// <summary>
        /// Sends a message through TCP
        /// </summary>
        /// <param name="Message"></param>
        private void SendTCPMessage(string Message)
        {
            if (this.client != null)
            {
                Log(string.Format("Sending message '{0}' to TCP client", Message));

                NetworkStream clientStream = this.client.GetStream();
                ASCIIEncoding encoder = new ASCIIEncoding();
                byte[] buffer = encoder.GetBytes(Message);

                clientStream.Write(buffer, 0, buffer.Length);
                clientStream.Flush();
            }
        }

        #endregion

        #region ORTC Communication
        /// <summary>
        /// Connects to ORTC to work its magic
        /// </summary>
        private void ORTCCommunication()
        {
            Log("Initializing ORTC Connection");
            if (ORTCAuthentication())
            {
                if (ORTCLoadFactory())
                {
                    ORTCConnect();
                }
            }
        }

        /// <summary>
        /// Authenticates us on ORTC so we can publish and subscribe
        /// </summary>
        private bool ORTCAuthentication()
        {
            Log("Going to make the authentication post");
            Dictionary<string, ChannelPermissions> channelPermissions = new Dictionary<string, ChannelPermissions>();
            channelPermissions.Add("ch:session1", ChannelPermissions.Write);
            if (Ibt.Ortc.Api.Ortc.SaveAuthentication(ortcServerURL, true, ortcAuthToken, false, ortcAppKey, 3600, ortcPrivateKey, channelPermissions))
            {
                Log("Permissions posted");
                return true;
            }
            else
            {
                Log("Unable to post permissions");
            }

            return false;
        }

        /// <summary>
        /// Loads the ORTC factory
        /// </summary>
        /// <returns></returns>
        private bool ORTCLoadFactory()
        {
            try
            {
                // Load factory
                var api = new Ibt.Ortc.Api.Ortc("Plugins");
                IOrtcFactory factory = api.LoadOrtcFactory("IbtRealTimeSJ");

                if (factory != null)
                {
                    // Construct object
                    ortcClient = factory.CreateClient();

                    if (ortcClient != null)
                    {
                        ortcClient.Id = "RTCH";
                        //_ortc.ConnectionTimeout = 10000;

                        // Handlers
                        ortcClient.OnConnected += new OnConnectedDelegate(ortc_OnConnected);
                        //ortcClient.OnDisconnected += new OnDisconnectedDelegate(ortc_OnDisconnected);
                        //ortcClient.OnReconnecting += new OnReconnectingDelegate(ortc_OnReconnecting);
                        //ortcClient.OnReconnected += new OnReconnectedDelegate(ortc_OnReconnected);
                        ortcClient.OnSubscribed += new OnSubscribedDelegate(ortc_OnSubscribed);
                        //ortcClient.OnUnsubscribed += new OnUnsubscribedDelegate(ortc_OnUnsubscribed);
                        ortcClient.OnException += (sender, error) => {
                            Log(error.ToString());
                        };
                        return true;
                    }
                }
                else
                {
                    Log("Factory is null");
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }

            if (ortcClient == null)
            {
                Log("ORTC object is null");
            }

            return false;
        }

        /// <summary>
        /// Connects to the ORTC server
        /// </summary>
        private void ORTCConnect()
        {
            Log(String.Format("Connecting to: {0} ", ortcServerURL));

            //ortcClient.ConnectionMetadata = txtClientConnectionMetadata.Text;
            //ortcClient.AnnouncementSubChannel = txtClientAnnouncementSubChannel.Text;
            ortcClient.ClusterUrl = ortcServerURL;
            ortcClient.Connect(ortcAppKey, ortcAuthToken);
        }

        /// <summary>
        /// ORTC OnConnected handler function
        /// </summary>
        /// <param name="sender"></param>
        private void ortc_OnConnected(object sender)
        {
            Log(String.Format("Connected to: {0}", ortcClient.Url));
            Log(String.Format("Connection metadata: {0}", ortcClient.ConnectionMetadata));
            Log(String.Format("Session ID: {0}", ortcClient.SessionId));

            btnConnectToORTC.Enabled = false;
            tssORTCStatus.Text = "ORTC: Connected";

            btnConnectToORTC.Text = "Connected";

            //Subscribe our channels
            ortcClient.Subscribe("ch:session1", true, OnMessageCallback);
        }

        /// <summary>
        /// Handles messages coming from a channel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="channel"></param>
        /// <param name="message"></param>
        private void OnMessageCallback(object sender, string channel, string message)
        {
            Log(string.Format("Received message '{0}' through ORTC channel {1}", message, channel));
            // Checks if this message was not originally sent from the app.
            if (((Ibt.Ortc.Plugin.IbtRealTimeSJ.IbtRealTimeSJClient)sender).Id != "RTCH")
            {
                // It's not -> relay it to Combat Helo
                SendTCPMessage(message);
            }
        }

        /// <summary>
        /// ORTC OnSubscribed handler function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="channel"></param>
        private void ortc_OnSubscribed(object sender, string channel)
        {
            Log(string.Format("Subscribing channel: {0}", channel));

            gbxORTC.Enabled = true;
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
            }
            else
            {
                rtbLog.AppendText(Message + '\n');
            }
        }
        #endregion
    }
}
