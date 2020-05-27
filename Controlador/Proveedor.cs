using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controlador
{
    public class Proveedor
    {
        public int Rut { get; set; }
        public char Dv { get; set; }
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public TipoRubro Tipo { get; set; }

        #region Constructores
        public Proveedor(int rut, char dv, int id, string nombre, string correo, int telefono, string direccion, TipoRubro tipo)
        {
            Rut = rut;
            Dv = dv;
            IdProveedor = id;
            Nombre = nombre;
            CorreoElectronico = correo;
            Telefono = telefono;
            Direccion = direccion;
            Tipo = tipo;
        }
        public Proveedor()
        {

        }
        #endregion

        #region Metodos para listar
        public IList<Proveedor> ListarCombobox()
        {
            List<Proveedor> listado = new List<Proveedor>();
            foreach (Modelo.PROVEEDOR proveedor in ConectorDALC.ModeloAlmacen.PROVEEDOR.ToList())
            {
                Proveedor proveedors = new Proveedor();
                proveedors.Rut = (int)proveedor.RUT;
                proveedors.Nombre = proveedor.NOMBRE;
                listado.Add(proveedors);
            }
            return listado;
        }
        public IList<Proveedor> ListarComboboxId()
        {
            List<Proveedor> listado = new List<Proveedor>();
            foreach (Modelo.PROVEEDOR proveedor in ConectorDALC.ModeloAlmacen.PROVEEDOR.ToList())
            {
                Proveedor proveedors = new Proveedor();
                proveedors.IdProveedor = (int)proveedor.ID;
                proveedors.Nombre = proveedor.NOMBRE;
                listado.Add(proveedors);
            }
            return listado;
        }
        public List<Modelo.PROVEEDOR> Listar()
        {
            List<Modelo.PROVEEDOR> listado = new List<Modelo.PROVEEDOR>();
            listado = ConectorDALC.ModeloAlmacen.PROVEEDOR.ToList();
            return listado;
        }
        public List<V_PROVEEDORES> ListarProveedor()
        {
            List<V_PROVEEDORES> listado = new List<V_PROVEEDORES>();
            listado = ConectorDALC.ModeloAlmacen.V_PROVEEDORES.ToList();
            return listado;
        }
        #endregion

        #region Metodos
        public Proveedor ObtenerProveedor(int rutProveedor)
        {
            try
            {
                Modelo.PROVEEDOR proveedor = ConectorDALC.ModeloAlmacen.PROVEEDOR.FirstOrDefault(e => e.RUT == rutProveedor);
                Rut = (int)proveedor.RUT;
                Dv = char.Parse(proveedor.DV);
                IdProveedor = (int)proveedor.ID;
                Nombre = proveedor.NOMBRE;
                CorreoElectronico = proveedor.CORREO;
                Telefono = proveedor.TELEFONO;
                Direccion = proveedor.DIRECCION;
                Tipo = new TipoRubro() { Id = (int)proveedor.TIPO_RUBRO.IDRUBRO };
                Proveedor proveedorEncontrado = new Proveedor(Rut, Dv, IdProveedor, Nombre, CorreoElectronico, Telefono, Direccion, Tipo);
                return proveedorEncontrado;
            }
            catch (Exception ex)
            {
                return null;
                throw new ArgumentException("Error al obtener proveedor: " + ex);
            }
        }
        public bool BuscarProveedor(int rutProveedor)
        {
            try
            {
                Modelo.PROVEEDOR proveedor = ConectorDALC.ModeloAlmacen.PROVEEDOR.FirstOrDefault(e => e.RUT == rutProveedor);
                if (proveedor != null)
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
        public bool AgregarProveedor()
        {
            try
            {
                Modelo.PROVEEDOR proveedor = new Modelo.PROVEEDOR();

                proveedor.RUT = Rut;
                proveedor.DV = Dv.ToString();
                proveedor.ID = IdProveedor;
                proveedor.NOMBRE = Nombre;
                proveedor.CORREO = CorreoElectronico;
                proveedor.TELEFONO = Telefono;
                proveedor.DIRECCION = Direccion;
                proveedor.TIPO_RUBRO_IDRUBRO= Tipo.Id;

                ConectorDALC.ModeloAlmacen.PROVEEDOR.Add(proveedor);
                ConectorDALC.ModeloAlmacen.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al agregar proveedor" + ex);
            }
        }
        public bool ModificarProveedor(Proveedor modificarProveedor)
        {
            try
            {
                if (BuscarProveedor(modificarProveedor.Rut))
                {
                    Modelo.PROVEEDOR proveedor = ConectorDALC.ModeloAlmacen.PROVEEDOR.FirstOrDefault(e => e.RUT == modificarProveedor.Rut);
                    proveedor.RUT = modificarProveedor.Rut;
                    proveedor.DV = modificarProveedor.Dv.ToString();
                    proveedor.ID= modificarProveedor.IdProveedor;
                    proveedor.NOMBRE = modificarProveedor.Nombre;
                    proveedor.CORREO = modificarProveedor.CorreoElectronico;
                    proveedor.TELEFONO = modificarProveedor.Telefono;
                    proveedor.DIRECCION= modificarProveedor.Direccion;
                    proveedor.TIPO_RUBRO_IDRUBRO = modificarProveedor.Tipo.Id;

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
                throw new ArgumentException("Error al modificar proveedor: " + ex);
            }
        }
        public bool EliminarProveedor(int rutProveedor)
        {
            try
            {
                if (BuscarProveedor(rutProveedor))
                {
                    Modelo.PROVEEDOR proveedor = ConectorDALC.ModeloAlmacen.PROVEEDOR.FirstOrDefault(e => e.RUT == rutProveedor);
                    ConectorDALC.ModeloAlmacen.PROVEEDOR.Remove(proveedor);
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
                throw new ArgumentException("Error al eliminar proveedor" + ex);
            }
        }
        #endregion

    }
}
