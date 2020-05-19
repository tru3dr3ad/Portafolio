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
        public frmRevisarPedido()
        {
            InitializeComponent();
            CargarGrillaOrden();
            CargarComboboxEstadoOrden();
            CargarComboboxProveedor();
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
            cmbProveedores.DataSource = proveedor.Listar();
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
        #endregion

        #region MetodoGrilla
        private void grdOrden_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int numero = int.Parse(grdOrden.Rows[rowIndex].Cells[0].Value.ToString());
            //MostrarDatosOrden(numero);
        }
        #endregion
    }
}
