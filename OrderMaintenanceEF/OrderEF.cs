using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVISC_DatabaseModel;
using AVIDataAccess;

namespace OrderMaintenanceEF
{
    public partial class OrderEF : Form
    {
        public OrderEF()
        {
            order = new EFDataAccess<Orders>(secureCoreEF);
            InitializeComponent();
        }

        SecureCoreEF secureCoreEF = new SecureCoreEF();
        EFDataAccess<Orders> order;

        private void OrderEF_Load(object sender, EventArgs e)
        {
            List<Orders> orders = order.Refresh();

            foreach (Orders order in orders){
                cbCodeOrder.Items.Add(order.ToString());
            }


        }
    }
}
