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
using AVISC_Global;

namespace AVISC_Pantallas
{
    public partial class AVISC_Principal : Form
    {
        public string UserName {
            set { lbl_Intro.Rtf = $"{{\\rtf1\\ansi Bienvenido a Secure Core, \\b {value}\\b0!}}"; }
        }

        public Image ProfilePicture { 
            get { return img_User.Image; } 
            set { img_User.Image = value; }
        }

        public List<DataRow> AvailableOptions { get; set; }

        public AVISC_Principal()
        {
            InitializeComponent();
        }

        // Se utiliza un richtextbox para poder permitir que el nombre de usuario salga en negrita
        // Ahora, hay que disimular que es un label normal y corriente :)
        private void lbl__Enter(object sender, EventArgs e)
        {
            ActiveControl = pnl_MenuItems;
        }

        private void AVISC_Principal_Load(object sender, EventArgs e)
        {
            if (AvailableOptions != null)
            {
                foreach (var option in AvailableOptions)
                {
                    pnl_MenuItems.Controls.Add(new SWLauchForm()
                    {
                        Project = "AVISC_BaseForms",
                        Target = "AVISC_CloseableFeatureForm",
                        Description = option.Field<string>("Descripcio"),
                        FeatureName = option.Field<string>("Nom"),
                        Margin = new Padding(25)
                    });
                }
            }

            //RoundUtils.RedondearEsquinas(img_User, 200);
        }
    }
}
