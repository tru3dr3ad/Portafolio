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
            MostrarTopVentas();
            MostrarVentasMensuales();
            MostrarProductoConMenosStock();
            MostrarOrdenAEsperar();
        }
        private void MostrarTopProductos()
        {
            Producto producto = new Producto();
            List<Producto> listado = producto.ListarTopProductos();
            if (listado.Count > 0)
            {
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

        }
        private void MostrarTopVentas()
        {
            Boleta boleta = new Boleta();
            List<Boleta> listado = boleta.ListarTopBoletas();
            if (listado.Count > 0)
            {
                lblRun1.Text = listado[0].Cliente.Run.ToString();
                lblBoletaNombre1.Text = listado[0].Cliente.Nombre;
                lblFechaBoleta1.Text = listado[0].FechaCreacion.ToShortDateString();
                lblTotal1.Text = listado[0].Total.ToString();
                lblRun2.Text = listado[1].Cliente.Run.ToString();
                lblBoletaNombre2.Text = listado[1].Cliente.Nombre;
                lblFechaBoleta2.Text = listado[1].FechaCreacion.ToShortDateString();
                lblTotal2.Text = listado[1].Total.ToString();
                lblRun3.Text = listado[2].Cliente.Run.ToString();
                lblBoletaNombre3.Text = listado[2].Cliente.Nombre;
                lblFechaBoleta3.Text = listado[2].FechaCreacion.ToShortDateString();
                lblTotal3.Text = listado[2].Total.ToString();
            }
        }
        private void MostrarVentasMensuales()
        {
            Boleta boleta = new Boleta();
            int cantidadBoleta = boleta.CantidadBoletasMes();
            lblCantidadBoletas.Text = cantidadBoleta.ToString();
        }
        private void MostrarProductoConMenosStock()
        {
            
            Producto producto = new Producto();
            producto = producto.StockMinimo();
            if (producto!=null)
            {
                lblCantidadStockMin.Text = producto.Stock.ToString();
                lblNombreStockMin.Text = producto.Nombre;
            }
        }
        private void MostrarOrdenAEsperar()
        {
            OrdenPedido orden = new OrdenPedido();
            orden = orden.MostrarUltimaOrdenEnviada();
            if (orden!=null)
            {
                lblNumeroOrden.Text = orden.Numero.ToString();
                //lblNombreProveedor.Text = orden.Proveedor.Rut.ToString();
                Proveedor proveedor = new Proveedor();
                proveedor = proveedor.ObtenerProveedor(orden.Proveedor.Rut);
                lblNombreProveedor.Text = proveedor.Nombre;
            }
        }
    }
}
