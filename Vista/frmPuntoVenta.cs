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
    public partial class frmPuntoVenta : Form
    {
        string _codProductoSeleccionado = "";
        string _codProductoQuitar = "";
        public frmPuntoVenta()
        {
            InitializeComponent();
            PersonalizarDiseño();
            CargarComboboxCliente();
            CargarComboboxMedioPago();
            CargarComboboxCategoria();
            CargarGrillaProducto();
            CargarNumeroSiguienteBoleta();
            
        }
        #region Metodos
        private void PersonalizarDiseño()
        {
            this.grdBoleta.Columns["Codigo"].Visible = false;
        }
        private void CargarGrillaProducto()
        {
            Producto producto = new Producto();
            grdProducto.DataSource = producto.Listar();
        }
        private void CargarComboboxMedioPago()
        {
            Controlador.MedioPago medioPago = new Controlador.MedioPago();
            cmbMedioPago.DataSource = medioPago.Listar();
            cmbMedioPago.DisplayMember = "Descripcion";
            cmbMedioPago.ValueMember = "Id";
        }
        private void CargarComboboxCliente()
        {
            Controlador.Cliente cliente = new Controlador.Cliente();
            cmbCliente.DataSource = cliente.ListarCombobox();
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Run";
        }
        private void CargarComboboxCategoria()
        {
            Controlador.Categoria categoria = new Controlador.Categoria();
            cmbCategoria.DataSource = categoria.Listar();
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.ValueMember = "Id";
        }
        private void CargarNumeroSiguienteBoleta()
        {
            Boleta boleta = new Boleta();
            int numero = boleta.ObtenerNumeroMaximoBoleta();
            numero = numero + 1;
            txtNumeroBoleta.Text = numero.ToString();
        }
        public bool MostrarDatosBoleta(int numero)
        {
            Boleta boleta = new Boleta();
            boleta = boleta.ObtenerBoleta(numero);
            if (boleta != null)
            {
                txtNumeroBoleta.Text = boleta.Numero.ToString();
                txtTotalBoleta.Text = boleta.Valor.ToString();
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
            txtRunCliente.Clear();
            cmbCliente.SelectedValue = 0;
            cmbMedioPago.SelectedValue = 0;
            grdBoleta.Rows.Clear();
        }
        private void LimpiarCantidad()
        {
            txtCantidad.Value = 0;
        }
        #endregion

        #region Metodos de la clase
        public void AgregarBoleta()
        {
            if (int.Parse(txtTotalBoleta.Text)>0)
            {
                DateTime fechaCreacion = DateTime.Now.Date;
                int total = int.Parse(txtTotalBoleta.Text);
                MedioPago medioPago = new MedioPago();
                medioPago.Id = (int)cmbMedioPago.SelectedValue;
                Cliente cliente = new Cliente();
                cliente.Run = (int)cmbCliente.SelectedValue;
                Usuario usuario = new Usuario();
                usuario.RunUsuario = 7769287;
                Boleta boleta = new Boleta(fechaCreacion, total, medioPago, cliente, usuario);
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
                    MessageBox.Show("Boleta "+ numeroBoleta + " ha sido agregada.");
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
    }
}
