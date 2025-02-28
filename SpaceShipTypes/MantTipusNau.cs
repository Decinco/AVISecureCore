using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVISC_EdiTools;
using AVISC_Maintenance;

namespace SpaceShipTypes
{
    public partial class MantTipusNau : AVISC_MaintenanceBaseForm
    {
        public MantTipusNau()
        {
            Taula = "SpaceShipTypes";
            InitializeComponent();
        }

        protected override void CustomDataGrid()
        {
            dataBaseView.Columns["CodeSpaceShipType"].HeaderText = "Código";
            dataBaseView.Columns["DescSpaceShipType"].HeaderText = "Descripción";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AVISC_EdiTools.EDI ediTools = new AVISC_EdiTools.EDI();
            ediTools.Show();
        }
    }
}
