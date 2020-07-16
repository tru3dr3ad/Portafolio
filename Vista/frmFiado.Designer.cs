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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiado));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDeudaTotal = new System.Windows.Forms.Label();
            this.rdbDeudaTotal = new System.Windows.Forms.RadioButton();
            this.rdbDeudaParcial = new System.Windows.Forms.RadioButton();
            this.txtMontoAbono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.txtRunCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlContenedorGrillaBoletas = new System.Windows.Forms.Panel();
            this.grdVentaFiadas = new System.Windows.Forms.DataGridView();
            this.pnlTituloGrillaBoleta = new System.Windows.Forms.Panel();
            this.nombreGrilla = new System.Windows.Forms.Label();
            this.pnlContenedorGrillaAbono = new System.Windows.Forms.Panel();
            this.grdAbono = new System.Windows.Forms.DataGridView();
            this.pnlTituloGrilla = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnAgregarAbono = new System.Windows.Forms.Button();
            this.btnModificarAbono = new System.Windows.Forms.Button();
            this.btnEliminarAbono = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlContenedorGrillaBoletas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVentaFiadas)).BeginInit();
            this.pnlTituloGrillaBoleta.SuspendLayout();
            this.pnlContenedorGrillaAbono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAbono)).BeginInit();
            this.pnlTituloGrilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.txtBuscarUsuario);
            this.groupBox2.Location = new System.Drawing.Point(770, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 85);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Cliente:";
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(13, 19);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(182, 20);
            this.txtBuscarUsuario.TabIndex = 1;
            this.txtBuscarUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarUsuario_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.rdbDeudaTotal);
            this.groupBox1.Controls.Add(this.rdbDeudaParcial);
            this.groupBox1.Controls.Add(this.txtMontoAbono);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.txtDeuda);
            this.groupBox1.Controls.Add(this.txtRunCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(772, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 309);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Abono:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblDeudaTotal);
            this.panel1.Location = new System.Drawing.Point(14, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 59);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Deuda Total:";
            // 
            // lblDeudaTotal
            // 
            this.lblDeudaTotal.AutoSize = true;
            this.lblDeudaTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeudaTotal.Location = new System.Drawing.Point(74, 24);
            this.lblDeudaTotal.Name = "lblDeudaTotal";
            this.lblDeudaTotal.Size = new System.Drawing.Size(22, 25);
            this.lblDeudaTotal.TabIndex = 13;
            this.lblDeudaTotal.Text = "0";
            // 
            // rdbDeudaTotal
            // 
            this.rdbDeudaTotal.AutoSize = true;
            this.rdbDeudaTotal.Location = new System.Drawing.Point(38, 156);
            this.rdbDeudaTotal.Name = "rdbDeudaTotal";
            this.rdbDeudaTotal.Size = new System.Drawing.Size(49, 17);
            this.rdbDeudaTotal.TabIndex = 6;
            this.rdbDeudaTotal.Text = "Total";
            this.rdbDeudaTotal.UseVisualStyleBackColor = true;
            this.rdbDeudaTotal.CheckedChanged += new System.EventHandler(this.rdbDeudaTotal_CheckedChanged);
            // 
            // rdbDeudaParcial
            // 
            this.rdbDeudaParcial.AutoSize = true;
            this.rdbDeudaParcial.Location = new System.Drawing.Point(109, 156);
            this.rdbDeudaParcial.Name = "rdbDeudaParcial";
            this.rdbDeudaParcial.Size = new System.Drawing.Size(57, 17);
            this.rdbDeudaParcial.TabIndex = 7;
            this.rdbDeudaParcial.Text = "Parcial";
            this.rdbDeudaParcial.UseVisualStyleBackColor = true;
            this.rdbDeudaParcial.CheckedChanged += new System.EventHandler(this.rdbDeudaParcial_CheckedChanged);
            // 
            // txtMontoAbono
            // 
            this.txtMontoAbono.Location = new System.Drawing.Point(12, 208);
            this.txtMontoAbono.Name = "txtMontoAbono";
            this.txtMontoAbono.Size = new System.Drawing.Size(182, 20);
            this.txtMontoAbono.TabIndex = 8;
            this.txtMontoAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMontoAbono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoAbono_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Monto Abono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Deuda:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(11, 31);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(182, 21);
            this.cmbCliente.TabIndex = 3;
            this.cmbCliente.SelectedValueChanged += new System.EventHandler(this.cmbCliente_SelectedValueChanged);
            // 
            // txtDeuda
            // 
            this.txtDeuda.Enabled = false;
            this.txtDeuda.Location = new System.Drawing.Point(12, 123);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(182, 20);
            this.txtDeuda.TabIndex = 5;
            this.txtDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDeuda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeuda_KeyPress);
            // 
            // txtRunCliente
            // 
            this.txtRunCliente.Enabled = false;
            this.txtRunCliente.Location = new System.Drawing.Point(11, 72);
            this.txtRunCliente.Name = "txtRunCliente";
            this.txtRunCliente.Size = new System.Drawing.Size(182, 20);
            this.txtRunCliente.TabIndex = 4;
            this.txtRunCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Run:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Cliente:";
            // 
            // pnlContenedorGrillaBoletas
            // 
            this.pnlContenedorGrillaBoletas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            this.grdVentaFiadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle33;
            this.grdVentaFiadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdVentaFiadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdVentaFiadas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdVentaFiadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdVentaFiadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVentaFiadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.grdVentaFiadas.ColumnHeadersHeight = 30;
            this.grdVentaFiadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdVentaFiadas.EnableHeadersVisualStyles = false;
            this.grdVentaFiadas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdVentaFiadas.Location = new System.Drawing.Point(0, 39);
            this.grdVentaFiadas.MultiSelect = false;
            this.grdVentaFiadas.Name = "grdVentaFiadas";
            this.grdVentaFiadas.ReadOnly = true;
            this.grdVentaFiadas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVentaFiadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.grdVentaFiadas.RowHeadersVisible = false;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.Black;
            this.grdVentaFiadas.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.grdVentaFiadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVentaFiadas.Size = new System.Drawing.Size(740, 227);
            this.grdVentaFiadas.TabIndex = 12;
            this.grdVentaFiadas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVentaFiadas_CellDoubleClick);
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
            this.nombreGrilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreGrilla.Location = new System.Drawing.Point(15, 10);
            this.nombreGrilla.Name = "nombreGrilla";
            this.nombreGrilla.Size = new System.Drawing.Size(125, 20);
            this.nombreGrilla.TabIndex = 0;
            this.nombreGrilla.Text = "Ventas Fiadas";
            // 
            // pnlContenedorGrillaAbono
            // 
            this.pnlContenedorGrillaAbono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.Black;
            this.grdAbono.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.grdAbono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAbono.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdAbono.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdAbono.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdAbono.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAbono.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.grdAbono.ColumnHeadersHeight = 30;
            this.grdAbono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdAbono.EnableHeadersVisualStyles = false;
            this.grdAbono.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdAbono.Location = new System.Drawing.Point(0, 39);
            this.grdAbono.MultiSelect = false;
            this.grdAbono.Name = "grdAbono";
            this.grdAbono.ReadOnly = true;
            this.grdAbono.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAbono.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.grdAbono.RowHeadersVisible = false;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.Black;
            this.grdAbono.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.grdAbono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAbono.Size = new System.Drawing.Size(740, 197);
            this.grdAbono.TabIndex = 13;
            this.grdAbono.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAbono_CellDoubleClick);
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Abonos";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.BackgroundImage")));
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAyuda.Location = new System.Drawing.Point(974, 7);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(21, 22);
            this.btnAyuda.TabIndex = 11;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnAgregarAbono
            // 
            this.btnAgregarAbono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarAbono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnAgregarAbono.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAgregarAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAbono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAbono.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAbono.Location = new System.Drawing.Point(810, 431);
            this.btnAgregarAbono.Name = "btnAgregarAbono";
            this.btnAgregarAbono.Size = new System.Drawing.Size(128, 29);
            this.btnAgregarAbono.TabIndex = 43;
            this.btnAgregarAbono.Text = "Agregar";
            this.btnAgregarAbono.UseVisualStyleBackColor = false;
            this.btnAgregarAbono.Click += new System.EventHandler(this.btnAgregarAbono_Click);
            // 
            // btnModificarAbono
            // 
            this.btnModificarAbono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModificarAbono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnModificarAbono.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnModificarAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAbono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAbono.ForeColor = System.Drawing.Color.White;
            this.btnModificarAbono.Location = new System.Drawing.Point(810, 466);
            this.btnModificarAbono.Name = "btnModificarAbono";
            this.btnModificarAbono.Size = new System.Drawing.Size(128, 29);
            this.btnModificarAbono.TabIndex = 42;
            this.btnModificarAbono.Text = "Modificar";
            this.btnModificarAbono.UseVisualStyleBackColor = false;
            this.btnModificarAbono.Click += new System.EventHandler(this.btnModificarAbono_Click);
            // 
            // btnEliminarAbono
            // 
            this.btnEliminarAbono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarAbono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnEliminarAbono.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnEliminarAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAbono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAbono.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAbono.Location = new System.Drawing.Point(810, 501);
            this.btnEliminarAbono.Name = "btnEliminarAbono";
            this.btnEliminarAbono.Size = new System.Drawing.Size(128, 29);
            this.btnEliminarAbono.TabIndex = 41;
            this.btnEliminarAbono.Text = "Eliminar";
            this.btnEliminarAbono.UseVisualStyleBackColor = false;
            this.btnEliminarAbono.Click += new System.EventHandler(this.btnEliminarAbono_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.Location = new System.Drawing.Point(40, 52);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(128, 21);
            this.btnBuscarCliente.TabIndex = 44;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // frmFiado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.btnAgregarAbono);
            this.Controls.Add(this.btnModificarAbono);
            this.Controls.Add(this.btnEliminarAbono);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.pnlContenedorGrillaAbono);
            this.Controls.Add(this.pnlContenedorGrillaBoletas);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFiado";
            this.Text = "frmFiado";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMontoAbono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRunCliente;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDeudaTotal;
        private System.Windows.Forms.Button btnAgregarAbono;
        private System.Windows.Forms.Button btnModificarAbono;
        private System.Windows.Forms.Button btnEliminarAbono;
        private System.Windows.Forms.Button btnBuscarCliente;
    }
}