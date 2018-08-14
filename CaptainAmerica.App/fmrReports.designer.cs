namespace CaptainAmerica.App
{
    partial class fmrReports
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnTopAddNew = new System.Windows.Forms.Button();
            this.btnUserDetail = new System.Windows.Forms.Button();
            this.PnFormularios = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Rtxt1 = new System.Windows.Forms.RichTextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtPlantilla = new System.Windows.Forms.TextBox();
            this.txtProyNumElec = new System.Windows.Forms.TextBox();
            this.txtProyNumMec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAsunElec = new System.Windows.Forms.TextBox();
            this.txtAsunMec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAtenElec = new System.Windows.Forms.TextBox();
            this.txtAtenMec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUbProMec = new System.Windows.Forms.TextBox();
            this.txtUbProElec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomProElec = new System.Windows.Forms.TextBox();
            this.txtNomProMec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContProMec = new System.Windows.Forms.TextBox();
            this.txtContProElec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlMainContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnFormularios.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Reporte Mecánico",
            "Reporte Electrico"});
            this.comboBox1.Location = new System.Drawing.Point(584, 23);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 27);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "--Seleccionar--";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.Controls.Add(this.button2);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.comboBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(968, 74);
            this.pnlTop.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::CaptainAmerica.App.Properties.Resources.ojo;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(804, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "       Mostrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 4);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(370, 51);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Creación de reportes";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::CaptainAmerica.App.Properties.Resources.if_cross_1894663;
            this.btnClose.Location = new System.Drawing.Point(301, 17);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.AllowDrop = true;
            this.pnlMainContainer.BackColor = System.Drawing.Color.White;
            this.pnlMainContainer.Controls.Add(this.PnFormularios);
            this.pnlMainContainer.Controls.Add(this.panel1);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 74);
            this.pnlMainContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(968, 498);
            this.pnlMainContainer.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Controls.Add(this.btnTopAddNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 439);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 59);
            this.panel1.TabIndex = 12;
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
            this.btnSave.Location = new System.Drawing.Point(804, 11);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Crear ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::CaptainAmerica.App.Properties.Resources.lupa__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(471, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "       Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(32, 20);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(268, 27);
            this.txtbuscar.TabIndex = 10;
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
            this.btnTopAddNew.Image = global::CaptainAmerica.App.Properties.Resources.ojo;
            this.btnTopAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopAddNew.Location = new System.Drawing.Point(647, 11);
            this.btnTopAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnTopAddNew.Name = "btnTopAddNew";
            this.btnTopAddNew.Size = new System.Drawing.Size(148, 37);
            this.btnTopAddNew.TabIndex = 9;
            this.btnTopAddNew.Text = "       Visualizar";
            this.btnTopAddNew.UseVisualStyleBackColor = false;
            this.btnTopAddNew.Click += new System.EventHandler(this.btnTopAddNew_Click);
            // 
            // btnUserDetail
            // 
            this.btnUserDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUserDetail.AutoEllipsis = true;
            this.btnUserDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserDetail.FlatAppearance.BorderSize = 0;
            this.btnUserDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUserDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserDetail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDetail.ForeColor = System.Drawing.Color.White;
            this.btnUserDetail.Image = global::CaptainAmerica.App.Properties.Resources.if_user_male2_172626;
            this.btnUserDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserDetail.Location = new System.Drawing.Point(16, 498);
            this.btnUserDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserDetail.Name = "btnUserDetail";
            this.btnUserDetail.Size = new System.Drawing.Size(365, 59);
            this.btnUserDetail.TabIndex = 8;
            this.btnUserDetail.Text = "    ";
            this.btnUserDetail.UseVisualStyleBackColor = true;
            // 
            // PnFormularios
            // 
            this.PnFormularios.Controls.Add(this.label7);
            this.PnFormularios.Controls.Add(this.Rtxt1);
            this.PnFormularios.Controls.Add(this.btnCargar);
            this.PnFormularios.Controls.Add(this.txtPlantilla);
            this.PnFormularios.Controls.Add(this.txtProyNumElec);
            this.PnFormularios.Controls.Add(this.txtProyNumMec);
            this.PnFormularios.Controls.Add(this.label6);
            this.PnFormularios.Controls.Add(this.txtAsunElec);
            this.PnFormularios.Controls.Add(this.txtAsunMec);
            this.PnFormularios.Controls.Add(this.label5);
            this.PnFormularios.Controls.Add(this.txtAtenElec);
            this.PnFormularios.Controls.Add(this.txtAtenMec);
            this.PnFormularios.Controls.Add(this.label4);
            this.PnFormularios.Controls.Add(this.txtUbProMec);
            this.PnFormularios.Controls.Add(this.txtUbProElec);
            this.PnFormularios.Controls.Add(this.label3);
            this.PnFormularios.Controls.Add(this.txtNomProElec);
            this.PnFormularios.Controls.Add(this.txtNomProMec);
            this.PnFormularios.Controls.Add(this.label2);
            this.PnFormularios.Controls.Add(this.txtContProMec);
            this.PnFormularios.Controls.Add(this.txtContProElec);
            this.PnFormularios.Controls.Add(this.label1);
            this.PnFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnFormularios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnFormularios.Location = new System.Drawing.Point(0, 0);
            this.PnFormularios.Margin = new System.Windows.Forms.Padding(4);
            this.PnFormularios.Name = "PnFormularios";
            this.PnFormularios.Size = new System.Drawing.Size(968, 439);
            this.PnFormularios.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label7.Location = new System.Drawing.Point(17, 209);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Información";
            // 
            // Rtxt1
            // 
            this.Rtxt1.Location = new System.Drawing.Point(12, 241);
            this.Rtxt1.Margin = new System.Windows.Forms.Padding(4);
            this.Rtxt1.Name = "Rtxt1";
            this.Rtxt1.Size = new System.Drawing.Size(903, 171);
            this.Rtxt1.TabIndex = 19;
            this.Rtxt1.Text = "";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(172)))), ((int)(((byte)(68)))));
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.Location = new System.Drawing.Point(551, 4);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(195, 41);
            this.btnCargar.TabIndex = 12;
            this.btnCargar.Text = "Cargar plantilla";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPlantilla
            // 
            this.txtPlantilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlantilla.Location = new System.Drawing.Point(12, 14);
            this.txtPlantilla.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlantilla.Name = "txtPlantilla";
            this.txtPlantilla.Size = new System.Drawing.Size(497, 27);
            this.txtPlantilla.TabIndex = 18;
            // 
            // txtProyNumElec
            // 
            this.txtProyNumElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProyNumElec.Location = new System.Drawing.Point(700, 145);
            this.txtProyNumElec.Margin = new System.Windows.Forms.Padding(4);
            this.txtProyNumElec.Name = "txtProyNumElec";
            this.txtProyNumElec.Size = new System.Drawing.Size(215, 27);
            this.txtProyNumElec.TabIndex = 17;
            // 
            // txtProyNumMec
            // 
            this.txtProyNumMec.Location = new System.Drawing.Point(700, 145);
            this.txtProyNumMec.Margin = new System.Windows.Forms.Padding(4);
            this.txtProyNumMec.Name = "txtProyNumMec";
            this.txtProyNumMec.Size = new System.Drawing.Size(215, 27);
            this.txtProyNumMec.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label6.Location = new System.Drawing.Point(559, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Proyecto Número";
            // 
            // txtAsunElec
            // 
            this.txtAsunElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunElec.Location = new System.Drawing.Point(356, 145);
            this.txtAsunElec.Margin = new System.Windows.Forms.Padding(4);
            this.txtAsunElec.Name = "txtAsunElec";
            this.txtAsunElec.Size = new System.Drawing.Size(157, 27);
            this.txtAsunElec.TabIndex = 14;
            // 
            // txtAsunMec
            // 
            this.txtAsunMec.Location = new System.Drawing.Point(356, 145);
            this.txtAsunMec.Margin = new System.Windows.Forms.Padding(4);
            this.txtAsunMec.Name = "txtAsunMec";
            this.txtAsunMec.Size = new System.Drawing.Size(157, 27);
            this.txtAsunMec.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(283, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Asunto";
            // 
            // txtAtenElec
            // 
            this.txtAtenElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtenElec.Location = new System.Drawing.Point(96, 145);
            this.txtAtenElec.Margin = new System.Windows.Forms.Padding(4);
            this.txtAtenElec.Name = "txtAtenElec";
            this.txtAtenElec.Size = new System.Drawing.Size(157, 27);
            this.txtAtenElec.TabIndex = 11;
            // 
            // txtAtenMec
            // 
            this.txtAtenMec.Location = new System.Drawing.Point(96, 145);
            this.txtAtenMec.Margin = new System.Windows.Forms.Padding(4);
            this.txtAtenMec.Name = "txtAtenMec";
            this.txtAtenMec.Size = new System.Drawing.Size(157, 27);
            this.txtAtenMec.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.Location = new System.Drawing.Point(15, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Atención";
            // 
            // txtUbProMec
            // 
            this.txtUbProMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbProMec.Location = new System.Drawing.Point(700, 71);
            this.txtUbProMec.Margin = new System.Windows.Forms.Padding(4);
            this.txtUbProMec.Name = "txtUbProMec";
            this.txtUbProMec.Size = new System.Drawing.Size(215, 27);
            this.txtUbProMec.TabIndex = 8;
            // 
            // txtUbProElec
            // 
            this.txtUbProElec.Location = new System.Drawing.Point(700, 71);
            this.txtUbProElec.Margin = new System.Windows.Forms.Padding(4);
            this.txtUbProElec.Name = "txtUbProElec";
            this.txtUbProElec.Size = new System.Drawing.Size(215, 27);
            this.txtUbProElec.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(559, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ubicación Proyecto";
            // 
            // txtNomProElec
            // 
            this.txtNomProElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProElec.Location = new System.Drawing.Point(356, 71);
            this.txtNomProElec.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomProElec.Name = "txtNomProElec";
            this.txtNomProElec.Size = new System.Drawing.Size(157, 27);
            this.txtNomProElec.TabIndex = 5;
            // 
            // txtNomProMec
            // 
            this.txtNomProMec.Location = new System.Drawing.Point(356, 71);
            this.txtNomProMec.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomProMec.Name = "txtNomProMec";
            this.txtNomProMec.Size = new System.Drawing.Size(157, 27);
            this.txtNomProMec.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(283, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proyecto";
            // 
            // txtContProMec
            // 
            this.txtContProMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContProMec.Location = new System.Drawing.Point(96, 71);
            this.txtContProMec.Margin = new System.Windows.Forms.Padding(4);
            this.txtContProMec.Name = "txtContProMec";
            this.txtContProMec.Size = new System.Drawing.Size(157, 27);
            this.txtContProMec.TabIndex = 2;
            // 
            // txtContProElec
            // 
            this.txtContProElec.Location = new System.Drawing.Point(96, 71);
            this.txtContProElec.Margin = new System.Windows.Forms.Padding(4);
            this.txtContProElec.Name = "txtContProElec";
            this.txtContProElec.Size = new System.Drawing.Size(157, 27);
            this.txtContProElec.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contenido";
            // 
            // fmrReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 572);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnUserDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmrReports";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "fmrReports";
            this.Load += new System.EventHandler(this.fmrReports_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlMainContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnFormularios.ResumeLayout(false);
            this.PnFormularios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnUserDetail;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTopAddNew;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel PnFormularios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox Rtxt1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtPlantilla;
        private System.Windows.Forms.TextBox txtProyNumElec;
        private System.Windows.Forms.TextBox txtProyNumMec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAsunElec;
        private System.Windows.Forms.TextBox txtAsunMec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAtenElec;
        private System.Windows.Forms.TextBox txtAtenMec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUbProMec;
        private System.Windows.Forms.TextBox txtUbProElec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomProElec;
        private System.Windows.Forms.TextBox txtNomProMec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContProMec;
        private System.Windows.Forms.TextBox txtContProElec;
        private System.Windows.Forms.Label label1;
    }
}