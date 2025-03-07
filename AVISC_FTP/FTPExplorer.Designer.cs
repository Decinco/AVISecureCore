
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
            this.lblDescAS = new System.Windows.Forms.Label();
            this.lblArchivoSeleccionado = new System.Windows.Forms.Label();
            this.btnDownload = new AVISC_Controles.SWTextButton();
            this.swTextButton2 = new AVISC_Controles.SWTextButton();
            this.btnSubirArchivo = new AVISC_Controles.SWTextButton();
            this.btnConfigFTP = new AVISC_Controles.SWTextButton();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Inter", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lblEstado.Location = new System.Drawing.Point(234, 307);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 32);
            this.lblEstado.TabIndex = 26;
            // 
            // lblDescAS
            // 
            this.lblDescAS.AutoSize = true;
            this.lblDescAS.Font = new System.Drawing.Font("Inter", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblDescAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lblDescAS.Location = new System.Drawing.Point(234, 255);
            this.lblDescAS.Name = "lblDescAS";
            this.lblDescAS.Size = new System.Drawing.Size(261, 32);
            this.lblDescAS.TabIndex = 32;
            this.lblDescAS.Text = "Archivo Seleccionado:";
            // 
            // lblArchivoSeleccionado
            // 
            this.lblArchivoSeleccionado.AutoSize = true;
            this.lblArchivoSeleccionado.Font = new System.Drawing.Font("Inter", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblArchivoSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.lblArchivoSeleccionado.Location = new System.Drawing.Point(501, 255);
            this.lblArchivoSeleccionado.Name = "lblArchivoSeleccionado";
            this.lblArchivoSeleccionado.Size = new System.Drawing.Size(0, 32);
            this.lblArchivoSeleccionado.TabIndex = 33;
            // 
            // btnDownload
            // 
            this.btnDownload.ButtonEnabled = true;
            this.btnDownload.ButtonText = "Descargar";
            this.btnDownload.Location = new System.Drawing.Point(441, 145);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(163, 64);
            this.btnDownload.TabIndex = 35;
            this.btnDownload.ButtonClick += new System.EventHandler(this.btnDownload_ButtonClick);
            // 
            // swTextButton2
            // 
            this.swTextButton2.ButtonEnabled = true;
            this.swTextButton2.ButtonText = "Seleccionar Archivo";
            this.swTextButton2.Location = new System.Drawing.Point(240, 145);
            this.swTextButton2.Name = "swTextButton2";
            this.swTextButton2.Size = new System.Drawing.Size(163, 64);
            this.swTextButton2.TabIndex = 36;
            this.swTextButton2.ButtonClick += new System.EventHandler(this.btnGetFile);
            // 
            // btnSubirArchivo
            // 
            this.btnSubirArchivo.ButtonEnabled = true;
            this.btnSubirArchivo.ButtonText = "Subir Archivo";
            this.btnSubirArchivo.Location = new System.Drawing.Point(646, 145);
            this.btnSubirArchivo.Name = "btnSubirArchivo";
            this.btnSubirArchivo.Size = new System.Drawing.Size(163, 64);
            this.btnSubirArchivo.TabIndex = 37;
            this.btnSubirArchivo.ButtonClick += new System.EventHandler(this.btnSubirArchivo_ButtonClick);
            // 
            // btnConfigFTP
            // 
            this.btnConfigFTP.ButtonEnabled = true;
            this.btnConfigFTP.ButtonText = "Configurar FTP";
            this.btnConfigFTP.Location = new System.Drawing.Point(870, 145);
            this.btnConfigFTP.Name = "btnConfigFTP";
            this.btnConfigFTP.Size = new System.Drawing.Size(199, 64);
            this.btnConfigFTP.TabIndex = 38;
            this.btnConfigFTP.ButtonClick += new System.EventHandler(this.btnConfigFTP_ButtonClick);
            // 
            // FTPExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.btnConfigFTP);
            this.Controls.Add(this.btnSubirArchivo);
            this.Controls.Add(this.swTextButton2);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblArchivoSeleccionado);
            this.Controls.Add(this.lblDescAS);
            this.Controls.Add(this.lblEstado);
            this.Name = "FTPExplorer";
            this.Text = "FTPExplorer";
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.lblDescAS, 0);
            this.Controls.SetChildIndex(this.lblArchivoSeleccionado, 0);
            this.Controls.SetChildIndex(this.btnDownload, 0);
            this.Controls.SetChildIndex(this.swTextButton2, 0);
            this.Controls.SetChildIndex(this.btnSubirArchivo, 0);
            this.Controls.SetChildIndex(this.btnConfigFTP, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDescAS;
        private System.Windows.Forms.Label lblArchivoSeleccionado;
        private AVISC_Controles.SWTextButton btnDownload;
        private AVISC_Controles.SWTextButton swTextButton2;
        private AVISC_Controles.SWTextButton btnSubirArchivo;
        private AVISC_Controles.SWTextButton btnConfigFTP;
    }
}