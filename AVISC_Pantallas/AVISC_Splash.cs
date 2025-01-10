using System;
using System.IO;
using System.Windows.Forms;

namespace AVISC_Pantallas
{
    public partial class AVISC_Splash : Form
    {
        public AVISC_Splash()
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

        private void splash_Load(object sender, EventArgs e)
        {
            backVideo.URL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "video-splash.mp4");
            backVideo.settings.autoStart = true;
            backVideo.uiMode = "none"; // Ocultar controles
            backVideo.enableContextMenu = false; // Deshabilitar menú contextual
            backVideo.PlayStateChange += backVideo_PlayStateChange; // Suscribirse al evento
        }
        
        private void backVideo_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            {
                backVideo.fullScreen = true; // Hacer pantalla completa
            }
            else if (e.newState == (int)WMPLib.WMPPlayState.wmppsStopped)
            {
                // Mostrar el formulario de login al pausar o terminar el video
                if (Visible == true) {
                    Hide();
                    AVISC_Login login = new AVISC_Login();
                    login.Show();
                }
            }
            else if (e.newState == (int)WMPLib.WMPPlayState.wmppsPaused)
            {
                backVideo.Ctlcontrols.stop();
            }
        }
    }
}
