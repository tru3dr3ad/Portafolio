﻿using Controlador;
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
        private void EliminarOrdenPedido()
        {
            if (_numeroOrdenSeleccionado != 0)
            {
                OrdenPedido orden = new OrdenPedido();
                bool estaGuardada = orden.OrdenPedidoGuardada(_numeroOrdenSeleccionado);
                if (estaGuardada)
                {
                    bool eliminarOrden = orden.EliminarOrdenPedido(_numeroOrdenSeleccionado);
                    if (eliminarOrden)
                    {
                        MessageBox.Show("Orden de pedido eliminada");
                        _numeroOrdenSeleccionado = 0;
                    }
                    else
                    {
                        MessageBox.Show("Orden de pedido no eliminada");
                        _numeroOrdenSeleccionado = 0;
                    }
                }
                else
                {
                    MessageBox.Show("La orden seleccionada ya ha sido enviada o recepcionada, no se puede eliminar.");
                }
            }
        }
        private void ModificarOrdenPedido()
        {
            if (_numeroOrdenSeleccionado != 0)
            {
                OrdenPedido orden = new OrdenPedido();
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
                    MessageBox.Show("La orden seleccionada ya ha sido enviada o recepcionada, no se puede modicar.");
                }
            }
        }
        public void RecepcionarOrden()
        {
            if (_numeroOrdenSeleccionado != 0)
            {
                OrdenPedido orden = new OrdenPedido();
                orden = orden.ObtenerOrdenPedido(_numeroOrdenSeleccionado);
                if (!orden.OrdenRecepcionada(orden))
                {
                    EstadoOrden estado = new EstadoOrden();
                    estado.Id = (int)cmbEstadoOrden.SelectedValue;
                    DateTime fechaRecepcion = DateTime.Now.Date;
                    orden.Estado = estado;
                    orden.FechaRecepcion = fechaRecepcion;
                    bool ordenRecepcionada = orden.RecepcionarOrdenPedido(orden);
                    if (ordenRecepcionada)
                    {
                        MessageBox.Show("Orden Recepcionada");
                        _numeroOrdenSeleccionado = 0;
                    }
                    else
                    {
                        MessageBox.Show("Orden no se ha recepcionado.");
                    }
                }
                else
                {
                    MessageBox.Show("La orden ya fue recepcionada");
                }
            }
        }
        public void DescargarOrdenPedido()
        {
            OrdenPedido orden = new OrdenPedido();
            orden = orden.ObtenerOrdenPedido(_numeroOrdenSeleccionado);
            if (!orden.OrdenRecepcionada(orden))
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
        }
        private void btnModificarOrden_Click(object sender, EventArgs e)
        {
            ModificarOrdenPedido();
        }
        private void btnEliminarOrden_Click(object sender, EventArgs e)
        {
            EliminarOrdenPedido();
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
