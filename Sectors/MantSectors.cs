using AVIDataAccess;
using AVISC_Maintenance;
using AVISC_DatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sectors
{
    public partial class MantSectors : AVISC_EFMaintenanceBaseForm<AVISC_DatabaseModel.Sectors, SecureCoreEF>
    {
        public MantSectors()
        {
            InitializeComponent();
        }

        protected override void CustomDataGrid()
        {
            dataBaseView.Columns["DescSector"].HeaderText = "Sector";
            dataBaseView.Columns["CodeSector"].HeaderText = "Código";
            dataBaseView.Columns["idRegionDisplay"].HeaderText = "Región";
        }
    }
}
