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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void backVideo_Enter(object sender, EventArgs e)
        {
            backVideo.URL = @"C:\DAM2n\ABP\ProyectoABP\resourses\splashVideo.mp4";
            backVideo.Ctlcontrols.play();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
