using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmContrasenaRecuperar : Form
    {
        public frmContrasenaRecuperar()
        {
            InitializeComponent();
            EsconderVerificacionEmail();
        }

        #region Metodos
        private void EsconderVerificacionEmail()
        {
            grpCorreo.Visible = false;
        }
        private string ValidarUsuario()
        {
            string mensajeError = string.Empty;
            string runUsuario = txtRunUsuario.Text + "-" + txtDv.Text;
            Validaciones validaciones = new Validaciones();
            if (validaciones.ValidarRun(runUsuario))
            {
                return mensajeError;
            }
            else
            {
                mensajeError = "El rut ingresado es invalido";
            }
            return mensajeError;
        }
        private void MostrarGroupBoxUsuario()
        {
            string msgEsValido = ValidarUsuario();
            if (string.IsNullOrEmpty(msgEsValido))
            {
                Usuario usuario = new Usuario();
                int run = int.Parse(txtRunUsuario.Text);
                if (usuario.BuscarUsuario(run))
                {
                    usuario = usuario.ObtenerUsuario(int.Parse(txtRunUsuario.Text));
                    lblNombreUsuario.Text = usuario.NombreUsuario;
                    lblMostrarCorreo.Text = usuario.Correo;
                    grpCorreo.Visible = true;
                    txtRunUsuario.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Rut no pertenece al personal");
                }
            }
            else
            {
                MessageBox.Show(msgEsValido);
            }
        }
        private void EnviarEmailRecuperacionContrasena(Usuario usuario)
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
                      <p>De antemano se despide:,<br>-Administracion Los Yuyitos</br></p>
                        <br></br>
                        <br></br>
                        <p>PRUEBA</p> 
                      </body>
                      </html>
                     ";
            body = body.Replace("{usuario}", usuario.NombreUsuario);
            body = body.Replace("{contrasena}", usuario.Contrasena);
            bool recuperacionEnviada = validar.EnviarEmail(correo, asunto, body);
            if (recuperacionEnviada)
            {
                MessageBox.Show("Se ha enviado un correo de recuperacion a la direccion indicada anteriormente.");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error enviando el correo de recuperacion");
            }
        }
        private void VerificarCorreoUsuario()
        {
            int run = int.Parse(txtRunUsuario.Text);
            Usuario usuario = new Usuario();
            usuario = usuario.ObtenerUsuario(run);
            if (usuario.Correo == txtVerificarCorreo.Text.ToUpper())
            {
                EnviarEmailRecuperacionContrasena(usuario);
            }
            else
            {
                MessageBox.Show("El correo ingresado no coincide con el registrado. Por favor contactar con un administrador.");
            }
        }
        #endregion

        #region Botones
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnVerificarUsuario_Click(object sender, EventArgs e)
        {
            MostrarGroupBoxUsuario();
        }
        private void btnVerificarCorreo_Click(object sender, EventArgs e)
        {
            VerificarCorreoUsuario();
        }
        #endregion

        #region Eventos
        private void txtRunUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion
        
    }
}