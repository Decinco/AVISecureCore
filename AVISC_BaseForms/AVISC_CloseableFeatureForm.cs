using System;
using System.Windows.Forms;
using System.Drawing;

namespace AVISC_BaseForms
{
    public partial class AVISC_CloseableFeatureForm : Form
    {
        public string FeatureName { get; set; }

        public AVISC_CloseableFeatureForm()
        {
            InitializeComponent();
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
