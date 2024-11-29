using System;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;

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

        private string Descripcion;

        public string descripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }

        private string Nombre;

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }


        public SWLauchForm(string nombre, string clase, string descripcion, string form)
        {
            InitializeComponent();
            Form = form;
            Descripcion = descripcion;
            Classe = clase;
            Nombre = nombre;
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

        private void SWLauchForm_MouseEnter(object sender, EventArgs e)
        {
            pnl_configuracion.BackColor = Color.FromArgb(48, 48, 48);
        }

        private void SWLauchForm_MouseLeave(object sender, EventArgs e)
        {
            pnl_configuracion.BackColor = Color.FromArgb(33, 33, 33);
        }
    }
}
