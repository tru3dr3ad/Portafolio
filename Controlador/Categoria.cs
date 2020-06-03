using System;
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
        public Categoria(string descripcion)
        {
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
        public bool BuscarCategoria(string descripcion)
        {
            try
            {
                Modelo.CATEGORIA tipo = ConectorDALC.ModeloAlmacen.CATEGORIA.FirstOrDefault(c => c.DESCRIPCION == descripcion);
                if (tipo != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al buscar" + ex);
            }
        }
        public bool AgregarCategoria(string descripcion)
        {
            try
            {
                if (BuscarCategoria(descripcion))
                {
                    return false;
                }
                else
                {
                    Modelo.CATEGORIA categoria = new Modelo.CATEGORIA();

                    categoria.DESCRIPCION = Descripcion;

                    ConectorDALC.ModeloAlmacen.CATEGORIA.Add(categoria);
                    ConectorDALC.ModeloAlmacen.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al agregar categoria" + ex);
            }
        }
        public bool EliminarCategoria(string descripcion)
        {
            try
            {
                if (BuscarCategoria(descripcion))
                {
                    Modelo.CATEGORIA categoria = ConectorDALC.ModeloAlmacen.CATEGORIA.FirstOrDefault(c => c.DESCRIPCION == descripcion);
                    ConectorDALC.ModeloAlmacen.CATEGORIA.Remove(categoria);
                    ConectorDALC.ModeloAlmacen.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al eliminar categoria: " + ex);
            }
        }
        #endregion

    }
}
