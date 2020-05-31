using System;
using System.Collections.Generic;
using System.Linq;

namespace Controlador
{
    public class OrdenPedido
    {
        public int Numero { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Total { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public Proveedor Proveedor { get; set; }
        public EstadoOrden Estado { get; set; }
        public Usuario Usuario { get; set; }

        #region Constructores
        public OrdenPedido(int numero, DateTime fechaCreacion, int total, DateTime fechaRecepcion, Proveedor proveedor, 
            EstadoOrden estado, Usuario usuario)
        {
            Numero = numero;
            FechaCreacion = fechaCreacion;
            Total = total;
            FechaRecepcion = fechaRecepcion;
            Proveedor = proveedor;
            Estado = estado;
            Usuario = usuario;
        }
        public OrdenPedido(DateTime fechaCreacion, int total, DateTime fechaRecepcion, Proveedor proveedor,
            EstadoOrden estado, Usuario usuario)
        {
            FechaCreacion = fechaCreacion;
            Total = total;
            FechaRecepcion = fechaRecepcion;
            Proveedor = proveedor;
            Estado = estado;
            Usuario = usuario;
        }
        public OrdenPedido()
        {

        }
        #endregion

        #region Metodos para listar
        public List<Modelo.ORDEN_PEDIDO> Listar()
        {
            List<Modelo.ORDEN_PEDIDO> listado = new List<Modelo.ORDEN_PEDIDO>();
            listado = ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.ToList();
            return listado;
        }
        public List<Modelo.V_ORDEN_PEDIDO> ListarOrdenPedido()
        {
            List<Modelo.V_ORDEN_PEDIDO> listado = new List<Modelo.V_ORDEN_PEDIDO>();
            listado = ConectorDALC.ModeloAlmacen.V_ORDEN_PEDIDO.ToList();
            return listado;
        }
        public List<Modelo.V_ORDEN_PEDIDO> ListarOrdenPedidoPorNumero(int nroOrden)
        {
            List<Modelo.V_ORDEN_PEDIDO> listado = new List<Modelo.V_ORDEN_PEDIDO>();
            listado = ConectorDALC.ModeloAlmacen.V_ORDEN_PEDIDO.Where(o => o.NUMERO == nroOrden).ToList();
            return listado;
        }
        public List<Modelo.V_ORDEN_PEDIDO> ListarOrdenPedidoPorProveedor(int rutProveedor)
        {
            List<Modelo.V_ORDEN_PEDIDO> listado = new List<Modelo.V_ORDEN_PEDIDO>();
            listado = ConectorDALC.ModeloAlmacen.V_ORDEN_PEDIDO.Where(o => o.PROVEEDOR_RUT == rutProveedor).ToList();
            return listado;
        }
        public List<Modelo.V_ORDEN_PEDIDO> ListarOrdenPedidoPorEstadoRecepcion(int idEstado)
        {
            List<Modelo.V_ORDEN_PEDIDO> listado = new List<Modelo.V_ORDEN_PEDIDO>();
            listado = ConectorDALC.ModeloAlmacen.V_ORDEN_PEDIDO.Where(o => o.IDESTADO == idEstado).ToList();
            return listado;
        }

        #endregion

        #region Metodos
        public int ObtenerNumeroMaximoOrden()
        {
            try
            {
                int numero = (int)ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.Max(o =>o.NUMEROORDEN);
                return numero;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }
        public OrdenPedido ObtenerOrdenPedido(int numero)
        {
            try
            {
                Modelo.ORDEN_PEDIDO ordenPedido = ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.FirstOrDefault(e => e.NUMEROORDEN == numero);
                Numero = (int)ordenPedido.NUMEROORDEN;
                FechaCreacion = ordenPedido.FECHACREACION;
                Total = ordenPedido.TOTAL;
                FechaRecepcion = ordenPedido.FECHARECEPCION;
                Proveedor = new Proveedor() { Rut = (int)ordenPedido.PROVEEDOR.RUT};
                Estado = new EstadoOrden() { Id = (int)ordenPedido.ESTADO_ORDEN.IDESTADO};
                Usuario = new Usuario() { RunUsuario = (int)ordenPedido.USUARIO.RUNUSUARIO};
                OrdenPedido ordenEncontrada = new OrdenPedido(Numero, FechaCreacion, Total, FechaRecepcion, Proveedor, Estado, Usuario);
                return ordenEncontrada;
            }
            catch (Exception ex)
            {
                return null;
                throw new ArgumentException("Error al obtener orden de pedido: " + ex);
            }
        }
        public bool BuscarOrden(int numero)
        {
            try
            {
                Modelo.ORDEN_PEDIDO orden = ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.FirstOrDefault(e => e.NUMEROORDEN == numero);
                if (orden != null)
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
        public bool AgregarOrdenPedido()
        {
            try
            {
                Modelo.ORDEN_PEDIDO orden = new Modelo.ORDEN_PEDIDO();

                orden.FECHACREACION = FechaCreacion;
                orden.TOTAL = Total;
                orden.FECHARECEPCION = FechaRecepcion;
                orden.PROVEEDOR_RUT = Proveedor.Rut;
                orden.ESTADO_ORDEN_IDESTADO = Estado.Id;
                orden.USUARIO_RUNUSUARIO = Usuario.RunUsuario;

                ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.Add(orden);
                ConectorDALC.ModeloAlmacen.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al agregar orden de pedido" + ex);
            }
        }
        public bool ModificarOrdenPedido(OrdenPedido modificarOrden)
        {
            try
            {
                if (BuscarOrden(modificarOrden.Numero))
                {
                    Modelo.ORDEN_PEDIDO orden = ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.FirstOrDefault(e => e.NUMEROORDEN == modificarOrden.Numero);

                    orden.TOTAL = Total;
                    orden.PROVEEDOR_RUT = Proveedor.Rut;
                    orden.ESTADO_ORDEN_IDESTADO = Estado.Id;
                    orden.USUARIO_RUNUSUARIO = Usuario.RunUsuario;

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
                throw new ArgumentException("Error al modificar orden de pedido: " + ex);
            }
        }
        public bool EliminarOrdenPedido(int numero)
        {
            try
            {
                if (BuscarOrden(numero))
                {
                    Modelo.ORDEN_PEDIDO orden = ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.FirstOrDefault(e => e.NUMEROORDEN == numero);
                    ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.Remove(orden);
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
                throw new ArgumentException("Error al eliminar orden de pedido: " + ex);
            }
        }
        public bool RecepcionarOrdenPedido(OrdenPedido recepcionarOrden)
        {
            try
            {
                if (BuscarOrden(recepcionarOrden.Numero))
                {
                    Modelo.ORDEN_PEDIDO ordenRecepcionar = ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.FirstOrDefault(e => e.NUMEROORDEN == recepcionarOrden.Numero);

                    ordenRecepcionar.FECHARECEPCION = recepcionarOrden.FechaRecepcion;
                    ordenRecepcionar.ESTADO_ORDEN_IDESTADO = recepcionarOrden.Estado.Id;

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
                throw new ArgumentException("Error al recepcionar orden de pedido: " + ex);
            }
        }
        #endregion

    }
}
