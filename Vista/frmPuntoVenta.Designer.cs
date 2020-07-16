namespace Vista
{
    partial class frmPuntoVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuntoVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlVenta = new System.Windows.Forms.Panel();
            this.pnlBoleta = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.pnlContenedorGrillaBoleta = new System.Windows.Forms.Panel();
            this.grdBoleta = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumeroBoleta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalBoleta = new System.Windows.Forms.TextBox();
            this.btnRealizarBoleta = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRunCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.pnlContenedorGrilla = new System.Windows.Forms.Panel();
            this.grdProducto = new System.Windows.Forms.DataGridView();
            this.pnlTituloGrilla = new System.Windows.Forms.Panel();
            this.nombreGrilla = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarBoleta = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.pnlVenta.SuspendLayout();
            this.pnlBoleta.SuspendLayout();
            this.pnlContenedorGrillaBoleta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBoleta)).BeginInit();
            this.panel2.SuspendLayout();
            this.btnRealizarBoleta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlProducto.SuspendLayout();
            this.pnlContenedorGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducto)).BeginInit();
            this.pnlTituloGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVenta
            // 
            this.pnlVenta.Controls.Add(this.pnlBoleta);
            this.pnlVenta.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlVenta.Location = new System.Drawing.Point(450, 0);
            this.pnlVenta.Name = "pnlVenta";
            this.pnlVenta.Size = new System.Drawing.Size(550, 550);
            this.pnlVenta.TabIndex = 16;
            // 
            // pnlBoleta
            // 
            this.pnlBoleta.Controls.Add(this.btnQuitarProducto);
            this.pnlBoleta.Controls.Add(this.btnAgregarBoleta);
            this.pnlBoleta.Controls.Add(this.btnAyuda);
            this.pnlBoleta.Controls.Add(this.pnlContenedorGrillaBoleta);
            this.pnlBoleta.Controls.Add(this.label3);
            this.pnlBoleta.Controls.Add(this.txtTotalBoleta);
            this.pnlBoleta.Controls.Add(this.btnRealizarBoleta);
            this.pnlBoleta.Controls.Add(this.groupBox1);
            this.pnlBoleta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBoleta.Location = new System.Drawing.Point(0, 0);
            this.pnlBoleta.Name = "pnlBoleta";
            this.pnlBoleta.Size = new System.Drawing.Size(550, 550);
            this.pnlBoleta.TabIndex = 19;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.BackgroundImage")));
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAyuda.Location = new System.Drawing.Point(524, 5);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(21, 22);
            this.btnAyuda.TabIndex = 12;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // pnlContenedorGrillaBoleta
            // 
            this.pnlContenedorGrillaBoleta.Controls.Add(this.grdBoleta);
            this.pnlContenedorGrillaBoleta.Controls.Add(this.panel2);
            this.pnlContenedorGrillaBoleta.Location = new System.Drawing.Point(22, 12);
            this.pnlContenedorGrillaBoleta.Name = "pnlContenedorGrillaBoleta";
            this.pnlContenedorGrillaBoleta.Size = new System.Drawing.Size(319, 452);
            this.pnlContenedorGrillaBoleta.TabIndex = 36;
            // 
            // grdBoleta
            // 
            this.grdBoleta.AllowUserToAddRows = false;
            this.grdBoleta.AllowUserToResizeRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            this.grdBoleta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.grdBoleta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdBoleta.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdBoleta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdBoleta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBoleta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.grdBoleta.ColumnHeadersHeight = 30;
            this.grdBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdBoleta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.CodProducto,
            this.Cantidad,
            this.total});
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBoleta.DefaultCellStyle = dataGridViewCellStyle31;
            this.grdBoleta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBoleta.EnableHeadersVisualStyles = false;
            this.grdBoleta.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdBoleta.Location = new System.Drawing.Point(0, 39);
            this.grdBoleta.MultiSelect = false;
            this.grdBoleta.Name = "grdBoleta";
            this.grdBoleta.ReadOnly = true;
            this.grdBoleta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdBoleta.RowHeadersVisible = false;
            this.grdBoleta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBoleta.Size = new System.Drawing.Size(319, 413);
            this.grdBoleta.TabIndex = 13;
            this.grdBoleta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBoleta_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 75;
            // 
            // CodProducto
            // 
            this.CodProducto.HeaderText = "Producto";
            this.CodProducto.Name = "CodProducto";
            this.CodProducto.ReadOnly = true;
            this.CodProducto.Width = 85;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 85;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 62;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblNumeroBoleta);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 39);
            this.panel2.TabIndex = 25;
            // 
            // lblNumeroBoleta
            // 
            this.lblNumeroBoleta.AutoSize = true;
            this.lblNumeroBoleta.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroBoleta.Location = new System.Drawing.Point(78, 2);
            this.lblNumeroBoleta.Name = "lblNumeroBoleta";
            this.lblNumeroBoleta.Size = new System.Drawing.Size(46, 30);
            this.lblNumeroBoleta.TabIndex = 30;
            this.lblNumeroBoleta.Text = "001";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Boleta";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label3.Location = new System.Drawing.Point(152, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "Total:";
            // 
            // txtTotalBoleta
            // 
            this.txtTotalBoleta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalBoleta.Enabled = false;
            this.txtTotalBoleta.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtTotalBoleta.Location = new System.Drawing.Point(220, 473);
            this.txtTotalBoleta.Name = "txtTotalBoleta";
            this.txtTotalBoleta.Size = new System.Drawing.Size(121, 35);
            this.txtTotalBoleta.TabIndex = 7;
            this.txtTotalBoleta.Text = "0";
            this.txtTotalBoleta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRealizarBoleta
            // 
            this.btnRealizarBoleta.Controls.Add(this.label8);
            this.btnRealizarBoleta.Controls.Add(this.cmbMedioPago);
            this.btnRealizarBoleta.Location = new System.Drawing.Point(358, 47);
            this.btnRealizarBoleta.Name = "btnRealizarBoleta";
            this.btnRealizarBoleta.Size = new System.Drawing.Size(180, 128);
            this.btnRealizarBoleta.TabIndex = 33;
            this.btnRealizarBoleta.TabStop = false;
            this.btnRealizarBoleta.Text = "Medio Pago";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Seleccione:";
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(30, 47);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(121, 21);
            this.cmbMedioPago.TabIndex = 8;
            this.cmbMedioPago.SelectedValueChanged += new System.EventHandler(this.cmbMedioPago_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtRunCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(358, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 150);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(30, 40);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 9;
            this.cmbCliente.SelectedValueChanged += new System.EventHandler(this.cmbCliente_SelectedValueChanged);
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
            // txtRunCliente
            // 
            this.txtRunCliente.Enabled = false;
            this.txtRunCliente.Location = new System.Drawing.Point(30, 79);
            this.txtRunCliente.Name = "txtRunCliente";
            this.txtRunCliente.Size = new System.Drawing.Size(121, 20);
            this.txtRunCliente.TabIndex = 10;
            this.txtRunCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Run:";
            // 
            // pnlProducto
            // 
            this.pnlProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProducto.Controls.Add(this.btnBuscarProducto);
            this.pnlProducto.Controls.Add(this.pnlContenedorGrilla);
            this.pnlProducto.Controls.Add(this.btnAgregarProducto);
            this.pnlProducto.Controls.Add(this.txtCantidad);
            this.pnlProducto.Controls.Add(this.label2);
            this.pnlProducto.Controls.Add(this.label1);
            this.pnlProducto.Controls.Add(this.cmbCategoria);
            this.pnlProducto.Controls.Add(this.txtBuscarProducto);
            this.pnlProducto.Location = new System.Drawing.Point(0, 0);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(450, 550);
            this.pnlProducto.TabIndex = 17;
            // 
            // pnlContenedorGrilla
            // 
            this.pnlContenedorGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedorGrilla.Controls.Add(this.grdProducto);
            this.pnlContenedorGrilla.Controls.Add(this.pnlTituloGrilla);
            this.pnlContenedorGrilla.Location = new System.Drawing.Point(12, 64);
            this.pnlContenedorGrilla.Name = "pnlContenedorGrilla";
            this.pnlContenedorGrilla.Size = new System.Drawing.Size(425, 400);
            this.pnlContenedorGrilla.TabIndex = 35;
            // 
            // grdProducto
            // 
            this.grdProducto.AllowUserToResizeRows = false;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            this.grdProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle32;
            this.grdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.grdProducto.Size = new System.Drawing.Size(425, 361);
            this.grdProducto.TabIndex = 14;
            this.grdProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProducto_CellClick);
            // 
            // pnlTituloGrilla
            // 
            this.pnlTituloGrilla.BackColor = System.Drawing.Color.Silver;
            this.pnlTituloGrilla.Controls.Add(this.nombreGrilla);
            this.pnlTituloGrilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloGrilla.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloGrilla.Name = "pnlTituloGrilla";
            this.pnlTituloGrilla.Size = new System.Drawing.Size(425, 39);
            this.pnlTituloGrilla.TabIndex = 25;
            // 
            // nombreGrilla
            // 
            this.nombreGrilla.AutoSize = true;
            this.nombreGrilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreGrilla.Location = new System.Drawing.Point(15, 10);
            this.nombreGrilla.Name = "nombreGrilla";
            this.nombreGrilla.Size = new System.Drawing.Size(90, 20);
            this.nombreGrilla.TabIndex = 0;
            this.nombreGrilla.Text = "Productos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(236, 473);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ingrese Producto:";
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
            this.txtBuscarProducto.Location = new System.Drawing.Point(236, 29);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(121, 20);
            this.txtBuscarProducto.TabIndex = 2;
            this.txtBuscarProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarProducto_KeyPress);
            // 
            // btnAgregarBoleta
            // 
            this.btnAgregarBoleta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarBoleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnAgregarBoleta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAgregarBoleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarBoleta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarBoleta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarBoleta.Location = new System.Drawing.Point(388, 366);
            this.btnAgregarBoleta.Name = "btnAgregarBoleta";
            this.btnAgregarBoleta.Size = new System.Drawing.Size(121, 33);
            this.btnAgregarBoleta.TabIndex = 45;
            this.btnAgregarBoleta.Text = "REALIZAR BOLETA";
            this.btnAgregarBoleta.UseVisualStyleBackColor = false;
            this.btnAgregarBoleta.Click += new System.EventHandler(this.btnAgregarBoleta_Click);
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnQuitarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnQuitarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnQuitarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarProducto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProducto.ForeColor = System.Drawing.Color.White;
            this.btnQuitarProducto.Location = new System.Drawing.Point(22, 470);
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
            this.btnAgregarProducto.Location = new System.Drawing.Point(333, 470);
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
            this.btnBuscarProducto.Location = new System.Drawing.Point(362, 27);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProducto.TabIndex = 47;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // frmPuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pnlProducto);
            this.Controls.Add(this.pnlVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPuntoVenta";
            this.Text = "frmRealizarVenta";
            this.pnlVenta.ResumeLayout(false);
            this.pnlBoleta.ResumeLayout(false);
            this.pnlBoleta.PerformLayout();
            this.pnlContenedorGrillaBoleta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBoleta)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.btnRealizarBoleta.ResumeLayout(false);
            this.btnRealizarBoleta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            this.pnlContenedorGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProducto)).EndInit();
            this.pnlTituloGrilla.ResumeLayout(false);
            this.pnlTituloGrilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlVenta;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Panel pnlBoleta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalBoleta;
        private System.Windows.Forms.GroupBox btnRealizarBoleta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMedioPago;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRunCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlContenedorGrilla;
        protected System.Windows.Forms.DataGridView grdProducto;
        private System.Windows.Forms.Panel pnlTituloGrilla;
        private System.Windows.Forms.Label nombreGrilla;
        private System.Windows.Forms.Panel pnlContenedorGrillaBoleta;
        private System.Windows.Forms.DataGridView grdBoleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumeroBoleta;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnAgregarBoleta;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
    }
}