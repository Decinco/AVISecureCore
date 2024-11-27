
namespace AVISecureCore
{
    partial class TestForm
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
            this.swLauchForm1 = new Controles.SWLauchForm();
            this.SuspendLayout();
            // 
            // swLauchForm1
            // 
            this.swLauchForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.swLauchForm1.classe = null;
            this.swLauchForm1.form = null;
            this.swLauchForm1.Location = new System.Drawing.Point(63, 34);
            this.swLauchForm1.Name = "swLauchForm1";
            this.swLauchForm1.Size = new System.Drawing.Size(514, 316);
            this.swLauchForm1.TabIndex = 0;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.swLauchForm1);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.SWLauchForm swLauchForm1;
    }
}