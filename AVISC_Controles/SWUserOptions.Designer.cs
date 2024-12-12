
namespace AVISC_Controles
{
    partial class SWUserOptions
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
            this.img_UserProfilePicture = new System.Windows.Forms.PictureBox();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.pnl_User = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.img_UserProfilePicture)).BeginInit();
            this.pnl_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_UserProfilePicture
            // 
            this.img_UserProfilePicture.Location = new System.Drawing.Point(353, 0);
            this.img_UserProfilePicture.Name = "img_UserProfilePicture";
            this.img_UserProfilePicture.Size = new System.Drawing.Size(80, 80);
            this.img_UserProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_UserProfilePicture.TabIndex = 6;
            this.img_UserProfilePicture.TabStop = false;
            // 
            // lbl_Role
            // 
            this.lbl_Role.Font = new System.Drawing.Font("Inter", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Role.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Role.Location = new System.Drawing.Point(3, 45);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(341, 24);
            this.lbl_Role.TabIndex = 4;
            this.lbl_Role.Text = "label2";
            this.lbl_Role.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Username
            // 
            this.lbl_Username.Font = new System.Drawing.Font("Inter", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Username.Location = new System.Drawing.Point(7, 6);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Username.Size = new System.Drawing.Size(343, 48);
            this.lbl_Username.TabIndex = 3;
            this.lbl_Username.Text = "label1";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_User
            // 
            this.pnl_User.BackColor = System.Drawing.Color.Black;
            this.pnl_User.Controls.Add(this.img_UserProfilePicture);
            this.pnl_User.Controls.Add(this.lbl_Role);
            this.pnl_User.Controls.Add(this.lbl_Username);
            this.pnl_User.Location = new System.Drawing.Point(0, 0);
            this.pnl_User.Name = "pnl_User";
            this.pnl_User.Size = new System.Drawing.Size(433, 80);
            this.pnl_User.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 80);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 80);
            this.panel2.TabIndex = 8;
            // 
            // SWUserOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_User);
            this.Name = "SWUserOptions";
            this.Size = new System.Drawing.Size(433, 239);
            this.MouseEnter += new System.EventHandler(this.UserPanel_Enter);
            this.MouseLeave += new System.EventHandler(this.UserPanel_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.img_UserProfilePicture)).EndInit();
            this.pnl_User.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_UserProfilePicture;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Panel pnl_User;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
