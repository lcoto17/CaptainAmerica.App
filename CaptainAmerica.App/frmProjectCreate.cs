﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaptainAmerica.BL.Implementations;
using CaptainAmerica.Model;

namespace CaptainAmerica.App
{
    public partial class frmProjectCreate : Form
    {
        private bool isUpdate { get; set; }
        private int IdProyecto { get; set; }
        public Proyecto UpdatedProyecto { get; set; }

        private BLCategoriaProyecto _oBLCategoriaPro;
        private BLCliente _oBLCliente;
        private BLProyecto _oBLProyecto; 

        public frmProjectCreate()
        {
            InitializeComponent();
            //Calling bind method to fill combo boxes
            fnBindListSources();

            isUpdate = false;
        }
        public frmProjectCreate(Proyecto tempProyecto)
        {
            InitializeComponent();
            //Calling bind method to fill combo boxes
            fnBindListSources();
            IdProyecto = tempProyecto.IdProyecto;
            txtProjectName.Text = tempProyecto.NombreProyecto;
            dtpProjectDate.Value = tempProyecto.FechaCreacion;
            cboxProjectCategory.SelectedValue = tempProyecto.ProyectoCategoria.IdCategoriaProyecto;
            cboxProjectClient.SelectedValue = tempProyecto.Cliente.IdCliente;
            dtpProjectDate.Enabled = false;
            isUpdate = true;
        }

        #region Controls Events
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void frmProjectCreate_Load(object sender, EventArgs e)
        {
            try
            {
                this.AutoSize = false;
                this.AutoScaleMode = AutoScaleMode.Font;
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Form Entry Points
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        #region Private Methods
        private void fnBindListSources()
        {
            //Loading project categories
            cboxProjectCategory.Items.Clear();
            _oBLCategoriaPro = new BLCategoriaProyecto();
            cboxProjectCategory.ValueMember = "IdCategoriaProyecto";
            cboxProjectCategory.DisplayMember = "NombreCategoriaProyecto";
            cboxProjectCategory.DataSource = _oBLCategoriaPro.GetAll();

            //Loading clients
            cboxProjectClient.Items.Clear();
            _oBLCliente = new BLCliente();
            cboxProjectClient.ValueMember = "IdCliente";
            cboxProjectClient.DisplayMember = "NombreCliente";
            cboxProjectClient.DataSource = _oBLCliente.GetAll().OrderBy(c => c.NombreCliente).ToList();
        }
        private void fnSaveProject(string name, int category, DateTime createDate, int client)
        {
            _oBLProyecto = new BLProyecto();
            Proyecto oProj = new Proyecto();

            oProj.NombreProyecto = name;
            oProj.IdCategoriaProyecto = category;
            oProj.FechaCreacion = createDate;
            oProj.IdCliente = client;

            //Calling bl method for saving in database (Edit or new)
            if(isUpdate)
            {
                oProj.IdProyecto = this.IdProyecto;
                _oBLProyecto.Edit(oProj);
                UpdatedProyecto = _oBLProyecto.GetOne(this.IdProyecto);
            }
            else
            {
                _oBLProyecto.AddNew(oProj);
            }

            
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                fnSaveProject(txtProjectName.Text, (int)cboxProjectCategory.SelectedValue, dtpProjectDate.Value, (int)cboxProjectClient.SelectedValue);
                MessageBox.Show("El proyecto se guardó correctamente.", "J&J Electromecánica - Aplicación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
