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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
            CargarGrilla();
            CargarComboboxCategoria();
        }
        #region Metodos
        private void CargarGrilla()
        {
            Producto producto= new Producto();
            grdProducto.DataSource = producto.Listar();
        }
        private void CargarComboboxCategoria()
        {
            Controlador.Categoria categoria= new Controlador.Categoria();
            cmbCategoria.DataSource = categoria.Listar();
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.ValueMember = "Id";
        }
        public bool MostrarDatosProducto(int codigo)
        {
            Producto producto = new Producto();
            producto = producto.ObtenerProducto(codigo);
            if (producto != null)
            {
                txtCodigo.Text = producto.Codigo.ToString();
                txtNombre.Text = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion;
                txtPrecioVenta.Text = producto.PrecioVenta.ToString();
                txtPrecioCompra.Text = producto.PrecioCompra.ToString();
                dtpFechaVencimiento.Value = producto.FechaVencimiento;
                txtStock.Text = producto.Stock.ToString();
                txtStockCritico.Text = producto.StockCritico.ToString();
                cmbCategoria.SelectedValue = producto.Categoria.Id;

                return true;
            }
            else
            {
                return false;
            }
        }
        private void LimpiarDatos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecioVenta.Clear();
            txtPrecioCompra.Clear();
            dtpFechaVencimiento.Value = DateTime.Now;
            txtStock.Clear();
            txtStockCritico.Clear();
            cmbCategoria.SelectedIndex = 0;
        }
        #endregion

        #region Metodos de la clase
        private void BuscarProducto()
        {
            Producto producto= new Producto();
            if (!String.IsNullOrEmpty(txtBuscarProducto.Text))
            {
                bool existeProducto = producto.BuscarProducto(int.Parse(txtBuscarProducto.Text));
                if (existeProducto)
                {
                    MessageBox.Show("Producto encontrado");
                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                }
            }
        }
        public void AgregarProducto()
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text))
            {
                int codigo = int.Parse(txtCodigo.Text);
                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                int precioVenta = int.Parse(txtPrecioVenta.Text);
                int precioCompra = int.Parse(txtPrecioCompra.Text);
                DateTime fechaVencimiento = dtpFechaVencimiento.Value.Date;
                int stock = int.Parse(txtStock.Text);
                int stockCritico = int.Parse(txtStockCritico.Text);
                Categoria categoria = new Categoria();
                categoria.Id = (int)cmbCategoria.SelectedValue;
                Producto producto = new Producto(codigo, nombre, descripcion, precioVenta, precioCompra, stock, stockCritico,
                        fechaVencimiento, categoria);
                if (producto.AgregarProducto())
                {
                    MessageBox.Show("Producto ha sido agregado");
                }
            }
        }
        private void ModificarProducto()
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text))
            {
                int codigo = int.Parse(txtCodigo.Text);
                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                int precioVenta = int.Parse(txtPrecioVenta.Text);
                int precioCompra = int.Parse(txtPrecioCompra.Text);
                DateTime fechaVencimiento = dtpFechaVencimiento.Value.Date;
                int stock = int.Parse(txtStock.Text);
                int stockCritico = int.Parse(txtStockCritico.Text);
                Categoria categoria = new Categoria();
                categoria.Id = (int)cmbCategoria.SelectedValue;
                Producto producto = new Producto(codigo, nombre, descripcion, precioVenta, precioCompra, stock, stockCritico,
                        fechaVencimiento, categoria);
                bool modificarProducto = producto.ModificarProducto(producto);
                if (modificarProducto)
                {
                    MessageBox.Show("Producto Actualizado");
                }
                else
                {
                    MessageBox.Show("Producto no se ha actualizado");
                }
            }
        }
        private void EliminarProveedor()
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text))
            {
                Producto producto= new Producto();
                bool eliminarProducto = producto.EliminarProducto(int.Parse(txtCodigo.Text));
                if (eliminarProducto)
                {
                    MessageBox.Show("Producto eliminado");
                }
                else
                {
                    MessageBox.Show("Producto no eliminado");
                }
            }
        }
        #endregion

        #region Botones
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProducto();
            txtCodigo.Clear();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto();
            CargarGrilla();
            LimpiarDatos();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            ModificarProducto();
            CargarGrilla();
            LimpiarDatos();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarProveedor();
            CargarGrilla();
            LimpiarDatos();
        }
        #endregion

        #region MetodoGrilla
        private void grdProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int codigo = int.Parse(grdProducto.Rows[rowIndex].Cells[0].Value.ToString());
            MostrarDatosProducto(codigo);
        }
        #endregion
    }
}
