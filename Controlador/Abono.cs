using System;
using System.Collections.Generic;
using System.Linq;

namespace Controlador
{
    public class Abono
    {
        public int Id { get; set; }
        public Boleta Boleta { get; set; }
        public int ValorAbono { get; set; }
        public DateTime FechaAbono { get; set; }
        public DateTime FechaLimite { get; set; }

        #region Constructores
        public Abono(int id, Boleta boleta, int valorAbono, DateTime fechaAbono, DateTime fechaLimite)
        {
            Id = id;
            Boleta = boleta;
            ValorAbono = valorAbono;
            FechaAbono = fechaAbono;
            FechaLimite = fechaLimite;
        }
        public Abono(Boleta boleta, int valorAbono, DateTime fechaAbono, DateTime fechaLimite)
        {
            Boleta = boleta;
            ValorAbono = valorAbono;
            FechaAbono = fechaAbono;
            FechaLimite = fechaLimite;
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
                Modelo.ABONO abono = ConectorDALC.ModeloAlmacen.ABONO.FirstOrDefault(a => a.IDABONO == id);
                Id = (int)abono.IDABONO;
                Boleta = new Boleta() { Numero = (int)abono.BOLETA.NUMEROBOLETA};
                ValorAbono = (int)abono.VALOR;
                FechaAbono = abono.FECHAABONO;
                FechaLimite = abono.FECHALIMITE;
                Abono abonoEncontrado = new Abono(Id, Boleta, ValorAbono, FechaAbono, FechaLimite);
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
                int id = (int)ConectorDALC.ModeloAlmacen.ABONO.Max(a => a.IDABONO);
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
                Modelo.ABONO abono = ConectorDALC.ModeloAlmacen.ABONO.FirstOrDefault(a => a.IDABONO == id);
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
                abono.VALOR = ValorAbono;

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
                    Modelo.ABONO abono = ConectorDALC.ModeloAlmacen.ABONO.FirstOrDefault(a => a.IDABONO == modificarAbono.Id);
                    abono.IDABONO = modificarAbono.Id;
                    abono.FECHAABONO= modificarAbono.FechaAbono;
                    abono.VALOR = modificarAbono.ValorAbono;

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
                    Modelo.ABONO abono = ConectorDALC.ModeloAlmacen.ABONO.FirstOrDefault(a => a.IDABONO == id);
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
