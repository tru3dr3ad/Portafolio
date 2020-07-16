using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmCambiarContrasena : Form
    {
        public frmCambiarContrasena()
        {
            InitializeComponent();
        }

        #region Metodos
        private bool VerificarContrasenaActual()
        {
            Usuario usuario = new Usuario();
            int runUsuarioActivo = Global.RunUsuarioActivo;
            usuario = usuario.ObtenerUsuario(runUsuarioActivo);
            string contrasena = txtContrasenaActual.Text.ToUpper();
            bool contrasenaIgual = usuario.VerificarContrasena(usuario, contrasena);
            if (contrasenaIgual)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CambiarContrasena()
        {
            if (VerificarContrasenaActual())
            {
                if (!String.IsNullOrEmpty(txtContrasenaNueva.Text) && !String.IsNullOrEmpty(txtContrasenaNueva.Text))
                {
                    if (txtContrasenaNueva.Text == txtRepertirContrasenaNueva.Text)
                    {
                        string contrasenaNueva = txtContrasenaNueva.Text.ToUpper();
                        Usuario usuario = new Usuario();
                        usuario = usuario.ObtenerUsuario(Global.RunUsuarioActivo);
                        usuario.Contrasena = contrasenaNueva;
                        if (usuario.CambiarContrasena(usuario))
                        {
                            MessageBox.Show("Contraseña se ha cambiado exitosamente.");
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se ha cambiado la contraseña.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No coinciden las contraseñas, verificar la contrasena.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar datos en los campos.");
                }
            }
            else
            {
                MessageBox.Show("La contraseña actual ingresada es incorrecta.");
            }
        }
        private void LimpiarCampos()
        {
            txtContrasenaActual.Clear();
            txtContrasenaNueva.Clear();
            txtRepertirContrasenaNueva.Clear();
        }
        #endregion

        #region Botones
        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            CambiarContrasena();
        }
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string rutaAyuda = @"\Ayuda\Ayuda.chm";
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string ayudaPath = projectDirectory + rutaAyuda;
            Help.ShowHelp(this, ayudaPath, "Cambio contraseña.htm");
        }
        #endregion
    }
}
