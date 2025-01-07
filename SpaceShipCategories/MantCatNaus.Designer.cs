
namespace SpaceShipCategories
{
    partial class MantCatNaus
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_descSpaceShips = new System.Windows.Forms.Label();
            this.lbl_codeSpaceShip = new System.Windows.Forms.Label();
            this.swTxt_code = new AVISC_Controles.SWTextbox();
            this.swTxt_desc = new AVISC_Controles.SWTextbox();
            this.SuspendLayout();
            // 
            // lbl_descSpaceShips
            // 
            this.lbl_descSpaceShips.AutoSize = true;
            this.lbl_descSpaceShips.Font = new System.Drawing.Font("Inter", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_descSpaceShips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lbl_descSpaceShips.Location = new System.Drawing.Point(671, 58);
            this.lbl_descSpaceShips.Name = "lbl_descSpaceShips";
            this.lbl_descSpaceShips.Size = new System.Drawing.Size(389, 48);
            this.lbl_descSpaceShips.TabIndex = 33;
            this.lbl_descSpaceShips.Text = "Descripción de la Nave";
            // 
            // lbl_codeSpaceShip
            // 
            this.lbl_codeSpaceShip.AutoSize = true;
            this.lbl_codeSpaceShip.Font = new System.Drawing.Font("Inter", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_codeSpaceShip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lbl_codeSpaceShip.Location = new System.Drawing.Point(25, 58);
            this.lbl_codeSpaceShip.Name = "lbl_codeSpaceShip";
            this.lbl_codeSpaceShip.Size = new System.Drawing.Size(311, 48);
            this.lbl_codeSpaceShip.TabIndex = 31;
            this.lbl_codeSpaceShip.Text = "Código de la Nave";
            // 
            // swTxt_code
            // 
            this.swTxt_code.AllowEmpty = false;
            this.swTxt_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.swTxt_code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.swTxt_code.DadaPermesa = AVISC_Controles.ContentType.Nombre;
            this.swTxt_code.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.swTxt_code.ForeColor = System.Drawing.Color.White;
            this.swTxt_code.IsForeignKey = false;
            this.swTxt_code.LinkedControlName = null;
            this.swTxt_code.Location = new System.Drawing.Point(33, 143);
            this.swTxt_code.Multiline = true;
            this.swTxt_code.Name = "swTxt_code";
            this.swTxt_code.Size = new System.Drawing.Size(570, 60);
            this.swTxt_code.TabIndex = 34;
            this.swTxt_code.Tag = "CodeSpaceShipCategory";
            // 
            // swTxt_desc
            // 
            this.swTxt_desc.AllowEmpty = false;
            this.swTxt_desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.swTxt_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.swTxt_desc.DadaPermesa = AVISC_Controles.ContentType.Nombre;
            this.swTxt_desc.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.swTxt_desc.ForeColor = System.Drawing.Color.White;
            this.swTxt_desc.IsForeignKey = false;
            this.swTxt_desc.LinkedControlName = null;
            this.swTxt_desc.Location = new System.Drawing.Point(679, 143);
            this.swTxt_desc.Multiline = true;
            this.swTxt_desc.Name = "swTxt_desc";
            this.swTxt_desc.Size = new System.Drawing.Size(570, 60);
            this.swTxt_desc.TabIndex = 35;
            this.swTxt_desc.Tag = "DescSpaceShipCategory";
            // 
            // MantCatNaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.swTxt_desc);
            this.Controls.Add(this.swTxt_code);
            this.Controls.Add(this.lbl_descSpaceShips);
            this.Controls.Add(this.lbl_codeSpaceShip);
            this.Name = "MantCatNaus";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.lbl_codeSpaceShip, 0);
            this.Controls.SetChildIndex(this.lbl_descSpaceShips, 0);
            this.Controls.SetChildIndex(this.swTxt_code, 0);
            this.Controls.SetChildIndex(this.swTxt_desc, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_descSpaceShips;
        private System.Windows.Forms.Label lbl_codeSpaceShip;
        private AVISC_Controles.SWTextbox swTxt_code;
        private AVISC_Controles.SWTextbox swTxt_desc;
    }
}

