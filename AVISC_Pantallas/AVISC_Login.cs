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
        private void AVISC_Login_Load(object sender, EventArgs e)
        {
            backVideo.URL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "video-splash.mp4");
            backVideo.settings.autoStart = true;
            backVideo.uiMode = "none";
            //backVideo.PlayStateChange += backVideo_PlayStateChange;
        }

        private void backVideo_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Verificar si el estado del reproductor es "Playing"
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            {
                backVideo.fullScreen = true; // Hacer pantalla completa
            }
        }
    }
}
