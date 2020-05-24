using Modelo;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Boleta
    {
        public int Numero { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Valor { get; set; }
        public MedioPago MedioPago { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }

        #region Constructores
        public Boleta(int numero, DateTime fechaCreacion, int valor, MedioPago medioPago, Cliente cliente, Usuario usuario)
        {
            Numero = numero;
            FechaCreacion = fechaCreacion;
            Valor = valor;
            MedioPago = medioPago;
            Cliente = cliente;
            Usuario = usuario;
        }
        public Boleta(DateTime fechaCreacion, int valor, MedioPago medioPago, Cliente cliente, Usuario usuario)
        {
            FechaCreacion = fechaCreacion;
            Valor = valor;
            MedioPago = medioPago;
            Cliente = cliente;
            Usuario = usuario;
        }
        public Boleta()
        {

        }
        #endregion

        #region Metodos de la clase
        public List<Modelo.BOLETA> Listar()
        {
            List<Modelo.BOLETA> listado = new List<Modelo.BOLETA>();
            listado = ConectorDALC.ModeloAlmacen.BOLETA.ToList();
            return listado;
        }
        public Boleta ObtenerBoleta(int numero)
        {
            try
            {
                Modelo.BOLETA boleta = ConectorDALC.ModeloAlmacen.BOLETA.FirstOrDefault(e => e.NUMEROBOLETA == numero);
                Numero = (int)boleta.NUMEROBOLETA;
                FechaCreacion = boleta.FECHABOLETA;
                Valor = (int)boleta.VALORBOLETA;
                MedioPago = new MedioPago() { Id = (int)boleta.MEDIO_PAGO.MEDIOPAGOID };
                Cliente = new Cliente() { Run = (int)boleta.CLIENTE.RUNCLIENTE };
                Usuario = new Usuario() { RunUsuario = (int)boleta.USUARIO.RUNUSUARIO };
                Boleta boletaEncontrada = new Boleta(Numero, FechaCreacion, Valor, MedioPago, Cliente, Usuario);
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

                boleta.FECHABOLETA = FechaCreacion;
                boleta.VALORBOLETA = Valor;
                boleta.MEDIO_PAGO_MEDIOPAGOID = MedioPago.Id;
                boleta.CLIENTE_RUNCLIENTE = Cliente.Run;
                boleta.USUARIO_RUNUSUARIO = Usuario.RunUsuario;

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
                    boleta.FECHABOLETA = modificarBoleta.FechaCreacion;
                    boleta.VALORBOLETA = modificarBoleta.Valor;
                    boleta.MEDIO_PAGO_MEDIOPAGOID = modificarBoleta.MedioPago.Id;
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
        #endregion

        public void EjecutarSP()
        {
            try
            {
                Conexion conexion = new Conexion();
                OracleDataReader reader = conexion.EjecutarQuery("BEGIN SP_ACTUALIZARPRECIO2(); END;");

            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public void EjecutarConParametro(int monto)
        {
            try
            {
                string sql = "BEGIN SP_ACTUALIZARPRECIO(:MONTO); end; ";
                Conexion conexion = new Conexion();
                OracleConnection connection = conexion.ConexionBd();
                connection.Open();


                OracleCommand command = connection.CreateCommand();
                command.CommandText = sql;
                command.Parameters.Add(new OracleParameter("MONTO", monto));
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

        public void ProcedimientoDevuelveParametro()
        {
            try
            {
                Conexion conexion = new Conexion();
                OracleConnection connection = conexion.ConexionBd();
                connection.Open();

                OracleCommand command = connection.CreateCommand();
                command.CommandText = "BEGIN SP_ACTUALIZARPRECIO(:ESTADO); end; ";

                OracleParameter outval = new OracleParameter("ESTADO", OracleDbType.Varchar2, 50);
                outval.Direction = ParameterDirection.Output;
                command.Parameters.Add(outval);

                command.ExecuteNonQuery();
                string resultado = outval.Value.ToString();
                connection.Close();
            }
            catch (Exception ex)
             {

                throw;
            }
        }
    }
}
