namespace Vista
{
    partial class frmFiado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEliminarAbono = new System.Windows.Forms.Button();
            this.btnAgregarAbono = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.rdbDeudaParcial = new System.Windows.Forms.RadioButton();
            this.rdbDeudaTotal = new System.Windows.Forms.RadioButton();
            this.txtMontoAbono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRunCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarAbono = new System.Windows.Forms.Button();
            this.pnlContenedorGrillaBoletas = new System.Windows.Forms.Panel();
            this.grdVentaFiadas = new System.Windows.Forms.DataGridView();
            this.pnlTituloGrillaBoleta = new System.Windows.Forms.Panel();
            this.nombreGrilla = new System.Windows.Forms.Label();
            this.pnlContenedorGrillaAbono = new System.Windows.Forms.Panel();
            this.grdAbono = new System.Windows.Forms.DataGridView();
            this.pnlTituloGrilla = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlContenedorGrillaBoletas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVentaFiadas)).BeginInit();
            this.pnlTituloGrillaBoleta.SuspendLayout();
            this.pnlContenedorGrillaAbono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAbono)).BeginInit();
            this.pnlTituloGrilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminarAbono
            // 
            this.btnEliminarAbono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarAbono.Location = new System.Drawing.Point(816, 496);
            this.btnEliminarAbono.Name = "btnEliminarAbono";
            this.btnEliminarAbono.Size = new System.Drawing.Size(128, 21);
            this.btnEliminarAbono.TabIndex = 34;
            this.btnEliminarAbono.Text = "Eliminar";
            this.btnEliminarAbono.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAbono
            // 
            this.btnAgregarAbono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarAbono.Location = new System.Drawing.Point(816, 420);
            this.btnAgregarAbono.Name = "btnAgregarAbono";
            this.btnAgregarAbono.Size = new System.Drawing.Size(128, 21);
            this.btnAgregarAbono.TabIndex = 32;
            this.btnAgregarAbono.Text = "Agregar";
            this.btnAgregarAbono.UseVisualStyleBackColor = true;
            this.btnAgregarAbono.Click += new System.EventHandler(this.btnAgregarAbono_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.btnBuscarUsuario);
            this.groupBox2.Controls.Add(this.txtBuscarUsuario);
            this.groupBox2.Location = new System.Drawing.Point(776, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 85);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Cliente:";
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(40, 55);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(128, 21);
            this.btnBuscarUsuario.TabIndex = 2;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(13, 19);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(182, 20);
            this.txtBuscarUsuario.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.rdbDeudaParcial);
            this.groupBox1.Controls.Add(this.rdbDeudaTotal);
            this.groupBox1.Controls.Add(this.txtMontoAbono);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDeuda);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRunCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(776, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 284);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Abono:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(13, 31);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(182, 21);
            this.cmbCliente.TabIndex = 17;
            this.cmbCliente.SelectedValueChanged += new System.EventHandler(this.cmbCliente_SelectedValueChanged);
            // 
            // rdbDeudaParcial
            // 
            this.rdbDeudaParcial.AutoSize = true;
            this.rdbDeudaParcial.Location = new System.Drawing.Point(110, 180);
            this.rdbDeudaParcial.Name = "rdbDeudaParcial";
            this.rdbDeudaParcial.Size = new System.Drawing.Size(57, 17);
            this.rdbDeudaParcial.TabIndex = 13;
            this.rdbDeudaParcial.Text = "Parcial";
            this.rdbDeudaParcial.UseVisualStyleBackColor = true;
            this.rdbDeudaParcial.CheckedChanged += new System.EventHandler(this.rdbDeudaParcial_CheckedChanged);
            // 
            // rdbDeudaTotal
            // 
            this.rdbDeudaTotal.AutoSize = true;
            this.rdbDeudaTotal.Location = new System.Drawing.Point(35, 180);
            this.rdbDeudaTotal.Name = "rdbDeudaTotal";
            this.rdbDeudaTotal.Size = new System.Drawing.Size(49, 17);
            this.rdbDeudaTotal.TabIndex = 12;
            this.rdbDeudaTotal.Text = "Total";
            this.rdbDeudaTotal.UseVisualStyleBackColor = true;
            this.rdbDeudaTotal.CheckedChanged += new System.EventHandler(this.rdbDeudaTotal_CheckedChanged);
            // 
            // txtMontoAbono
            // 
            this.txtMontoAbono.Location = new System.Drawing.Point(14, 239);
            this.txtMontoAbono.Name = "txtMontoAbono";
            this.txtMontoAbono.Size = new System.Drawing.Size(182, 20);
            this.txtMontoAbono.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Monto Abono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Deuda:";
            // 
            // txtDeuda
            // 
            this.txtDeuda.Enabled = false;
            this.txtDeuda.Location = new System.Drawing.Point(13, 135);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(182, 20);
            this.txtDeuda.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Cliente:";
            // 
            // txtRunCliente
            // 
            this.txtRunCliente.Enabled = false;
            this.txtRunCliente.Location = new System.Drawing.Point(13, 83);
            this.txtRunCliente.Name = "txtRunCliente";
            this.txtRunCliente.Size = new System.Drawing.Size(182, 20);
            this.txtRunCliente.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Run:";
            // 
            // btnModificarAbono
            // 
            this.btnModificarAbono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModificarAbono.Location = new System.Drawing.Point(816, 457);
            this.btnModificarAbono.Name = "btnModificarAbono";
            this.btnModificarAbono.Size = new System.Drawing.Size(128, 21);
            this.btnModificarAbono.TabIndex = 33;
            this.btnModificarAbono.Text = "Modificar";
            this.btnModificarAbono.UseVisualStyleBackColor = true;
            // 
            // pnlContenedorGrillaBoletas
            // 
            this.pnlContenedorGrillaBoletas.Controls.Add(this.grdVentaFiadas);
            this.pnlContenedorGrillaBoletas.Controls.Add(this.pnlTituloGrillaBoleta);
            this.pnlContenedorGrillaBoletas.Location = new System.Drawing.Point(12, 12);
            this.pnlContenedorGrillaBoletas.Name = "pnlContenedorGrillaBoletas";
            this.pnlContenedorGrillaBoletas.Size = new System.Drawing.Size(740, 266);
            this.pnlContenedorGrillaBoletas.TabIndex = 39;
            // 
            // grdVentaFiadas
            // 
            this.grdVentaFiadas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.grdVentaFiadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdVentaFiadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdVentaFiadas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdVentaFiadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdVentaFiadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVentaFiadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdVentaFiadas.ColumnHeadersHeight = 30;
            this.grdVentaFiadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdVentaFiadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVentaFiadas.EnableHeadersVisualStyles = false;
            this.grdVentaFiadas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdVentaFiadas.Location = new System.Drawing.Point(0, 39);
            this.grdVentaFiadas.MultiSelect = false;
            this.grdVentaFiadas.Name = "grdVentaFiadas";
            this.grdVentaFiadas.ReadOnly = true;
            this.grdVentaFiadas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVentaFiadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdVentaFiadas.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.grdVentaFiadas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdVentaFiadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVentaFiadas.Size = new System.Drawing.Size(740, 227);
            this.grdVentaFiadas.TabIndex = 27;
            this.grdVentaFiadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVentaFiadas_CellDoubleClick);
            // 
            // pnlTituloGrillaBoleta
            // 
            this.pnlTituloGrillaBoleta.BackColor = System.Drawing.Color.Silver;
            this.pnlTituloGrillaBoleta.Controls.Add(this.nombreGrilla);
            this.pnlTituloGrillaBoleta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloGrillaBoleta.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloGrillaBoleta.Name = "pnlTituloGrillaBoleta";
            this.pnlTituloGrillaBoleta.Size = new System.Drawing.Size(740, 39);
            this.pnlTituloGrillaBoleta.TabIndex = 25;
            // 
            // nombreGrilla
            // 
            this.nombreGrilla.AutoSize = true;
            this.nombreGrilla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreGrilla.Location = new System.Drawing.Point(15, 10);
            this.nombreGrilla.Name = "nombreGrilla";
            this.nombreGrilla.Size = new System.Drawing.Size(116, 19);
            this.nombreGrilla.TabIndex = 0;
            this.nombreGrilla.Text = "Ventas Fiadas";
            // 
            // pnlContenedorGrillaAbono
            // 
            this.pnlContenedorGrillaAbono.Controls.Add(this.grdAbono);
            this.pnlContenedorGrillaAbono.Controls.Add(this.pnlTituloGrilla);
            this.pnlContenedorGrillaAbono.Location = new System.Drawing.Point(12, 294);
            this.pnlContenedorGrillaAbono.Name = "pnlContenedorGrillaAbono";
            this.pnlContenedorGrillaAbono.Size = new System.Drawing.Size(740, 236);
            this.pnlContenedorGrillaAbono.TabIndex = 40;
            // 
            // grdAbono
            // 
            this.grdAbono.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.grdAbono.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdAbono.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdAbono.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdAbono.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdAbono.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAbono.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdAbono.ColumnHeadersHeight = 30;
            this.grdAbono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdAbono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAbono.EnableHeadersVisualStyles = false;
            this.grdAbono.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdAbono.Location = new System.Drawing.Point(0, 39);
            this.grdAbono.MultiSelect = false;
            this.grdAbono.Name = "grdAbono";
            this.grdAbono.ReadOnly = true;
            this.grdAbono.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAbono.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdAbono.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.grdAbono.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grdAbono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAbono.Size = new System.Drawing.Size(740, 197);
            this.grdAbono.TabIndex = 27;
            // 
            // pnlTituloGrilla
            // 
            this.pnlTituloGrilla.BackColor = System.Drawing.Color.Silver;
            this.pnlTituloGrilla.Controls.Add(this.label5);
            this.pnlTituloGrilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloGrilla.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloGrilla.Name = "pnlTituloGrilla";
            this.pnlTituloGrilla.Size = new System.Drawing.Size(740, 39);
            this.pnlTituloGrilla.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Abonos";
            // 
            // frmFiado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pnlContenedorGrillaAbono);
            this.Controls.Add(this.pnlContenedorGrillaBoletas);
            this.Controls.Add(this.btnEliminarAbono);
            this.Controls.Add(this.btnAgregarAbono);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnModificarAbono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFiado";
            this.Text = "frmFiado";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlContenedorGrillaBoletas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVentaFiadas)).EndInit();
            this.pnlTituloGrillaBoleta.ResumeLayout(false);
            this.pnlTituloGrillaBoleta.PerformLayout();
            this.pnlContenedorGrillaAbono.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAbono)).EndInit();
            this.pnlTituloGrilla.ResumeLayout(false);
            this.pnlTituloGrilla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarAbono;
        private System.Windows.Forms.Button btnAgregarAbono;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMontoAbono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRunCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificarAbono;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.RadioButton rdbDeudaParcial;
        private System.Windows.Forms.RadioButton rdbDeudaTotal;
        private System.Windows.Forms.Panel pnlContenedorGrillaBoletas;
        protected System.Windows.Forms.DataGridView grdVentaFiadas;
        private System.Windows.Forms.Panel pnlTituloGrillaBoleta;
        private System.Windows.Forms.Label nombreGrilla;
        private System.Windows.Forms.Panel pnlContenedorGrillaAbono;
        protected System.Windows.Forms.DataGridView grdAbono;
        private System.Windows.Forms.Panel pnlTituloGrilla;
        private System.Windows.Forms.Label label5;
    }
}