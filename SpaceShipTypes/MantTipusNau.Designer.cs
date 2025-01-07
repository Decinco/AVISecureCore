
namespace SpaceShipTypes
{
    partial class MantTipusNau
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
            this.lbl_codeSpaceShipType = new System.Windows.Forms.Label();
            this.lbl_descSpaceShipType = new System.Windows.Forms.Label();
            this.lbl_descFiliations = new System.Windows.Forms.Label();
            this.cmb_descFiliation = new System.Windows.Forms.ComboBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.swTextbox1 = new AVISC_Controles.SWTextbox();
            this.swTxt_desc = new AVISC_Controles.SWTextbox();
            this.SuspendLayout();
            // 
            // lbl_codeSpaceShipType
            // 
            this.lbl_codeSpaceShipType.AutoSize = true;
            this.lbl_codeSpaceShipType.Font = new System.Drawing.Font("Inter", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_codeSpaceShipType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lbl_codeSpaceShipType.Location = new System.Drawing.Point(27, 107);
            this.lbl_codeSpaceShipType.Name = "lbl_codeSpaceShipType";
            this.lbl_codeSpaceShipType.Size = new System.Drawing.Size(90, 31);
            this.lbl_codeSpaceShipType.TabIndex = 30;
            this.lbl_codeSpaceShipType.Text = "Código";
            // 
            // lbl_descSpaceShipType
            // 
            this.lbl_descSpaceShipType.AutoSize = true;
            this.lbl_descSpaceShipType.Font = new System.Drawing.Font("Inter", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_descSpaceShipType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lbl_descSpaceShipType.Location = new System.Drawing.Point(327, 107);
            this.lbl_descSpaceShipType.Name = "lbl_descSpaceShipType";
            this.lbl_descSpaceShipType.Size = new System.Drawing.Size(143, 31);
            this.lbl_descSpaceShipType.TabIndex = 31;
            this.lbl_descSpaceShipType.Text = "Descripción";
            // 
            // lbl_descFiliations
            // 
            this.lbl_descFiliations.AutoSize = true;
            this.lbl_descFiliations.Font = new System.Drawing.Font("Inter", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_descFiliations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lbl_descFiliations.Location = new System.Drawing.Point(909, 107);
            this.lbl_descFiliations.Name = "lbl_descFiliations";
            this.lbl_descFiliations.Size = new System.Drawing.Size(98, 31);
            this.lbl_descFiliations.TabIndex = 33;
            this.lbl_descFiliations.Text = "Facción";
            // 
            // cmb_descFiliation
            // 
            this.cmb_descFiliation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.cmb_descFiliation.Font = new System.Drawing.Font("Inter", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cmb_descFiliation.ForeColor = System.Drawing.Color.White;
            this.cmb_descFiliation.FormattingEnabled = true;
            this.cmb_descFiliation.Location = new System.Drawing.Point(915, 161);
            this.cmb_descFiliation.Name = "cmb_descFiliation";
            this.cmb_descFiliation.Size = new System.Drawing.Size(234, 38);
            this.cmb_descFiliation.TabIndex = 34;
            this.cmb_descFiliation.Tag = "Filiations.DescFiliations";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Inter", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lbl_categoria.Location = new System.Drawing.Point(1198, 107);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(119, 31);
            this.lbl_categoria.TabIndex = 35;
            this.lbl_categoria.Text = "Categoria";
            // 
            // cmb_category
            // 
            this.cmb_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.cmb_category.Font = new System.Drawing.Font("Inter", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cmb_category.ForeColor = System.Drawing.Color.White;
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(1204, 161);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(234, 38);
            this.cmb_category.TabIndex = 36;
            this.cmb_category.Tag = "SpaceShipCategories.DescSpaceShipCategory";
            // 
            // swTextbox1
            // 
            this.swTextbox1.AllowEmpty = false;
            this.swTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.swTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.swTextbox1.DadaPermesa = AVISC_Controles.ContentType.Nombre;
            this.swTextbox1.Font = new System.Drawing.Font("Inter", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.swTextbox1.ForeColor = System.Drawing.Color.White;
            this.swTextbox1.IsForeignKey = false;
            this.swTextbox1.LinkedControlName = null;
            this.swTextbox1.Location = new System.Drawing.Point(33, 161);
            this.swTextbox1.Multiline = true;
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(231, 60);
            this.swTextbox1.TabIndex = 38;
            this.swTextbox1.Tag = "CodeSpaceShipType";
            // 
            // swTxt_desc
            // 
            this.swTxt_desc.AllowEmpty = false;
            this.swTxt_desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.swTxt_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.swTxt_desc.DadaPermesa = AVISC_Controles.ContentType.Nombre;
            this.swTxt_desc.Font = new System.Drawing.Font("Inter", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.swTxt_desc.ForeColor = System.Drawing.Color.White;
            this.swTxt_desc.IsForeignKey = false;
            this.swTxt_desc.LinkedControlName = null;
            this.swTxt_desc.Location = new System.Drawing.Point(333, 158);
            this.swTxt_desc.Multiline = true;
            this.swTxt_desc.Name = "swTxt_desc";
            this.swTxt_desc.Size = new System.Drawing.Size(530, 60);
            this.swTxt_desc.TabIndex = 37;
            this.swTxt_desc.Tag = "DescSpaceShipType";
            // 
            // MantTipusNau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.swTxt_desc);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.cmb_descFiliation);
            this.Controls.Add(this.lbl_descFiliations);
            this.Controls.Add(this.lbl_descSpaceShipType);
            this.Controls.Add(this.lbl_codeSpaceShipType);
            this.Name = "MantTipusNau";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.lbl_codeSpaceShipType, 0);
            this.Controls.SetChildIndex(this.lbl_descSpaceShipType, 0);
            this.Controls.SetChildIndex(this.lbl_descFiliations, 0);
            this.Controls.SetChildIndex(this.cmb_descFiliation, 0);
            this.Controls.SetChildIndex(this.lbl_categoria, 0);
            this.Controls.SetChildIndex(this.cmb_category, 0);
            this.Controls.SetChildIndex(this.swTxt_desc, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codeSpaceShipType;
        private System.Windows.Forms.Label lbl_descSpaceShipType;
        private System.Windows.Forms.Label lbl_descFiliations;
        private System.Windows.Forms.ComboBox cmb_descFiliation;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.ComboBox cmb_category;
        private AVISC_Controles.SWTextbox swTxt_desc;
        private AVISC_Controles.SWTextbox swTextbox1;
    }
}

