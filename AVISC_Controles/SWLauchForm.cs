using System;
using System.Reflection;
using System.Windows.Forms;

namespace AVISC_Controles
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
            Assembly ensamblat = Assembly.LoadFrom($"{Classe}.dll");

            Object dllBD;

            Type tipus;

            tipus = ensamblat.GetType($"{Classe}.{Form}");

            dllBD = Activator.CreateInstance(tipus);

            ((Form)dllBD).Show();
        }
    }
}
