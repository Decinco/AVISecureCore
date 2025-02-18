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

namespace Factories
{
    public partial class MantFactories : AVISC_EFMaintenanceBaseForm<Factories, SecureCore>
    {
        public MantFactories()
        {
            InitializeComponent();
        }

        protected override void CustomDataGrid()
        {
            dataBaseView.Columns["codeFactory"].HeaderText = "Código";
            dataBaseView.Columns["DescFactory"].HeaderText = "Nombre";
        }
    }
}