using Controlador;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmProducto : Form
    {
        private string Path = @"C:\Users\krist\Desktop\LosyuyitosWEB\core\static\core\img\";
        public frmProducto()
        {
            InitializeComponent();
            CargarComboboxCategoria();
            CargarComboboxProveedorId();
            CargarGrilla();
            MostrarVistaVendedor();
        }

        #region Metodos
        private void CargarGrilla()
        {
            Producto producto = new Producto();
            grdProducto.DataSource = producto.ListarProductos();
            EsconderColumnasAutogeneradas();
            CambioNombreColumnaGrilla();
        }
        private void CambiarColorProductoSinStock()
        {
            foreach (DataGridViewRow row in grdProducto.Rows)
            {
                if (int.Parse(row.Cells[5].Value.ToString()) == 0)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                    row.DefaultCellStyle.SelectionForeColor = Color.Red;
                }
            }
        }
        private void EsconderColumnasAutogeneradas()
        {
            grdProducto.Columns["IDCATEGORIA"].Visible = false;
        }
        private void CargarComboboxCategoria()
        {
            Controlador.Categoria categoria = new Controlador.Categoria();
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DataSource = categoria.Listar();
        }
        private void CargarComboboxProveedorId()
        {
            Controlador.Proveedor proveedor = new Controlador.Proveedor();
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "IdProveedor";
            cmbProveedor.DataSource = proveedor.ListarComboboxId();
        }
        public bool MostrarDatosProducto(string codigo)
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
                FileStream fs = new FileStream(Path + codigo + ".jpg", FileMode.Open, FileAccess.Read);
                picFoto.Image = Image.FromStream(fs);
                fs.Close();
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
            picFoto.Image = null;
        }
        public int NumeroRandom(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private string GenerarCodigoProducto()
        {
            string idProveedor = cmbProveedor.SelectedValue.ToString();
            int formatoCategoria = (int)cmbCategoria.SelectedValue;
            string idCategoria = formatoCategoria.ToString("000");
            string fechaVencimiento = dtpFechaVencimiento.Value.ToString("ddmmyyyy");
            if (DateTime.Now.Date == dtpFechaVencimiento.Value.Date)
            {
                fechaVencimiento = "00000000";
            }
            int idSecuencial = NumeroRandom(100, 999);
            string codigoProducto = idProveedor + idCategoria + fechaVencimiento + idSecuencial;
            return codigoProducto;
        }
        private string ValidarIngresoProducto()
        {
            string mensajeError = string.Empty;
            Validaciones validaciones = new Validaciones();
            if (dtpFechaVencimiento.Value.Date >= DateTime.Now.Date)
            {
                if (validaciones.ValidarLargoString(3, 70, txtNombre.Text))
                {
                    if (validaciones.ValidarLargoString(3, 70, txtDescripcion.Text))
                    {
                        if (!String.IsNullOrWhiteSpace(txtPrecioVenta.Text))
                        {
                            if (!String.IsNullOrWhiteSpace(txtPrecioCompra.Text))
                            {
                                int precioVenta = int.Parse(txtPrecioVenta.Text);
                                int precioCompra = int.Parse(txtPrecioCompra.Text);
                                if (validaciones.ValidarMayorACero(precioVenta, precioCompra))
                                {
                                    if (!String.IsNullOrWhiteSpace(txtStock.Text))
                                    {
                                        if (!String.IsNullOrWhiteSpace(txtStockCritico.Text))
                                        {
                                            if (validaciones.ValidarMayorACero(int.Parse(txtStock.Text), 0))
                                            {
                                                if (validaciones.ValidarMayorACero(int.Parse(txtStockCritico.Text), 0))
                                                {
                                                    return mensajeError;
                                                }
                                                else
                                                {
                                                    mensajeError = "El stock critico debe ser mayor a 0";
                                                }
                                            }
                                            else
                                            {
                                                mensajeError = "El stock debe ser mayor a 0";
                                            }
                                        }
                                        else
                                        {
                                            mensajeError = "El stock critico esta vacio. Por favor rellene.";
                                        }
                                    }
                                    else
                                    {
                                        mensajeError = "El stock esta vacio. Por favor rellene.";
                                    }
                                }
                                else
                                {
                                    mensajeError = "Precio de venta no puede ser menor al precio de compra.";
                                }
                            }
                            else
                            {
                                mensajeError = "Precio de compra esta vacio.";
                            }
                        }
                        else
                        {
                            mensajeError = "Precio de venta esta vacio.";
                        }
                    }
                    else
                    {
                        mensajeError = "Largo de descripcion invalido";
                    }
                }
                else
                {
                    mensajeError = "Largo de nombre invalido";
                }
            }
            else
            {
                mensajeError = "Fecha de vencimiento no puede ser menor a hoy";
            }
            return mensajeError;
        }
        private void CambioNombreColumnaGrilla()
        {
            grdProducto.Columns["PRECIO_VENTA"].HeaderText = "PRECIO VENTA";
            grdProducto.Columns["PRECIO_COMPRA"].HeaderText = "PRECIO COMPRA";
            grdProducto.Columns["STOCK_CRITICO"].HeaderText = "STOCK CRITICO";
            grdProducto.Columns["FECHA_VENCIMIENTO"].HeaderText = "FECHA VENCIMIENTO";

            //grdProducto.Columns["PRECIO_VENTA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void MostrarVistaVendedor()
        {
            Usuario usuario = new Usuario();
            bool esVendedor = usuario.esVendedor(Global.RunUsuarioActivo);
            if (esVendedor)
            {
                grpProducto.Visible = false;
                btnAbrir.Visible = false;
                picFoto.Visible = false;
                btnAgregarProducto.Visible = false;
                btnModificarProducto.Visible = false;
                btnEliminarProducto.Visible = false;
            }
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
        private void AgregarProducto()
        {
            string msgEsValido = ValidarIngresoProducto();
            if (string.IsNullOrEmpty(msgEsValido))
            {
                if (picFoto.Image != null)
                {
                    string codigo = GenerarCodigoProducto();
                    string nombre = txtNombre.Text.ToUpper();
                    string descripcion = txtDescripcion.Text.ToUpper();
                    int precioVenta = int.Parse(txtPrecioVenta.Text);
                    int precioCompra = int.Parse(txtPrecioCompra.Text);
                    DateTime fechaVencimiento = dtpFechaVencimiento.Value.Date;
                    int stock = int.Parse(txtStock.Text);
                    int stockCritico = int.Parse(txtStockCritico.Text);
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)cmbCategoria.SelectedValue;
                    picFoto.Image.Save(Path + codigo + ".jpg", ImageFormat.Png);
                    Producto producto = new Producto(codigo, nombre, descripcion, precioVenta, precioCompra, stock, stockCritico,
                            fechaVencimiento, categoria);
                    if (producto.AgregarProducto())
                    {
                        LimpiarDatos();
                        MessageBox.Show("Producto ha sido agregado");
                    }
                }
                else
                {
                    MessageBox.Show("Debe indicar una imagen.");
                }
            }
            else
            {
                MessageBox.Show(msgEsValido);
            }
        }
        private void ModificarProducto()
        {
            string msgEsValido = ValidarIngresoProducto();
            if (string.IsNullOrEmpty(msgEsValido))
            {
                string codigo = txtCodigo.Text.ToUpper();
                string nombre = txtNombre.Text.ToUpper();
                string descripcion = txtDescripcion.Text.ToUpper();
                int precioVenta = int.Parse(txtPrecioVenta.Text);
                int precioCompra = int.Parse(txtPrecioCompra.Text);
                DateTime fechaVencimiento = dtpFechaVencimiento.Value.Date;
                int stock = int.Parse(txtStock.Text);
                int stockCritico = int.Parse(txtStockCritico.Text);
                Categoria categoria = new Categoria();
                categoria.Id = (int)cmbCategoria.SelectedValue;
                File.Delete(Path + codigo + ".jpg");
                picFoto.Image.Save(Path + codigo + ".jpg", ImageFormat.Png);
                Producto producto = new Producto(codigo, nombre, descripcion, precioVenta, precioCompra, stock, stockCritico,
                        fechaVencimiento, categoria);
                bool modificarProducto = producto.ModificarProducto(producto);
                if (modificarProducto)
                {
                    LimpiarDatos();
                    MessageBox.Show("Producto actualizado");
                }
                else
                {
                    MessageBox.Show("Producto no se ha actualizado");
                }
            }
            else
            {
                MessageBox.Show(msgEsValido);
            }
        }
        private void EliminarProducto()
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text))
            {
                Producto producto = new Producto();
                bool eliminarProducto = producto.EliminarProducto(txtCodigo.Text);
                if (eliminarProducto)
                {
                    MessageBox.Show("Producto eliminado");
                }
                else
                {
                    MessageBox.Show("El producto se encuentra en alguna orden o boleta activa, por lo cual no se puede eliminar.");
                }
            }
        }
        #endregion

        #region Botones
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProductoPorNombre();
            LimpiarDatos();
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto();
            CargarGrilla();
        }
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            ModificarProducto();
            CargarGrilla();
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarProducto();
            CargarGrilla();
            LimpiarDatos();
        }
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/c-vp/OneDrive/Escritorio/Ayuda/Ayuda.chm", "Producto.htm");
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                picFoto.Image = Image.FromFile(ofd.FileName);
            }
        }
        #endregion

        #region MetodoGrilla
        private void grdProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string codigo = grdProducto.Rows[rowIndex].Cells[0].Value.ToString();
            MostrarDatosProducto(codigo);
        }

        #endregion

        #region Eventos
        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtStockCritico_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void grdProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CambiarColorProductoSinStock();
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        #endregion

    }
}
