
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AVISC_Login));
            this.pnl_fondo = new System.Windows.Forms.Panel();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.backVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.pnl_user = new System.Windows.Forms.Panel();
            this.pnl_pass = new System.Windows.Forms.Panel();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_fondo.SuspendLayout();
            this.pnl_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backVideo)).BeginInit();
            this.pnl_user.SuspendLayout();
            this.pnl_pass.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_fondo
            // 
            this.pnl_fondo.Controls.Add(this.pnl_login);
            this.pnl_fondo.Controls.Add(this.backVideo);
            this.pnl_fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_fondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnl_fondo.Location = new System.Drawing.Point(0, 0);
            this.pnl_fondo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_fondo.Name = "pnl_fondo";
            this.pnl_fondo.Size = new System.Drawing.Size(1920, 1080);
            this.pnl_fondo.TabIndex = 0;
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnl_login.Controls.Add(this.button1);
            this.pnl_login.Controls.Add(this.pnl_pass);
            this.pnl_login.Controls.Add(this.pnl_user);
            this.pnl_login.Controls.Add(this.lbl_pass);
            this.pnl_login.Controls.Add(this.lbl_user);
            this.pnl_login.Controls.Add(this.lbl_titulo);
            this.pnl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnl_login.Location = new System.Drawing.Point(600, 302);
            this.pnl_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(720, 476);
            this.pnl_login.TabIndex = 3;
            // 
            // backVideo
            // 
            this.backVideo.Enabled = true;
            this.backVideo.Location = new System.Drawing.Point(-8, -15);
            this.backVideo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backVideo.Name = "backVideo";
            this.backVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("backVideo.OcxState")));
            this.backVideo.Size = new System.Drawing.Size(1933, 1245);
            this.backVideo.TabIndex = 1;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Inter", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.lbl_titulo.Location = new System.Drawing.Point(215, 35);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(310, 57);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Iniciar Sessión";
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
            // pnl_user
            // 
            this.pnl_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pnl_user.Controls.Add(this.txt_user);
            this.pnl_user.Location = new System.Drawing.Point(37, 175);
            this.pnl_user.Name = "pnl_user";
            this.pnl_user.Size = new System.Drawing.Size(655, 48);
            this.pnl_user.TabIndex = 3;
            // 
            // pnl_pass
            // 
            this.pnl_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pnl_pass.Controls.Add(this.txt_pass);
            this.pnl_pass.Location = new System.Drawing.Point(37, 283);
            this.pnl_pass.Name = "pnl_pass";
            this.pnl_pass.Size = new System.Drawing.Size(655, 48);
            this.pnl_pass.TabIndex = 4;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_user.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.White;
            this.txt_user.Location = new System.Drawing.Point(3, 7);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(649, 34);
            this.txt_user.TabIndex = 0;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_pass.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(3, 7);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(649, 34);
            this.txt_pass.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.button1.Location = new System.Drawing.Point(243, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AVISC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pnl_fondo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AVISC_Login";
            this.Text = "AVISC_Login";
            this.Load += new System.EventHandler(this.AVISC_Login_Load);
            this.pnl_fondo.ResumeLayout(false);
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backVideo)).EndInit();
            this.pnl_user.ResumeLayout(false);
            this.pnl_user.PerformLayout();
            this.pnl_pass.ResumeLayout(false);
            this.pnl_pass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_fondo;
        private AxWMPLib.AxWindowsMediaPlayer backVideo;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnl_pass;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Panel pnl_user;
        private System.Windows.Forms.TextBox txt_user;
    }
}