using Controlador;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
            CargarComboboxTipoRubro();
            CargarGrilla();
        }

        #region Metodos
        private void CargarGrilla()
        {
            Proveedor proveedor = new Proveedor();
            grdProveedor.DataSource = proveedor.ListarProveedor();
            EsconderColumnasAutogeneradas();
        }
        private void EsconderColumnasAutogeneradas()
        {
            grdProveedor.Columns["IDRUBRO"].Visible = false;
            grdProveedor.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void CargarComboboxTipoRubro()
        {
            Controlador.TipoRubro tipoRubro = new Controlador.TipoRubro();
            cmbRubro.DataSource = tipoRubro.Listar();
            cmbRubro.DisplayMember = "Descripcion";
            cmbRubro.ValueMember = "Id";
        }
        public bool MostrarDatosProveedor(int rut)
        {
            Proveedor proveedor = new Proveedor();
            proveedor = proveedor.ObtenerProveedor(rut);
            if (proveedor != null)
            {
                txtRutProveedor.Text = proveedor.Rut.ToString();
                txtDv.Text = proveedor.Dv.ToString();
                txtNombre.Text = proveedor.Nombre;
                txtTelefono.Text = proveedor.Telefono.ToString();
                txtCorreo.Text = proveedor.CorreoElectronico;
                txtDireccion.Text = proveedor.Direccion;
                cmbRubro.SelectedValue = proveedor.Tipo.Id;
                return true;
            }
            else
            {
                return false;
            }
        }
        private void LimpiarDatos()
        {
            txtRutProveedor.Clear();
            txtDv.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            cmbRubro.SelectedIndex = 1;
        }
        private string ValidacionIngresoProveedor()
        {
            string mensajeError = string.Empty;
            string runProveedor = txtRutProveedor.Text + "-" + txtDv.Text;
            Validaciones validaciones = new Validaciones();
            if (validaciones.ValidarRun(runProveedor))
            {
                if (validaciones.ValidarLargoString(3, 70, txtNombre.Text))
                {
                    if (validaciones.ValidarNumeroTelefono(txtTelefono.Text))
                    {
                        if (validaciones.ValidarLargoString(10, 250, txtCorreo.Text))
                        {
                            if (validaciones.ValidarEmail(txtCorreo.Text))
                            {
                                if (validaciones.ValidarLargoString(10, 150, txtDireccion.Text))
                                {
                                    return mensajeError;
                                }
                                else
                                {
                                    mensajeError = "EL largo de la direccion es invalida";
                                }
                            }
                            else
                            {
                                mensajeError = "El correo electronico no tiene un formato correcto";
                            }
                        }
                        else
                        {
                            mensajeError = "El largo del correo es invalido";
                        }
                    }
                    else
                    {
                        mensajeError = "El numero de celular es invalido";
                    }
                }
                else
                {
                    mensajeError = "El largo del nombre de proveedor es invalido";
                }
            }
            else
            {
                mensajeError = "El rut del proveedor es invalido";
            }
            return mensajeError;
        }
        #endregion

        #region Metodos de la clase
        private void BuscarProveedorPorNombre()
        {
            string nombre = txtBuscarProveedor.Text.ToUpper();
            Proveedor proveedor = new Proveedor();
            grdProveedor.DataSource = proveedor.ListarProveedorPorNombre(nombre);
            txtBuscarProveedor.Clear();
            EsconderColumnasAutogeneradas();
        }
        public void AgregarProveedor()
        {
            string msgEsValido = ValidacionIngresoProveedor();
            if (string.IsNullOrEmpty(msgEsValido))
            {
                int rut = int.Parse(txtRutProveedor.Text);
                char dv = char.Parse(txtDv.Text);
                string nombre = txtNombre.Text.ToUpper();
                int telefono = int.Parse(txtTelefono.Text);
                string correo = txtCorreo.Text.ToUpper();
                string direccion = txtDireccion.Text.ToUpper();
                TipoRubro tipo = new TipoRubro();
                tipo.Id = (int)cmbRubro.SelectedValue;
                Proveedor proveedor = new Proveedor(rut, dv, nombre, correo, telefono, direccion, tipo);
                if (proveedor.AgregarProveedor())
                {
                    MessageBox.Show("Proveedor ha sido agregado");
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show(msgEsValido);
            }
        }
        private void ModificarProveedor()
        {
            if (!String.IsNullOrEmpty(txtRutProveedor.Text))
            {
                int rut = int.Parse(txtRutProveedor.Text);
                char dv = char.Parse(txtDv.Text);
                string nombre = txtNombre.Text.ToUpper();
                int telefono = int.Parse(txtTelefono.Text);
                string correo = txtCorreo.Text.ToUpper();
                string direccion = txtDireccion.Text.ToUpper();
                TipoRubro tipo = new TipoRubro();
                tipo.Id = (int)cmbRubro.SelectedValue;
                Proveedor proveedor = new Proveedor(rut, dv, nombre, correo, telefono, direccion, tipo);
                bool modificarProveedor = proveedor.ModificarProveedor(proveedor);
                if (modificarProveedor)
                {
                    MessageBox.Show("Proveedor actualizado");
                }
                else
                {
                    MessageBox.Show("Proveedor no se ha actualizado");
                }
            }
        }
        private void EliminarProveedor()
        {
            if (!String.IsNullOrEmpty(txtRutProveedor.Text))
            {
                Proveedor proveedor = new Proveedor();
                bool eliminarProveedor = proveedor.EliminarProveedor(int.Parse(txtRutProveedor.Text));
                if (eliminarProveedor)
                {
                    MessageBox.Show("Proveedor eliminado");
                }
                else
                {
                    MessageBox.Show("Proveedor no eliminado");
                }
            }
        }
        #endregion

        #region Botones
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            BuscarProveedorPorNombre();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            AgregarProveedor();
            CargarGrilla();

        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            ModificarProveedor();
            CargarGrilla();
            LimpiarDatos();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            EliminarProveedor();
            CargarGrilla();
            LimpiarDatos();
        }
        #endregion

        #region Metodo Grilla
        private void grdProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int rutProveedor = int.Parse(grdProveedor.Rows[rowIndex].Cells[0].Value.ToString());
            MostrarDatosProveedor(rutProveedor);
        }
        #endregion

        #region Eventos
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtIdProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtRutProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

    }
}
