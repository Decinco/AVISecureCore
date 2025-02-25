
namespace Planets
{
    partial class MantPlanetes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CodePlanet = new AVISC_Controles.SWTextbox();
            this.DescPlant = new AVISC_Controles.SWTextbox();
            this.longTbx = new AVISC_Controles.SWTextbox();
            this.latTbx = new AVISC_Controles.SWTextbox();
            this.parsecs = new AVISC_Controles.SWTextbox();
            this.codePlanetlbl = new System.Windows.Forms.Label();
            this.planetLbl = new System.Windows.Forms.Label();
            this.longlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.parsecsLbl = new System.Windows.Forms.Label();
            this.filiationCbx = new System.Windows.Forms.ComboBox();
            this.sectorCbx = new System.Windows.Forms.ComboBox();
            this.filiationlbl = new System.Windows.Forms.Label();
            this.sectorlbl = new System.Windows.Forms.Label();
            this.nativeslbl = new System.Windows.Forms.Label();
            this.nativesCbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CodePlanet
            // 
            this.CodePlanet.AllowEmpty = false;
            this.CodePlanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.CodePlanet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodePlanet.DadaPermesa = AVISC_Controles.ContentType.Codi;
            this.CodePlanet.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.CodePlanet.ForeColor = System.Drawing.Color.White;
            this.CodePlanet.IsForeignKey = false;
            this.CodePlanet.LinkedControlName = null;
            this.CodePlanet.Location = new System.Drawing.Point(35, 119);
            this.CodePlanet.Multiline = true;
            this.CodePlanet.Name = "CodePlanet";
            this.CodePlanet.Size = new System.Drawing.Size(245, 60);
            this.CodePlanet.TabIndex = 30;
            this.CodePlanet.Tag = "CodePlanet";
            // 
            // DescPlant
            // 
            this.DescPlant.AllowEmpty = false;
            this.DescPlant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.DescPlant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescPlant.DadaPermesa = AVISC_Controles.ContentType.Nombre;
            this.DescPlant.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.DescPlant.ForeColor = System.Drawing.Color.White;
            this.DescPlant.IsForeignKey = false;
            this.DescPlant.LinkedControlName = null;
            this.DescPlant.Location = new System.Drawing.Point(305, 119);
            this.DescPlant.Multiline = true;
            this.DescPlant.Name = "DescPlant";
            this.DescPlant.Size = new System.Drawing.Size(245, 60);
            this.DescPlant.TabIndex = 31;
            this.DescPlant.Tag = "DescPlanet";
            // 
            // longTbx
            // 
            this.longTbx.AllowEmpty = false;
            this.longTbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.longTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.longTbx.DadaPermesa = AVISC_Controles.ContentType.Text;
            this.longTbx.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.longTbx.ForeColor = System.Drawing.Color.White;
            this.longTbx.IsForeignKey = false;
            this.longTbx.LinkedControlName = null;
            this.longTbx.Location = new System.Drawing.Point(583, 119);
            this.longTbx.Multiline = true;
            this.longTbx.Name = "longTbx";
            this.longTbx.Size = new System.Drawing.Size(100, 60);
            this.longTbx.TabIndex = 32;
            this.longTbx.Tag = "long";
            // 
            // latTbx
            // 
            this.latTbx.AllowEmpty = false;
            this.latTbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.latTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.latTbx.DadaPermesa = AVISC_Controles.ContentType.Text;
            this.latTbx.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.latTbx.ForeColor = System.Drawing.Color.White;
            this.latTbx.IsForeignKey = false;
            this.latTbx.LinkedControlName = null;
            this.latTbx.Location = new System.Drawing.Point(706, 117);
            this.latTbx.Multiline = true;
            this.latTbx.Name = "latTbx";
            this.latTbx.Size = new System.Drawing.Size(100, 60);
            this.latTbx.TabIndex = 33;
            this.latTbx.Tag = "lat";
            // 
            // parsecs
            // 
            this.parsecs.AllowEmpty = false;
            this.parsecs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.parsecs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parsecs.DadaPermesa = AVISC_Controles.ContentType.Text;
            this.parsecs.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.parsecs.ForeColor = System.Drawing.Color.White;
            this.parsecs.IsForeignKey = false;
            this.parsecs.LinkedControlName = null;
            this.parsecs.Location = new System.Drawing.Point(834, 117);
            this.parsecs.Multiline = true;
            this.parsecs.Name = "parsecs";
            this.parsecs.Size = new System.Drawing.Size(111, 60);
            this.parsecs.TabIndex = 34;
            this.parsecs.Tag = "parsecs";
            // 
            // codePlanetlbl
            // 
            this.codePlanetlbl.AutoSize = true;
            this.codePlanetlbl.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.codePlanetlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.codePlanetlbl.Location = new System.Drawing.Point(28, 73);
            this.codePlanetlbl.Name = "codePlanetlbl";
            this.codePlanetlbl.Size = new System.Drawing.Size(205, 41);
            this.codePlanetlbl.TabIndex = 35;
            this.codePlanetlbl.Text = "Code Planets";
            // 
            // planetLbl
            // 
            this.planetLbl.AutoSize = true;
            this.planetLbl.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.planetLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.planetLbl.Location = new System.Drawing.Point(298, 73);
            this.planetLbl.Name = "planetLbl";
            this.planetLbl.Size = new System.Drawing.Size(125, 41);
            this.planetLbl.TabIndex = 36;
            this.planetLbl.Text = "Planeta";
            // 
            // longlbl
            // 
            this.longlbl.AutoSize = true;
            this.longlbl.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.longlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.longlbl.Location = new System.Drawing.Point(576, 73);
            this.longlbl.Name = "longlbl";
            this.longlbl.Size = new System.Drawing.Size(99, 41);
            this.longlbl.TabIndex = 37;
            this.longlbl.Text = "Largo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(699, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 41);
            this.label3.TabIndex = 38;
            this.label3.Text = "Latitud";
            // 
            // parsecsLbl
            // 
            this.parsecsLbl.AutoSize = true;
            this.parsecsLbl.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.parsecsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.parsecsLbl.Location = new System.Drawing.Point(829, 73);
            this.parsecsLbl.Name = "parsecsLbl";
            this.parsecsLbl.Size = new System.Drawing.Size(116, 41);
            this.parsecsLbl.TabIndex = 39;
            this.parsecsLbl.Text = "Parsec";
            // 
            // filiationCbx
            // 
            this.filiationCbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.filiationCbx.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.filiationCbx.ForeColor = System.Drawing.Color.White;
            this.filiationCbx.FormattingEnabled = true;
            this.filiationCbx.Location = new System.Drawing.Point(980, 125);
            this.filiationCbx.Name = "filiationCbx";
            this.filiationCbx.Size = new System.Drawing.Size(202, 44);
            this.filiationCbx.TabIndex = 41;
            this.filiationCbx.Tag = "Filiations.DescFiliations";
            // 
            // sectorCbx
            // 
            this.sectorCbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.sectorCbx.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.sectorCbx.ForeColor = System.Drawing.Color.White;
            this.sectorCbx.FormattingEnabled = true;
            this.sectorCbx.Location = new System.Drawing.Point(1239, 70);
            this.sectorCbx.Name = "sectorCbx";
            this.sectorCbx.Size = new System.Drawing.Size(202, 44);
            this.sectorCbx.TabIndex = 42;
            this.sectorCbx.Tag = "Sectors.DescSector";
            // 
            // filiationlbl
            // 
            this.filiationlbl.AutoSize = true;
            this.filiationlbl.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.filiationlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.filiationlbl.Location = new System.Drawing.Point(973, 79);
            this.filiationlbl.Name = "filiationlbl";
            this.filiationlbl.Size = new System.Drawing.Size(154, 41);
            this.filiationlbl.TabIndex = 43;
            this.filiationlbl.Text = "Afiliacion";
            // 
            // sectorlbl
            // 
            this.sectorlbl.AutoSize = true;
            this.sectorlbl.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.sectorlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.sectorlbl.Location = new System.Drawing.Point(1232, 24);
            this.sectorlbl.Name = "sectorlbl";
            this.sectorlbl.Size = new System.Drawing.Size(112, 41);
            this.sectorlbl.TabIndex = 44;
            this.sectorlbl.Text = "Sector";
            // 
            // nativeslbl
            // 
            this.nativeslbl.AutoSize = true;
            this.nativeslbl.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nativeslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(102)))));
            this.nativeslbl.Location = new System.Drawing.Point(1232, 132);
            this.nativeslbl.Name = "nativeslbl";
            this.nativeslbl.Size = new System.Drawing.Size(126, 41);
            this.nativeslbl.TabIndex = 46;
            this.nativeslbl.Text = "Nativos";
            // 
            // nativesCbx
            // 
            this.nativesCbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.nativesCbx.Font = new System.Drawing.Font("Inter", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nativesCbx.ForeColor = System.Drawing.Color.White;
            this.nativesCbx.FormattingEnabled = true;
            this.nativesCbx.Location = new System.Drawing.Point(1239, 178);
            this.nativesCbx.Name = "nativesCbx";
            this.nativesCbx.Size = new System.Drawing.Size(202, 44);
            this.nativesCbx.TabIndex = 45;
            this.nativesCbx.Tag = "Species.DescSpecie";
            // 
            // MantPlanetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.nativeslbl);
            this.Controls.Add(this.nativesCbx);
            this.Controls.Add(this.sectorlbl);
            this.Controls.Add(this.filiationlbl);
            this.Controls.Add(this.sectorCbx);
            this.Controls.Add(this.filiationCbx);
            this.Controls.Add(this.parsecsLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.longlbl);
            this.Controls.Add(this.planetLbl);
            this.Controls.Add(this.codePlanetlbl);
            this.Controls.Add(this.parsecs);
            this.Controls.Add(this.latTbx);
            this.Controls.Add(this.longTbx);
            this.Controls.Add(this.DescPlant);
            this.Controls.Add(this.CodePlanet);
            this.Name = "MantPlanetes";
            this.Text = "Planets";
            this.Controls.SetChildIndex(this.CodePlanet, 0);
            this.Controls.SetChildIndex(this.DescPlant, 0);
            this.Controls.SetChildIndex(this.longTbx, 0);
            this.Controls.SetChildIndex(this.latTbx, 0);
            this.Controls.SetChildIndex(this.parsecs, 0);
            this.Controls.SetChildIndex(this.codePlanetlbl, 0);
            this.Controls.SetChildIndex(this.planetLbl, 0);
            this.Controls.SetChildIndex(this.longlbl, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.parsecsLbl, 0);
            this.Controls.SetChildIndex(this.filiationCbx, 0);
            this.Controls.SetChildIndex(this.sectorCbx, 0);
            this.Controls.SetChildIndex(this.filiationlbl, 0);
            this.Controls.SetChildIndex(this.sectorlbl, 0);
            this.Controls.SetChildIndex(this.nativesCbx, 0);
            this.Controls.SetChildIndex(this.nativeslbl, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AVISC_Controles.SWTextbox CodePlanet;
        private AVISC_Controles.SWTextbox DescPlant;
        private AVISC_Controles.SWTextbox longTbx;
        private AVISC_Controles.SWTextbox latTbx;
        private AVISC_Controles.SWTextbox parsecs;
        private System.Windows.Forms.Label codePlanetlbl;
        private System.Windows.Forms.Label planetLbl;
        private System.Windows.Forms.Label longlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label parsecsLbl;
        private System.Windows.Forms.ComboBox filiationCbx;
        private System.Windows.Forms.ComboBox sectorCbx;
        private System.Windows.Forms.Label filiationlbl;
        private System.Windows.Forms.Label sectorlbl;
        private System.Windows.Forms.Label nativeslbl;
        private System.Windows.Forms.ComboBox nativesCbx;
    }
}

