using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class TipoRubro
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public TipoRubro(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public TipoRubro()
        {

        }
        public IList<TipoRubro> Listar()
        {
            List<TipoRubro> listado = new List<TipoRubro>();
            foreach (Modelo.TIPO_RUBRO tipoRubro in ConectorDALC.ModeloAlmacen.TIPO_RUBRO.ToList())
            {
                TipoRubro tipo = new TipoRubro();
                tipo.Id = (int)tipoRubro.RUBROID;
                tipo.Descripcion = tipoRubro.DESCRIPRUBRO;
                listado.Add(tipo);
            }
            return listado;
        }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
