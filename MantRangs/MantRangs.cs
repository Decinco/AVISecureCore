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

namespace UserRanks
{
    public partial class MantRangs : AVISC_MaintenanceBaseForm
    {
        public MantRangs()
        {
            InitializeComponent();

            Taula = "UserRanks";
        }

        protected override void CustomDataGrid()
        {
            dataBaseView.Columns["CodeUserRank"].HeaderText = "Code Rank";
            dataBaseView.Columns["DescUserRank"].HeaderText = "Rank";
        }
    }
}
