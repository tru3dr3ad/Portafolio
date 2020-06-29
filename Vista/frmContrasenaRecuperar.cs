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
                    lblMostrarCorreo.Text = MostrarCorreo(usuario.Correo.Trim());
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
        private void VerificarCorreoUsuario()
        {
            int run = int.Parse(txtRunUsuario.Text);
            Usuario usuario = new Usuario();
            usuario = usuario.ObtenerUsuario(run);
            if (usuario.Correo.Trim() == txtVerificarCorreo.Text.ToUpper())
            {
                AsignarNuevaContrasena(usuario);
            }
            else
            {
                MessageBox.Show("El correo ingresado no coincide con el registrado. Por favor contactar con un administrador.");
            }
        }
        private string MostrarCorreo(string correo)
        {
            string inicio = string.Empty;
            string medio = string.Empty;
            string final = string.Empty;
            string completo = string.Empty;
            inicio = correo.Substring(0, 3);
            medio = correo.Substring(3, correo.Length - 6);
            medio = ReemplazarTodo(medio, '*');
            final = correo.Substring(correo.Length - 3, 3);
            completo = inicio + medio + final;
            return completo;
        }
        private string ReemplazarTodo(string input, char target)
        {
            StringBuilder sb = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(target);
            }

            return sb.ToString();
        }
        private void AsignarNuevaContrasena(Usuario usuario)
        {
            if (usuario.AsignarNuevaContrasena(usuario))
            {
                MessageBox.Show("Se ha enviado una nueva contraseña a su correo electronico.");
            }
            else
            {
                MessageBox.Show("Error al asignar una nueva contraseña");
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