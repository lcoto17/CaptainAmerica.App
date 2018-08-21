using System;
using System.IO;
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
using System.Security.Principal;

namespace CaptainAmerica.App
{
    public partial class frmProjectDetails : Form
    {
        private BLProyecto _oBLProyecto = new BLProyecto();
        private BLProyectoMiembro _oBLProyectoMiembro = new BLProyectoMiembro();
        private BLParametro _oBLParametro = new BLParametro();
        private BLProyectoArchivo _oBLProyectoArchivo = new BLProyectoArchivo();
        private BLArchivoComentario _oBLArchivoComentario = new BLArchivoComentario();
        private BLUsuario _oBLUsuario = new BLUsuario();

        public Proyecto ProyectoDetalle { get; set; }

        public frmProjectDetails(Proyecto tempProyecto)
        {
            InitializeComponent();
            this.ProyectoDetalle = tempProyecto;
            lblProjectName.Text = this.ProyectoDetalle.NombreProyecto;
            lblProjectClient.Text = this.ProyectoDetalle.Cliente.NombreCliente;
            lblProjectCategory.Text = this.ProyectoDetalle.ProyectoCategoria.NombreCategoriaProyecto;
            lblProjectDate.Text = this.ProyectoDetalle.FechaCreacion.ToShortDateString();
        }

        #region Events
        private void frmListProjects_Load(object sender, EventArgs e)
        {
            try
            {
                fnLoadImages();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "J&J Electromecánica - Aplicación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Image_click(object sender, EventArgs e)
        {

            var ctrl = sender as PictureBox;
            var proyectoArchivo = (ProyectoArchivo)ctrl.Tag;

            fnLoadSelectedImage(proyectoArchivo);

        }
        private void btnAddImages_Click(object sender, EventArgs e)
        {
            try
            {
                fnSaveImage();
                fnLoadImages();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "J&J Electromecánica - Aplicación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtAddcomment_Enter(object sender, EventArgs e)
        {
            if (txtAddcomment.Text == "Ingrese comentario...")
            {
                txtAddcomment.ForeColor = Color.Black;
                txtAddcomment.Text = "";
            }
        }
        private void txtAddcomment_Leave(object sender, EventArgs e)
        {
            if (txtAddcomment.Text == "")
            {
                txtAddcomment.ForeColor = Color.DarkGray;
                txtAddcomment.Text = "Ingrese comentario...";
            }
        }
        private void btnBottomAddNewComment_Click(object sender, EventArgs e)
        {
            try
            {
                fnSaveComment(txtAddcomment.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "J&J Electromecánica - Aplicación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Methods
        private void fnSaveImage()
        {
            string filePath = "";
            string fileDestination = "";
            string fileName = "";
            ProyectoArchivo oTempArchivo;

            if (OpenFileDialogImages.ShowDialog() == DialogResult.OK)
            {

                fileName = OpenFileDialogImages.SafeFileName;
                filePath = OpenFileDialogImages.FileName;
                fileDestination = _oBLParametro.GetAll().Where(c => c.Nombre == "FileStoragePath").FirstOrDefault().Valor;

                if (!Directory.Exists(fileDestination))
                {
                    Directory.CreateDirectory(fileDestination);
                }

                if (File.Exists(Path.Combine(fileDestination, fileName)))
                {
                    throw new Exception("El archivo que intenta agregar ya existe en el directorio destino, por favor cambie el nombre del archivo e intente nuevamente.");
                }
                else
                {
                    File.Copy(filePath, Path.Combine(fileDestination, fileName), false);
                    oTempArchivo = new ProyectoArchivo();

                    oTempArchivo.IdProyecto = this.ProyectoDetalle.IdProyecto;
                    oTempArchivo.NombreArchivo = fileName;
                    oTempArchivo.URLGuardado = Path.Combine(fileDestination, fileName);
                    oTempArchivo.FechaCreacion = DateTime.Now;

                    _oBLProyectoArchivo.AddNew(oTempArchivo);

                }

            }
        }

        private void fnLoadImages()
        {
            var listImages = _oBLProyectoArchivo.GetAll().Where(c => c.IdProyecto == this.ProyectoDetalle.IdProyecto).OrderByDescending(c=>c.FechaCreacion).ToList();

            flpnlImgList.Controls.Clear();

            foreach (var item in listImages)
            {

                PictureBox pb = new PictureBox();
                pb.Click += new EventHandler(this.Image_click);
                pb.Tag = item;
                pb.Cursor = Cursors.Hand;
                pb.Width = 202;
                pb.Height = 125;
                pb.Image = Image.FromFile(item.URLGuardado);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                flpnlImgList.Controls.Add(pb);
                
            }
            if(flpnlImgList.Controls.Count > 0)
            {
                fnLoadSelectedImage((ProyectoArchivo)flpnlImgList.Controls[0].Tag);
            }
        }

        private void fnSaveComment(string comment)
        {
            var proyArchivo = (ProyectoArchivo)imgSelected.Tag;
            if (proyArchivo != null)
            {
                if ((!string.IsNullOrEmpty(comment) && comment != "Ingrese comentario..."))
                {
                    ArchivoComentario temp = new ArchivoComentario();
                    temp.IdProyectoArchivo = proyArchivo.IdProyectoArchivo;
                    temp.ArchivoComentarioDescr = comment;
                    temp.FechaCreacion = DateTime.Now;
                    temp.IdUsuario = _oBLUsuario.GetAll().Where(c => c.CodigoUsuario.ToLower() == WindowsIdentity.GetCurrent().Name.ToLower()).FirstOrDefault().IdUsuario;
                    _oBLArchivoComentario.AddNew(temp);

                    fnLoadComments(proyArchivo.IdProyectoArchivo);
                }
                else
                {
                    MessageBox.Show("El comentario no puede estar vacío.", "J&J Electromecánica - Aplicación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("No se ha seleccionado una imagen.", "J&J Electromecánica - Aplicación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fnLoadSelectedImage(ProyectoArchivo proyectoArchivo)
        {

            imgSelected.Image = Image.FromFile(proyectoArchivo.URLGuardado);
            imgSelected.Tag = proyectoArchivo;
            imgSelected.SizeMode = PictureBoxSizeMode.StretchImage;
            lblFileName.Text = "Nombre: " + proyectoArchivo.NombreArchivo;
            lblFileDate.Text = "Creada: " + proyectoArchivo.FechaCreacion.ToShortDateString();
            lblPath.Text = "Ruta: " + proyectoArchivo.URLGuardado;

            fnLoadComments(proyectoArchivo.IdProyectoArchivo);
        }

        private void fnLoadComments(int IdProyectoArchivo)
        {
            int row;
            var temp = _oBLArchivoComentario.GetAll()
                .Where(c => c.IdProyectoArchivo == IdProyectoArchivo)
                .OrderByDescending(c => c.FechaCreacion).ToList();

            tlpnlComments.Controls.Clear();
            tlpnlComments.ColumnStyles.Clear();
            tlpnlComments.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tlpnlComments.RowStyles.Clear();
            tlpnlComments.RowCount = 0;

            foreach (var item in temp)
            {
                CtrlFileComment comment = new CtrlFileComment(item);
                comment.Dock = DockStyle.Top;
                row = tlpnlComments.RowCount++;
                tlpnlComments.RowStyles.Add(new RowStyle(SizeType.AutoSize, 0f));
                tlpnlComments.Controls.Add(comment, 0, row);
                
            }
        }
        #endregion


    }
}
