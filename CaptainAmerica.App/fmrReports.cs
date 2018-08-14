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

                this.FindAndReplace(wordApp, "<contenido>", txtContProElec.Text);
                this.FindAndReplace(wordApp, "<proyecto>", txtNomProElec.Text);
                this.FindAndReplace(wordApp, "<ubicacion>", txtUbProElec.Text);
                this.FindAndReplace(wordApp, "<atencion>", txtAtenElec.Text);
                this.FindAndReplace(wordApp, "<asunto>", txtAsunElec.Text);
                this.FindAndReplace(wordApp, "<proyec_num>", txtProyNumElec.Text);
                this.FindAndReplace(wordApp, "<Ingeniero1>", txtProyNumElec.Text);
                this.FindAndReplace(wordApp, "<Ingeniero2>", txtProyNumElec.Text);
                this.FindAndReplace(wordApp, "<MailIng1>", txtProyNumElec.Text);
                this.FindAndReplace(wordApp, "<MailIng2>", txtProyNumElec.Text);
                this.FindAndReplace(wordApp, "<Texto1>", Rtxt1.Text);
                this.FindAndReplace(wordApp, "<Texto2>", Rtxt1.Text);
                this.FindAndReplace(wordApp, "<Texto3>", Rtxt1.Text);
                this.FindAndReplace(wordApp, "<Texto4>", Rtxt1.Text);
                this.FindAndReplace(wordApp, "<Texto5>", Rtxt1.Text);
                this.FindAndReplace(wordApp, "<Texto6>", Rtxt1.Text);
                this.FindAndReplace(wordApp, "<Texto7>", Rtxt1.Text);
                this.FindAndReplace(wordApp, "<Texto8>", Rtxt1.Text);
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

            /*object ObjMiss = System.Reflection.Missing.Value;
            Word.Application ObjWord = new Word.Application();
            Word.Document ObjDoc = ObjWord.Documents.Add(ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss);
            ObjDoc.Activate();
            ObjWord.Selection.Font.Color = Word.WdColor.wdColorBlack;
            ObjWord.Selection.TypeText(comboBox1.Text);
           // ObjWord.Selection.TypeText(richTextBox1.Text);
            ObjWord.Visible = Visible;*/
            string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            
            createWordDocument(@"C:\Users\lirroy.coto\Downloads\Temp.docx", @"C:\Users\lirroy.coto\Documents\test.docx");
               

                 
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
            if (comboBox1.Text == "--Seleccionar--") {

                PnFormularios.Hide();
            }
            else {
                PnFormularios.Show();
                if (comboBox1.Text == "Reporte Electrico")
                {
                    txtContProElec.Show();
                    txtContProElec.Show();
                    txtUbProElec.Show();
                    txtAtenElec.Show();
                    txtAsunElec.Show();
                    Rtxt1.Show();
                }
                else
                {
                    txtContProElec.Hide();
                    txtContProElec.Hide();
                    txtUbProElec.Hide();
                    txtAtenElec.Hide();
                    txtAsunElec.Hide();
                    Rtxt1.Hide();
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
    }
}
