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
            ActiveControl = null;
        }

        private void AVISC_Principal_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 7; i++)
            {
                SWLauchForm function = new SWLauchForm("cosa", "cosa", "cosa", "cosa");
                function.Margin = new Padding(67, 30, 67, 30);


                pnl_MenuItems.Controls.Add(function);
            }
        }
    }
}
