
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.swTextbox1 = new AVISC_Controles.SWTextbox();
            this.swTextboxSpecie = new AVISC_Controles.SWTextbox();
            this.swTextboxNom = new AVISC_Controles.SWTextbox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.nuevoDB.Location = new System.Drawing.Point(1252, 73);
            this.nuevoDB.Name = "nuevoDB";
            this.nuevoDB.Size = new System.Drawing.Size(226, 44);
            this.nuevoDB.TabIndex = 4;
            this.nuevoDB.Text = "Nuevo";
            this.nuevoDB.UseVisualStyleBackColor = true;
            this.nuevoDB.Click += new System.EventHandler(this.nuevoDB_Click_1);
            // 
            // actualizarDB
            // 
            this.actualizarDB.Location = new System.Drawing.Point(1562, 74);
            this.actualizarDB.Name = "actualizarDB";
            this.actualizarDB.Size = new System.Drawing.Size(226, 43);
            this.actualizarDB.TabIndex = 5;
            this.actualizarDB.Text = "Actualizar";
            this.actualizarDB.UseVisualStyleBackColor = true;
            this.actualizarDB.Click += new System.EventHandler(this.actualizarDB_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(555, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.Tag = "UserCategories.DescUserCategory";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(555, 122);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.Tag = "UserRanks.DescUserRank";
            // 
            // swTextbox1
            // 
            this.swTextbox1.AllowEmpty = false;
            this.swTextbox1.DadaPermesa = AVISC_Controles.ContentType.Text;
            this.swTextbox1.IsForeignKey = false;
            this.swTextbox1.LinkedControlName = null;
            this.swTextbox1.Location = new System.Drawing.Point(61, 123);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(208, 20);
            this.swTextbox1.TabIndex = 26;
            this.swTextbox1.Tag = "Login";
            // 
            // swTextboxSpecie
            // 
            this.swTextboxSpecie.AllowEmpty = false;
            this.swTextboxSpecie.DadaPermesa = AVISC_Controles.ContentType.Text;
            this.swTextboxSpecie.IsForeignKey = false;
            this.swTextboxSpecie.LinkedControlName = null;
            this.swTextboxSpecie.Location = new System.Drawing.Point(284, 84);
            this.swTextboxSpecie.Name = "swTextboxSpecie";
            this.swTextboxSpecie.Size = new System.Drawing.Size(265, 20);
            this.swTextboxSpecie.TabIndex = 11;
            this.swTextboxSpecie.Tag = "Password";
            // 
            // swTextboxNom
            // 
            this.swTextboxNom.AllowEmpty = false;
            this.swTextboxNom.DadaPermesa = AVISC_Controles.ContentType.Text;
            this.swTextboxNom.IsForeignKey = false;
            this.swTextboxNom.LinkedControlName = null;
            this.swTextboxNom.Location = new System.Drawing.Point(61, 84);
            this.swTextboxNom.Name = "swTextboxNom";
            this.swTextboxNom.Size = new System.Drawing.Size(208, 20);
            this.swTextboxNom.TabIndex = 9;
            this.swTextboxNom.Tag = "UserName";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(682, 83);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 28;
            this.comboBox3.Tag = "Species.DescSpecie";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(682, 123);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 29;
            this.comboBox4.Tag = "Planets.DescPlanet";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.swTextboxSpecie);
            this.Controls.Add(this.swTextboxNom);
            this.Controls.Add(this.actualizarDB);
            this.Controls.Add(this.nuevoDB);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.nuevoDB, 0);
            this.Controls.SetChildIndex(this.actualizarDB, 0);
            this.Controls.SetChildIndex(this.swTextboxNom, 0);
            this.Controls.SetChildIndex(this.swTextboxSpecie, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            this.Controls.SetChildIndex(this.comboBox3, 0);
            this.Controls.SetChildIndex(this.comboBox4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button nuevoDB;
        private System.Windows.Forms.Button actualizarDB;
        private AVISC_Controles.SWTextbox swTextboxNom;
        private AVISC_Controles.SWTextbox swTextboxSpecie;
        private System.Windows.Forms.ComboBox comboBox1;
        private AVISC_Controles.SWTextbox swTextbox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}