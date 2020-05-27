using Controlador;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmRevisarVenta : Form
    {
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
        }
        #endregion

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
    }
}
