using AVIDataAccess;
using AVISC_BaseForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVISC_Maintenance
{

    /// <summary>
    /// Formulario base para la creación de formularios de mantenimiento utilizando EntityFramework.
    /// </summary>
    /// <typeparam name="EntityT">Tipo de la entidad que </typeparam>
    /// <typeparam name="ContextT"></typeparam>
    public partial class AVISC_EFMaintenanceBaseForm<EntityT, ContextT> : AVISC_CloseableFeatureForm
        where EntityT : class, new()
        where ContextT : DbContext, new()
    {
        private List<string> Fields;

        private List<EntityT> Data;

        private bool New;

        private ContextT Context = new ContextT();

        private EFDataAccess<EntityT> DataAccess; // Un dataAccess cuyas acciones solo pueden afectar a objetos "EntityT"

        private string TypeName;

        /// <summary>
        /// Consttructor por defecto del formulario. Crea el acceso a datos.
        /// </summary>
        public AVISC_EFMaintenanceBaseForm()
        {
            DataAccess = new EFDataAccess<EntityT>(Context);
            New = false;
            TypeName = typeof(EntityT).Name;

            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Setup();
            DataBind();

            HideUnavailable();
        }

        private void Setup()
        {
            Fields = new List<string>();
            Data = DataAccess.Refresh();

            if (Data == null)
            {
                MessageBox.Show("Ha habido un error al importar los datos de la base de datos.");
            }
            else
            {

                foreach (Control control in Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        Fields.Add(textBox.Tag.ToString());
                    }
                }
            }
        }

        private void DataBind()
        {
            bool errors = false;

            dataBaseView.DataSource = Data;
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    try
                    {
                        textBox.DataBindings.Clear();
                        textBox.DataBindings.Add("Text", Data, textBox.Tag.ToString());

                        textBox.TextChanged += SaveToDataGrid;
                    }
                    catch
                    {
                        MessageBox.Show($"¡{textBox.Tag} no es una propiedad de {TypeName}!", "Liada monumental", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        textBox.ReadOnly = true;
                        textBox.Text = "¡Esta propiedad no existe!";

                        errors = true;
                    }
                }
            }

            if (errors == true)
            {
                DisableNew();
            }
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
        }

        private void SaveToDataGrid(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.DataBindings.Count > 0)
            {
                textBox.DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            int changedItems;
            int newItems = 0;
            List<EntityT> newData;

            if (New)
            {

                EntityT species = new EntityT();

                foreach (Control control in Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        try
                        {
                            typeof(EntityT).GetProperty(textBox.Tag.ToString()).SetValue(species, textBox.Text); // Reflection para poner las propiedades del objeto
                        }
                        catch
                        {
                            MessageBox.Show($"¡{textBox.Tag} no es una propiedad de {TypeName}!", "Liada monumental", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (DataAccess.Create(species))
                {
                    newItems += 1;
                }
                else
                {
                    MessageBox.Show("Ha habido un error al añadir un nuevo registro.");
                }
            }

            newData = DataAccess.SaveAndRefresh(out changedItems);

            if (Data == null)
            {
                MessageBox.Show("Ha habido un error al guardar o recargar los datos de la base de datos. Es posible que uno de los valores introducidos sea de un tipo inválido.");
            }
            else
            {
                Data = newData;
            }

            MessageBox.Show($"Registros modificados: {changedItems + newItems}");

            New = false;

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
            }

            New = true;
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
