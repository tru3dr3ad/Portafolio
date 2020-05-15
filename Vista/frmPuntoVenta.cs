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
        public frmPuntoVenta()
        {
            InitializeComponent();
            PersonalizarDiseño();
            CargarComboboxCliente();
            CargarComboboxMedioPago();
            CargarComboboxCategoria();
            CargarGrilla();
        }
        private void PersonalizarDiseño()
        {
            pnlPago.Visible = false;
            if (pnlPago.Visible == false)
            {
                pnlBoleta.Width = 550;
            }
            else if (pnlPago.Visible)
            {
                pnlBoleta.Width = 350;
            }
        }
        private void CargarGrilla()
        {
            Producto producto= new Producto();
            grdProducto.DataSource = producto.Listar();
        }
        private void CargarComboboxMedioPago()
        {
            Controlador.MedioPago medioPago= new Controlador.MedioPago();
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
            Controlador.Categoria categoria= new Controlador.Categoria();
            cmbCategoria.DataSource = categoria.Listar();
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.ValueMember = "Id";
        }
        private void btnCancelarPago_Click(object sender, EventArgs e)
        {
            pnlPago.Visible = false;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            pnlPago.Visible = true;
        }
        public bool MostrarDatosCliente(int numero)
        {
            Boleta boleta= new Boleta();
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
            txtNumeroBoleta.Clear();
            txtTotalBoleta.Clear();
            txtRunCliente.Clear();
            cmbCliente.SelectedValue = 0;
            cmbMedioPago.SelectedValue = 0;
        }

        #region Metodos de la clase
        private void BuscarProducto()
        {
            Producto producto = new Producto();
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
        public void AgregarBoleta()
        {
            if (!String.IsNullOrEmpty(txtNumeroBoleta.Text))
            {
                int numero = int.Parse(txtNumeroBoleta.Text);
                DateTime fechaCreacion = DateTime.Now.Date;
                int total = int.Parse(txtTotalBoleta.Text);
                MedioPago medioPago = new MedioPago();
                medioPago.Id = (int)cmbMedioPago.SelectedValue;
                Cliente cliente = new Cliente();
                cliente.Run = (int)cmbCliente.SelectedValue;
                Usuario usuario = new Usuario();
                usuario.RunUsuario = 7769287;
                Boleta boleta = new Boleta(numero, fechaCreacion, total, medioPago, cliente, usuario);
                if (boleta.AgregarBoleta())
                {
                    MessageBox.Show("Boleta ha sido agregada");
                }
            }
        }
        private void ModificarBoleta()
        {
            if (!String.IsNullOrEmpty(txtNumeroBoleta.Text))
            {
                int numero = int.Parse(txtNumeroBoleta.Text);
                DateTime fechaCreacion = DateTime.Now.Date;
                int total = int.Parse(txtTotalBoleta.Text);
                MedioPago medioPago = new MedioPago();
                medioPago.Id = (int)cmbMedioPago.SelectedValue;
                Cliente cliente = new Cliente();
                cliente.Run = (int)cmbCliente.SelectedValue;
                Usuario usuario = new Usuario();
                usuario.RunUsuario = 7769287;
                Boleta boleta = new Boleta(numero, fechaCreacion, total, medioPago, cliente, usuario);
                bool modificarBoleta = boleta.ModificarBoleta(boleta);
                if (modificarBoleta)
                {
                    MessageBox.Show("Boleta actualizada");
                }
                else
                {
                    MessageBox.Show("Boleta no se ha actualizada");
                }
            }
        }
        private void EliminarBoleta()
        {
            if (!String.IsNullOrEmpty(txtNumeroBoleta.Text))
            {
                Boleta boleta = new Boleta();
                bool eliminarBoleta = boleta.EliminarBoleta(int.Parse(txtRunCliente.Text));
                if (eliminarBoleta)
                {
                    MessageBox.Show("Boleta eliminada");
                }
                else
                {
                    MessageBox.Show("Boleta no eliminada");
                }
            }
        }
        #endregion

        private void btnAgregarBoleta_Click(object sender, EventArgs e)
        {
            AgregarBoleta();
            LimpiarDatos();
        }
    }
}
