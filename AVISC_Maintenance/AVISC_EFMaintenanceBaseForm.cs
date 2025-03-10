using AVIDataAccess;
using AVISC_BaseForms;
using AVISC_Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVISC_Maintenance
{

    /// <summary>
    ///     <para>
    ///         Formulario base para la creación de formularios de mantenimiento utilizando EntityFramework.
    ///     </para>
    ///     <para>
    ///         Se pueden añadir automáticamente campos a la tabla creando un <see cref="TextBox"/> o <see cref="ComboBox"/> en el formulario y luego introduciendo el nombre del tag con el formato correcto.
    ///     </para>
    ///     <list type="table">
    ///         <item>
    ///             <term>TextBox</term>
    ///             <description>"[nombre_columna]"</description>
    ///         </item>
    ///         <item>
    ///             <term>ComboBox</term>
    ///             <description>"[nombre_tabla_foránea].[nombre_columna_foránea].[nombre_columna_id]"</description>
    ///         </item>
    ///     </list>
    /// </summary>
    /// <typeparam name="EntityT">Tipo de la entidad que va a servir como tabla primaria.</typeparam>
    /// <typeparam name="ContextT">Contexto a utilizar. Debe heredar de <see cref="DbContext"/>.</typeparam>
    public partial class AVISC_EFMaintenanceBaseForm<EntityT, ContextT> : AVISC_CloseableFeatureForm
        where EntityT : class, new()
        where ContextT : DbContext, new()
    {

        /// <summary>
        /// Define los campos que se van a mostrar en la tabla.
        /// </summary>
        protected List<string> Fields { get; set; }

        /// <summary>
        /// Controla si se está creando un nuevo registro.
        /// </summary>
        protected bool New { get; private set; }

        /// <summary>
        /// Datos obtenidos de la base de datos.
        /// </summary>
        protected BindingList<EntityT> Data { get; private set; }

        /// <summary>
        /// Instancia del contexto <typeparamref name="ContextT"/> usado en esta clase.
        /// </summary>
        protected ContextT Context { get; private set; }

        // Eventos para añadir nuevos comportamientos al formulario
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
        protected event EventHandler NewAdded;

        private BindingSource Source;

        private EFDataAccess<EntityT> DataAccess;

        private string TypeName;

        private bool ErrorMessageAlreadyShown = false;

        /// <summary>
        /// Consttructor por defecto del formulario. Crea el acceso a datos.
        /// </summary>
        public AVISC_EFMaintenanceBaseForm()
        {
            Context = new ContextT();

            DataAccess = new EFDataAccess<EntityT>(Context);
            Source = new BindingSource();
            New = false;
            TypeName = typeof(EntityT).Name;

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

        private void OnLoad(object sender, EventArgs e)
        {
            RoundUtils.RedondearEsquinas(pnl_NewButton, 30);
            RoundUtils.RedondearEsquinas(pnl_SaveButton, 30);
            RoundUtils.RedondearEsquinas(dataBaseView, 50);

            if (!DesignMode)
            {
                Setup();

                DataBind();

                // Aplicar estilo al DataGridView
                EstilizarDataGridView();

                CustomPostLoadBehavior();

                HideUnavailable();
            }
        }

        private void Setup()
        {
            dataBaseView.Hide();

            Fields = new List<string>();

            AddFields();

            Data = new BindingList<EntityT>(DataAccess.Refresh());
            Source.DataSource = Data;

            if (Data == null)
            {
                MessageBox.Show("Ha habido un error al importar los datos de la base de datos.");
            }

            ComboBoxInitialization();

            CustomFields();
        }

        private void AddFields()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    Fields.Add(textBox.Tag.ToString());
                }
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    string[] tagParts = comboBox.Tag.ToString().Split('.');
                    ForeignKeyTag newTag;

                    newTag = new ForeignKeyTag()
                    {
                        ValueColumnName = tagParts[2],
                        ValueTableName = TypeName,
                        OriginColumnName = tagParts[2],
                        DisplayColumnName = tagParts[1],
                        DisplayTableName = tagParts[0]
                    };

                    comboBox.Tag = newTag;

                    Fields.Add(comboBox.Tag.ToString());
                }
            }
        }

        private void ComboBoxInitialization()
        {
            foreach (Control control in Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    ForeignKeyTag foreign = (ForeignKeyTag)comboBox.Tag;

                    try
                    {
                        // Esta es la única forma que he encontrado de sacar los datos de un modelo a partir de su nombre.
                        Type foreignType = typeof(ContextT).GetProperty(foreign.DisplayTableName).PropertyType.GetGenericArguments()[0];
                        
                        comboBox.DataSource = MakeListFromDBSet(Context.Set(foreignType));

                        comboBox.DisplayMember = foreign.DisplayColumnName;
                        comboBox.ValueMember = foreign.OriginColumnName;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($"No se pudo determinar a dónde tiene que apuntar el ComboBox para la columna {comboBox.Tag}. \nDetalles: {e.Message}\nEn:{e.StackTrace}", "Liada monumental", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private List<object> MakeListFromDBSet(DbSet set)
        {
            List<object> list = new List<object>();

            foreach (object entry in set)
            {
                list.Add(entry);
            }

            return list;
        }

        private void DataBind()
        {
            bool errors = false;

            Source.DataSource = Data;
            dataBaseView.DataSource = Source;

            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    try
                    {
                        textBox.DataBindings.Clear();
                        textBox.DataBindings.Add("Text", Source, textBox.Tag.ToString());

                        textBox.TextChanged += SaveToDataGrid;
                    }
                    catch
                    {
                        if (!ErrorMessageAlreadyShown)
                        {
                            MessageBox.Show($"¡{textBox.Tag} no es una propiedad de {TypeName}!", "Liada monumental", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            textBox.ReadOnly = true;
                            textBox.Text = "¡Esta propiedad no existe!";

                            errors = true;
                        }
                    }
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    ForeignKeyTag foreign = (ForeignKeyTag)comboBox.Tag;

                    try
                    {
                        dataBaseView.Columns[foreign.OriginColumnName].Visible = false;

                        comboBox.DataBindings.Clear();
                        comboBox.DataBindings.Add(new Binding("SelectedValue", Source, comboBox.Tag.ToString(), true, DataSourceUpdateMode.Never));

                        comboBox.SelectionChangeCommitted += SaveToDataGridComboBox;
                    }
                    catch
                    {
                        if (!ErrorMessageAlreadyShown)
                        {
                            MessageBox.Show($"¡{foreign.ValueColumnName} no es una propiedad de {foreign.ValueTableName} o {foreign.OriginColumnName} no es una propiedad de {TypeName}!", "Liada monumental", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            comboBox.Enabled = false;
                            comboBox.Text = "¡Esta propiedad no existe!";

                            errors = true;
                        }
                    }
                }
            }

            if (errors == true)
            {
                DisableNew();
                ErrorMessageAlreadyShown = true;
            }

            CustomDataBinding();
        }

        private void HideUnavailable()
        {
            foreach (DataGridViewColumn column in dataBaseView.Columns)
            {
                if (!Fields.Contains(column.Name))
                {
                    column.Visible = false;
                }
            }

            dataBaseView.Show();
        }

        private void SaveToDataGrid(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.DataBindings.Count > 0)
            {
                textBox.DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        private void SaveToDataGridComboBox(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.DataBindings.Count > 0)
            {
                // La hamburguesa del terror
                comboBox.DataBindings[0].BindingManagerBase.EndCurrentEdit();
                comboBox.DataBindings[0].WriteValue();
                comboBox.DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }

            UpdateExtraColumns(comboBox);
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            int changedItems;
            int newItems = 0;
            BindingList<EntityT> newData;

            BeforeSave?.Invoke(this, e);

            if (New)
            {

                EntityT entity = new EntityT();

                foreach (Control control in Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        try
                        {
                            typeof(EntityT).GetProperty(textBox.Tag.ToString()).SetValue(entity, textBox.Text); // Reflection para poner las propiedades del objeto
                        }
                        catch
                        {
                            MessageBox.Show($"¡{textBox.Tag} no es una propiedad de {TypeName}!", "Liada monumental", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        try
                        {
                            typeof(EntityT).GetProperty(comboBox.Tag.ToString()).SetValue(entity, comboBox.SelectedValue); // Reflection para poner las propiedades del objeto
                        }
                        catch
                        {
                            MessageBox.Show($"¡{comboBox.Tag} no es una propiedad de {TypeName}!", "Liada monumental", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (DataAccess.Create(entity))
                {
                    newItems += 1;
                }
                else
                {
                    MessageBox.Show("Ha habido un error al añadir un nuevo registro.");
                }
            }

            newData = new BindingList<EntityT>(DataAccess.SaveAndRefresh(out changedItems));

            if (newData == null)
            {
                MessageBox.Show("Ha habido un error al guardar o recargar los datos de la base de datos. Es posible que uno de los valores introducidos sea de un tipo inválido.");
            }
            else
            {
                Data = newData;
                MessageBox.Show($"Registros modificados: {changedItems + newItems}");
            }

            New = false;

            Saved?.Invoke(this, e);

            DataBind();
        }

        private void NewEntry(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.DataBindings.Clear();
                    textBox.Text = "";

                    textBox.TextChanged -= SaveToDataGrid;
                }
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.DataBindings.Clear();
                    comboBox.SelectedIndex = 0;

                    comboBox.Validated -= SaveToDataGridComboBox;
                }
            }

            New = true;

            NewAdded?.Invoke(this, EventArgs.Empty);
        }

        private void DisableNew()
        {
            Control[] newButtonControls = new Control[4]
            {
                pbx_New,
                pnl_NewButton,
                pnl_newIconButton,
                lbl_New
            };

            pnl_NewButton.BackColor = Color.FromArgb(20, 20, 20);
            lbl_New.Text = "No disponible";
            lbl_New.ForeColor = Color.Gray;

            for (int i = 0; i < newButtonControls.Length; i++)
            {
                newButtonControls[i].Cursor = Cursors.Default;
                newButtonControls[i].MouseEnter -= pnl_NewButton_MouseEnter;
                newButtonControls[i].MouseLeave -= pnl_NewButton_MouseLeave;
                newButtonControls[i].Click -= NewEntry;
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

            // Eliminar las líneas blancas entre las celdas
            dataBaseView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            //dataBaseView.GridColor = Color.Transparent;

            // Deshabilitar los estilos visuales predeterminados
            dataBaseView.EnableHeadersVisualStyles = false;

            ComboBoxColumnLinking();

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

        // -- WIP --

        // Código para las columnas de muestra de foránea... WIP y en desuso por ahora
        private void ComboBoxColumnLinking()
        {
            foreach (Control control in Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;

                    ForeignKeyTag foreign = (ForeignKeyTag)comboBox.Tag;

                    // Columna de muestra de foránea
                    dataBaseView.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        CellTemplate = new DataGridViewTextBoxCell(),
                        Name = $"{foreign.OriginColumnName}Display",
                        HeaderText = $"{foreign.OriginColumnName}Display",
                        Tag = dataBaseView.Columns[foreign.OriginColumnName].Index
                    });

                    Fields.Add($"{foreign.OriginColumnName}Display");
                }
            };
        }

        // Código de actualización de columna de muestra de foránea. WIP y en desuso.
        private void UpdateExtraColumns(ComboBox comboBox)
        {
            ForeignKeyTag foreign = (ForeignKeyTag)comboBox.Tag;
            Type foreignType = typeof(ContextT).GetProperty(foreign.DisplayTableName).PropertyType.GetGenericArguments()[0];
            DataGridViewColumn displayColumn = dataBaseView.Columns[$"{foreign.OriginColumnName}Display"];
            DataGridViewColumn valueColumn = dataBaseView.Columns[$"{foreign.OriginColumnName}"];

            foreach (DataGridViewRow row in dataBaseView.Rows)
            {
                DataGridViewCell displayCell = row.Cells[displayColumn.Index];
                DataGridViewCell valueCell = row.Cells[valueColumn.Index];

                // Reflection, mi vieja amiga
                DbSet displaySet = Context.Set(foreignType);
                try
                {
                    var displayObject = displaySet.Find(int.Parse(valueCell.Value.ToString()));
                    displayCell.Value = displayObject.GetType().GetProperty(foreign.DisplayColumnName).GetValue(displayObject);
                }
                catch
                {
                    displayCell.Value = "Sin información";
                }
            }
        }

        private void RefreshLinkedColumns(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;

                    UpdateExtraColumns(comboBox);
                }
            }
        }
    }
}