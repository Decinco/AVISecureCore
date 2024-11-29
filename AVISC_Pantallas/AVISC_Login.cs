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
        private void AVISC_Login_Load(object sender, EventArgs e)
        {
            backVideo.URL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "video-splash.mp4");
            backVideo.settings.autoStart = true;
            backVideo.uiMode = "none";
            backVideo.PlayStateChange += backVideo_PlayStateChange;

            imageOpen = pbx_ojo.Image = Bitmap.FromFile(@"Resources\icono password abierto.png");
        }

        private void backVideo_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Verificar si el estado del reproductor es "Playing"
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            {
                backVideo.SendToBack();
            }
        }

        private void btm_login_Click(object sender, EventArgs e)
        {
            LoginData login = new LoginData();
            AVISC_Border aVISC_Border = new AVISC_Border();
            bool validar_login  = login.PerformLogin(txt_user.Text, txt_pass.Text);

            if (validar_login == true)
            {
                this.Hide();
                aVISC_Border.Show();
                backVideo.settings.mute = true;
            }
            else
            {
                pnl_warning.Visible = true;
            }
        }

        private void pbx_ojo_Click(object sender, EventArgs e)
        {
            if (imageOpen == pbx_ojo.Image)
            {
                imageClose = pbx_ojo.Image = Bitmap.FromFile(@"Resources\icono password.png");
                txt_pass.PasswordChar.ToString();
            }
            else if (imageClose == pbx_ojo.Image)
            {
                imageOpen = pbx_ojo.Image = Bitmap.FromFile(@"Resources\icono password abierto.png");
                txt_pass.PasswordChar = '*';
            }
        }
    }
}
