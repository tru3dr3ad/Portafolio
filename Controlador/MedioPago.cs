using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class MedioPago
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        #region Constructores
        public MedioPago(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public MedioPago()
        {

        }
        #endregion

        #region Metodos
        public IList<MedioPago> Listar()
        {
            List<MedioPago> listado = new List<MedioPago>();
            foreach (Modelo.MEDIO_PAGO estadoFiado in ConectorDALC.ModeloAlmacen.MEDIO_PAGO.ToList())
            {
                MedioPago medio = new MedioPago();
                medio.Id = (int)estadoFiado.MEDIOPAGOID;
                medio.Descripcion = estadoFiado.DESCRIPMEDIO;
                listado.Add(medio);
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
