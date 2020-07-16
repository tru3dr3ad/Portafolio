﻿using Controlador;
using System;
using System.IO;
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
            MostrarVistaVendedor();
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
            CambioNombreColumnaGrilla();
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
            Usuario usuario = new Usuario();
            bool esVendedor = usuario.esVendedor(Global.RunUsuarioActivo);
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
                if (esVendedor)
                {

                }
                else
                {
                    cmbTipoCliente.SelectedValue = cliente.Tipo.Id;
                    cmbEstado.SelectedValue = cliente.Estado.Id;
                }
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
        private string ValidacionIngresoCliente()
        {
            string mensajeError = string.Empty;
            string runCliente = txtRunCliente.Text + "-" + txtDv.Text;
            Validaciones validaciones = new Validaciones();
            if (validaciones.ValidarRun(runCliente))
            {
                if (validaciones.ValidarLargoString(3, 70, txtNombre.Text))
                {
                    if (validaciones.ValidarLargoString(3, 70, txtApellido.Text))
                    {
                        if (validaciones.ValidarMayoriaEdad(dtpFechaNacimiento.Value))
                        {
                            if (validaciones.ValidarLargoString(3, 150, txtDireccion.Text))
                            {
                                if (validaciones.ValidarNumeroTelefono(txtTelefono.Text))
                                {
                                    return mensajeError;
                                }
                                else
                                {
                                    mensajeError = "Telefono es invalido";
                                }
                            }
                            else
                            {
                                mensajeError = "Largo de la direccion es invalido";
                            }
                        }
                        else
                        {
                            mensajeError = "Debe ser mayor de edad para ser cliente";
                        }
                    }
                    else
                    {
                        mensajeError = "Largo del apellido es inválido";
                    }
                }
                else
                {
                    mensajeError = "Largo del nombre es inválido";
                }
            }
            else
            {
                mensajeError = "Run inválido";
            }

            return mensajeError;
        }
        private void CambioNombreColumnaGrilla()
        {
            grdCliente.Columns["NOMBRE_CLIENTE"].HeaderText = "NOMBRE CLIENTE";
            grdCliente.Columns["FECHANACIMIENTO"].HeaderText = "FECHA NACIMIENTO";
            grdCliente.Columns["TIPO_CLIENTE"].HeaderText = "TIPO";
            grdCliente.Columns["ESTADO_FIADO"].HeaderText = "ESTADO";
            grdCliente.Columns["NOMBRE_CLIENTE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void MostrarVistaVendedor()
        {
            Usuario usuario = new Usuario();
            bool esVendedor = usuario.esVendedor(Global.RunUsuarioActivo);
            if (esVendedor)
            {
                cmbEstado.Visible = false;
                cmbTipoCliente.Visible = false;
                lblEstadoCliente.Visible = false;
                lblTipoCliente.Visible = false;
            }
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
            string msgEsValido = ValidacionIngresoCliente();
            Usuario usuario = new Usuario();
            bool esVendedor = usuario.esVendedor(Global.RunUsuarioActivo);
            if (string.IsNullOrEmpty(msgEsValido))
            {
                int run = int.Parse(txtRunCliente.Text);
                char dv = char.Parse(txtDv.Text);
                string nombre = txtNombre.Text.ToUpper();
                string apellido = txtApellido.Text.ToUpper(); ;
                DateTime fechaNacimiento = dtpFechaNacimiento.Value.Date;
                string direccion = txtDireccion.Text.ToUpper();
                int telefono = int.Parse(txtTelefono.Text);
                EstadoFiado estado = new EstadoFiado();
                TipoCliente tipo = new TipoCliente();
                if (esVendedor)
                {
                    estado = estado.ObtenerEstadoFiado(1);
                    tipo = tipo.ObtenerTipoCliente(2);
                }
                else
                {
                    estado.Id = (int)cmbEstado.SelectedValue;
                    tipo.Id = (int)cmbTipoCliente.SelectedValue;
                }
                Cliente cliente = new Cliente(run, dv, nombre, apellido, fechaNacimiento, direccion, telefono, estado, tipo);
                if (cliente.AgregarCliente())
                {
                    MessageBox.Show("Cliente ha sido agregado");
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show(msgEsValido);
            }
        }
        private void ModificarCliente()
        {
            string msgEsValido = ValidacionIngresoCliente();
            Usuario usuario = new Usuario();
            bool esVendedor = usuario.esVendedor(Global.RunUsuarioActivo);
            if (string.IsNullOrEmpty(msgEsValido))
            {
                int run = int.Parse(txtRunCliente.Text);
                char dv = char.Parse(txtDv.Text);
                string nombre = txtNombre.Text.ToUpper();
                string apellido = txtApellido.Text.ToUpper();
                DateTime fechaNacimiento = dtpFechaNacimiento.Value.Date;
                string direccion = txtDireccion.Text.ToUpper();
                int telefono = int.Parse(txtTelefono.Text);
                EstadoFiado estado = new EstadoFiado();
                TipoCliente tipo = new TipoCliente();
                if (esVendedor)
                {
                    estado = estado.ObtenerEstadoFiado(1);
                    tipo = tipo.ObtenerTipoCliente(2);
                }
                else
                {
                    estado.Id = (int)cmbEstado.SelectedValue;
                    tipo.Id = (int)cmbTipoCliente.SelectedValue;
                }
                Cliente cliente = new Cliente(run, dv, nombre, apellido, fechaNacimiento, direccion, telefono, estado, tipo);
                bool modificarCliente = cliente.ModificarCliente(cliente);
                if (modificarCliente)
                {
                    MessageBox.Show("Cliente actualizado");
                }
                else
                {
                    MessageBox.Show("Cliente no se ha actualizado");
                }
            }
            else
            {
                MessageBox.Show(msgEsValido);
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
                    MessageBox.Show("El cliente tiene datos vinculados con boletas, no se puede eliminar.");
                }
            }
        }
        #endregion

        #region Botones
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarClientePorNombre();
            LimpiarDatos();
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente();
            CargarGrilla();
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
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string rutaAyuda = @"\Ayuda\Ayuda.chm";
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string ayudaPath = projectDirectory + rutaAyuda;
            Help.ShowHelp(this, ayudaPath, "Revision cliente.htm");
        }
        #endregion

        #region MetodoGrilla
        private void grdCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex > -1)
            {
                int runCliente = int.Parse(grdCliente.Rows[rowIndex].Cells[0].Value.ToString());
                MostrarDatosCliente(runCliente);
            }
        }
        #endregion

        #region Eventos
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtRunCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) || e.KeyChar == (char)Keys.Space;
        }
        #endregion
    }
}
