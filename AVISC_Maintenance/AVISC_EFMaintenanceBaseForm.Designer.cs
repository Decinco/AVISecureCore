
using AVISC_BaseForms;
using System.Data.Entity;
using System.Windows.Forms;

namespace AVISC_Maintenance
{
    public partial class AVISC_EFMaintenanceBaseForm<EntityT, ContextT> : AVISC_CloseableFeatureForm
        where EntityT : class, new()
        where ContextT : DbContext, new()
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
            this.saveImg = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnl_saveButtonIcon = new System.Windows.Forms.Panel();
            this.pnl_SaveButton = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbx_New = new System.Windows.Forms.PictureBox();
            this.pnl_NewButton = new System.Windows.Forms.Panel();
            this.lbl_New = new System.Windows.Forms.Label();
            this.pnl_newIconButton = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveImg)).BeginInit();
            this.pnl_saveButtonIcon.SuspendLayout();
            this.pnl_SaveButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_New)).BeginInit();
            this.pnl_NewButton.SuspendLayout();
            this.pnl_newIconButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataBaseView
            // 
            this.dataBaseView.AllowUserToAddRows = false;
            this.dataBaseView.AllowUserToResizeColumns = false;
            this.dataBaseView.AllowUserToResizeRows = false;
            this.dataBaseView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBaseView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dataBaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBaseView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataBaseView.Location = new System.Drawing.Point(33, 254);
            this.dataBaseView.Name = "dataBaseView";
            this.dataBaseView.RowHeadersWidth = 51;
            this.dataBaseView.Size = new System.Drawing.Size(1765, 703);
            this.dataBaseView.TabIndex = 1;
            this.dataBaseView.Visible = false;
            this.dataBaseView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.RefreshLinkedColumns);
            // 
            // saveImg
            // 
            this.saveImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveImg.Image = global::AVISC_Maintenance.Properties.Resources.save_img;
            this.saveImg.Location = new System.Drawing.Point(10, 10);
            this.saveImg.Name = "saveImg";
            this.saveImg.Size = new System.Drawing.Size(40, 40);
            this.saveImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saveImg.TabIndex = 25;
            this.saveImg.TabStop = false;
            this.saveImg.Click += new System.EventHandler(this.SaveChanges);
            this.saveImg.MouseEnter += new System.EventHandler(this.pnl_SaveButton_MouseEnter);
            this.saveImg.MouseLeave += new System.EventHandler(this.pnl_SaveButton_MouseLeave);
            // 
            // pnl_saveButtonIcon
            // 
            this.pnl_saveButtonIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.pnl_saveButtonIcon.Controls.Add(this.saveImg);
            this.pnl_saveButtonIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_saveButtonIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_saveButtonIcon.Location = new System.Drawing.Point(0, 0);
            this.pnl_saveButtonIcon.Name = "pnl_saveButtonIcon";
            this.pnl_saveButtonIcon.Size = new System.Drawing.Size(60, 60);
            this.pnl_saveButtonIcon.TabIndex = 26;
            this.pnl_saveButtonIcon.Click += new System.EventHandler(this.SaveChanges);
            this.pnl_saveButtonIcon.MouseEnter += new System.EventHandler(this.pnl_SaveButton_MouseEnter);
            this.pnl_saveButtonIcon.MouseLeave += new System.EventHandler(this.pnl_SaveButton_MouseLeave);
            // 
            // pnl_SaveButton
            // 
            this.pnl_SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnl_SaveButton.Controls.Add(this.label1);
            this.pnl_SaveButton.Controls.Add(this.pnl_saveButtonIcon);
            this.pnl_SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_SaveButton.Location = new System.Drawing.Point(1498, 90);
            this.pnl_SaveButton.Name = "pnl_SaveButton";
            this.pnl_SaveButton.Size = new System.Drawing.Size(300, 60);
            this.pnl_SaveButton.TabIndex = 28;
            this.pnl_SaveButton.Click += new System.EventHandler(this.SaveChanges);
            this.pnl_SaveButton.MouseEnter += new System.EventHandler(this.pnl_SaveButton_MouseEnter);
            this.pnl_SaveButton.MouseLeave += new System.EventHandler(this.pnl_SaveButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Inter", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 60);
            this.label1.TabIndex = 27;
            this.label1.Text = "Guardar \r\nCambios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.SaveChanges);
            this.label1.MouseEnter += new System.EventHandler(this.pnl_SaveButton_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.pnl_SaveButton_MouseLeave);
            // 
            // pbx_New
            // 
            this.pbx_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_New.Image = global::AVISC_Maintenance.Properties.Resources.new_img;
            this.pbx_New.Location = new System.Drawing.Point(10, 10);
            this.pbx_New.Name = "pbx_New";
            this.pbx_New.Size = new System.Drawing.Size(40, 40);
            this.pbx_New.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_New.TabIndex = 25;
            this.pbx_New.TabStop = false;
            this.pbx_New.Click += new System.EventHandler(this.NewEntry);
            this.pbx_New.MouseEnter += new System.EventHandler(this.pnl_NewButton_MouseEnter);
            this.pbx_New.MouseLeave += new System.EventHandler(this.pnl_NewButton_MouseLeave);
            // 
            // pnl_NewButton
            // 
            this.pnl_NewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnl_NewButton.Controls.Add(this.lbl_New);
            this.pnl_NewButton.Controls.Add(this.pnl_newIconButton);
            this.pnl_NewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_NewButton.Location = new System.Drawing.Point(1498, 172);
            this.pnl_NewButton.Name = "pnl_NewButton";
            this.pnl_NewButton.Size = new System.Drawing.Size(300, 60);
            this.pnl_NewButton.TabIndex = 29;
            this.pnl_NewButton.Click += new System.EventHandler(this.NewEntry);
            this.pnl_NewButton.MouseEnter += new System.EventHandler(this.pnl_NewButton_MouseEnter);
            this.pnl_NewButton.MouseLeave += new System.EventHandler(this.pnl_NewButton_MouseLeave);
            // 
            // lbl_New
            // 
            this.lbl_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_New.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_New.Font = new System.Drawing.Font("Inter", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_New.ForeColor = System.Drawing.Color.White;
            this.lbl_New.Location = new System.Drawing.Point(60, 0);
            this.lbl_New.Name = "lbl_New";
            this.lbl_New.Size = new System.Drawing.Size(240, 60);
            this.lbl_New.TabIndex = 27;
            this.lbl_New.Text = "Nuevo";
            this.lbl_New.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_New.Click += new System.EventHandler(this.NewEntry);
            this.lbl_New.MouseEnter += new System.EventHandler(this.pnl_NewButton_MouseEnter);
            this.lbl_New.MouseLeave += new System.EventHandler(this.pnl_NewButton_MouseLeave);
            // 
            // pnl_newIconButton
            // 
            this.pnl_newIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.pnl_newIconButton.Controls.Add(this.pbx_New);
            this.pnl_newIconButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_newIconButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_newIconButton.Location = new System.Drawing.Point(0, 0);
            this.pnl_newIconButton.Name = "pnl_newIconButton";
            this.pnl_newIconButton.Size = new System.Drawing.Size(60, 60);
            this.pnl_newIconButton.TabIndex = 26;
            this.pnl_newIconButton.Click += new System.EventHandler(this.NewEntry);
            this.pnl_newIconButton.MouseEnter += new System.EventHandler(this.pnl_NewButton_MouseEnter);
            this.pnl_newIconButton.MouseLeave += new System.EventHandler(this.pnl_NewButton_MouseLeave);
            // 
            // AVISC_EFMaintenanceBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1840, 1000);
            this.Controls.Add(this.pnl_NewButton);
            this.Controls.Add(this.pnl_SaveButton);
            this.Controls.Add(this.dataBaseView);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AVISC_EFMaintenanceBaseForm";
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.OnLoad);
            this.Controls.SetChildIndex(this.dataBaseView, 0);
            this.Controls.SetChildIndex(this.pnl_SaveButton, 0);
            this.Controls.SetChildIndex(this.pnl_NewButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveImg)).EndInit();
            this.pnl_saveButtonIcon.ResumeLayout(false);
            this.pnl_SaveButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_New)).EndInit();
            this.pnl_NewButton.ResumeLayout(false);
            this.pnl_newIconButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox saveImg;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnl_saveButtonIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbx_New;
        private System.Windows.Forms.Panel pnl_newIconButton;

        /// <summary>
        ///     <para>
        ///         DataGrid utilizado para mostrar los datos de la tabla.
        ///     </para>
        ///     <para>
        ///         Sus columnas se generan automáticamente a partir de las propiedades de <typeparamref name="EntityT"/> a las que se les haya asignado un <see cref="TextBox"/> o <see cref="ComboBox"/>.
        ///     </para>
        ///     <para>
        ///         Las columnas se nombrarán de formas diferentes según si las columnas fueron generadas con un <see cref="TextBox"/> o con un <see cref="ComboBox"/>:
        ///     </para>
        ///     <list type="table">
        ///         <item>
        ///             <term>TextBox</term>
        ///             <description>"El nombre de la columna es [nombre_columna].</description>
        ///         </item>
        ///         <item>
        ///             <term>ComboBox</term>
        ///             <description>Hay dos columnas una de valor y otra de muestra. La de valor tiene el nombre [nombre_columna_id] y la de muestra el nombre "[nombre_columna_id]Display"</description>
        ///         </item>
        ///     </list>
        /// </summary>
        protected System.Windows.Forms.DataGridView dataBaseView;
        private System.Windows.Forms.Panel pnl_SaveButton;
        private System.Windows.Forms.Panel pnl_NewButton;
        private System.Windows.Forms.Label lbl_New;
    }
}