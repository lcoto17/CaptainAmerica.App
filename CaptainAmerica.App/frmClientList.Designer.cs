namespace CaptainAmerica.App
{
    partial class frmClientList
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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnTopAddNew = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.flpnlClientList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBottomAddNew = new System.Windows.Forms.Button();
            this.pnlTopBar.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTopBar.Controls.Add(this.btnTopAddNew);
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(660, 100);
            this.pnlTopBar.TabIndex = 0;
            // 
            // btnTopAddNew
            // 
            this.btnTopAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTopAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTopAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopAddNew.FlatAppearance.BorderSize = 0;
            this.btnTopAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTopAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopAddNew.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopAddNew.ForeColor = System.Drawing.Color.White;
            this.btnTopAddNew.Image = global::CaptainAmerica.App.Properties.Resources.if_plus_24_103172;
            this.btnTopAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopAddNew.Location = new System.Drawing.Point(444, 37);
            this.btnTopAddNew.Name = "btnTopAddNew";
            this.btnTopAddNew.Size = new System.Drawing.Size(180, 38);
            this.btnTopAddNew.TabIndex = 8;
            this.btnTopAddNew.Text = "    Agregar cliente";
            this.btnTopAddNew.UseVisualStyleBackColor = false;
            this.btnTopAddNew.Click += new System.EventHandler(this.btnTopAddNew_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(336, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Control de clientes";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Controls.Add(this.flpnlClientList);
            this.pnlContainer.Controls.Add(this.pnlMessage);
            this.pnlContainer.Controls.Add(this.panel2);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 100);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(660, 487);
            this.pnlContainer.TabIndex = 1;
            // 
            // flpnlClientList
            // 
            this.flpnlClientList.AutoScroll = true;
            this.flpnlClientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnlClientList.Location = new System.Drawing.Point(0, 0);
            this.flpnlClientList.Name = "flpnlClientList";
            this.flpnlClientList.Padding = new System.Windows.Forms.Padding(25, 50, 25, 0);
            this.flpnlClientList.Size = new System.Drawing.Size(660, 425);
            this.flpnlClientList.TabIndex = 4;
            // 
            // pnlMessage
            // 
            this.pnlMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(237)))), ((int)(((byte)(218)))));
            this.pnlMessage.Controls.Add(this.btnClose);
            this.pnlMessage.Controls.Add(this.lblMessage);
            this.pnlMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMessage.Location = new System.Drawing.Point(0, 0);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(660, 0);
            this.pnlMessage.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::CaptainAmerica.App.Properties.Resources.if_cross_1894663;
            this.btnClose.Location = new System.Drawing.Point(627, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 34);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(57)))));
            this.lblMessage.Location = new System.Drawing.Point(17, 22);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(319, 23);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "El proyecto \'{0}\' se ha {1} correctamente.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnBottomAddNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 62);
            this.panel2.TabIndex = 2;
            // 
            // btnBottomAddNew
            // 
            this.btnBottomAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBottomAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBottomAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBottomAddNew.FlatAppearance.BorderSize = 0;
            this.btnBottomAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBottomAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottomAddNew.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBottomAddNew.ForeColor = System.Drawing.Color.White;
            this.btnBottomAddNew.Image = global::CaptainAmerica.App.Properties.Resources.if_plus_24_103172;
            this.btnBottomAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBottomAddNew.Location = new System.Drawing.Point(444, 12);
            this.btnBottomAddNew.Name = "btnBottomAddNew";
            this.btnBottomAddNew.Size = new System.Drawing.Size(180, 38);
            this.btnBottomAddNew.TabIndex = 7;
            this.btnBottomAddNew.Text = "    Agregar cliente";
            this.btnBottomAddNew.UseVisualStyleBackColor = false;
            this.btnBottomAddNew.Click += new System.EventHandler(this.btnBottomAddNew_Click);
            // 
            // frmClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 587);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientList";
            this.Text = "Control de proyectos";
            this.Load += new System.EventHandler(this.frmListProjects_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlMessage.ResumeLayout(false);
            this.pnlMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBottomAddNew;
        private System.Windows.Forms.Panel pnlMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.FlowLayoutPanel flpnlClientList;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Button btnTopAddNew;
    }
}