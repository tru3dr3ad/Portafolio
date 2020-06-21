using Modelo;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controlador
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }
        public int Stock { get; set; }
        public int StockCritico { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public char Estado { get; set; }
        public Categoria Categoria { get; set; }

        #region Constructores
        public Producto(string codigo, string nombre, string descripcion, decimal precioVenta, decimal precioCompra, int stock,
            int stockCritico, DateTime fechaVencimiento, char estado, Categoria categoria)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioVenta = precioVenta;
            PrecioCompra = precioCompra;
            Stock = stock;
            StockCritico = stockCritico;
            FechaVencimiento = fechaVencimiento;
            Estado = estado;
            Categoria = categoria;
        }
        public Producto(string codigo, string nombre, string descripcion, decimal precioVenta, decimal precioCompra, int stock,
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
        //public List<V_PRODUCTOS> ListarProductos()
        //{
        //    List<V_PRODUCTOS> listado = new List<V_PRODUCTOS>();
        //    listado = ConectorDALC.ModeloAlmacen.V_PRODUCTOS.OrderBy(p => p.CODIGO).ToList();
        //    return listado;
        //}
        public List<V_PRODUCTOS> ListarProductos()
        {
            List<V_PRODUCTOS> listado = new List<V_PRODUCTOS>();
            listado = ConectorDALC.ModeloAlmacen.V_PRODUCTOS.OrderBy(p => p.CODIGO).ToList();
            foreach (var item in listado)
            {
                if (item.ESTADO == "1")
                {
                    item.ESTADO = "ACTIVADO";
                }
                else if (item.ESTADO == "0")
                {
                    item.ESTADO = "NO ACTIVO";
                }
            }

            return listado;
        }
        public List<V_PRODUCTOS> ListarProductosPorNombre(string nombre)
        {
            List<V_PRODUCTOS> listado = new List<V_PRODUCTOS>();
            listado = ConectorDALC.ModeloAlmacen.V_PRODUCTOS.Where(p => p.NOMBRE.Contains(nombre)).
                OrderBy(p => p.NOMBRE).ToList();
            return listado;
        }
        public List<V_PRODUCTOS> ListarProductosPorCategoria(int idCategoria)
        {
            List<V_PRODUCTOS> listado = new List<V_PRODUCTOS>();
            listado = ConectorDALC.ModeloAlmacen.V_PRODUCTOS.Where(p => p.IDCATEGORIA == idCategoria).
                OrderBy(p => p.CODIGO).ToList();
            return listado;
        }
        public List<Producto> ListarTopProductos()
        {
            List<Producto> listaP = new List<Producto>();


            List<V_TOP_PRODUCTOS> listado = new List<V_TOP_PRODUCTOS>();
            listado = ConectorDALC.ModeloAlmacen.V_TOP_PRODUCTOS.ToList();

            foreach (V_TOP_PRODUCTOS item in listado)
            {
                Producto producto = new Producto();
                producto.Nombre = item.NOMBRE;
                producto.Descripcion = item.DESCRIPCION;
                producto.PrecioVenta = (int)item.PRECIOVENTA;
                listaP.Add(producto);
            }

            return listaP;
        }
        #endregion

        #region Metodos
        //TODO cambiar implementacion por subconsultas
        public Producto StockMinimo()
        {
            try
            {
                int minimoStock = int.Parse(ConectorDALC.ModeloAlmacen.PRODUCTO.Min(p => p.STOCK).ToString());

                Modelo.PRODUCTO productoModelo = ConectorDALC.ModeloAlmacen.PRODUCTO.
                    Where(p => p.STOCK < p.STOCKCRITICO).FirstOrDefault(e => e.STOCK == minimoStock);
                if (productoModelo != null)
                {
                    Producto producto = new Producto
                    {
                        Codigo = productoModelo.CODIGO.ToString(),
                        Nombre = productoModelo.NOMBRE,
                        Stock = int.Parse(productoModelo.STOCK.ToString())
                    };
                    return producto;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public int ContarProductoBajoStockCritico()
        {
            try
            {
                int cantidadBoletas = (int)ConectorDALC.ModeloAlmacen.PRODUCTO.Where(p => p.STOCK <= p.STOCKCRITICO).
                    Count();
                return cantidadBoletas;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }
        public Producto ObtenerProducto(string codigo)
        {
            try
            {
                Modelo.PRODUCTO producto = ConectorDALC.ModeloAlmacen.PRODUCTO.FirstOrDefault(e => e.CODIGO == codigo);
                Codigo = producto.CODIGO;
                Nombre = producto.NOMBRE;
                Descripcion = producto.DESCRIPCION;
                PrecioVenta = producto.PRECIOVENTA;
                PrecioCompra = producto.PRECIOCOMPRA;
                Stock = (int)producto.STOCK;
                StockCritico = (int)producto.STOCKCRITICO;
                FechaVencimiento = producto.FECHAVENCIMIENTO;
                Estado = char.Parse(producto.ESTADO);
                Categoria = new Categoria() { Id = (int)producto.CATEGORIA.IDCATEGORIA };
                Producto productoEncontrado = new Producto(Codigo, Nombre, Descripcion, PrecioVenta, PrecioCompra, Stock, StockCritico,
                        FechaVencimiento, Estado, Categoria);
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
                Modelo.PRODUCTO producto = ConectorDALC.ModeloAlmacen.PRODUCTO.FirstOrDefault(e => e.CODIGO == codigo);
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

                producto.CODIGO = Codigo;
                producto.NOMBRE = Nombre;
                producto.DESCRIPCION = Descripcion;
                producto.PRECIOVENTA = PrecioVenta;
                producto.PRECIOCOMPRA = PrecioCompra;
                producto.STOCK = Stock;
                producto.STOCKCRITICO = StockCritico;
                producto.FECHAVENCIMIENTO = FechaVencimiento;
                producto.ESTADO = Estado.ToString();
                producto.CATEGORIA_IDCATEGORIA = Categoria.Id;

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
                    Modelo.PRODUCTO producto = ConectorDALC.ModeloAlmacen.PRODUCTO.FirstOrDefault(e => e.CODIGO == modificarProducto.Codigo);
                    producto.CODIGO = modificarProducto.Codigo;
                    producto.NOMBRE = modificarProducto.Nombre;
                    producto.DESCRIPCION = modificarProducto.Descripcion;
                    producto.PRECIOVENTA = modificarProducto.PrecioVenta;
                    producto.PRECIOCOMPRA = modificarProducto.PrecioCompra;
                    producto.STOCK = modificarProducto.Stock;
                    producto.STOCKCRITICO = modificarProducto.StockCritico;
                    producto.FECHAVENCIMIENTO = FechaVencimiento;
                    producto.CATEGORIA_IDCATEGORIA = modificarProducto.Categoria.Id;

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
                    Modelo.PRODUCTO producto = ConectorDALC.ModeloAlmacen.PRODUCTO.FirstOrDefault(e => e.CODIGO == codigo);
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
        public decimal ObtenerValorVentaProducto(string codigo)
        {
            Producto producto = new Producto();
            producto = producto.ObtenerProducto(codigo);
            decimal valorVenta = producto.PrecioVenta;
            return valorVenta;
        }
        public decimal ObtenerValorCompraProducto(string codigo)
        {
            Producto producto = new Producto();
            producto = producto.ObtenerProducto(codigo);
            decimal valorCompra = producto.PrecioCompra;
            return valorCompra;
        }
        #endregion

        #region Cambio Moneda
        public void CambiarPrecioPorMoneda(string nombreMoneda, decimal valorMoneda)
        {
            try
            {
                string sql = "BEGIN SP_MONEDA_CAMBIO(:NOMBRE_MONEDA, :VALOR); end; ";
                Conexion conexion = new Conexion();
                OracleConnection connection = conexion.ConexionBd();
                connection.Open();


                OracleCommand command = connection.CreateCommand();
                command.CommandText = sql;
                command.Parameters.Add(new OracleParameter("NOMBRE_MONEDA", nombreMoneda));
                command.Parameters.Add(new OracleParameter("VALOR", valorMoneda));
                OracleDataReader reader = command.ExecuteReader();
                reader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion
    }
}
