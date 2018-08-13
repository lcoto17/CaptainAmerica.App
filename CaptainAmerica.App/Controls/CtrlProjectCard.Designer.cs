namespace CaptainAmerica.App.Controls
{
    partial class CtrlProjectCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProject = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblProjectCreateDate = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.imgMecanic = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.imgElectric = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMecanic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgElectric)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProject
            // 
            this.lblProject.AutoEllipsis = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(20, 11);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(227, 24);
            this.lblProject.TabIndex = 0;
            this.lblProject.Text = "[ProjectName]";
            this.lblProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClient
            // 
            this.lblClient.AutoEllipsis = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(81, 87);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(227, 24);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "[ClientName]";
            this.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProjectCreateDate
            // 
            this.lblProjectCreateDate.AutoEllipsis = true;
            this.lblProjectCreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectCreateDate.Location = new System.Drawing.Point(81, 141);
            this.lblProjectCreateDate.Name = "lblProjectCreateDate";
            this.lblProjectCreateDate.Size = new System.Drawing.Size(227, 24);
            this.lblProjectCreateDate.TabIndex = 5;
            this.lblProjectCreateDate.Text = "[CreateDate]";
            this.lblProjectCreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(78, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Detalles";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(262, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CaptainAmerica.App.Properties.Resources.if_free_client;
            this.pictureBox1.Location = new System.Drawing.Point(24, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.Location = new System.Drawing.Point(5, 189);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(67, 29);
            this.btnDetails.TabIndex = 9;
            this.btnDetails.Text = "Editar";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(172)))), ((int)(((byte)(68)))));
            this.btnMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Location = new System.Drawing.Point(164, 189);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(92, 29);
            this.btnMembers.TabIndex = 8;
            this.btnMembers.Text = "Miembros";
            this.btnMembers.UseVisualStyleBackColor = false;
            // 
            // imgMecanic
            // 
            this.imgMecanic.BackColor = System.Drawing.Color.White;
            this.imgMecanic.Image = global::CaptainAmerica.App.Properties.Resources.if_miscellaneous_48_809421;
            this.imgMecanic.InitialImage = global::CaptainAmerica.App.Properties.Resources.if_Copcopan_3428076;
            this.imgMecanic.Location = new System.Drawing.Point(299, 3);
            this.imgMecanic.Name = "imgMecanic";
            this.imgMecanic.Size = new System.Drawing.Size(48, 48);
            this.imgMecanic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMecanic.TabIndex = 7;
            this.imgMecanic.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::CaptainAmerica.App.Properties.Resources.if_free_calendar;
            this.pictureBox3.Location = new System.Drawing.Point(24, 121);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // imgElectric
            // 
            this.imgElectric.BackColor = System.Drawing.Color.White;
            this.imgElectric.Image = global::CaptainAmerica.App.Properties.Resources.if_Copcopan_3428076;
            this.imgElectric.InitialImage = global::CaptainAmerica.App.Properties.Resources.if_Copcopan_3428076;
            this.imgElectric.Location = new System.Drawing.Point(299, 3);
            this.imgElectric.Name = "imgElectric";
            this.imgElectric.Size = new System.Drawing.Size(48, 48);
            this.imgElectric.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgElectric.TabIndex = 3;
            this.imgElectric.TabStop = false;
            // 
            // CtrlProjectCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.imgMecanic);
            this.Controls.Add(this.lblProjectCreateDate);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.imgElectric);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblProject);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.Name = "CtrlProjectCard";
            this.Size = new System.Drawing.Size(354, 256);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMecanic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgElectric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.PictureBox imgElectric;
        private System.Windows.Forms.Label lblProjectCreateDate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox imgMecanic;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
