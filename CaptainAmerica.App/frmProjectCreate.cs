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
    public partial class frmProjectCreate : Form
    {
        public Proyecto oAddedProject { get; set; }

        private BLCategoriaProyecto _oBLCategoriaPro;
        private BLCliente _oBLCliente;
        private BLProyecto _oBLProyecto; 

        public frmProjectCreate()
        {
            InitializeComponent();
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

                //Calling bind method to fill combo boxes
                fnBindListSources();
                
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
        private void fnSaveNewProject(string name, int category, DateTime createDate, int client)
        {
            _oBLProyecto = new BLProyecto();
            Proyecto oProj = new Proyecto();

            oProj.NombreProyecto = name;
            oProj.ProyectoCategoria = _oBLCategoriaPro.GetOne(category);
            oProj.FechaCreacion = createDate;
            oProj.Cliente = _oBLCliente.GetOne(client);

            //Calling bl method for saving in database
            _oBLProyecto.AddNew(oProj);

            //Saving object for UI
            this.oAddedProject = oProj;
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                fnSaveNewProject(txtProjectName.Text, (int)cboxProjectCategory.SelectedValue, dtpProjectDate.Value, (int)cboxProjectClient.SelectedValue);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
