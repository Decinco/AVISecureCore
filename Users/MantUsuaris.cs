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
        }

        public override void CustomFields()
        {
            // Campo imatge, que no se mostrará en la tabla
            Fields.Add("Photo", new byte[1]);
            IgnoredFields.Add("Photo");
        }

        public override void CustomDataBinding()
        {
            pbx_UserIcon.DataBindings.Clear();

            Binding imageBinding = new Binding("Image", dataBaseView.DataSource, "Photo");
            imageBinding.Format += new ConvertEventHandler(ImageBinding_Format);
            imageBinding.Parse += new ConvertEventHandler(ImageBinding_Parse);

            pbx_UserIcon.DataBindings.Add(imageBinding);

            UpdateImage();
        }

        public override void CustomPostLoadBehavior()
        {
            New += MantUsuaris_New;
        }

        private void MantUsuaris_New(object sender, EventArgs e)
        {
            pbx_UserIcon.DataBindings.Clear();

            pbx_UserIcon.Image = Resources.user;

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

        private void button1_Click(object sender, EventArgs e)
        {
            Image uploadedImage;
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                uploadedImage = Image.FromFile(fileDialog.FileName);
                pbx_UserIcon.Image = uploadedImage;

                UpdateImage();
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
    }
}

