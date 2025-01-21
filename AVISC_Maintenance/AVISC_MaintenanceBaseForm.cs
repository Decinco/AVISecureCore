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
using System.Drawing.Text;
using AVISC_Global;
 

namespace AVISC_Maintenance
{
    /// <summary>
    /// Formulario base para mantenimientos de base de datos.
    /// </summary>
    public partial class AVISC_MaintenanceBaseForm : AVISC_CloseableFeatureForm
    {
        /// <summary>
        /// Requerido. El nombre de la tabla principal desde la cual obtener los datos.
        /// </summary>
        protected string Taula { get; set; }

        private DataAccess DataAccess;

        /// <summary>
        /// Campos que se mostrarán en el DataGridView. Se asignan automáticamente pero se pueden añadir más.
        /// </summary>
        protected Dictionary<string, object> Fields = new Dictionary<string, object>();

        /// <summary>
        /// Campos que no se mostrarán en el DataGridView.
        /// </summary>
        protected List<string> IgnoredFields = new List<string>();

        /// <summary>
        /// DataSet que contiene los datos de la tabla.
        /// </summary>
        protected DataSet DTS;

        /// <summary>
        /// DataSet que contiene la información de las claves foráneas.
        /// </summary>
        protected DataSet ForeignKeyInformation;

        /// <summary>
        /// Expone la propiedad <see cref="DataAccess.New"/> para que los formularios que hereden esta clase puedan leerlo.
        /// </summary>
        protected bool IsNew
        {
            get { return DataAccess.New; }
        }

        // Eventos que habilitan la personalización de la actualización de la base de datos y la creación de un nuevo registro
        /// <summary>
        /// Evento que se dispara antes de guardar los cambios en la base de datos.
        /// </summary>
        protected event EventHandler BeforeSave;
        /// <summary>
        /// Evento que se dispara después de guardar los cambios en la base de datos.
        /// </summary>
        protected event EventHandler Saved;
        /// <summary>
        /// Evento que se dispara al crear un nuevo registro.
        /// </summary>
        protected event EventHandler New;

        public AVISC_MaintenanceBaseForm()
        {
            DataAccess = new DataAccess();

            InitializeComponent();
        }

        /// <summary>
        /// Permite personalizar las cabeceras del dataGridView y las propiedades de las columnas.
        /// </summary>
        protected virtual void CustomDataGrid() { }

        /// <summary>
        /// Permite añadir los campos que no se hayan añadido automáticamente, y esconder los que no se quieran mostrar.
        /// </summary>
        protected virtual void CustomFields() { }

        /// <summary>
        /// Permite añadir manualmente nuevos dataBindings.
        /// </summary>
        protected virtual void CustomDataBinding() { }

        /// <summary>
        /// Permite añadir comportamientos personalizados después de cargar la ventana.
        /// </summary>
        protected virtual void CustomPostLoadBehavior() { }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            Setup();

            PortarDades();

            ComboBoxInitialization();
            DataBind();

            // Aplicar estilo al DataGridView
            EstilizarDataGridView();

            CustomPostLoadBehavior();

            RoundUtils.RedondearEsquinas(pnl_NewButton, 30);
            RoundUtils.RedondearEsquinas(pnl_SaveButton, 30);
            RoundUtils.RedondearEsquinas(dataBaseView, 50);
        }

