using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVISecureCore
{
    public partial class AVISecureCore : Form
    {
        public AVISecureCore()
        {
            InitializeComponent();
            this.Hide();
            PantallaPrincipal PantallaPrincipal = new PantallaPrincipal();
            PantallaPrincipal.Show();
        }
    }
}
