using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
        }
        //CONFIGURACIONES PARA HACER VENTANA MOVIBLE
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //FUNCIONES DASHBOARD
        //ABRIR FORMULARIO COMO PANEL
        private void AbrirFormInPanel(object formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }
        private void btnMenuVertical_Click(object sender, EventArgs e)
        {
            if (pnlMenuVertical.Width == 200)
            {
                pnlMenuVertical.Width = 50;
            }
            else
            {
                pnlMenuVertical.Width = 200;
            }
        }

        private void pnlBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmDashboard());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmVenta());
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmProducto());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmCliente());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmPedido());
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmProveedor());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmUsuario());
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmEstadistica());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmConfiguracion());
        }
    }
}
