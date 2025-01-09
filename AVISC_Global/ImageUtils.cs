using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVISC_Global
{
    public static class ImageUtils
    {
        public static Bitmap StretchImageToSquare(Image image, int size)
        {
            Bitmap result = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage((Image)result))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(image, 0, 0, size, size);
            }

            return result;
        }
    }
}
