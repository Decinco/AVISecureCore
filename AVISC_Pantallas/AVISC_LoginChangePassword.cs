﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVISC_DataAccess;

namespace AVISC_Pantallas
{
    public partial class AVISC_LoginChangePassword : Form
    {
        private Image imageOpen, imageClose;
        LoginData login = new LoginData();
        private bool validar_login = false;
        AVISC_Border aVISC_Border = new AVISC_Border();

        private string Username;

        public string username
        {
            get { return Username; }
            set { Username = value; }
        }

        private string Passwword;

        public string passwword
        {
            get { return Passwword; }
            set { Passwword = value; }
        }


        public AVISC_LoginChangePassword()
        {
            InitializeComponent();
        }

        private void AVISC_LoginChangePassword_Load(object sender, EventArgs e)
        {
            imageOpen = Bitmap.FromFile(@"Resources\ojo-abierto.png");

            imageClose = Bitmap.FromFile(@"Resources\ojo-cerrado.png");

            pbx_newPass.Image = imageOpen;
            pbx_confirmNewPass.Image = imageOpen;

            txt_confirmNewPass.UseSystemPasswordChar = false;
            txt_newPass.UseSystemPasswordChar = false;
        }

        private void pbx_newPass_Click(object sender, EventArgs e)
        {
            if (validar_login)
            {
                txt_newPass.UseSystemPasswordChar = false;
                pbx_newPass.Image = imageOpen;
                validar_login = false;
            }
            else
            {
                txt_newPass.UseSystemPasswordChar = true;
                pbx_newPass.Image = imageClose;
                validar_login = true;
            }
        }

        private void pbx_confirmNewPass_Click(object sender, EventArgs e)
        {
            if (validar_login)
            {
                txt_confirmNewPass.UseSystemPasswordChar = false;
                pbx_confirmNewPass.Image = imageOpen;
                validar_login = false;
            }
            else
            {
                txt_confirmNewPass.UseSystemPasswordChar = true;
                pbx_confirmNewPass.Image = imageClose;
                validar_login = true;
            }
        }
        private void btm_generationNewPass_Click(object sender, EventArgs e)
        {
            int valorX = 125;
            if (txt_confirmNewPass.Text != txt_newPass.Text)
            {
                lbl_error.Text = "Contraseña incorrecta1. Vuelve a intentarlo.";
                lbl_error.Location = new Point(lbl_error.Location.X + valorX, lbl_error.Location.Y);
            }
            else
            {
                validar_login = login.PerformLogin(username, Passwword, txt_confirmNewPass.Text);

                if (validar_login)
                {
                    pnl_warning.Visible = false;
                    this.Hide();
                    aVISC_Border.Show();
                }
                else
                {
                    lbl_error.Text = "Contraseña incorrecta2. Vuelve a intentarlo.";
                    lbl_error.Location = new Point(lbl_error.Location.X + valorX, lbl_error.Location.Y);
                }
            }
        }        
    }
}