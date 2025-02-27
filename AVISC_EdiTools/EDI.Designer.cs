
namespace AVISC_EdiTools
{
    partial class EDI
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
            this.swTextButton1 = new AVISC_Controles.SWTextButton();
            this.swTextButton2 = new AVISC_Controles.SWTextButton();
            this.txt_Edi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // swTextButton1
            // 
            this.swTextButton1.ButtonEnabled = true;
            this.swTextButton1.ButtonText = "Seleccionar el EDI";
            this.swTextButton1.Location = new System.Drawing.Point(85, 209);
            this.swTextButton1.Name = "swTextButton1";
            this.swTextButton1.Size = new System.Drawing.Size(262, 63);
            this.swTextButton1.TabIndex = 25;
            this.swTextButton1.ButtonClick += new System.EventHandler(this.swTextButton1_ButtonClick);
            // 
            // swTextButton2
            // 
            this.swTextButton2.ButtonEnabled = true;
            this.swTextButton2.ButtonText = "Subir a la BDD";
            this.swTextButton2.Location = new System.Drawing.Point(85, 319);
            this.swTextButton2.Name = "swTextButton2";
            this.swTextButton2.Size = new System.Drawing.Size(262, 63);
            this.swTextButton2.TabIndex = 26;
            this.swTextButton2.ButtonClick += new System.EventHandler(this.swTextButton2_ButtonClick);
            // 
            // txt_Edi
            // 
            this.txt_Edi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txt_Edi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Edi.Font = new System.Drawing.Font("Inter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Edi.ForeColor = System.Drawing.Color.White;
            this.txt_Edi.Location = new System.Drawing.Point(391, 209);
            this.txt_Edi.Multiline = true;
            this.txt_Edi.Name = "txt_Edi";
            this.txt_Edi.Size = new System.Drawing.Size(944, 678);
            this.txt_Edi.TabIndex = 27;
            // 
            // EDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.txt_Edi);
            this.Controls.Add(this.swTextButton2);
            this.Controls.Add(this.swTextButton1);
            this.Name = "EDI";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.swTextButton1, 0);
            this.Controls.SetChildIndex(this.swTextButton2, 0);
            this.Controls.SetChildIndex(this.txt_Edi, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AVISC_Controles.SWTextButton swTextButton1;
        private AVISC_Controles.SWTextButton swTextButton2;
        private System.Windows.Forms.TextBox txt_Edi;
    }
}

