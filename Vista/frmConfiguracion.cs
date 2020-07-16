using Controlador;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
            CargarComboboxRubro();
            CargarComboboxCategoria();
            ValorDolar();
            MonedaActual();
        }

        #region Metodos
        private void CargarComboboxRubro()
        {
            Controlador.TipoRubro tipo = new Controlador.TipoRubro();
            cmbRubro.DisplayMember = "Descripcion";
            cmbRubro.ValueMember = "Id";
            cmbRubro.DataSource = tipo.Listar();
        }
        private void CargarComboboxCategoria()
        {
            Controlador.Categoria tipo = new Controlador.Categoria();
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DataSource = tipo.Listar();
        }
        private void CambioMoneda()
        {
            Dolar dolar = new Dolar();
            decimal dolarValor = dolar.ObtenerValorDolar();
            Producto producto = new Producto();
            string nombreMoneda = "";

            if (lblMonedaActual.Text == "CLP")
            {
                nombreMoneda = "USD";
            }
            else if(lblMonedaActual.Text == "USD")
            {
                nombreMoneda = "CLP";
            }
            producto.CambiarPrecioPorMoneda(nombreMoneda, dolarValor);
        }
        private void MonedaActual()
        {
            Producto producto = new Producto();
            if (producto.ContieneDecimal())
            {
                lblMonedaActual.Text = "USD";
            }
            else
            {
                lblMonedaActual.Text = "CLP";
            }
        }
        private void ValorDolar()
        {
            Dolar dolar = new Dolar();
            decimal valor = dolar.ObtenerValorDolar();
            lblValorDolar.Text = valor.ToString("C2", new CultureInfo("en-US"));
        }
        #endregion

        #region Metodos de la clase
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
            if ((int.Parse(cmbRubro.SelectedValue.ToString())) > 0)
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
        private void btnMoneda_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Es necesario cerrar la aplicacion para realizar este cambio, ¿Esta seguro que desea continuar?", "Cambio de Moneda", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CambioMoneda();
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
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
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string rutaAyuda = @"\Ayuda\Ayuda.chm";
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string ayudaPath = projectDirectory + rutaAyuda;
            Help.ShowHelp(this, ayudaPath, "Configuración.htm");
        }

        #endregion

        #region Eventos
        private void txtRubro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        #endregion

      
    }
}
