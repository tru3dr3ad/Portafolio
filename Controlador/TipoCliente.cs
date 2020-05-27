using System.Collections.Generic;
using System.Linq;

namespace Controlador
{
    public class TipoCliente
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        #region Constructores
        public TipoCliente(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public TipoCliente()
        {

        }
        #endregion

        #region Metodos
        public IList<TipoCliente> Listar()
        {
            List<TipoCliente> listado = new List<TipoCliente>();
            foreach (Modelo.TIPO_CLIENTE tipoCliente in ConectorDALC.ModeloAlmacen.TIPO_CLIENTE.ToList())
            {
                TipoCliente tipo = new TipoCliente();
                tipo.Id = (int)tipoCliente.IDTIPO;
                tipo.Descripcion = tipoCliente.DESCRIPCION;
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
