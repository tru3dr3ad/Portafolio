using Controlador;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmFiado : Form
    {
        int _numeroBoleta = 0;
        public frmFiado()
        {
            InitializeComponent();
            CargarComboboxCliente();
            CargarGrillaVentasFiadas();
        }

        #region Metodos
        private void CargarGrillaVentasFiadas()
        {
            Boleta boleta = new Boleta();
            grdVentaFiadas.DataSource = boleta.ListarBoletasPorMedioPago(4);
            OcultarColumnasAutogeneradas();
        }
        private void CargarGrillaAbonoPorBoleta(int nroBoleta)
        {
            Abono abono = new Abono();
            grdAbono.DataSource = abono.ListarAbonosPorBoleta(nroBoleta);
            LlenarColumnaGrillaDetalle();
        }
        private void LlenarColumnaGrillaDetalle()
        {
            grdAbono.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void OcultarColumnasAutogeneradas()
        {
            grdVentaFiadas.Columns["RUN_USUARIO"].Visible = false;
            grdVentaFiadas.Columns["RUN_CLIENTE"].Visible = false;
            grdVentaFiadas.Columns["IDMEDIOPAGO"].Visible = false;
            grdVentaFiadas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void CargarComboboxCliente()
        {
            Controlador.Cliente cliente = new Controlador.Cliente();
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Run";
            cmbCliente.DataSource = cliente.ListarCombobox();
        }
        public void MostrarDeuda(int numeroBoleta)
        {
            Abono abono = new Abono();
            int deuda = abono.ObtenerDeuda(numeroBoleta);
            txtDeuda.Text = deuda.ToString();
        }
        private void DatosClienteBoleta(int nroBoleta)
        {
            Boleta boleta = new Boleta();
            boleta = boleta.ObtenerBoleta(nroBoleta);
            txtRunCliente.Text = boleta.Cliente.Run.ToString();
            cmbCliente.SelectedValue = boleta.Cliente.Run;
        }
        private void LimpiarGrillaAbono()
        {
            grdAbono.DataSource = null;
        }
        #endregion

        #region Metodos de la clase
        public void BuscarBoletasPorNombreCliente()
        {
            string nombre = txtBuscarUsuario.Text.ToUpper();
            Boleta boleta = new Boleta();
            if (nombre == "")
            {
                grdVentaFiadas.DataSource = boleta.ListarBoletasPorMedioPago(4);
            }
            else
            {
                grdVentaFiadas.DataSource = boleta.ListarBoletasPorNombreClienteFiador(nombre);
            }
            txtBuscarUsuario.Clear();
            OcultarColumnasAutogeneradas();
        }
        public void AgregarAbono()
        {
            if (int.Parse(txtMontoAbono.Text) <= int.Parse(txtDeuda.Text))
            {
                DateTime fechaAbono = DateTime.Now.Date;
                int montoAbono = int.Parse(txtMontoAbono.Text);
                Boleta boleta = new Boleta();
                boleta = boleta.ObtenerBoleta(_numeroBoleta);
                DateTime fechaLimite = boleta.FechaCreacion.AddMonths(1);

                Abono abono = new Abono(boleta, montoAbono, fechaAbono, fechaLimite);
                if (abono.AgregarAbono())
                {
                    int idAbono = abono.ObtenerIdMaximoAbono();
                    CargarGrillaAbonoPorBoleta(boleta.Numero);
                    MessageBox.Show("Abono N°" + idAbono + " agregado.");
                    _numeroBoleta = 0;
                }
            }
            else
            {
                MessageBox.Show("Monto del abono no puede ser mayor a lo adeudado.");
            }
            _numeroBoleta = 0;
        }
        #endregion

        #region Botones
        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            BuscarBoletasPorNombreCliente();
            LimpiarGrillaAbono();
        }
        private void btnAgregarAbono_Click(object sender, EventArgs e)
        {
            AgregarAbono();
            txtDeuda.Clear();
            txtMontoAbono.Clear();
        }
        #endregion

        #region Eventos
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
        private void cmbCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue != null)
            {
                Boleta boleta = new Boleta();
                grdVentaFiadas.DataSource = boleta.ListarBoletasPorClienteFiador((int)cmbCliente.SelectedValue);
                txtRunCliente.Text = cmbCliente.SelectedValue.ToString();
                LimpiarGrillaAbono();
            }
        }
        #endregion

        #region Metodos Grilla
        private void grdVentaFiadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex > -1)
            {
                _numeroBoleta = int.Parse(grdVentaFiadas.Rows[rowIndex].Cells[0].Value.ToString());
                MostrarDeuda(_numeroBoleta);
                DatosClienteBoleta(_numeroBoleta);
                CargarGrillaAbonoPorBoleta(_numeroBoleta);
            }
        }
        #endregion

    }
}
