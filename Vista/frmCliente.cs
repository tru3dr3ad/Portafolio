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
            CargarGrilla();
        }
        #region Metodos
        private void CargarGrilla()
        {
            Cliente cliente = new Cliente();
            grdCliente.DataSource = cliente.Listar();
        }
        public void CapturarDatos()
        {
            int rut = int.Parse(txtRunCliente.Text);
            char dv = char.Parse(txtDv.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value.Date;
            string direccion = txtDireccion.Text;
            int telefono = int.Parse(txtTelefono.Text);

            Cliente cliente = new Cliente(rut, dv, nombre, apellido, fechaNacimiento, direccion, telefono, 1, 1);
            cliente.AgregarCliente();
        }
        private void CargarComboboxTipoCliente()
        {
            Controlador.TipoCliente tipoCliente = new Controlador.TipoCliente();
            cmbTipoCliente.DataSource = tipoCliente.Listar();
            cmbTipoCliente.DisplayMember = "Descripcion";
            cmbTipoCliente.ValueMember = "Id";
        }
        #endregion
        #region Botones
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

            CapturarDatos();
            CargarGrilla();
        }
        #endregion
    }
}
