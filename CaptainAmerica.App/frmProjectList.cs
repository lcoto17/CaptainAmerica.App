using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaptainAmerica.BL.Implementations;
using CaptainAmerica.App.Controls;
using CaptainAmerica.Model;

namespace CaptainAmerica.App
{
    public partial class frmProjectList : Form
    {
        private BLProyecto _oBLProyecto = new BLProyecto();
        private BLProyectoMiembro _oBLProyectoMiembro = new BLProyectoMiembro();
        public frmProjectList()
        {
            InitializeComponent();
        }

        private void frmListProjects_Load(object sender, EventArgs e)
        {
            try
            {
                fnLoadProjects();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnTopAddNew_Click(object sender, EventArgs e)
        {
            fnInitializeCreateForm();
        }

        private void btnBottomAddNew_Click(object sender, EventArgs e)
        {
            fnInitializeCreateForm();
        }

        public void fnLoadProjects()
        {
            var projectList = _oBLProyectoMiembro.GetAll();

            flpnlProjectList.Controls.Clear();
                        
            foreach (var item in projectList)
            {
                CtrlProjectCard _oCtrlProject = new CtrlProjectCard(item.Proyecto.NombreProyecto,
                item.Proyecto.Cliente.NombreCliente, item.Proyecto.ProyectoCategoria.NombreCategoriaProyecto, item.Proyecto.FechaCreacion, 0, item.MiembroPermiso);
                _oCtrlProject.Tag = item.Proyecto;
                flpnlProjectList.Controls.Add(_oCtrlProject);
            }
        }

        private void fnInitializeCreateForm()
        {
            frmProjectCreate _oform = new frmProjectCreate();
            var result = _oform.ShowDialog();

            //Adding new project to UI with out refresh from database - Better performance
            if(result == DialogResult.OK)
            {
                fnLoadProjects();
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlMessage.Height = 0;
            lblMessage.Text = "El proyecto '{0}' se ha {1} correctamente.";
        }
    }
}
