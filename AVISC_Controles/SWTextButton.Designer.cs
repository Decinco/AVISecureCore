
namespace AVISC_Controles
{
    partial class SWTextButton
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Button = new System.Windows.Forms.Panel();
            this.lbl_Button = new System.Windows.Forms.Label();
            this.pnl_Button.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Button
            // 
            this.pnl_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnl_Button.Controls.Add(this.lbl_Button);
            this.pnl_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Button.Location = new System.Drawing.Point(0, 0);
            this.pnl_Button.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(150, 150);
            this.pnl_Button.TabIndex = 53;
            // 
            // lbl_Button
            // 
            this.lbl_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Button.Font = new System.Drawing.Font("Inter", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Button.ForeColor = System.Drawing.Color.White;
            this.lbl_Button.Location = new System.Drawing.Point(0, 0);
            this.lbl_Button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Button.Name = "lbl_Button";
            this.lbl_Button.Size = new System.Drawing.Size(150, 150);
            this.lbl_Button.TabIndex = 51;
            this.lbl_Button.Text = "Reiniciar Contraseña";
            this.lbl_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Button.Click += new System.EventHandler(this.ClickEvent);
            this.lbl_Button.MouseEnter += new System.EventHandler(this.MouseEnterEvent);
            this.lbl_Button.MouseLeave += new System.EventHandler(this.MouseLeaveEvent);
            // 
            // SWTextButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Button);
            this.Name = "SWTextButton";
            this.pnl_Button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.Label lbl_Button;
    }
}