        private void Setup()
        {
            if (DesignMode)
            {
                Taula = "Dummy";
            }

            ForeignKeyInformation = DataAccess.PortarInfoFK(Taula);

            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    Fields.Add(txt.Tag.ToString(), txt.Text);
                }
                else if (control is ComboBox)
                {
                    ComboBox cmb = (ComboBox)control;
                    string[] tagParts = cmb.Tag.ToString().Split('.');
                    ForeignKeyTag newTag;

                    newTag = new ForeignKeyTag()
                    {
                        ValueColumnName = GetValueColumn(tagParts[0]),
                        ValueTableName = GetValueTable(tagParts[0]),
                        OriginColumnName = GetOriginColumn(tagParts[0]),
                        DisplayColumnName = tagParts[1],
                        DisplayTableName = tagParts[0]
                    };

                    cmb.Tag = newTag;

                    Fields.Add(cmb.Tag.ToString(), "");
                }
            }

            CustomFields();
        }

        private void PortarDades()
        {
            DTS = DataAccess.PortarDatasetIForanies(Taula, ForeignKeyInformation);
            dataBaseView.DataSource = DTS.Tables[Taula];

            foreach (DataGridViewColumn column in dataBaseView.Columns)
            {
                if (!Fields.ContainsKey(column.Name) || IgnoredFields.Contains(column.Name))
                {
                    column.Visible = false;
                }
            }
        }

        private string GetValueColumn(string displayTable)
        {
            string valueColumnName;
            DataRow foreignKeyRow;

            foreignKeyRow = ForeignKeyInformation.Tables[0].Select($"PKTABLE_NAME = '{displayTable}'")[0];
            valueColumnName = foreignKeyRow.Field<string>("PKCOLUMN_NAME");

            return valueColumnName;
        }

        private string GetOriginColumn(string displayTable)
        {
            string valueColumnName;
            DataRow foreignKeyRow;

            foreignKeyRow = ForeignKeyInformation.Tables[0].Select($"PKTABLE_NAME = '{displayTable}'")[0];
            valueColumnName = foreignKeyRow.Field<string>("FKCOLUMN_NAME");

            return valueColumnName;
        }

        private string GetValueTable(string displayTable)
        {
            string valueColumnName;
            DataRow foreignKeyRow;

            foreignKeyRow = ForeignKeyInformation.Tables[0].Select($"PKTABLE_NAME = '{displayTable}'")[0];
            valueColumnName = foreignKeyRow.Field<string>("FKTABLE_NAME");

            return valueColumnName;
        }

        private void ComboBoxInitialization()
        {
            foreach (Control control in Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    ForeignKeyTag foreign = (ForeignKeyTag)comboBox.Tag;
                    int dataGridViewColumnIndex;

                    comboBox.DataSource = DTS.Tables[foreign.DisplayTableName];
                    comboBox.DisplayMember = foreign.DisplayColumnName;
                    comboBox.ValueMember = foreign.ValueColumnName;

                    dataGridViewColumnIndex = dataBaseView.Columns[foreign.OriginColumnName].Index;
                    dataBaseView.Columns[foreign.OriginColumnName].Visible = false;

                    //DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
                    //column.DataSource = DTS.Tables[foreign.DisplayTableName];
                    //column.DisplayMember = foreign.DisplayColumnName;
                    //column.ValueMember = foreign.ValueColumnName;

                    //dataBaseView.Columns.Insert(dataGridViewColumnIndex, column);
                }
            }
        }

        private void DataBind()
        {
            foreach (Control control in Controls)
            {
                if(control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.DataBindings.Clear();

                    textBox.DataBindings.Add("Text", DTS.Tables[0], textBox.Tag.ToString());
                    textBox.TextChanged += ValidateTextBox;
                }
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;

                    comboBox.DataBindings.Clear();

                    comboBox.DataBindings.Add("SelectedValue", DTS.Tables[0], comboBox.Tag.ToString());
                    comboBox.SelectedIndexChanged += ValidateComboBox;
                }
            }

            CustomDataBinding();

            DataAccess.New = false;
        }
        
        private void ValidateTextBox(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.DataBindings.Count > 0)
            {
                textBox.DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        private void ValidateComboBox(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.DataBindings.Count > 0)
            {
                comboBox.DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        private void UpdateDatabase(object sender, EventArgs e)
        {
            string querySelect = $"SELECT * FROM {Taula}";

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    TextBox sWTextbox = (TextBox)item;
                    if (Fields.ContainsKey(sWTextbox.Tag.ToString()))
                    {
                        Fields[sWTextbox.Tag.ToString()] = sWTextbox.Text;
                    }
                }
                else if (item is ComboBox)
                {
                    ComboBox ComboBox = (ComboBox)item;
                    if (Fields.ContainsKey(ComboBox.Tag.ToString()))
                    {
                        Fields[ComboBox.Tag.ToString()] = ComboBox.SelectedValue.ToString();
                    }
                }
            }

            BeforeSave?.Invoke(this, EventArgs.Empty);

            int result = DataAccess.Actualitzar(DTS, querySelect, Fields);

            MessageBox.Show($"Registros modificados: {result}");

            PortarDades();
            DataBind();

            Saved?.Invoke(this, EventArgs.Empty);
        }

        private void NewEntry(object sender, EventArgs e)
        {
            DataAccess.New = true;
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.DataBindings.Clear();
                    textBox.Clear();
                    textBox.Validated -= ValidateTextBox;
                }
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.DataBindings.Clear();
                    comboBox.SelectedIndex = 0;
                    comboBox.Validated -= ValidateComboBox;
                }
            }

            New?.Invoke(this, EventArgs.Empty);
        }

        private void EstilizarDataGridView()
        {
            dataBaseView.BorderStyle = BorderStyle.None;

            // Estilo de las cabeceras de columna
            dataBaseView.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(32, 32, 32),
                ForeColor = Color.FromArgb(255, 241, 102),
                Font = new Font("Inter", 32, FontStyle.Bold, GraphicsUnit.Pixel),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            // Estilo de las celdas
            dataBaseView.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(42, 42, 42),
                ForeColor = Color.White,
                Font = new Font("Inter", 24, FontStyle.Regular, GraphicsUnit.Pixel),
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

            CustomDataGrid();
        }

        private void pnl_NewButton_MouseEnter(object sender, EventArgs e)
        {
            pnl_NewButton.BackColor = Color.FromArgb(42, 42, 42);
        }

        private void pnl_NewButton_MouseLeave(object sender, EventArgs e)
        {
            pnl_NewButton.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void pnl_SaveButton_MouseEnter(object sender, EventArgs e)
        {
            pnl_SaveButton.BackColor = Color.FromArgb(42, 42, 42);
        }

        private void pnl_SaveButton_MouseLeave(object sender, EventArgs e)
        {
            pnl_SaveButton.BackColor = Color.FromArgb(33, 33, 33);
        }
    }
}