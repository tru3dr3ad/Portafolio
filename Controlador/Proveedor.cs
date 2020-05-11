using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        #region Metodos
        public List<Modelo.PROVEEDOR> ListarProveedor()
        {
            List<Modelo.PROVEEDOR> listado = new List<Modelo.PROVEEDOR>();
            listado = ConectorDALC.ModeloAlmacen.PROVEEDOR.ToList();
            return listado;
        }
        public Proveedor ObtenerProveedor(int rutProveedor)
        {
            try
            {
                Modelo.PROVEEDOR proveedor = ConectorDALC.ModeloAlmacen.PROVEEDOR.FirstOrDefault(e => e.RUTPROVEEDOR == rutProveedor);
                Rut = (int)proveedor.RUTPROVEEDOR;
                Dv = char.Parse(proveedor.DVPROVEEDOR);
                IdProveedor = (int)proveedor.IDPROVEEDOR;
                Nombre = proveedor.NOMBREPROVEEDOR;
                CorreoElectronico = proveedor.CORREOPROVEEDOR;
                Telefono = proveedor.FONOPROVEEDOR;
                Direccion = proveedor.DIRECCIONPROVEEDOR;
                Tipo = new TipoRubro() { Id = (int)proveedor.TIPO_RUBRO.RUBROID };
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
                Modelo.PROVEEDOR proveedor = ConectorDALC.ModeloAlmacen.PROVEEDOR.FirstOrDefault(e => e.RUTPROVEEDOR == rutProveedor);
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

                proveedor.RUTPROVEEDOR = Rut;
                proveedor.DVPROVEEDOR = Dv.ToString();
                proveedor.IDPROVEEDOR = IdProveedor;
                proveedor.NOMBREPROVEEDOR = Nombre;
                proveedor.CORREOPROVEEDOR = CorreoElectronico;
                proveedor.FONOPROVEEDOR = Telefono;
                proveedor.DIRECCIONPROVEEDOR = Direccion;
                proveedor.TIPO_RUBRO_RUBROID = Tipo.Id;

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
                    Modelo.PROVEEDOR proveedor = ConectorDALC.ModeloAlmacen.PROVEEDOR.FirstOrDefault(e => e.RUTPROVEEDOR == modificarProveedor.Rut);
                    proveedor.RUTPROVEEDOR = modificarProveedor.Rut;
                    proveedor.DVPROVEEDOR = modificarProveedor.Dv.ToString();
                    proveedor.IDPROVEEDOR = modificarProveedor.IdProveedor;
                    proveedor.NOMBREPROVEEDOR = modificarProveedor.Nombre;
                    proveedor.CORREOPROVEEDOR = modificarProveedor.CorreoElectronico;
                    proveedor.FONOPROVEEDOR = modificarProveedor.Telefono;
                    proveedor.DIRECCIONPROVEEDOR = modificarProveedor.Direccion;
                    proveedor.TIPO_RUBRO_RUBROID = modificarProveedor.Tipo.Id;

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
                    Modelo.PROVEEDOR proveedor = ConectorDALC.ModeloAlmacen.PROVEEDOR.FirstOrDefault(e => e.RUTPROVEEDOR == rutProveedor);
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
