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
    public partial class InfProductoMas : Form
    {
        public InfProductoMas()
        {
            InitializeComponent();
        }

        private void InfProductoMas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsProductoMas.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.PRODUCTOTableAdapter.Fill(this.DsProductoMas.PRODUCTO);

            this.reportViewer1.RefreshReport();
        }
    }
}
