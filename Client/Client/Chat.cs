using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class Chat : Form
    {
        string TextBox;
        public string MyNames;
        public string MyName { get; set; }
        private IPEndPoint myEndPoint;
        private Socket mySocket;
        private int port;
        private IPAddress myIp;
        private const int BUFSIZE = 32;
        private const int BACKLOG = 5;
        byte[] rcvBuffer = new byte[BUFSIZE];
        int bytesRcvd;
        
        public Chat()
        {
            InitializeComponent();
            User u = new User();
            Login Login = new Login();
            myIp = IPAddress.Parse("127.0.0.1");
            port = 1234;
            myEndPoint = new IPEndPoint(myIp, port);
            mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
           
        }
      
        public void sets_MyNames(string alpha)
        {
            MyNames = alpha;
            Connection();
        }
        private void bSenden_Click(object sender, EventArgs e)
        {
            Connection();
            TextBox = Convert.ToString(textBoxSender.Text);
            if (TextBox.Length > 0)
            {
                textverlauf();
                textBox1.AppendText(MyNames);
                textBox1.AppendText(":");
                textBox1.AppendText(textBoxSender.Text);


                textBoxSender.ResetText();
            }

        }

        private void Connection()
        {
            try
            {
                

                mySocket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8887)); //Server Endpoint  Was für ein Port und Was für eine IP 
            }
            catch (Exception)
            {
                throw;
            }
            if (mySocket.Connected)
            {
                MessageBox.Show("Connection Establish");
                mySocket.Send(rcvBuffer, 0, bytesRcvd, SocketFlags.None);
                mySocket.Close();
            }
        }

        private void textBoxSender_TextChanged(object sender, EventArgs e)
        {

        }
        private void textverlauf()
        {
            textBox10.ResetText();
            textBox10.AppendText(textBox9.Text);
            textBox9.ResetText();
            textBox9.AppendText(textBox8.Text);
            textBox8.ResetText();
            textBox8.AppendText(textBox7.Text);
            textBox7.ResetText();
            textBox7.AppendText(textBox6.Text);
            textBox6.ResetText();
            textBox6.AppendText(textBox5.Text);
            textBox5.ResetText();
            textBox5.AppendText(textBox4.Text);
            textBox4.ResetText();
            textBox4.AppendText(textBox3.Text);
            textBox3.ResetText();
            textBox3.AppendText(textBox2.Text);
            textBox2.ResetText();
            textBox2.AppendText(textBox1.Text);
            textBox1.ResetText();
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            myIp = IPAddress.Parse("localhost");
            port = 1234;
            myEndPoint = new IPEndPoint(myIp, port);
            mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //TCP Echo Server
        }
    }
}
