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
            MostrarBoletasAnuladas();
            MostrarCantidadProductosBajoStockCritico();
            MostrarOrdenAEsperar();
        }

        #region Metodos
        private void MostrarTopProductos()
        {
            Producto producto = new Producto();
            List<Producto> listado = producto.ListarTopProductos();
            if (listado.Count > 0)
            {
                lblNombreProducto1.Text = listado[0].Nombre;
                lblDescripcionProducto1.Text = CortarDescripcion(listado[0].Descripcion);
                lblPrecioProducto1.Text = "$" + listado[0].PrecioVenta.ToString();
                lblNombreProducto2.Text = listado[1].Nombre;
                lblDescripcionProducto2.Text = CortarDescripcion(listado[1].Descripcion);
                lblPrecioProducto2.Text = "$" + listado[1].PrecioVenta.ToString();
                lblNombreProducto3.Text = listado[2].Nombre;
                lblDescripcionProducto3.Text = CortarDescripcion(listado[2].Descripcion);
                lblPrecioProducto3.Text = "$" + listado[2].PrecioVenta.ToString();
            }
        }
        private string CortarDescripcion(string descripcion)
        {
            if (descripcion.Length > 23)
            {
                descripcion.Substring(0, 23);
            }
            return descripcion;
        }
        private void MostrarTopVentas()
        {
            Boleta boleta = new Boleta();
            List<Boleta> listado = boleta.ListarUltimasBoletas();
            if (listado.Count > 0)
            {
                lblRun1.Text = TraerRunCompleto(listado[0].Cliente.Run);
                lblBoletaNombre1.Text = CortarDescripcion(TraerNombreCompleto(listado[0].Cliente.Run));
                lblFechaBoleta1.Text = listado[0].FechaCreacion.ToShortDateString();
                lblTotal1.Text = "$" + listado[0].Total.ToString();
                lblRun2.Text = TraerRunCompleto(listado[1].Cliente.Run);
                lblBoletaNombre2.Text = CortarDescripcion(TraerNombreCompleto(listado[1].Cliente.Run));
                lblFechaBoleta2.Text = listado[1].FechaCreacion.ToShortDateString();
                lblTotal2.Text = "$" + listado[1].Total.ToString();
                lblRun3.Text = TraerRunCompleto(listado[2].Cliente.Run);
                lblBoletaNombre3.Text = CortarDescripcion(TraerNombreCompleto(listado[2].Cliente.Run));
                lblFechaBoleta3.Text = listado[2].FechaCreacion.ToShortDateString();
                lblTotal3.Text = "$" + listado[2].Total.ToString();
            }
        }
        private string TraerRunCompleto(int runCliente)
        {
            Cliente cliente = new Cliente();
            cliente = cliente.ObtenerCliente(runCliente);
            string run = cliente.Run + "-" + cliente.Dv;
            return run;
        }
        private string TraerNombreCompleto(int runCliente)
        {
            Cliente cliente = new Cliente();
            cliente = cliente.ObtenerCliente(runCliente);
            string nombre = cliente.Nombre + " " + cliente.Apellido;
            return nombre;
        }
        private void MostrarVentasMensuales()
        {
            Boleta boleta = new Boleta();
            int cantidadBoleta = boleta.CantidadBoletasMes();
            lblCantidadBoletas.Text = cantidadBoleta.ToString();
        }
        private void MostrarBoletasAnuladas()
        {
            Boleta boleta = new Boleta();
            int cantidadBoletaAnuladas = boleta.CantidadBoletasAnuladas();
            lblBoletasAnuladas.Text = cantidadBoletaAnuladas.ToString();
        }
        private void MostrarOrdenAEsperar()
        {
            OrdenPedido orden = new OrdenPedido();
            orden = orden.MostrarUltimaOrdenEnviada();
            if (orden != null)
            {
                lblNumeroOrden.Text = "N° " + orden.Numero.ToString();
                Proveedor proveedor = new Proveedor();
                proveedor = proveedor.ObtenerProveedor(orden.Proveedor.Rut);
                lblNombreProveedor.Text = proveedor.Nombre;
            }
        }
        private void MostrarCantidadProductosBajoStockCritico()
        {
            Producto producto = new Producto();
            int cantidad = producto.ContarProductoBajoStockCritico();
            lblCantidadStockMin.Text = cantidad.ToString();
            producto = producto.StockMinimo();
            if (producto != null)
            {
                lblNombreStockMin.Text = producto.Nombre + " | Stock: " + producto.Stock;
            }
        }
        #endregion
    }
}
