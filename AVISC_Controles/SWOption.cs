using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVISC_Controles
{
    public partial class SWOption : UserControl
    {
        [Browsable(true)]
        [Category("Action")] // Necesarios para que se pueda ver en el Diseñador
        public event EventHandler OptionClick;

        public string OptionName {
            get { return lbl_OptionName.Text; }
            set { lbl_OptionName.Text = value; } 
        }

        public Image OptionIcon
        {
            get { return img_OptionIcon.Image; }
            set { img_OptionIcon.Image = value; }
        }

        public SWOption()
        {
            InitializeComponent();

            if (lbl_OptionName.ForeColor != Color.White)
            {
                lbl_OptionName.ForeColor = Color.White;
            }
        }

        private void Option_Enter(object sender, EventArgs e)
        {
            pnl_Option.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void Option_Leave(object sender, EventArgs e)
        {
            pnl_Option.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void PassEvent(object sender, EventArgs e)
        {
            OptionClick?.Invoke(this, e);
        }
    }
}
