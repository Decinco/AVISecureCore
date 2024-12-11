
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
            this.swTextbox1 = new AVISC_Controles.SWTextbox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.swTextbox2 = new AVISC_Controles.SWTextbox();
            this.swTextbox3 = new AVISC_Controles.SWTextbox();
            this.nuevoDB = new System.Windows.Forms.Button();
            this.actualizarDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // swTextbox1
            // 
            this.swTextbox1.AllowEmpty = false;
            this.swTextbox1.DadaPermesa = AVISC_Controles.SWTextbox.ContentType.Nombre;
            this.swTextbox1.IsForeignKey = false;
            this.swTextbox1.LinkedControlName = null;
            this.swTextbox1.Location = new System.Drawing.Point(39, 95);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(201, 22);
            this.swTextbox1.TabIndex = 0;
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
            // swTextbox2
            // 
            this.swTextbox2.AllowEmpty = false;
            this.swTextbox2.DadaPermesa = AVISC_Controles.SWTextbox.ContentType.Nombre;
            this.swTextbox2.IsForeignKey = false;
            this.swTextbox2.LinkedControlName = null;
            this.swTextbox2.Location = new System.Drawing.Point(289, 95);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.Size = new System.Drawing.Size(406, 22);
            this.swTextbox2.TabIndex = 2;
            // 
            // swTextbox3
            // 
            this.swTextbox3.AllowEmpty = false;
            this.swTextbox3.DadaPermesa = AVISC_Controles.SWTextbox.ContentType.Nombre;
            this.swTextbox3.IsForeignKey = false;
            this.swTextbox3.LinkedControlName = null;
            this.swTextbox3.Location = new System.Drawing.Point(776, 95);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.Size = new System.Drawing.Size(210, 22);
            this.swTextbox3.TabIndex = 3;
            // 
            // nuevoDB
            // 
            this.nuevoDB.Location = new System.Drawing.Point(1252, 73);
            this.nuevoDB.Name = "nuevoDB";
            this.nuevoDB.Size = new System.Drawing.Size(226, 44);
            this.nuevoDB.TabIndex = 4;
            this.nuevoDB.Text = "Nuevo";
            this.nuevoDB.UseVisualStyleBackColor = true;
            // 
            // actualizarDB
            // 
            this.actualizarDB.Location = new System.Drawing.Point(1562, 74);
            this.actualizarDB.Name = "actualizarDB";
            this.actualizarDB.Size = new System.Drawing.Size(226, 43);
            this.actualizarDB.TabIndex = 5;
            this.actualizarDB.Text = "Actualizar";
            this.actualizarDB.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 953);
            this.Controls.Add(this.actualizarDB);
            this.Controls.Add(this.nuevoDB);
            this.Controls.Add(this.swTextbox3);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.swTextbox1);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AVISC_Controles.SWTextbox swTextbox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AVISC_Controles.SWTextbox swTextbox2;
        private AVISC_Controles.SWTextbox swTextbox3;
        private System.Windows.Forms.Button nuevoDB;
        private System.Windows.Forms.Button actualizarDB;
    }
}