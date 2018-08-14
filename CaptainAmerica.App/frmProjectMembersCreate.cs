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
    public partial class frmProjectMembersCreate : Form
    {
        private bool isUpdate { get; set; }
        private int IdProyecto { get; set; }
        public Proyecto UpdatedProyecto { get; set; }

        private BLProyecto _oBLProyecto = new BLProyecto();
        private BLProyectoMiembro _oBLProyectoMiembro = new BLProyectoMiembro();
        private BLUsuario _oBLUsuario = new BLUsuario();


        public frmProjectMembersCreate()
        {
            InitializeComponent();
            //Calling bind method to fill combo boxes
            fnLoadLists();

            isUpdate = false;
        }
        public frmProjectMembersCreate(Proyecto tempProyecto)
        {
            InitializeComponent();
            IdProyecto = tempProyecto.IdProyecto;

            //Calling bind method to fill combo boxes
            fnLoadLists();
            
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
        private void btnReadOnly_Click(object sender, EventArgs e)
        {
            try
            {
                string message = fnAddMembers("R");
                fnLoadLists();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "J&J Electromecánica - Aplicación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            try
            {
                fnRemoveMembers();
                fnLoadLists();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "J&J Electromecánica - Aplicación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string message = fnAddMembers("E");
                fnLoadLists();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "J&J Electromecánica - Aplicación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFullAccess_Click(object sender, EventArgs e)
        {
            try
            {
                string message = fnAddMembers("F");
                fnLoadLists();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "J&J Electromecánica - Aplicación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Form Entry Points
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        #region Private Methods

        private void fnLoadLists()
        {
            bool exist = false;
            var userList = _oBLUsuario.GetAll();
            var memberList = _oBLProyectoMiembro.GetAll().Where(c => c.IdProyecto == IdProyecto);

            listBoxMembers.Items.Clear();
            listBoxUsers.Items.Clear();

            foreach (var item in memberList)
            {
                listBoxMembers.Items.Add(string.Format("{0} | {1} | {2} | {3}", item.IdUsuario, item.Usuario.CodigoUsuario, item.Usuario.NombreUsuario, item.MiembroPermiso));
            }

            foreach (var item in userList)
            {
                foreach (var itemList in listBoxMembers.Items)
                {
                    if (itemList.ToString().Replace(" | R", "").Replace(" | F", "").Replace(" | E", "") == 
                        string.Format("{0} | {1} | {2}", item.IdUsuario, item.CodigoUsuario, item.NombreUsuario))
                    {
                        exist = true;
                        break;
                    }
                }
                if(!exist)
                    listBoxUsers.Items.Add(string.Format("{0} | {1} | {2}", item.IdUsuario, item.CodigoUsuario, item.NombreUsuario));

                exist = false;
            }
            
        }

        private string fnAddMembers(string typeMember)
        {
            string message = "Los miembros se agregaron correctamente." + Environment.NewLine;

            foreach (var item in listBoxUsers.SelectedItems)
            {
                try
                {
                    ProyectoMiembro pm = new ProyectoMiembro();

                    pm.IdProyecto = this.IdProyecto;
                    pm.IdUsuario = Convert.ToInt32(item.ToString().Split('|')[0].Trim());
                    pm.MiembroPermiso = typeMember;

                    _oBLProyectoMiembro.AddNew(pm);
                    //listBoxMembers.Items.Add(item);
                    //listBoxUsers.Items.Remove(item);
                }
                catch (Exception ex)
                {
                    message += string.Format("El permiso para el usuario {0} no se pudo agregar. Razón: {1}", 
                        item.ToString().Split('|')[1].Trim(), ex.Message);
                    
                }

            }
            
            return message;
        }

        private string fnRemoveMembers()
        {
            string message = "Los miembros se removieron correctamente." + Environment.NewLine;

            foreach (var item in listBoxMembers.SelectedItems)
            {
                try
                {

                    var tempom = _oBLProyectoMiembro.GetAll().Where(c => c.IdUsuario == Convert.ToInt32(item.ToString().Split('|')[0].Trim()) && c.IdProyecto == this.IdProyecto).FirstOrDefault();

                    if (tempom != null)
                    {
                        _oBLProyectoMiembro.Delete(tempom.IdProyectoMiembro);
                    }

                    //listBoxUsers.Items.Add(item);
                    //listBoxMembers.Items.Remove(item);

                }
                catch (Exception ex)
                {
                    message += string.Format("El permiso para el usuario {0} no se pudo agregar. Razón: {1}",
                        item.ToString().Split('|')[1].Trim(), ex.Message);

                }

            }
            return message;
        }


        #endregion



    }
}
