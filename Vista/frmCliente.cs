using Controlador;
using System;
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
        private void EsconderColumnasAutogeneradas()
        {
            grdCliente.Columns["IDTIPO"].Visible = false;
            grdCliente.Columns["IDESTADO"].Visible = false;
        }
        private void CargarGrilla()
        {
            Cliente cliente = new Cliente();
            grdCliente.DataSource = cliente.ListarVistaCliente();
            EsconderColumnasAutogeneradas();
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
        private void LimpiarDatos()
        {
            txtRunCliente.Clear();
            txtDv.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            txtDireccion.Clear();
            txtTelefono.Clear();
            cmbTipoCliente.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
        }
        #endregion

        #region Metodos de la clase
        private void BuscarClientePorNombre()
        {
            string nombre = txtBuscarCliente.Text.ToUpper();
            Cliente cliente = new Cliente();
            grdCliente.DataSource = cliente.ListarClientePorNombre(nombre);
            txtBuscarCliente.Clear();
            EsconderColumnasAutogeneradas();
        }
        public void AgregarCliente()
        {
            if (!String.IsNullOrEmpty(txtRunCliente.Text))
            {
                int run = int.Parse(txtRunCliente.Text);
                char dv = char.Parse(txtDv.Text);
                string nombre = txtNombre.Text.ToUpper();
                string apellido = txtApellido.Text.ToUpper(); ;
                DateTime fechaNacimiento = dtpFechaNacimiento.Value.Date;
                string direccion = txtDireccion.Text.ToUpper();
                int telefono = int.Parse(txtTelefono.Text);
                EstadoFiado estado = new EstadoFiado();
                estado.Id = (int)cmbEstado.SelectedValue;
                TipoCliente tipo = new TipoCliente();
                tipo.Id = (int)cmbTipoCliente.SelectedValue;
                Cliente cliente = new Cliente(run, dv, nombre, apellido, fechaNacimiento, direccion, telefono, estado, tipo);
                if (cliente.AgregarCliente())
                {
                    MessageBox.Show("Cliente ha sido agregado");
                }
            }
        }
        private void ModificarCliente()
        {
            if (!String.IsNullOrEmpty(txtRunCliente.Text))
            {
                int run = int.Parse(txtRunCliente.Text);
                char dv = char.Parse(txtDv.Text);
                string nombre = txtNombre.Text.ToUpper();
                string apellido = txtApellido.Text.ToUpper();
                DateTime fechaNacimiento = dtpFechaNacimiento.Value.Date;
                string direccion = txtDireccion.Text.ToUpper();
                int telefono = int.Parse(txtTelefono.Text);
                EstadoFiado estado = new EstadoFiado();
                estado.Id = (int)cmbEstado.SelectedValue;
                TipoCliente tipo = new TipoCliente();
                tipo.Id = (int)cmbTipoCliente.SelectedValue;
                Cliente cliente = new Cliente(run, dv, nombre, apellido, fechaNacimiento, direccion, telefono, estado, tipo);
                bool modificarCliente = cliente.ModificarCliente(cliente);
                if (modificarCliente)
                {
                    MessageBox.Show("Cliente Actualizado");
                }
                else
                {
                    MessageBox.Show("Cliente no se ha actualizado");
                }
            }
        }
        private void EliminarCliente()
        {
            if (!String.IsNullOrEmpty(txtRunCliente.Text))
            {
                Cliente cliente = new Cliente();
                bool eliminarCliente = cliente.EliminarCliente(int.Parse(txtRunCliente.Text));
                if (eliminarCliente)
                {
                    MessageBox.Show("Cliente eliminado");
                }
                else
                {
                    MessageBox.Show("Cliente no eliminado");
                }
            }
        }
        #endregion

        #region Botones
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarClientePorNombre();
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

            AgregarCliente();
            CargarGrilla();
            LimpiarDatos();
        }
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            ModificarCliente();
            CargarGrilla();
            LimpiarDatos();
        }
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            EliminarCliente();
            CargarGrilla();
            LimpiarDatos();
        }
        #endregion

        #region MetodoGrilla
        private void grdCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int runCliente = int.Parse(grdCliente.Rows[rowIndex].Cells[0].Value.ToString());
            MostrarDatosCliente(runCliente);
        }
        #endregion
    }
}
