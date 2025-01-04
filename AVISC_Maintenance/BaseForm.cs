using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVIDataAccess;
using AVISC_Controles;
using AVISC_BaseForms;
using AVISC_Global;
 

namespace AVISC_Maintenance
{

    public partial class BaseForm : AVISC_CloseableFeatureForm
    {
        private DataAccess dataAccess;
        private DataSet dts;
        public  string taula { get; set; }
        private Dictionary<string, string> fields = new Dictionary<string, string>();

        public BaseForm()
        {
            dataAccess = new DataAccess();
            InitializeComponent();
            PortarDates();
            dataBind();

            RoundUtils.RedondearEsquinas(nuevoDB, topRight: 30, bottomRight: 30);
            RoundUtils.RedondearEsquinas(actualizarDB, topRight: 30, bottomRight: 30);
            RoundUtils.RedondearEsquinas(nuevoPanel, topLeft: 30, bottomLeft: 30);
            RoundUtils.RedondearEsquinas(actualizarPanel, topLeft: 30, bottomLeft: 30);
            RoundUtils.RedondearEsquinas(dataBaseView, 50);
        }
        bool EsNou = false;
        private void PortarDates()
        {
            // Obtener datos de la base de datos
            dts = dataAccess.PortarDataset("Species");
            Regex compCampoId = new Regex("(?i)id");

            if (dts != null && dts.Tables.Count > 0)
            {
                // Configurar el DataSource
                dataBaseView.DataSource = dts.Tables[0];

                // Ocultar columnas específicas
                foreach (DataGridViewColumn column in dataBaseView.Columns)
                {
                    if (compCampoId.IsMatch(column.Name))
                    {
                        column.Visible = false;
                    }
                }
            }

            // Aplicar estilo al DataGridView
            EstilizarDataGridView();
        }


        //private void actualizarDatos()
        //{
        //    swTextboxCognom.DataBindings.Clear();
        //    swTextboxSpecie.DataBindings.Clear();
        //    swTextboxNom.DataBindings.Clear();

        //    swTextboxCognom.DataBindings.Add("Text", dts.Tables["Species"], "CodeSpecie");
        //    swTextboxSpecie.DataBindings.Add("Text", dts.Tables["Species"], "DescSpecie");
        //}
        private void dataBind()
        {
            foreach (Control control in Controls)
            {
                if(control is AVISC_Controles.SWTextbox)
                {
                    SWTextbox textBox = (AVISC_Controles.SWTextbox)control;
                    textBox.DataBindings.Clear();

                    textBox.DataBindings.Add("Text", dts.Tables[0], textBox.Tag.ToString());
                    textBox.Validated += new EventHandler(ValidateTextBox);
                }
            }
            dataAccess.New = false;
        }
        
        private void ValidateTextBox(object sender, EventArgs e)
        {
            ((SWTextbox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        private void actualizarDB_Click(object sender, EventArgs e)
        {
            string querySelect = "SELECT * FROM Species";

            if (EsNou)
            {
                DataRow newRow = dts.Tables[0].NewRow();
                newRow["CodeSpecie"] = swTextboxNom.Text;
                newRow["DescSpecie"] = swTextboxSpecie.Text;
                dts.Tables[0].Rows.Add(newRow);
                EsNou = false;
            }

            foreach (Control item in this.Controls)
            {
                if (item is SWTextbox)
                {
                    SWTextbox sWTextbox = (AVISC_Controles.SWTextbox)item;
                }
            }
            int result = dataAccess.Actualitzar(dts, querySelect, fields);

            MessageBox.Show($"Registros modificados: {result}");

            PortarDates();
        }

        private void nuevoDB_Click_1(object sender, EventArgs e)
        {
            EsNou = true;
            foreach (Control control in Controls)
            {
                if (control is SWTextbox)
                {
                    SWTextbox textBox = (AVISC_Controles.SWTextbox)control;
                    textBox.DataBindings.Clear();
                    textBox.Clear();
                    textBox.Validated -= new EventHandler(ValidateTextBox);
                }
            }


        }

        private void EstilizarDataGridView()
        {
            dataBaseView.BorderStyle = BorderStyle.None;

            // Estilo de las cabeceras de columna
            dataBaseView.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(32, 32, 32),
                ForeColor = Color.FromArgb(255, 241, 102),
                Font = new Font("Arial", 14F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            // Estilo de las celdas
            dataBaseView.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(42, 42, 42),
                ForeColor = Color.White,
                Font = new Font("Arial", 12F),
                SelectionBackColor = Color.Gray,
                SelectionForeColor = Color.White
            };

            // Alternar colores en las filas
            dataBaseView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(32, 32, 32);

            // Estilo de filas
            dataBaseView.RowTemplate.Height = 70;

            // Asignar el mismo ancho a todas las columnas
            //foreach (DataGridViewColumn columna in dataBaseView.Columns)
            //{
            //    columna.Width = 260;
            //}

            // Eliminar las líneas blancas entre las celdas
            dataBaseView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            //dataBaseView.GridColor = Color.Transparent;

            // Deshabilitar los estilos visuales predeterminados
            dataBaseView.EnableHeadersVisualStyles = false;
        }

        private void swTextboxSpecie_Validating(object sender, CancelEventArgs e)
        {
            swTextboxNom.BackColor = Color.FromArgb(42, 42, 42);
            swTextboxCognom.BackColor = Color.FromArgb(42, 42, 42);
            swTextboxSpecie.BackColor = Color.FromArgb(42, 42, 42);
        }
    }
}
