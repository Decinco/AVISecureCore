using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using AVISC_BaseForms;

namespace AVISC_FTP
{
    public partial class FTPExplorer : AVISC_CloseableFeatureForm
    {
        private FTPConnection ftpConnection;
        private string archivoSeleccionado = ""; // Variable para almacenar el archivo seleccionado
        private Dictionary<TreeNode, string> nodeToPathMap; // Mapa para almacenar la ruta completa de cada nodo

        public FTPExplorer()
        {
            InitializeComponent();
            ftpConnection = new FTPConnection();  // Iniciar conexión FTP al crear el formulario
            nodeToPathMap = new Dictionary<TreeNode, string>(); // Inicializamos el diccionario
        }

        private void btnGetFile_Click(object sender, EventArgs e)
        {
            using (Form explorerForm = new Form())
            {
                explorerForm.Text = "Explorador FTP";
                explorerForm.Size = new System.Drawing.Size(400, 500);

                TreeView treeView = new TreeView { Dock = DockStyle.Fill };
                explorerForm.Controls.Add(treeView);

                treeView.BeforeExpand += (s, ev) =>
                {
                    TreeNode selectedNode = ev.Node;

                    if (selectedNode.Nodes.Count == 1 && selectedNode.Nodes[0].Text == "Cargando...")
                    {
                        selectedNode.Nodes.Clear(); // Eliminar nodo temporal
                        string ruta = nodeToPathMap[selectedNode]; // Obtener la ruta completa del directorio
                        var archivos = ftpConnection.listarDirectoriosYArchivosFTP(ruta);

                        foreach (var archivo in archivos)
                        {
                            TreeNode nuevoNodo = new TreeNode(archivo);

                            // Si es una carpeta, agregar un nodo temporal para permitir expansión
                            if (archivo.EndsWith("/"))
                            {
                                nuevoNodo.Nodes.Add("Cargando...");
                            }

                            selectedNode.Nodes.Add(nuevoNodo);
                            // Almacenar la ruta completa del nodo en el diccionario
                            nodeToPathMap[nuevoNodo] = Path.Combine(ruta, archivo).Replace("\\", "/");
                        }
                    }
                };

                treeView.AfterSelect += (s, ev) =>
                {
                    if (ev.Node != null && !ev.Node.Text.EndsWith("/")) // Es un archivo
                    {
                        // Obtener la ruta completa del archivo
                        archivoSeleccionado = nodeToPathMap[ev.Node];
                        lblArchivoSeleccionado.Text = archivoSeleccionado;
                    }
                };

                // Inicializamos el explorador en la raíz del servidor FTP
                cargarDirectorios(treeView, "");
                explorerForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(archivoSeleccionado))
            {
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Selecciona la carpeta de destino";

                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        string rutaLocal = Path.Combine(folderDialog.SelectedPath, Path.GetFileName(archivoSeleccionado));
                        bool exito = ftpConnection.descargarArchivoFTP(archivoSeleccionado, rutaLocal);
                        lblEstado.Text = exito ? $"Archivo descargado correctamente en: {rutaLocal}" : "Error al descargar el archivo.";
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

        private void cargarDirectorios(TreeView treeView, string ruta)
        {
            try
            {
                treeView.Nodes.Clear();
                var elementos = ftpConnection.listarDirectoriosYArchivosFTP(ruta);

                foreach (var elemento in elementos)
                {
                    TreeNode nodo = new TreeNode(elemento);

                    // Si el elemento es un directorio, agregar "/" al final para identificarlo
                    if (elemento.EndsWith("/"))
                    {
                        nodo.Nodes.Add("Cargando..."); // Nodo temporal para expandir después
                    }

                    treeView.Nodes.Add(nodo);
                    // Almacenamos la ruta completa del nodo en el diccionario
                    nodeToPathMap[nodo] = Path.Combine(ruta, elemento).Replace("\\", "/");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar directorios: " + ex.Message);
            }
        }
    }
}
