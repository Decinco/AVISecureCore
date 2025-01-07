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

namespace SpaceShipCategories
{
    public partial class MantCatNaus : BaseForm
    {
        public MantCatNaus()
        {
            Taula = "SpaceShipCategories";
            InitializeComponent();
        }

        public override void CustomHeaders()
        {
            dataBaseView.Columns["CodeSpaceShipCategory"].HeaderText = "Código";
            dataBaseView.Columns["DescSpaceShipCategory"].HeaderText = "Descripción";
        }
    }
}