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
    public partial class frmPuntoVenta : Form
    {
        public frmPuntoVenta()
        {
            InitializeComponent();
            PersonalizarDiseño();
        }
        private void PersonalizarDiseño()
        {
            pnlPago.Visible = false;
            if (pnlPago.Visible == false)
            {
                pnlBoleta.Width = 550;
            }
            else if (pnlPago.Visible)
            {
                pnlBoleta.Width = 350;
            }
        }

        private void btnCancelarPago_Click(object sender, EventArgs e)
        {
            pnlPago.Visible = false;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            pnlPago.Visible = true;
        }
    }
}
