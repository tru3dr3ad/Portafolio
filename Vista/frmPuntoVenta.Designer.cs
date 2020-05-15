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
            this.pnlVenta = new System.Windows.Forms.Panel();
            this.pnlBoleta = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMedioPago = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalBoleta = new System.Windows.Forms.TextBox();
            this.txtNumeroBoleta = new System.Windows.Forms.TextBox();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.grdBoleta = new System.Windows.Forms.DataGridView();
            this.pnlPago = new System.Windows.Forms.Panel();
            this.btnAgregarBoleta = new System.Windows.Forms.Button();
            this.btnRealizarBoleta = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarPago = new System.Windows.Forms.Button();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRunCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelarPago = new System.Windows.Forms.Button();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grdProducto = new System.Windows.Forms.DataGridView();
            this.pnlVenta.SuspendLayout();
            this.pnlBoleta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBoleta)).BeginInit();
            this.pnlPago.SuspendLayout();
            this.btnRealizarBoleta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVenta
            // 
            this.pnlVenta.Controls.Add(this.pnlBoleta);
            this.pnlVenta.Controls.Add(this.pnlPago);
            this.pnlVenta.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlVenta.Location = new System.Drawing.Point(450, 0);
            this.pnlVenta.Name = "pnlVenta";
            this.pnlVenta.Size = new System.Drawing.Size(550, 550);
            this.pnlVenta.TabIndex = 16;
            // 
            // pnlBoleta
            // 
            this.pnlBoleta.Controls.Add(this.label4);
            this.pnlBoleta.Controls.Add(this.btnMedioPago);
            this.pnlBoleta.Controls.Add(this.label3);
            this.pnlBoleta.Controls.Add(this.txtTotalBoleta);
            this.pnlBoleta.Controls.Add(this.txtNumeroBoleta);
            this.pnlBoleta.Controls.Add(this.btnQuitarProducto);
            this.pnlBoleta.Controls.Add(this.grdBoleta);
            this.pnlBoleta.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBoleta.Location = new System.Drawing.Point(0, 0);
            this.pnlBoleta.Name = "pnlBoleta";
            this.pnlBoleta.Size = new System.Drawing.Size(350, 550);
            this.pnlBoleta.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nro Boleta:";
            // 
            // btnMedioPago
            // 
            this.btnMedioPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMedioPago.Location = new System.Drawing.Point(215, 499);
            this.btnMedioPago.Name = "btnMedioPago";
            this.btnMedioPago.Size = new System.Drawing.Size(121, 33);
            this.btnMedioPago.TabIndex = 16;
            this.btnMedioPago.Text = "MEDIO PAGO";
            this.btnMedioPago.UseVisualStyleBackColor = true;
            this.btnMedioPago.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total:";
            // 
            // txtTotalBoleta
            // 
            this.txtTotalBoleta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalBoleta.Location = new System.Drawing.Point(215, 473);
            this.txtTotalBoleta.Name = "txtTotalBoleta";
            this.txtTotalBoleta.Size = new System.Drawing.Size(121, 20);
            this.txtTotalBoleta.TabIndex = 14;
            // 
            // txtNumeroBoleta
            // 
            this.txtNumeroBoleta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtNumeroBoleta.Location = new System.Drawing.Point(121, 27);
            this.txtNumeroBoleta.Name = "txtNumeroBoleta";
            this.txtNumeroBoleta.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroBoleta.TabIndex = 16;
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarProducto.Location = new System.Drawing.Point(24, 470);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarProducto.TabIndex = 15;
            this.btnQuitarProducto.Text = "Quitar";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            // 
            // grdBoleta
            // 
            this.grdBoleta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBoleta.Location = new System.Drawing.Point(16, 64);
            this.grdBoleta.Name = "grdBoleta";
            this.grdBoleta.ReadOnly = true;
            this.grdBoleta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBoleta.Size = new System.Drawing.Size(320, 400);
            this.grdBoleta.TabIndex = 12;
            // 
            // pnlPago
            // 
            this.pnlPago.Controls.Add(this.btnAgregarBoleta);
            this.pnlPago.Controls.Add(this.btnRealizarBoleta);
            this.pnlPago.Controls.Add(this.groupBox1);
            this.pnlPago.Controls.Add(this.btnCancelarPago);
            this.pnlPago.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPago.Location = new System.Drawing.Point(350, 0);
            this.pnlPago.Name = "pnlPago";
            this.pnlPago.Size = new System.Drawing.Size(200, 550);
            this.pnlPago.TabIndex = 18;
            // 
            // btnAgregarBoleta
            // 
            this.btnAgregarBoleta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarBoleta.Location = new System.Drawing.Point(38, 370);
            this.btnAgregarBoleta.Name = "btnAgregarBoleta";
            this.btnAgregarBoleta.Size = new System.Drawing.Size(121, 33);
            this.btnAgregarBoleta.TabIndex = 25;
            this.btnAgregarBoleta.Text = "REALIZAR BOLETA";
            this.btnAgregarBoleta.UseVisualStyleBackColor = true;
            this.btnAgregarBoleta.Click += new System.EventHandler(this.btnAgregarBoleta_Click);
            // 
            // btnRealizarBoleta
            // 
            this.btnRealizarBoleta.Controls.Add(this.label8);
            this.btnRealizarBoleta.Controls.Add(this.btnAgregarPago);
            this.btnRealizarBoleta.Controls.Add(this.cmbMedioPago);
            this.btnRealizarBoleta.Location = new System.Drawing.Point(8, 23);
            this.btnRealizarBoleta.Name = "btnRealizarBoleta";
            this.btnRealizarBoleta.Size = new System.Drawing.Size(180, 128);
            this.btnRealizarBoleta.TabIndex = 24;
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
            // btnAgregarPago
            // 
            this.btnAgregarPago.Location = new System.Drawing.Point(52, 74);
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPago.TabIndex = 16;
            this.btnAgregarPago.Text = "Agregar";
            this.btnAgregarPago.UseVisualStyleBackColor = true;
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(30, 47);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(121, 21);
            this.cmbMedioPago.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.btnSeleccionarCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtRunCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(8, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 150);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(30, 40);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 16;
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(52, 105);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarCliente.TabIndex = 22;
            this.btnSeleccionarCliente.Text = "Seleccionar";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
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
            this.txtRunCliente.Location = new System.Drawing.Point(30, 79);
            this.txtRunCliente.Name = "txtRunCliente";
            this.txtRunCliente.Size = new System.Drawing.Size(121, 20);
            this.txtRunCliente.TabIndex = 18;
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
            // btnCancelarPago
            // 
            this.btnCancelarPago.Location = new System.Drawing.Point(60, 509);
            this.btnCancelarPago.Name = "btnCancelarPago";
            this.btnCancelarPago.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarPago.TabIndex = 21;
            this.btnCancelarPago.Text = "Cancelar";
            this.btnCancelarPago.UseVisualStyleBackColor = true;
            this.btnCancelarPago.Click += new System.EventHandler(this.btnCancelarPago_Click);
            // 
            // pnlProducto
            // 
            this.pnlProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProducto.Controls.Add(this.btnAgregarProducto);
            this.pnlProducto.Controls.Add(this.numericUpDown1);
            this.pnlProducto.Controls.Add(this.label2);
            this.pnlProducto.Controls.Add(this.label1);
            this.pnlProducto.Controls.Add(this.cmbCategoria);
            this.pnlProducto.Controls.Add(this.txtBuscarProducto);
            this.pnlProducto.Controls.Add(this.button1);
            this.pnlProducto.Controls.Add(this.grdProducto);
            this.pnlProducto.Location = new System.Drawing.Point(0, 0);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(450, 550);
            this.pnlProducto.TabIndex = 17;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(333, 470);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(104, 23);
            this.btnAgregarProducto.TabIndex = 15;
            this.btnAgregarProducto.Text = "Agregar Productos";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(203, 473);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 14;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grdProducto
            // 
            this.grdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducto.Location = new System.Drawing.Point(12, 64);
            this.grdProducto.Name = "grdProducto";
            this.grdProducto.ReadOnly = true;
            this.grdProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProducto.Size = new System.Drawing.Size(422, 403);
            this.grdProducto.TabIndex = 8;
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
            ((System.ComponentModel.ISupportInitialize)(this.grdBoleta)).EndInit();
            this.pnlPago.ResumeLayout(false);
            this.btnRealizarBoleta.ResumeLayout(false);
            this.btnRealizarBoleta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlVenta;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdProducto;
        private System.Windows.Forms.Panel pnlPago;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.Button btnCancelarPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRunCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumeroBoleta;
        private System.Windows.Forms.Button btnAgregarPago;
        private System.Windows.Forms.ComboBox cmbMedioPago;
        private System.Windows.Forms.Panel pnlBoleta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMedioPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalBoleta;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.DataGridView grdBoleta;
        private System.Windows.Forms.GroupBox btnRealizarBoleta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button btnAgregarBoleta;
    }
}