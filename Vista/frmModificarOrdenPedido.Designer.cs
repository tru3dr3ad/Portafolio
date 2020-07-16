namespace Vista
{
    partial class frmModificarOrdenPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarOrdenPedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlOrden = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.pnlContenedorGrillaOrden = new System.Windows.Forms.Panel();
            this.grdOrden = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumeroOrden = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalOrden = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRutProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.pnlContenedorGrillaProducto = new System.Windows.Forms.Panel();
            this.grdProducto = new System.Windows.Forms.DataGridView();
            this.pnlTituloGrilla = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnModificarOrden = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlOrden.SuspendLayout();
            this.pnlContenedorGrillaOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrden)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlProducto.SuspendLayout();
            this.pnlContenedorGrillaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducto)).BeginInit();
            this.pnlTituloGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(957, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Modificar Orden de Pedido";
            // 
            // pnlOrden
            // 
            this.pnlOrden.AllowDrop = true;
            this.pnlOrden.Controls.Add(this.btnQuitarProducto);
            this.pnlOrden.Controls.Add(this.btnModificarOrden);
            this.pnlOrden.Controls.Add(this.btnAyuda);
            this.pnlOrden.Controls.Add(this.pnlContenedorGrillaOrden);
            this.pnlOrden.Controls.Add(this.label3);
            this.pnlOrden.Controls.Add(this.txtTotalOrden);
            this.pnlOrden.Controls.Add(this.groupBox1);
            this.pnlOrden.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOrden.Location = new System.Drawing.Point(450, 48);
            this.pnlOrden.Name = "pnlOrden";
            this.pnlOrden.Size = new System.Drawing.Size(550, 502);
            this.pnlOrden.TabIndex = 24;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.BackgroundImage")));
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAyuda.Location = new System.Drawing.Point(526, 4);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(21, 22);
            this.btnAyuda.TabIndex = 11;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // pnlContenedorGrillaOrden
            // 
            this.pnlContenedorGrillaOrden.Controls.Add(this.grdOrden);
            this.pnlContenedorGrillaOrden.Controls.Add(this.panel2);
            this.pnlContenedorGrillaOrden.Location = new System.Drawing.Point(22, 13);
            this.pnlContenedorGrillaOrden.Name = "pnlContenedorGrillaOrden";
            this.pnlContenedorGrillaOrden.Size = new System.Drawing.Size(319, 407);
            this.pnlContenedorGrillaOrden.TabIndex = 37;
            // 
            // grdOrden
            // 
            this.grdOrden.AllowUserToAddRows = false;
            this.grdOrden.AllowUserToResizeRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            this.grdOrden.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.grdOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdOrden.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdOrden.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdOrden.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOrden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.grdOrden.ColumnHeadersHeight = 30;
            this.grdOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdOrden.DefaultCellStyle = dataGridViewCellStyle31;
            this.grdOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOrden.EnableHeadersVisualStyles = false;
            this.grdOrden.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdOrden.Location = new System.Drawing.Point(0, 39);
            this.grdOrden.MultiSelect = false;
            this.grdOrden.Name = "grdOrden";
            this.grdOrden.ReadOnly = true;
            this.grdOrden.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdOrden.RowHeadersVisible = false;
            this.grdOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOrden.Size = new System.Drawing.Size(319, 368);
            this.grdOrden.TabIndex = 14;
            this.grdOrden.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrden_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 85;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 85;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 62;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblNumeroOrden);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 39);
            this.panel2.TabIndex = 25;
            // 
            // lblNumeroOrden
            // 
            this.lblNumeroOrden.AutoSize = true;
            this.lblNumeroOrden.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroOrden.Location = new System.Drawing.Point(203, 2);
            this.lblNumeroOrden.Name = "lblNumeroOrden";
            this.lblNumeroOrden.Size = new System.Drawing.Size(46, 30);
            this.lblNumeroOrden.TabIndex = 31;
            this.lblNumeroOrden.Text = "001";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nro Orden de Pedido";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "Total:";
            // 
            // txtTotalOrden
            // 
            this.txtTotalOrden.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalOrden.Enabled = false;
            this.txtTotalOrden.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOrden.Location = new System.Drawing.Point(220, 431);
            this.txtTotalOrden.Name = "txtTotalOrden";
            this.txtTotalOrden.Size = new System.Drawing.Size(121, 35);
            this.txtTotalOrden.TabIndex = 7;
            this.txtTotalOrden.Text = "0";
            this.txtTotalOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbProveedor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtRutProveedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(358, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 121);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(30, 40);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(121, 21);
            this.cmbProveedor.TabIndex = 8;
            this.cmbProveedor.SelectedValueChanged += new System.EventHandler(this.cmbProveedor_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nombre:";
            // 
            // txtRutProveedor
            // 
            this.txtRutProveedor.Enabled = false;
            this.txtRutProveedor.Location = new System.Drawing.Point(30, 79);
            this.txtRutProveedor.Name = "txtRutProveedor";
            this.txtRutProveedor.Size = new System.Drawing.Size(121, 20);
            this.txtRutProveedor.TabIndex = 9;
            this.txtRutProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rut:";
            // 
            // pnlProducto
            // 
            this.pnlProducto.Controls.Add(this.btnBuscarProducto);
            this.pnlProducto.Controls.Add(this.pnlContenedorGrillaProducto);
            this.pnlProducto.Controls.Add(this.btnAgregarProducto);
            this.pnlProducto.Controls.Add(this.txtCantidad);
            this.pnlProducto.Controls.Add(this.label2);
            this.pnlProducto.Controls.Add(this.label4);
            this.pnlProducto.Controls.Add(this.cmbCategoria);
            this.pnlProducto.Controls.Add(this.txtBuscarProducto);
            this.pnlProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProducto.Location = new System.Drawing.Point(0, 48);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(450, 502);
            this.pnlProducto.TabIndex = 25;
            // 
            // pnlContenedorGrillaProducto
            // 
            this.pnlContenedorGrillaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedorGrillaProducto.Controls.Add(this.grdProducto);
            this.pnlContenedorGrillaProducto.Controls.Add(this.pnlTituloGrilla);
            this.pnlContenedorGrillaProducto.Location = new System.Drawing.Point(12, 64);
            this.pnlContenedorGrillaProducto.Name = "pnlContenedorGrillaProducto";
            this.pnlContenedorGrillaProducto.Size = new System.Drawing.Size(422, 362);
            this.pnlContenedorGrillaProducto.TabIndex = 41;
            // 
            // grdProducto
            // 
            this.grdProducto.AllowUserToResizeRows = false;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            this.grdProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle32;
            this.grdProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdProducto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.grdProducto.ColumnHeadersHeight = 30;
            this.grdProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProducto.EnableHeadersVisualStyles = false;
            this.grdProducto.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdProducto.Location = new System.Drawing.Point(0, 39);
            this.grdProducto.MultiSelect = false;
            this.grdProducto.Name = "grdProducto";
            this.grdProducto.ReadOnly = true;
            this.grdProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.grdProducto.RowHeadersVisible = false;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black;
            this.grdProducto.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.grdProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProducto.Size = new System.Drawing.Size(422, 323);
            this.grdProducto.TabIndex = 13;
            this.grdProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProducto_CellClick);
            // 
            // pnlTituloGrilla
            // 
            this.pnlTituloGrilla.BackColor = System.Drawing.Color.Silver;
            this.pnlTituloGrilla.Controls.Add(this.label1);
            this.pnlTituloGrilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloGrilla.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloGrilla.Name = "pnlTituloGrilla";
            this.pnlTituloGrilla.Size = new System.Drawing.Size(422, 39);
            this.pnlTituloGrilla.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(236, 431);
            this.txtCantidad.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(87, 35);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ingrese Producto:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(83, 28);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 1;
            this.cmbCategoria.SelectedValueChanged += new System.EventHandler(this.cmbCategoria_SelectedValueChanged);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(231, 28);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(121, 20);
            this.txtBuscarProducto.TabIndex = 2;
            this.txtBuscarProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnModificarOrden
            // 
            this.btnModificarOrden.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModificarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnModificarOrden.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnModificarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarOrden.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarOrden.ForeColor = System.Drawing.Color.White;
            this.btnModificarOrden.Location = new System.Drawing.Point(379, 393);
            this.btnModificarOrden.Name = "btnModificarOrden";
            this.btnModificarOrden.Size = new System.Drawing.Size(130, 27);
            this.btnModificarOrden.TabIndex = 45;
            this.btnModificarOrden.Text = "MODIFICAR ORDEN";
            this.btnModificarOrden.UseVisualStyleBackColor = false;
            this.btnModificarOrden.Click += new System.EventHandler(this.btnModificarOrden_Click);
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnQuitarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnQuitarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnQuitarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarProducto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProducto.ForeColor = System.Drawing.Color.White;
            this.btnQuitarProducto.Location = new System.Drawing.Point(22, 428);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(94, 38);
            this.btnQuitarProducto.TabIndex = 47;
            this.btnQuitarProducto.Text = "Quitar";
            this.btnQuitarProducto.UseVisualStyleBackColor = false;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnAgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(329, 429);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(104, 38);
            this.btnAgregarProducto.TabIndex = 46;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarProducto.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Location = new System.Drawing.Point(358, 26);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProducto.TabIndex = 47;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // frmModificarOrdenPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pnlProducto);
            this.Controls.Add(this.pnlOrden);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarOrdenPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModificarOrdenPedido";
            this.Load += new System.EventHandler(this.frmModificarOrdenPedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlOrden.ResumeLayout(false);
            this.pnlOrden.PerformLayout();
            this.pnlContenedorGrillaOrden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrden)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            this.pnlContenedorGrillaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProducto)).EndInit();
            this.pnlTituloGrilla.ResumeLayout(false);
            this.pnlTituloGrilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlOrden;
        private System.Windows.Forms.Panel pnlContenedorGrillaOrden;
        private System.Windows.Forms.DataGridView grdOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNumeroOrden;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalOrden;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRutProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Panel pnlContenedorGrillaProducto;
        protected System.Windows.Forms.DataGridView grdProducto;
        private System.Windows.Forms.Panel pnlTituloGrilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnModificarOrden;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
    }
}