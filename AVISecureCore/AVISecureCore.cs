using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVISC_Pantallas;
using System.Windows.Forms;

namespace AVISecureCore
{
    public partial class AVISecureCore : Form
    {
        AVISC_Splash splash = new AVISC_Splash();
        AVISC_Border pantallaPrincipal = new AVISC_Border();
        AVISC_Login login = new AVISC_Login();
        public AVISecureCore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //login.Show();
            pantallaPrincipal.Show();
            //splash.Show();
        }
    }
}
