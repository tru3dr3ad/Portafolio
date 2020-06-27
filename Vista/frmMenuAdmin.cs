﻿using Controlador;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
            PersonalizarDiseño();
        }
        #region Metodos Para el Diseño

        //CONFIGURACIONES PARA HACER VENTANA MOVIBLE
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //FUNCIONES DASHBOARD
        //ABRIR FORMULARIO COMO PANEL
        public void AbrirFormInPanel(object formHijo)
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
            pnlReporteSubMenu.Visible = false;
            pnlClienteSubMenu.Visible = false;
            pnlVentaSubMenu.Visible = false;
            pnlPedidoSubMenu.Visible = false;
        }
        private void OcultarSubMenu()
        {
            if (pnlReporteSubMenu.Visible)
            {
                pnlReporteSubMenu.Visible = false;
            }
            if (pnlVentaSubMenu.Visible)
            {
                pnlVentaSubMenu.Visible = false;
            }
            if (pnlClienteSubMenu.Visible)
            {
                pnlClienteSubMenu.Visible = false;
            }
            if (pnlPedidoSubMenu.Visible)
            {
                pnlPedidoSubMenu.Visible = false;
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
            btnPedidos.Text = "";
            btnHacerPedido.Text = "";
            btnRevisarPedido.Text = "";
            btnProveedor.Text = "";
            btnProducto.Text = "";
            btnUsuarios.Text = "";
            btnCerrarSesion.Text = "";
            btnReportes.Text = "";
            btnEstadisticas.Text = "";
            btnInforme.Text = "";
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
            btnPedidos.Text = "Pedidos";
            btnHacerPedido.Text = "Hacer Pedido";
            btnRevisarPedido.Text = "Revision";
            btnProveedor.Text = "Proveedores";
            btnProducto.Text = "Productos";
            btnUsuarios.Text = "Usuarios";
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnReportes.Text = "Reportes";
            btnEstadisticas.Text = "Estadisticas";
            btnInforme.Text = "Informe";
            btnRealizarVenta.Text = "Realizar Venta";
            btnRevisarVentas.Text = "Revisar Ventas";
            btnRevisionCliente.Text = "Revision Clientes";
            btnFiado.Text = "Fiados";
        }
        private void NombreFormularioAbierto(string nombre)
        {
            lblTituloForm.Text = nombre;
        }
        private void pnlBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Botones
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
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            AbrirFormInPanel(new frmConfiguracion());
            NombreFormularioAbierto("Configuración");
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
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlPedidoSubMenu);
        }
        private void btnProveedor_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            AbrirFormInPanel(new frmProveedor());
            NombreFormularioAbierto("Proveedores");
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            AbrirFormInPanel(new frmUsuario());
            NombreFormularioAbierto("Usuarios");
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlReporteSubMenu);
        }
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            AbrirFormInPanel(new frmEstadistica());
            NombreFormularioAbierto("Estadisticas");
        }
        private void btnInforme_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            AbrirFormInPanel(new frmInforme());
            NombreFormularioAbierto("Informes");
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            Global.RunUsuarioActivo = 0;
            this.Dispose();
        }
        private void btnHacerPedido_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            AbrirFormInPanel(new frmOrdenPedido());
            NombreFormularioAbierto("Orden de Pedido");
        }
        private void btnRevisarPedido_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            AbrirFormInPanel(new frmRevisarPedido());
            NombreFormularioAbierto("Orden de Pedido");
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            AbrirFormInPanel(new frmCambiarContrasena());
            NombreFormularioAbierto("Cambio de Contraseña");
        }
        #endregion


    }
}
