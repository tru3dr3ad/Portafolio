using System;
using System.Collections.Generic;
using System.Linq;

namespace Controlador
{
    public class TipoCliente
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        #region Constructores
        public TipoCliente(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public TipoCliente(string descripcion)
        {
            Descripcion = descripcion;
        }
        public TipoCliente()
        {

        }
        #endregion

        #region Metodos
        public IList<TipoCliente> Listar()
        {
            List<TipoCliente> listado = new List<TipoCliente>();
            foreach (Modelo.TIPO_CLIENTE tipoCliente in ConectorDALC.ModeloAlmacen.TIPO_CLIENTE.ToList())
            {
                TipoCliente tipo = new TipoCliente();
                tipo.Id = (int)tipoCliente.IDTIPO;
                tipo.Descripcion = tipoCliente.DESCRIPCION;
                listado.Add(tipo);
            }
            return listado;
        }
        public override string ToString()
        {
            return Descripcion;
        }
        public TipoCliente ObtenerTipoCliente(int id)
        {
            try
            {
                Modelo.TIPO_CLIENTE estadoModelo = ConectorDALC.ModeloAlmacen.TIPO_CLIENTE.FirstOrDefault(e => e.IDTIPO == id);
                Id = (int)estadoModelo.IDTIPO;
                Descripcion = estadoModelo.DESCRIPCION;
                TipoCliente estado = new TipoCliente(Id, Descripcion);
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
        public bool BuscarTipoCliente(string descripcion)
        {
            try
            {
                Modelo.TIPO_CLIENTE tipo = ConectorDALC.ModeloAlmacen.TIPO_CLIENTE.FirstOrDefault(t => t.DESCRIPCION == descripcion);
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
        public bool AgregarTipoCliente(string descripcion)
        {
            try
            {
                if (BuscarTipoCliente(descripcion))
                {
                    return false;
                }
                else
                {
                    Modelo.TIPO_CLIENTE tipo = new Modelo.TIPO_CLIENTE();

                    tipo.DESCRIPCION = Descripcion;

                    ConectorDALC.ModeloAlmacen.TIPO_CLIENTE.Add(tipo);
                    ConectorDALC.ModeloAlmacen.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al agregar tipo de cliente" + ex);
            }
        }
        public bool EliminarTipoCliente(string descripcion)
        {
            try
            {
                if (BuscarTipoCliente(descripcion))
                {
                    Modelo.TIPO_CLIENTE estado = ConectorDALC.ModeloAlmacen.TIPO_CLIENTE.FirstOrDefault(t => t.DESCRIPCION == descripcion);
                    ConectorDALC.ModeloAlmacen.TIPO_CLIENTE.Remove(estado);
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
                throw new ArgumentException("Error al eliminar tipo de cliente: " + ex);
            }
        }
        #endregion

    }
}
