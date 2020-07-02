using Controlador;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Drawing.Imaging;
using System.IO;
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
            CargarComboboxCategoria();
            CargarComboboxProveedor();
            CargarGrillaProducto();
            CargarNumeroSiguienteOrden();
        }

        #region Metodos
        private void CargarGrillaProducto()
        {
            Producto producto = new Producto();
            grdProducto.DataSource = producto.ListarProductos();
            EsconderColumnasAutogeneradas();
            CambioNombreColumnaGrilla();
        }
        private void EsconderColumnasAutogeneradas()
        {
            grdOrden.Columns["Codigo"].Visible = false;
            grdProducto.Columns["PRECIO_VENTA"].Visible = false;
            grdProducto.Columns["STOCK_CRITICO"].Visible = false;
            grdProducto.Columns["FECHA_VENCIMIENTO"].Visible = false;
            grdProducto.Columns["IDCATEGORIA"].Visible = false;
            grdOrden.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            lblNumeroOrden.Text = numero.ToString("0000");
        }
        private void LimpiarDatos()
        {
            txtTotalOrden.Text = "0";
            txtRutProveedor.Clear();
            cmbCategoria.SelectedValue = 1;
            cmbProveedor.SelectedValue = 10257620;
            grdOrden.Rows.Clear();
        }
        private void LimpiarCantidad()
        {
            txtCantidad.Value = 0;
        }
        private void CambioNombreColumnaGrilla()
        {
            grdProducto.Columns["PRECIO_COMPRA"].HeaderText = "PRECIO";
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
        public void AgregarOrdenPedido()
        {
            if (decimal.Parse(txtTotalOrden.Text) > 0)
            {
                DateTime fechaCreacion = DateTime.Now.Date;
                decimal total = decimal.Parse(txtTotalOrden.Text);
                DateTime fechaRecepcion = DateTime.Now.Date;
                Proveedor proveedor = new Proveedor();
                proveedor.Rut = (int)cmbProveedor.SelectedValue;
                EstadoOrden estadoOrden = new EstadoOrden();
                estadoOrden.Id = 1;//<--debe ser No Recepcionada
                Usuario usuario = new Usuario();
                usuario.RunUsuario = Global.RunUsuarioActivo;
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
        public void AgregarOrdenPedidoParaDescargar()
        {
            if (decimal.Parse(txtTotalOrden.Text) > 0)
            {
                DateTime fechaCreacion = DateTime.Now.Date;
                decimal total = decimal.Parse(txtTotalOrden.Text);
                DateTime fechaRecepcion = DateTime.Now.Date;
                Proveedor proveedor = new Proveedor();
                proveedor.Rut = (int)cmbProveedor.SelectedValue;
                EstadoOrden estadoOrden = new EstadoOrden();
                estadoOrden.Id = 2;//<--estado de orden = enviada
                Usuario usuario = new Usuario();
                usuario.RunUsuario = Global.RunUsuarioActivo;
                OrdenPedido orden = new OrdenPedido(fechaCreacion, total, fechaRecepcion, proveedor, estadoOrden, usuario);
                if (orden.AgregarOrdenPedido())
                {
                    DescargarPDFOrdenPedido(orden);//<-------------------
                    int numeroOrden = orden.ObtenerNumeroMaximoOrden();
                    foreach (DataGridViewRow row in grdOrden.Rows)
                    {
                        string codigo = row.Cells[0].Value.ToString();
                        int cantidad = int.Parse(row.Cells[2].Value.ToString());
                        DetallePedido detalle = new DetallePedido(numeroOrden, codigo, cantidad);
                        detalle.AgregarDetallePedido();
                    }
                    MessageBox.Show("Orden de Pedido N°" + numeroOrden + " ha sido agregada, y descargada");
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
                    decimal totalProductos = producto.PrecioCompra * cantidad;
                    decimal totalPedido = decimal.Parse(txtTotalOrden.Text);
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
        #endregion

        #region Metodo Para PDF
        private void DescargarPDFOrdenPedido(OrdenPedido orden)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        var imagePath = @"C:\Users\krist\source\repos\slnAlmacen\Portafolio\Vista\Logo\Logo.png";
                        using (FileStream fs = new FileStream(imagePath, FileMode.Open))
                        {
                            var png = Image.GetInstance(System.Drawing.Image.FromStream(fs),
                                ImageFormat.Png);
                            png.ScalePercent(18f);
                            png.SetAbsolutePosition(15f, 705f);
                            doc.Add(png);
                        }

                        var spacer = new Paragraph("")
                        {
                            SpacingBefore = 10f,
                            SpacingAfter = 10f,
                        };
                        doc.Add(spacer);
                        doc.Add(spacer);

                        var proveedorTable = new PdfPTable(new[] { .75f, 2f })
                        {
                            HorizontalAlignment = Left,
                            WidthPercentage = 75,
                            DefaultCell = { MinimumHeight = 22f }
                        };

                        Proveedor proveedor = new Proveedor();
                        proveedor = proveedor.ObtenerProveedor(orden.Proveedor.Rut);

                        proveedorTable.AddCell("Fecha");
                        proveedorTable.AddCell(DateTime.Now.Date.ToShortDateString());
                        proveedorTable.AddCell("Proveedor");
                        proveedorTable.AddCell(proveedor.Nombre);
                        proveedorTable.AddCell("Rut");
                        proveedorTable.AddCell(proveedor.Rut.ToString("00.000.000") + "-" + proveedor.Dv);
                        //proveedorTable.AddCell("Fecha");
                        
                        doc.Add(proveedorTable);
                        doc.Add(spacer);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
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
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProductoPorNombre();
        }
        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            AgregarOrdenPedido();
            LimpiarDatos();
            CargarNumeroSiguienteOrden();
        }
        private void btnDescargarOrden_Click(object sender, EventArgs e)
        {
            //<--Metodo para descargar la grilla
            AgregarOrdenPedidoParaDescargar();
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

    }
}
