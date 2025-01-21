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

namespace SpaceShipCategories
{
    public partial class MantCatNaus : AVISC_MaintenanceBaseForm
    {
        public MantCatNaus()
        {
            Taula = "SpaceShipCategories";
            InitializeComponent();
        }

        protected override void CustomDataGrid()
        {
            dataBaseView.Columns["CodeSpaceShipCategory"].HeaderText = "Código";
            dataBaseView.Columns["DescSpaceShipCategory"].HeaderText = "Descripción";
        }
    }
}