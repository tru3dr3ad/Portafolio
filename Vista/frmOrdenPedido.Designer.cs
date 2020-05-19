namespace Vista
{
    partial class frmOrdenPedido
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
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.grdProducto = new System.Windows.Forms.DataGridView();
            this.pnlBoleta = new System.Windows.Forms.Panel();
            this.btnDescargarOrden = new System.Windows.Forms.Button();
            this.grdOrden = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalOrden = new System.Windows.Forms.TextBox();
            this.txtNumeroOrden = new System.Windows.Forms.TextBox();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.btnAgregarOrden = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRutProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducto)).BeginInit();
            this.pnlBoleta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrden)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProducto
            // 
            this.pnlProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProducto.Controls.Add(this.btnAgregarProducto);
            this.pnlProducto.Controls.Add(this.txtCantidad);
            this.pnlProducto.Controls.Add(this.label2);
            this.pnlProducto.Controls.Add(this.label1);
            this.pnlProducto.Controls.Add(this.cmbCategoria);
            this.pnlProducto.Controls.Add(this.txtBuscarProducto);
            this.pnlProducto.Controls.Add(this.btnBuscarProducto);
            this.pnlProducto.Controls.Add(this.grdProducto);
            this.pnlProducto.Location = new System.Drawing.Point(0, 0);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(450, 550);
            this.pnlProducto.TabIndex = 18;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(333, 470);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(104, 23);
            this.btnAgregarProducto.TabIndex = 15;
            this.btnAgregarProducto.Text = "Agregar Productos";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(236, 473);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(87, 20);
            this.txtCantidad.TabIndex = 14;
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
            this.cmbCategoria.TabIndex = 11;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(236, 29);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(121, 20);
            this.txtBuscarProducto.TabIndex = 10;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(363, 27);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProducto.TabIndex = 9;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // grdProducto
            // 
            this.grdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducto.Location = new System.Drawing.Point(12, 64);
            this.grdProducto.Name = "grdProducto";
            this.grdProducto.ReadOnly = true;
            this.grdProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProducto.Size = new System.Drawing.Size(422, 403);
            this.grdProducto.TabIndex = 8;
            this.grdProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProducto_CellClick);
            // 
            // pnlBoleta
            // 
            this.pnlBoleta.Controls.Add(this.btnDescargarOrden);
            this.pnlBoleta.Controls.Add(this.grdOrden);
            this.pnlBoleta.Controls.Add(this.label4);
            this.pnlBoleta.Controls.Add(this.label3);
            this.pnlBoleta.Controls.Add(this.txtTotalOrden);
            this.pnlBoleta.Controls.Add(this.txtNumeroOrden);
            this.pnlBoleta.Controls.Add(this.btnQuitarProducto);
            this.pnlBoleta.Controls.Add(this.btnAgregarOrden);
            this.pnlBoleta.Controls.Add(this.groupBox1);
            this.pnlBoleta.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBoleta.Location = new System.Drawing.Point(450, 0);
            this.pnlBoleta.Name = "pnlBoleta";
            this.pnlBoleta.Size = new System.Drawing.Size(550, 550);
            this.pnlBoleta.TabIndex = 20;
            // 
            // btnDescargarOrden
            // 
            this.btnDescargarOrden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescargarOrden.Location = new System.Drawing.Point(388, 395);
            this.btnDescargarOrden.Name = "btnDescargarOrden";
            this.btnDescargarOrden.Size = new System.Drawing.Size(121, 54);
            this.btnDescargarOrden.TabIndex = 35;
            this.btnDescargarOrden.Text = "DESCARGAR ORDEN";
            this.btnDescargarOrden.UseVisualStyleBackColor = true;
            // 
            // grdOrden
            // 
            this.grdOrden.AllowUserToAddRows = false;
            this.grdOrden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.CodProducto,
            this.Cantidad,
            this.total});
            this.grdOrden.Location = new System.Drawing.Point(22, 64);
            this.grdOrden.Name = "grdOrden";
            this.grdOrden.ReadOnly = true;
            this.grdOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOrden.Size = new System.Drawing.Size(319, 403);
            this.grdOrden.TabIndex = 31;
            this.grdOrden.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrden_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // CodProducto
            // 
            this.CodProducto.HeaderText = "Producto";
            this.CodProducto.Name = "CodProducto";
            this.CodProducto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nro Orden:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Total:";
            // 
            // txtTotalOrden
            // 
            this.txtTotalOrden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalOrden.Enabled = false;
            this.txtTotalOrden.Location = new System.Drawing.Point(220, 470);
            this.txtTotalOrden.Name = "txtTotalOrden";
            this.txtTotalOrden.Size = new System.Drawing.Size(121, 20);
            this.txtTotalOrden.TabIndex = 27;
            this.txtTotalOrden.Text = "0";
            this.txtTotalOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumeroOrden
            // 
            this.txtNumeroOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroOrden.Enabled = false;
            this.txtNumeroOrden.Location = new System.Drawing.Point(130, 29);
            this.txtNumeroOrden.Name = "txtNumeroOrden";
            this.txtNumeroOrden.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroOrden.TabIndex = 29;
            this.txtNumeroOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarProducto.Location = new System.Drawing.Point(22, 470);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarProducto.TabIndex = 28;
            this.btnQuitarProducto.Text = "Quitar";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click);
            // 
            // btnAgregarOrden
            // 
            this.btnAgregarOrden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarOrden.Location = new System.Drawing.Point(388, 356);
            this.btnAgregarOrden.Name = "btnAgregarOrden";
            this.btnAgregarOrden.Size = new System.Drawing.Size(121, 33);
            this.btnAgregarOrden.TabIndex = 34;
            this.btnAgregarOrden.Text = "GUARDAR ORDEN";
            this.btnAgregarOrden.UseVisualStyleBackColor = true;
            this.btnAgregarOrden.Click += new System.EventHandler(this.btnAgregarOrden_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbProveedor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtRutProveedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(358, 64);
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
            this.cmbProveedor.TabIndex = 16;
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
            this.txtRutProveedor.Location = new System.Drawing.Point(30, 79);
            this.txtRutProveedor.Name = "txtRutProveedor";
            this.txtRutProveedor.Size = new System.Drawing.Size(121, 20);
            this.txtRutProveedor.TabIndex = 18;
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
            // frmOrdenPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pnlBoleta);
            this.Controls.Add(this.pnlProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrdenPedido";
            this.Text = "frmOrdenPedido";
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducto)).EndInit();
            this.pnlBoleta.ResumeLayout(false);
            this.pnlBoleta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrden)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.DataGridView grdProducto;
        private System.Windows.Forms.Panel pnlBoleta;
        private System.Windows.Forms.Button btnDescargarOrden;
        private System.Windows.Forms.DataGridView grdOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalOrden;
        private System.Windows.Forms.TextBox txtNumeroOrden;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnAgregarOrden;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRutProveedor;
        private System.Windows.Forms.Label label6;
    }
}