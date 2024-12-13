using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AVISC_Controles
{
    public partial class SWUserOptions : UserControl
    {
        private bool ContextMenuExtended;

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

        public List<SWOption> Options { get; set; }


        public SWUserOptions()
        {
            InitializeComponent();

            ContextMenuExtended = false;

            SetDefaultOptions();
        }

        private void SetDefaultOptions()
        {
            // Opción "Cerrar Sesión"
            pnl_OptionList.Controls.Add(new SWOption() { 
                OptionName = "Cerrar Sesión"
            });


            // Opción "Salir del Programa"
            pnl_OptionList.Controls.Add(new SWOption()
            {
                OptionName = "Salir del Programa"
            });

        }

        private void UserPanel_Enter(object sender, EventArgs e)
        {
            pnl_User.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void UserPanel_Leave(object sender, EventArgs e)
        {
            pnl_User.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void UserPanel_Click(object sender, EventArgs e)
        {

            ContextMenuExtended = !ContextMenuExtended; // Invierte el estado del listado de opciones

            pnl_OptionList.Visible = ContextMenuExtended; // Actualiza el listado según su estado
        }
    }
}
