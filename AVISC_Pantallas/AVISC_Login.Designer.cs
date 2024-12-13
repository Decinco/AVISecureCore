﻿
namespace AVISC_Pantallas
{
    partial class AVISC_Login
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
            this.pnl_fondo = new System.Windows.Forms.Panel();
            this.pbx_back = new System.Windows.Forms.PictureBox();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.pnl_warning = new System.Windows.Forms.Panel();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btm_login = new System.Windows.Forms.Button();
            this.pnl_pass = new System.Windows.Forms.Panel();
            this.pbx_ojo = new System.Windows.Forms.PictureBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.pnl_user = new System.Windows.Forms.Panel();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_fondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_back)).BeginInit();
            this.pnl_login.SuspendLayout();
            this.pnl_warning.SuspendLayout();
            this.pnl_pass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ojo)).BeginInit();
            this.pnl_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_fondo
            // 
            this.pnl_fondo.Controls.Add(this.pbx_back);
            this.pnl_fondo.Controls.Add(this.pnl_login);
            this.pnl_fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_fondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnl_fondo.Location = new System.Drawing.Point(0, 0);
            this.pnl_fondo.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_fondo.Name = "pnl_fondo";
            this.pnl_fondo.Size = new System.Drawing.Size(1920, 1080);
            this.pnl_fondo.TabIndex = 0;
            // 
            // pbx_back
            // 
            this.pbx_back.Image = global::AVISC_Pantallas.Properties.Resources.Log_In;
            this.pbx_back.Location = new System.Drawing.Point(24, 58);
            this.pbx_back.Name = "pbx_back";
            this.pbx_back.Size = new System.Drawing.Size(321, 312);
            this.pbx_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_back.TabIndex = 4;
            this.pbx_back.TabStop = false;
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnl_login.Controls.Add(this.pnl_warning);
            this.pnl_login.Controls.Add(this.btm_login);
            this.pnl_login.Controls.Add(this.pnl_pass);
            this.pnl_login.Controls.Add(this.pnl_user);
            this.pnl_login.Controls.Add(this.lbl_pass);
            this.pnl_login.Controls.Add(this.lbl_user);
            this.pnl_login.Controls.Add(this.lbl_titulo);
            this.pnl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnl_login.Location = new System.Drawing.Point(600, 302);
            this.pnl_login.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(720, 476);
            this.pnl_login.TabIndex = 3;
            // 
            // pnl_warning
            // 
            this.pnl_warning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnl_warning.Controls.Add(this.lbl_error);
            this.pnl_warning.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_warning.Location = new System.Drawing.Point(0, 0);
            this.pnl_warning.Name = "pnl_warning";
            this.pnl_warning.Size = new System.Drawing.Size(720, 35);
            this.pnl_warning.TabIndex = 6;
            this.pnl_warning.Visible = false;
            // 
            // lbl_error
            // 
            this.lbl_error.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Inter", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.White;
            this.lbl_error.Location = new System.Drawing.Point(35, 4);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(65, 27);
            this.lbl_error.TabIndex = 0;
            this.lbl_error.Text = "label1";
            this.lbl_error.Visible = false;
            // 
            // btm_login
            // 
            this.btm_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btm_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btm_login.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btm_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.btm_login.Location = new System.Drawing.Point(243, 375);
            this.btm_login.Name = "btm_login";
            this.btm_login.Size = new System.Drawing.Size(240, 59);
            this.btm_login.TabIndex = 5;
            this.btm_login.Text = "Entrar";
            this.btm_login.UseVisualStyleBackColor = false;
            this.btm_login.Click += new System.EventHandler(this.btm_login_Click);
            // 
            // pnl_pass
            // 
            this.pnl_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pnl_pass.Controls.Add(this.pbx_ojo);
            this.pnl_pass.Controls.Add(this.txt_pass);
            this.pnl_pass.Location = new System.Drawing.Point(37, 283);
            this.pnl_pass.Name = "pnl_pass";
            this.pnl_pass.Size = new System.Drawing.Size(655, 48);
            this.pnl_pass.TabIndex = 4;
            // 
            // pbx_ojo
            // 
            this.pbx_ojo.Location = new System.Drawing.Point(605, 5);
            this.pbx_ojo.Name = "pbx_ojo";
            this.pbx_ojo.Size = new System.Drawing.Size(47, 38);
            this.pbx_ojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_ojo.TabIndex = 2;
            this.pbx_ojo.TabStop = false;
            this.pbx_ojo.Click += new System.EventHandler(this.pbx_ojo_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.White;
            this.txt_pass.Location = new System.Drawing.Point(3, 8);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '·';
            this.txt_pass.Size = new System.Drawing.Size(596, 38);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // pnl_user
            // 
            this.pnl_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pnl_user.Controls.Add(this.txt_user);
            this.pnl_user.Location = new System.Drawing.Point(37, 175);
            this.pnl_user.Name = "pnl_user";
            this.pnl_user.Size = new System.Drawing.Size(655, 48);
            this.pnl_user.TabIndex = 3;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.White;
            this.txt_user.Location = new System.Drawing.Point(3, 8);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(649, 38);
            this.txt_user.TabIndex = 0;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lbl_pass.Location = new System.Drawing.Point(30, 248);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(142, 32);
            this.lbl_pass.TabIndex = 2;
            this.lbl_pass.Text = "Contraseña";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lbl_user.Location = new System.Drawing.Point(30, 131);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(226, 32);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "Nombre de Usuario";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Inter", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.lbl_titulo.Location = new System.Drawing.Point(210, 35);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(310, 57);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Iniciar Sessión";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AVISC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pnl_fondo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AVISC_Login";
            this.Text = "AVISC_Login";
            this.Load += new System.EventHandler(this.AVISC_Login_Load);
            this.pnl_fondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_back)).EndInit();
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.pnl_warning.ResumeLayout(false);
            this.pnl_warning.PerformLayout();
            this.pnl_pass.ResumeLayout(false);
            this.pnl_pass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ojo)).EndInit();
            this.pnl_user.ResumeLayout(false);
            this.pnl_user.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_fondo;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btm_login;
        private System.Windows.Forms.Panel pnl_pass;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Panel pnl_user;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Panel pnl_warning;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.PictureBox pbx_ojo;
        private System.Windows.Forms.PictureBox pbx_back;
    }
}