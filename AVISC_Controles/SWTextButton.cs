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
    public partial class SWTextButton : UserControl
    {

        public string ButtonText
        {
            get { return lbl_Button.Text; }
            set { lbl_Button.Text = value; }
        }

        public bool ButtonEnabled { 
            get { return ButtonEnabledInternal; } 
            set { UpdateState(value); }
        }
        private bool ButtonEnabledInternal;

        private event EventHandler ButtonClick;

        public SWTextButton()
        {
            InitializeComponent();
        }

        public void Enable()
        {
            UpdateState(true);
        }

        public void Disable()
        {
            UpdateState(false);
        }

        private void UpdateState(bool newValue)
        {
            ButtonEnabledInternal = newValue;

            if (ButtonEnabledInternal)
            {
                pnl_Button.BackColor = Color.FromArgb(20, 20, 20);
                lbl_Button.ForeColor = Color.Gray;
                lbl_Button.Cursor = Cursors.Default;
            }
            else
            {
                pnl_Button.BackColor = Color.FromArgb(33, 33, 33);
                lbl_Button.ForeColor = Color.White;
                lbl_Button.Cursor = Cursors.Hand;
            }
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            if (ButtonEnabledInternal)
            {
                ButtonClick?.Invoke(this, e);
            }
        }

        private void MouseEnterEvent(object sender, EventArgs e)
        {
            if (ButtonEnabledInternal)
            {
                pnl_Button.BackColor = Color.FromArgb(42, 42, 42);
            }
        }

        private void MouseLeaveEvent(object sender, EventArgs e)
        {
            if (ButtonEnabledInternal)
            {
                pnl_Button.BackColor = Color.FromArgb(33, 33, 33);
            }
        }
    }
}
