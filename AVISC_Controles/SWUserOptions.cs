﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;

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

        public string Category
        {
            get { return lbl_Category.Text; }
            set { lbl_Category.Text = value; }
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

        private void LogOut(object sender, EventArgs e)
        {
            FindForm().Close();
        }

        private void LogOff(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
