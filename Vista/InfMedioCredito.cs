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
    public partial class InfMedioCredito : Form
    {
        public InfMedioCredito()
        {
            InitializeComponent();
        }

        private void InfMedioCredito_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsMedioCredito.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DsMedioCredito.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
