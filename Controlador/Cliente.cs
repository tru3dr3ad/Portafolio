using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class Cliente
    {
        public int Run { get; set; }
        public char Dv { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public EstadoFiado Estado { get; set; }
        public TipoCliente Tipo { get; set; }
        public Cliente(int run, char dv, string nombre, string apellido, DateTime fechaNacimiento, string direccion,
                    int telefono, EstadoFiado estado, TipoCliente tipo)
        {
            Run = run;
            Dv = dv;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
            Telefono = telefono;
            Estado = estado;
            Tipo = tipo;
        }
        public Cliente()
        {

        }

        #region Metodos
        public List<Modelo.CLIENTE> Listar()
        {
            List<Modelo.CLIENTE> listado = new List<Modelo.CLIENTE>();
            listado = ConectorDALC.ModeloAlmacen.CLIENTE.ToList();
            return listado;
        }
        public Cliente ObtenerCliente(int runCliente)
        {
            try
            {
                Modelo.CLIENTE cliente = ConectorDALC.ModeloAlmacen.CLIENTE.FirstOrDefault(e => e.RUNCLIENTE == runCliente);
                Run = (int)cliente.RUNCLIENTE;
                Dv = char.Parse(cliente.DVCLIENTE);
                Nombre = cliente.NOMBRECLIENTE;
                Apellido = cliente.APELLIDOCLIENTE;
                FechaNacimiento = cliente.FECHANACIMIENTO;
                Direccion = cliente.DIRECCIONCLIENTE;
                Telefono = cliente.FONOCLIENTE;
                Estado = new EstadoFiado() { Id = (int)cliente.ESTADO_FIADO.ESTADOID };
                Tipo = new TipoCliente() { Id = (int)cliente.TIPO_CLIENTE.TIPOCLIENTEID };
                Cliente clienteEncontrado = new Cliente(Run, Dv, Nombre, Apellido, FechaNacimiento, Direccion, Telefono,
                    Estado, Tipo);
                return clienteEncontrado;
            }
            catch (Exception ex)
            {
                return null;
                throw new ArgumentException("Error al obtener cliente: " + ex);
            }
        }
        public bool BuscarCliente(int runCliente)
        {
            try
            {
                Modelo.CLIENTE cliente = ConectorDALC.ModeloAlmacen.CLIENTE.FirstOrDefault(e => e.RUNCLIENTE == runCliente);
                if (cliente != null)
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
        public bool AgregarCliente()
        {
            try
            {
                Modelo.CLIENTE cliente = new Modelo.CLIENTE();

                cliente.RUNCLIENTE = Run;
                cliente.DVCLIENTE = Dv.ToString();
                cliente.NOMBRECLIENTE = Nombre;
                cliente.APELLIDOCLIENTE = Apellido;
                cliente.FECHANACIMIENTO = FechaNacimiento;
                cliente.DIRECCIONCLIENTE = Direccion;
                cliente.FONOCLIENTE = Telefono;
                cliente.ESTADO_FIADO_ESTADOID = Estado.Id;
                cliente.TIPO_CLIENTE_TIPOCLIENTEID = Tipo.Id;

                ConectorDALC.ModeloAlmacen.CLIENTE.Add(cliente);
                ConectorDALC.ModeloAlmacen.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al agregar cliente" + ex);
            }
        }
        public bool ModificarCliente(int runCliente)
        {
            try
            {
                if (BuscarCliente(runCliente))
                {
                    Modelo.CLIENTE cliente = ConectorDALC.ModeloAlmacen.CLIENTE.FirstOrDefault(e => e.RUNCLIENTE == runCliente);
                    cliente.RUNCLIENTE = Run;
                    cliente.DVCLIENTE = Dv.ToString();
                    cliente.NOMBRECLIENTE = Nombre;
                    cliente.APELLIDOCLIENTE = Apellido;
                    cliente.FECHANACIMIENTO = FechaNacimiento;
                    cliente.DIRECCIONCLIENTE = Direccion;
                    cliente.FONOCLIENTE = Telefono;
                    cliente.ESTADO_FIADO_ESTADOID = Estado.Id;
                    cliente.TIPO_CLIENTE_TIPOCLIENTEID = Tipo.Id;

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
                throw new ArgumentException("Error al modificar cliente: " + ex);
            }
        }
        public bool EliminarCliente(int runCliente)
        {
            try
            {
                if (BuscarCliente(runCliente))
                {
                    Modelo.CLIENTE cliente = ConectorDALC.ModeloAlmacen.CLIENTE.FirstOrDefault(e => e.RUNCLIENTE == runCliente);
                    ConectorDALC.ModeloAlmacen.CLIENTE.Remove(cliente);
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
                throw new ArgumentException("Error al eliminar cliente" + ex);
            }
        }
        #endregion
    }
}
