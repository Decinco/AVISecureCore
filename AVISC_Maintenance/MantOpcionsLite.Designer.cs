namespace AVISC_Maintenance
{
    partial class MantOpcionsLite
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbx_Icon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_ImgByteArray = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 20);
            this.textBox1.TabIndex = 30;
            this.textBox1.Tag = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 31;
            this.label3.Tag = "";
            this.label3.Text = "Opción";
            // 
            // pbx_Icon
            // 
            this.pbx_Icon.ErrorImage = global::AVISC_Maintenance.Properties.Resources.octagon_xmark;
            this.pbx_Icon.Location = new System.Drawing.Point(436, 142);
            this.pbx_Icon.Name = "pbx_Icon";
            this.pbx_Icon.Size = new System.Drawing.Size(60, 60);
            this.pbx_Icon.TabIndex = 32;
            this.pbx_Icon.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(433, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 33;
            this.label4.Tag = "";
            this.label4.Text = "IMAGEM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Añadir Imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_ImgByteArray
            // 
            this.txt_ImgByteArray.Location = new System.Drawing.Point(419, 100);
            this.txt_ImgByteArray.Name = "txt_ImgByteArray";
            this.txt_ImgByteArray.Size = new System.Drawing.Size(100, 20);
            this.txt_ImgByteArray.TabIndex = 35;
            // 
            // MantOpcionsLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.txt_ImgByteArray);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbx_Icon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Name = "MantOpcionsLite";
            this.Text = "MantOpcionsLite";
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.pbx_Icon, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txt_ImgByteArray, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbx_Icon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_ImgByteArray;
    }
}