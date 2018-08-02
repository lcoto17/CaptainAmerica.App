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

        public frmMain()
        {
            InitializeComponent();

        }

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
            btnUserDetail.Text = WindowsIdentity.GetCurrent().Name;
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if(pnlVerticalMenu.Width == 63) pnlVerticalMenu.Width = 275;
            else pnlVerticalMenu.Width = 63;

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            btnRestore.Visible = false;
            btnMaximize.Visible = true;
        }
    }
}
