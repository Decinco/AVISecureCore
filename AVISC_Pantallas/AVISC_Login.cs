﻿using System;
using System.Drawing;
using System.Windows.Forms;
using AVISC_Global;

namespace AVISC_Pantallas
{
    public partial class AVISC_Login : Form
    {
        private Image imageOpen, imageClose;

        AVISC_Border Border; 

        public AVISC_Login()
        {
            InitializeComponent();
        }

        private void AVISC_Login_Load(object sender, EventArgs e)
        {
            pbx_back.SendToBack();
            pbx_back.Dock = DockStyle.Fill;

            imageOpen = Bitmap.FromFile(@"Resources\ojo-abierto.png");
            imageClose = Bitmap.FromFile(@"Resources\ojo-cerrado.png");

            pbx_ojo.Image = imageOpen;

            // Redondear los bordes de los paneles
            RoundUtils.RedondearEsquinas(pnl_Login, 40); // Redondear el panel de login
            RoundUtils.RedondearEsquinas(btn_Login, 20); // Redondear el botón de login
            RoundUtils.RedondearEsquinas(panel_user, topLeft: 10, topRight: 10); 
            RoundUtils.RedondearEsquinas(panel_pass, topLeft: 10, topRight: 10);
        }
        private void btm_login_Click_1(object sender, EventArgs e)
        {

            LoginStatus status;
            // hacer primero verificar si el password es 12345aA y hacer el changepass, sino, simplemente acceder a la base de
            // datos y ya
            try
            {
                if (txt_pass.Text == null || txt_user.Text == null)
                {
                    pnl_warning.Visible = true;
                    lbl_error.Text = "Rellena el formulario, por favor.";
                }
                else
                {

                    status = LoginData.PerformLogin(txt_user.Text, txt_pass.Text);

                    if (status == LoginStatus.PasswordChange)
                    {
                        ShowNewPassword();
                    }
                    else if (status == LoginStatus.Success)
                    {
                        Border = new AVISC_Border();
                        pnl_warning.Visible = false;

                        Border.FormClosing += LoggedOut; // Suscribirse al evento FormClosing

                        Border.Show();
                        Hide();
                    }
                    else
                    {
                        pnl_warning.Visible = true;
                        lbl_error.Text = "Nombre de usuario o contraseña incorrectos. Vuelve a intentarlo.";
                    }
                }
            }
            catch (Exception ex)
            {
                pnl_warning.Visible = true;
                lbl_error.Text = "Ha ocurrido un error.";
                MessageBox.Show(ex.ToString(), "Parece que estás en el bando equivocado...");

                Application.Exit();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoggedOut(object sender, FormClosingEventArgs e)
        {
            Show();
        }

        private void pbx_newPass_Click(object sender, EventArgs e)
        {
            if (txt_newPass.UseSystemPasswordChar)
            {
                txt_newPass.UseSystemPasswordChar = false;
                pbx_newPass.Image = imageOpen;
            }
            else
            {
                txt_newPass.UseSystemPasswordChar = true;
                pbx_newPass.Image = imageClose;
            }
        }

        private void pbx_ojo_Click(object sender, EventArgs e)
        {
            if (txt_pass.UseSystemPasswordChar)
            {
                txt_pass.UseSystemPasswordChar = false;
                pbx_ojo.Image = imageOpen;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
                pbx_ojo.Image = imageClose;
            }
        }

        private void pbx_confirmNewPass_Click(object sender, EventArgs e)
        {
            if (txt_confirmNewPass.UseSystemPasswordChar)
            {
                txt_confirmNewPass.UseSystemPasswordChar = false;
                pbx_confirmNewPass.Image = imageOpen;
            }
            else
            {
                txt_confirmNewPass.UseSystemPasswordChar = true;
                pbx_confirmNewPass.Image = imageClose;
            }
        }

        private void ShowNewPassword()
        {
            pbx_newPass.Image = imageOpen;
            pbx_confirmNewPass.Image = imageOpen;

            pnl_confirmNewPass.Show();
            pnl_warning.Visible = true;
            lbl_error.Visible = true;
            txt_newPass.UseSystemPasswordChar = false;
            txt_newPass.UseSystemPasswordChar = false;
            lbl_error.ForeColor = Color.Black;
            pnl_warning.BackColor = Color.FromArgb(255, 241, 102);
            lbl_error.Text = "Se ha pedido un cambio para la contraseña. Por favor, crea una nueva.";

            // Activar Tabulación
            txt_newPass.TabStop = true;
            txt_confirmNewPass.TabStop = true;
            btm_generationNewPass.TabStop = true;

            txt_user.TabStop = false;
            txt_pass.TabStop = false;
            btm_login.TabStop = false;



            pnl_Login.Hide();
            lbl_titulo.Hide();
            lbl_pass.Hide();
            lbl_user.Hide();
        }

        private void btm_generationNewPass_Click(object sender, EventArgs e)
        {
            ChangeNewPassword();
        }

        private void SupressEnterAndNextTextbox(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void ChangeNewPassword()
        {
            bool validar_login;
            validar_login = LoginData.ChangeNewPassword(txt_newPass.Text, txt_confirmNewPass.Text, txt_user.Text);

            if (validar_login)
            {
                Border = new AVISC_Border();

                pnl_warning.Visible = false;
                pnl_confirmNewPass.Hide();
                Hide();
                Border.Show();
            }
            else
            {
                lbl_error.Text = "Las contraseñas no coinciden.";
                lbl_error.ForeColor = Color.White;
                pnl_warning.BackColor = Color.FromArgb(255, 46, 46);
            }
        }
    }
}
