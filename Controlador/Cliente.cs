using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Cliente
    {
        public int Rut { get; set; }
        public char Dv { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int Estado { get; set; }
        public int Tipo { get; set; }
        public Cliente()
        {

        }
        public Cliente(int rut, char dv, string nombre, string direccion, int telefono, int estado, int tipo)
        {
            Rut = rut;
            Dv = dv;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Estado = estado;
            Tipo = tipo;
        }
    }
}
