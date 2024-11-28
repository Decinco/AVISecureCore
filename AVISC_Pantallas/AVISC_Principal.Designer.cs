
namespace AVISC_Pantallas
{
    partial class AVISC_Principal
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
            this.img_User = new System.Windows.Forms.PictureBox();
            this.lbl_ = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_User)).BeginInit();
            this.SuspendLayout();
            // 
            // img_User
            // 
            this.img_User.Image = global::AVISC_Pantallas.Properties.Resources.ferrari;
            this.img_User.Location = new System.Drawing.Point(40, 30);
            this.img_User.Name = "img_User";
            this.img_User.Size = new System.Drawing.Size(200, 200);
            this.img_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_User.TabIndex = 0;
            this.img_User.TabStop = false;
            // 
            // lbl_
            // 
            this.lbl_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lbl_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lbl_.Location = new System.Drawing.Point(276, 79);
            this.lbl_.Name = "lbl_";
            this.lbl_.ReadOnly = true;
            this.lbl_.Size = new System.Drawing.Size(542, 102);
            this.lbl_.TabIndex = 2;
            this.lbl_.Text = "¡Bienvenido a Secure Core, <persona>!";
            this.lbl_.Enter += new System.EventHandler(this.lbl__Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(40, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1760, 1);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(781, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elige qué quieres hacer";
            // 
            // AVISC_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.img_User);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AVISC_Principal";
            this.Text = "AVISC_Principal";
            ((System.ComponentModel.ISupportInitialize)(this.img_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_User;
        private System.Windows.Forms.RichTextBox lbl_;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}