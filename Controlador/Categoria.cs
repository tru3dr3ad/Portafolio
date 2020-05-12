using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Categoria(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public Categoria()
        {

        }
        public IList<Categoria> Listar()
        {
            List<Categoria> listado = new List<Categoria>();
            foreach (Modelo.CATEGORIA categoriaP in ConectorDALC.ModeloAlmacen.CATEGORIA.ToList())
            {
                Categoria categoria = new Categoria();
                categoria.Id = (int)categoriaP.CATEGORIAID;
                categoria.Descripcion = categoriaP.DESCRIPCATEGORIA;
                listado.Add(categoria);
            }
            return listado;
        }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
