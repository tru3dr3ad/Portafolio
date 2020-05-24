using Controlador;
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
    public partial class frmFiado : Form
    {
        public frmFiado()
        {
            InitializeComponent();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            Boleta boleta = new Boleta();
            boleta.ProcedimientoDevuelveParametro();
        }
        //boleta.EjecutarSP();TODO
        //boleta.EjecutarConParametro(int.Parse(txtBuscarUsuario.Text));TODO        
    }
}
