using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class TipoUsuario
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        #region Constructores
        public TipoUsuario(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public TipoUsuario()
        {

        }
        #endregion

        #region Metodos
        public IList<TipoUsuario> Listar()
        {
            List<TipoUsuario> listado = new List<TipoUsuario>();
            foreach (Modelo.TIPO_USUARIO tipoUsuario in ConectorDALC.ModeloAlmacen.TIPO_USUARIO.ToList())
            {
                TipoUsuario tipo = new TipoUsuario();
                tipo.Id = (int)tipoUsuario.TIPOUSUARIOID;
                tipo.Descripcion = tipoUsuario.DESCRIPUSUARIO;
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
