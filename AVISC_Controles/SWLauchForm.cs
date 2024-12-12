using System;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using AVISC_BaseForms;

namespace AVISC_Controles
{
    public partial class SWLauchForm : UserControl
    {
        public string Project { get; set; }

        public string Target { get; set; }

        public string Description
        {
            get { return lbl_descipcion.Text; }
            set { lbl_descipcion.Text = value; }
        }

        public string FeatureName
        {
            get { return lbl_opcion.Text; }
            set { lbl_opcion.Text = value; }
        }

        public SWLauchForm()
        {
            InitializeComponent();
        }

        private void Abrir_Formulario_Click(object sender, EventArgs e)
        {
            Assembly ensamblat = Assembly.LoadFrom($"{Project}.dll");

            Object dll;
            Type tipus;
            tipus = ensamblat.GetType($"{Project}.{Target}");
            dll = Activator.CreateInstance(tipus);
            AVISC_CloseableFeatureForm frm = (AVISC_CloseableFeatureForm)dll;

            frm.FeatureName = FeatureName;

            OpenForm(frm);

        }

        private void SWLauchForm_MouseEnter(object sender, EventArgs e)
        {
            pnl_configuracion.BackColor = Color.FromArgb(48, 48, 48);
        }

        private void SWLauchForm_MouseLeave(object sender, EventArgs e)
        {
            pnl_configuracion.BackColor = Color.FromArgb(33, 33, 33);
        }

        /// <summary>
        /// Introduce un formulario nuevo en el panel contenedor, quitando el anterior. 
        /// </summary>
        /// <param name="newform">Formulario a mostrar.</param>
        private void OpenForm(Form newform)
        {
            Form frPral = this.FindForm();
            Control contenedorPral = frPral.Parent;

            newform.TopLevel = false;
            contenedorPral.Controls.Add(newform);
            newform.WindowState = FormWindowState.Maximized;
            newform.Show();
        }
    }
}
