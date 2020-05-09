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
        public int Estado { get; set; }
        public int Tipo { get; set; }
        public Cliente()
        {

        }
        public Cliente(int run, char dv, string nombre,string apellido, DateTime fechaNacimiento, string direccion,
                    int telefono, int estado, int tipo)
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
                cliente.ESTADO_FIADO_ESTADOID = 1;
                cliente.TIPO_CLIENTE_TIPOCLIENTEID = 1;
                
                ConectorDALC.ModeloAlmacen.CLIENTE.Add(cliente);
                ConectorDALC.ModeloAlmacen.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<Modelo.CLIENTE> Listar()
        {
            List<Modelo.CLIENTE> resultado = new List<Modelo.CLIENTE>();
            resultado = ConectorDALC.ModeloAlmacen.CLIENTE.ToList();
            return resultado;
        }
    }
}
