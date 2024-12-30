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
        }
        bool EsNou = false;
        private void PortarDates()
        {

            dts = dataAccess.PortarDataset(" Species ");
            dataGridView1.DataSource = dts.Tables["Species"];
            Regex compCampoId = new Regex("(?i)id");
            if(dts !=null && dts.Tables.Count >0)
            {
                dataGridView1.DataSource = dts.Tables[0];
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (compCampoId.IsMatch(column.Name))
                    {
                        column.Visible = false;
                    }
                }
            }
            //actualizarDatos();


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
    }
    
    

}
