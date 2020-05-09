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
        public IList<EstadoFiado> Listar()
        {
            List<EstadoFiado> listado = new List<EstadoFiado>();
            foreach (Modelo.ESTADO_FIADO estadoFiado in ConectorDALC.ModeloAlmacen.ESTADO_FIADO.ToList())
            {
                EstadoFiado estado = new EstadoFiado();
                estado.Id = (int)estadoFiado.ESTADOID;
                estado.Descripcion = estadoFiado.DESCRIPESTADO;
                listado.Add(estado);
            }
            return listado;
        }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
