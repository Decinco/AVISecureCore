
namespace AVISC_Maintenance
{
    partial class BaseForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nuevoDB = new System.Windows.Forms.Button();
            this.actualizarDB = new System.Windows.Forms.Button();
            this.swTextboxSpecie = new AVISC_Controles.SWTextbox();
            this.swTextboxCognom = new AVISC_Controles.SWTextbox();
            this.swTextboxNom = new AVISC_Controles.SWTextbox();
            this.saveImg = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1749, 622);
            this.dataGridView1.TabIndex = 1;
            // 
            // nuevoDB
            // 
            this.nuevoDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.nuevoDB.FlatAppearance.BorderSize = 0;
            this.nuevoDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoDB.Font = new System.Drawing.Font("Inter ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoDB.ForeColor = System.Drawing.Color.White;
            this.nuevoDB.Location = new System.Drawing.Point(1299, 79);
            this.nuevoDB.Name = "nuevoDB";
            this.nuevoDB.Size = new System.Drawing.Size(180, 60);
            this.nuevoDB.TabIndex = 4;
            this.nuevoDB.Text = "Nuevo";
            this.nuevoDB.UseVisualStyleBackColor = false;
            this.nuevoDB.Click += new System.EventHandler(this.nuevoDB_Click_1);
            // 
            // actualizarDB
            // 
            this.actualizarDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.actualizarDB.FlatAppearance.BorderSize = 0;
            this.actualizarDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizarDB.Font = new System.Drawing.Font("Inter ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizarDB.ForeColor = System.Drawing.Color.White;
            this.actualizarDB.Location = new System.Drawing.Point(1622, 79);
            this.actualizarDB.Name = "actualizarDB";
            this.actualizarDB.Size = new System.Drawing.Size(180, 60);
            this.actualizarDB.TabIndex = 5;
            this.actualizarDB.Text = "Guardar\r\nCambios";
            this.actualizarDB.UseVisualStyleBackColor = false;
            this.actualizarDB.Click += new System.EventHandler(this.actualizarDB_Click);
            // 
            // swTextboxSpecie
            // 
            this.swTextboxSpecie.AllowEmpty = false;
            this.swTextboxSpecie.DadaPermesa = AVISC_Controles.ContentType.Text;
            this.swTextboxSpecie.IsForeignKey = false;
            this.swTextboxSpecie.LinkedControlName = null;
            this.swTextboxSpecie.Location = new System.Drawing.Point(786, 83);
            this.swTextboxSpecie.Name = "swTextboxSpecie";
            this.swTextboxSpecie.Size = new System.Drawing.Size(265, 22);
            this.swTextboxSpecie.TabIndex = 11;
            this.swTextboxSpecie.Tag = "DescSpecie";
            // 
            // swTextboxCognom
            // 
            this.swTextboxCognom.AllowEmpty = false;
            this.swTextboxCognom.DadaPermesa = AVISC_Controles.ContentType.Text;
            this.swTextboxCognom.IsForeignKey = false;
            this.swTextboxCognom.LinkedControlName = null;
            this.swTextboxCognom.Location = new System.Drawing.Point(340, 84);
            this.swTextboxCognom.Name = "swTextboxCognom";
            this.swTextboxCognom.Size = new System.Drawing.Size(422, 22);
            this.swTextboxCognom.TabIndex = 10;
            this.swTextboxCognom.Tag = "CodeSpecie";
            // 
            // swTextboxNom
            // 
            this.swTextboxNom.AllowEmpty = false;
            this.swTextboxNom.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.swTextboxNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.swTextboxNom.DadaPermesa = AVISC_Controles.ContentType.Text;
            this.swTextboxNom.IsForeignKey = false;
            this.swTextboxNom.LinkedControlName = null;
            this.swTextboxNom.Location = new System.Drawing.Point(61, 84);
            this.swTextboxNom.Multiline = true;
            this.swTextboxNom.Name = "swTextboxNom";
            this.swTextboxNom.Size = new System.Drawing.Size(245, 60);
            this.swTextboxNom.TabIndex = 9;
            this.swTextboxNom.Tag = "CodeSpecie";
            // 
            // saveImg
            // 
            this.saveImg.Image = global::AVISC_Maintenance.Properties.Resources.save_img;
            this.saveImg.Location = new System.Drawing.Point(9, 10);
            this.saveImg.Name = "saveImg";
            this.saveImg.Size = new System.Drawing.Size(40, 40);
            this.saveImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saveImg.TabIndex = 25;
            this.saveImg.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panel1.Controls.Add(this.saveImg);
            this.panel1.Location = new System.Drawing.Point(1564, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 60);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(1240, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 60);
            this.panel2.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AVISC_Maintenance.Properties.Resources.save_img;
            this.pictureBox2.Location = new System.Drawing.Point(10, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.swTextboxSpecie);
            this.Controls.Add(this.swTextboxCognom);
            this.Controls.Add(this.swTextboxNom);
            this.Controls.Add(this.actualizarDB);
            this.Controls.Add(this.nuevoDB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.nuevoDB, 0);
            this.Controls.SetChildIndex(this.actualizarDB, 0);
            this.Controls.SetChildIndex(this.swTextboxNom, 0);
            this.Controls.SetChildIndex(this.swTextboxCognom, 0);
            this.Controls.SetChildIndex(this.swTextboxSpecie, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button nuevoDB;
        private System.Windows.Forms.Button actualizarDB;
        private AVISC_Controles.SWTextbox swTextboxNom;
        private AVISC_Controles.SWTextbox swTextboxCognom;
        private AVISC_Controles.SWTextbox swTextboxSpecie;
        private System.Windows.Forms.PictureBox saveImg;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}