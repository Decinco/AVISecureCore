using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVISC_Controles;

namespace AVISC_Pantallas
{
    public partial class AVISC_Principal : Form
    {
        public string UserName {
            set { lbl_Intro.Rtf = $"{{\\rtf1\\ansi Bienvenido a Secure Core, \\b {value}\\b0!}}"; }
        }

        public AVISC_Principal()
        {
            InitializeComponent();

            UserName = "John Random";
        }

        // Se utiliza un richtextbox para poder permitir que el nombre de usuario salga en negrita
        // Ahora, hay que disimular que es un label normal y corriente :)
        private void lbl__Enter(object sender, EventArgs e)
        {
            ActiveControl = pnl_MenuItems;
        }

        private void AVISC_Principal_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 50; i++)
            {

                pnl_MenuItems.Controls.Add(new SWLauchForm()
                {
                    Project = "AVISC_BaseForms",
                    Target = "AVISC_CloseableFeatureForm",
                    FeatureName = "cosa seria",
                    Description = "esta vaina es seria",
                    Margin = new Padding(25)
                });

                pnl_MenuItems.Controls.Add(new SWLauchForm()
                {
                    Project = "AVISC_BaseForms",
                    Target = "AVISC_CloseableFeatureForm",
                    FeatureName = "cosa graciosa",
                    Description = "lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
                    Margin = new Padding(25)
                });
            }
        }
    }
}
