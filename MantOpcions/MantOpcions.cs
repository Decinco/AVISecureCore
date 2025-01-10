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
using AVISC_Maintenance;
using System.Resources;
using MantOpcions.Properties;
using AVISC_Global;

namespace MenuOptions
{
    public partial class MantOpcions : AVISC_MaintenanceBaseForm
    {
        public MantOpcions()
        {
            Taula = "MenuOptions";
            InitializeComponent();

        }

        public override void CustomDataGrid()
        {
            dataBaseView.Columns["Ensamblat"].HeaderText = "Ensamblado";
            dataBaseView.Columns["Classe"].HeaderText = "Clase del Formulario";
            dataBaseView.Columns["Nom"].HeaderText = "Nombre";
            dataBaseView.Columns["Descripcio"].HeaderText = "Descripción";
            dataBaseView.Columns["accesLvlReq"].HeaderText = "Niv. Acceso";

            // El icono se muestra de forma diferente
            dataBaseView.Columns["Imatge"].HeaderText = "";
            dataBaseView.Columns["Imatge"].Width = 70;
            dataBaseView.Columns["Imatge"].DisplayIndex = 0;
            ((DataGridViewImageColumn)dataBaseView.Columns["Imatge"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        public override void CustomFields()
        {
            // Campo imatge, que no se mostrará en la tabla
            Fields.Add("Imatge", new byte[1]);
        }

        public override void CustomDataBinding()
        {
            pbx_OptionIcon.DataBindings.Clear();

            Binding imageBinding = new Binding("Image", dataBaseView.DataSource, "Imatge", true, DataSourceUpdateMode.Never);
            imageBinding.Format += ImageBinding_Format;
            imageBinding.Parse += ImageBinding_Parse;

            pbx_OptionIcon.DataBindings.Add(imageBinding);
        }

        public override void CustomPostLoadBehavior()
        {
            New += MantUsuaris_New;
        }

        private void MantUsuaris_New(object sender, EventArgs e)
        {
            pbx_OptionIcon.DataBindings.Clear();

            pbx_OptionIcon.Image = Resources.marca_x_octagono__1_;

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
                    e.Value = Resources.marca_x_octagono__1_;
                }
            }
        }

        private void UpdateImage()
        {
            ImageConverter converter = new ImageConverter();
            byte[] imageByte = (byte[])converter.ConvertTo(pbx_OptionIcon.Image, typeof(byte[]));

            Fields["Imatge"] = imageByte;

            if (pbx_OptionIcon.DataBindings.Count > 0)
            {
                pbx_OptionIcon.DataBindings[0].BindingManagerBase.EndCurrentEdit();
                pbx_OptionIcon.DataBindings[0].WriteValue();
                pbx_OptionIcon.DataBindings[0].BindingManagerBase.EndCurrentEdit();
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
                pbx_OptionIcon.Image = ImageUtils.StretchImageToSquare(uploadedImage, 200);

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

    }
}
