using System;
using System.Windows.Forms;
using System.Drawing;
using AVISC_Global;

namespace AVISC_BaseForms
{
    /// <summary>
    /// Un formulario cerrable que se introduce dentro del panel de la pantalla AVISC_Border.
    /// </summary>
    public partial class AVISC_CloseableFeatureForm : Form
    {
        /// <summary>
        /// Nombre de la función a mostrar.
        /// </summary>
        public string FeatureName { get; set; }

        public AVISC_CloseableFeatureForm()
        {
            InitializeComponent();
        }

        private void AVISC_CloseableFeatureForm_Load(object sender, EventArgs e)
        {
            RoundUtils.RedondearEsquinas(pnl_BackButton, bottomLeft: 20);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackButton_Enter(object sender, EventArgs e)
        {
            pnl_BackButton.BackColor = ColorTranslator.FromHtml("#3C3C3C");
        }

        private void BackButton_Leave(object sender, EventArgs e)
        {
            pnl_BackButton.BackColor = ColorTranslator.FromHtml("#2A2A2A");
        }
    }
}
