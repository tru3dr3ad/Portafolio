using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class TipoCliente
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public TipoCliente()
        {

        }
        public TipoCliente(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public IList<TipoCliente> Listar()
        {
            List<TipoCliente> listado = new List<TipoCliente>();
            foreach (Modelo.TIPO_CLIENTE tipoCliente in ConectorDALC.ModeloAlmacen.TIPO_CLIENTE.ToList())
            {
                TipoCliente tipo = new TipoCliente();
                tipo.Id = (int)tipoCliente.TIPOCLIENTEID;
                tipo.Descripcion = tipoCliente.DESCRIPCLIENTE;
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
