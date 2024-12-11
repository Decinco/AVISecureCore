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
 

namespace AVISC_Maintenance
{
   

    public partial class BaseForm : Form
    {
        public class MaintenanceDataAccess : DataAccess { };
        private MaintenanceDataAccess dataAccess;
        private DataSet dts;
        public  string taula { get; set; }
        private Dictionary<string, string> fields = new Dictionary<string, string>();

        public BaseForm()
        {
            dataAccess = new MaintenanceDataAccess();
            InitializeComponent();
            PortarDates();
        }
        bool EsNou = false;
        private void PortarDates()
        {

            dts = dataAccess.PortarTaula(" Species ");
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



        }

        private void actualizarDB_Click(object sender, EventArgs e)
        {
            if (EsNou)
            {
                DataRow newRow = dts.Tables["Species"].NewRow();
                newRow["CodeSpecie"] = swTextbox1.Text;
                newRow["DescSpecie"] = swTextbox3.Text;

                dts.Tables["Species"].Rows.Add(newRow);
                EsNou = false;
            }

            string querySelect = "SELECT * FROM Species";
            
            foreach  (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    TextBox ctr = (TextBox)item;
                    fields.Add(item.Tag.ToString(), item.Text);
                }
            }
            int result = dataAccess.Actualitzar(dts, querySelect , fields );

            MessageBox.Show($"Registros modificados: {result}");

            PortarDates();
        }

        private void nuevoDB_Click(object sender, EventArgs e)
        {

        }
    }
    
    

}
