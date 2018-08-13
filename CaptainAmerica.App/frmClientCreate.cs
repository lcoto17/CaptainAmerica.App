using System;
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
    public partial class frmClientCreate : Form
    {
        private bool isUpdate { get; set; }
        private int IdCliente { get; set; }
        public Cliente UpdatedCliente { get; set; }

        private BLCategoriaProyecto _oBLCategoriaPro;
        private BLCliente _oBLCliente;
        private BLProyecto _oBLProyecto; 

        public frmClientCreate()
        {
            InitializeComponent();
            //Calling bind method to fill combo boxes
            isUpdate = false;
        }
        public frmClientCreate(Cliente tempCliente)
        {
            InitializeComponent();
            //Calling bind method to fill combo boxes
            IdCliente = tempCliente.IdCliente;
            txtClientName.Text = tempCliente.NombreCliente;
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
        private void fnSaveClient(string name)
        {
            _oBLCliente = new BLCliente();
            Cliente oCliente = new Cliente();

            oCliente.NombreCliente = name;
            oCliente.FechaCreacion = DateTime.Now;
            //Calling bl method for saving in database (Edit or new)
            if(isUpdate)
            {
                oCliente.IdCliente = this.IdCliente;
                _oBLCliente.Edit(oCliente);
                UpdatedCliente = _oBLCliente.GetOne(this.IdCliente);
            }
            else
            {
                _oBLCliente.AddNew(oCliente);
            }

            
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                fnSaveClient(txtClientName.Text);
                MessageBox.Show("El cliente se guardó correctamente.", "J&J Electromecánica - Aplicación",
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
