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
        }

        public void CapturarDatos()
        {
            int rut = int.Parse(txtRunCliente.Text);
            char dv = char.Parse(txtDv.Text);
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            int telefono = int.Parse(txtTelefono.Text);

            Cliente cliente = new Cliente(rut, dv, nombre, direccion, telefono, 1, 1);
            cliente.AgregarCliente();
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            CapturarDatos();
        }
    }
}
