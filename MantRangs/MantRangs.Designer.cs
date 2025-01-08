
namespace UserRanks
{
    partial class MantRangs
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
            this.codeUserRank = new AVISC_Controles.SWTextbox();
            this.descUserRank = new AVISC_Controles.SWTextbox();
            this.codeRank = new System.Windows.Forms.Label();
            this.descRank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codeUserRank
            // 
            this.codeUserRank.AllowEmpty = false;
            this.codeUserRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.codeUserRank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeUserRank.DadaPermesa = AVISC_Controles.ContentType.Nombre;
            this.codeUserRank.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.codeUserRank.ForeColor = System.Drawing.Color.White;
            this.codeUserRank.IsForeignKey = false;
            this.codeUserRank.LinkedControlName = null;
            this.codeUserRank.Location = new System.Drawing.Point(33, 140);
            this.codeUserRank.Multiline = true;
            this.codeUserRank.Name = "codeUserRank";
            this.codeUserRank.Size = new System.Drawing.Size(245, 60);
            this.codeUserRank.TabIndex = 30;
            this.codeUserRank.Tag = "CodeUserRank";
            // 
            // descUserRank
            // 
            this.descUserRank.AllowEmpty = false;
            this.descUserRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.descUserRank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descUserRank.DadaPermesa = AVISC_Controles.ContentType.Nombre;
            this.descUserRank.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.descUserRank.ForeColor = System.Drawing.Color.White;
            this.descUserRank.IsForeignKey = false;
            this.descUserRank.LinkedControlName = null;
            this.descUserRank.Location = new System.Drawing.Point(398, 140);
            this.descUserRank.Multiline = true;
            this.descUserRank.Name = "descUserRank";
            this.descUserRank.Size = new System.Drawing.Size(245, 60);
            this.descUserRank.TabIndex = 31;
            this.descUserRank.Tag = "DescUserRank";
            // 
            // codeRank
            // 
            this.codeRank.AutoSize = true;
            this.codeRank.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.codeRank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.codeRank.Location = new System.Drawing.Point(26, 94);
            this.codeRank.Name = "codeRank";
            this.codeRank.Size = new System.Drawing.Size(170, 41);
            this.codeRank.TabIndex = 32;
            this.codeRank.Text = "Code Rank";
            // 
            // descRank
            // 
            this.descRank.AutoSize = true;
            this.descRank.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.descRank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.descRank.Location = new System.Drawing.Point(391, 94);
            this.descRank.Name = "descRank";
            this.descRank.Size = new System.Drawing.Size(89, 41);
            this.descRank.TabIndex = 33;
            this.descRank.Text = "Rank";
            // 
            // MantRangs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.descRank);
            this.Controls.Add(this.codeRank);
            this.Controls.Add(this.descUserRank);
            this.Controls.Add(this.codeUserRank);
            this.Name = "MantRangs";
            this.Text = "Rangs d\'Usuaris";
            this.Controls.SetChildIndex(this.codeUserRank, 0);
            this.Controls.SetChildIndex(this.descUserRank, 0);
            this.Controls.SetChildIndex(this.codeRank, 0);
            this.Controls.SetChildIndex(this.descRank, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AVISC_Controles.SWTextbox codeUserRank;
        private AVISC_Controles.SWTextbox descUserRank;
        private System.Windows.Forms.Label codeRank;
        private System.Windows.Forms.Label descRank;
    }
}

