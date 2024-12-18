using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AVISC_Global
{
    public static class RoundUtils
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        /// <summary>
        /// Redondea todos los bordes del control.
        /// </summary>
        public static void RedondearControl(Control control, int radius)
        {
            if (control == null) throw new ArgumentNullException(nameof(control));

            var bounds = control.ClientRectangle;
            control.Region = Region.FromHrgn(CreateRoundRectRgn(
                bounds.Left, bounds.Top,
                bounds.Right, bounds.Bottom,
                radius, radius));

            // Forzar el redibujado del control
            control.Invalidate();
        }

        /// <summary>
        /// Redondea solo los bordes superiores del control.
        /// </summary>
        public static void RedondearBordesSuperiores(Control control, int radius)
        {
            if (control == null) throw new ArgumentNullException(nameof(control));

            var bounds = control.ClientRectangle;
            using (GraphicsPath path = new GraphicsPath())
            {
                // Esquinas superiores redondeadas
                path.AddArc(bounds.Left, bounds.Top, radius, radius, 180, 90); // Esquina superior izquierda
                path.AddArc(bounds.Right - radius, bounds.Top, radius, radius, 270, 90); // Esquina superior derecha
                path.AddLine(bounds.Right, bounds.Top + radius, bounds.Right, bounds.Bottom); // Lado derecho
                path.AddLine(bounds.Left, bounds.Bottom, bounds.Right, bounds.Bottom); // Línea inferior recta
                path.AddLine(bounds.Left, bounds.Bottom, bounds.Left, bounds.Top + radius); // Lado izquierdo
                path.CloseFigure();

                // Asignar la región al control
                control.Region = new Region(path);

                // Forzar el redibujado del control
                control.Invalidate();
            }
        }
    }
}
