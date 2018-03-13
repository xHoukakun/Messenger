using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;




namespace Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        string path2;
        private void MainForm_Load(object sender, EventArgs e)
        {


            
            path2 = Application.StartupPath + "\\Iah51muellerMessenger2.wav";
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            player.SoundLocation = path2;
            player.Play();
            
            //Process.Start(path2);
           
            Visible = false;
            System.Threading.Thread.Sleep(4000);
            Login Login = new Login();
            Login.ShowDialog();
            Close();
        }
    }
}
