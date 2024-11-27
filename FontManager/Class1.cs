using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;


public static class FontManager
{
    public static PrivateFontCollection FontCollection { get; } = new PrivateFontCollection();

    static FontManager()
    {
        LoadCustomFont();
    }

    private static void LoadCustomFont()
    {
        string fontPath = System.IO.Path.Combine(Application.StartupPath, "Resources", "TuFuente.ttf");
        FontCollection.AddFontFile(fontPath);
    }

    public static Font GetFont(float size, FontStyle style = FontStyle.Regular)
    {
        return new Font(FontCollection.Families[0], size, style);
    }

    public static void ApplyCustomFont(Control parent)
    {
        foreach (Control control in parent.Controls)
        {
            control.Font = new Font(FontCollection.Families[0], control.Font.Size, control.Font.Style);
            if (control.HasChildren)
            {
                ApplyCustomFont(control);
            }
        }
    }
}

