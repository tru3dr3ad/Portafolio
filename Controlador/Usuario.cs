using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Controlador
{
    public class Usuario
    {
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

        #region Constructores
        public Usuario(int run, char dv, string nombre, string apellido, string clave, DateTime fechaNacimiento,
            DateTime fechaCreacion, string direccion, int telefono, TipoUsuario tipo)
        {
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
        #endregion

        #region Metodos para listar
        public IList<Usuario> ListarCombobox()
        {
            List<Usuario> listado = new List<Usuario>();
            foreach (Modelo.USUARIO usuario in ConectorDALC.ModeloAlmacen.USUARIO.ToList())
            {
                Usuario usuarios = new Usuario();
                usuarios.RunUsuario = (int)usuario.RUNUSUARIO;
                usuarios.NombreUsuario = usuario.NOMBRE;
                listado.Add(usuarios);
            }
            return listado;
        }
        public List<V_USUARIOS> ListarUsuarios()
        {
            List<V_USUARIOS> listado = new List<V_USUARIOS>();
            listado = ConectorDALC.ModeloAlmacen.V_USUARIOS.ToList();
            return listado;
        }
        public List<Modelo.USUARIO> Listar()
        {
            List<Modelo.USUARIO> listado = new List<Modelo.USUARIO>();
            listado = ConectorDALC.ModeloAlmacen.USUARIO.ToList();
            return listado;
        }
        #endregion

        #region Metodos
        public Usuario ObtenerUsuario(int runUsuario)
        {
            try
            {
                Modelo.USUARIO usuario = ConectorDALC.ModeloAlmacen.USUARIO.FirstOrDefault(e => e.RUNUSUARIO == runUsuario);
                RunUsuario = (int)usuario.RUNUSUARIO;
                DvUsuario = char.Parse(usuario.DV);
                NombreUsuario = usuario.NOMBRE;
                ApellidoUsuario = usuario.APELLIDO;
                ClaveUsuario = usuario.CONTRASENA;
                FechaNacimiento = usuario.FECHANACIMIENTO;
                FechaCreacionUsuario = usuario.FECHACREACION;
                DireccionUsuario = usuario.DIRECCION;
                TelefonoUsuario = (int)usuario.TELEFONO;
                Tipo = new TipoUsuario() { Id = (int)usuario.TIPO_USUARIO.IDTIPO };

                Usuario usuarioEncontrado = new Usuario(RunUsuario, DvUsuario, NombreUsuario, ApellidoUsuario, ClaveUsuario,
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

                usuario.RUNUSUARIO = RunUsuario;
                usuario.DV = DvUsuario.ToString();
                usuario.NOMBRE= NombreUsuario;
                usuario.APELLIDO= ApellidoUsuario;
                usuario.CONTRASENA= GenerateSHA256String(ClaveUsuario);
                usuario.FECHANACIMIENTO = FechaNacimiento;
                usuario.FECHACREACION = FechaCreacionUsuario;
                usuario.DIRECCION= DireccionUsuario;
                usuario.TELEFONO= TelefonoUsuario;
                usuario.TIPO_USUARIO_IDTIPO= Tipo.Id;

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
                    usuario.RUNUSUARIO = modificarUsuario.RunUsuario;
                    usuario.DV = modificarUsuario.DvUsuario.ToString();
                    usuario.NOMBRE = modificarUsuario.NombreUsuario;
                    usuario.APELLIDO= modificarUsuario.ApellidoUsuario;
                    usuario.CONTRASENA= modificarUsuario.ClaveUsuario;
                    usuario.FECHANACIMIENTO = modificarUsuario.FechaNacimiento;
                    usuario.DIRECCION= modificarUsuario.DireccionUsuario;
                    usuario.TELEFONO= modificarUsuario.TelefonoUsuario;
                    usuario.TIPO_USUARIO_IDTIPO= modificarUsuario.Tipo.Id;

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
                throw new ArgumentException("Error al modificar usuario" + ex);
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

        #region Encriptación
        public Usuario Login(string nombreUsuario, string contrasena)
        {
            try
            {
                string clave = GenerateSHA256String(contrasena);
                Modelo.USUARIO usuarioDB = ConectorDALC.ModeloAlmacen.USUARIO
                    .Where(u => u.NOMBRE == nombreUsuario)
                    .Where(u => u.CONTRASENA == clave).FirstOrDefault();

                if (usuarioDB != null)
                {
                    Usuario usuario = new Usuario();
                    usuario.RunUsuario = (int)usuarioDB.RUNUSUARIO;
                    usuario.NombreUsuario = usuarioDB.NOMBRE;
                    usuario.ClaveUsuario = usuarioDB.CONTRASENA;
                    TipoUsuario tipo = new TipoUsuario() { Id = (int)usuarioDB.TIPO_USUARIO.IDTIPO, 
                        Descripcion = usuarioDB.TIPO_USUARIO.DESCRIPCION };
                    usuario.Tipo = tipo;
                    return usuario;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
                throw new ArgumentException("Error al iniciar sesion: " + ex);
            }
        }

        public static string GenerateSHA256String(string inputString)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha256.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }

        #endregion
    }
}
