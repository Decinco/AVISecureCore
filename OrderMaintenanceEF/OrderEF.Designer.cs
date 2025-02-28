
namespace OrderMaintenanceEF
{
    partial class OrderEF
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
            this.tbxFechaEntrega = new AVISC_Controles.SWTextbox();
            this.cbPrioridad = new System.Windows.Forms.ComboBox();
            this.cbAgencia = new System.Windows.Forms.ComboBox();
            this.cbCodeOrder = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbxFechaEntrega
            // 
            this.tbxFechaEntrega.AllowEmpty = false;
            this.tbxFechaEntrega.DadaPermesa = AVISC_Controles.ContentType.Nombre;
            this.tbxFechaEntrega.IsForeignKey = false;
            this.tbxFechaEntrega.LinkedControlName = null;
            this.tbxFechaEntrega.Location = new System.Drawing.Point(197, 51);
            this.tbxFechaEntrega.Name = "tbxFechaEntrega";
            this.tbxFechaEntrega.Size = new System.Drawing.Size(100, 22);
            this.tbxFechaEntrega.TabIndex = 1;
            // 
            // cbPrioridad
            // 
            this.cbPrioridad.FormattingEnabled = true;
            this.cbPrioridad.Location = new System.Drawing.Point(326, 51);
            this.cbPrioridad.Name = "cbPrioridad";
            this.cbPrioridad.Size = new System.Drawing.Size(121, 24);
            this.cbPrioridad.TabIndex = 2;
            // 
            // cbAgencia
            // 
            this.cbAgencia.FormattingEnabled = true;
            this.cbAgencia.Location = new System.Drawing.Point(479, 51);
            this.cbAgencia.Name = "cbAgencia";
            this.cbAgencia.Size = new System.Drawing.Size(121, 24);
            this.cbAgencia.TabIndex = 3;
            // 
            // cbCodeOrder
            // 
            this.cbCodeOrder.FormattingEnabled = true;
            this.cbCodeOrder.Location = new System.Drawing.Point(53, 51);
            this.cbCodeOrder.Name = "cbCodeOrder";
            this.cbCodeOrder.Size = new System.Drawing.Size(121, 24);
            this.cbCodeOrder.TabIndex = 4;
            // 
            // OrderEF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCodeOrder);
            this.Controls.Add(this.cbAgencia);
            this.Controls.Add(this.cbPrioridad);
            this.Controls.Add(this.tbxFechaEntrega);
            this.Name = "OrderEF";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OrderEF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AVISC_Controles.SWTextbox tbxFechaEntrega;
        private System.Windows.Forms.ComboBox cbPrioridad;
        private System.Windows.Forms.ComboBox cbAgencia;
        private System.Windows.Forms.ComboBox cbCodeOrder;
    }
}