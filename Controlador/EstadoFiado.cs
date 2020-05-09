using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class EstadoFiado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public EstadoFiado()
        {

        }
        public EstadoFiado(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}
