using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;

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

        #region Constructores
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
        #endregion

        #region Metodos para listar
        public IList<Cliente> ListarCombobox()
        {
            List<Cliente> listado = new List<Cliente>();
            foreach (Modelo.CLIENTE clienteEncontrados in ConectorDALC.ModeloAlmacen.CLIENTE.ToList()) 
            {
                Cliente cliente = new Cliente();
                cliente.Run = (int)clienteEncontrados.RUNCLIENTE;
                cliente.Nombre = clienteEncontrados.NOMBRE+" "+clienteEncontrados.APELLIDO;
                listado.Add(cliente);
            }
            return listado;
        }
        public IList<Cliente> ListarComboboxFiado()
        {
            List<Cliente> listado = new List<Cliente>();
            foreach (Modelo.CLIENTE clienteEncontrados in ConectorDALC.ModeloAlmacen.CLIENTE.Where(c => c.TIPO_CLIENTE_IDTIPO == 1).ToList())
            {
                Cliente cliente = new Cliente();
                cliente.Run = (int)clienteEncontrados.RUNCLIENTE;
                cliente.Nombre = clienteEncontrados.NOMBRE + " " + clienteEncontrados.APELLIDO;
                listado.Add(cliente);
            }
            return listado;
        }
        public List<Modelo.CLIENTE> Listar()
        {
            List<Modelo.CLIENTE> listado = new List<Modelo.CLIENTE>();
            listado = ConectorDALC.ModeloAlmacen.CLIENTE.ToList();
            return listado;
        }
        public List<V_CLIENTES> ListarVistaCliente()
        {
            List<V_CLIENTES> listado = new List<V_CLIENTES>();
            listado = ConectorDALC.ModeloAlmacen.V_CLIENTES.ToList();
            return listado;
        }
        public List<V_CLIENTES> ListarClientePorNombre(string nombre)
        {
            List<V_CLIENTES> listado = new List<V_CLIENTES>();
            listado = ConectorDALC.ModeloAlmacen.V_CLIENTES.Where(c => c.NOMBRE_CLIENTE.Contains(nombre))
                .OrderBy(c => c.NOMBRE_CLIENTE).ToList();
            return listado;
        }
        #endregion

        #region Metodos
        public bool ExisteDeudaCliente(int run)
        {
            Cliente cliente = new Cliente();
            if (cliente.BuscarCliente(run))
            {
                cliente = cliente.ObtenerCliente(run);
                if (cliente.Estado.Descripcion == "NO DEBE")
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
        public Cliente ObtenerCliente(int runCliente)
        {
            try
            {
                Modelo.CLIENTE cliente = ConectorDALC.ModeloAlmacen.CLIENTE.FirstOrDefault(e => e.RUNCLIENTE == runCliente);
                Run = (int)cliente.RUNCLIENTE;
                Dv = char.Parse(cliente.DV);
                Nombre = cliente.NOMBRE;
                Apellido = cliente.APELLIDO;
                FechaNacimiento = cliente.FECHANACIMIENTO;
                Direccion = cliente.DIRECCION;
                Telefono = cliente.TELEFONO;
                Estado = new EstadoFiado() { Id = (int)cliente.ESTADO_FIADO.IDESTADO };
                Tipo = new TipoCliente() { Id = (int)cliente.TIPO_CLIENTE.IDTIPO };
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
                cliente.DV = Dv.ToString();
                cliente.NOMBRE= Nombre;
                cliente.APELLIDO= Apellido;
                cliente.FECHANACIMIENTO= FechaNacimiento;
                cliente.DIRECCION= Direccion;
                cliente.TELEFONO = Telefono;
                cliente.ESTADO_FIADO_IDESTADO = Estado.Id;
                cliente.TIPO_CLIENTE_IDTIPO= Tipo.Id;

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
        public bool ModificarCliente(Cliente modificarCliente)
        {
            try
            {
                if (BuscarCliente(modificarCliente.Run))
                {
                    Modelo.CLIENTE cliente = ConectorDALC.ModeloAlmacen.CLIENTE.FirstOrDefault(e => e.RUNCLIENTE == modificarCliente.Run);
                    cliente.RUNCLIENTE = modificarCliente.Run;
                    cliente.DV = modificarCliente.Dv.ToString();
                    cliente.NOMBRE = modificarCliente.Nombre;
                    cliente.APELLIDO = modificarCliente.Apellido;
                    cliente.FECHANACIMIENTO = modificarCliente.FechaNacimiento;
                    cliente.DIRECCION = modificarCliente.Direccion;
                    cliente.TELEFONO = modificarCliente.Telefono;
                    cliente.ESTADO_FIADO_IDESTADO = modificarCliente.Estado.Id;
                    cliente.TIPO_CLIENTE_IDTIPO = modificarCliente.Tipo.Id;

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
                throw new ArgumentException("Error al eliminar cliente: " + ex);
            }
        }
        #endregion

    }
}
