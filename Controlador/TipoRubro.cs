using System;
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
        public TipoRubro(string descripcion)
        {
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
        public bool BuscarRubro(string descripcion)
        {
            try
            {
                Modelo.TIPO_RUBRO rubro = ConectorDALC.ModeloAlmacen.TIPO_RUBRO.FirstOrDefault(r => r.DESCRIPCION == descripcion);
                if (rubro != null)
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
        public bool AgregarRubro(string nombre)
        {
            try
            {
                if (BuscarRubro(nombre))
                {
                    return false;
                }
                else 
                {
                    Modelo.TIPO_RUBRO rubro = new Modelo.TIPO_RUBRO();

                    rubro.DESCRIPCION = Descripcion;

                    ConectorDALC.ModeloAlmacen.TIPO_RUBRO.Add(rubro);
                    ConectorDALC.ModeloAlmacen.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al agregar rubro" + ex);
            }
        }
        public bool EliminarRubro(string descripcion)
        {
            try
            {
                if (BuscarRubro(descripcion))
                {
                    Modelo.TIPO_RUBRO rubro = ConectorDALC.ModeloAlmacen.TIPO_RUBRO.FirstOrDefault(r => r.DESCRIPCION == descripcion);
                    ConectorDALC.ModeloAlmacen.TIPO_RUBRO.Remove(rubro);
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
                throw new ArgumentException("Error al eliminar rubro: " + ex);
            }
        }
        #endregion

    }
}
