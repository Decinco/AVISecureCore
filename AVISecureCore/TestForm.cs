﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVISC_DataAccess;
using AVIDataAccess;

namespace AVISecureCore
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            AVISC_DataAccess.LoginData loginData = new AVISC_DataAccess.LoginData();

            loginData.PerformLogin("a", "b");
        }
    }
}
