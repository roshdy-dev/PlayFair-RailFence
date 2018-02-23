using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayFair
{
    public partial class ClientA : Form
    {
        Security play;
       ClientB clientAPP;
        internal string encrypt;
        public Socket s; 
        public Socket clientSock; 
      string appMode= "PlayFair";
        public ClientA()
        {
            InitializeComponent();
            cbxProgramType.SelectedIndex = 0;
            clientAPP = new ClientB(appMode);
            clientAPP.Show();
        }


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (appMode == "PlayFair")
            {
                if (txtKey.Text != "")
                {

                    play = new PlayFair(txtKey.Text);
                    encrypt = play.Encrypt(txtPlainText.Text.ToLower());
                    txtEncrypted.Text = encrypt.ToUpper();
                }
                else
                {
                    MessageBox.Show("Cannot Encrypt unless key is provided!!");
                }
            }
            else if (appMode == "Rail Fence")
            {
                play = new RailFence(Convert.ToInt32(txtDepth.Value));
                encrypt=play.Encrypt(System.Text.RegularExpressions.Regex.Replace(txtPlainText.Text," ",""));
                txtEncrypted.Text = encrypt.ToUpper();
            }

        }
        
        private void btnClientB_Click(object sender, EventArgs e)
        {
            //clientAPP.GetAppMode(appMode);

            // clientAPP.EncryptedText(encrypt);
            try
            {
            byte[] messageByteArray = Encoding.ASCII.GetBytes(encrypt);

          
            clientSock.Send(messageByteArray);

            lblServerStatus.Text = "Message Sent";

            }
            catch (Exception)
            {

                MessageBox.Show("Need Client B to be connected so data can be sent");
            }
        }



        private void cbxProgramType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProgramType.SelectedIndex == 0)
            {
                appMode = cbxProgramType.Text;
                txtDepth.Visible = false;
                txtDepth.Value = 1;
                txtKey.Visible = true;
                txtPlainText.Clear();
                txtEncrypted.Clear();
                txtPlainText.Focus();
            }
            else if (cbxProgramType.SelectedIndex == 1)
            {
                appMode = cbxProgramType.Text;
                txtKey.Visible=false;
                txtKey.Clear();
                txtDepth.Visible = true;
                txtPlainText.Clear();
                txtEncrypted.Clear();
                txtPlainText.Focus();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1000);
            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Bind(ep);
            s.Listen(100);
           lblServerStatus.Text= "Waiting for a client connect...";
        }

        private void btnAcceptConnection_Click(object sender, EventArgs e)
        {
            if (lblServerStatus.Text== "Waiting for a client connect...")
            {
            clientSock = s.Accept();
            lblServerStatus.Text = "Client Connected";
            }
            else
            {
                MessageBox.Show("Server Service Must Be started first\nPress Start Server");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            byte[] appModeArray = Encoding.ASCII.GetBytes(appMode);
            clientSock.Send(appModeArray);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Need Server to start service 1st before connecting\n");
            }
        }
    }
}
