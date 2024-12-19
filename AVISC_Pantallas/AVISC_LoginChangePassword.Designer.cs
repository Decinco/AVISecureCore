
namespace AVISC_Pantallas
{
    partial class AVISC_LoginChangePassword
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
            this.pnl_back = new System.Windows.Forms.Panel();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.pnl_warning = new System.Windows.Forms.Panel();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btm_generationNewPass = new System.Windows.Forms.Button();
            this.pnl_confirmNewPass = new System.Windows.Forms.Panel();
            this.pbx_confirmNewPass = new System.Windows.Forms.PictureBox();
            this.txt_confirmNewPass = new System.Windows.Forms.TextBox();
            this.pnl_newPass = new System.Windows.Forms.Panel();
            this.pbx_newPass = new System.Windows.Forms.PictureBox();
            this.txt_newPass = new System.Windows.Forms.TextBox();
            this.lbl_confirmNewPass = new System.Windows.Forms.Label();
            this.lbl_newPass = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pbx_back = new System.Windows.Forms.PictureBox();
            this.pnl_back.SuspendLayout();
            this.pnl_login.SuspendLayout();
            this.pnl_warning.SuspendLayout();
            this.pnl_confirmNewPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_confirmNewPass)).BeginInit();
            this.pnl_newPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_newPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_back)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_back
            // 
            this.pnl_back.Controls.Add(this.pnl_login);
            this.pnl_back.Controls.Add(this.pbx_back);
            this.pnl_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_back.Location = new System.Drawing.Point(0, 0);
            this.pnl_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_back.Name = "pnl_back";
            this.pnl_back.Size = new System.Drawing.Size(1920, 1055);
            this.pnl_back.TabIndex = 0;
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnl_login.Controls.Add(this.pnl_warning);
            this.pnl_login.Controls.Add(this.btm_generationNewPass);
            this.pnl_login.Controls.Add(this.pnl_confirmNewPass);
            this.pnl_login.Controls.Add(this.pnl_newPass);
            this.pnl_login.Controls.Add(this.lbl_confirmNewPass);
            this.pnl_login.Controls.Add(this.lbl_newPass);
            this.pnl_login.Controls.Add(this.lbl_titulo);
            this.pnl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnl_login.Location = new System.Drawing.Point(600, 302);
            this.pnl_login.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(720, 476);
            this.pnl_login.TabIndex = 4;
            // 
            // pnl_warning
            // 
            this.pnl_warning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.pnl_warning.Controls.Add(this.lbl_error);
            this.pnl_warning.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_warning.Location = new System.Drawing.Point(0, 0);
            this.pnl_warning.Name = "pnl_warning";
            this.pnl_warning.Size = new System.Drawing.Size(720, 35);
            this.pnl_warning.TabIndex = 6;
            // 
            // lbl_error
            // 
            this.lbl_error.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Inter", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Black;
            this.lbl_error.Location = new System.Drawing.Point(35, 4);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(666, 27);
            this.lbl_error.TabIndex = 0;
            this.lbl_error.Text = "Se ha pedido un cambio para la contraseña. Por favor, crea una nueva.";
            // 
            // btm_generationNewPass
            // 
            this.btm_generationNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btm_generationNewPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btm_generationNewPass.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btm_generationNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.btm_generationNewPass.Location = new System.Drawing.Point(243, 375);
            this.btm_generationNewPass.Name = "btm_generationNewPass";
            this.btm_generationNewPass.Size = new System.Drawing.Size(240, 59);
            this.btm_generationNewPass.TabIndex = 5;
            this.btm_generationNewPass.Text = "Generar";
            this.btm_generationNewPass.UseVisualStyleBackColor = false;
            this.btm_generationNewPass.Click += new System.EventHandler(this.btm_generationNewPass_Click);
            // 
            // pnl_confirmNewPass
            // 
            this.pnl_confirmNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pnl_confirmNewPass.Controls.Add(this.pbx_confirmNewPass);
            this.pnl_confirmNewPass.Controls.Add(this.txt_confirmNewPass);
            this.pnl_confirmNewPass.Location = new System.Drawing.Point(37, 283);
            this.pnl_confirmNewPass.Name = "pnl_confirmNewPass";
            this.pnl_confirmNewPass.Size = new System.Drawing.Size(655, 48);
            this.pnl_confirmNewPass.TabIndex = 4;
            // 
            // pbx_confirmNewPass
            // 
            this.pbx_confirmNewPass.Location = new System.Drawing.Point(605, 5);
            this.pbx_confirmNewPass.Name = "pbx_confirmNewPass";
            this.pbx_confirmNewPass.Size = new System.Drawing.Size(47, 38);
            this.pbx_confirmNewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_confirmNewPass.TabIndex = 2;
            this.pbx_confirmNewPass.TabStop = false;
            this.pbx_confirmNewPass.Click += new System.EventHandler(this.pbx_confirmNewPass_Click);
            // 
            // txt_confirmNewPass
            // 
            this.txt_confirmNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_confirmNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirmNewPass.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txt_confirmNewPass.ForeColor = System.Drawing.Color.White;
            this.txt_confirmNewPass.Location = new System.Drawing.Point(3, 8);
            this.txt_confirmNewPass.Multiline = true;
            this.txt_confirmNewPass.Name = "txt_confirmNewPass";
            this.txt_confirmNewPass.PasswordChar = '·';
            this.txt_confirmNewPass.Size = new System.Drawing.Size(596, 38);
            this.txt_confirmNewPass.TabIndex = 1;
            this.txt_confirmNewPass.UseSystemPasswordChar = true;
            // 
            // pnl_newPass
            // 
            this.pnl_newPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pnl_newPass.Controls.Add(this.pbx_newPass);
            this.pnl_newPass.Controls.Add(this.txt_newPass);
            this.pnl_newPass.Location = new System.Drawing.Point(37, 175);
            this.pnl_newPass.Name = "pnl_newPass";
            this.pnl_newPass.Size = new System.Drawing.Size(655, 48);
            this.pnl_newPass.TabIndex = 3;
            // 
            // pbx_newPass
            // 
            this.pbx_newPass.Location = new System.Drawing.Point(605, 5);
            this.pbx_newPass.Name = "pbx_newPass";
            this.pbx_newPass.Size = new System.Drawing.Size(47, 38);
            this.pbx_newPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_newPass.TabIndex = 3;
            this.pbx_newPass.TabStop = false;
            this.pbx_newPass.Click += new System.EventHandler(this.pbx_newPass_Click);
            // 
            // txt_newPass
            // 
            this.txt_newPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_newPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_newPass.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txt_newPass.ForeColor = System.Drawing.Color.White;
            this.txt_newPass.Location = new System.Drawing.Point(3, 8);
            this.txt_newPass.Multiline = true;
            this.txt_newPass.Name = "txt_newPass";
            this.txt_newPass.PasswordChar = '·';
            this.txt_newPass.Size = new System.Drawing.Size(596, 38);
            this.txt_newPass.TabIndex = 0;
            // 
            // lbl_confirmNewPass
            // 
            this.lbl_confirmNewPass.AutoSize = true;
            this.lbl_confirmNewPass.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_confirmNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lbl_confirmNewPass.Location = new System.Drawing.Point(30, 248);
            this.lbl_confirmNewPass.Name = "lbl_confirmNewPass";
            this.lbl_confirmNewPass.Size = new System.Drawing.Size(259, 32);
            this.lbl_confirmNewPass.TabIndex = 2;
            this.lbl_confirmNewPass.Text = "Confirmar Contraseña";
            // 
            // lbl_newPass
            // 
            this.lbl_newPass.AutoSize = true;
            this.lbl_newPass.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_newPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lbl_newPass.Location = new System.Drawing.Point(30, 131);
            this.lbl_newPass.Name = "lbl_newPass";
            this.lbl_newPass.Size = new System.Drawing.Size(142, 32);
            this.lbl_newPass.TabIndex = 1;
            this.lbl_newPass.Text = "Contraseña";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Inter", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.lbl_titulo.Location = new System.Drawing.Point(170, 40);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(386, 57);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Nueva Contraseña";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbx_back
            // 
            this.pbx_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_back.Image = global::AVISC_Pantallas.Properties.Resources.Log_In;
            this.pbx_back.Location = new System.Drawing.Point(0, 0);
            this.pbx_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbx_back.Name = "pbx_back";
            this.pbx_back.Size = new System.Drawing.Size(1920, 1055);
            this.pbx_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_back.TabIndex = 0;
            this.pbx_back.TabStop = false;
            // 
            // AVISC_LoginChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1055);
            this.Controls.Add(this.pnl_back);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AVISC_LoginChangePassword";
            this.Text = "AVISC_LoginChangePassword";
            this.Load += new System.EventHandler(this.AVISC_LoginChangePassword_Load);
            this.pnl_back.ResumeLayout(false);
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.pnl_warning.ResumeLayout(false);
            this.pnl_warning.PerformLayout();
            this.pnl_confirmNewPass.ResumeLayout(false);
            this.pnl_confirmNewPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_confirmNewPass)).EndInit();
            this.pnl_newPass.ResumeLayout(false);
            this.pnl_newPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_newPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_back;
        private System.Windows.Forms.PictureBox pbx_back;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Panel pnl_warning;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Button btm_generationNewPass;
        private System.Windows.Forms.Panel pnl_confirmNewPass;
        private System.Windows.Forms.PictureBox pbx_confirmNewPass;
        private System.Windows.Forms.TextBox txt_confirmNewPass;
        private System.Windows.Forms.Panel pnl_newPass;
        private System.Windows.Forms.PictureBox pbx_newPass;
        private System.Windows.Forms.TextBox txt_newPass;
        private System.Windows.Forms.Label lbl_confirmNewPass;
        private System.Windows.Forms.Label lbl_newPass;
        private System.Windows.Forms.Label lbl_titulo;
    }
}