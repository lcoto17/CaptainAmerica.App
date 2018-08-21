using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using System.Reflection;
using System.IO;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace CaptainAmerica.App
{
    public partial class fmrReports : Form
    {
        //Methode for FIN AND REPLACE
        private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object findtext, object replacewithtext)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref findtext,
                ref matchCase, ref matchWholeWord, ref matchWildCards,
                ref matchSoundLike, ref nmatchAllForms, ref forward,
                ref wrap, ref format, ref replacewithtext, ref replace,
                ref matchKashida, ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }

        //Methode for create Document
        private void createWordDocument(object filename, object SaveAs)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document MyWordDoc = null;

            if (File.Exists((string)filename))
            {
                DateTime today = DateTime.Now;
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                MyWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                              ref missing, ref missing, ref missing,
                                              ref missing, ref missing, ref missing,
                                              ref missing, ref missing, ref missing, ref missing,
                                              ref missing, ref missing, ref missing);

                MyWordDoc.Activate();

                //FindAndReplace

                this.FindAndReplace(wordApp, "<texto0>", txtContProElec.Text);
                this.FindAndReplace(wordApp, "<texto0>", txtContProMec.Text);
                this.FindAndReplace(wordApp, "<proyecto>", txtNomProElec.Text);
                this.FindAndReplace(wordApp, "<proyecto>", txtNomProMec.Text);
                this.FindAndReplace(wordApp, "<locacion>", txtUbProElec.Text);
                this.FindAndReplace(wordApp, "<locacion>", txtUbProMec.Text);
                this.FindAndReplace(wordApp, "<atencion>", txtAtenElec.Text);
                this.FindAndReplace(wordApp, "<atencion>", txtAtenMec.Text);
                this.FindAndReplace(wordApp, "<asunto>", txtAsunElec.Text);
                this.FindAndReplace(wordApp, "<asunto>", txtAsunMec.Text);
                this.FindAndReplace(wordApp, "<proyec_num>", txtProyNumElec.Text);
                this.FindAndReplace(wordApp, "<proyec_num>", txtProyNumMec.Text);
                this.FindAndReplace(wordApp, "<Ingeniero1>", txtIng1.Text);
                this.FindAndReplace(wordApp, "<Ingeniero2>", txtIng2.Text);
                this.FindAndReplace(wordApp, "<MailIng1>", txtMail1.Text);
                this.FindAndReplace(wordApp, "<MailIng2>", txtMail2.Text);
                this.FindAndReplace(wordApp, "<titulo1>", txtTit1.Text);
                this.FindAndReplace(wordApp, "<Texto1>", Rtxt1.Text);
                this.FindAndReplace(wordApp, "<titulo2>", txtTit2.Text);
                this.FindAndReplace(wordApp, "<Texto2>", Rtxt2.Text);
                this.FindAndReplace(wordApp, "<titulo3>", txtTit3.Text);
                this.FindAndReplace(wordApp, "<Texto3>", Rtxt3.Text);
                this.FindAndReplace(wordApp, "<titulo4>", txtTit4.Text);
                this.FindAndReplace(wordApp, "<Texto4>", Rtxt4.Text);
                this.FindAndReplace(wordApp, "<titulo5>", txtTit5.Text);
                this.FindAndReplace(wordApp, "<Texto5>", Rtxt5.Text);
                this.FindAndReplace(wordApp, "<titulo6>", txtTit6.Text);
                this.FindAndReplace(wordApp, "<Texto6>", Rtxt6.Text);
                this.FindAndReplace(wordApp, "<titulo7>", txtTit7.Text);
                this.FindAndReplace(wordApp, "<Texto7>", Rtxt7.Text);
                this.FindAndReplace(wordApp, "<titulo8>", txtTit8.Text);
                this.FindAndReplace(wordApp, "<Texto8>", Rtxt8.Text);
                this.FindAndReplace(wordApp, "<titulo9>", txtTit9.Text);
                this.FindAndReplace(wordApp, "<Texto9>", Rtxt9.Text);
                this.FindAndReplace(wordApp, "<titulo10>", txtTit10.Text);
                this.FindAndReplace(wordApp, "<Texto10>", Rtxt10.Text);
                this.FindAndReplace(wordApp, "<titulo11>", txtTit11.Text);
                this.FindAndReplace(wordApp, "<Texto11>", Rtxt11.Text);
                this.FindAndReplace(wordApp, "<titulo12>", txtTit12.Text);
                this.FindAndReplace(wordApp, "<Texto12>", Rtxt12.Text);
                this.FindAndReplace(wordApp, "<fecha>", DateTime.Now.ToShortDateString());

                //                Insert Image
                //Image img = resizeImage(pathImage, new Size(200, 90));



            }
            else
            {
                MessageBox.Show("No existe el archivo");
                return;
            }


            //Save AS
            MyWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                         ref missing, ref missing, ref missing,
                          ref missing, ref missing, ref missing,
                           ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);
            //Clse
            MyWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("Documento Creado");


        }
        public fmrReports()
        {
            InitializeComponent();
            PnFormularios.Hide();

        }

        private void fmrReports_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtbuscar.Clear();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            /*this.WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnMaximize.Visible = true;*/
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //btnRestore.Visible = true;
            // btnMaximize.Visible = false;
        }

        private void btnPrjectManagement_Click(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();
            fm.Show();
            this.Hide();

        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            // if (pnlVerticalMenu.Width == 63) pnlVerticalMenu.Width = 275;
            //else pnlVerticalMenu.Width = 63;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnTopAddNew_Click(object sender, EventArgs e)
        {




            Process.Start(txtbuscar.Text);


        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            SaveFileDialog Sve = new SaveFileDialog();
            if (Sve.ShowDialog() == DialogResult.OK)
            {
                createWordDocument(txtPlantilla.Text, Sve.FileName);
            }
            else
            {
                MessageBox.Show("La plantilla cargada no se puede editar");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtbuscar.Text = buscar.FileName;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "--Seleccionar--")
            {

                PnFormularios.Hide();
            }
            else
            {
                PnFormularios.Show();
                if (comboBox1.Text == "Reporte Electrico")
                {
                    lblelec.Show();
                    lblmec.Hide();
                    txtContProElec.Show();
                    txtContProElec.Show();
                    txtUbProElec.Show();
                    txtAtenElec.Show();
                    txtAsunElec.Show();
                    Rtxt1.Show();
                    btnatras.Hide();
                }
                else
                {
                    lblelec.Hide();
                    lblmec.Show();
                    txtContProElec.Hide();
                    txtContProElec.Hide();
                    txtUbProElec.Hide();
                    txtAtenElec.Hide();
                    txtAsunElec.Hide();
                    Rtxt1.Hide();
                    btnatras.Hide();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomProMec_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog LoadDoc = new OpenFileDialog();

            if (LoadDoc.ShowDialog() == DialogResult.OK)
            {
                txtPlantilla.Text = LoadDoc.FileName;
            }
        }

        private void txtPlantilla_TextChanged(object sender, EventArgs e)
        {
            txtPlantilla.Enabled = false;
        }

        private void txtPlantilla_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void PnFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Rtxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Rtxt7.Show();
            Rtxt8.Show();
            Rtxt9.Show();
            Rtxt10.Show();
            Rtxt11.Show();
            Rtxt12.Show();
            txtTit7.Show();
            txtTit8.Show();
            txtTit9.Show();
            txtTit10.Show();
            txtTit11.Show();
            txtTit12.Show();
            lbtit1.Hide();
            lbtit2.Hide();
            lbtit3.Hide();
            lbtit4.Hide();
            lbtit5.Hide();
            lbtit6.Hide();
            Rtxt1.Hide();
            Rtxt2.Hide();
            Rtxt3.Hide();
            Rtxt4.Hide();
            Rtxt5.Hide();
            Rtxt6.Hide();
            txtTit1.Hide();
            txtTit2.Hide();
            txtTit3.Hide();
            txtTit4.Hide();
            txtTit5.Hide();
            txtTit6.Hide();
            btnsecc.Enabled = false;
            btnatras.Show();

        }

        private void txtUbProMec_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            /*Rtxt7.Show();
            Rtxt8.Show();
            Rtxt9.Show();
            Rtxt10.Show();
            Rtxt11.Show();
            Rtxt12.Show();
            txtTit7.Show();
            txtTit8.Show();
            txtTit9.Show();
            txtTit10.Show();
            txtTit11.Show();
            txtTit12.Show();*/
            lbtit1.Show();
            lbtit2.Show();
            lbtit3.Show();
            lbtit4.Show();
            lbtit5.Show();
            lbtit6.Show();
            Rtxt1.Show();
            Rtxt2.Show();
            Rtxt3.Show();
            Rtxt4.Show();
            Rtxt5.Show();
            Rtxt6.Show();
            txtTit1.Show();
            txtTit2.Show();
            txtTit3.Show();
            txtTit4.Show();
            txtTit5.Show();
            txtTit6.Show();
            btnatras.Hide();
            btnsecc.Enabled = true;

        }
    }
}
