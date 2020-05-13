using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class EstadoOrden
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public EstadoOrden()
        {

        }
        public EstadoOrden(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public IList<EstadoOrden> Listar()
        {
            List<EstadoOrden> listado = new List<EstadoOrden>();
            foreach (Modelo.ESTADO_ORDEN estadoOrden in ConectorDALC.ModeloAlmacen.ESTADO_ORDEN.ToList())
            {
                EstadoOrden estado = new EstadoOrden();
                estado.Id = (int)estadoOrden.ESTADOID;
                estado.Descripcion = estadoOrden.DESCRIPCION;
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
