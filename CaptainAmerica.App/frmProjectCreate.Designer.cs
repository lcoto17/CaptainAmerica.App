namespace CaptainAmerica.App
{
    partial class frmProjectCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectCreate));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboxProjectClient = new System.Windows.Forms.ComboBox();
            this.lblProjectClientTittle = new System.Windows.Forms.Label();
            this.cboxProjectCategory = new System.Windows.Forms.ComboBox();
            this.lblProjectCategoryTittle = new System.Windows.Forms.Label();
            this.dtpProjectDate = new System.Windows.Forms.DateTimePicker();
            this.lblProjectDateTittle = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lblProjectNameTittle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.btnCancel);
            this.pnlContainer.Controls.Add(this.btnSave);
            this.pnlContainer.Controls.Add(this.cboxProjectClient);
            this.pnlContainer.Controls.Add(this.lblProjectClientTittle);
            this.pnlContainer.Controls.Add(this.cboxProjectCategory);
            this.pnlContainer.Controls.Add(this.lblProjectCategoryTittle);
            this.pnlContainer.Controls.Add(this.dtpProjectDate);
            this.pnlContainer.Controls.Add(this.lblProjectDateTittle);
            this.pnlContainer.Controls.Add(this.txtProjectName);
            this.pnlContainer.Controls.Add(this.lblProjectNameTittle);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 60);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.pnlContainer.Size = new System.Drawing.Size(585, 391);
            this.pnlContainer.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(444, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 31);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(172)))), ((int)(((byte)(68)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(334, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboxProjectClient
            // 
            this.cboxProjectClient.FormattingEnabled = true;
            this.cboxProjectClient.Location = new System.Drawing.Point(39, 234);
            this.cboxProjectClient.Name = "cboxProjectClient";
            this.cboxProjectClient.Size = new System.Drawing.Size(509, 31);
            this.cboxProjectClient.TabIndex = 4;
            // 
            // lblProjectClientTittle
            // 
            this.lblProjectClientTittle.AutoSize = true;
            this.lblProjectClientTittle.Location = new System.Drawing.Point(35, 209);
            this.lblProjectClientTittle.Name = "lblProjectClientTittle";
            this.lblProjectClientTittle.Size = new System.Drawing.Size(163, 23);
            this.lblProjectClientTittle.TabIndex = 6;
            this.lblProjectClientTittle.Text = "Cliente del proyecto";
            // 
            // cboxProjectCategory
            // 
            this.cboxProjectCategory.FormattingEnabled = true;
            this.cboxProjectCategory.Location = new System.Drawing.Point(267, 141);
            this.cboxProjectCategory.Name = "cboxProjectCategory";
            this.cboxProjectCategory.Size = new System.Drawing.Size(281, 31);
            this.cboxProjectCategory.TabIndex = 3;
            // 
            // lblProjectCategoryTittle
            // 
            this.lblProjectCategoryTittle.AutoSize = true;
            this.lblProjectCategoryTittle.Location = new System.Drawing.Point(263, 116);
            this.lblProjectCategoryTittle.Name = "lblProjectCategoryTittle";
            this.lblProjectCategoryTittle.Size = new System.Drawing.Size(180, 23);
            this.lblProjectCategoryTittle.TabIndex = 4;
            this.lblProjectCategoryTittle.Text = "Categoría de proyecto";
            // 
            // dtpProjectDate
            // 
            this.dtpProjectDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProjectDate.Location = new System.Drawing.Point(39, 142);
            this.dtpProjectDate.Name = "dtpProjectDate";
            this.dtpProjectDate.Size = new System.Drawing.Size(197, 30);
            this.dtpProjectDate.TabIndex = 2;
            // 
            // lblProjectDateTittle
            // 
            this.lblProjectDateTittle.AutoSize = true;
            this.lblProjectDateTittle.Location = new System.Drawing.Point(35, 116);
            this.lblProjectDateTittle.Name = "lblProjectDateTittle";
            this.lblProjectDateTittle.Size = new System.Drawing.Size(124, 23);
            this.lblProjectDateTittle.TabIndex = 2;
            this.lblProjectDateTittle.Text = "Fecha apertura";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(39, 58);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(509, 30);
            this.txtProjectName.TabIndex = 1;
            // 
            // lblProjectNameTittle
            // 
            this.lblProjectNameTittle.AutoSize = true;
            this.lblProjectNameTittle.Location = new System.Drawing.Point(35, 31);
            this.lblProjectNameTittle.Name = "lblProjectNameTittle";
            this.lblProjectNameTittle.Size = new System.Drawing.Size(173, 23);
            this.lblProjectNameTittle.TabIndex = 0;
            this.lblProjectNameTittle.Text = "Nombre del proyecto";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::CaptainAmerica.App.Properties.Resources.if_cross_1894663;
            this.btnClose.Location = new System.Drawing.Point(553, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 34);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(585, 60);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear nuevo proyecto";
            // 
            // frmProjectCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(585, 451);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProjectCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmProjectCreate";
            this.Load += new System.EventHandler(this.frmProjectCreate_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DateTimePicker dtpProjectDate;
        private System.Windows.Forms.Label lblProjectDateTittle;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label lblProjectNameTittle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxProjectCategory;
        private System.Windows.Forms.Label lblProjectCategoryTittle;
        private System.Windows.Forms.ComboBox cboxProjectClient;
        private System.Windows.Forms.Label lblProjectClientTittle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}