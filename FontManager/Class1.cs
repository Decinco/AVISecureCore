using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FontManager
{
    public static class FontManager
    {
        LoadCustomFont();
    }
    private static void LoadCustomFont()
    {
        string fontPath = System.IO.Path.Combine(Application.bin\Debug, "Resources", "Inter/Inter-Italic-VariableFont_opsz,wght.ttf");
        FontCollection.AddFontFile(fontPath);
    }
}
