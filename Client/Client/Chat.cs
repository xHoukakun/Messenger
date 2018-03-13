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
using System.Diagnostics;

namespace Client
{
    public partial class Chat : Form
    {
        
        private string TextBox;
        private StringBuilder sbSenden = new StringBuilder();
        private string selfIp;
        private string myName;
        private string sServerIp;
        private IPEndPoint myEndPoint;
        private Socket mySocket;
        private int port;
        private IPAddress myIp;


        private string gName;
        private string gIP;
        private string gNachricht;
       
        

        public Chat()
        {
            InitializeComponent();
            Login Login = new Login();
            myIp = IPAddress.Parse("127.0.0.1");
            port = 8887;
            myEndPoint = new IPEndPoint(myIp, port);
            mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            lClients.DisplayMember = "GetFormrtierteAusgabe";
           
        }
        //Der Name, die eigene IP und die Server IP werden übergeben
        public void sets_MyNames(string alpha, string beta, string Gamma)
        {
            myName = alpha;
            selfIp = beta;
            sServerIp = Gamma;
            sbSenden.Clear();
            sbSenden.Append(myName);
            sbSenden.Append("|");
            sbSenden.Append(selfIp);
           // eConnection();
        }

        //Wenn der Button geclickt wurder wird der Text versendet
        private void bSenden_Click(object sender, EventArgs e)
        {
            tConnect();
            TextBox = Convert.ToString(textBoxSender.Text);
            if (TextBox.Length > 0)
            {
                textverlauf();
                textBox1.AppendText(myName);
                textBox1.AppendText(":");
                textBox1.AppendText(textBoxSender.Text);


                textBoxSender.ResetText();
            }

        }

        private void eConnection()  //merken
        {
            
            Byte[] bytesSent = Encoding.ASCII.GetBytes(sbSenden.ToString());
            Byte[] bytesReceived = new Byte[4096];
            try
            {
                

                mySocket.Connect(new IPEndPoint(IPAddress.Parse(sServerIp), 8887)); //Server Endpoint  Was für ein Port und Was für eine IP 
            }
            catch (Exception)
            {
                MessageBox.Show("Es konnte nicht verbunden werden");
                System.Threading.Thread.Sleep(1000);
                Visible = false;
                Login Login = new Login();
                Login.ShowDialog();
                Close();
            }
            if (mySocket.Connected)
            {
                int bytes = 0;
                MessageBox.Show("Connection Establish");
                mySocket.Send(bytesSent, bytesSent.Length, SocketFlags.None);
                //do
                //{
                //    bytes = mySocket.Receive(bytesReceived, bytesReceived.Length, SocketFlags.None);
                //    // kovertiere die Byte Daten in einen string
                //    MyNames = MyNames + Encoding.ASCII.GetString(bytesReceived, 0, bytes);
                //} while (bytes > 0);
                mySocket.Close();
                sbSenden.Clear();
            }
        }
        private void tConnect()
        {
            
           TextBox = Convert.ToString(sbSenden);
           Byte[] bytesSent = Encoding.ASCII.GetBytes(TextBox);
           //Byte[] bytesReceived = new Byte[4096];
            try
            {
                mySocket.Connect(new IPEndPoint(IPAddress.Parse(sServerIp), 8887));
            }
            catch (Exception)
            {
                MessageBox.Show("Es konnte nicht verbunden werden");
                System.Threading.Thread.Sleep(1000);
                Visible = false;
                Login Login = new Login();
                Login.ShowDialog();
                Close();
            }
            if (mySocket.Connected)
            {
                mySocket.Send(bytesSent, bytesSent.Length, SocketFlags.None);
                sbSenden.Clear();
            }
            mySocket.Close();
            
        }
        private void zusammensetzung(string Text)
        {
            
            if(gName!="")
            {
                sbSenden.Clear();
                sbSenden.Append("1|");
                sbSenden.Append(gName);  //Name oder IP wird noch entschieden
                sbSenden.Append("|");
                sbSenden.Append(myName);
                sbSenden.Append("|");
                sbSenden.Append(Text);
                
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
            string path2;
            StringBuilder sbPath = new StringBuilder();
            try
            {
                sbPath.Append(Application.StartupPath);
                sbPath.Remove(sbPath.Length - 9, 9);
                sbPath.Append("\\01-intro.wav");
                path2 = Convert.ToString(sbPath);

                System.Media.SoundPlayer player = new System.Media.SoundPlayer();

                player.SoundLocation = path2;
                player.Play();

            }
            catch (Exception)
            {

            }
            //myIp = IPAddress.Parse("127.0.0.1");
            //port = 8887;
            //myEndPoint = new IPEndPoint(myIp, port);
            //mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //TCP Echo Server
        }

        private void lClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lClients.SelectedItem != null)
            {
                textBox10.ResetText();               
                textBox9.ResetText();
                textBox8.ResetText();
                textBox7.ResetText();                
                textBox6.ResetText();                
                textBox5.ResetText();               
                textBox4.ResetText();                
                textBox3.ResetText();                
                textBox2.ResetText();               
                textBox1.ResetText();

                User uUser = lClients.SelectedItem as User;
                gIP = uUser.uIPv4;
                gName = uUser.uName;
                gNachricht = uUser.uNachricht;
                textBox1.AppendText(gName + ":" + gNachricht);
                

            }
        }
    }
}
