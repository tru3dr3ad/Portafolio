using Controlador;
using System;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region Metodos
        private void IniciarSesion()
        {
            string nombreUsuario = txtNombreUsuario.Text.ToUpper();
            string clave = txtContrasena.Text.ToUpper();
            Usuario usuario = new Usuario();
            usuario = usuario.Login(nombreUsuario, clave);

            //if(txtNombreUsuario.Text == "KRISTAL")
            if (usuario != null)
            {
                //frmMenuAdmin frmAdministrador = new frmMenuAdmin();
                //frmAdministrador.ShowDialog();
                Global.RunUsuarioActivo = usuario.RunUsuario;
                MostrarMenu(usuario.Tipo.Id);
            }
            else
            {
                MessageBox.Show("Nombre o Contraseña invalidos");
            }
        }
        private void MostrarMenu(int idTipoUsuario)
        {
            //this.Hide();
            if (idTipoUsuario == 1)
            {
                frmMenuAdmin frmAdministrador = new frmMenuAdmin();
                frmAdministrador.ShowDialog();
            }
            else if (idTipoUsuario == 2)
            {
                frmMenuVendedor frmVendedor = new frmMenuVendedor();
                frmVendedor.ShowDialog();
            }
        }
        #endregion

        #region Botones
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string rutaAyuda = @"\Ayuda\Ayuda.chm";
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string ayudaPath = projectDirectory + rutaAyuda;
            Help.ShowHelp(this, ayudaPath, "Login.htm");
        }
        #endregion

        private void lblContrasenaOlvidada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmContrasenaRecuperar recuperacion = new frmContrasenaRecuperar();
            recuperacion.ShowDialog();
        }

        
    }
}
