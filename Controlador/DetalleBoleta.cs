using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class DetalleBoleta
    {
        public int IdDetalle { get; set; }
        public int NumeroBoleta { get; set; }
        public int CodigoProducto{ get; set; }
        public int Cantidad { get; set; }

        #region Constructores
        public DetalleBoleta(int idDetalle, int numeroBoleta, int producto, int cantidad)
        {
            IdDetalle = idDetalle;
            NumeroBoleta = numeroBoleta;
            CodigoProducto = producto;
            Cantidad = cantidad;
        }
        public DetalleBoleta(int numeroBoleta, int producto, int cantidad)
        {
            NumeroBoleta = numeroBoleta;
            CodigoProducto = producto;
            Cantidad = cantidad;
        }
        public DetalleBoleta()
        {

        }
        #endregion

        #region Metodos de la clase
        //public List<DetalleBoleta> ListarDetalles()
        //{
        //    List<DetalleBoleta> listado = new List<DetalleBoleta>();
            
        //}

        public List<Modelo.DETALLE_BOLETA> Listar()
        {
            List<Modelo.DETALLE_BOLETA> listado = new List<Modelo.DETALLE_BOLETA>();
            listado = ConectorDALC.ModeloAlmacen.DETALLE_BOLETA.ToList();
            return listado;
        }
        public bool BuscarDetalleBoleta(int idDetalle)
        {
            try
            {
                Modelo.DETALLE_BOLETA detalleBoleta = ConectorDALC.ModeloAlmacen.DETALLE_BOLETA.FirstOrDefault(e => e.IDDETALLEB == idDetalle);
                if (detalleBoleta != null)
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
        public bool AgregarDetalleBoleta()
        {
            try
            {
                Modelo.DETALLE_BOLETA detalleBoleta = new Modelo.DETALLE_BOLETA();

                detalleBoleta.BOLETA_NUMEROBOLETA = NumeroBoleta;
                detalleBoleta.PRODUCTO_CODIGOPROD = CodigoProducto;
                detalleBoleta.CANTIDAD = Cantidad;

                ConectorDALC.ModeloAlmacen.DETALLE_BOLETA.Add(detalleBoleta);
                ConectorDALC.ModeloAlmacen.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al agregar detalle de boleta: " + ex);
            }
        }
        public bool EliminarDetalleBoleta(int idDetalle)
        {
            try
            {
                if (BuscarDetalleBoleta(idDetalle))
                {
                    Modelo.DETALLE_BOLETA detalleBoleta = ConectorDALC.ModeloAlmacen.DETALLE_BOLETA.FirstOrDefault(e => e.IDDETALLEB == idDetalle);
                    ConectorDALC.ModeloAlmacen.DETALLE_BOLETA.Remove(detalleBoleta);
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
                throw new ArgumentException("Error al eliminar detalle de boleta: " + ex);
            }
        }
        #endregion
    }
}
