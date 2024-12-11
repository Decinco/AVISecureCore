using System;
using System.Drawing;
using System.Windows.Forms;

namespace AVISC_Controles
{
    public partial class SWUserOptions : UserControl
    {

        public string Username
        {
            get { return lbl_Username.Text; }
            set { lbl_Username.Text = value; }
        }

        public string Role
        {
            get { return lbl_Role.Text; }
            set { lbl_Role.Text = value; }
        }

        public Image UserProfilePicture
        {
            get { return img_UserProfilePicture.Image; }
            set { img_UserProfilePicture.Image = value; }
        }


        public SWUserOptions()
        {
            InitializeComponent();
        }

        private void UserPanel_Enter(object sender, EventArgs e)
        {
            pnl_User.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void UserPanel_Leave(object sender, EventArgs e)
        {
            pnl_User.BackColor = Color.FromArgb(0, 0, 0);
        }
    }
}
