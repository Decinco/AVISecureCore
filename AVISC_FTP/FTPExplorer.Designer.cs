
namespace AVISC_FTP
{
    partial class FTPExplorer
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.lblDescAS = new System.Windows.Forms.Label();
            this.lblArchivoSeleccionado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(231, 100);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 17);
            this.lblEstado.TabIndex = 26;
            // 
            // btnDownload
            // 
            this.btnDownload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDownload.Location = new System.Drawing.Point(234, 40);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(97, 41);
            this.btnDownload.TabIndex = 27;
            this.btnDownload.Text = "Descargar";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetFile
            // 
            this.btnGetFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetFile.Location = new System.Drawing.Point(234, 199);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(114, 23);
            this.btnGetFile.TabIndex = 31;
            this.btnGetFile.Text = "Select File";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // lblDescAS
            // 
            this.lblDescAS.AutoSize = true;
            this.lblDescAS.Location = new System.Drawing.Point(234, 255);
            this.lblDescAS.Name = "lblDescAS";
            this.lblDescAS.Size = new System.Drawing.Size(148, 17);
            this.lblDescAS.TabIndex = 32;
            this.lblDescAS.Text = "Archivo Seleccionado:";
            // 
            // lblArchivoSeleccionado
            // 
            this.lblArchivoSeleccionado.AutoSize = true;
            this.lblArchivoSeleccionado.Location = new System.Drawing.Point(389, 255);
            this.lblArchivoSeleccionado.Name = "lblArchivoSeleccionado";
            this.lblArchivoSeleccionado.Size = new System.Drawing.Size(46, 17);
            this.lblArchivoSeleccionado.TabIndex = 33;
            this.lblArchivoSeleccionado.Text = "label2";
            // 
            // FTPExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.lblArchivoSeleccionado);
            this.Controls.Add(this.lblDescAS);
            this.Controls.Add(this.btnGetFile);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblEstado);
            this.Name = "FTPExplorer";
            this.Text = "FTPExplorer";
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.btnDownload, 0);
            this.Controls.SetChildIndex(this.btnGetFile, 0);
            this.Controls.SetChildIndex(this.lblDescAS, 0);
            this.Controls.SetChildIndex(this.lblArchivoSeleccionado, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.Label lblDescAS;
        private System.Windows.Forms.Label lblArchivoSeleccionado;
    }
}