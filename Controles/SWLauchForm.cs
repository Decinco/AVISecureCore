using System;
using System.Windows.Forms;

namespace Controles
{
    public partial class SWLauchForm: UserControl
    {
        private string Classe;

        public string classe
        {
            get { return Classe; }
            set { Classe = value; }
        }

        private string Form;

        public string form
        {
            get { return Form; }
            set { Form = value; }
        }

        public SWLauchForm()
        {
            InitializeComponent();
        }

        private void Abrir_Formulario_Click(object sender, EventArgs e)
        {

        }
    }
}
