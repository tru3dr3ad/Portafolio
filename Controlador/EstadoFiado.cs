using System;
using System.Collections.Generic;
using System.Linq;

namespace Controlador
{
    public class EstadoFiado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        #region Constructores
        public EstadoFiado(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public EstadoFiado(string descripcion)
        {
            Descripcion = descripcion;
        }
        public EstadoFiado()
        {

        }
        #endregion

        #region Metodos
        public IList<EstadoFiado> Listar()
        {
            List<EstadoFiado> listado = new List<EstadoFiado>();
            foreach (Modelo.ESTADO_FIADO estadoFiado in ConectorDALC.ModeloAlmacen.ESTADO_FIADO.ToList())
            {
                EstadoFiado estado = new EstadoFiado();
                estado.Id = (int)estadoFiado.IDESTADO;
                estado.Descripcion = estadoFiado.DESCRIPCION;
                listado.Add(estado);
            }
            return listado;
        }
        public override string ToString()
        {
            return Descripcion;
        }
        public EstadoFiado ObtenerEstadoFiado(int id)
        {
            try
            {
                Modelo.ESTADO_FIADO estadoModelo = ConectorDALC.ModeloAlmacen.ESTADO_FIADO.FirstOrDefault(e => e.IDESTADO == id);
                Id = (int)estadoModelo.IDESTADO;
                Descripcion = estadoModelo.DESCRIPCION;
                EstadoFiado estado = new EstadoFiado(Id, Descripcion);
                return estado;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        #endregion

        #region Metodo de la clase
        public bool BuscarEstadoFiado(string descripcion)
        {
            try
            {
                Modelo.ESTADO_FIADO estado = ConectorDALC.ModeloAlmacen.ESTADO_FIADO.FirstOrDefault(e => e.DESCRIPCION == descripcion);
                if (estado != null)
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
        public bool AgregarEstadoFiado(string descripcion)
        {
            try
            {
                if (BuscarEstadoFiado(descripcion))
                {
                    return false;
                }
                else
                {
                    Modelo.ESTADO_FIADO estado = new Modelo.ESTADO_FIADO();

                    estado.DESCRIPCION = Descripcion;

                    ConectorDALC.ModeloAlmacen.ESTADO_FIADO.Add(estado);
                    ConectorDALC.ModeloAlmacen.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al agregar estado de fiado" + ex);
            }
        }
        public bool EliminarEstadoFiado(string descripcion)
        {
            try
            {
                if (BuscarEstadoFiado(descripcion))
                {
                    Modelo.ESTADO_FIADO estado = ConectorDALC.ModeloAlmacen.ESTADO_FIADO.FirstOrDefault(e => e.DESCRIPCION == descripcion);
                    ConectorDALC.ModeloAlmacen.ESTADO_FIADO.Remove(estado);
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
                throw new ArgumentException("Error al eliminar estado de orden de fiado: " + ex);
            }
        }
        #endregion

    }
}
