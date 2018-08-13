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
using CaptainAmerica.Model;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace CaptainAmerica.App
{
    public partial class frmMain : Form
    {
        private BLProyecto oPoryectoBL = new BLProyecto();

        #region Constructor
        public frmMain()
        {
            InitializeComponent();
        } 
        #endregion

        #region Controls Events
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestore.Visible = true;
            btnMaximize.Visible = false;

        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnMaximize.Visible = true;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.AutoSize = false;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            btnUserDetail.Text = WindowsIdentity.GetCurrent().Name;
        }
        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (pnlVerticalMenu.Width == 63) pnlVerticalMenu.Width = 275;
            else pnlVerticalMenu.Width = 63;

        }
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            btnRestore.Visible = false;
            btnMaximize.Visible = true;
        }
        #endregion

        #region Form Entry Points
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        #region Private Methods
        private void fnInitializeChildForms(object frmChild)
        {
            Form fChild = frmChild as Form;

            if (pnlMainContainer.Controls.Count > 0)
                pnlMainContainer.Controls.RemoveAt(0);

            //Configuring child form
            fChild.TopLevel = false;
            fChild.Dock = DockStyle.Fill;

            //Adding child form to the panel container
            pnlMainContainer.Controls.Add(fChild);
            pnlMainContainer.Tag = fChild;

            //Showing child form
            fChild.Show();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            fnInitializeChildForms(new frmProjectList());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fnInitializeChildForms(new frmClientList());
        }
    }
}
