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
    public partial class frmOrdenPedido : Form
    {
        string _codProductoSeleccionado = "";
        string _codProductoQuitar = "";
        public frmOrdenPedido()
        {
            InitializeComponent();
            PersonalizarDiseño();
            CargarComboboxProveedor();
            CargarComboboxCategoria();
            CargarGrillaProducto();
            CargarNumeroSiguienteOrden();
        }
        #region Metodos
        private void PersonalizarDiseño()
        {
            this.grdOrden.Columns["Codigo"].Visible = false;
        }
        private void CargarGrillaProducto()
        {
            Producto producto = new Producto();
            grdProducto.DataSource = producto.Listar();
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
        private void CargarNumeroSiguienteOrden()
        {
            OrdenPedido orden = new OrdenPedido();
            int numero = orden.ObtenerNumeroMaximoOrden();
            numero = numero + 1;
            txtNumeroOrden.Text = numero.ToString();
        }
        private void LimpiarDatos()
        {
            txtTotalOrden.Text = "0";
            txtRutProveedor.Clear();
            cmbCategoria.SelectedValue = 0;
            cmbProveedor.SelectedValue = 0;
            grdOrden.Rows.Clear();
        }
        private void LimpiarCantidad()
        {
            txtCantidad.Value = 0;
        }

        #endregion

        #region Metodos de la clase
        public void AgregarOrdenPedido()
        {
            if (int.Parse(txtTotalOrden.Text) > 0)
            {
                DateTime fechaCreacion = DateTime.Now.Date;
                int total = int.Parse(txtTotalOrden.Text);
                DateTime fechaRecepcion = DateTime.Now.Date;
                Proveedor proveedor = new Proveedor();
                proveedor.Rut = (int)cmbProveedor.SelectedValue;
                EstadoOrden estadoOrden = new EstadoOrden();
                estadoOrden.Id = 1;//<--debe ser No Recepcionada
                Usuario usuario = new Usuario();
                usuario.RunUsuario = 7769287;
                OrdenPedido orden = new OrdenPedido(fechaCreacion, total, fechaRecepcion, proveedor, estadoOrden, usuario);
                if (orden.AgregarOrdenPedido())
                {
                    int numeroOrden = orden.ObtenerNumeroMaximoOrden();
                    foreach (DataGridViewRow row in grdOrden.Rows)
                    {
                        string codigo = row.Cells[0].Value.ToString();
                        int cantidad = int.Parse(row.Cells[2].Value.ToString());
                        DetallePedido detalle = new DetallePedido(numeroOrden, codigo, cantidad);
                        detalle.AgregarDetallePedido();
                    }
                    MessageBox.Show("Orden de Pedido N°" + numeroOrden + " ha sido agregada.");
                }
            }
        }
        public void AgregarDetallePedido()
        {
            if (int.Parse(txtCantidad.Text) > 0)
            {
                int cantidad = int.Parse(txtCantidad.Text);
                Producto producto = new Producto();
                producto = producto.ObtenerProducto(_codProductoSeleccionado);
                if (producto != null)
                {
                    string nombreProducto = producto.Nombre;
                    int totalProductos = producto.PrecioCompra * cantidad;
                    int totalPedido = int.Parse(txtTotalOrden.Text);
                    totalPedido = totalPedido + totalProductos;
                    txtTotalOrden.Text = totalPedido.ToString();
                    grdOrden.Rows.Add(_codProductoSeleccionado, nombreProducto, cantidad, totalProductos);
                }
            }
        }
        private void QuitarDetallePedido()
        {
            if (_codProductoQuitar != "")
            {
                Producto producto = new Producto();
                int valorCompra = producto.ObtenerValorCompraProducto(_codProductoQuitar);
                int cantidad = int.Parse(grdOrden.Rows[grdOrden.CurrentRow.Index].Cells[2].Value.ToString());
                int totalBoleta = int.Parse(txtTotalOrden.Text);
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
        #endregion

        #region MetodosGrilla
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

        #region Botones
        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            AgregarOrdenPedido();
            LimpiarDatos();
            CargarNumeroSiguienteOrden();
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
        #endregion


        private void cmbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedValue != null)
            {
                Producto producto = new Producto();
                grdProducto.DataSource = producto.ListarPorCategoria((int)cmbCategoria.SelectedValue);
            }
        }
    }
}
