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
            string passNew;
            try
            {
                pbx_newPass.Visible = true;
                pbx_newPass.Image = imageOpen;
                pnl_warning.Visible = true;
                passNew = ChangeAdminPassword();
                if (txt_pass.Text == "12345aA")
                {
                    validar_login = login.PerformLogin(txt_user.Text, passNew);
                    if (validar_login)
                    {
                        pnl_warning.Visible = false;
                        this.Hide();
                        aVISC_Border.Show();
                        MessageBox.Show("Login exitoso.");
                    }
                    else
                    {
                        pnl_warning.Visible = true;
                        lbl_error.Text = "Nombre de usuario o contraseña incorrectos. Vuelve a intentarlo.";
                    }

                }
                else
                {
                    validar_login = login.PerformLogin(txt_user.Text, txt_pass.Text);
                }

                if (validar_login == true && txt_user.Text == txt_pass.Text)
                {
                    pnl_warning.Visible = false;
                    this.Hide();
                    aVISC_Border.Show();
                    MessageBox.Show("Todo correcto");
                }
            }
            catch (Exception)
            {

                pnl_warning.Visible = true;
                lbl_error.Text = "Nombre de usuario o contraseña incorrectos. Vuelve a intentarlo.";
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
        private string ChangeAdminPassword()
        {
            string passNew;

            txt_pass.UseSystemPasswordChar = false;
            lbl_error.Visible = true;
           
            lbl_titulo.Text = "Nueva Contraseña";
            lbl_user.Text = "Contraseña";
            lbl_pass.Text = "Confirmar contraseña";
            btm_login.Text = "Generar";
            lbl_error.Text = "Se ha pedido un cambio para la contraseña. Por favor, crea una nueva.";
            txt_user.PasswordChar = '·';
            txt_user.Text = "";

            lbl_error.ForeColor = Color.Black;
            pnl_warning.BackColor = Color.FromArgb(255, 241, 102);
            
            passNew = txt_pass.Text = "";

            return passNew;
        }

        private void pbx_newPass_Click(object sender, EventArgs e)
        {
            if (validar_login)
            {
                txt_user.UseSystemPasswordChar = false;
                pbx_newPass.Image = imageOpen;
                validar_login = false;
            }
            else
            {
                txt_user.UseSystemPasswordChar = true;
                pbx_newPass.Image = imageClose;
                validar_login = true;
            }
        }
    }
}