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
    public partial class InfClienteFrecuente : Form
    {
        public InfClienteFrecuente()
        {
            InitializeComponent();
        }

        private void InfClienteFrecuente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsClienteFrecuente.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.CLIENTETableAdapter.Fill(this.DsClienteFrecuente.CLIENTE);

            this.reportViewer1.RefreshReport();
        }
    }
}
