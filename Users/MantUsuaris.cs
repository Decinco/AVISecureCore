using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVISC_Maintenance;
using AVISC_Controles;
using System.IO;
using System.Resources;
using Users.Properties;
using System.Xml.Serialization;

namespace Users
{
    public partial class MantUsuaris : BaseForm
    {
        public MantUsuaris()
        {
            Taula = "Users";

            InitializeComponent();
        }

        public override void CustomHeaders()
        {
            dataBaseView.Columns["CodeUser"].HeaderText = "Código";
            dataBaseView.Columns["UserName"].HeaderText = "Nombre";
            dataBaseView.Columns["Login"].HeaderText = "Nombre de Usuario";
            dataBaseView.Columns["Password"].HeaderText = "Contraseña";

            // La foto de perfil se muestra de forma diferente
            dataBaseView.Columns["Photo"].HeaderText = "";
            dataBaseView.Columns["Photo"].Width = 60;
            dataBaseView.Columns["Photo"].DisplayIndex = 0;
            ((DataGridViewImageColumn)dataBaseView.Columns["Photo"]).ImageLayout = DataGridViewImageCellLayout.Stretch;

        }

        public override void CustomFields()
        {
            // Campo imatge, que no se mostrará en la tabla
            Fields.Add("Photo", new byte[1]);
            IgnoredFields.Add("Password");
        }

        public override void CustomDataBinding()
        {
            pbx_UserIcon.DataBindings.Clear();

            Binding imageBinding = new Binding("Image", dataBaseView.DataSource, "Photo", true, DataSourceUpdateMode.Never);
            imageBinding.Format += ImageBinding_Format;
            imageBinding.Parse += ImageBinding_Parse;

            pbx_UserIcon.DataBindings.Add(imageBinding);
        }

        public override void CustomPostLoadBehavior()
        {
            New += MantUsuaris_New;
        }

        private void MantUsuaris_New(object sender, EventArgs e)
        {
            pbx_UserIcon.DataBindings.Clear();

            pbx_UserIcon.Image = Resources.user;

            txt_passwordDataBoundButNotShown.Text = "12345aA";

            UpdateImage();
        }

        private void ImageBinding_Parse(object sender, ConvertEventArgs e)
        {
            if (e.DesiredType == typeof(byte[]))
            {
                if (e.Value is Image image)
                {
                    ImageConverter converter = new ImageConverter();
                    e.Value = (byte[])converter.ConvertTo(image, typeof(byte[]));
                }
            }
        }

        private void ImageBinding_Format(object sender, ConvertEventArgs e)
        {
            if (e.DesiredType == typeof(Image))
            {
                if (e.Value is byte[] imageData)
                {
                    e.Value = Image.FromStream(new MemoryStream(imageData));
                }
                else
                {
                    e.Value = Resources.user;
                }
            }
        }

        private void UpdateImage()
        {
            ImageConverter converter = new ImageConverter();
            byte[] imageByte = (byte[])converter.ConvertTo(pbx_UserIcon.Image, typeof(byte[]));

            Fields["Photo"] = imageByte;

            if (pbx_UserIcon.DataBindings.Count > 0)
            {
                pbx_UserIcon.DataBindings[0].BindingManagerBase.EndCurrentEdit();
                pbx_UserIcon.DataBindings[0].WriteValue();
                pbx_UserIcon.DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        // Botón de cambio de imagen
        private void button1_Click(object sender, EventArgs e)
        {
            Image uploadedImage;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Imágenes PNG (*.png)|*.png";
            fileDialog.Title = "Por favor, elige una imagen";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                uploadedImage = Image.FromFile(fileDialog.FileName);
                pbx_UserIcon.Image = uploadedImage;

                UpdateImage();
            }
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            pnl_ChangeImage.BackColor = Color.FromArgb(42, 42, 42);
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            pnl_ChangeImage.BackColor = Color.FromArgb(33, 33, 33);
        }

        // Muestra de tarjeta identificativa
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            pnl_IDCard.BackColor = Color.FromArgb(42, 42, 42); 
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            pnl_IDCard.BackColor = Color.FromArgb(33, 33, 33);
        }


        // Restablecimiento de contraseña
        private void label6_Click(object sender, EventArgs e)
        {
            if (txt_passwordDataBoundButNotShown.Text != "12345aA")
            {
                txt_passwordDataBoundButNotShown.Text = "12345aA";
                if (pbx_UserIcon.DataBindings.Count > 0)
                {
                    txt_passwordDataBoundButNotShown.DataBindings[0].BindingManagerBase.EndCurrentEdit();
                }
            }
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            if (txt_passwordDataBoundButNotShown.Text != "12345aA")
            {
                pnl_ResetPassword.BackColor = Color.FromArgb(42, 42, 42);
            }
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            if (txt_passwordDataBoundButNotShown.Text != "12345aA")
            {
                pnl_ResetPassword.BackColor = Color.FromArgb(33, 33, 33);
            }
        }

        private void txt_passwordDataBoundButNotShown_TextChanged(object sender, EventArgs e)
        {
            if (txt_passwordDataBoundButNotShown.Text == "12345aA")
            {
                pnl_ResetPassword.BackColor = Color.FromArgb(20, 20, 20);
                lbl_ResetPassword.ForeColor = Color.Gray;
                lbl_ResetPassword.Cursor = Cursors.Default;
            }
            else
            {
                pnl_ResetPassword.BackColor = Color.FromArgb(33, 33, 33);
                lbl_ResetPassword.ForeColor = Color.White;
                lbl_ResetPassword.Cursor = Cursors.Hand;
            }
        }
    }
}

