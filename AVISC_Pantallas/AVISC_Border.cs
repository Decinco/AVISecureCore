using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVISC_Pantallas
{
    public partial class AVISC_Border : Form
    {

        public AVISC_Border()
        {

            InitializeComponent();

            RefreshForm(new AVISC_Principal());

        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSecure_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Introduce un formulario nuevo, quitando el anterior. 
        /// </summary>
        /// <param name="newform">Formulario a mostrar.</param>
        private void RefreshForm(Form newform)
        {
            
            pnl_FormContainer.Controls.Clear();

            newform.TopLevel = false;
            pnl_FormContainer.Controls.Add(newform);

            newform.Show();
        }
    }
}
