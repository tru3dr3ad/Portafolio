using Controlador;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmRevisarPedido : Form
    {
        int _numeroOrdenSeleccionado = 0;

        public frmRevisarPedido()
        {
            InitializeComponent();
            CargarComboboxEstadoOrden();
            CargarComboboxProveedor();
            CargarGrillaOrden();
        }

        #region Metodos
        private void CargarGrillaOrden()
        {
            OrdenPedido orden = new OrdenPedido();
            grdOrden.DataSource = orden.ListarOrdenPedido();
            EsconderColumnasAutogeneradas();
            CambioNombreColumnaGrillaOrden();
        }
        private void CargarGrillaDetalleOrden(int numero)
        {
            DetallePedido detalle = new DetallePedido();
            grdDetalleOrden.DataSource = detalle.ListarDetallePorOrden(numero);
            EsconderColumnasDetalle();
        }
        private void CargarComboboxEstadoOrden()
        {
            Controlador.EstadoOrden estadoOrden = new Controlador.EstadoOrden();
            cmbEstadoOrden.DisplayMember = "Descripcion";
            cmbEstadoOrden.ValueMember = "Id";
            cmbEstadoOrden.DataSource = estadoOrden.Listar();
        }
        private void CargarComboboxProveedor()
        {
            Controlador.Proveedor proveedor = new Controlador.Proveedor();
            cmbProveedores.DisplayMember = "Nombre";
            cmbProveedores.ValueMember = "Rut";
            cmbProveedores.DataSource = proveedor.ListarCombobox();
        }
        private void LimpiarDatos()
        {
            txtBuscarOrden.Clear();
            cmbProveedores.SelectedIndex = 0;
            cmbEstadoOrden.SelectedIndex = 0;
        }
        private void LimpiarGrillaDetalle()
        {
            grdDetalleOrden.Columns.Clear();
        }
        private void EsconderColumnasAutogeneradas()
        {
            grdOrden.Columns["PROVEEDOR_RUT"].Visible = false;
            grdOrden.Columns["IDESTADO"].Visible = false;
        }
        private void EsconderColumnasDetalle()
        {
            grdDetalleOrden.Columns["ORDEN_PEDIDO_NUMEROORDEN"].Visible = false;
            grdDetalleOrden.Columns["IDDETALLEO"].Visible = false;
            grdDetalleOrden.Columns["PRODUCTO_CODIGO"].Visible = false;
            grdDetalleOrden.Columns["NOMBRE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void CambioNombreColumnaGrillaOrden()
        {
            grdOrden.Columns["NUMERO"].HeaderText = "N°";
            grdOrden.Columns["FECHA_CREACION"].HeaderText = "FECHA CREACION";
            grdOrden.Columns["FECHA_RECEPCION"].HeaderText = "FECHA RECEPCION";
            grdOrden.Columns["ESTADO_ORDEN"].HeaderText = "ESTADO";
        }
        #endregion

        #region Metodos de la clase

        private void BuscarOrdenPedidoPorNumero()
        {
            OrdenPedido orden = new OrdenPedido();
            if (txtBuscarOrden.Text != "")
            {
                int nroOrden = int.Parse(txtBuscarOrden.Text);
                grdOrden.DataSource = orden.ListarOrdenPedidoPorNumero(nroOrden);
                txtBuscarOrden.Clear();
                EsconderColumnasAutogeneradas();
            }
            else
            {
                CargarGrillaOrden();
            }
        }
        private void AnularOrdenPedido()
        {
            if (_numeroOrdenSeleccionado != 0)
            {
                OrdenPedido orden = new OrdenPedido();
                orden = orden.ObtenerOrdenPedido(_numeroOrdenSeleccionado);
                EstadoOrden estado = new EstadoOrden();
                estado = estado.ObtenerEstadoOrden(orden.Estado.Id);
                string descripcion = estado.Descripcion;
                bool estaGuardada = orden.OrdenPedidoGuardada(_numeroOrdenSeleccionado);
                if (estaGuardada)
                {
                    bool anularOrden = orden.AnularOrdenPedido(_numeroOrdenSeleccionado);
                    if (anularOrden)
                    {
                        MessageBox.Show("Orden de pedido anulada");
                        _numeroOrdenSeleccionado = 0;
                    }
                    else
                    {
                        MessageBox.Show("Orden de pedido no ha sido anulada");
                        _numeroOrdenSeleccionado = 0;
                    }
                }
                else
                {
                    MessageBox.Show("La orden seleccionada se encuentra " + descripcion + ", no se puede anular.");
                }
            }
        }
        private void ModificarOrdenPedido()
        {
            if (_numeroOrdenSeleccionado != 0)
            {
                OrdenPedido orden = new OrdenPedido();
                orden = orden.ObtenerOrdenPedido(_numeroOrdenSeleccionado);
                EstadoOrden estado = new EstadoOrden();
                estado = estado.ObtenerEstadoOrden(orden.Estado.Id);
                string descripcion = estado.Descripcion;
                bool estaGuardada = orden.OrdenPedidoGuardada(_numeroOrdenSeleccionado);
                if (estaGuardada)
                {
                    frmModificarOrdenPedido form = new frmModificarOrdenPedido();
                    form.ShowDialog();
                    //_numeroOrdenSeleccionado = 0;
                    //formOrdenPedido.
                }
                else
                {
                    MessageBox.Show("La orden seleccionada se encuentra "+ descripcion + ", no se puede modicar.");
                }
            }
        }
        public void RecepcionarOrden()
        {
            if (_numeroOrdenSeleccionado != 0)
            {
                OrdenPedido orden = new OrdenPedido();
                orden = orden.ObtenerOrdenPedido(_numeroOrdenSeleccionado);

                EstadoOrden estado = new EstadoOrden();
                estado = estado.ObtenerEstadoOrden(orden.Estado.Id);
                string descripcion = estado.Descripcion;
                if (orden.OrdenPedidoEnviada(orden))
                {
                    estado.Id = (int)cmbEstadoOrden.SelectedValue;
                    if (estado.Id != 1)
                    {
                        if (estado.Id != 2)
                        {
                            if (estado.Id != 6)
                            {
                                DateTime fechaRecepcion = DateTime.Now.Date;
                                orden.Estado = estado;
                                orden.FechaRecepcion = fechaRecepcion;
                                if (estado.Id == 4)
                                {
                                    bool ordenRecepcionada = orden.RecepcionarOrdenPedido(orden);
                                    DetallePedido detalle = new DetallePedido();
                                    bool stockAgregado = detalle.AgregarStockOrdenRecepcionada(orden.Numero);
                                    if (stockAgregado && ordenRecepcionada)
                                    {
                                        LimpiarGrillaDetalle();
                                        MessageBox.Show("Se ha recepcionado y agregado el stock correctamente.");
                                        _numeroOrdenSeleccionado = 0;
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se ha podido agregar la recepcion.");
                                    }
                                }
                                else if (estado.Id == 3 || estado.Id == 5)
                                {
                                    bool ordenRecepcionada = orden.RecepcionarOrdenPedido(orden);
                                    if (ordenRecepcionada)
                                    {
                                        LimpiarGrillaDetalle();
                                        MessageBox.Show("Se ha guardado la recepcion de la orden de pedido.");
                                        _numeroOrdenSeleccionado = 0;
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se ha guardado la recepcion.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se puede anular la orden desde aqui, intente con el boton anular.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La orden ya ha sido enviada");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La orden de pedido ya ha sido enviada, no puede volver a estado guardada.");
                    }
                }
                else
                {
                    MessageBox.Show("La orden seleccionada se encuentra "+ descripcion + " , no se puede recepcionar.");
                }
            }
        }
        public void DescargarOrdenPedido()
        {
            OrdenPedido orden = new OrdenPedido();
            orden = orden.ObtenerOrdenPedido(_numeroOrdenSeleccionado);
            if (orden.OrdenPedidoGuardada(orden.Numero))
            {
                bool estaDescargada = orden.DescargarOrdenPedido(_numeroOrdenSeleccionado);
                if (estaDescargada)
                {
                    MessageBox.Show("Orden Descargada");
                }
                else
                {
                    MessageBox.Show("Orden no se ha podido descargar");
                }
            }
            else
            {
                MessageBox.Show("La orden ya fue recepcionada");
            }
        }
        #endregion

        #region Botones
        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            BuscarOrdenPedidoPorNumero();
            LimpiarGrillaDetalle();
        }
        private void btnModificarOrden_Click(object sender, EventArgs e)
        {
            ModificarOrdenPedido();
        }
        private void btnAnularOrden_Click(object sender, EventArgs e)
        {
            AnularOrdenPedido();
            CargarGrillaOrden();
            LimpiarDatos();
        }
        private void btnRecepcionar_Click(object sender, EventArgs e)
        {
            RecepcionarOrden();
            CargarGrillaOrden();
        }
        private void btnDescargarOrden_Click(object sender, EventArgs e)
        {
            DescargarOrdenPedido();
            CargarGrillaOrden();
        }
        #endregion

        #region MetodoGrilla
        private void grdOrden_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                _numeroOrdenSeleccionado = int.Parse(this.grdOrden[0, e.RowIndex].Value.ToString());
                CargarGrillaDetalleOrden(_numeroOrdenSeleccionado);
            }
        }
        #endregion

        #region Eventos
        private void cmbProveedores_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbProveedores.SelectedValue != null)
            {
                OrdenPedido ordenPedido = new OrdenPedido();
                grdOrden.DataSource = ordenPedido.ListarOrdenPedidoPorProveedor((int)cmbProveedores.SelectedValue);
                LimpiarGrillaDetalle();
                EsconderColumnasAutogeneradas();
            }
        }

        #endregion

        
    }
}
