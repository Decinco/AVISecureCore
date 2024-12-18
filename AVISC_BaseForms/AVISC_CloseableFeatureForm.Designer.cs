
namespace AVISC_BaseForms

{
    partial class AVISC_CloseableFeatureForm
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
            this.pnl_BackButton = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_BackButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_BackButton
            // 
            this.pnl_BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnl_BackButton.Controls.Add(this.pictureBox1);
            this.pnl_BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_BackButton.Location = new System.Drawing.Point(1759, 0);
            this.pnl_BackButton.Name = "pnl_BackButton";
            this.pnl_BackButton.Size = new System.Drawing.Size(81, 60);
            this.pnl_BackButton.TabIndex = 24;
            this.pnl_BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.pnl_BackButton.MouseEnter += new System.EventHandler(this.BackButton_Enter);
            this.pnl_BackButton.MouseLeave += new System.EventHandler(this.BackButton_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AVISC_BaseForms.Properties.Resources.UI_ICON_Back;
            this.pictureBox1.Location = new System.Drawing.Point(17, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.BackButton_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.BackButton_Enter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.BackButton_Leave);
            // 
            // AVISC_CloseableFeatureForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.pnl_BackButton);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AVISC_CloseableFeatureForm";
            this.Text = "AVISC_Principal";
            this.Load += new System.EventHandler(this.AVISC_CloseableFeatureForm_Load);
            this.pnl_BackButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}