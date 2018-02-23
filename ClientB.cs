using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace PlayFair
{
    public partial class ClientB : Form
    {
        internal string encrypt;
        internal string decrypt;
        Security playDec;
        public Socket c;
        string msgSocket;
        internal string appMode { get; set; }
        public ClientB(string appMode)
        {
            InitializeComponent();
            this.appMode = appMode;
        }
        public ClientB()
        {
            InitializeComponent();
            this.appMode = appMode;
        }
        public void GetAppMode(string appMode)
        {
            if (appMode == "PlayFair")
            {
                txtDepth.Visible = false;
                txtDepth.Value = 1;
                txtKey.Visible = true;
                lblEncryptedText.Text = "";
                txtDecrypted.Text = "";
                this.appMode = appMode;
            }
            else if (appMode == "Rail Fence")
            {
                txtKey.Clear();
                txtKey.Visible = false;
                txtDepth.Visible = true;
                lblEncryptedText.Text = "";
                txtDecrypted.Text = "";
                this.appMode = appMode;
            }
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txtKey.Text == "")
            {
                if (appMode == "PlayFair")
                {

                    MessageBox.Show("Cannot Decrypt until a key is provided!!");
                    return;

                }
            }
           


                if (lblEncryptedText.Text == "")
                {
                    MessageBox.Show("Cannot Decrypt until an encrypted message is recieved!!");
                }
                else
                {
                    if (appMode == "PlayFair")
                    {
                        txtDecrypted.Clear();
                        playDec = new PlayFair(txtKey.Text);
                    // decrypt = playDec.Decrypt(encrypt.ToLower());
                    decrypt = playDec.Decrypt(msgSocket.ToLower());
                    txtDecrypted.Text = decrypt.ToUpper();
                    }
                    else if (appMode == "Rail Fence")
                    {
                        txtDecrypted.Clear();
                        playDec = new RailFence(Convert.ToInt32(txtDepth.Value));
                    //  decrypt = playDec.Decrypt(encrypt.ToLower());
                    decrypt = playDec.Decrypt(msgSocket.ToLower());
                    txtDecrypted.Text = decrypt.ToUpper();
                    }


                }
            }


        public void EncryptedText(string msg)
        {
            encrypt = msg;
            lblEncryptedText.Text = encrypt.ToUpper();
          
        }

        private void ClientB_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
            IPAddress host = IPAddress.Parse("127.0.0.1");
            IPEndPoint hostEndPoint = new IPEndPoint(host, 1000);
            c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            c.Connect(hostEndPoint);
           lblClientStatus.Text = "Connected to Server ... Recieving...";
            }
            catch (SocketException ex)
            {

                MessageBox.Show("Need Server to start service 1st before connecting\n"+ex.Message);
            }
        }

        private void btnRecieveMessage_Click(object sender, EventArgs e)
        {
            try
            {
            msgSocket = "";
            lblClientStatus.Text = "";
            byte[] ClientData = new byte[1024];
            int recievedBytesLength = c.Receive(ClientData);
            string message;

            message = Encoding.ASCII.GetString(ClientData);
            lblClientStatus.Text = "";
            lblClientStatus.Text += "Server Encrypted Message..";


            for (int i = 0; message[i] != '\0'; ++i)
            { msgSocket += message[i]; }
            lblEncryptedText.Text = msgSocket;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Need Server to start service 1st before connecting");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            msgSocket = "";
            byte[] ClientAppMode = new byte[1024];
            int recieveClientAPP = c.Receive(ClientAppMode);
            appMode = Encoding.ASCII.GetString(ClientAppMode);
            for (int i = 0; appMode[i] != '\0'; ++i)
            { msgSocket += appMode[i]; }
            this.GetAppMode(msgSocket);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Need Server to start service 1st before connecting");
            }
        }
    }
}
