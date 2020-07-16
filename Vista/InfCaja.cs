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
    public partial class InfCaja : Form
    {
        public InfCaja()
        {
            InitializeComponent();
        }
        DateTime Fecha { get; set; }
        private void InfCaja_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsCaja.BOLETA' Puede moverla o quitarla según sea necesario.
            this.BOLETATableAdapter.Fill(this.DsCaja.BOLETA,Fecha);
            // TODO: esta línea de código carga datos en la tabla 'DsCaja.BOLETA' Puede moverla o quitarla según sea necesario.

            this.reportViewer1.RefreshReport();
        }

        private void BUSCAR_Click(object sender, EventArgs e)
        {
            ReportParameter myPar = new ReportParameter("Fecha", dtpFecha.Text);
            reportViewer1.LocalReport.SetParameters(myPar);
            reportViewer1.RefreshReport();
        }
    }
}
