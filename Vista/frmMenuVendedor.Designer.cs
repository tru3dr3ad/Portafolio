namespace Vista
{
    partial class frmMenuVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuVendedor));
            this.pnlBarraSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMenuVertical = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
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
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.pnlBarraSuperior.SuspendLayout();
            this.pnlMenuVertical.SuspendLayout();
            this.pnlClienteSubMenu.SuspendLayout();
            this.pnlVentaSubMenu.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraSuperior
            // 
            this.pnlBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.pnlBarraSuperior.Controls.Add(this.btnPerfil);
            this.pnlBarraSuperior.Controls.Add(this.btnMinimizar);
            this.pnlBarraSuperior.Controls.Add(this.btnMenuVertical);
            this.pnlBarraSuperior.Controls.Add(this.btnCerrar);
            this.pnlBarraSuperior.Controls.Add(this.label1);
            this.pnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Size = new System.Drawing.Size(1200, 50);
            this.pnlBarraSuperior.TabIndex = 8;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendedor";
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.pnlMenuVertical.Controls.Add(this.btnCerrarSesion);
            this.pnlMenuVertical.Controls.Add(this.btnPedido);
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
            this.pnlMenuVertical.TabIndex = 12;
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
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 360);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 40);
            this.btnCerrarSesion.TabIndex = 47;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.Color.White;
            this.btnPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnPedido.Image")));
            this.btnPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.Location = new System.Drawing.Point(0, 320);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPedido.Size = new System.Drawing.Size(200, 40);
            this.btnPedido.TabIndex = 42;
            this.btnPedido.Text = "Pedidos";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
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
            this.btnProducto.Size = new System.Drawing.Size(200, 40);
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
            this.pnlClienteSubMenu.Size = new System.Drawing.Size(200, 80);
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
            this.btnRevisionCliente.Size = new System.Drawing.Size(200, 40);
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
            this.btnFiado.Size = new System.Drawing.Size(200, 40);
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
            this.btnCliente.Size = new System.Drawing.Size(200, 40);
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
            this.pnlVentaSubMenu.Size = new System.Drawing.Size(200, 80);
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
            this.btnRevisarVentas.Size = new System.Drawing.Size(200, 40);
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
            this.btnRealizarVenta.Size = new System.Drawing.Size(200, 44);
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
            this.btnVentas.Size = new System.Drawing.Size(200, 40);
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
            this.btnDashboard.Size = new System.Drawing.Size(200, 40);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
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
            this.pnlBarraTitulo.TabIndex = 13;
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.Location = new System.Drawing.Point(852, 16);
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
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 100);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1000, 550);
            this.pnlContenedor.TabIndex = 14;
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPerfil.BackgroundImage")));
            this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Location = new System.Drawing.Point(1065, 5);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(40, 40);
            this.btnPerfil.TabIndex = 6;
            this.btnPerfil.UseVisualStyleBackColor = true;
            // 
            // frmMenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.pnlMenuVertical);
            this.Controls.Add(this.pnlBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Vendedor";
            this.pnlBarraSuperior.ResumeLayout(false);
            this.pnlBarraSuperior.PerformLayout();
            this.pnlMenuVertical.ResumeLayout(false);
            this.pnlClienteSubMenu.ResumeLayout(false);
            this.pnlVentaSubMenu.ResumeLayout(false);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBarraSuperior;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMenuVertical;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMenuVertical;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Panel pnlClienteSubMenu;
        private System.Windows.Forms.Button btnRevisionCliente;
        private System.Windows.Forms.Button btnFiado;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel pnlVentaSubMenu;
        private System.Windows.Forms.Button btnRevisarVentas;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnPerfil;
    }
}