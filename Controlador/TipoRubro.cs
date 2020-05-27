using System.Collections.Generic;
using System.Linq;

namespace Controlador
{
    public class TipoRubro
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        #region Constructores
        public TipoRubro(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public TipoRubro()
        {

        }
        #endregion

        #region Metodos
        public IList<TipoRubro> Listar()
        {
            List<TipoRubro> listado = new List<TipoRubro>();
            foreach (Modelo.TIPO_RUBRO tipoRubro in ConectorDALC.ModeloAlmacen.TIPO_RUBRO.ToList())
            {
                TipoRubro tipo = new TipoRubro();
                tipo.Id = (int)tipoRubro.IDRUBRO;
                tipo.Descripcion = tipoRubro.DESCRIPCION;
                listado.Add(tipo);
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
