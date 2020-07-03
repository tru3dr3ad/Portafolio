using Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
        public string Contrasena { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaCreacionUsuario { get; set; }
        public string DireccionUsuario { get; set; }
        public int TelefonoUsuario { get; set; }
        public string Correo { get; set; }
        public TipoUsuario Tipo { get; set; }

        #region Constructores
        public Usuario(int run, char dv, string nombre, string apellido, string contrasena, DateTime fechaNacimiento,
            DateTime fechaCreacion, string direccion, int telefono, string correo, TipoUsuario tipo)
        {
            RunUsuario = run;
            DvUsuario = dv;
            NombreUsuario = nombre;
            ApellidoUsuario = apellido;
            Contrasena = contrasena;
            FechaNacimiento = fechaNacimiento;
            FechaCreacionUsuario = fechaCreacion;
            DireccionUsuario = direccion;
            TelefonoUsuario = telefono;
            Correo = correo;
            Tipo = tipo;
        }
        public Usuario(string contrasena)
        {
            Contrasena = contrasena;
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
        public List<Modelo.USUARIO> Listar()
        {
            List<Modelo.USUARIO> listado = new List<Modelo.USUARIO>();
            listado = ConectorDALC.ModeloAlmacen.USUARIO.ToList();
            return listado;
        }
        public List<V_USUARIOS> ListarUsuarios()
        {
            List<V_USUARIOS> listado = new List<V_USUARIOS>();
            listado = ConectorDALC.ModeloAlmacen.V_USUARIOS.ToList();
            return listado;
        }
        public List<V_USUARIOS> ListarUsuariosPorNombre(string nombre)
        {
            List<V_USUARIOS> listado = new List<V_USUARIOS>();
            listado = ConectorDALC.ModeloAlmacen.V_USUARIOS.Where(u => u.NOMBRE_USUARIO.Contains(nombre))
                .OrderBy(u => u.NOMBRE_USUARIO).ToList();
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
                Contrasena = usuario.CONTRASENA;
                FechaNacimiento = usuario.FECHANACIMIENTO;
                FechaCreacionUsuario = usuario.FECHACREACION;
                DireccionUsuario = usuario.DIRECCION;
                TelefonoUsuario = (int)usuario.TELEFONO;
                Correo = usuario.CORREO;
                Tipo = new TipoUsuario() { Id = (int)usuario.TIPO_USUARIO.IDTIPO };

                Usuario usuarioEncontrado = new Usuario(RunUsuario, DvUsuario, NombreUsuario, ApellidoUsuario, Contrasena,
                    FechaNacimiento, FechaCreacionUsuario, DireccionUsuario, TelefonoUsuario, Correo, Tipo);
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
                usuario.NOMBRE = NombreUsuario;
                usuario.APELLIDO = ApellidoUsuario;
                usuario.CONTRASENA = GenerateSHA256String(Contrasena);
                usuario.FECHANACIMIENTO = FechaNacimiento;
                usuario.FECHACREACION = FechaCreacionUsuario;
                usuario.DIRECCION = DireccionUsuario;
                usuario.TELEFONO = TelefonoUsuario;
                usuario.CORREO = Correo;
                usuario.TIPO_USUARIO_IDTIPO = Tipo.Id;

                ConectorDALC.ModeloAlmacen.USUARIO.Add(usuario);
                ConectorDALC.ModeloAlmacen.SaveChanges();
                return true;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
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
                    usuario.APELLIDO = modificarUsuario.ApellidoUsuario;
                    usuario.CONTRASENA = GenerateSHA256String(Contrasena);
                    usuario.FECHANACIMIENTO = modificarUsuario.FechaNacimiento;
                    usuario.DIRECCION = modificarUsuario.DireccionUsuario;
                    usuario.TELEFONO = modificarUsuario.TelefonoUsuario;
                    usuario.TIPO_USUARIO_IDTIPO = modificarUsuario.Tipo.Id;

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
        public bool CambiarContrasena(Usuario usuario)
        {
            try
            {
                if (BuscarUsuario(usuario.RunUsuario))
                {
                    Modelo.USUARIO usuarioModelo = ConectorDALC.ModeloAlmacen.USUARIO.FirstOrDefault(e => e.RUNUSUARIO == usuario.RunUsuario);
                    usuarioModelo.CONTRASENA = GenerateSHA256String(Contrasena);
                    
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
                throw new ArgumentException("Error al cambiar la contraseña" + ex);
            }
        }
        public bool VerificarContrasena(Usuario usuario, string contrasena)
        {
            try
            {
                string contrasenaCodificada = GenerateSHA256String(contrasena);
                if (usuario.Contrasena == contrasenaCodificada)
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
                throw ;
            }
        }
        public bool AsignarNuevaContrasena(Usuario usuario)
        {
            try
            {
                string nuevaContraseña = GenerarContrasena();
                usuario.Contrasena = nuevaContraseña;
                bool contrasenaCambiada = usuario.CambiarContrasena(usuario);
                if (contrasenaCambiada)
                {
                    if (EnviarCorreoRecuperacionCuenta(usuario, nuevaContraseña))
                    {
                        return true;
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }
        public bool EnviarCorreoRecuperacionCuenta(Usuario usuario, string nuevaContrasena)
        {
            try
            {
                Validaciones validar = new Validaciones();
                string correo = usuario.Correo;
                string asunto = "Recuperacion de Contraseña Personal Almacen Los Yuyitos";
                string body = @"<html>
                      <body>
                      <p>Buenas Tardes {usuario} ,</p>
                      <p>Si usted esta viendo este correo, significa que ha olvidado su contraseña, seguido de eso ha solicitado la recuperacion de esta, la cual le sera facilitada en la parte de abajo de este mensaje. En caso de que usted no haya solicitado la recuperacion de contraseña de la aplicacion de Almancen, por favor contactarse con el administrador.</p>
                        <br></br>
                       <p>La contraseña es: {contrasena}</p> 
                        <br></br>
                        <br></br>
                      <p>De antemano se despide:<br>-Administracion Los Yuyitos</br></p>
                        <br></br>
                        <br></br>
                      </body>
                      </html>
                     ";
                body = body.Replace("{usuario}", usuario.NombreUsuario);
                body = body.Replace("{contrasena}", nuevaContrasena);
                bool recuperacionEnviada = validar.EnviarEmail(correo, asunto, body);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool EnviarCorreoBienvenida(Usuario usuario, string contrasena)
        {
            try
            {
                Validaciones validar = new Validaciones();
                string correo = usuario.Correo;
                string asunto = "Bienvenido Personal Almacen Los Yuyitos";
                string body = @"<html>
                      <body>
                      <p>Buenas Tardes {usuario} ,</p>
                      <p>Esperando que se encuentre megnificamente, este correo es para darle la bienvenida a nuestra empresa, esperando que tenga una calida llegada, tambien le adjuntaremos una contraseña personal, la cual podra ser cambiada una vez haya ingresado al sistema. De igual manera se le recuerda que su nombre de usuario es el nombre con el cual se la ha saludado al inicio de este correo.</p>
                        <br></br>
                       <p>La contraseña es: {contrasena}</p> 
                        <br></br>
                        <br></br>
                      <p>De antemano se despide:<br>-Administracion Los Yuyitos</br></p>
                        <br></br>
                        <br></br>
                      </body>
                      </html>
                     ";
                body = body.Replace("{usuario}", usuario.NombreUsuario);
                body = body.Replace("{contrasena}", contrasena);
                bool recuperacionEnviada = validar.EnviarEmail(correo, asunto, body);
                if (recuperacionEnviada)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
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
                    .Where(u => u.CONTRASENA == clave).First();

                if (usuarioDB != null)
                {
                    Usuario usuario = new Usuario();
                    usuario.RunUsuario = (int)usuarioDB.RUNUSUARIO;
                    usuario.NombreUsuario = usuarioDB.NOMBRE;
                    usuario.Contrasena = usuarioDB.CONTRASENA;
                    TipoUsuario tipo = new TipoUsuario()
                    {
                        Id = (int)usuarioDB.TIPO_USUARIO.IDTIPO,
                        Descripcion = usuarioDB.TIPO_USUARIO.DESCRIPCION
                    };
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
        public string VerCodigoContrasena(string contrasena)
        {
            string codigo = GenerateSHA256String(contrasena);
            return codigo;
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
        public string GenerarContrasena()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        #endregion
    }
}
