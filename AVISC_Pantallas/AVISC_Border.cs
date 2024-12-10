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

            OpenForm(new AVISC_Principal());

        }

        /// <summary>
        /// Introduce un formulario nuevo, quitando el anterior. 
        /// </summary>
        /// <param name="newform">Formulario a mostrar.</param>
        private void OpenForm(Form newform)
        {
            
            //pnl_FormContainer.Controls.Clear();


            newform.TopLevel = false;
            pnl_FormContainer.Controls.Add(newform);

            newform.Show();
            
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void UserPanel_Enter(object sender, EventArgs e)
        {
            pnl_User.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void UserPanel_Leave(object sender, EventArgs e)
        {
            pnl_User.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void UserPanel_Click(object sender, EventArgs e)
        {

        }
    }

}
