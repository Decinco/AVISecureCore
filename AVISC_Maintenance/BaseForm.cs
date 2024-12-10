using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVIDataAccess;
 

namespace AVISC_Maintenance
{
    public partial class BaseForm : Form
    {
        class MaintenanceDataAccess : DataAccess{}
        private MaintenanceDataAccess dataAccess;
        private DataSet dts;
        public  string taula { get; set; }

        public BaseForm()
        {
            InitializeComponent();
            PortarDates();
        }

        private void PortarDates()
        {

            dts = dataAccess.PortarTaula(taula);
            dataGridView1.Columns["id"].Visible = false;


        }

        private void actualizarDB_Click(object sender, EventArgs e)
        {

        }

        private void nuevoDB_Click(object sender, EventArgs e)
        {

        }
    }
    
    

}
