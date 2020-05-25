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
            CargarGrillaVentasFiadas();
            CargarComboboxCliente();
        }
        private void CargarGrillaVentasFiadas()
        {
            Boleta boleta = new Boleta(); 
            grdVentaFiadas.DataSource = boleta.ListarPorMedioPago(4);
        }
        private void CargarComboboxCliente()
        {
            Controlador.Cliente cliente = new Controlador.Cliente();
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Run";
            cmbCliente.DataSource = cliente.ListarCombobox();
        }

        private void cmbCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue != null)
            {
                Boleta boleta = new Boleta();
                grdVentaFiadas.DataSource = boleta.ListarPorClienteFiados((int)cmbCliente.SelectedValue);
            }
        }

        private void grdVentaFiadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int numeroBoleta = int.Parse(grdVentaFiadas.Rows[rowIndex].Cells[0].Value.ToString());
            MostrarDeuda(numeroBoleta);
        }
        
        public bool MostrarDeuda(int numeroBoleta)
        {
            Boleta boleta = new Boleta();
            boleta = boleta.ObtenerBoleta(numeroBoleta);
            if (boleta != null)
            {
                txtRunCliente.Text = boleta.Cliente.Run.ToString();
                txtDeuda.Text = boleta.Valor.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void rdbDeudaTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDeudaTotal.Checked)
            {
                txtMontoAbono.Enabled = false;
                txtMontoAbono.Text = txtDeuda.Text;
            }
        }

        private void rdbDeudaParcial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDeudaParcial.Checked)
            {
                txtMontoAbono.Enabled = true;
            }
        }

        //boleta.EjecutarSP();TODO
        //boleta.EjecutarConParametro(int.Parse(txtBuscarUsuario.Text));TODO        
        //boleta.ProcedimientoDevuelveParametro();TODO
    }
}
