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

            for (int i = 0; i < 3; i++)
            {
                SWLauchForm function = new SWLauchForm();

                function.Project = "AVISC_BaseForms";
                function.Target = "AVISC_CloseableFeatureForm";
                function.FeatureName = "cosa seria";
                function.Description = "esta vaina es seria";
                function.Margin = new Padding(67, 30, 67, 30);

                pnl_MenuItems.Controls.Add(function);

                SWLauchForm function2 = new SWLauchForm();

                function2.Project = "AVISC_BaseForms";
                function2.Target = "AVISC_CloseableFeatureForm";
                function2.FeatureName = "cosa graciosa";
                function2.Description = "gracioso, gracioso, gracioso, gracioso";
                function2.Margin = new Padding(67, 30, 67, 30);

                pnl_MenuItems.Controls.Add(function2);
            }
        }
    }
}
