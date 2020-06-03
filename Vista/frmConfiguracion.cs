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
        private void AgregarTipoCliente()
        {
            if (!String.IsNullOrEmpty(txtTipoCliente.Text))
            {
                string descripcion = txtTipoCliente.Text.ToUpper();
                TipoCliente tipo = new TipoCliente(descripcion);
                if (tipo.AgregarTipoCliente(descripcion))
                {
                    MessageBox.Show("Tipo de cliente ha sido agregado");
                }
                else
                {
                    MessageBox.Show("Ya existe ese tipo de cliente");
                }
            }
        }
        private void EliminarTipoCliente()
        {
            if ((int.Parse(cmbTipoCliente.SelectedValue.ToString())) > 0)
            {
                TipoCliente tipo = new TipoCliente();
                string descripcion = cmbTipoCliente.Text;
                bool eliminarTipo = tipo.EliminarTipoCliente(descripcion);
                if (eliminarTipo)
                {
                    MessageBox.Show("Tipo de cliente eliminado");
                }
                else
                {
                    MessageBox.Show("Tipo de cliente no eliminado");
                }
            }
        }
        private void AgregarEstadoFiado()
        {
            if (!String.IsNullOrEmpty(txtEstadoFiado.Text))
            {
                string descripcion = txtEstadoFiado.Text.ToUpper();
                EstadoFiado estado = new EstadoFiado(descripcion);
                if (estado.AgregarEstadoFiado(descripcion))
                {
                    MessageBox.Show("Estado de fiado ha sido agregado");
                }
                else
                {
                    MessageBox.Show("Ya existe ese estado de fiado");
                }
            }
        }
        private void EliminarEstadoFiado()
        {
            if ((int.Parse(cmbEstadoFiado.SelectedValue.ToString())) > 0)
            {
                EstadoFiado estado = new EstadoFiado();
                string descripcion = cmbEstadoFiado.Text;
                bool eliminarEstado = estado.EliminarEstadoFiado(descripcion);
                if (eliminarEstado)
                {
                    MessageBox.Show("Estado de fiado eliminado");
                }
                else
                {
                    MessageBox.Show("Estado de fiado no eliminado");
                }
            }
        }
        private void AgregarEstadoOrden()
        {
            if (!String.IsNullOrEmpty(txtEstadoOrden.Text))
            {
                string descripcion = txtEstadoOrden.Text.ToUpper();
                EstadoOrden estado = new EstadoOrden(descripcion);
                if (estado.AgregarEstadoOrden(descripcion))
                {
                    MessageBox.Show("Estado de orden de pedido ha sido agregado");
                }
                else
                {
                    MessageBox.Show("Ya existe ese estado de orden de pedido");
                }
            }
        }
        private void EliminarEstadoOrden()
        {
            if ((int.Parse(cmbEstadoOrden.SelectedValue.ToString())) > 0)
            {
                EstadoOrden estado = new EstadoOrden();
                string descripcion = cmbEstadoOrden.Text;
                bool eliminarEstado = estado.EliminarEstadoOrden(descripcion);
                if (eliminarEstado)
                {
                    MessageBox.Show("Estado de orden de pedido eliminado");
                }
                else
                {
                    MessageBox.Show("Estado de orden de pedido no eliminado");
                }
            }
        }
        private void AgregarCategoria()
        {
            if (!String.IsNullOrEmpty(txtCategoria.Text))
            {
                string descripcion = txtCategoria.Text.ToUpper();
                Categoria categoria = new Categoria(descripcion);
                if (categoria.AgregarCategoria(descripcion))
                {
                    MessageBox.Show("Categoria ha sido agregada");
                }
                else
                {
                    MessageBox.Show("Ya existe esa categoria");
                }
            }
        }
        private void EliminarCategoria()
        {
            if ((int.Parse(cmbCategoria.SelectedValue.ToString())) > 0)
            {
                Categoria categoria = new Categoria();
                string descripcion = cmbCategoria.Text;
                bool eliminarCategoria = categoria.EliminarCategoria(descripcion);
                if (eliminarCategoria)
                {
                    MessageBox.Show("Categoria eliminada");
                }
                else
                {
                    MessageBox.Show("Categoria no se ha eliminado");
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
        private void btnAgregarTipoCliente_Click(object sender, EventArgs e)
        {
            AgregarTipoCliente();
            CargarComboboxTipoCliente();
        }

        private void btnEliminarTipoCliente_Click(object sender, EventArgs e)
        {
            EliminarTipoCliente();
            CargarComboboxTipoCliente();
        }

        private void btnAgregarEstadoFiado_Click(object sender, EventArgs e)
        {
            AgregarEstadoFiado();
            CargarComboboxEstadoFiado();
        }

        private void btnEliminarEstadoFiado_Click(object sender, EventArgs e)
        {
            EliminarEstadoFiado();
            CargarComboboxEstadoFiado();
        }

        private void btnAgregarEstadoOrden_Click(object sender, EventArgs e)
        {
            AgregarEstadoOrden();
            CargarComboboxEstadoOrden();
        }

        private void btnEliminarEstadoOrden_Click(object sender, EventArgs e)
        {
            EliminarEstadoOrden();
            CargarComboboxEstadoOrden();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            AgregarCategoria();
            CargarComboboxCategoria();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            EliminarCategoria();
            CargarComboboxCategoria();
        }
        #endregion
    }
}
