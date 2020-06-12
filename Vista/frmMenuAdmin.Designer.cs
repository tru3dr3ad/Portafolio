namespace Vista
{
    partial class frmMenuAdmin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdmin));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlReporteSubMenu = new System.Windows.Forms.Panel();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.pnlPedidoSubMenu = new System.Windows.Forms.Panel();
            this.btnRevisarPedido = new System.Windows.Forms.Button();
            this.btnHacerPedido = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.pnlClienteSubMenu = new System.Windows.Forms.Panel();
            this.btnRevisionCliente = new System.Windows.Forms.Button();
            this.btnFiado = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.pnlVentaSubMenu = new System.Windows.Forms.Panel();
            this.btnRevisarVentas = new System.Windows.Forms.Button();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlBarraSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMenuVertical = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBarraTitulo.SuspendLayout();
            this.pnlMenuVertical.SuspendLayout();
            this.pnlReporteSubMenu.SuspendLayout();
            this.pnlPedidoSubMenu.SuspendLayout();
            this.pnlClienteSubMenu.SuspendLayout();
            this.pnlVentaSubMenu.SuspendLayout();
            this.pnlBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 100);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1000, 550);
            this.pnlContenedor.TabIndex = 7;
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBarraTitulo.Controls.Add(this.lblTituloForm);
            this.pnlBarraTitulo.Controls.Add(this.label2);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(200, 50);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1000, 50);
            this.pnlBarraTitulo.TabIndex = 6;
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.Location = new System.Drawing.Point(844, 16);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(86, 21);
            this.lblTituloForm.TabIndex = 3;
            this.lblTituloForm.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bienvenido";
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.AutoScroll = true;
            this.pnlMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.pnlMenuVertical.Controls.Add(this.btnCerrarSesion);
            this.pnlMenuVertical.Controls.Add(this.pnlReporteSubMenu);
            this.pnlMenuVertical.Controls.Add(this.btnReportes);
            this.pnlMenuVertical.Controls.Add(this.btnUsuarios);
            this.pnlMenuVertical.Controls.Add(this.btnProveedor);
            this.pnlMenuVertical.Controls.Add(this.pnlPedidoSubMenu);
            this.pnlMenuVertical.Controls.Add(this.btnPedidos);
            this.pnlMenuVertical.Controls.Add(this.btnProducto);
            this.pnlMenuVertical.Controls.Add(this.pnlClienteSubMenu);
            this.pnlMenuVertical.Controls.Add(this.btnCliente);
            this.pnlMenuVertical.Controls.Add(this.pnlVentaSubMenu);
            this.pnlMenuVertical.Controls.Add(this.btnVentas);
            this.pnlMenuVertical.Controls.Add(this.btnDashboard);
            this.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuVertical.Location = new System.Drawing.Point(0, 50);
            this.pnlMenuVertical.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(200, 600);
            this.pnlMenuVertical.TabIndex = 5;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 640);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(183, 40);
            this.btnCerrarSesion.TabIndex = 56;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pnlReporteSubMenu
            // 
            this.pnlReporteSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(150)))), ((int)(((byte)(141)))));
            this.pnlReporteSubMenu.Controls.Add(this.btnInforme);
            this.pnlReporteSubMenu.Controls.Add(this.btnEstadisticas);
            this.pnlReporteSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReporteSubMenu.Location = new System.Drawing.Point(0, 560);
            this.pnlReporteSubMenu.Name = "pnlReporteSubMenu";
            this.pnlReporteSubMenu.Size = new System.Drawing.Size(183, 80);
            this.pnlReporteSubMenu.TabIndex = 55;
            // 
            // btnInforme
            // 
            this.btnInforme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInforme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInforme.FlatAppearance.BorderSize = 0;
            this.btnInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInforme.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInforme.ForeColor = System.Drawing.Color.White;
            this.btnInforme.Image = ((System.Drawing.Image)(resources.GetObject("btnInforme.Image")));
            this.btnInforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInforme.Location = new System.Drawing.Point(0, 40);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnInforme.Size = new System.Drawing.Size(183, 40);
            this.btnInforme.TabIndex = 50;
            this.btnInforme.Text = "Informes";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.ForeColor = System.Drawing.Color.White;
            this.btnEstadisticas.Image = ((System.Drawing.Image)(resources.GetObject("btnEstadisticas.Image")));
            this.btnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEstadisticas.Size = new System.Drawing.Size(183, 40);
            this.btnEstadisticas.TabIndex = 49;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 520);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(183, 40);
            this.btnReportes.TabIndex = 53;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 480);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(183, 40);
            this.btnUsuarios.TabIndex = 52;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.ForeColor = System.Drawing.Color.White;
            this.btnProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedor.Image")));
            this.btnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedor.Location = new System.Drawing.Point(0, 440);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProveedor.Size = new System.Drawing.Size(183, 40);
            this.btnProveedor.TabIndex = 51;
            this.btnProveedor.Text = "Proveedores";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // pnlPedidoSubMenu
            // 
            this.pnlPedidoSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(150)))), ((int)(((byte)(141)))));
            this.pnlPedidoSubMenu.Controls.Add(this.btnRevisarPedido);
            this.pnlPedidoSubMenu.Controls.Add(this.btnHacerPedido);
            this.pnlPedidoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPedidoSubMenu.Location = new System.Drawing.Point(0, 360);
            this.pnlPedidoSubMenu.Name = "pnlPedidoSubMenu";
            this.pnlPedidoSubMenu.Size = new System.Drawing.Size(183, 80);
            this.pnlPedidoSubMenu.TabIndex = 46;
            // 
            // btnRevisarPedido
            // 
            this.btnRevisarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRevisarPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRevisarPedido.FlatAppearance.BorderSize = 0;
            this.btnRevisarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevisarPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevisarPedido.ForeColor = System.Drawing.Color.White;
            this.btnRevisarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnRevisarPedido.Image")));
            this.btnRevisarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevisarPedido.Location = new System.Drawing.Point(0, 40);
            this.btnRevisarPedido.Name = "btnRevisarPedido";
            this.btnRevisarPedido.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRevisarPedido.Size = new System.Drawing.Size(183, 40);
            this.btnRevisarPedido.TabIndex = 54;
            this.btnRevisarPedido.Text = "Revision";
            this.btnRevisarPedido.UseVisualStyleBackColor = true;
            this.btnRevisarPedido.Click += new System.EventHandler(this.btnRevisarPedido_Click);
            // 
            // btnHacerPedido
            // 
            this.btnHacerPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHacerPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHacerPedido.FlatAppearance.BorderSize = 0;
            this.btnHacerPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHacerPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerPedido.ForeColor = System.Drawing.Color.White;
            this.btnHacerPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnHacerPedido.Image")));
            this.btnHacerPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHacerPedido.Location = new System.Drawing.Point(0, 0);
            this.btnHacerPedido.Name = "btnHacerPedido";
            this.btnHacerPedido.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHacerPedido.Size = new System.Drawing.Size(183, 40);
            this.btnHacerPedido.TabIndex = 53;
            this.btnHacerPedido.Text = "Hacer Pedido";
            this.btnHacerPedido.UseVisualStyleBackColor = true;
            this.btnHacerPedido.Click += new System.EventHandler(this.btnHacerPedido_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.White;
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.Location = new System.Drawing.Point(0, 320);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPedidos.Size = new System.Drawing.Size(183, 40);
            this.btnPedidos.TabIndex = 42;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnProducto.Image")));
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(0, 280);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProducto.Size = new System.Drawing.Size(183, 40);
            this.btnProducto.TabIndex = 41;
            this.btnProducto.Text = "Productos";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // pnlClienteSubMenu
            // 
            this.pnlClienteSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(150)))), ((int)(((byte)(141)))));
            this.pnlClienteSubMenu.Controls.Add(this.btnRevisionCliente);
            this.pnlClienteSubMenu.Controls.Add(this.btnFiado);
            this.pnlClienteSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClienteSubMenu.Location = new System.Drawing.Point(0, 200);
            this.pnlClienteSubMenu.Name = "pnlClienteSubMenu";
            this.pnlClienteSubMenu.Size = new System.Drawing.Size(183, 80);
            this.pnlClienteSubMenu.TabIndex = 39;
            // 
            // btnRevisionCliente
            // 
            this.btnRevisionCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRevisionCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRevisionCliente.FlatAppearance.BorderSize = 0;
            this.btnRevisionCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevisionCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevisionCliente.ForeColor = System.Drawing.Color.White;
            this.btnRevisionCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnRevisionCliente.Image")));
            this.btnRevisionCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevisionCliente.Location = new System.Drawing.Point(0, 40);
            this.btnRevisionCliente.Name = "btnRevisionCliente";
            this.btnRevisionCliente.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRevisionCliente.Size = new System.Drawing.Size(183, 40);
            this.btnRevisionCliente.TabIndex = 41;
            this.btnRevisionCliente.Text = "Revision Clientes";
            this.btnRevisionCliente.UseVisualStyleBackColor = true;
            this.btnRevisionCliente.Click += new System.EventHandler(this.btnRevisionCliente_Click);
            // 
            // btnFiado
            // 
            this.btnFiado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFiado.FlatAppearance.BorderSize = 0;
            this.btnFiado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiado.ForeColor = System.Drawing.Color.White;
            this.btnFiado.Image = ((System.Drawing.Image)(resources.GetObject("btnFiado.Image")));
            this.btnFiado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiado.Location = new System.Drawing.Point(0, 0);
            this.btnFiado.Name = "btnFiado";
            this.btnFiado.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFiado.Size = new System.Drawing.Size(183, 40);
            this.btnFiado.TabIndex = 34;
            this.btnFiado.Text = "Fiados";
            this.btnFiado.UseVisualStyleBackColor = true;
            this.btnFiado.Click += new System.EventHandler(this.btnFiado_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 160);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCliente.Size = new System.Drawing.Size(183, 40);
            this.btnCliente.TabIndex = 40;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pnlVentaSubMenu
            // 
            this.pnlVentaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(150)))), ((int)(((byte)(141)))));
            this.pnlVentaSubMenu.Controls.Add(this.btnRevisarVentas);
            this.pnlVentaSubMenu.Controls.Add(this.btnRealizarVenta);
            this.pnlVentaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVentaSubMenu.Location = new System.Drawing.Point(0, 80);
            this.pnlVentaSubMenu.Name = "pnlVentaSubMenu";
            this.pnlVentaSubMenu.Size = new System.Drawing.Size(183, 80);
            this.pnlVentaSubMenu.TabIndex = 39;
            // 
            // btnRevisarVentas
            // 
            this.btnRevisarVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRevisarVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRevisarVentas.FlatAppearance.BorderSize = 0;
            this.btnRevisarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevisarVentas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevisarVentas.ForeColor = System.Drawing.Color.White;
            this.btnRevisarVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnRevisarVentas.Image")));
            this.btnRevisarVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevisarVentas.Location = new System.Drawing.Point(0, 44);
            this.btnRevisarVentas.Name = "btnRevisarVentas";
            this.btnRevisarVentas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRevisarVentas.Size = new System.Drawing.Size(183, 40);
            this.btnRevisarVentas.TabIndex = 41;
            this.btnRevisarVentas.Text = "Revisar Ventas";
            this.btnRevisarVentas.UseVisualStyleBackColor = true;
            this.btnRevisarVentas.Click += new System.EventHandler(this.btnRevisarVentas_Click);
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRealizarVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRealizarVenta.FlatAppearance.BorderSize = 0;
            this.btnRealizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarVenta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRealizarVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnRealizarVenta.Image")));
            this.btnRealizarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRealizarVenta.Location = new System.Drawing.Point(0, 0);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRealizarVenta.Size = new System.Drawing.Size(183, 44);
            this.btnRealizarVenta.TabIndex = 40;
            this.btnRealizarVenta.Text = "Punto de Venta";
            this.btnRealizarVenta.UseVisualStyleBackColor = true;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 40);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(183, 40);
            this.btnVentas.TabIndex = 7;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(183, 40);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlBarraSuperior
            // 
            this.pnlBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.pnlBarraSuperior.Controls.Add(this.btnMinimizar);
            this.pnlBarraSuperior.Controls.Add(this.btnMenuVertical);
            this.pnlBarraSuperior.Controls.Add(this.btnCerrar);
            this.pnlBarraSuperior.Controls.Add(this.btnConfiguracion);
            this.pnlBarraSuperior.Controls.Add(this.label1);
            this.pnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Size = new System.Drawing.Size(1200, 50);
            this.pnlBarraSuperior.TabIndex = 4;
            this.pnlBarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraSuperior_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(1111, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMenuVertical
            // 
            this.btnMenuVertical.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuVertical.BackgroundImage")));
            this.btnMenuVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuVertical.FlatAppearance.BorderSize = 0;
            this.btnMenuVertical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuVertical.Location = new System.Drawing.Point(204, 5);
            this.btnMenuVertical.Name = "btnMenuVertical";
            this.btnMenuVertical.Size = new System.Drawing.Size(45, 40);
            this.btnMenuVertical.TabIndex = 4;
            this.btnMenuVertical.UseVisualStyleBackColor = true;
            this.btnMenuVertical.Click += new System.EventHandler(this.btnMenuVertical_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(1157, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfiguracion.BackgroundImage")));
            this.btnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Location = new System.Drawing.Point(1065, 3);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(40, 40);
            this.btnConfiguracion.TabIndex = 2;
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador";
            // 
            // frmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.pnlMenuVertical);
            this.Controls.Add(this.pnlBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yuyitos";
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.pnlMenuVertical.ResumeLayout(false);
            this.pnlReporteSubMenu.ResumeLayout(false);
            this.pnlPedidoSubMenu.ResumeLayout(false);
            this.pnlClienteSubMenu.ResumeLayout(false);
            this.pnlVentaSubMenu.ResumeLayout(false);
            this.pnlBarraSuperior.ResumeLayout(false);
            this.pnlBarraSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMenuVertical;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlBarraSuperior;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMenuVertical;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPedidoSubMenu;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Panel pnlClienteSubMenu;
        private System.Windows.Forms.Button btnRevisionCliente;
        private System.Windows.Forms.Button btnFiado;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel pnlVentaSubMenu;
        private System.Windows.Forms.Button btnRevisarVentas;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlReporteSubMenu;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnRevisarPedido;
        private System.Windows.Forms.Button btnHacerPedido;
    }
}

