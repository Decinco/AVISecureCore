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

namespace SpaceShipTypes
{
    public partial class MantTipusNau : BaseForm
    {
        public MantTipusNau()
        {
            Taula = "SpaceShipTypes";
            InitializeComponent();
        }

        public override void CustomHeaders()
        {
            dataBaseView.Columns["CodeSpaceShipType"].HeaderText = "Código";
            dataBaseView.Columns["DescSpaceShipType"].HeaderText = "Descripción";
        }
    }
}
