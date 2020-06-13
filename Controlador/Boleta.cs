using Modelo;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Controlador
{
    public class Boleta
    {
        public int Numero { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal Total { get; set; }
        public MedioPago MedioPago { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public EstadoBoleta Estado { get; set; }

        #region Constructores
        public Boleta(int numero, DateTime fechaCreacion, decimal total, MedioPago medioPago, Cliente cliente, Usuario usuario, EstadoBoleta estado)
        {
            Numero = numero;
            FechaCreacion = fechaCreacion;
            Total = total;
            MedioPago = medioPago;
            Cliente = cliente;
            Usuario = usuario;
            Estado = estado;
        }
        public Boleta(DateTime fechaCreacion, decimal total, MedioPago medioPago, Cliente cliente, Usuario usuario, EstadoBoleta estado)
        {
            FechaCreacion = fechaCreacion;
            Total = total;
            MedioPago = medioPago;
            Cliente = cliente;
            Usuario = usuario;
            Estado = estado;
        }
        public Boleta()
        {

        }
        #endregion

        #region Metodos para listar
        public List<Modelo.BOLETA> Listar()
        {
            List<Modelo.BOLETA> listado = new List<Modelo.BOLETA>();
            listado = ConectorDALC.ModeloAlmacen.BOLETA.ToList();
            return listado;
        }
        public List<V_BOLETAS> ListarBoletas()
        {
            List<V_BOLETAS> listado = new List<V_BOLETAS>();
            listado = ConectorDALC.ModeloAlmacen.V_BOLETAS.OrderByDescending(b => b.NUMERO).ToList();
            return listado;
        }
        public List<V_BOLETAS> ListarBoletasPorUsuario(int runUsuario)
        {
            List<V_BOLETAS> listado = new List<V_BOLETAS>();
            listado = ConectorDALC.ModeloAlmacen.V_BOLETAS.Where(b => b.RUN_USUARIO == runUsuario).
                OrderByDescending(b => b.NUMERO).ToList();
            return listado;
        }
        public List<V_BOLETAS> ListarBoletasPorMedioPago(int idMedioPago)
        {
            List<V_BOLETAS> listado = new List<V_BOLETAS>();
            listado = ConectorDALC.ModeloAlmacen.V_BOLETAS.Where(b => b.IDMEDIOPAGO == idMedioPago).
                OrderByDescending(b => b.NUMERO).ToList();
            return listado;
        }
        public List<V_BOLETAS> ListarBoletasPorNombreCliente(string nombre)
        {
            List<V_BOLETAS> listado = new List<V_BOLETAS>();
            listado = ConectorDALC.ModeloAlmacen.V_BOLETAS.Where(b => b.NOMBRE_CLIENTE.Contains(nombre)).
                OrderByDescending(b => b.NUMERO).ToList();
            return listado;
        }
        public List<V_BOLETAS> ListarBoletasPorNombreClienteFiador(string nombre)
        {
            List<V_BOLETAS> listado = new List<V_BOLETAS>();
            listado = ConectorDALC.ModeloAlmacen.V_BOLETAS.Where(b => b.NOMBRE_CLIENTE.Contains(nombre)).
                Where(b => b.IDMEDIOPAGO == 4).OrderByDescending(b => b.NUMERO).ToList();
            return listado;
        }
        public List<V_BOLETAS> ListarBoletasPorClienteFiador(int runCliente)
        {
            List<V_BOLETAS> listado = new List<V_BOLETAS>();
            listado = ConectorDALC.ModeloAlmacen.V_BOLETAS.Where(b => b.RUN_CLIENTE == runCliente)
                .Where(b => b.IDMEDIOPAGO == 4).OrderByDescending(b => b.NUMERO).ToList();
            return listado;
        }
        public List<Boleta> ListarUltimasBoletas()
        {
            List<Boleta> listaB = new List<Boleta>();
            List<V_BOLETAS> listado = new List<V_BOLETAS>();
            listado = ConectorDALC.ModeloAlmacen.V_BOLETAS.OrderByDescending(b => b.NUMERO).ToList();
            foreach (V_BOLETAS item in listado)
            {
                Cliente cliente = new Cliente();
                cliente.Run = (int)item.RUN_CLIENTE;
                Boleta boleta = new Boleta();
                boleta.Cliente = cliente;
                boleta.FechaCreacion = item.FECHA_CREACION;
                boleta.Total = (int)item.TOTAL;
                listaB.Add(boleta);
            }
            return listaB;
        }
        #endregion

        #region Metodos
        public Boleta ObtenerBoleta(int numero)
        {
            try
            {
                Modelo.BOLETA boleta = ConectorDALC.ModeloAlmacen.BOLETA.FirstOrDefault(e => e.NUMEROBOLETA == numero);
                Numero = (int)boleta.NUMEROBOLETA;
                FechaCreacion = boleta.FECHACREACION;
                Total = (int)boleta.TOTAL;
                MedioPago = new MedioPago() { Id = (int)boleta.MEDIO_PAGO.IDMEDIO };
                Cliente = new Cliente() { Run = (int)boleta.CLIENTE.RUNCLIENTE };
                Usuario = new Usuario() { RunUsuario = (int)boleta.USUARIO.RUNUSUARIO };
                Estado = new EstadoBoleta() { Id = (int)boleta.ESTADO_BOLETA.IDESTADO };
                Boleta boletaEncontrada = new Boleta(Numero, FechaCreacion, Total, MedioPago, Cliente, Usuario, Estado);
                return boletaEncontrada;
            }
            catch (Exception ex)
            {
                return null;
                throw new ArgumentException("Error al obtener boleta: " + ex);
            }
        }
        public int ObtenerNumeroMaximoBoleta()
        {
            try
            {
                int numero = (int)ConectorDALC.ModeloAlmacen.BOLETA.Max(b => b.NUMEROBOLETA);
                return numero;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }
        public int CantidadBoletasMes()
        {
            try
            {
                int cantidadBoletas = (int)ConectorDALC.ModeloAlmacen.BOLETA.Count();
                return cantidadBoletas;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }
        public int CantidadBoletasAnuladas()
        {
            try
            {
                int cantidadBoletas = (int)ConectorDALC.ModeloAlmacen.BOLETA.Where(b => b.ESTADO_BOLETA.IDESTADO == 2).
                    Count();
                return cantidadBoletas;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }

        #endregion

        #region Metodos de la clase
        public bool BuscarBoleta(int numero)
        {
            try
            {
                Modelo.BOLETA boleta = ConectorDALC.ModeloAlmacen.BOLETA.FirstOrDefault(e => e.NUMEROBOLETA == numero);
                if (boleta != null)
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
        public bool AgregarBoleta()
        {
            try
            {
                Modelo.BOLETA boleta = new Modelo.BOLETA();

                boleta.FECHACREACION = FechaCreacion;
                boleta.TOTAL = Total;
                boleta.MEDIO_PAGO_IDMEDIO = MedioPago.Id;
                boleta.CLIENTE_RUNCLIENTE = Cliente.Run;
                boleta.USUARIO_RUNUSUARIO = Usuario.RunUsuario;
                boleta.ESTADO_BOLETA_IDESTADO = Estado.Id;

                ConectorDALC.ModeloAlmacen.BOLETA.Add(boleta);
                ConectorDALC.ModeloAlmacen.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al agregar boleta" + ex);
            }
        }
        public bool ModificarBoleta(Boleta modificarBoleta)
        {
            try
            {
                if (BuscarBoleta(modificarBoleta.Numero))
                {
                    Modelo.BOLETA boleta = ConectorDALC.ModeloAlmacen.BOLETA.FirstOrDefault(e => e.NUMEROBOLETA == modificarBoleta.Numero);
                    boleta.NUMEROBOLETA = modificarBoleta.Numero;
                    boleta.FECHACREACION = modificarBoleta.FechaCreacion;
                    boleta.TOTAL = modificarBoleta.Total;
                    boleta.MEDIO_PAGO_IDMEDIO = modificarBoleta.MedioPago.Id;
                    boleta.CLIENTE_RUNCLIENTE = modificarBoleta.Cliente.Run;
                    boleta.USUARIO_RUNUSUARIO = modificarBoleta.Usuario.RunUsuario;

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
                throw new ArgumentException("Error al modificar boleta: " + ex);
            }
        }
        public bool EliminarBoleta(int numero)
        {
            try
            {
                if (BuscarBoleta(numero))
                {
                    Modelo.BOLETA boleta = ConectorDALC.ModeloAlmacen.BOLETA.FirstOrDefault(e => e.NUMEROBOLETA == numero);
                    ConectorDALC.ModeloAlmacen.BOLETA.Remove(boleta);
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
                throw new ArgumentException("Error al eliminar boleta: " + ex);
            }
        }
        public bool AnularBoleta(int numero)
        {
            try
            {
                if (BuscarBoleta(numero))
                {
                    Modelo.BOLETA boleta = ConectorDALC.ModeloAlmacen.BOLETA.FirstOrDefault(e => e.NUMEROBOLETA == numero);
                    boleta.ESTADO_BOLETA_IDESTADO = 2;

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
                throw new ArgumentException("Error al eliminar boleta: " + ex);
            }
        }
        public bool BoletaAnulada(Boleta boleta)
        {
            if (boleta.Estado.Id == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

    }
}
