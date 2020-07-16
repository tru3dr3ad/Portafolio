using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmModificarOrdenPedido : Form
    {
        string _codProductoSeleccionado = "";
        string _codProductoQuitar = "";
        public frmModificarOrdenPedido()
        {
            InitializeComponent();
            CargarComboboxProveedor();
            CargarComboboxCategoria();
            CargarGrillaProducto();
        }

        #region Load Form
        private void frmModificarOrdenPedido_Load(object sender, EventArgs e)
        {
            CargarOrdenAModificar();
        }
        #endregion

        #region Metodos
        private void CargarGrillaProducto()
        {
            Producto producto = new Producto();
            grdProducto.DataSource = producto.ListarProductos();
            EsconderColumnasAutogeneradas();
            CambioNombreColumnaGrilla();
        }
        private void CargarGrillaDetalleOrdenYTotal(int numero)
        {
            DetallePedido detalle = new DetallePedido();
            List<V_DETALLE_ORDEN> listadoModelo = new List<V_DETALLE_ORDEN>();
            listadoModelo = detalle.ListarDetallePorOrden(numero);
            decimal totalPedido = 0;
            foreach (V_DETALLE_ORDEN item in listadoModelo)
            {
                string codigo = item.PRODUCTO_CODIGO;
                string nombre = item.NOMBRE;
                int cantidad = (int)item.CANTIDAD;
                decimal total = (decimal)item.TOTAL;
                totalPedido += total;
                grdOrden.Rows.Add(codigo, nombre, cantidad, total);
            }
            txtTotalOrden.Text = totalPedido.ToString();
        }
        private void CargarOrdenAModificar()
        {
            int numeroOrden = frmRevisarPedido.numeroOrdenModificar;
            OrdenPedido orden = new OrdenPedido();
            orden = orden.ObtenerOrdenPedido(numeroOrden);
            lblNumeroOrden.Text = numeroOrden.ToString("0000");
            cmbProveedor.SelectedValue = orden.Proveedor.Rut;
            CargarGrillaDetalleOrdenYTotal(numeroOrden);
        }
        private void CargarComboboxProveedor()
        {
            Controlador.Proveedor proveedor = new Controlador.Proveedor();
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Rut";
            cmbProveedor.DataSource = proveedor.ListarCombobox();
        }
        private void CargarComboboxCategoria()
        {
            Controlador.Categoria categoria = new Controlador.Categoria();
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DataSource = categoria.Listar();
        }
        private void CambioNombreColumnaGrilla()
        {
            grdProducto.Columns["PRECIO_COMPRA"].HeaderText = "PRECIO";
        }
        private void EsconderColumnasAutogeneradas()
        {
            grdOrden.Columns["Codigo"].Visible = false;
            grdProducto.Columns["PRECIO_VENTA"].Visible = false;
            grdProducto.Columns["STOCK"].Visible = false;
            grdProducto.Columns["STOCK_CRITICO"].Visible = false;
            grdProducto.Columns["FECHA_VENCIMIENTO"].Visible = false;
            grdProducto.Columns["IDCATEGORIA"].Visible = false;
            grdOrden.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void LimpiarCantidad()
        {
            txtCantidad.Value = 0;
        }
        
        #endregion

        #region Metodos de la clase
        private void BuscarProductoPorNombre()
        {
            string nombre = txtBuscarProducto.Text.ToUpper();
            Producto producto = new Producto();
            grdProducto.DataSource = producto.ListarProductosPorNombre(nombre);
            txtBuscarProducto.Clear();
            EsconderColumnasAutogeneradas();
        }
        public void AgregarDetallePedido()
        {
            if (int.Parse(txtCantidad.Text) > 0 && _codProductoSeleccionado != "")
            {
                if (!ValidarProductoLista(grdOrden))
                {
                    int cantidad = int.Parse(txtCantidad.Text);
                    Producto producto = new Producto();
                    producto = producto.ObtenerProducto(_codProductoSeleccionado);
                    if (producto != null)
                    {
                        string nombreProducto = producto.Nombre;
                        decimal totalProductos = producto.PrecioCompra * cantidad;
                        decimal totalPedido = decimal.Parse(txtTotalOrden.Text);
                        totalPedido = totalPedido + totalProductos;
                        txtTotalOrden.Text = totalPedido.ToString();
                        grdOrden.Rows.Add(_codProductoSeleccionado, nombreProducto, cantidad, totalProductos);
                        _codProductoSeleccionado = "";
                    }
                }
                else
                {
                    MessageBox.Show("Ya lleva de ese producto, por favor quitelo y vuelva a agregarlo si desea canbiar la cantidad.");
                }
            }
        }
        private void QuitarDetallePedido()
        {
            if (_codProductoQuitar != "")
            {
                Producto producto = new Producto();
                decimal valorCompra = producto.ObtenerValorCompraProducto(_codProductoQuitar);
                decimal cantidad = decimal.Parse(grdOrden.Rows[grdOrden.CurrentRow.Index].Cells[2].Value.ToString());
                decimal totalBoleta = decimal.Parse(txtTotalOrden.Text);
                totalBoleta = totalBoleta - (valorCompra * cantidad);
                txtTotalOrden.Text = totalBoleta.ToString();

                grdOrden.Rows.Remove(grdOrden.CurrentRow);
                _codProductoQuitar = "";
            }
            else
            {
                MessageBox.Show("Debes seleccionar el producto a quitar");
            }
        }
        public void ModificarOrdenPedido()
        {
            if (decimal.Parse(txtTotalOrden.Text) > 0)
            {
                int numeroOrden = int.Parse(lblNumeroOrden.Text);
                decimal total = decimal.Parse(txtTotalOrden.Text);
                Proveedor proveedor = new Proveedor();
                proveedor.Rut = (int)cmbProveedor.SelectedValue;
                EstadoOrden estadoOrden = new EstadoOrden();
                estadoOrden.Id = 1;//<--debe ser No Recepcionada
                Usuario usuario = new Usuario();
                usuario.RunUsuario = Global.RunUsuarioActivo;
                OrdenPedido orden = new OrdenPedido(numeroOrden, total, proveedor, estadoOrden, usuario);
                if (orden.ModificarOrdenPedido(orden))
                {
                    DetallePedido detalle = new DetallePedido();
                    bool eliminarDetalleAnteriores = detalle.EliminarDetalleEnCascada(numeroOrden);
                    if (eliminarDetalleAnteriores)
                    {
                        foreach (DataGridViewRow row in grdOrden.Rows)
                        {
                            string codigo = row.Cells[0].Value.ToString();
                            int cantidad = int.Parse(row.Cells[2].Value.ToString());
                            detalle.NumeroOrden = numeroOrden;
                            detalle.CodigoProducto = codigo;
                            detalle.Cantidad = cantidad;
                            detalle.AgregarDetallePedido();
                        }
                        MessageBox.Show("Orden de Pedido N°" + numeroOrden + " ha sido modificada.");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Problema al eliminar detalles anteriores");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar al menos un producto para realizar la orden.");
            }
        }
        private bool ValidarProductoLista(DataGridView grdOrden)
        {
            foreach (DataGridViewRow row in grdOrden.Rows)
            {
                if (grdOrden.Rows[row.Index].Cells[0].Value.ToString() == _codProductoSeleccionado)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Botones
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProductoPorNombre();
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarDetallePedido();
            LimpiarCantidad();
        }
        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            QuitarDetallePedido();
        }
        private void btnModificarOrden_Click(object sender, EventArgs e)
        {
            ModificarOrdenPedido();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string rutaAyuda = @"\Ayuda\Ayuda.chm";
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string ayudaPath = projectDirectory + rutaAyuda;
            Help.ShowHelp(this, ayudaPath, "Revision.htm");
        }

        #endregion

        #region Eventos
        private void cmbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedValue != null)
            {
                Producto producto = new Producto();
                grdProducto.DataSource = producto.ListarProductosPorCategoria((int)cmbCategoria.SelectedValue);
                EsconderColumnasAutogeneradas();
            }
        }
        private void cmbProveedor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedValue != null)
            {
                Proveedor proveedor = new Proveedor();
                proveedor = proveedor.ObtenerProveedor((int)cmbProveedor.SelectedValue);
                string rut = (cmbProveedor.SelectedValue.ToString()) + "-" + proveedor.Dv.ToString();
                txtRutProveedor.Text = rut;
            }
        }
        #endregion

        #region Metodos Grilla
        private void grdProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string codigo = this.grdProducto[0, e.RowIndex].Value.ToString();
                _codProductoSeleccionado = codigo;
            }
        }
        private void grdOrden_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string codigo = this.grdOrden[0, e.RowIndex].Value.ToString();
                _codProductoQuitar = codigo;
            }
        }
        #endregion

        
    }
}
