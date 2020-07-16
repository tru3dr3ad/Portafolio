﻿using Controlador;
using System;
using System.IO;
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
            CambioNombreColumnaGrilla();
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
            grdDetalleBoleta.Columns["IDDETALLEB"].Visible = false;
            grdDetalleBoleta.Columns["BOLETA_NUMEROBOLETA"].Visible = false;
            grdDetalleBoleta.Columns["PRODUCTO_CODIGO"].Visible = false;
            grdDetalleBoleta.Columns["NOMBRE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        #endregion

        #region Metodos de la clase
        private void BuscarBoletasPorNombreCliente()
        {
            if (!String.IsNullOrEmpty(txtBuscarBoleta.Text))
            {
                int numero = int.Parse(txtBuscarBoleta.Text);
                Boleta boleta = new Boleta();
                grdBoleta.DataSource = boleta.ListarBoletasPorNumeroBoleta(numero);
                txtBuscarBoleta.Clear();
                EsconderColumnasAutogeneradas();
            }
        }
        private void AnularBoleta()
        {
            Boleta boleta = new Boleta();
            if (_numeroBoletaSeleccionado > 0)
            {
                boleta = boleta.ObtenerBoleta(_numeroBoletaSeleccionado);
                if (!boleta.BoletaAnulada(boleta))
                {
                    DetalleBoleta detalle = new DetalleBoleta();
                    Cliente cliente = new Cliente();
                    cliente = cliente.ObtenerCliente(boleta.Cliente.Run);
                    bool agregarStock = detalle.AgregarStockBoletaAnulada(_numeroBoletaSeleccionado);
                    if (agregarStock)
                    {
                        bool boletaAnulada = boleta.AnularBoleta(_numeroBoletaSeleccionado);
                        if (boletaAnulada)
                        {
                            MessageBox.Show("La boleta N°" + _numeroBoletaSeleccionado + " se ha anulado.");
                            _numeroBoletaSeleccionado = 0;
                        }
                        //Ojo! este metodo cambia el estado del fiador en caso de que la boleta se anule, de DEBE a NODEBE
                        if (cliente.Estado.Id == 2)
                        {
                            cliente.CambiarEstadoDeudaPagada(cliente.Run);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al anular boleta.");
                    }
                }
                else
                {
                    MessageBox.Show("Boleta seleccionada ya se encuentra anulada.");
                }
                _numeroBoletaSeleccionado = 0;
            }
            else
            {
                MessageBox.Show("No hay ninguna boleta seleccionada para anular.");
            }
        }
        private void LimpiarGrillaDetalle()
        {
            grdDetalleBoleta.Columns.Clear();
        }
        private void CambioNombreColumnaGrilla()
        {
            grdBoleta.Columns["NUMERO"].HeaderText = "N°";
            grdBoleta.Columns["FECHA_CREACION"].HeaderText = "FECHA VENTA";
            grdBoleta.Columns["MEDIO_PAGO"].HeaderText = "MEDIO PAGO";
            grdBoleta.Columns["NOMBRE_CLIENTE"].HeaderText = "CLIENTE";
            grdBoleta.Columns["NOMBRE_VENDEDOR"].HeaderText = "VENDEDOR";
            grdBoleta.Columns["DESCRIPCION"].HeaderText = "ESTADO";
        }
        #endregion

        #region Botones
        private void btnBuscarBoleta_Click(object sender, EventArgs e)
        {
            BuscarBoletasPorNombreCliente();
            LimpiarGrillaDetalle();
        }
        private void btnAnularBoleta_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Si la boleta que desea anular ha sido generada en esta ultima instancia, se le solicita que reinicie la aplicacion. Si ya ha reiniciado la aplicación, presione 'Si'. Para cancelar presionar 'No'.", "Antes de Anular Boleta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                AnularBoleta();
                CargarGrilla();
                LimpiarGrillaDetalle();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string rutaAyuda = @"\Ayuda\Ayuda.chm";
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string ayudaPath = projectDirectory + rutaAyuda;
            Help.ShowHelp(this, ayudaPath, "Revisar Ventas.htm");
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
                LimpiarGrillaDetalle();
            }
        }
        private void cmbVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedioPago.SelectedValue != null)
            {
                Boleta boleta = new Boleta();
                grdBoleta.DataSource = boleta.ListarBoletasPorUsuario((int)cmbVendedores.SelectedValue);
                EsconderColumnasAutogeneradas();
                LimpiarGrillaDetalle();
            }
        }
        private void txtBuscarBoleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

        #region Evento Grilla
        private void grdBoleta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                _numeroBoletaSeleccionado = int.Parse(this.grdBoleta[0, e.RowIndex].Value.ToString());
                CargarGrillaDetalleBoleta(_numeroBoletaSeleccionado);
            }
        }
        #endregion


    }
}
