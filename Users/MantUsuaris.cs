﻿using System;
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
using AVISC_Global;
using AVISC_CrystalReport;

namespace Users
{
    public partial class MantUsuaris : AVISC_MaintenanceBaseForm
    {
        public MantUsuaris()
        {
            Taula = "Users";

            InitializeComponent();
        }

        protected override void CustomDataGrid()
        {
            dataBaseView.Columns["CodeUser"].HeaderText = "Código";
            dataBaseView.Columns["UserName"].HeaderText = "Nombre";
            dataBaseView.Columns["Login"].HeaderText = "Nombre de Usuario";
            dataBaseView.Columns["Password"].HeaderText = "Contraseña";

            // La foto de perfil se muestra de forma diferente
            dataBaseView.Columns["Photo"].HeaderText = "";
            ((DataGridViewImageColumn)dataBaseView.Columns["Photo"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataBaseView.Columns["Photo"].DisplayIndex = 0;
            dataBaseView.Columns["Photo"].Width = 72;
        }

        protected override void CustomFields()
        {
            // Campo imatge, que no se mostrará en la tabla
            Fields.Add("Photo", new byte[1]);
            Fields.Remove("idUser");
            IgnoredFields.Add("Password");
            IgnoredFields.Add("idUser");
        }

        protected override void CustomDataBinding()
        {
            pbx_UserIcon.DataBindings.Clear();

            Binding imageBinding = new Binding("Image", dataBaseView.DataSource, "Photo", true, DataSourceUpdateMode.Never);
            imageBinding.Format += ImageBinding_Format;
            imageBinding.Parse += ImageBinding_Parse;

            pbx_UserIcon.DataBindings.Add(imageBinding);
        }

        protected override void CustomPostLoadBehavior()
        {
            New += MantUsuaris_New;
            Saved += MantUsuaris_Saved;
        }

        private void MantUsuaris_Saved(object sender, EventArgs e)
        {
            stb_IDCard.Enable();
        }

        private void MantUsuaris_New(object sender, EventArgs e)
        {
            pbx_UserIcon.DataBindings.Clear();

            pbx_UserIcon.Image = Resources.user;

            txt_passwordDataBoundButNotShown.Text = "12345aA";

            UpdateImage();

            // Al crear un nuevo usuario, el botón no se debe poder pulsar.
            stb_IDCard.Disable();
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
        private void stb_ChangeProfile_Click(object sender, EventArgs e)
        {
            Image uploadedImage;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Imágenes (*.png, *.jpg)|*.png;*.jpg|Animaciones GIF (*.gif)|*.gif";
            fileDialog.Title = "Por favor, elige una imagen";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                uploadedImage = Image.FromFile(fileDialog.FileName);
                pbx_UserIcon.Image = ImageUtils.StretchImageToSquare(uploadedImage, 200);

                UpdateImage();
            }
        }

        // Muestra de tarjeta identificativa
        private void stb_IDCard_Click(object sender, EventArgs e)
        {
            CardIdUser cardIdUser = new CardIdUser(int.Parse(swtxtIdUser.Text));
            cardIdUser.Show();
        }


        // Restablecimiento de contraseña
        private void txt_passwordDataBoundButNotShown_TextChanged(object sender, EventArgs e)
        {
            if (txt_passwordDataBoundButNotShown.Text == "12345aA")
            {
                stb_ResetPassword.Disable();
            }
            else
            {
                stb_ResetPassword.Enable();
            }
        }

        private void stb_ResetPassword_ButtonClick(object sender, EventArgs e)
        {
            txt_passwordDataBoundButNotShown.Text = "12345aA";
            if (pbx_UserIcon.DataBindings.Count > 0)
            {
                txt_passwordDataBoundButNotShown.DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }
    }
}

