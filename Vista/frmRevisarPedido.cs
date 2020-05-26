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
            grdOrden.DataSource = orden.Listar();
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
            cmbProveedores.DataSource = proveedor.ListarCombobox();
            cmbProveedores.DisplayMember = "Nombre";
            cmbProveedores.ValueMember = "Rut";
        }
        private void LimpiarDatos()
        {
            txtBuscarOrden.Clear();
            cmbProveedores.SelectedIndex = 0;
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

        private void EliminarOrdenPedido()
        {
            if (!String.IsNullOrEmpty(txtBuscarOrden.Text))
            {
                OrdenPedido orden = new OrdenPedido();
                bool eliminarOrden = orden.EliminarOrdenPedido(int.Parse(txtBuscarOrden.Text));
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
        public void RecepcionarOrden()
        {
            if (_numeroOrdenSeleccionado != 0)
            {
                OrdenPedido orden = new OrdenPedido();
                orden = orden.ObtenerOrdenPedido(_numeroOrdenSeleccionado);
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
        }
        #endregion

        #region Botones
        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            BuscarOrdenPedido();
            txtBuscarOrden.Clear();
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
        #endregion

        #region MetodoGrilla
        private void grdOrden_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int numeroOrden = int.Parse(this.grdOrden[0, e.RowIndex].Value.ToString());
                _numeroOrdenSeleccionado = numeroOrden;
            }
        }
        #endregion
        
    }
}
