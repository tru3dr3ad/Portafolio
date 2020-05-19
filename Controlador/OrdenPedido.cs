using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class OrdenPedido
    {
        public int Numero { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Valor { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public Proveedor Proveedor { get; set; }
        public EstadoOrden Estado { get; set; }
        public Usuario Usuario { get; set; }

        #region Constructores
        public OrdenPedido(int numero, DateTime fechaCreacion, int valor, DateTime fechaRecepcion, Proveedor proveedor, 
            EstadoOrden estado, Usuario usuario)
        {
            Numero = numero;
            FechaCreacion = fechaCreacion;
            Valor = valor;
            FechaRecepcion = fechaRecepcion;
            Proveedor = proveedor;
            Estado = estado;
            Usuario = usuario;
        }
        public OrdenPedido(DateTime fechaCreacion, int valor, DateTime fechaRecepcion, Proveedor proveedor,
            EstadoOrden estado, Usuario usuario)
        {
            FechaCreacion = fechaCreacion;
            Valor = valor;
            FechaRecepcion = fechaRecepcion;
            Proveedor = proveedor;
            Estado = estado;
            Usuario = usuario;
        }
        public OrdenPedido()
        {

        }
        #endregion

        #region Metodos
        public List<Modelo.ORDEN_PEDIDO> Listar()
        {
            List<Modelo.ORDEN_PEDIDO> listado = new List<Modelo.ORDEN_PEDIDO>();
            listado = ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.ToList();
            return listado;
        }
        public int ObtenerNumeroMaximoOrden()
        {
            try
            {
                int numero = (int)ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.Max(o =>o.NUMERORDEN);
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
                Modelo.ORDEN_PEDIDO ordenPedido = ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.FirstOrDefault(e => e.NUMERORDEN == numero);
                Numero = (int)ordenPedido.NUMERORDEN;
                FechaCreacion = ordenPedido.FECHAORDEN;
                Valor = ordenPedido.VALORORDEN;
                FechaRecepcion = ordenPedido.FECHARECEPCION;
                Proveedor = new Proveedor() { Rut = (int)ordenPedido.PROVEEDOR.RUTPROVEEDOR};
                Estado = new EstadoOrden() { Id = (int)ordenPedido.ESTADO_ORDEN.ESTADOID};
                Usuario = new Usuario() { RunUsuario = (int)ordenPedido.USUARIO.RUNUSUARIO};
                OrdenPedido ordenEncontrada = new OrdenPedido(Numero, FechaCreacion, Valor, FechaRecepcion, Proveedor, Estado, Usuario);
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
                Modelo.ORDEN_PEDIDO orden = ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.FirstOrDefault(e => e.NUMERORDEN == numero);
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

                orden.FECHAORDEN = FechaCreacion;
                orden.VALORORDEN = Valor;
                orden.FECHARECEPCION = FechaRecepcion;
                orden.PROVEEDOR_RUTPROVEEDOR = Proveedor.Rut;
                orden.ESTADO_ORDEN_ESTADOID = Estado.Id;
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
                    Modelo.ORDEN_PEDIDO orden = ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.FirstOrDefault(e => e.NUMERORDEN == modificarOrden.Numero);

                    orden.VALORORDEN = Valor;
                    orden.PROVEEDOR_RUTPROVEEDOR = Proveedor.Rut;
                    orden.ESTADO_ORDEN_ESTADOID = Estado.Id;
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
                    Modelo.ORDEN_PEDIDO orden = ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.FirstOrDefault(e => e.NUMERORDEN == numero);
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
        #endregion

    }
}
