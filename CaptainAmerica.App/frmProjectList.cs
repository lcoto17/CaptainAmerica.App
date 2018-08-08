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

        public frmProjectList()
        {
            InitializeComponent();
        }

        private void frmListProjects_Load(object sender, EventArgs e)
        {
            try
            {
                var projectList = _oBLProyecto.GetAll();

                foreach (var item in projectList)
                {
                    CtrlProjectCard _oCtrlProject = new CtrlProjectCard(item.NombreProyecto,
                    item.Cliente.NombreCliente, item.ProyectoCategoria.NombreCategoriaProyecto, item.FechaCreacion,0);

                    flpnlProjectList.Controls.Add(_oCtrlProject);
                }
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

        private void fnInitializeCreateForm()
        {
            frmProjectCreate _oform = new frmProjectCreate();
            var result = _oform.ShowDialog();

            //Adding new project to UI with out refresh from database - Better performance
            if(result == DialogResult.OK)
            {
                CtrlProjectCard _oCtrlProject = new CtrlProjectCard(_oform.oAddedProject.NombreProyecto,
                    _oform.oAddedProject.Cliente.NombreCliente, _oform.oAddedProject.ProyectoCategoria.NombreCategoriaProyecto, _oform.oAddedProject.FechaCreacion,0);

                lblMessage.Text = String.Format(lblMessage.Text, _oform.oAddedProject.NombreProyecto, "creado");
                pnlMessage.Height = 60;
                

                flpnlProjectList.Controls.Add(_oCtrlProject);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlMessage.Height = 0;
            lblMessage.Text = "El proyecto '{0}' se ha {1} correctamente.";
        }
    }
}
