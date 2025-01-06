
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
            this.saveImg = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.actualizarPanel = new System.Windows.Forms.Panel();
            this.nuevoPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveImg)).BeginInit();
            this.actualizarPanel.SuspendLayout();
            this.nuevoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.nuevoDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.actualizarDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizarDB.ForeColor = System.Drawing.Color.White;
            this.actualizarDB.Location = new System.Drawing.Point(1622, 79);
            this.actualizarDB.Name = "actualizarDB";
            this.actualizarDB.Size = new System.Drawing.Size(180, 60);
            this.actualizarDB.TabIndex = 5;
            this.actualizarDB.Text = "Guardar\r\nCambios";
            this.actualizarDB.UseVisualStyleBackColor = false;
            this.actualizarDB.Click += new System.EventHandler(this.actualizarDB_Click);
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
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.actualizarDB);
            this.Controls.Add(this.nuevoDB);
            this.Controls.Add(this.dataBaseView);
            this.Controls.Add(this.actualizarPanel);
            this.Controls.Add(this.nuevoPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.Controls.SetChildIndex(this.nuevoPanel, 0);
            this.Controls.SetChildIndex(this.actualizarPanel, 0);
            this.Controls.SetChildIndex(this.dataBaseView, 0);
            this.Controls.SetChildIndex(this.nuevoDB, 0);
            this.Controls.SetChildIndex(this.actualizarDB, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveImg)).EndInit();
            this.actualizarPanel.ResumeLayout(false);
            this.nuevoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataBaseView;
        private System.Windows.Forms.Button nuevoDB;
        private System.Windows.Forms.Button actualizarDB;
        private System.Windows.Forms.PictureBox saveImg;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel actualizarPanel;
        private System.Windows.Forms.Panel nuevoPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}