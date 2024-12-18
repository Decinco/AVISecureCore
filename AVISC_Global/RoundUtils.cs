using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AVISC_Global
{
    public static class RoundUtils
    {

        /// <summary>
        /// Redondea todas las esquinas de un control.
        /// </summary>
        /// <param name="control">Control a modificar.</param>
        /// <param name="radius">Radio de las esquinas.</param>
        public static void RedondearEsquinas(Control control, float radius)
        {
            if (control == null) throw new ArgumentNullException(nameof(control));

            var bounds = control.ClientRectangle;

            using (GraphicsPath path = new GraphicsPath())
            {

                // Arco de esquina superior izquierda
                path.AddArc(bounds.Left, bounds.Top, radius, radius, 180, 90);

                // Arco de esquina superior derecha
                path.AddArc(bounds.Right - radius, bounds.Top, radius, radius, 270, 90);

                // Arco de esquina inferior izquierda
                path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);

                // Arco de esquina inferior derecha
                path.AddArc(bounds.Left, bounds.Bottom - radius, radius, radius, 90, 90);

                // Asignar la región al control
                control.Region = new Region(path);

                // Forzar el redibujado del control
                control.Invalidate();
            }
        }

        /// <summary>
        /// Redondea las esquinas de un control. Permite especificar qué esquinas redondear.
        /// </summary>
        /// <param name="control">Control a modificar.</param>
        /// <param name="topLeft">Radio de la esquina superior izquierda.</param>
        /// <param name="topRight">Radio de la esquina superior derecha.</param>
        /// <param name="bottomLeft">Radio de la esquina inferior izquierda.</param>
        /// <param name="bottomRight">Radio de la esquina inferior derecha.</param>
        public static void RedondearEsquinas(Control control, float topLeft = 0.1F, float topRight = 0.1F, float bottomLeft = 0.1F, float bottomRight = 0.1F)
        {
            if (control == null) throw new ArgumentNullException(nameof(control));

            var bounds = control.ClientRectangle;

            using (GraphicsPath path = new GraphicsPath())
            {

                // Arco de esquina superior izquierda
                path.AddArc(bounds.Left, bounds.Top, topLeft, topLeft, 180, 90);

                // Arco de esquina superior derecha
                path.AddArc(bounds.Right - topRight, bounds.Top, topRight, topRight, 270, 90);

                // Arco de esquina inferior izquierda
                path.AddArc(bounds.Right - bottomRight, bounds.Bottom - bottomRight, bottomRight, bottomRight, 0, 90);

                // Arco de esquina inferior derecha
                path.AddArc(bounds.Left, bounds.Bottom - bottomLeft, bottomLeft, bottomLeft, 90, 90);

                // Asignar la región al control
                control.Region = new Region(path);

                // Forzar el redibujado del control
                control.Invalidate();
            }
        }
    }
}
