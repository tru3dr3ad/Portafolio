using Microsoft.Reporting.WinForms;
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
    public partial class InfDelMes : Form
    {
        public InfDelMes()
        {
            InitializeComponent();
        }
        DateTime DESDE { get; set; }
        DateTime HASTA { get; set; }
        private void InfDelMes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsDelMes.BOLETA' Puede moverla o quitarla según sea necesario.
            this.BOLETATableAdapter.Fill(this.DsDelMes.BOLETA,DESDE,HASTA);
            this.reportViewer1.RefreshReport();
        }

        private void BUSCAR_Click(object sender, EventArgs e)
        {
            ReportParameter[] myPar = new ReportParameter[2];
            myPar[0] = new ReportParameter("DESDE", dtpDESDE.Text);
            myPar[1] = new ReportParameter("HASTA", dtpHASTA.Text);
            reportViewer1.LocalReport.SetParameters(myPar);
            reportViewer1.RefreshReport();
        }
    }
}
