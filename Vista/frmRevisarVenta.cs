using Controlador;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmRevisarVenta : Form
    {
        int _numeroBoletaSeleccionado = 0;
        public frmRevisarVenta()
        {
            InitializeComponent();
            CargarComboboxMedioPago();
            CargarComboboxUsuario();
            CargarGrilla();
        }

        #region Metodos
        private void CargarGrilla()
        {
            Boleta boleta = new Boleta();
            grdBoleta.DataSource = boleta.ListarBoletas();
            EsconderColumnasAutogeneradas();
        }
        private void CargarGrillaDetalleBoleta(int numeroBoleta)
        {
            DetalleBoleta detalle = new DetalleBoleta();
            grdDetalleBoleta.DataSource = detalle.ListarDetallePorBoleta(numeroBoleta);
            EsconderColumnasDetalle();
        }
        private void CargarComboboxMedioPago()
        {
            Controlador.MedioPago medioPago = new Controlador.MedioPago();
            cmbMedioPago.DisplayMember = "Descripcion";
            cmbMedioPago.ValueMember = "Id";
            cmbMedioPago.DataSource = medioPago.Listar();
        }
        private void CargarComboboxUsuario()
        {
            Controlador.Usuario usuario = new Controlador.Usuario();
            cmbVendedores.DisplayMember = "NombreUsuario";
            cmbVendedores.ValueMember = "RunUsuario";
            cmbVendedores.DataSource = usuario.ListarCombobox();
        }
        private void EsconderColumnasAutogeneradas()
        {
            grdBoleta.Columns["IDMEDIOPAGO"].Visible = false;
            grdBoleta.Columns["RUN_USUARIO"].Visible = false;
            grdBoleta.Columns["RUN_CLIENTE"].Visible = false;
            grdBoleta.Columns["IDESTADO"].Visible = false;
            //grdBoleta.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void EsconderColumnasDetalle()
        {
            grdDetalleBoleta.Columns["BOLETA_NUMEROBOLETA"].Visible = false;
            grdDetalleBoleta.Columns["PRODUCTO_CODIGO"].Visible = false;
            grdDetalleBoleta.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void BuscarBoletasPorNombreCliente()
        {
            string nombre = txtBuscarBoleta.Text.ToUpper();
            Boleta boleta = new Boleta();
            grdBoleta.DataSource = boleta.ListarBoletasPorNombreCliente(nombre);
            txtBuscarBoleta.Clear();
            EsconderColumnasAutogeneradas();
        }
        private void AnularBoleta()
        {
            Boleta boleta = new Boleta();
            bool boletaAnulada = boleta.AnularBoleta(_numeroBoletaSeleccionado);
            _numeroBoletaSeleccionado = 0;
        }
        #endregion

        #region Botones
        private void btnBuscarBoleta_Click(object sender, EventArgs e)
        {
            BuscarBoletasPorNombreCliente();
        }
        private void btnAnularBoleta_Click(object sender, EventArgs e)
        {
            AnularBoleta();
            CargarGrilla();
        }
        #endregion

        #region Eventos
        private void cmbMedioPago_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbMedioPago.SelectedValue != null)
            {
                Boleta boleta = new Boleta();
                grdBoleta.DataSource = boleta.ListarBoletasPorMedioPago((int)cmbMedioPago.SelectedValue);
                EsconderColumnasAutogeneradas();
            }
        }
        private void cmbVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedioPago.SelectedValue != null)
            {
                Boleta boleta = new Boleta();
                grdBoleta.DataSource = boleta.ListarBoletasPorUsuario((int)cmbVendedores.SelectedValue);
                EsconderColumnasAutogeneradas();
            }
        }
        #endregion

        private void grdBoleta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                _numeroBoletaSeleccionado = int.Parse(this.grdBoleta[0, e.RowIndex].Value.ToString());
                CargarGrillaDetalleBoleta(_numeroBoletaSeleccionado);
            }
        }

    }
}
