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
                txtIdProveedor.Text = proveedor.IdProveedor.ToString();
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
            txtIdProveedor.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            cmbRubro.SelectedIndex = 1;
        }
        #endregion

        #region Metodos de la clase
        private void BuscarProveedor()
        {
            Proveedor proveedor = new Proveedor();
            if (!String.IsNullOrEmpty(txtBuscarProveedor.Text))
            {
                bool existeProveedor = proveedor.BuscarProveedor(int.Parse(txtBuscarProveedor.Text));
                if (existeProveedor)
                {
                    MessageBox.Show("Proveedor encontrado");
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado");
                }
            }
        }
        public void AgregarProveedor()
        {
            if (!String.IsNullOrEmpty(txtRutProveedor.Text))
            {
                int rut = int.Parse(txtRutProveedor.Text);
                char dv = char.Parse(txtDv.Text);
                int id = int.Parse(txtIdProveedor.Text);
                string nombre = txtNombre.Text;
                int telefono = int.Parse(txtTelefono.Text);
                string correo = txtCorreo.Text;
                string direccion = txtDireccion.Text;
                TipoRubro tipo = new TipoRubro();
                tipo.Id = (int)cmbRubro.SelectedValue;
                Proveedor proveedor = new Proveedor(rut, dv, id, nombre, correo, telefono, direccion, tipo);
                if (proveedor.AgregarProveedor())
                {
                    MessageBox.Show("Proveedor ha sido agregado");
                }
            }
        }
        private void ModificarProveedor()
        {
            if (!String.IsNullOrEmpty(txtRutProveedor.Text))
            {
                int rut = int.Parse(txtRutProveedor.Text);
                char dv = char.Parse(txtDv.Text);
                int id = int.Parse(txtIdProveedor.Text);
                string nombre = txtNombre.Text;
                int telefono = int.Parse(txtTelefono.Text);
                string correo = txtCorreo.Text;
                string direccion = txtDireccion.Text;
                TipoRubro tipo = new TipoRubro();
                tipo.Id = (int)cmbRubro.SelectedValue;
                Proveedor proveedor = new Proveedor(rut, dv, id, nombre, correo, telefono, direccion, tipo);
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
            BuscarProveedor();
            txtBuscarProveedor.Clear();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            AgregarProveedor();
            CargarGrilla();
            LimpiarDatos();
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
    }
}
