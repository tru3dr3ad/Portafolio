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
    public partial class InfStock : Form
    {
        public InfStock()
        {
            InitializeComponent();
        }

        private void InfStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsStockCategoria.CATEGORIA' Puede moverla o quitarla según sea necesario.
            this.CATEGORIATableAdapter.Fill(this.DsStockCategoria.CATEGORIA);

            this.reportViewer1.RefreshReport();
        }
    }
}
