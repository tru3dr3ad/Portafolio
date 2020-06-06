using Controlador;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmPuntoVenta : Form
    {
        string _codProductoSeleccionado = "";
        string _codProductoQuitar = "";

        public frmPuntoVenta()
        {
            InitializeComponent();
            CargarComboboxMedioPago();
            CargarComboboxCategoria();
            CargarComboboxCliente();
            CargarNumeroSiguienteBoleta();
            CargarGrillaProducto();
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
            grdBoleta.Columns["Codigo"].Visible = false;
            grdProducto.Columns["PRECIO_COMPRA"].Visible = false;
            grdProducto.Columns["STOCK_CRITICO"].Visible = false;
            grdProducto.Columns["FECHA_VENCIMIENTO"].Visible = false;
            grdProducto.Columns["IDCATEGORIA"].Visible = false;
            grdBoleta.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void CargarComboboxMedioPago()
        {
            Controlador.MedioPago medioPago = new Controlador.MedioPago();
            cmbMedioPago.DisplayMember = "Descripcion";
            cmbMedioPago.ValueMember = "Id";
            cmbMedioPago.DataSource = medioPago.Listar();
        }
        private void CargarComboboxCliente()
        {
            Controlador.Cliente cliente = new Controlador.Cliente();
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Run";
            cmbCliente.DataSource = cliente.ListarCombobox();
        }
        private void CargarComboboxClienteFiados()
        {
            Controlador.Cliente cliente = new Controlador.Cliente();
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Run";
            cmbCliente.DataSource = cliente.ListarComboboxFiado();
        }
        private void CargarComboboxCategoria()
        {
            Controlador.Categoria categoria = new Controlador.Categoria();
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DataSource = categoria.Listar();
        }
        private void CargarNumeroSiguienteBoleta()
        {
            Boleta boleta = new Boleta();
            int numero = boleta.ObtenerNumeroMaximoBoleta();
            numero = numero + 1;
            lblNumeroBoleta.Text = numero.ToString();
        }
        public bool MostrarDatosBoleta(int numero)
        {
            Boleta boleta = new Boleta();
            boleta = boleta.ObtenerBoleta(numero);
            if (boleta != null)
            {
                lblNumeroBoleta.Text = boleta.Numero.ToString();
                txtTotalBoleta.Text = boleta.Total.ToString();
                txtRunCliente.Text = boleta.Cliente.Run.ToString();
                cmbCliente.SelectedValue = boleta.Cliente.Run;
                cmbMedioPago.SelectedValue = boleta.MedioPago.Id;
                return true;
            }
            else
            {
                return false;
            }
        }
        private void LimpiarDatos()
        {
            txtTotalBoleta.Text = "0";
            cmbCliente.SelectedValue = 11111111;
            cmbMedioPago.SelectedValue = 1;
            grdBoleta.Rows.Clear();
        }
        private void LimpiarCantidad()
        {
            txtCantidad.Value = 0;
        }
        private void CambioNombreColumnaGrilla()
        {
            grdProducto.Columns["PRECIO_VENTA"].HeaderText = "PRECIO";
            grdProducto.Columns["STOCK"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
        public void AgregarBoleta()
        {
            if (int.Parse(txtTotalBoleta.Text) > 0)
            {
                DateTime fechaCreacion = DateTime.Now.Date;
                int total = int.Parse(txtTotalBoleta.Text);
                MedioPago medioPago = new MedioPago();
                medioPago.Id = (int)cmbMedioPago.SelectedValue;
                Cliente cliente = new Cliente();
                cliente.Run = (int)cmbCliente.SelectedValue;
                Usuario usuario = new Usuario();
                usuario.RunUsuario = Global.RunUsuarioActivo;
                EstadoBoleta estado = new EstadoBoleta();
                estado.Id = 1;
                Boleta boleta = new Boleta(fechaCreacion, total, medioPago, cliente, usuario, estado);
                if (boleta.AgregarBoleta())
                {
                    int numeroBoleta = boleta.ObtenerNumeroMaximoBoleta();
                    foreach (DataGridViewRow row in grdBoleta.Rows)
                    {
                        string codigo = row.Cells[0].Value.ToString();
                        int cantidad = int.Parse(row.Cells[2].Value.ToString());
                        DetalleBoleta detalle = new DetalleBoleta(numeroBoleta, codigo, cantidad);
                        detalle.AgregarDetalleBoleta();
                    }
                    MessageBox.Show("Boleta N°" + numeroBoleta + " ha sido agregada.");
                }
            }
        }
        public void AgregarDetalleBoleta()
        {
            if (int.Parse(txtCantidad.Text)>0)
            {
                int cantidad = int.Parse(txtCantidad.Text);
                Producto producto = new Producto();
                producto = producto.ObtenerProducto(_codProductoSeleccionado);
                if (producto!=null)
                {
                    string nombreProducto = producto.Nombre;
                    int totalProductos = producto.PrecioVenta * cantidad;
                    int totalBoleta = int.Parse(txtTotalBoleta.Text);
                    totalBoleta = totalBoleta + totalProductos;
                    txtTotalBoleta.Text = totalBoleta.ToString();
                    grdBoleta.Rows.Add(_codProductoSeleccionado, nombreProducto, cantidad, totalProductos);
                }
            }
        }
        private void QuitarDetalleBoleta()
        {
            if (_codProductoQuitar != "")
            {
                Producto producto = new Producto();
                int valorVenta = producto.ObtenerValorVentaProducto(_codProductoQuitar);
                int cantidad = int.Parse(grdBoleta.Rows[grdBoleta.CurrentRow.Index].Cells[2].Value.ToString());
                int totalBoleta = int.Parse(txtTotalBoleta.Text);
                totalBoleta = totalBoleta - (valorVenta * cantidad);
                txtTotalBoleta.Text = totalBoleta.ToString();

                grdBoleta.Rows.Remove(grdBoleta.CurrentRow);
                _codProductoQuitar = "";
            }
        }
        #endregion

        #region Botones
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProductoPorNombre();
        }
        private void btnAgregarBoleta_Click(object sender, EventArgs e)
        {
            AgregarBoleta();
            LimpiarDatos();
            CargarNumeroSiguienteBoleta();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarDetalleBoleta();
            LimpiarCantidad();
        }
        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            QuitarDetalleBoleta();
        }
        #endregion

        #region MetodosGrillas
        private void grdProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string codigo = this.grdProducto[0, e.RowIndex].Value.ToString();
                _codProductoSeleccionado = codigo;
            }
        }
        private void grdBoleta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string codigo = this.grdBoleta[0, e.RowIndex].Value.ToString();
                _codProductoQuitar = codigo;
            }
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
        private void cmbMedioPago_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbMedioPago.SelectedIndex == 3)
            {
                CargarComboboxClienteFiados();
            }
            else
            {
                CargarComboboxCliente();
            }
            Cliente cliente = new Cliente();
            cliente = cliente.ObtenerCliente((int)cmbCliente.SelectedValue);
            string run = cmbCliente.SelectedValue.ToString() + "-" + cliente.Dv.ToString();
            txtRunCliente.Text = run;
        }
        private void cmbCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue != null)
            {
                Cliente cliente = new Cliente();
                cliente = cliente.ObtenerCliente((int)cmbCliente.SelectedValue);
                string run = cmbCliente.SelectedValue.ToString() + "-" + cliente.Dv.ToString();
                txtRunCliente.Text = run;
            }
        }

        #endregion
    }
}
