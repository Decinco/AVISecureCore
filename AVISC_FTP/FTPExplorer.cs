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
                        cargarDirectorios(selectedNode, ruta);
                    }
                };

                treeView.AfterSelect += (s, ev) =>
                {
                    if (ev.Node != null && !ev.Node.Text.EndsWith("/")) // Es un archivo
                    {
                        archivoSeleccionado = nodeToPathMap[ev.Node];
                        lblArchivoSeleccionado.Text = archivoSeleccionado;
                    }
                };

                // Inicializamos el explorador en la raíz del servidor FTP
                TreeNode rootNode = new TreeNode("/");
                treeView.Nodes.Add(rootNode);
                nodeToPathMap[rootNode] = "/";
                cargarDirectorios(rootNode, "");

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

        private void cargarDirectorios(TreeNode parentNode, string ruta)
        {
            try
            {
                var elementos = ftpConnection.listarDirectoriosYArchivosFTP(ruta);

                foreach (var elemento in elementos)
                {
                    TreeNode nodo = new TreeNode(elemento);
                    string rutaCompleta = Path.Combine(ruta, elemento).Replace("\\", "/");
                    nodeToPathMap[nodo] = rutaCompleta;
                    parentNode.Nodes.Add(nodo);

                    if (elemento.EndsWith("/")) // Si es un directorio, agregar nodo temporal
                    {
                        nodo.Nodes.Add("Cargando...");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar directorios: " + ex.Message);
            }
        }

        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Selecciona el archivo a subir";
                openFileDialog.Filter = "Archivos (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string archivoLocal = openFileDialog.FileName;

                    using (Form explorerForm = new Form())
                    {
                        explorerForm.Text = "Selecciona el directorio remoto en FTP";
                        explorerForm.Size = new System.Drawing.Size(400, 500);

                        TreeView treeView = new TreeView { Dock = DockStyle.Fill };
                        explorerForm.Controls.Add(treeView);

                        treeView.BeforeExpand += (s, ev) =>
                        {
                            TreeNode selectedNode = ev.Node;
                            if (selectedNode.Nodes.Count == 1 && selectedNode.Nodes[0].Text == "Cargando...")
                            {
                                selectedNode.Nodes.Clear();
                                string ruta = nodeToPathMap[selectedNode];
                                cargarDirectorios(selectedNode, ruta);
                            }
                        };

                        TreeNode rootNode = new TreeNode("/");
                        treeView.Nodes.Add(rootNode);
                        nodeToPathMap[rootNode] = "/";
                        cargarDirectorios(rootNode, "");

                        explorerForm.Controls.Add(treeView);

                        Button btnSubir = new Button() { Text = "Subir Archivo", Dock = DockStyle.Bottom };
                        explorerForm.Controls.Add(btnSubir);

                        btnSubir.Click += (s, ev) =>
                        {
                            if (treeView.SelectedNode != null)
                            {
                                string directorioSeleccionado = nodeToPathMap[treeView.SelectedNode];
                                bool exito = ftpConnection.subirArchivoFTP(archivoLocal, directorioSeleccionado);
                                lblEstado.Text = exito ? $"Archivo '{Path.GetFileName(archivoLocal)}' subido correctamente en '{directorioSeleccionado}'." : "Error al subir el archivo.";
                            }
                            else
                            {
                                lblEstado.Text = "Selecciona un directorio antes de subir.";
                            }
                            explorerForm.Close();
                        };

                        explorerForm.ShowDialog();
                    }
                }
            }
        }
    }
}