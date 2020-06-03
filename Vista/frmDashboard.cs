using Controlador;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            MostrarTopProductos();
            //MostrarTopVentas();
        }
        private void MostrarTopProductos()
        {
            Producto producto = new Producto();
            List<Producto> listado = producto.ListarTopProductos();
            lblNombreProducto1.Text = listado[0].Nombre;
            lblDescripcionProducto1.Text = listado[0].Descripcion;
            lblPrecioProducto1.Text = listado[0].PrecioVenta.ToString();
            lblNombreProducto2.Text = listado[1].Nombre;
            lblDescripcionProducto2.Text = listado[1].Descripcion;
            lblPrecioProducto2.Text = listado[1].PrecioVenta.ToString();
            lblNombreProducto3.Text = listado[2].Nombre;
            lblDescripcionProducto3.Text = listado[2].Descripcion;
            lblPrecioProducto3.Text = listado[2].PrecioVenta.ToString();
        }
        private void MostrarTopVentas()
        {
            Boleta boleta = new Boleta();
            List<Boleta> listado = boleta.ListarTopBoletas();
            lblRun1.Text = listado[0].Cliente.Run.ToString();
            lblBoletaNombre1.Text = listado[0].Cliente.Nombre;
            lblFechaBoleta1.Text = listado[0].FechaCreacion.ToString();
        }
    }
}
