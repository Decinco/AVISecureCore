
namespace AVISC_FTP
{
    partial class FTP_Configuration_From
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
            this.lblIP = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnExit = new AVISC_Controles.SWTextButton();
            this.btnSaveConf = new AVISC_Controles.SWTextButton();
            this.tbPassword = new AVISC_Controles.SWTextbox();
            this.tbUserName = new AVISC_Controles.SWTextbox();
            this.tbIP = new AVISC_Controles.SWTextbox();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Inter", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lblIP.Location = new System.Drawing.Point(88, 32);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(43, 32);
            this.lblIP.TabIndex = 33;
            this.lblIP.Text = "IP:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Inter", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lblUserName.Location = new System.Drawing.Point(282, 32);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(233, 32);
            this.lblUserName.TabIndex = 34;
            this.lblUserName.Text = "Nombre de Usuario:";
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Font = new System.Drawing.Font("Inter", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lblPassWord.Location = new System.Drawing.Point(541, 32);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(149, 32);
            this.lblPassWord.TabIndex = 35;
            this.lblPassWord.Text = "Contraseña:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Inter", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lblEstado.Location = new System.Drawing.Point(98, 175);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(22, 32);
            this.lblEstado.TabIndex = 41;
            this.lblEstado.Text = ".";
            // 
            // btnExit
            // 
            this.btnExit.ButtonEnabled = true;
            this.btnExit.ButtonText = "Cancelar";
            this.btnExit.Location = new System.Drawing.Point(667, 366);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 60);
            this.btnExit.TabIndex = 40;
            this.btnExit.ButtonClick += new System.EventHandler(this.btnExit_ButtonClick);
            // 
            // btnSaveConf
            // 
            this.btnSaveConf.ButtonEnabled = true;
            this.btnSaveConf.ButtonText = "Guardar Configuracion";
            this.btnSaveConf.Location = new System.Drawing.Point(522, 366);
            this.btnSaveConf.Name = "btnSaveConf";
            this.btnSaveConf.Size = new System.Drawing.Size(139, 60);
            this.btnSaveConf.TabIndex = 39;
            this.btnSaveConf.ButtonClick += new System.EventHandler(this.btnSaveConf_ButtonClick);
            // 
            // tbPassword
            // 
            this.tbPassword.AllowEmpty = false;
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.DadaPermesa = AVISC_Controles.ContentType.Codi;
            this.tbPassword.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.IsForeignKey = false;
            this.tbPassword.LinkedControlName = null;
            this.tbPassword.Location = new System.Drawing.Point(547, 95);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(156, 34);
            this.tbPassword.TabIndex = 38;
            this.tbPassword.Tag = "";
            // 
            // tbUserName
            // 
            this.tbUserName.AllowEmpty = false;
            this.tbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserName.DadaPermesa = AVISC_Controles.ContentType.Codi;
            this.tbUserName.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbUserName.ForeColor = System.Drawing.Color.White;
            this.tbUserName.IsForeignKey = false;
            this.tbUserName.LinkedControlName = null;
            this.tbUserName.Location = new System.Drawing.Point(288, 95);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(220, 34);
            this.tbUserName.TabIndex = 37;
            this.tbUserName.Tag = "";
            // 
            // tbIP
            // 
            this.tbIP.AllowEmpty = false;
            this.tbIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tbIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIP.DadaPermesa = AVISC_Controles.ContentType.Codi;
            this.tbIP.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbIP.ForeColor = System.Drawing.Color.White;
            this.tbIP.IsForeignKey = false;
            this.tbIP.LinkedControlName = null;
            this.tbIP.Location = new System.Drawing.Point(94, 95);
            this.tbIP.Multiline = true;
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(156, 34);
            this.tbIP.TabIndex = 36;
            this.tbIP.Tag = "";
            // 
            // FTP_Configuration_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(818, 438);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveConf);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1000, 400);
            this.Name = "FTP_Configuration_From";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FTP_Configuration_From";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassWord;
        private AVISC_Controles.SWTextbox tbIP;
        private AVISC_Controles.SWTextbox tbUserName;
        private AVISC_Controles.SWTextbox tbPassword;
        private AVISC_Controles.SWTextButton btnSaveConf;
        private AVISC_Controles.SWTextButton btnExit;
        private System.Windows.Forms.Label lblEstado;
    }
}