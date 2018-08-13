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
    public partial class frmClientList : Form
    {
        private BLCliente _oBLCliente = new BLCliente();

        public frmClientList()
        {
            InitializeComponent();
        }

        private void frmListProjects_Load(object sender, EventArgs e)
        {
            try
            {
                fnLoadClients();
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

        public void fnLoadClients()
        {
            var clientList = _oBLCliente.GetAll();

            flpnlClientList.Controls.Clear();
                        
            foreach (var item in clientList)
            {
                CtrlClientCard _oCtrlClient = new CtrlClientCard(item.NombreCliente, item.FechaCreacion, item.IdCliente);
                _oCtrlClient.Tag = item;
                flpnlClientList.Controls.Add(_oCtrlClient);
            }
        }

        private void fnInitializeCreateForm()
        {
            frmClientCreate _oform = new frmClientCreate();
            var result = _oform.ShowDialog();

            //Adding new project to UI with out refresh from database - Better performance
            if(result == DialogResult.OK)
            {
                fnLoadClients();
            }

        }
    }
}
