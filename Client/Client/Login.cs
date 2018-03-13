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
   
    public partial class Login : Form
    {
        public Login()
        {
            User u = new User();
            InitializeComponent();

            
        }
       
        private void bLogIn_Click(object sender, EventArgs e)
        {

            string sAddress = "";
            string sServerIP;

            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIPs)
            {
               
                
                   
                if (address.ToString().Contains("."))
                    {
                    sAddress = Convert.ToString(address);
                    };
                    
                

            }
            try {
                if (String.IsNullOrWhiteSpace(tServerIP.Text))
                {
                    sServerIP = "127.0.0.1";

                }
                if (String.IsNullOrEmpty(tServerIP.Text))
                {
                    sServerIP = "127.0.0.1";

                }
                sServerIP = Convert.ToString(tServerIP.Text);
                Chat chat = new Chat();
                Visible = false;
                Close();
                chat.sets_MyNames(Convert.ToString(tUserName.Text),sAddress,sServerIP);            



                chat.ShowDialog();

            }
            catch(Exception)
            {

            }
        }
       
        //  sAddress = Convert.ToString(address);
        private void tUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tServerIP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
