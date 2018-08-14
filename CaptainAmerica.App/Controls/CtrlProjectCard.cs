using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptainAmerica.App.Controls
{
    public partial class CtrlProjectCard : UserControl
    {
        private frmMain MyGrandFather { get; set; }
        public CtrlProjectCard()
        {
            InitializeComponent();
        }

        public CtrlProjectCard(string projectName, string clientName, string projectCategory, DateTime projectCreateDate,
            int id, string permission, frmMain MainParent)
        {
            InitializeComponent();

            lblProject.Text = projectName;
            lblClient.Text = clientName;
            lblProjectCreateDate.Text = projectCreateDate.ToShortDateString();
            this.Tag = id;
            imgElectric.Visible = projectCategory == "Eléctrico";
            imgMecanic.Visible = projectCategory == "Mecánico";

            switch (permission)
            {
                case "F":
                    btnEdit.Visible = true;
                    btnDetails.Visible = true;
                    btnMembers.Visible = true;
                    break;
                case "R":
                    btnEdit.Visible = false;
                    btnDetails.Visible = true;
                    btnMembers.Visible = false;
                    break;
                case "E":
                    btnEdit.Visible = true;
                    btnDetails.Visible = true;
                    btnMembers.Visible = false;
                    break;
                default:
                    break;
            }

            MyGrandFather = MainParent;

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            fnInitializeEditForm();
        }

        private void fnInitializeEditForm()
        {
            frmProjectCreate _oform = new frmProjectCreate((Model.Proyecto)Tag);
            var result = _oform.ShowDialog();

            //Adding new project to UI with out refresh from database - Better performance
            if (result == DialogResult.OK)
            {
                lblClient.Text = _oform.UpdatedProyecto.Cliente.NombreCliente;
                lblProject.Text = _oform.UpdatedProyecto.NombreProyecto;
                imgElectric.Visible = _oform.UpdatedProyecto.ProyectoCategoria.NombreCategoriaProyecto == "Eléctrico";
                imgMecanic.Visible = _oform.UpdatedProyecto.ProyectoCategoria.NombreCategoriaProyecto == "Mecánico";
            }

        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            frmProjectMembersCreate _oform = new frmProjectMembersCreate((Model.Proyecto)Tag);
            var result = _oform.ShowDialog();

            //Adding new project to UI with out refresh from database - Better performance
            if (result == DialogResult.OK)
            {
            }
        }

        private void btnDetails_Click_1(object sender, EventArgs e)
        {
            this.MyGrandFather.fnDetailsProject();
        }
    }
}
