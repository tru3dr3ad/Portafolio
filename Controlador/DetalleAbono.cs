using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class DetalleAbono
    {
        public int Id { get; set; }
        public Boleta Boleta { get; set; }
        public Abono Abono { get; set; }
        public DateTime FechaAbono { get; set; }
        public int Monto { get; set; }
        public DateTime FechaLimite { get; set; }

        #region Constructores
        public DetalleAbono(int id, Boleta boleta, Abono abono, DateTime fechaAbono, int monto, DateTime fechaLimite)
        {
            Id = id;
            Boleta = boleta;
            Abono = abono;
            FechaAbono = fechaAbono;
            Monto = monto;
            FechaLimite = fechaLimite;
        }
        public DetalleAbono(Boleta boleta, Abono abono, DateTime fechaAbono, int monto, DateTime fechaLimite)
        {
            Boleta = boleta;
            Abono = abono;
            FechaAbono = fechaAbono;
            Monto = monto;
            FechaLimite = fechaLimite;
        }
        public DetalleAbono()
        {

        }
        #endregion

        #region Metodos
        public List<Modelo.DETALLE_ABONO> Listar()
        {
            List<Modelo.DETALLE_ABONO> listado = new List<Modelo.DETALLE_ABONO>();
            listado = ConectorDALC.ModeloAlmacen.DETALLE_ABONO.ToList();
            return listado;
        }
        public bool BuscarDetalleAbono(int idDetalle)
        {
            try
            {
                Modelo.DETALLE_ABONO detalleAbono = ConectorDALC.ModeloAlmacen.DETALLE_ABONO.FirstOrDefault(r => r.IDDETALLEA == idDetalle);
                if (detalleAbono != null)
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
        public bool AgregarDetalleFiado()
        {
            try
            {
                Modelo.DETALLE_ABONO detalleAbono = new Modelo.DETALLE_ABONO();

                detalleAbono.FECHAABONO = FechaAbono;
                detalleAbono.NUMEROBOLETA = Boleta.Numero;
                detalleAbono.ABONOID = Abono.Id;
                detalleAbono.MONTO = Monto;
                detalleAbono.FECHALIMITE = FechaLimite;
                
                ConectorDALC.ModeloAlmacen.DETALLE_ABONO.Add(detalleAbono);
                ConectorDALC.ModeloAlmacen.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al agregar detalle de fiado: " + ex);
            }
        }
        public bool EliminarDetalleFiado(int idDetalle)
        {
            try
            {
                if (BuscarDetalleAbono(idDetalle))
                {
                    Modelo.DETALLE_ABONO detalleAbono = ConectorDALC.ModeloAlmacen.DETALLE_ABONO.FirstOrDefault(r => r.IDDETALLEA == idDetalle);
                    ConectorDALC.ModeloAlmacen.DETALLE_ABONO.Remove(detalleAbono);
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
                throw new ArgumentException("Error al eliminar detalle de fiado: " + ex);
            }
        }
        #endregion

    }
}
