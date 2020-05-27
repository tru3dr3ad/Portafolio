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
        }
        private void EsconderColumnasAutogeneradas()
        {
            grdUsuario.Columns["IDTIPO"].Visible = false;
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
        }
        #endregion

        #region Metodos de la clase
        private void BuscarUsuario()
        {
            Usuario usuario = new Usuario();
            if (!String.IsNullOrEmpty(txtBuscarUsuario.Text))
            {
                bool existeUsuario = usuario.BuscarUsuario(int.Parse(txtBuscarUsuario.Text));
                if (existeUsuario)
                {
                    MessageBox.Show("Usuario encontrado");
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
        }
        public void AgregarUsuario()
        {
            if (!String.IsNullOrEmpty(txtRunUsuario.Text))
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
                TipoUsuario tipo = new TipoUsuario();
                tipo.Id = (int)cmbTipoUsuario.SelectedValue;
                Usuario usuario = new Usuario(run, dv, nombre, apellido, contrasena, fechaNacimiento, fechaCreacion,
                    direccion, telefono, tipo);
                if (usuario.AgregarUsuario())
                {
                    MessageBox.Show("Usuario ha sido Agregado");
                }
            }
        }
        public void ModificarUsuario()
        {
            if (!String.IsNullOrEmpty(txtRunUsuario.Text))
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
                TipoUsuario tipo = new TipoUsuario();
                tipo.Id = (int)cmbTipoUsuario.SelectedValue;
                Usuario usuario = new Usuario(run, dv, nombre, apellido, contrasena, fechaNacimiento, fechaCreacion,
                    direccion, telefono, tipo);
                bool estaModificado = usuario.ModificarUsuario(usuario);
                if (estaModificado)
                {
                    MessageBox.Show("Usuario modificado");
                }
                else
                {
                    MessageBox.Show("Usuario no ha sido modificado");
                }
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
            BuscarUsuario();
            txtBuscarUsuario.Clear();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario();
            CargarGrilla();
            LimpiarDatos();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            ModificarUsuario();
            CargarGrilla();
            LimpiarDatos();
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
