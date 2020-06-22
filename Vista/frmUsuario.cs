using Controlador;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
            CargarComboboxTipoUsuario();
            CargarGrilla();
        }

        #region Metodos
        public void CargarGrilla()
        {
            Usuario usuario = new Usuario();
            grdUsuario.DataSource = usuario.ListarUsuarios();
            EsconderColumnasAutogeneradas();
            CambioNombreColumnaGrilla();
        }
        private void EsconderColumnasAutogeneradas()
        {
            grdUsuario.Columns["IDTIPO"].Visible = false;
            grdUsuario.Columns["CONTRASENA"].Visible = false;
        }
        private void CargarComboboxTipoUsuario()
        {
            Controlador.TipoUsuario tipoUsuario = new Controlador.TipoUsuario();
            cmbTipoUsuario.DisplayMember = "Descripcion";
            cmbTipoUsuario.ValueMember = "Id";
            cmbTipoUsuario.DataSource = tipoUsuario.Listar();
        }
        public bool MostrarDatosUsuario(int run)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario = usuario.ObtenerUsuario(run);
                if (usuario != null)
                {
                    txtRunUsuario.Text = usuario.RunUsuario.ToString();
                    txtDv.Text = usuario.DvUsuario.ToString();
                    txtNombreUsuario.Text = usuario.NombreUsuario;
                    txtApellidoUsuario.Text = usuario.ApellidoUsuario;
                    txtContrasena.Text = usuario.Contrasena;
                    cmbTipoUsuario.SelectedValue = usuario.Tipo.Id;
                    dtpFechaNacimiento.Value = usuario.FechaNacimiento;
                    txtDireccionUsuario.Text = usuario.DireccionUsuario;
                    txtTelefonoUsuario.Text = usuario.TelefonoUsuario.ToString();
                    txtCorreo.Text = usuario.Correo;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al mostrar datos de usuario: " + ex);
            }
        }
        private void LimpiarDatos()
        {
            txtRunUsuario.Clear();
            txtDv.Clear();
            txtNombreUsuario.Clear();
            txtApellidoUsuario.Clear();
            txtContrasena.Clear();
            cmbTipoUsuario.SelectedValue = 0;
            dtpFechaNacimiento.Value = DateTime.Now;
            txtDireccionUsuario.Clear();
            txtTelefonoUsuario.Clear();
            txtCorreo.Clear();
        }
        private string ValidarIngresoUsuario()
        {
            string mensajeError = string.Empty;
            string runUsuario = txtRunUsuario.Text + "-" + txtDv.Text;
            Validaciones validaciones = new Validaciones();
            if (validaciones.ValidarRun(runUsuario))
            {
                if (validaciones.ValidarLargoString(3,70,txtNombreUsuario.Text))
                {
                    if (validaciones.ValidarLargoString(3,70,txtApellidoUsuario.Text))
                    {
                        if (validaciones.ValidarMayoriaEdad(dtpFechaNacimiento.Value))
                        {
                            if (validaciones.ValidarLargoString(3,550,txtDireccionUsuario.Text))
                            {
                                if (validaciones.ValidarNumeroTelefono(txtTelefonoUsuario.Text))
                                {
                                    if (validaciones.ValidarEmail(txtCorreo.Text))
                                    {
                                        return mensajeError;
                                    }
                                    else
                                    {
                                        mensajeError = "El formato del correo es invalido";
                                    }
                                }
                                else
                                {
                                    mensajeError = "El numero de telefono es invalido";
                                }
                            }
                            else
                            {
                                mensajeError = "El largo de la direccion de usuario es invalido";
                            }
                        }
                        else
                        {
                            mensajeError = "El usuario debe ser mayor de edad";
                        }
                    }
                    else
                    {
                        mensajeError = "El largo del apellido de usuario es invalido";
                    }
                }
                else
                {
                    mensajeError = "El largo del nombre de usuario es invalido";
                }
            }
            else
            {
                mensajeError = "El rut del usuario es invalido";
            }
            return mensajeError;
        }
        private void CambioNombreColumnaGrilla()
        {
            grdUsuario.Columns["NOMBRE_USUARIO"].HeaderText = "NOMBRE USUARIO";
            grdUsuario.Columns["FECHANACIMIENTO"].HeaderText = "FECHA NACIMIENTO";
            grdUsuario.Columns["FECHACREACION"].HeaderText = "FECHA CREACION";
            grdUsuario.Columns["DESCRIPCION"].HeaderText = "TIPO DE USUARIO";
        }
        #endregion

        #region Metodos de la clase
        private void BuscarUsuarioPorNombre()
        {
            string nombre = txtBuscarUsuario.Text.ToUpper();
            Usuario usuario = new Usuario();
            grdUsuario.DataSource = usuario.ListarUsuariosPorNombre(nombre);
            txtBuscarUsuario.Clear();
            EsconderColumnasAutogeneradas();
        }
        public void AgregarUsuario()
        {
            string msgEsValido = ValidarIngresoUsuario();
            if (string.IsNullOrEmpty(msgEsValido))
            {
                int run = int.Parse(txtRunUsuario.Text);
                char dv = char.Parse(txtDv.Text);
                string nombre = txtNombreUsuario.Text.ToUpper();
                string apellido = txtApellidoUsuario.Text.ToUpper(); ;
                string contrasena = txtContrasena.Text;
                DateTime fechaNacimiento = dtpFechaNacimiento.Value.Date;
                DateTime fechaCreacion = DateTime.Now.Date;
                string direccion = txtDireccionUsuario.Text.ToUpper();
                int telefono = int.Parse(txtTelefonoUsuario.Text);
                string correo = txtCorreo.Text;
                TipoUsuario tipo = new TipoUsuario();
                tipo.Id = (int)cmbTipoUsuario.SelectedValue;
                Usuario usuario = new Usuario(run, dv, nombre, apellido, contrasena, fechaNacimiento, fechaCreacion,
                    direccion, telefono, correo, tipo);
                if (usuario.AgregarUsuario())
                {
                    MessageBox.Show("Usuario ha sido Agregado");
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show(msgEsValido);
            }
        }
        public void ModificarUsuario()
        {
            string msgEsValido = ValidarIngresoUsuario();
            if (string.IsNullOrEmpty(msgEsValido))
            {
                int run = int.Parse(txtRunUsuario.Text);
                char dv = char.Parse(txtDv.Text);
                string nombre = txtNombreUsuario.Text;
                string apellido = txtApellidoUsuario.Text;
                string contrasena = txtContrasena.Text;
                DateTime fechaNacimiento = dtpFechaNacimiento.Value.Date;
                DateTime fechaCreacion = DateTime.Now;
                string direccion = txtDireccionUsuario.Text;
                int telefono = int.Parse(txtTelefonoUsuario.Text);
                string correo = txtCorreo.Text;
                TipoUsuario tipo = new TipoUsuario();
                tipo.Id = (int)cmbTipoUsuario.SelectedValue;
                Usuario usuario = new Usuario(run, dv, nombre, apellido, contrasena, fechaNacimiento, fechaCreacion,
                    direccion, telefono, correo, tipo);
                bool estaModificado = usuario.ModificarUsuario(usuario);
                if (estaModificado)
                {
                    MessageBox.Show("Usuario modificado");
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("Usuario no ha sido modificado");
                }
            }
            else
            {
                MessageBox.Show(msgEsValido);
            }
        }
        private void EliminarUsuario()
        {
            if (!String.IsNullOrEmpty(txtRunUsuario.Text))
            {
                Usuario usuario = new Usuario();
                bool estaEliminado = usuario.EliminarUsuario(int.Parse(txtRunUsuario.Text));
                if (estaEliminado)
                {
                    MessageBox.Show("Usuario eliminado");
                }
                else
                {
                    MessageBox.Show("Usuario no eliminado");
                }
            }
        }
        #endregion

        #region Botones
        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            BuscarUsuarioPorNombre();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario();
            CargarGrilla();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            ModificarUsuario();
            CargarGrilla();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
            CargarGrilla();
            LimpiarDatos();
        }
        #endregion

        #region Metodo Grilla
        private void grdUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int runUsuario = int.Parse(grdUsuario.Rows[rowIndex].Cells[0].Value.ToString());
            MostrarDatosUsuario(runUsuario);
        }
        #endregion
    }
}
