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
        #endregion

        #region Eventos
        private void txtRunUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion
    }
}