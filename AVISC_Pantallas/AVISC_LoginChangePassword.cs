using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVISC_Global;

namespace AVISC_Pantallas
{
    public partial class AVISC_LoginChangePassword : Form
    {
        private Image imageOpen, imageClose;

        private bool validar_login = false;

        AVISC_Border border;

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
                validar_login = LoginData.PerformLogin(username, Passwword, txt_confirmNewPass.Text);

                if (validar_login)
                {
                    border = new AVISC_Border();

                    pnl_warning.Visible = false;
                    Hide();
                    border.Show();
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
