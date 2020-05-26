using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Abono
    {
        public int Id { get; set; }
        public DateTime FechaAbono { get; set; }
        public int ValorAbono { get; set; }

        #region Constructores
        public Abono(int id, DateTime fechaAbono, int valorAbono)
        {
            Id = id;
            FechaAbono = fechaAbono;
            ValorAbono = valorAbono;
        }
        public Abono(DateTime fechaAbono, int valorAbono)
        {
            FechaAbono = fechaAbono;
            ValorAbono = valorAbono;
        }
        public Abono()
        {

        }
        #endregion

        #region Metodos
        public List<Modelo.ABONO> Listar()
        {
            List<Modelo.ABONO> listado = new List<Modelo.ABONO>();
            listado = ConectorDALC.ModeloAlmacen.ABONO.ToList();
            return listado;
        }
        public Abono ObtenerAbono(int id)
        {
            try
            {
                Modelo.ABONO abono = ConectorDALC.ModeloAlmacen.ABONO.FirstOrDefault(a => a.ABONOID == id);
                Id = (int)abono.ABONOID;
                FechaAbono = abono.FECHAABONO;
                ValorAbono = (int)abono.VALORABONO;
                Abono abonoEncontrado = new Abono(Id, FechaAbono, ValorAbono);
                return abonoEncontrado;
            }
            catch (Exception ex)
            {
                return null;
                throw new ArgumentException("Error al obtener abono: " + ex);
            }
        }
        public int ObtenerIdMaximoAbono()
        {
            try
            {
                int id = (int)ConectorDALC.ModeloAlmacen.ABONO.Max(a => a.ABONOID);
                return id;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }
        #endregion

        #region Metodos de la clase
        public bool BuscarAbono(int id)
        {
            try
            {
                Modelo.ABONO abono = ConectorDALC.ModeloAlmacen.ABONO.FirstOrDefault(a => a.ABONOID == id);
                if (abono != null)
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
        public bool AgregarAbono()
        {
            try
            {
                Modelo.ABONO abono = new Modelo.ABONO();

                abono.FECHAABONO = FechaAbono;
                abono.VALORABONO = ValorAbono;

                ConectorDALC.ModeloAlmacen.ABONO.Add(abono);
                ConectorDALC.ModeloAlmacen.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al agregar abono" + ex);
            }
        }
        public bool ModificarAbono(Abono modificarAbono)
        {
            try
            {
                if (BuscarAbono(modificarAbono.Id))
                {
                    Modelo.ABONO abono = ConectorDALC.ModeloAlmacen.ABONO.FirstOrDefault(a => a.ABONOID == modificarAbono.Id);
                    abono.ABONOID = modificarAbono.Id;
                    abono.FECHAABONO= modificarAbono.FechaAbono;
                    abono.VALORABONO = modificarAbono.ValorAbono;

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
                throw new ArgumentException("Error al modificar abono: " + ex);
            }
        }
        public bool EliminarAbono(int id)
        {
            try
            {
                if (BuscarAbono(id))
                {
                    Modelo.ABONO abono = ConectorDALC.ModeloAlmacen.ABONO.FirstOrDefault(a => a.ABONOID == id);
                    ConectorDALC.ModeloAlmacen.ABONO.Remove(abono);
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
                throw new ArgumentException("Error al eliminar abono: " + ex);
            }
        }
        #endregion

    }
}
