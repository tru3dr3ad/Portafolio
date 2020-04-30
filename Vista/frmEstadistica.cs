using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmEstadistica : Form
    {
        public frmEstadistica()
        {
            InitializeComponent();
            grpInforme.Visible = false;
            dgrInforme.Visible = false;
        }

        private void rdEstadistica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEstadistica.Checked)
            {
                grpEstadistica.Visible = true;
                grpInforme.Visible = false;
                chart.Visible = true;
                dgrInforme.Visible = false;
            }
            
            if (rdInforme.Checked)
            {
                grpEstadistica.Visible = false;
                grpInforme.Visible = true;
                chart.Visible = false;
                dgrInforme.Visible = true;
            }
        }
    }
}
