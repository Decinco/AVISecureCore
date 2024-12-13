
using System.Drawing;

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
            this.pnl_OptionList = new System.Windows.Forms.FlowLayoutPanel();
            this.swOption1 = new AVISC_Controles.SWOption();
            this.swOption2 = new AVISC_Controles.SWOption();
            ((System.ComponentModel.ISupportInitialize)(this.img_UserProfilePicture)).BeginInit();
            this.pnl_User.SuspendLayout();
            this.pnl_OptionList.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_UserProfilePicture
            // 
            this.img_UserProfilePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_UserProfilePicture.Location = new System.Drawing.Point(353, 0);
            this.img_UserProfilePicture.Name = "img_UserProfilePicture";
            this.img_UserProfilePicture.Size = new System.Drawing.Size(80, 80);
            this.img_UserProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_UserProfilePicture.TabIndex = 6;
            this.img_UserProfilePicture.TabStop = false;
            this.img_UserProfilePicture.Click += new System.EventHandler(this.UserPanel_Click);
            this.img_UserProfilePicture.MouseEnter += new System.EventHandler(this.UserPanel_Enter);
            this.img_UserProfilePicture.MouseLeave += new System.EventHandler(this.UserPanel_Leave);
            // 
            // lbl_Role
            // 
            this.lbl_Role.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Role.Font = new System.Drawing.Font("Inter", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Role.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Role.Location = new System.Drawing.Point(3, 45);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(341, 24);
            this.lbl_Role.TabIndex = 4;
            this.lbl_Role.Text = "label2";
            this.lbl_Role.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Role.Click += new System.EventHandler(this.UserPanel_Click);
            this.lbl_Role.MouseEnter += new System.EventHandler(this.UserPanel_Enter);
            this.lbl_Role.MouseLeave += new System.EventHandler(this.UserPanel_Leave);
            // 
            // lbl_Username
            // 
            this.lbl_Username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Username.Font = new System.Drawing.Font("Inter", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Username.Location = new System.Drawing.Point(7, 6);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Username.Size = new System.Drawing.Size(343, 48);
            this.lbl_Username.TabIndex = 3;
            this.lbl_Username.Text = "label1";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Username.Click += new System.EventHandler(this.UserPanel_Click);
            this.lbl_Username.MouseEnter += new System.EventHandler(this.UserPanel_Enter);
            this.lbl_Username.MouseLeave += new System.EventHandler(this.UserPanel_Leave);
            // 
            // pnl_User
            // 
            this.pnl_User.BackColor = System.Drawing.Color.Black;
            this.pnl_User.Controls.Add(this.img_UserProfilePicture);
            this.pnl_User.Controls.Add(this.lbl_Role);
            this.pnl_User.Controls.Add(this.lbl_Username);
            this.pnl_User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_User.Location = new System.Drawing.Point(0, 0);
            this.pnl_User.Name = "pnl_User";
            this.pnl_User.Size = new System.Drawing.Size(433, 80);
            this.pnl_User.TabIndex = 4;
            this.pnl_User.Click += new System.EventHandler(this.UserPanel_Click);
            this.pnl_User.MouseEnter += new System.EventHandler(this.UserPanel_Enter);
            this.pnl_User.MouseLeave += new System.EventHandler(this.UserPanel_Leave);
            // 
            // pnl_OptionList
            // 
            this.pnl_OptionList.AutoSize = true;
            this.pnl_OptionList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnl_OptionList.Controls.Add(this.swOption1);
            this.pnl_OptionList.Controls.Add(this.swOption2);
            this.pnl_OptionList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_OptionList.ForeColor = System.Drawing.Color.White;
            this.pnl_OptionList.Location = new System.Drawing.Point(0, 80);
            this.pnl_OptionList.MaximumSize = new System.Drawing.Size(433, 0);
            this.pnl_OptionList.Name = "pnl_OptionList";
            this.pnl_OptionList.Size = new System.Drawing.Size(433, 160);
            this.pnl_OptionList.TabIndex = 5;
            this.pnl_OptionList.Visible = false;
            // 
            // swOption1
            // 
            this.swOption1.ForeColor = System.Drawing.Color.White;
            this.swOption1.Location = new System.Drawing.Point(0, 0);
            this.swOption1.Margin = new System.Windows.Forms.Padding(0);
            this.swOption1.Name = "swOption1";
            this.swOption1.OptionIcon = null;
            this.swOption1.OptionName = "Cerrar Sesión";
            this.swOption1.Size = new System.Drawing.Size(433, 80);
            this.swOption1.TabIndex = 6;
            this.swOption1.OptionClick += new System.EventHandler(this.LogOut);
            // 
            // swOption2
            // 
            this.swOption2.ForeColor = System.Drawing.Color.White;
            this.swOption2.Location = new System.Drawing.Point(0, 80);
            this.swOption2.Margin = new System.Windows.Forms.Padding(0);
            this.swOption2.Name = "swOption2";
            this.swOption2.OptionIcon = null;
            this.swOption2.OptionName = "Salir del Programa";
            this.swOption2.Size = new System.Drawing.Size(433, 80);
            this.swOption2.TabIndex = 7;
            this.swOption2.OptionClick += new System.EventHandler(this.LogOff);
            // 
            // SWUserOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnl_OptionList);
            this.Controls.Add(this.pnl_User);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SWUserOptions";
            this.Size = new System.Drawing.Size(433, 240);
            ((System.ComponentModel.ISupportInitialize)(this.img_UserProfilePicture)).EndInit();
            this.pnl_User.ResumeLayout(false);
            this.pnl_OptionList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_UserProfilePicture;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Panel pnl_User;
        private System.Windows.Forms.FlowLayoutPanel pnl_OptionList;
        private SWOption swOption1;
        private SWOption swOption2;
    }
}
