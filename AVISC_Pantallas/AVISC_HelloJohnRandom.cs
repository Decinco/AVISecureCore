﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVISC_Pantallas
{
    public partial class AVISC_HelloJohnRandom : Form
    {
        public AVISC_HelloJohnRandom()
        {
            lbl_Persona.Text = @"Bienvenido a Secure Core, \bJohn Random\b0";

            InitializeComponent();
        }

        // Se utiliza un richtextbox para poder permitir que el nombre de usuario salga en negrita
        // Ahora, hay que disimular que es un label normal y corriente :)
        private void lbl__Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
    }
}