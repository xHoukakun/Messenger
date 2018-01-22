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
            
            Visible = false;
            Chat chat = new Chat();
            chat.ShowDialog();
            Close();

           
        }
    }
}
