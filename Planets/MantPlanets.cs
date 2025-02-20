using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVISC_Maintenance;

namespace Planets
{
    public partial class MantPlanetes : AVISC_MaintenanceBaseForm
    {
        public MantPlanetes()
        {
            Taula = "Planets";
            InitializeComponent();
        }

        protected override void CustomDataGrid()
        {
            dataBaseView.Columns["CodePlanet"].HeaderText = "Code Planets";
            dataBaseView.Columns["DescPlanet"].HeaderText = "Planeta";
            dataBaseView.Columns["long"].HeaderText = "Longitud";
            dataBaseView.Columns["lat"].HeaderText = "Latitud";
            dataBaseView.Columns["parsecs"].HeaderText = "Parsecs";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AVISC_FTP.FTPExplorer fTPExplorer = new AVISC_FTP.FTPExplorer();
            fTPExplorer.Show();
        }
    }
}
