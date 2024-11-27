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

        //private void backVideo_Enter(object sender, EventArgs e)
        //{
        //    backVideo.URL = @"C:\DAM2n\ABP\ProyectoABP\resourses\video-splash.mp4";
        //    backVideo.fullScreen = true;
        //    backVideo.Ctlcontrols.play();
            
        //}
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void splash_Load(object sender, EventArgs e)
        {
            backVideo.URL = @"C:\DAM2n\ABP\ProyectoABP\resourses\video-splash.mp4";
            backVideo.settings.autoStart = true;
            backVideo.uiMode = "none"; // Ocultar controles
            backVideo.PlayStateChange += BackVideo_PlayStateChange; // Suscribirse al evento
        }

        private void BackVideo_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Verificar si el estado del reproductor es "Playing"
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            {
                backVideo.fullScreen = true; // Hacer pantalla completa
            }
        }
    }
}
