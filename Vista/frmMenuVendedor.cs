﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmMenuVendedor : Form
    {
        public frmMenuVendedor()
        {
            InitializeComponent();
            PersonalizarDiseño();
        }
        #region Metodos Diseño
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
        private void PersonalizarDiseño()
        {
            pnlClienteSubMenu.Visible = false;
            pnlVentaSubMenu.Visible = false;
        }
        private void OcultarSubMenu()
        {
            if (pnlVentaSubMenu.Visible)
            {
                pnlVentaSubMenu.Visible = false;
            }
            if (pnlClienteSubMenu.Visible)
            {
                pnlClienteSubMenu.Visible = false;
            }
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void OcultarNombresMenu()
        {
            btnDashboard.Text = "";
            btnCliente.Text = "";
            btnVentas.Text = "";
            btnPedido.Text = "";
            btnProducto.Text = "";
            btnCerrarSesion.Text = "";
            btnRealizarVenta.Text = "";
            btnRevisarVentas.Text = "";
            btnRevisionCliente.Text = "";
            btnFiado.Text = "";
        }
        private void MostrarNombresMenu()
        {
            btnDashboard.Text = "Dashboard";
            btnCliente.Text = "Clientes";
            btnVentas.Text = "Ventas";
            btnPedido.Text = "Pedidos";
            btnProducto.Text = "Productos";
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnRealizarVenta.Text = "Realizar Venta";
            btnRevisarVentas.Text = "Revisar Ventas";
            btnRevisionCliente.Text = "Revision Clientes";
            btnFiado.Text = "Fiados";
        }
        private void NombreFormularioAbierto(string nombre)
        {
            lblTituloForm.Text = nombre;
        }
        private void btnMenuVertical_Click(object sender, EventArgs e)
        {
            if (pnlMenuVertical.Width == 200)
            {
                pnlMenuVertical.Width = 50;
                OcultarNombresMenu();
                OcultarSubMenu();
            }
            else
            {
                pnlMenuVertical.Width = 200;
                MostrarNombresMenu();
            }
        }

        private void pnlBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Botones
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
            OcultarSubMenu();
            AbrirFormInPanel(new frmDashboard());
            NombreFormularioAbierto("Dashboard");
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlVentaSubMenu);
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            AbrirFormInPanel(new frmPuntoVenta());
            NombreFormularioAbierto("Punto de Venta");
        }

        private void btnRevisarVentas_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            NombreFormularioAbierto("Ventas");
            AbrirFormInPanel(new frmRevisarVenta());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlClienteSubMenu);
        }

        private void btnFiado_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmFiado());
            OcultarSubMenu();
            NombreFormularioAbierto("Fiados");
        }

        private void btnRevisionCliente_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            NombreFormularioAbierto("Clientes");
            AbrirFormInPanel(new frmCliente());
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            AbrirFormInPanel(new frmProducto());
            NombreFormularioAbierto("Productos");
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            AbrirFormInPanel(new frmRevisarPedido());
            NombreFormularioAbierto("Orden de Pedido");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            this.Dispose();
        }
        #endregion

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            AbrirFormInPanel(new frmCambiarContrasena());
            NombreFormularioAbierto("Cambio de Contraseña");
        }
    }
}
