
namespace Factories
{
    partial class MantFactories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.swTextbox2 = new AVISC_Controles.SWTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.swTextbox1 = new AVISC_Controles.SWTextbox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(31, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 41);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nombre";
            // 
            // swTextbox2
            // 
            this.swTextbox2.AllowEmpty = false;
            this.swTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.swTextbox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.swTextbox2.DadaPermesa = AVISC_Controles.ContentType.Nombre;
            this.swTextbox2.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.swTextbox2.ForeColor = System.Drawing.Color.White;
            this.swTextbox2.IsForeignKey = false;
            this.swTextbox2.LinkedControlName = null;
            this.swTextbox2.Location = new System.Drawing.Point(38, 173);
            this.swTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.swTextbox2.Multiline = true;
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.Size = new System.Drawing.Size(347, 44);
            this.swTextbox2.TabIndex = 38;
            this.swTextbox2.Tag = "DescFactory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(31, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 41);
            this.label3.TabIndex = 37;
            this.label3.Text = "Código";
            // 
            // swTextbox1
            // 
            this.swTextbox1.AllowEmpty = false;
            this.swTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.swTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.swTextbox1.DadaPermesa = AVISC_Controles.ContentType.Nombre;
            this.swTextbox1.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.swTextbox1.ForeColor = System.Drawing.Color.White;
            this.swTextbox1.IsForeignKey = false;
            this.swTextbox1.LinkedControlName = null;
            this.swTextbox1.Location = new System.Drawing.Point(38, 72);
            this.swTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.swTextbox1.Multiline = true;
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(347, 44);
            this.swTextbox1.TabIndex = 36;
            this.swTextbox1.Tag = "codeFactory";
            // 
            // MantFactories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.swTextbox1);
            this.Name = "MantFactories";
            this.Text = "MantFactories";
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private AVISC_Controles.SWTextbox swTextbox2;
        private System.Windows.Forms.Label label3;
        private AVISC_Controles.SWTextbox swTextbox1;
    }
}