﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace Controlador
{
    public class OrdenPedido
    {
        public int Numero { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public Proveedor Proveedor { get; set; }
        public EstadoOrden Estado { get; set; }
        public Usuario Usuario { get; set; }

        #region Constructores
        public OrdenPedido(int numero, DateTime fechaCreacion, decimal total, DateTime fechaRecepcion, Proveedor proveedor,
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
        public OrdenPedido(DateTime fechaCreacion, decimal total, DateTime fechaRecepcion, Proveedor proveedor,
            EstadoOrden estado, Usuario usuario)
        {
            FechaCreacion = fechaCreacion;
            Total = total;
            FechaRecepcion = fechaRecepcion;
            Proveedor = proveedor;
            Estado = estado;
            Usuario = usuario;
        }
        public OrdenPedido(int numero, decimal total, Proveedor proveedor, EstadoOrden estado, Usuario usuario)
        {
            Numero = numero;
            Total = total;
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
            listado = ConectorDALC.ModeloAlmacen.V_ORDEN_PEDIDO.OrderByDescending(o => o.NUMERO).ToList();
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
            listado = ConectorDALC.ModeloAlmacen.V_ORDEN_PEDIDO.Where(o => o.PROVEEDOR_RUT == rutProveedor).
                OrderByDescending(o => o.NUMERO).ToList();
            return listado;
        }
        public List<Modelo.V_ORDEN_PEDIDO> ListarOrdenPedidoPorEstadoRecepcion(int idEstado)
        {
            List<Modelo.V_ORDEN_PEDIDO> listado = new List<Modelo.V_ORDEN_PEDIDO>();
            listado = ConectorDALC.ModeloAlmacen.V_ORDEN_PEDIDO.Where(o => o.IDESTADO == idEstado).
                OrderByDescending(o => o.NUMERO).ToList();
            return listado;
        }

        #endregion

        #region Metodos
        public int ObtenerNumeroMaximoOrden()
        {
            try
            {
                int numero = (int)ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.Max(o => o.NUMEROORDEN);
                return numero;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }
        public OrdenPedido MostrarUltimaOrdenEnviada()
        {
            try
            {
                Modelo.ORDEN_PEDIDO ordenPedidoModelo = ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.
                Where(o => o.ESTADO_ORDEN_IDESTADO == 2).OrderByDescending(o => o.NUMEROORDEN).
                FirstOrDefault();
                if (ordenPedidoModelo != null)
                {
                    OrdenPedido ordenPedido = new OrdenPedido();
                    ordenPedido.Numero = int.Parse(ordenPedidoModelo.NUMEROORDEN.ToString());
                    ordenPedido.Proveedor = new Proveedor() { Rut = int.Parse(ordenPedidoModelo.PROVEEDOR.RUT.ToString()) };
                    return ordenPedido;
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
        public OrdenPedido ObtenerOrdenPedido(int numero)
        {
            try
            {
                Modelo.ORDEN_PEDIDO ordenPedido = ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.FirstOrDefault(e => e.NUMEROORDEN == numero);
                Numero = (int)ordenPedido.NUMEROORDEN;
                FechaCreacion = ordenPedido.FECHACREACION;
                Total = ordenPedido.TOTAL;
                FechaRecepcion = ordenPedido.FECHARECEPCION;
                Proveedor = new Proveedor() { Rut = (int)ordenPedido.PROVEEDOR.RUT };
                Estado = new EstadoOrden() { Id = (int)ordenPedido.ESTADO_ORDEN.IDESTADO };
                Usuario = new Usuario() { RunUsuario = (int)ordenPedido.USUARIO.RUNUSUARIO };
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
        public bool CambiarEstadoAEnviado(int nroOrden)
        {
            try
            {
                if (BuscarOrden(nroOrden))
                {
                    Modelo.ORDEN_PEDIDO ordenRecepcionar = ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.
                        FirstOrDefault(e => e.NUMEROORDEN == nroOrden);

                    ordenRecepcionar.ESTADO_ORDEN_IDESTADO = 2;

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
                throw new ArgumentException("Error al descargar orden de pedido: " + ex);
            }
        }
        private void CambiarEstadoRecepcion(OrdenPedido recepcionarOrden)
        {
            Modelo.ORDEN_PEDIDO ordenRecepcionar = ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.FirstOrDefault(e => e.NUMEROORDEN == recepcionarOrden.Numero);

            ordenRecepcionar.FECHARECEPCION = recepcionarOrden.FechaRecepcion;
            ordenRecepcionar.ESTADO_ORDEN_IDESTADO = recepcionarOrden.Estado.Id;

            ConectorDALC.ModeloAlmacen.SaveChanges();
        }
        public bool RecepcionarOrdenPedido(OrdenPedido recepcionarOrden)
        {
            try
            {
                if (BuscarOrden(recepcionarOrden.Numero))
                {
                    if (recepcionarOrden.Estado.Id == 4)
                    {
                        CambiarEstadoRecepcion(recepcionarOrden);
                    }
                    else
                    {
                        CambiarEstadoRecepcion(recepcionarOrden);
                    }
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
        public bool OrdenPedidoEnviada(OrdenPedido orden)
        {
            if (orden.Estado.Id == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool OrdenPedidoGuardada(int numero)
        {
            OrdenPedido orden = new OrdenPedido();
            orden = orden.ObtenerOrdenPedido(numero);
            if (orden.Estado.Id == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AnularOrdenPedido(int nroOrden)
        {
            try
            {
                if (BuscarOrden(nroOrden))
                {
                    Modelo.ORDEN_PEDIDO ordenRecepcionar = ConectorDALC.ModeloAlmacen.ORDEN_PEDIDO.
                        FirstOrDefault(e => e.NUMEROORDEN == nroOrden);

                    ordenRecepcionar.ESTADO_ORDEN_IDESTADO = 6;

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
                throw new ArgumentException("Error al anular orden de pedido: " + ex);
            }
        }
        public bool EnviarCorreoOrdenPedido(OrdenPedido orden, string ruta)
        {
            try
            {
                Validaciones validar = new Validaciones();
                Proveedor proveedor = new Proveedor();
                proveedor = proveedor.ObtenerProveedor(orden.Proveedor.Rut);
                string correo = proveedor.CorreoElectronico;
                string asunto = "ORDEN DE PEDIDO DESDE ALMACEN LOS YUYITOS";
                string body = @"<html>
                      <body>
                      <p>Buenas Tardes {proveedor} ,</p>
                      <p>Esperando que todo este marchando en orden, le adjunto una orden de pedido. Esperamos la confirmacion del pedido en cuanto se haya confirmado su stock.</p>
                        <br></br>
                       <p>La direccion de nuestro local es: Av San fernandez #1329</p> 
                        <br></br>
                        <br></br>
                      <p>De antemano se despide:<br>-Administracion Los Yuyitos</br></p>
                        <br></br>
                        <br></br>
                      </body>
                      </html>
                     ";
                body = body.Replace("{proveedor}", proveedor.Nombre);
                bool recuperacionEnviada = validar.EnviarEmailConArchivo(correo, asunto, body, ruta);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        #endregion


    }
}
