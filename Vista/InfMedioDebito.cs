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
    public partial class InfMedioDebito : Form
    {
        public InfMedioDebito()
        {
            InitializeComponent();
        }

        private void InfMedioDebito_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsMedioDebito.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DsMedioDebito.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
