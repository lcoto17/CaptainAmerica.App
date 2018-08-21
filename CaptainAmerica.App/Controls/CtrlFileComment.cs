using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaptainAmerica.Model;

namespace CaptainAmerica.App.Controls
{
    public partial class CtrlFileComment : UserControl
    {
        public CtrlFileComment(ArchivoComentario otemp)
        {
            InitializeComponent();
            lblSummary.Text = string.Format(lblSummary.Text, otemp.Usuario.NombreUsuario, otemp.FechaCreacion.ToShortDateString());
            lblComment.Text = otemp.ArchivoComentarioDescr;
            
        }
    }
}
