namespace Controles
{
    partial class SWLauchForm
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
            this.pnl_configuracion = new System.Windows.Forms.Panel();
            this.pbx_imagen = new System.Windows.Forms.PictureBox();
            this.lbl_opcion = new System.Windows.Forms.Label();
            this.lbl_descipcion = new System.Windows.Forms.Label();
            this.pnl_configuracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_configuracion
            // 
            this.pnl_configuracion.Controls.Add(this.lbl_descipcion);
            this.pnl_configuracion.Controls.Add(this.lbl_opcion);
            this.pnl_configuracion.Controls.Add(this.pbx_imagen);
            this.pnl_configuracion.Location = new System.Drawing.Point(3, 3);
            this.pnl_configuracion.Name = "pnl_configuracion";
            this.pnl_configuracion.Size = new System.Drawing.Size(508, 310);
            this.pnl_configuracion.TabIndex = 0;
            this.pnl_configuracion.Click += new System.EventHandler(this.Abrir_Formulario_Click);
            // 
            // pbx_imagen
            // 
            this.pbx_imagen.Location = new System.Drawing.Point(19, 19);
            this.pbx_imagen.Name = "pbx_imagen";
            this.pbx_imagen.Size = new System.Drawing.Size(161, 150);
            this.pbx_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_imagen.TabIndex = 0;
            this.pbx_imagen.TabStop = false;
            this.pbx_imagen.Click += new System.EventHandler(this.Abrir_Formulario_Click);
            // 
            // lbl_opcion
            // 
            this.lbl_opcion.AutoSize = true;
            this.lbl_opcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_opcion.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_opcion.Location = new System.Drawing.Point(199, 19);
            this.lbl_opcion.Name = "lbl_opcion";
            this.lbl_opcion.Size = new System.Drawing.Size(85, 29);
            this.lbl_opcion.TabIndex = 1;
            this.lbl_opcion.Text = "label1";
            this.lbl_opcion.Click += new System.EventHandler(this.Abrir_Formulario_Click);
            // 
            // lbl_descipcion
            // 
            this.lbl_descipcion.AutoSize = true;
            this.lbl_descipcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descipcion.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_descipcion.Location = new System.Drawing.Point(19, 185);
            this.lbl_descipcion.Name = "lbl_descipcion";
            this.lbl_descipcion.Size = new System.Drawing.Size(53, 20);
            this.lbl_descipcion.TabIndex = 2;
            this.lbl_descipcion.Text = "label1";
            this.lbl_descipcion.Click += new System.EventHandler(this.Abrir_Formulario_Click);
            // 
            // SWLauchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.pnl_configuracion);
            this.Name = "SWLauchForm";
            this.Size = new System.Drawing.Size(514, 316);
            this.pnl_configuracion.ResumeLayout(false);
            this.pnl_configuracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_configuracion;
        private System.Windows.Forms.Label lbl_descipcion;
        private System.Windows.Forms.Label lbl_opcion;
        private System.Windows.Forms.PictureBox pbx_imagen;
    }
}
