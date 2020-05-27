using System.Collections.Generic;
using System.Linq;

namespace Controlador
{
    public class EstadoOrden
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        #region Constructores
        public EstadoOrden(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public EstadoOrden()
        {

        }
        #endregion

        #region Metodos
        public IList<EstadoOrden> Listar()
        {
            List<EstadoOrden> listado = new List<EstadoOrden>();
            foreach (Modelo.ESTADO_ORDEN estadoOrden in ConectorDALC.ModeloAlmacen.ESTADO_ORDEN.ToList())
            {
                EstadoOrden estado = new EstadoOrden();
                estado.Id = (int)estadoOrden.IDESTADO;
                estado.Descripcion = estadoOrden.DESCRIPCION;
                listado.Add(estado);
            }
            return listado;
        }
        public override string ToString()
        {
            return Descripcion;
        }
        #endregion

    }
}
