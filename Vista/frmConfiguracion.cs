using Controlador;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
            CargarComboboxRubro();
            CargarComboboxTipoCliente();
            CargarComboboxEstadoFiado();
            CargarComboboxEstadoOrden();
            CargarComboboxCategoria();
        }
        #region Metodos
        private void CargarComboboxRubro()
        {
            Controlador.TipoRubro tipo = new Controlador.TipoRubro();
            cmbRubro.DisplayMember = "Descripcion";
            cmbRubro.ValueMember = "Id";
            cmbRubro.DataSource = tipo.Listar();
        }
        private void CargarComboboxTipoCliente()
        {
            Controlador.TipoCliente tipo = new Controlador.TipoCliente();
            cmbTipoCliente.DisplayMember = "Descripcion";
            cmbTipoCliente.ValueMember = "Id";
            cmbTipoCliente.DataSource = tipo.Listar();
        }
        private void CargarComboboxEstadoFiado()
        {
            Controlador.EstadoFiado tipo = new Controlador.EstadoFiado();
            cmbEstadoFiado.DisplayMember = "Descripcion";
            cmbEstadoFiado.ValueMember = "Id";
            cmbEstadoFiado.DataSource = tipo.Listar();
        }
        private void CargarComboboxEstadoOrden()
        {
            Controlador.EstadoOrden tipo = new Controlador.EstadoOrden();
            cmbEstadoOrden.DisplayMember = "Descripcion";
            cmbEstadoOrden.ValueMember = "Id";
            cmbEstadoOrden.DataSource = tipo.Listar();
        }
        private void CargarComboboxCategoria()
        {
            Controlador.Categoria tipo = new Controlador.Categoria();
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DataSource = tipo.Listar();
        }
        #endregion

        #region
        private void AgregarRubro()
        {
            if (!String.IsNullOrEmpty(txtRubro.Text))
            {
                string descripcion = txtRubro.Text.ToUpper();
                TipoRubro tipo = new TipoRubro(descripcion);
                if (tipo.AgregarRubro(descripcion))
                {
                    MessageBox.Show("Rubro ha sido agregado");
                }
                else
                {
                    MessageBox.Show("Ya existe el rubro");
                }
            }
        }
        private void EliminarRubro()
        {
            if ((int.Parse(cmbRubro.SelectedValue.ToString()))>0)
            {
                TipoRubro rubro = new TipoRubro();
                string descripcion = cmbRubro.Text;
                bool eliminarRubro = rubro.EliminarRubro(descripcion);
                if (eliminarRubro)
                {
                    MessageBox.Show("Rubro eliminado");
                }
                else
                {
                    MessageBox.Show("Rubro no eliminado");
                }
            }
        }

        #endregion

        #region Botones
        private void btnAgregarRubro_Click(object sender, System.EventArgs e)
        {
            AgregarRubro();
            CargarComboboxRubro();
        }
        private void btnEliminarRubro_Click(object sender, EventArgs e)
        {
            EliminarRubro();
            CargarComboboxRubro();
        }
        #endregion

    }
}
