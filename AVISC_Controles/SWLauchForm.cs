using System;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using AVISC_BaseForms;
using System.Runtime.InteropServices;
using System.ComponentModel;
using AVISC_Global;

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


        Color myRgbColor = new Color();

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        public SWLauchForm()
        {
            InitializeComponent();

            // Configurar el estilo para redibujar el control.
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true); // Redibuja al cambiar de tamaño.
            this.BackColor = Color.Transparent; // Permitir transparencia para bordes visibles.
            RoundUtils.RedondearControl(pnl_configuracion, 50); // Inicializa la región al crear el control.
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
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            RoundUtils.RedondearControl(pnl_configuracion, 50); // Redondea de nuevo al cambiar el tamaño.
        }
    }
}
