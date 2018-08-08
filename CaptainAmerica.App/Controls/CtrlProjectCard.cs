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
        public CtrlProjectCard()
        {
            InitializeComponent();
        }

        public CtrlProjectCard(string projectName, string clientName, string projectCategory, DateTime projectCreateDate, int id )
        {
            InitializeComponent();

            lblProject.Text = projectName;
            lblClient.Text = clientName;
            lblProjectCreateDate.Text = projectCreateDate.ToShortDateString();
            this.Tag = id;
            imgElectric.Visible = projectCategory == "Eléctrico";
            imgMecanic.Visible = projectCategory == "Mecánico";
        }
    }
}
