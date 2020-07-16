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
    public partial class InfClienteDeuda : Form
    {
        public InfClienteDeuda()
        {
            InitializeComponent();
        }

        private void InfClienteDeuda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsClienteDeuda.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DsClienteDeuda.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
