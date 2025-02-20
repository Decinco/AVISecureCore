using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVISC_BaseForms;

namespace AVISC_FTP
{
    public partial class FTPExplorer : AVISC_CloseableFeatureForm
    {
        private FTPConnection ftpConnection;

        public FTPExplorer()
        {
            InitializeComponent();
            ftpConnection = new FTPConnection();  // Iniciar conexión FTP al crear el formulario
            listarArchivos();
        }

        // Método para listar archivos desde el servidor FTP
        private void listarArchivos()
        {
            try
            {
                // Llamar a la función de FTPConnection para listar los archivos del servidor
                var archivos = ftpConnection.listarArchivosFTP(""); // Lista de archivos del directorio raíz o el directorio que desees

                // Limpiar y agregar archivos al ListBox
                lstArchivos.Items.Clear();
                foreach (var archivo in archivos)
                {
                    lstArchivos.Items.Add(archivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar archivos: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstArchivos.SelectedItem != null)
            {
                string archivoSeleccionado = lstArchivos.SelectedItem.ToString();

                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Selecciona la carpeta de destino";

                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        string rutaLocal = System.IO.Path.Combine(folderDialog.SelectedPath, archivoSeleccionado);

                        // Descargar el archivo seleccionado
                        bool exito = ftpConnection.descargarArchivoFTP(archivoSeleccionado, rutaLocal);
                        if (exito)
                        {
                            lblEstado.Text = "Archivo descargado correctamente en: " + rutaLocal;
                        }
                        else
                        {
                            lblEstado.Text = "Error al descargar el archivo.";
                        }
                    }
                    else
                    {
                        lblEstado.Text = "Selección de carpeta cancelada.";
                    }
                }
            }
            else
            {
                lblEstado.Text = "Selecciona un archivo primero.";
            }
        }
    }
}
