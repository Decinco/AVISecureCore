
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
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.actualizarDB);
            this.Controls.Add(this.nuevoDB);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.nuevoDB, 0);
            this.Controls.SetChildIndex(this.actualizarDB, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button nuevoDB;
        private System.Windows.Forms.Button actualizarDB;
    }
}