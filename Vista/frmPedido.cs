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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
            EscondeGroupRecepcionar();
            CargarGrillaOrden();
            CargarGrillaProducto();
            CargarComboboxEstadoOrden();
            CargarComboboxProveedor();
        }
        
        #region Metodos
        private void CargarGrillaOrden()
        {
            OrdenPedido orden = new OrdenPedido();
            grdOrden.DataSource = orden.Listar();
        }
        private void CargarGrillaProducto()
        {
            Producto producto = new Producto();
            grdProducto.DataSource = producto.Listar();
        }
        private void CargarComboboxEstadoOrden()
        {
            Controlador.EstadoOrden estadoOrden = new Controlador.EstadoOrden();
            cmbEstadoOrden.DataSource = estadoOrden.Listar();
            cmbEstadoOrden.DisplayMember = "Descripcion";
            cmbEstadoOrden.ValueMember = "Id";
        }
        private void CargarComboboxProveedor()
        {
            Controlador.Proveedor proveedor = new Controlador.Proveedor();
            cmbProveedor.DataSource = proveedor.Listar();
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Rut";
        }
        private void EscondeGroupRecepcionar()
        {
            grpRecepcion.Visible = false;
        }
        public bool MostrarDatosOrden(int numero)
        {
            OrdenPedido orden = new OrdenPedido();
            orden = orden.ObtenerOrdenPedido(numero);
            if (orden != null)
            {
                txtNumero.Text = orden.Numero.ToString();
                txtRut.Text = orden.Proveedor.Rut.ToString();
                txtTotalOrden.Text = orden.Valor.ToString();
                cmbProveedor.SelectedValue = orden.Proveedor.Rut;
                cmbEstadoOrden.SelectedValue = orden.Estado.Id;
                return true;
            }
            else
            {
                return false;
            }
        }
        private void LimpiarDatos()
        {
            txtNumero.Clear();
            txtBuscarOrden.Clear();
            txtTotalOrden.Clear();
            cmbProveedor.SelectedIndex = 0;
            cmbEstadoOrden.SelectedIndex = 0;
        }
        #endregion

        #region Metodos de la clase
        private void BuscarOrdenPedido()
        {
            OrdenPedido orden = new OrdenPedido();
            if (!String.IsNullOrEmpty(txtBuscarOrden.Text))
            {
                bool existeOrden = orden.BuscarOrden(int.Parse(txtBuscarOrden.Text));
                if (existeOrden)
                {
                    MessageBox.Show("Orden de pedido encontrada");
                }
                else
                {
                    MessageBox.Show("Orden de pedido no encontrada");
                }
            }
        }
        public void AgregarOrdenPedido()
        {
            if (!String.IsNullOrEmpty(txtTotalOrden.Text))
            {
                DateTime fechaCreacion = DateTime.Now;
                int valor = int.Parse(txtTotalOrden.Text);
                DateTime fechaRecepcion = DateTime.Now;
                Proveedor proveedor = new Proveedor();
                proveedor.Rut = (int)cmbProveedor.SelectedValue;
                EstadoOrden estado = new EstadoOrden();
                estado.Id = (int)cmbEstadoOrden.SelectedValue;
                Usuario usuario = new Usuario();
                usuario.RunUsuario = 7769287;
                OrdenPedido orden = new OrdenPedido(fechaCreacion, valor, fechaRecepcion, proveedor, estado, usuario);
                if (orden.AgregarOrdenPedido())
                {
                    MessageBox.Show("Orden de pedido ha sido agregada");
                }
            }
        }
        private void ModificarOrdenPedido()
        {
            if (!String.IsNullOrEmpty(txtNumero.Text))
            {
                DateTime fechaCreacion = DateTime.Now;
                int valor = int.Parse(txtTotalOrden.Text);
                DateTime fechaRecepcion = DateTime.Now;
                Proveedor proveedor = new Proveedor();
                proveedor.Rut = (int)cmbProveedor.SelectedValue;
                EstadoOrden estado = new EstadoOrden();
                estado.Id = (int)cmbEstadoOrden.SelectedValue;
                Usuario usuario = new Usuario();
                usuario.RunUsuario = 7769287;
                OrdenPedido orden = new OrdenPedido(fechaCreacion, valor, fechaRecepcion, proveedor, estado, usuario);
                bool modificarOrden = orden.ModificarOrdenPedido(orden);
                if (modificarOrden)
                {
                    MessageBox.Show("Orden de pedido actualizado");
                }
                else
                {
                    MessageBox.Show("Orden de pedido no se ha actualizado");
                }
            }
        }
        private void EliminarOrdenPedido()
        {
            if (!String.IsNullOrEmpty(txtNumero.Text))
            {
                OrdenPedido orden = new OrdenPedido();
                bool eliminarOrden = orden.EliminarOrdenPedido(int.Parse(txtNumero.Text));
                if (eliminarOrden)
                {
                    MessageBox.Show("Orden de pedido eliminado");
                }
                else
                {
                    MessageBox.Show("Orden de pedido no eliminado");
                }
            }
        }
        #endregion

        #region Botones
        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            BuscarOrdenPedido();
            txtBuscarOrden.Clear();
        }
        private void btnGuardarOrden_Click(object sender, EventArgs e)
        {
            AgregarOrdenPedido();
            CargarGrillaOrden();
            LimpiarDatos();
        }

        private void btnModificarOrden_Click(object sender, EventArgs e)
        {
            ModificarOrdenPedido();
            CargarGrillaOrden();
            LimpiarDatos();
        }

        private void btnEliminarOrden_Click(object sender, EventArgs e)
        {
            EliminarOrdenPedido();
            CargarGrillaOrden();
            LimpiarDatos();
        }
        private void btnMostrarRecepcion_Click(object sender, EventArgs e)
        {
            grpRecepcion.Visible = true;
        }
        #endregion

        #region MetodoGrilla
        private void grdOrden_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int numero = int.Parse(grdOrden.Rows[rowIndex].Cells[0].Value.ToString());
            MostrarDatosOrden(numero);
        }
        #endregion
    }
}
