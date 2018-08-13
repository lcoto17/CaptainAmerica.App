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
    public partial class CtrlClientCard : UserControl
    {
        public CtrlClientCard()
        {
            InitializeComponent();
        }

        public CtrlClientCard(string ClientName, DateTime clientCreateDate, int id)
        {
            InitializeComponent();

            lblClient.Text = ClientName;
            lblClientCreateDate.Text = clientCreateDate.ToShortDateString();
            this.Tag = id;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            fnInitializeEditForm();
        }

        private void fnInitializeEditForm()
        {
            frmClientCreate _oform = new frmClientCreate((Model.Cliente)Tag);
            var result = _oform.ShowDialog();

            //Adding new project to UI with out refresh from database - Better performance
            if (result == DialogResult.OK)
            {
                lblClient.Text = _oform.UpdatedCliente.NombreCliente;
            }

        }
    }
}
