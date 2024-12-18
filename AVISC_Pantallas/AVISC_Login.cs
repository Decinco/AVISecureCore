using System;
using System.Drawing;
using System.Windows.Forms;
using AVISC_Global;

namespace AVISC_Pantallas
{
    public partial class AVISC_Login : Form
    {
        private Image imageOpen, imageClose;

        private bool validar_login = false;

        AVISC_LoginChangePassword ChangePasswordForm;

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
            txt_pass.UseSystemPasswordChar = false;

            // Redondear los bordes de los paneles
            RoundUtils.RedondearEsquinas(pnl_Login, 40); // Redondear el panel de login
            RoundUtils.RedondearEsquinas(btn_Login, 20); // Redondear el botón de login
            RoundUtils.RedondearEsquinas(panel_user, topLeft: 10, topRight: 10); 
            RoundUtils.RedondearEsquinas(panel_pass, topLeft: 10, topRight: 10);
        }

        private void btm_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_pass.Text == "12345aA")
                {
                    ChangePasswordForm = new AVISC_LoginChangePassword { username = txt_user.Text, passwword = txt_pass.Text };
                    ChangePasswordForm.Show();
                    Hide();
                }
                else
                {
                    validar_login = LoginData.PerformLogin(txt_user.Text, txt_pass.Text, null);

                    if (validar_login)
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

        private void pbx_ojo_Click_1(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoggedOut(object sender, FormClosingEventArgs e)
        {
            Show();
        }
    }
}
