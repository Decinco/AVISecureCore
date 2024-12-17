using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVISC_Controles
{
    public enum ContentType
    {
        Nombre,
        Text,
        Codi,
    }

    public partial  class SWTextbox : TextBox
    {
        public ContentType DadaPermesa { get; set; }
        public bool AllowEmpty { get; set; }
        public bool IsForeignKey { get; set; }
        public string LinkedControlName { get; set; }

        private TextBox linkedControl;
        public SWTextbox()
        {
            this.Enter += new System.EventHandler(this.SWTextbox_Enter);
            this.Leave += new System.EventHandler(this.SWTextbox_Leave);
            this.TextChanged += new System.EventHandler(this.SWTextbox_TextChanged);
            this.ResumeLayout(false);
        }

        private void SWTextbox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            ValidateContent();
        }

        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Lime;
        }

        private void SWTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LinkedControlName))
            {
                Control control = this.Parent?.Controls[LinkedControlName];
                if (control is TextBox linkedTextBox)
                {
                    linkedControl = linkedTextBox;
                    linkedTextBox.Text = this.Text;
                    
                }
            }
        }

        private void ValidateContent()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(this.Text))
            {
                if (!AllowEmpty)
                {
                    this.Focus();
                }
            }
            else
            {
                if (DadaPermesa == ContentType.Nombre)
                {
                    isValid = ValidateNombre(this.Text);

                }
                else if (DadaPermesa == ContentType.Codi)
                {
                    isValid = ValidateCodi(this.Text);
                }
                else if(DadaPermesa == ContentType.Text){
                    isValid = true;
                }
               

                if (isValid)
                {
                    linkedControl.Text = "CODI VALID";
                }
                else
                {
                    linkedControl.Text = "ERROR CODI";
                }
            }

        }

        private bool ValidateNombre(string text)
        {
            return int.TryParse(text, out _);
        }

        private bool ValidateCodi(string text)
        {
            string pattern = @"^[AEIOU][A-Z]{3}0[13579]$";
            return Regex.IsMatch(text, pattern);
        }




    }
}

