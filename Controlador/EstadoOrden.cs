using System;
using System.Collections.Generic;
using System.Linq;

namespace Controlador
{
    public class EstadoOrden
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        #region Constructores
        public EstadoOrden(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public EstadoOrden(string descripcion)
        {
            Descripcion = descripcion;
        }
        public EstadoOrden()
        {

        }
        #endregion

        #region Metodos
        public IList<EstadoOrden> Listar()
        {
            List<EstadoOrden> listado = new List<EstadoOrden>();
            foreach (Modelo.ESTADO_ORDEN estadoOrden in ConectorDALC.ModeloAlmacen.ESTADO_ORDEN.ToList())
            {
                EstadoOrden estado = new EstadoOrden();
                estado.Id = (int)estadoOrden.IDESTADO;
                estado.Descripcion = estadoOrden.DESCRIPCION;
                listado.Add(estado);
            }
            return listado;
        }
        public override string ToString()
        {
            return Descripcion;
        }
        public bool BuscarEstadoOrden(string descripcion)
        {
            try
            {
                Modelo.ESTADO_ORDEN estado = ConectorDALC.ModeloAlmacen.ESTADO_ORDEN.FirstOrDefault(e => e.DESCRIPCION == descripcion);
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
        public bool AgregarEstadoOrden(string descripcion)
        {
            try
            {
                if (BuscarEstadoOrden(descripcion))
                {
                    return false;
                }
                else
                {
                    Modelo.ESTADO_ORDEN estado = new Modelo.ESTADO_ORDEN();

                    estado.DESCRIPCION = Descripcion;

                    ConectorDALC.ModeloAlmacen.ESTADO_ORDEN.Add(estado);
                    ConectorDALC.ModeloAlmacen.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al agregar estado de orden de pedido" + ex);
            }
        }
        public bool EliminarEstadoOrden(string descripcion)
        {
            try
            {
                if (BuscarEstadoOrden(descripcion))
                {
                    Modelo.ESTADO_ORDEN estado = ConectorDALC.ModeloAlmacen.ESTADO_ORDEN.FirstOrDefault(e => e.DESCRIPCION == descripcion);
                    ConectorDALC.ModeloAlmacen.ESTADO_ORDEN.Remove(estado);
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
                throw new ArgumentException("Error al eliminar estado de orden de pedido: " + ex);
            }
        }
        #endregion

    }
}
