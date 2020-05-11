using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int RunUsuario { get; set; }
        public char DvUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string ClaveUsuario { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaCreacionUsuario { get; set; }
        public string DireccionUsuario { get; set; }
        public int TelefonoUsuario { get; set; }
        public TipoUsuario Tipo { get; set; }

        public Usuario(int idUsuario, int run, char dv, string nombre, string apellido, string clave, DateTime fechaNacimiento,
            DateTime fechaCreacion, string direccion, int telefono, TipoUsuario tipo)
        {
            IdUsuario = idUsuario;
            RunUsuario = run;
            DvUsuario = dv;
            NombreUsuario = nombre;
            ApellidoUsuario = apellido;
            ClaveUsuario = clave;
            FechaNacimiento = fechaNacimiento;
            FechaCreacionUsuario = fechaCreacion;
            DireccionUsuario = direccion;
            TelefonoUsuario = telefono;
            Tipo = tipo;
        }
        public Usuario()
        {

        }
        #region Metodos
        public List<Modelo.USUARIO> Listar()
        {
            List<Modelo.USUARIO> listado = new List<Modelo.USUARIO>();
            listado = ConectorDALC.ModeloAlmacen.USUARIO.ToList();
            return listado;
        }
        public Usuario ObtenerUsuario(int runUsuario)
        {
            try
            {
                Modelo.USUARIO usuario = ConectorDALC.ModeloAlmacen.USUARIO.FirstOrDefault(e => e.RUNUSUARIO == runUsuario);
                IdUsuario = (int)usuario.USUARIOID;
                RunUsuario = (int)usuario.RUNUSUARIO;
                DvUsuario = char.Parse(usuario.DVUSUARIO);
                NombreUsuario = usuario.NOMBREUSUARIO;
                ApellidoUsuario = usuario.APELLIDOUSUARIO;
                ClaveUsuario = usuario.CLAVEUSUARIO;
                FechaNacimiento = usuario.FECHANACIMIENTO;
                FechaCreacionUsuario = usuario.FECHACREACION;
                DireccionUsuario = usuario.DIRECCIONUSUARIO;
                TelefonoUsuario = (int)usuario.TELEFONOUSUARIO;
                Tipo = new TipoUsuario() { Id = (int)usuario.TIPO_USUARIO.TIPOUSUARIOID };

                Usuario usuarioEncontrado = new Usuario(IdUsuario, RunUsuario, DvUsuario, NombreUsuario, ApellidoUsuario, ClaveUsuario,
                    FechaNacimiento, FechaCreacionUsuario, DireccionUsuario, TelefonoUsuario, Tipo);
                return usuarioEncontrado;
            }
            catch (Exception ex)
            {
                return null;
                throw new ArgumentNullException("Error al obtener al usuario: " + ex);
            }
        }
        public bool BuscarUsuario(int runUsuario)
        {
            try
            {
                Modelo.USUARIO usuario = ConectorDALC.ModeloAlmacen.USUARIO.FirstOrDefault(e => e.RUNUSUARIO == runUsuario);
                if (usuario != null)
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
                throw new ArgumentException("Error al buscar usuario: " + ex);
            }
        }
        public bool AgregarUsuario()
        {
            try
            {
                Modelo.USUARIO usuario = new Modelo.USUARIO();

                usuario.USUARIOID = IdUsuario;
                usuario.RUNUSUARIO = RunUsuario;
                usuario.DVUSUARIO = DvUsuario.ToString();
                usuario.NOMBREUSUARIO = NombreUsuario;
                usuario.APELLIDOUSUARIO = ApellidoUsuario;
                usuario.CLAVEUSUARIO = ClaveUsuario;
                usuario.FECHANACIMIENTO = FechaNacimiento;
                usuario.FECHACREACION = FechaCreacionUsuario;
                usuario.DIRECCIONUSUARIO = DireccionUsuario;
                usuario.TELEFONOUSUARIO = TelefonoUsuario;
                usuario.TIPO_USUARIO_TIPOUSUARIOID = Tipo.Id;

                ConectorDALC.ModeloAlmacen.USUARIO.Add(usuario);
                ConectorDALC.ModeloAlmacen.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException("Error al agregar usuario: " + ex); 
            }
        }
        public bool ModificarUsuario(Usuario modificarUsuario)
        {
            try
            {
                if (BuscarUsuario(modificarUsuario.RunUsuario))
                {
                    Modelo.USUARIO usuario = ConectorDALC.ModeloAlmacen.USUARIO.FirstOrDefault(e => e.RUNUSUARIO == modificarUsuario.RunUsuario);
                    usuario.USUARIOID = modificarUsuario.IdUsuario;
                    usuario.RUNUSUARIO = modificarUsuario.RunUsuario;
                    usuario.DVUSUARIO = modificarUsuario.DvUsuario.ToString();
                    usuario.NOMBREUSUARIO = modificarUsuario.NombreUsuario;
                    usuario.APELLIDOUSUARIO = modificarUsuario.ApellidoUsuario;
                    usuario.CLAVEUSUARIO = modificarUsuario.ClaveUsuario;
                    usuario.FECHANACIMIENTO = modificarUsuario.FechaNacimiento;
                    usuario.DIRECCIONUSUARIO = modificarUsuario.DireccionUsuario;
                    usuario.TELEFONOUSUARIO = modificarUsuario.TelefonoUsuario;
                    usuario.TIPO_USUARIO_TIPOUSUARIOID = modificarUsuario.Tipo.Id;

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
                throw new ArgumentException("Error al modificar usuario"+ex);
            }
        }
        public bool EliminarUsuario(int runUsuario)
        {
            try
            {
                if (BuscarUsuario(runUsuario))
                {
                    Modelo.USUARIO usuario = ConectorDALC.ModeloAlmacen.USUARIO.First(e => e.RUNUSUARIO == runUsuario);
                    ConectorDALC.ModeloAlmacen.USUARIO.Remove(usuario);
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
                throw new ArgumentException("Error al eliminar usuario: " + ex);
            }
        }
        #endregion
    }
}
