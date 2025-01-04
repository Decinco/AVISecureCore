
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
            this.dataBaseView = new System.Windows.Forms.DataGridView();
            this.nuevoDB = new System.Windows.Forms.Button();
            this.actualizarDB = new System.Windows.Forms.Button();
            this.swTextboxSpecie = new AVISC_Controles.SWTextbox();
            this.swTextboxCognom = new AVISC_Controles.SWTextbox();
            this.swTextboxNom = new AVISC_Controles.SWTextbox();
            this.saveImg = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.actualizarPanel = new System.Windows.Forms.Panel();
            this.nuevoPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.apellidoLbl = new System.Windows.Forms.Label();
            this.descSpecieLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveImg)).BeginInit();
            this.actualizarPanel.SuspendLayout();
            this.nuevoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataBaseView
            // 
            this.dataBaseView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBaseView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dataBaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBaseView.Location = new System.Drawing.Point(61, 285);
            this.dataBaseView.Name = "dataBaseView";
            this.dataBaseView.RowHeadersWidth = 51;
            this.dataBaseView.Size = new System.Drawing.Size(1749, 622);
            this.dataBaseView.TabIndex = 1;
            // 
            // nuevoDB
            // 
            this.nuevoDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.nuevoDB.FlatAppearance.BorderSize = 0;
            this.nuevoDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoDB.Font = new System.Drawing.Font("Inter ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.actualizarDB.Font = new System.Drawing.Font("Inter ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.swTextboxSpecie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.swTextboxSpecie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.swTextboxSpecie.DadaPermesa = AVISC_Controles.ContentType.Text;
            this.swTextboxSpecie.Font = new System.Drawing.Font("Inter SemiBold", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextboxSpecie.ForeColor = System.Drawing.Color.White;
            this.swTextboxSpecie.IsForeignKey = false;
            this.swTextboxSpecie.LinkedControlName = null;
            this.swTextboxSpecie.Location = new System.Drawing.Point(905, 84);
            this.swTextboxSpecie.Multiline = true;
            this.swTextboxSpecie.Name = "swTextboxSpecie";
            this.swTextboxSpecie.Size = new System.Drawing.Size(245, 60);
            this.swTextboxSpecie.TabIndex = 11;
            this.swTextboxSpecie.Tag = "DescSpecie";
            this.swTextboxSpecie.Validating += new System.ComponentModel.CancelEventHandler(this.swTextboxSpecie_Validating);
            // 
            // swTextboxCognom
            // 
            this.swTextboxCognom.AllowEmpty = false;
            this.swTextboxCognom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.swTextboxCognom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.swTextboxCognom.DadaPermesa = AVISC_Controles.ContentType.Text;
            this.swTextboxCognom.Font = new System.Drawing.Font("Inter SemiBold", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextboxCognom.ForeColor = System.Drawing.Color.White;
            this.swTextboxCognom.IsForeignKey = false;
            this.swTextboxCognom.LinkedControlName = null;
            this.swTextboxCognom.Location = new System.Drawing.Point(340, 84);
            this.swTextboxCognom.Multiline = true;
            this.swTextboxCognom.Name = "swTextboxCognom";
            this.swTextboxCognom.Size = new System.Drawing.Size(530, 60);
            this.swTextboxCognom.TabIndex = 10;
            this.swTextboxCognom.Tag = "CodeSpecie";
            this.swTextboxCognom.Validating += new System.ComponentModel.CancelEventHandler(this.swTextboxSpecie_Validating);
            // 
            // swTextboxNom
            // 
            this.swTextboxNom.AllowEmpty = false;
            this.swTextboxNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.swTextboxNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.swTextboxNom.DadaPermesa = AVISC_Controles.ContentType.Text;
            this.swTextboxNom.Font = new System.Drawing.Font("Inter SemiBold", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextboxNom.ForeColor = System.Drawing.Color.White;
            this.swTextboxNom.IsForeignKey = false;
            this.swTextboxNom.LinkedControlName = null;
            this.swTextboxNom.Location = new System.Drawing.Point(61, 84);
            this.swTextboxNom.Multiline = true;
            this.swTextboxNom.Name = "swTextboxNom";
            this.swTextboxNom.Size = new System.Drawing.Size(245, 60);
            this.swTextboxNom.TabIndex = 9;
            this.swTextboxNom.Tag = "CodeSpecie";
            this.swTextboxNom.Validating += new System.ComponentModel.CancelEventHandler(this.swTextboxSpecie_Validating);
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
            // actualizarPanel
            // 
            this.actualizarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.actualizarPanel.Controls.Add(this.saveImg);
            this.actualizarPanel.Location = new System.Drawing.Point(1564, 79);
            this.actualizarPanel.Name = "actualizarPanel";
            this.actualizarPanel.Size = new System.Drawing.Size(60, 60);
            this.actualizarPanel.TabIndex = 26;
            // 
            // nuevoPanel
            // 
            this.nuevoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.nuevoPanel.Controls.Add(this.pictureBox2);
            this.nuevoPanel.Location = new System.Drawing.Point(1240, 79);
            this.nuevoPanel.Name = "nuevoPanel";
            this.nuevoPanel.Size = new System.Drawing.Size(60, 60);
            this.nuevoPanel.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AVISC_Maintenance.Properties.Resources.new_img;
            this.pictureBox2.Location = new System.Drawing.Point(10, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Font = new System.Drawing.Font("Inter ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.nombreLbl.Location = new System.Drawing.Point(57, 47);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(78, 24);
            this.nombreLbl.TabIndex = 28;
            this.nombreLbl.Text = "Nombre";
            // 
            // apellidoLbl
            // 
            this.apellidoLbl.AutoSize = true;
            this.apellidoLbl.Font = new System.Drawing.Font("Inter ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.apellidoLbl.Location = new System.Drawing.Point(336, 47);
            this.apellidoLbl.Name = "apellidoLbl";
            this.apellidoLbl.Size = new System.Drawing.Size(81, 24);
            this.apellidoLbl.TabIndex = 29;
            this.apellidoLbl.Text = "Apellido";
            // 
            // descSpecieLbl
            // 
            this.descSpecieLbl.AutoSize = true;
            this.descSpecieLbl.Font = new System.Drawing.Font("Inter ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descSpecieLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.descSpecieLbl.Location = new System.Drawing.Point(901, 47);
            this.descSpecieLbl.Name = "descSpecieLbl";
            this.descSpecieLbl.Size = new System.Drawing.Size(76, 24);
            this.descSpecieLbl.TabIndex = 30;
            this.descSpecieLbl.Text = "Especie";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(61, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 10);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(281, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 10);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(340, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 10);
            this.panel3.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(905, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 10);
            this.panel4.TabIndex = 34;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.swTextboxSpecie);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.swTextboxCognom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.descSpecieLbl);
            this.Controls.Add(this.apellidoLbl);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.swTextboxNom);
            this.Controls.Add(this.actualizarDB);
            this.Controls.Add(this.nuevoDB);
            this.Controls.Add(this.dataBaseView);
            this.Controls.Add(this.actualizarPanel);
            this.Controls.Add(this.nuevoPanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.nuevoPanel, 0);
            this.Controls.SetChildIndex(this.actualizarPanel, 0);
            this.Controls.SetChildIndex(this.dataBaseView, 0);
            this.Controls.SetChildIndex(this.nuevoDB, 0);
            this.Controls.SetChildIndex(this.actualizarDB, 0);
            this.Controls.SetChildIndex(this.swTextboxNom, 0);
            this.Controls.SetChildIndex(this.nombreLbl, 0);
            this.Controls.SetChildIndex(this.apellidoLbl, 0);
            this.Controls.SetChildIndex(this.descSpecieLbl, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.swTextboxCognom, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.swTextboxSpecie, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveImg)).EndInit();
            this.actualizarPanel.ResumeLayout(false);
            this.nuevoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataBaseView;
        private System.Windows.Forms.Button nuevoDB;
        private System.Windows.Forms.Button actualizarDB;
        private AVISC_Controles.SWTextbox swTextboxNom;
        private AVISC_Controles.SWTextbox swTextboxCognom;
        private AVISC_Controles.SWTextbox swTextboxSpecie;
        private System.Windows.Forms.PictureBox saveImg;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel actualizarPanel;
        private System.Windows.Forms.Panel nuevoPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Label apellidoLbl;
        private System.Windows.Forms.Label descSpecieLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}