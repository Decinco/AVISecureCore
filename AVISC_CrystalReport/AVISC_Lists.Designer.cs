
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
            this.swTextButton1 = new AVISC_Controles.SWTextButton();
            this.panel_user = new System.Windows.Forms.Panel();
            this.txt_comand = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ListEDI1 = new AVISC_CrystalReport.ListEDI();
            this.panel_user.SuspendLayout();
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
            // swTextButton1
            // 
            this.swTextButton1.ButtonEnabled = true;
            this.swTextButton1.ButtonText = "Show command";
            this.swTextButton1.Location = new System.Drawing.Point(733, 38);
            this.swTextButton1.Name = "swTextButton1";
            this.swTextButton1.Size = new System.Drawing.Size(223, 48);
            this.swTextButton1.TabIndex = 38;
            this.swTextButton1.ButtonClick += new System.EventHandler(this.swTextButton1_ButtonClick_1);
            // 
            // panel_user
            // 
            this.panel_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel_user.Controls.Add(this.txt_comand);
            this.panel_user.Location = new System.Drawing.Point(218, 38);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(488, 48);
            this.panel_user.TabIndex = 37;
            // 
            // txt_comand
            // 
            this.txt_comand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_comand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_comand.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txt_comand.ForeColor = System.Drawing.Color.White;
            this.txt_comand.Location = new System.Drawing.Point(16, 7);
            this.txt_comand.Multiline = true;
            this.txt_comand.Name = "txt_comand";
            this.txt_comand.Size = new System.Drawing.Size(456, 34);
            this.txt_comand.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(67, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 731);
            this.panel1.TabIndex = 39;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.ListEDI1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1286, 731);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // AVISC_Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_user);
            this.Controls.Add(this.swTextButton1);
            this.Controls.Add(this.label1);
            this.Name = "AVISC_Lists";
            this.Text = "AVISC_Lists";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.swTextButton1, 0);
            this.Controls.SetChildIndex(this.panel_user, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel_user.ResumeLayout(false);
            this.panel_user.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private AVISC_Controles.SWTextButton swTextButton1;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.TextBox txt_comand;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private ListEDI ListEDI1;
    }
}