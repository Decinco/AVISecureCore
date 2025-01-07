using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVISC_Maintenance.Properties;
using static System.Resources.ResXFileRef;

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
            Fields.Add("Imatge", "");
            IgnoredFields.Add("Imatge");
        }

        public override void CustomDataBinding()
        {
            RefreshImage();

            txt_ImgByteArray.DataBindings.Add("Text", dataBaseView.DataSource, "Imatge");
        }

        public override void CustomHeaders()
        {
            // Columnas de la tabla
            dataBaseView.Columns["Nom"].HeaderText = "Opción";
        }

        public override void CustomPostLoadBehavior()
        {
            // Eventos
            BeforeSave += ActualitzarDadesImatge;
        }

        private void ActualitzarDadesImatge(object sender, EventArgs e)
        {
            Fields.Add("Imatge", "");
        }

        private void RefreshImage()
        {
            ImageConverter converter = new ImageConverter();

            try
            {
                byte[] imageByte = Encoding.ASCII.GetBytes(dataBaseView.SelectedRows[0].Cells["Imatge"].Value.ToString());
                pbx_Icon.Image = (Bitmap)converter.ConvertFrom(imageByte);
            }
            catch (Exception)
            {
                pbx_Icon.Image = Resources.octagon_xmark;
            }
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

                string imageString = Encoding.ASCII.GetString(imageByte);
                dataBaseView.SelectedRows[0].Cells["Imatge"].Value = imageString;
                Fields["Imatge"] = imageString;
            }

            RefreshImage();
        }
    }
}
