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
    public partial class frmRevisarVenta : Form
    {
        public frmRevisarVenta()
        {
            InitializeComponent();
            CargarComboboxMedioPago();
            CargarComboboxUsuario();
            CargarGrilla();
        }

        #region Metodos
        private void CargarGrilla()
        {
            Boleta boleta = new Boleta();
            grdBoleta.DataSource = boleta.ListarBoletas();
        }
        private void CargarComboboxMedioPago()
        {
            Controlador.MedioPago medioPago = new Controlador.MedioPago();
            cmbMedioPago.DisplayMember = "Descripcion";
            cmbMedioPago.ValueMember = "Id";
            cmbMedioPago.DataSource = medioPago.Listar();
        }
        private void CargarComboboxUsuario()
        {
            Controlador.Usuario usuario = new Controlador.Usuario();
            cmbVendedores.DisplayMember = "NombreUsuario";
            cmbVendedores.ValueMember = "RunUsuario";
            cmbVendedores.DataSource = usuario.ListarCombobox();
        }
        #endregion

        private void cmbMedioPago_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbMedioPago.SelectedValue != null)
            {
                Boleta boleta = new Boleta();
                grdBoleta.DataSource = boleta.ListarPorMedioPago((int)cmbMedioPago.SelectedValue);
            }
        }
    }
}
