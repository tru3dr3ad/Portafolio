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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            CargarComboboxTipoCliente();
            CargarComboboxEstadoFiado();
            CargarGrilla();
        }
        #region Metodos
        private void CargarGrilla()
        {
            Cliente cliente = new Cliente();
            grdCliente.DataSource = cliente.Listar();
        }
        private void CargarComboboxTipoCliente()
        {
            Controlador.TipoCliente tipoCliente = new Controlador.TipoCliente();
            cmbTipoCliente.DataSource = tipoCliente.Listar();
            cmbTipoCliente.DisplayMember = "Descripcion";
            cmbTipoCliente.ValueMember = "Id";
        }
        private void CargarComboboxEstadoFiado()
        {
            Controlador.EstadoFiado estadoFiado = new Controlador.EstadoFiado();
            cmbEstado.DataSource = estadoFiado.Listar();
            cmbEstado.DisplayMember = "Descripcion";
            cmbEstado.ValueMember = "Id";
        }
        public bool MostrarDatosCliente(int run)
        {
            Cliente cliente = new Cliente();
            cliente = cliente.ObtenerCliente(run);
            if (cliente != null)
            {
                txtRunCliente.Text = cliente.Run.ToString();
                txtDv.Text = cliente.Dv.ToString();
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                dtpFechaNacimiento.Value = cliente.FechaNacimiento;
                txtDireccion.Text = cliente.Direccion;
                txtTelefono.Text = cliente.Telefono.ToString();
                cmbTipoCliente.SelectedValue = cliente.Tipo.Id;
                cmbEstado.SelectedValue = cliente.Estado.Id;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AgregarCliente()
        {
            int rut = int.Parse(txtRunCliente.Text);
            char dv = char.Parse(txtDv.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value.Date;
            string direccion = txtDireccion.Text;
            int telefono = int.Parse(txtTelefono.Text);
            EstadoFiado estado = new EstadoFiado();
            estado.Id = (int)cmbEstado.SelectedValue;
            TipoCliente tipo = new TipoCliente();
            tipo.Id = (int)cmbTipoCliente.SelectedValue;
            Cliente cliente = new Cliente(rut, dv, nombre, apellido, fechaNacimiento, direccion, telefono, estado, tipo);
            if (cliente.AgregarCliente())
            {
                MessageBox.Show("Cliente ha sido Agregado");
            }
        }
        private void BuscarCliente()
        {
            Cliente cliente = new Cliente();
            if (!String.IsNullOrEmpty(txtBuscarCliente.Text))
            {
                bool existeCliente = cliente.BuscarCliente(int.Parse(txtBuscarCliente.Text));
                if (existeCliente)
                {
                    MessageBox.Show("Cliente Encontrado");
                }
                else
                {
                    MessageBox.Show("Cliente No Encontrado");
                }
            }
        }
        private void EliminarCliente()
        {
            Cliente cliente = new Cliente();
            bool eliminarCliente = cliente.EliminarCliente(int.Parse(txtRunCliente.Text));
            if (eliminarCliente)
            {
                MessageBox.Show("Cliente Eliminado");
            }
            else
            {
                MessageBox.Show("Cliente no eliminado");
            }
        }
        private void ModificarCliente()
        {           
            int rut = int.Parse(txtRunCliente.Text);
            char dv = char.Parse(txtDv.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value.Date;
            string direccion = txtDireccion.Text;
            int telefono = int.Parse(txtTelefono.Text);
            EstadoFiado estado = new EstadoFiado();
            estado.Id = (int)cmbEstado.SelectedValue;
            TipoCliente tipo = new TipoCliente();
            tipo.Id = (int)cmbTipoCliente.SelectedValue;
            Cliente cliente = new Cliente(rut, dv, nombre, apellido, fechaNacimiento, direccion, telefono, estado, tipo);
            bool modificarCliente = cliente.ModificarCliente(int.Parse(txtRunCliente.Text));
            if (modificarCliente)
            {
                MessageBox.Show("Cliente Actualizado");
            }
            else
            {
                MessageBox.Show("Cliente no se ha actualizado");
            }
        }
        #endregion
        #region Botones
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

            AgregarCliente();
            CargarGrilla();
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }
        #endregion

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            EliminarCliente();
            CargarGrilla();
        }
        private void grdCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int runCliente = int.Parse(grdCliente.Rows[rowIndex].Cells[0].Value.ToString());
            MostrarDatosCliente(runCliente);
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            ModificarCliente();
            CargarGrilla();
        }
    }
}
