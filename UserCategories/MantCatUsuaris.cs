﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVISC_Maintenance;

namespace UserCategories
{
    public partial class MantCatUsuaris : BaseForm
    {
        public MantCatUsuaris()
        {
            Taula = "UserCategories";

            InitializeComponent();
        }

        public override void CustomDataGrid()
        {
            dataBaseView.Columns["CodeUserCategory"].HeaderText = "Código";
            dataBaseView.Columns["DescUserCategory"].HeaderText = "Nombre";
            dataBaseView.Columns["AccessLevel"].HeaderText = "Nivel de Acceso";
        }

        private void swTextbox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
