
namespace AVISC_CrystalReport
{
    partial class AVISC_Lists
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
            this.label1 = new System.Windows.Forms.Label();
            this.swTextbox1 = new AVISC_Controles.SWTextbox();
            this.swTextButton1 = new AVISC_Controles.SWTextButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ListEDI1 = new AVISC_CrystalReport.ListEDI();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(60, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 41);
            this.label1.TabIndex = 25;
            this.label1.Text = "Comanda:";
            // 
            // swTextbox1
            // 
            this.swTextbox1.AllowEmpty = false;
            this.swTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.swTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.swTextbox1.DadaPermesa = AVISC_Controles.ContentType.Nombre;
            this.swTextbox1.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.swTextbox1.ForeColor = System.Drawing.Color.White;
            this.swTextbox1.IsForeignKey = false;
            this.swTextbox1.LinkedControlName = null;
            this.swTextbox1.Location = new System.Drawing.Point(230, 38);
            this.swTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.swTextbox1.Multiline = true;
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(433, 44);
            this.swTextbox1.TabIndex = 33;
            this.swTextbox1.Tag = "CodeUser";
            // 
            // swTextButton1
            // 
            this.swTextButton1.ButtonEnabled = true;
            this.swTextButton1.ButtonText = "Encontrar Comanda";
            this.swTextButton1.Location = new System.Drawing.Point(696, 38);
            this.swTextButton1.Name = "swTextButton1";
            this.swTextButton1.Size = new System.Drawing.Size(224, 44);
            this.swTextButton1.TabIndex = 34;
            this.swTextButton1.ButtonClick += new System.EventHandler(this.swTextButton1_ButtonClick);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.ListEDI1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1561, 777);
            this.crystalReportViewer1.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(67, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1561, 777);
            this.panel1.TabIndex = 36;
            // 
            // AVISC_Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.swTextButton1);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.label1);
            this.Name = "AVISC_Lists";
            this.Text = "AVISC_Lists";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextButton1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private AVISC_Controles.SWTextbox swTextbox1;
        private AVISC_Controles.SWTextButton swTextButton1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private ListEDI ListEDI1;
        private System.Windows.Forms.Panel panel1;
    }
}