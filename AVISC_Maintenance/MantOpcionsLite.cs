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
using AVISC_Maintenance.Properties;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AVISC_Maintenance
{
    public partial class MantOpcionsLite : BaseForm
    {
        public MantOpcionsLite()
        {
            Taula = "MenuOptions";

            InitializeComponent();
        }

        public override void CustomFields()
        {
            // Campo imatge, que no se mostrará en la tabla
            Fields.Add("Imatge", new byte[1]);
            IgnoredFields.Add("Imatge");
        }

        public override void CustomDataBinding()
        {
            pbx_Icon.DataBindings.Clear();

            Binding imageBinding = new Binding("Image", DTS.Tables[0], "Imatge");
            imageBinding.Format += ImageBinding_Format;
            imageBinding.Parse += ImageBinding_Parse;

            pbx_Icon.DataBindings.Add(imageBinding);
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
                    e.Value = Resources.octagon_xmark;
                }
            }
        }

        public override void CustomHeaders()
        {
            // Columnas de la tabla
            dataBaseView.Columns["Nom"].HeaderText = "Opción";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image uploadedImage;
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                uploadedImage = Image.FromFile(fileDialog.FileName);
                pbx_Icon.Image = uploadedImage;
                ImageConverter converter = new ImageConverter();
                byte[] imageByte = (byte[])converter.ConvertTo(uploadedImage, typeof(byte[]));

                Fields["Imatge"] = imageByte;
            }

            if (pbx_Icon.DataBindings.Count > 0)
            {
                pbx_Icon.DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }
    }
}
