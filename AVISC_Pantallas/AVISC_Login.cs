using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVISC_DataAccess;

namespace AVISC_Pantallas
{
    public partial class AVISC_Login : Form
    {
        public AVISC_Login()
        {
            InitializeComponent();
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

        private Image imageOpen;
        private Image imageClose;
        private bool validar_login = false;
        private void AVISC_Login_Load(object sender, EventArgs e)
        {
            //backVideo.URL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "estrellas_gif_prueba.gif");
            //backVideo.settings.autoStart = true;
            //backVideo.uiMode = "none";
            //backVideo.PlayStateChange += backVideo_PlayStateChange;

            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SendToBack();

            imageOpen = Bitmap.FromFile(@"Resources\icono password abierto.png");
            imageClose = Bitmap.FromFile(@"Resources\icono password.png");

            pbx_ojo.Image = imageOpen;
            txt_pass.UseSystemPasswordChar = false;
        }

        private void backVideo_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Verificar si el estado del reproductor es "Playing"
            //if (e.newState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            //{
            //    backVideo.SendToBack();
            //    backVideo.Dock = DockStyle.Fill;
            //}
        }

        private void btm_login_Click(object sender, EventArgs e)
        {
            LoginData login = new LoginData();
            AVISC_Border aVISC_Border = new AVISC_Border();
            validar_login  = login.PerformLogin(txt_user.Text, txt_pass.Text);

            if (validar_login == true)
            {
                this.Hide();
                aVISC_Border.Show();
                //backVideo.settings.mute = true;
            }
            else
            {
                pnl_warning.Visible = true;
            }
        }

        private void pbx_ojo_Click(object sender, EventArgs e)
        {
            if (validar_login)
            {
                txt_pass.UseSystemPasswordChar = false;
                pbx_ojo.Image = imageOpen;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
                pbx_ojo.Image = imageClose;
            }

            validar_login = !validar_login;
        }
    }
}