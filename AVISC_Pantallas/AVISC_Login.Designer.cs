
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
            this.pnl_salir = new System.Windows.Forms.Panel();
            this.pbx_salir = new System.Windows.Forms.PictureBox();
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.pnl_warning = new System.Windows.Forms.Panel();
            this.lbl_error = new System.Windows.Forms.Label();
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btm_login = new System.Windows.Forms.Button();
            this.panel_pass = new System.Windows.Forms.Panel();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.pbx_ojo = new System.Windows.Forms.PictureBox();
            this.panel_user = new System.Windows.Forms.Panel();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_titol = new System.Windows.Forms.Label();
            this.pnl_newPassword = new System.Windows.Forms.Panel();
            this.btm_generationNewPass = new System.Windows.Forms.Button();
            this.pnl_confirmNewPass = new System.Windows.Forms.Panel();
            this.pbx_confirmNewPass = new System.Windows.Forms.PictureBox();
            this.txt_confirmNewPass = new System.Windows.Forms.TextBox();
            this.pnl_newPass = new System.Windows.Forms.Panel();
            this.pbx_newPass = new System.Windows.Forms.PictureBox();
            this.txt_newPass = new System.Windows.Forms.TextBox();
            this.lbl_confirmNewPass = new System.Windows.Forms.Label();
            this.lbl_newPass = new System.Windows.Forms.Label();
            this.lbl_titolNewPass = new System.Windows.Forms.Label();
            this.pbx_back = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pnl_fondo.SuspendLayout();
            this.pnl_salir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_salir)).BeginInit();
            this.pnl_Container.SuspendLayout();
            this.pnl_warning.SuspendLayout();
            this.pnl_Login.SuspendLayout();
            this.panel_pass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ojo)).BeginInit();
            this.panel_user.SuspendLayout();
            this.pnl_newPassword.SuspendLayout();
            this.pnl_confirmNewPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_confirmNewPass)).BeginInit();
            this.pnl_newPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_newPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_back)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_fondo
            // 
            this.pnl_fondo.Controls.Add(this.pnl_salir);
            this.pnl_fondo.Controls.Add(this.pnl_Container);
            this.pnl_fondo.Controls.Add(this.pbx_back);
            this.pnl_fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_fondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnl_fondo.Location = new System.Drawing.Point(0, 0);
            this.pnl_fondo.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_fondo.Name = "pnl_fondo";
            this.pnl_fondo.Size = new System.Drawing.Size(1940, 1080);
            this.pnl_fondo.TabIndex = 0;
            // 
            // pnl_salir
            // 
            this.pnl_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnl_salir.Controls.Add(this.pbx_salir);
            this.pnl_salir.Location = new System.Drawing.Point(1841, -3);
            this.pnl_salir.Name = "pnl_salir";
            this.pnl_salir.Size = new System.Drawing.Size(80, 60);
            this.pnl_salir.TabIndex = 6;
            this.pnl_salir.Click += new System.EventHandler(this.pnl_salir_Click);
            this.pnl_salir.MouseEnter += new System.EventHandler(this.pnl_salir_MouseEnter_1);
            this.pnl_salir.MouseLeave += new System.EventHandler(this.pnl_salir_MouseLeave_1);
            // 
            // pbx_salir
            // 
            this.pbx_salir.Image = global::AVISC_Pantallas.Properties.Resources.energia1;
            this.pbx_salir.Location = new System.Drawing.Point(21, 10);
            this.pbx_salir.Name = "pbx_salir";
            this.pbx_salir.Size = new System.Drawing.Size(40, 40);
            this.pbx_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_salir.TabIndex = 5;
            this.pbx_salir.TabStop = false;
            this.pbx_salir.Click += new System.EventHandler(this.pbx_salir_Click_1);
            this.pbx_salir.MouseEnter += new System.EventHandler(this.pnl_salir_MouseEnter_1);
            this.pbx_salir.MouseLeave += new System.EventHandler(this.pnl_salir_MouseLeave_1);
            // 
            // pnl_Container
            // 
            this.pnl_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnl_Container.Controls.Add(this.pnl_warning);
            this.pnl_Container.Controls.Add(this.pnl_Login);
            this.pnl_Container.Controls.Add(this.pnl_newPassword);
            this.pnl_Container.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnl_Container.Location = new System.Drawing.Point(600, 302);
            this.pnl_Container.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(720, 476);
            this.pnl_Container.TabIndex = 3;
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
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.White;
            this.lbl_error.Location = new System.Drawing.Point(3, 4);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(714, 27);
            this.lbl_error.TabIndex = 0;
            this.lbl_error.Text = "lable1";
            this.lbl_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Login
            // 
            this.pnl_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnl_Login.Controls.Add(this.lbl_user);
            this.pnl_Login.Controls.Add(this.lbl_pass);
            this.pnl_Login.Controls.Add(this.btm_login);
            this.pnl_Login.Controls.Add(this.panel_pass);
            this.pnl_Login.Controls.Add(this.panel_user);
            this.pnl_Login.Controls.Add(this.lbl_titol);
            this.pnl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnl_Login.Location = new System.Drawing.Point(0, 0);
            this.pnl_Login.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(720, 476);
            this.pnl_Login.TabIndex = 7;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lbl_user.Location = new System.Drawing.Point(32, 143);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(224, 29);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "Nombre de Usuario";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lbl_pass.Location = new System.Drawing.Point(34, 251);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(136, 29);
            this.lbl_pass.TabIndex = 2;
            this.lbl_pass.Text = "Contraseña";
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
            this.btm_login.TabIndex = 2;
            this.btm_login.Text = "Entrar";
            this.btm_login.UseVisualStyleBackColor = false;
            this.btm_login.Click += new System.EventHandler(this.btm_login_Click);
            // 
            // panel_pass
            // 
            this.panel_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel_pass.Controls.Add(this.txt_pass);
            this.panel_pass.Controls.Add(this.pbx_ojo);
            this.panel_pass.Location = new System.Drawing.Point(37, 283);
            this.panel_pass.Name = "panel_pass";
            this.panel_pass.Size = new System.Drawing.Size(655, 48);
            this.panel_pass.TabIndex = 4;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.White;
            this.txt_pass.Location = new System.Drawing.Point(16, 8);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '·';
            this.txt_pass.Size = new System.Drawing.Size(583, 33);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SupressEnterAndNextTextbox);
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
            // panel_user
            // 
            this.panel_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel_user.Controls.Add(this.txt_user);
            this.panel_user.Location = new System.Drawing.Point(37, 175);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(655, 48);
            this.panel_user.TabIndex = 3;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.White;
            this.txt_user.Location = new System.Drawing.Point(20, 11);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(614, 27);
            this.txt_user.TabIndex = 3;
            this.txt_user.UseSystemPasswordChar = true;
            this.txt_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SupressEnterAndNextTextbox);
            // 
            // lbl_titol
            // 
            this.lbl_titol.Font = new System.Drawing.Font("Inter", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_titol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.lbl_titol.Location = new System.Drawing.Point(0, 47);
            this.lbl_titol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titol.Name = "lbl_titol";
            this.lbl_titol.Size = new System.Drawing.Size(722, 57);
            this.lbl_titol.TabIndex = 0;
            this.lbl_titol.Text = "Iniciar Sesión";
            this.lbl_titol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_newPassword
            // 
            this.pnl_newPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnl_newPassword.Controls.Add(this.btm_generationNewPass);
            this.pnl_newPassword.Controls.Add(this.pnl_confirmNewPass);
            this.pnl_newPassword.Controls.Add(this.pnl_newPass);
            this.pnl_newPassword.Controls.Add(this.lbl_confirmNewPass);
            this.pnl_newPassword.Controls.Add(this.lbl_newPass);
            this.pnl_newPassword.Controls.Add(this.lbl_titolNewPass);
            this.pnl_newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnl_newPassword.Location = new System.Drawing.Point(0, 0);
            this.pnl_newPassword.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_newPassword.Name = "pnl_newPassword";
            this.pnl_newPassword.Size = new System.Drawing.Size(722, 441);
            this.pnl_newPassword.TabIndex = 6;
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
            this.btm_generationNewPass.TabIndex = 2;
            this.btm_generationNewPass.TabStop = false;
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
            this.txt_confirmNewPass.Size = new System.Drawing.Size(596, 33);
            this.txt_confirmNewPass.TabIndex = 1;
            this.txt_confirmNewPass.TabStop = false;
            this.txt_confirmNewPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SupressEnterAndNextTextbox);
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
            this.txt_newPass.Location = new System.Drawing.Point(3, 7);
            this.txt_newPass.Multiline = true;
            this.txt_newPass.Name = "txt_newPass";
            this.txt_newPass.PasswordChar = '·';
            this.txt_newPass.Size = new System.Drawing.Size(596, 34);
            this.txt_newPass.TabIndex = 0;
            this.txt_newPass.TabStop = false;
            this.txt_newPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SupressEnterAndNextTextbox);
            // 
            // lbl_confirmNewPass
            // 
            this.lbl_confirmNewPass.AutoSize = true;
            this.lbl_confirmNewPass.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_confirmNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lbl_confirmNewPass.Location = new System.Drawing.Point(31, 248);
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
            this.lbl_newPass.Location = new System.Drawing.Point(31, 141);
            this.lbl_newPass.Name = "lbl_newPass";
            this.lbl_newPass.Size = new System.Drawing.Size(142, 32);
            this.lbl_newPass.TabIndex = 1;
            this.lbl_newPass.Text = "Contraseña";
            // 
            // lbl_titolNewPass
            // 
            this.lbl_titolNewPass.AutoSize = true;
            this.lbl_titolNewPass.Font = new System.Drawing.Font("Inter", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_titolNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.lbl_titolNewPass.Location = new System.Drawing.Point(165, 46);
            this.lbl_titolNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titolNewPass.Name = "lbl_titolNewPass";
            this.lbl_titolNewPass.Size = new System.Drawing.Size(386, 57);
            this.lbl_titolNewPass.TabIndex = 0;
            this.lbl_titolNewPass.Text = "Nueva Contraseña";
            this.lbl_titolNewPass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbx_back
            // 
            this.pbx_back.Image = global::AVISC_Pantallas.Properties.Resources.Log_In;
            this.pbx_back.Location = new System.Drawing.Point(0, -3);
            this.pbx_back.Name = "pbx_back";
            this.pbx_back.Size = new System.Drawing.Size(1920, 1083);
            this.pbx_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_back.TabIndex = 4;
            this.pbx_back.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 1);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 1);
            this.panel2.TabIndex = 2;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.btn_Login.Location = new System.Drawing.Point(243, 375);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(240, 59);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Entrar";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btm_login_Click);
            // 
            // AVISC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 1080);
            this.Controls.Add(this.pnl_fondo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AVISC_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVISC_Login";
            this.Load += new System.EventHandler(this.AVISC_Login_Load);
            this.pnl_fondo.ResumeLayout(false);
            this.pnl_salir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_salir)).EndInit();
            this.pnl_Container.ResumeLayout(false);
            this.pnl_warning.ResumeLayout(false);
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            this.panel_pass.ResumeLayout(false);
            this.panel_pass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ojo)).EndInit();
            this.panel_user.ResumeLayout(false);
            this.panel_user.PerformLayout();
            this.pnl_newPassword.ResumeLayout(false);
            this.pnl_newPassword.PerformLayout();
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

        private System.Windows.Forms.Panel pnl_fondo;
        private System.Windows.Forms.Panel pnl_Container;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.PictureBox pbx_back;
        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.Panel pnl_warning;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Panel panel_pass;
        private System.Windows.Forms.PictureBox pbx_ojo;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button btm_login;
        private System.Windows.Forms.Label lbl_titol;
        private System.Windows.Forms.Panel pnl_newPassword;
        private System.Windows.Forms.Button btm_generationNewPass;
        private System.Windows.Forms.Panel pnl_confirmNewPass;
        private System.Windows.Forms.PictureBox pbx_confirmNewPass;
        private System.Windows.Forms.Panel pnl_newPass;
        private System.Windows.Forms.PictureBox pbx_newPass;
        private System.Windows.Forms.Label lbl_confirmNewPass;
        private System.Windows.Forms.Label lbl_newPass;
        private System.Windows.Forms.Label lbl_titolNewPass;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txt_confirmNewPass;
        private System.Windows.Forms.TextBox txt_newPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbx_salir;
        private System.Windows.Forms.Panel pnl_salir;
    }
}