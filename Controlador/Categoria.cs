using System.Collections.Generic;
using System.Linq;

namespace Controlador
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        
        #region Constructores
        public Categoria(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public Categoria()
        {

        }
        #endregion

        #region Metodos
        public IList<Categoria> Listar()
        {
            List<Categoria> listado = new List<Categoria>();
            foreach (Modelo.CATEGORIA categoriaP in ConectorDALC.ModeloAlmacen.CATEGORIA.ToList())
            {
                Categoria categoria = new Categoria();
                categoria.Id = (int)categoriaP.IDCATEGORIA;
                categoria.Descripcion = categoriaP.DESCRIPCION;
                listado.Add(categoria);
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
