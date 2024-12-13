
namespace AVISC_Controles
{
    partial class SWOption
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
            this.pnl_Option = new System.Windows.Forms.Panel();
            this.img_OptionIcon = new System.Windows.Forms.PictureBox();
            this.lbl_OptionName = new System.Windows.Forms.Label();
            this.pnl_Option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_OptionIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Option
            // 
            this.pnl_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnl_Option.Controls.Add(this.img_OptionIcon);
            this.pnl_Option.Controls.Add(this.lbl_OptionName);
            this.pnl_Option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Option.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Option.ForeColor = System.Drawing.Color.White;
            this.pnl_Option.Location = new System.Drawing.Point(0, 0);
            this.pnl_Option.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Option.Name = "pnl_Option";
            this.pnl_Option.Size = new System.Drawing.Size(433, 80);
            this.pnl_Option.TabIndex = 5;
            this.pnl_Option.Click += new System.EventHandler(this.PassEvent);
            this.pnl_Option.MouseEnter += new System.EventHandler(this.Option_Enter);
            this.pnl_Option.MouseLeave += new System.EventHandler(this.Option_Leave);
            // 
            // img_OptionIcon
            // 
            this.img_OptionIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_OptionIcon.Location = new System.Drawing.Point(0, 0);
            this.img_OptionIcon.Name = "img_OptionIcon";
            this.img_OptionIcon.Size = new System.Drawing.Size(80, 80);
            this.img_OptionIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_OptionIcon.TabIndex = 6;
            this.img_OptionIcon.TabStop = false;
            this.img_OptionIcon.Click += new System.EventHandler(this.PassEvent);
            this.img_OptionIcon.MouseEnter += new System.EventHandler(this.Option_Enter);
            this.img_OptionIcon.MouseLeave += new System.EventHandler(this.Option_Leave);
            // 
            // lbl_OptionName
            // 
            this.lbl_OptionName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_OptionName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_OptionName.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_OptionName.ForeColor = System.Drawing.Color.White;
            this.lbl_OptionName.Location = new System.Drawing.Point(86, 16);
            this.lbl_OptionName.Name = "lbl_OptionName";
            this.lbl_OptionName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_OptionName.Size = new System.Drawing.Size(329, 48);
            this.lbl_OptionName.TabIndex = 3;
            this.lbl_OptionName.Text = "label1";
            this.lbl_OptionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_OptionName.Click += new System.EventHandler(this.PassEvent);
            this.lbl_OptionName.MouseEnter += new System.EventHandler(this.Option_Enter);
            this.lbl_OptionName.MouseLeave += new System.EventHandler(this.Option_Leave);
            // 
            // SWOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Option);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SWOption";
            this.Size = new System.Drawing.Size(433, 80);
            this.MouseEnter += new System.EventHandler(this.Option_Enter);
            this.MouseLeave += new System.EventHandler(this.Option_Leave);
            this.pnl_Option.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_OptionIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Option;
        private System.Windows.Forms.PictureBox img_OptionIcon;
        private System.Windows.Forms.Label lbl_OptionName;
    }
}
