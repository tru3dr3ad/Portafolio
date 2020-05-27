using System.Collections.Generic;
using System.Linq;

namespace Controlador
{
    public class EstadoFiado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        #region Constructores
        public EstadoFiado(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public EstadoFiado()
        {

        }
        #endregion

        #region Metodos
        public IList<EstadoFiado> Listar()
        {
            List<EstadoFiado> listado = new List<EstadoFiado>();
            foreach (Modelo.ESTADO_FIADO estadoFiado in ConectorDALC.ModeloAlmacen.ESTADO_FIADO.ToList())
            {
                EstadoFiado estado = new EstadoFiado();
                estado.Id = (int)estadoFiado.IDESTADO;
                estado.Descripcion = estadoFiado.DESCRIPCION;
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
