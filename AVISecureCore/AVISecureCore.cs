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
        AVISC_Login login = new AVISC_Login();
        public AVISecureCore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AVISC_Splash splash = new AVISC_Splash();
            AVISC_Login LOGIN = new AVISC_Login();

            LOGIN.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AVISC_Border pantallaPrincipal = new AVISC_Border();

            pantallaPrincipal.Show();
        }
    }
}
