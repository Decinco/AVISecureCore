using System;
using System.Windows.Forms;

namespace AVISC_BaseForms
{
    public partial class AVISC_CloseableFeatureForm : Form
    {
        public string FeatureName { get; set; }

        public AVISC_CloseableFeatureForm()
        {
            InitializeComponent();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
