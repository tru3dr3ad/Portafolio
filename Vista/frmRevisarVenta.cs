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
            CargarGrilla();
            CargarComboboxMedioPago();
            CargarComboboxUsuario();
        }

        #region Metodos
        private void CargarGrilla()
        {
            Boleta boleta = new Boleta();
            grdBoleta.DataSource = boleta.Listar();
        }
        private void CargarComboboxMedioPago()
        {
            Controlador.MedioPago medioPago = new Controlador.MedioPago();
            cmbMedioPago.DataSource = medioPago.Listar();
            cmbMedioPago.DisplayMember = "Descripcion";
            cmbMedioPago.ValueMember = "Id";
        }
        private void CargarComboboxUsuario()
        {
            Controlador.Usuario usuario = new Controlador.Usuario();
            cmbVendedores.DataSource = usuario.Listar();
            cmbVendedores.DisplayMember = "NombreUsuario";
            cmbVendedores.ValueMember = "RunUsuario";
        }
        #endregion
    }
}
