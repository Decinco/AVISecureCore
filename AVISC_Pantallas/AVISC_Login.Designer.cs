
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
            this.pnl_fondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_fondo
            // 
            this.pnl_fondo.Controls.Add(this.pnl_login);
            this.pnl_fondo.Controls.Add(this.backVideo);
            this.pnl_fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_fondo.Location = new System.Drawing.Point(0, 0);
            this.pnl_fondo.Name = "pnl_fondo";
            this.pnl_fondo.Size = new System.Drawing.Size(1942, 1000);
            this.pnl_fondo.TabIndex = 0;
            // 
            // pnl_login
            // 
            this.pnl_login.Location = new System.Drawing.Point(600, 302);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(720, 476);
            this.pnl_login.TabIndex = 3;
            // 
            // backVideo
            // 
            this.backVideo.Enabled = true;
            this.backVideo.Location = new System.Drawing.Point(-14, -35);
            this.backVideo.Name = "backVideo";
            this.backVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("backVideo.OcxState")));
            this.backVideo.Size = new System.Drawing.Size(1956, 1083);
            this.backVideo.TabIndex = 1;
            // 
            // AVISC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1000);
            this.Controls.Add(this.pnl_fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AVISC_Login";
            this.Text = "AVISC_Login";
            this.Load += new System.EventHandler(this.AVISC_Login_Load);
            this.pnl_fondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_fondo;
        private AxWMPLib.AxWindowsMediaPlayer backVideo;
        private System.Windows.Forms.Panel pnl_login;
    }
}