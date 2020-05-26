using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int PrecioVenta { get; set; }
        public int PrecioCompra { get; set; }
        public int Stock { get; set; }
        public int StockCritico { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public Categoria Categoria { get; set; }

        #region Constructores
        public Producto(string codigo, string nombre, string descripcion, int precioVenta, int precioCompra, int stock,
            int stockCritico, DateTime fechaVencimiento, Categoria categoria)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioVenta = precioVenta;
            PrecioCompra = precioCompra;
            Stock = stock;
            StockCritico = stockCritico;
            FechaVencimiento = fechaVencimiento;
            Categoria = categoria;
        }
        public Producto()
        {

        }
        #endregion

        #region Metodos para listar
        public List<Modelo.PRODUCTO> Listar()
        {
            List<Modelo.PRODUCTO> listado = new List<Modelo.PRODUCTO>();
            listado = ConectorDALC.ModeloAlmacen.PRODUCTO.ToList();
            return listado;
        }
        public List<V_PRODUCTOS> ListarProductos()
        {
            List<V_PRODUCTOS> listado = new List<V_PRODUCTOS>();
            listado = ConectorDALC.ModeloAlmacen.V_PRODUCTOS.OrderBy(p => p.CODIGO).ToList();
            return listado;
        }
        public List<V_PRODUCTOS> ListarProductosPorCategoria(int idCategoria)
        {
            List<V_PRODUCTOS> listado = new List<V_PRODUCTOS>();
            listado = ConectorDALC.ModeloAlmacen.V_PRODUCTOS.Where(p => p.CATEGORIAID == idCategoria).
                OrderBy(p => p.CODIGO).ToList();
            return listado;
        }
        #endregion

        #region Metodos
        public Producto ObtenerProducto(string codigo)
        {
            try
            {
                Modelo.PRODUCTO producto = ConectorDALC.ModeloAlmacen.PRODUCTO.FirstOrDefault(e => e.CODIGOPROD == codigo);
                Codigo = producto.CODIGOPROD;
                Nombre = producto.NOMBREPROD;
                Descripcion = producto.DESCRIPPROD;
                PrecioVenta = (int)producto.PRECIOVENTA;
                PrecioCompra = (int)producto.PRECIOCOMPRA;
                Stock = (int)producto.STOCK;
                StockCritico = (int)producto.STOCKCRITICO;
                FechaVencimiento = producto.FECHAVENCIMIENTO;
                Categoria = new Categoria() { Id = (int)producto.CATEGORIA.CATEGORIAID };
                Producto productoEncontrado = new Producto(Codigo, Nombre, Descripcion, PrecioVenta, PrecioCompra, Stock, StockCritico,
                        FechaVencimiento, Categoria);
                return productoEncontrado;
            }
            catch (Exception ex)
            {
                return null;
                throw new ArgumentException("Error al obtener producto: " + ex);
            }
        }
        public bool BuscarProducto(string codigo)
        {
            try
            {
                Modelo.PRODUCTO producto = ConectorDALC.ModeloAlmacen.PRODUCTO.FirstOrDefault(e => e.CODIGOPROD == codigo);
                if (producto != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al buscar: " + ex);
            }
        }
        public bool AgregarProducto()
        {
            try
            {
                Modelo.PRODUCTO producto = new Modelo.PRODUCTO();

                producto.CODIGOPROD = Codigo;
                producto.NOMBREPROD = Nombre;
                producto.DESCRIPPROD = Descripcion;
                producto.PRECIOVENTA = PrecioVenta;
                producto.PRECIOCOMPRA = PrecioCompra;
                producto.STOCK = Stock;
                producto.STOCKCRITICO = StockCritico;
                producto.FECHAVENCIMIENTO = FechaVencimiento;
                producto.CATEGORIA_CATEGORIAID = Categoria.Id;

                ConectorDALC.ModeloAlmacen.PRODUCTO.Add(producto);
                ConectorDALC.ModeloAlmacen.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al agregar producto: " + ex);
            }
        }
        public bool ModificarProducto(Producto modificarProducto)
        {
            try
            {
                if (BuscarProducto(modificarProducto.Codigo))
                {
                    Modelo.PRODUCTO producto = ConectorDALC.ModeloAlmacen.PRODUCTO.FirstOrDefault(e => e.CODIGOPROD == modificarProducto.Codigo);
                    producto.CODIGOPROD = modificarProducto.Codigo;
                    producto.NOMBREPROD = modificarProducto.Nombre;
                    producto.DESCRIPPROD = modificarProducto.Descripcion;
                    producto.PRECIOVENTA = modificarProducto.PrecioVenta;
                    producto.PRECIOCOMPRA = modificarProducto.PrecioCompra;
                    producto.STOCK = modificarProducto.Stock;
                    producto.STOCKCRITICO = modificarProducto.StockCritico;
                    producto.FECHAVENCIMIENTO = FechaVencimiento;
                    producto.CATEGORIA_CATEGORIAID = modificarProducto.Categoria.Id;

                    ConectorDALC.ModeloAlmacen.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al modificar producto: " + ex);
            }
        }
        public bool EliminarProducto(string codigo)
        {
            try
            {
                if (BuscarProducto(codigo))
                {
                    Modelo.PRODUCTO producto = ConectorDALC.ModeloAlmacen.PRODUCTO.FirstOrDefault(e => e.CODIGOPROD == codigo);
                    ConectorDALC.ModeloAlmacen.PRODUCTO.Remove(producto);
                    ConectorDALC.ModeloAlmacen.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al eliminar producto: " + ex);
            }
        }
        public int ObtenerValorVentaProducto(string codigo)
        {
            Producto producto = new Producto();
            producto = producto.ObtenerProducto(codigo);
            int valorVenta = producto.PrecioVenta;
            return valorVenta;
        }
        public int ObtenerValorCompraProducto(string codigo)
        {
            Producto producto = new Producto();
            producto = producto.ObtenerProducto(codigo);
            int valorCompra = producto.PrecioCompra;
            return valorCompra;
        }
        #endregion

    }
}
