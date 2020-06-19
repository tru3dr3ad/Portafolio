using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controlador
{
    public class DetallePedido
    {
        public int IdDetalle { get; set; }
        public int NumeroOrden { get; set; }
        public string CodigoProducto { get; set; }
        public int Cantidad { get; set; }

        #region Constructores
        public DetallePedido(int idDetalle, int numeroOrden, string codProducto, int cantidad)
        {
            IdDetalle = idDetalle;
            NumeroOrden = numeroOrden;
            CodigoProducto = codProducto;
            Cantidad = cantidad;
        }
        public DetallePedido(int numeroOrden, string codProducto, int cantidad)
        {
            NumeroOrden = numeroOrden;
            CodigoProducto = codProducto;
            Cantidad = cantidad;
        }
        public DetallePedido()
        {

        }
        #endregion

        #region Metodos de la clase
        public List<Modelo.DETALLE_PEDIDO> Listar()
        {
            List<Modelo.DETALLE_PEDIDO> listado = new List<Modelo.DETALLE_PEDIDO>();
            listado = ConectorDALC.ModeloAlmacen.DETALLE_PEDIDO.ToList();
            return listado;
        }
        public List<Modelo.V_DETALLE_ORDEN> ListarDetallePorOrden(int numero)
        {
            List<Modelo.V_DETALLE_ORDEN> listado = new List<Modelo.V_DETALLE_ORDEN>();
            listado = ConectorDALC.ModeloAlmacen.V_DETALLE_ORDEN.Where(d => d.ORDEN_PEDIDO_NUMEROORDEN == numero).
                ToList();
            return listado;
        }
        public List<DetallePedido> ListaProductoCantidadDetalle(int numeroOrden)
        {
            OrdenPedido orden = new OrdenPedido();
            orden = orden.ObtenerOrdenPedido(numeroOrden);
            List<DETALLE_PEDIDO> listadoModelo = ConectorDALC.ModeloAlmacen.DETALLE_PEDIDO.
                Where(d => d.ORDEN_PEDIDO_NUMEROORDEN == numeroOrden).ToList();
            List<DetallePedido> listadoD = new List<DetallePedido>();
            foreach (DETALLE_PEDIDO item in listadoModelo)
            {
                DetallePedido detalle = new DetallePedido();
                detalle.CodigoProducto = item.PRODUCTO_CODIGO;
                detalle.Cantidad = (int)item.CANTIDAD;
                listadoD.Add(detalle);
            }
            return listadoD;
        }
        public bool BuscarDetallePedido(int idDetalle)
        {
            try
            {
                Modelo.DETALLE_PEDIDO detallePedido = ConectorDALC.ModeloAlmacen.DETALLE_PEDIDO.FirstOrDefault(e => e.IDDETALLEO == idDetalle);
                if (detallePedido != null)
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
                throw new ArgumentException("Error al buscar" + ex);
            }
        }
        public bool AgregarDetallePedido()
        {
            try
            {
                Modelo.DETALLE_PEDIDO detallePedido = new Modelo.DETALLE_PEDIDO();

                detallePedido.ORDEN_PEDIDO_NUMEROORDEN = NumeroOrden;
                detallePedido.PRODUCTO_CODIGO = CodigoProducto;
                detallePedido.CANTIDAD = Cantidad;

                ConectorDALC.ModeloAlmacen.DETALLE_PEDIDO.Add(detallePedido);
                ConectorDALC.ModeloAlmacen.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al agregar detalle de pedido: " + ex);
            }
        }
        public bool EliminarDetallePedido(int idDetalle)
        {
            try
            {
                if (BuscarDetallePedido(idDetalle))
                {
                    Modelo.DETALLE_PEDIDO detallePedido = ConectorDALC.ModeloAlmacen.DETALLE_PEDIDO.FirstOrDefault(e => e.IDDETALLEO == idDetalle);
                    ConectorDALC.ModeloAlmacen.DETALLE_PEDIDO.Remove(detallePedido);
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
                throw new ArgumentException("Error al eliminar detalle de pedido: " + ex);
            }
        }
        public bool AgregarStockOrdenRecepcionada(int numero)
        {
            List<DetallePedido> listado = new List<DetallePedido>();
            listado = ListaProductoCantidadDetalle(numero);
            foreach (DetallePedido item in listado)
            {
                Producto producto = new Producto();
                producto = producto.ObtenerProducto(item.CodigoProducto);
                producto.Stock = producto.Stock + item.Cantidad;
                bool estaAgregado = producto.ModificarProducto(producto);
                if (estaAgregado)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        #endregion

    }
}
