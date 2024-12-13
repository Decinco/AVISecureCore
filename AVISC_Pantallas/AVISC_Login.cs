using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVISC_DataAccess;

namespace AVISC_Pantallas
{
    public partial class AVISC_Login : Form
    {
        private Image imageOpen, imageClose;
        private bool validar_login = false;
        LoginData login = new LoginData();
        AVISC_Border aVISC_Border = new AVISC_Border();
        AVISC_LoginChangePassword loginChangePassword;

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
            txt_pass.UseSystemPasswordChar = false;
        }

        private void btm_login_Click(object sender, EventArgs e)
        {
            // hacer primero verificar si la pass es 12345aA si es hacer el changepass, sino simplemente acceder a la base de datos y ya
            try
            {
                if (txt_pass.Text == "12345aA")
                {
                    Hide();
                    loginChangePassword = new AVISC_LoginChangePassword { username = txt_user.Text, passwword = txt_pass.Text };
                    loginChangePassword.Show();
                }
                else
                {
                    validar_login = login.PerformLogin(txt_user.Text, txt_pass.Text, null);

                    if (validar_login == true)
                    {
                        pnl_warning.Visible = false;
                        this.Hide();
                        aVISC_Border.Show();
                    }
                    else
                    {
                        pnl_warning.Visible = true;
                        lbl_error.Visible = true;
                        lbl_error.Text = "Nombre de usuario o contraseña incorrectos. Vuelve a intentarlo.";
                    }
                }
            }
            catch (Exception)
            {

                pnl_warning.Visible = true;
                lbl_error.Text = "Nombre de usuario o contraseña incorrectos.";
            }
        }
        private void pbx_ojo_Click(object sender, EventArgs e)
        {
            if (validar_login)
            {
                txt_pass.UseSystemPasswordChar = false;
                pbx_ojo.Image = imageOpen;
                validar_login = false;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
                pbx_ojo.Image = imageClose;
                validar_login = true;
            }
        }
    }
}