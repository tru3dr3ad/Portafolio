namespace Vista
{
    partial class frmRevisarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRevisarVenta));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVendedores = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarBoleta = new System.Windows.Forms.TextBox();
            this.pnlContenedorGrilla = new System.Windows.Forms.Panel();
            this.grdBoleta = new System.Windows.Forms.DataGridView();
            this.pnlTituloGrilla = new System.Windows.Forms.Panel();
            this.nombreGrilla = new System.Windows.Forms.Label();
            this.pnlContenedorGrillaDetalleBoleta = new System.Windows.Forms.Panel();
            this.grdDetalleBoleta = new System.Windows.Forms.DataGridView();
            this.pnlTituloGrillaDetalle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnAnularBoleta = new System.Windows.Forms.Button();
            this.btnBuscarBoleta = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.pnlContenedorGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBoleta)).BeginInit();
            this.pnlTituloGrilla.SuspendLayout();
            this.pnlContenedorGrillaDetalleBoleta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleBoleta)).BeginInit();
            this.pnlTituloGrillaDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnBuscarBoleta);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbMedioPago);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbVendedores);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBuscarBoleta);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(976, 86);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Boleta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ingrese N° Boleta:";
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(333, 38);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(181, 21);
            this.cmbMedioPago.TabIndex = 2;
            this.cmbMedioPago.SelectedValueChanged += new System.EventHandler(this.cmbMedioPago_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Medio Pago:";
            // 
            // cmbVendedores
            // 
            this.cmbVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedores.FormattingEnabled = true;
            this.cmbVendedores.Location = new System.Drawing.Point(65, 38);
            this.cmbVendedores.Name = "cmbVendedores";
            this.cmbVendedores.Size = new System.Drawing.Size(181, 21);
            this.cmbVendedores.TabIndex = 1;
            this.cmbVendedores.SelectedIndexChanged += new System.EventHandler(this.cmbVendedores_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Vendedor:";
            // 
            // txtBuscarBoleta
            // 
            this.txtBuscarBoleta.Location = new System.Drawing.Point(651, 39);
            this.txtBuscarBoleta.Name = "txtBuscarBoleta";
            this.txtBuscarBoleta.Size = new System.Drawing.Size(182, 20);
            this.txtBuscarBoleta.TabIndex = 3;
            this.txtBuscarBoleta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarBoleta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarBoleta_KeyPress);
            // 
            // pnlContenedorGrilla
            // 
            this.pnlContenedorGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedorGrilla.Controls.Add(this.grdBoleta);
            this.pnlContenedorGrilla.Controls.Add(this.pnlTituloGrilla);
            this.pnlContenedorGrilla.Location = new System.Drawing.Point(12, 104);
            this.pnlContenedorGrilla.Name = "pnlContenedorGrilla";
            this.pnlContenedorGrilla.Size = new System.Drawing.Size(474, 418);
            this.pnlContenedorGrilla.TabIndex = 45;
            // 
            // grdBoleta
            // 
            this.grdBoleta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.grdBoleta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBoleta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdBoleta.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdBoleta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdBoleta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBoleta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdBoleta.ColumnHeadersHeight = 30;
            this.grdBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdBoleta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBoleta.EnableHeadersVisualStyles = false;
            this.grdBoleta.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdBoleta.Location = new System.Drawing.Point(0, 39);
            this.grdBoleta.MultiSelect = false;
            this.grdBoleta.Name = "grdBoleta";
            this.grdBoleta.ReadOnly = true;
            this.grdBoleta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBoleta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdBoleta.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.grdBoleta.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdBoleta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBoleta.Size = new System.Drawing.Size(474, 379);
            this.grdBoleta.TabIndex = 6;
            this.grdBoleta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBoleta_CellClick);
            // 
            // pnlTituloGrilla
            // 
            this.pnlTituloGrilla.BackColor = System.Drawing.Color.Silver;
            this.pnlTituloGrilla.Controls.Add(this.nombreGrilla);
            this.pnlTituloGrilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloGrilla.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloGrilla.Name = "pnlTituloGrilla";
            this.pnlTituloGrilla.Size = new System.Drawing.Size(474, 39);
            this.pnlTituloGrilla.TabIndex = 25;
            // 
            // nombreGrilla
            // 
            this.nombreGrilla.AutoSize = true;
            this.nombreGrilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreGrilla.Location = new System.Drawing.Point(15, 10);
            this.nombreGrilla.Name = "nombreGrilla";
            this.nombreGrilla.Size = new System.Drawing.Size(70, 20);
            this.nombreGrilla.TabIndex = 0;
            this.nombreGrilla.Text = "Boletas";
            // 
            // pnlContenedorGrillaDetalleBoleta
            // 
            this.pnlContenedorGrillaDetalleBoleta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedorGrillaDetalleBoleta.Controls.Add(this.grdDetalleBoleta);
            this.pnlContenedorGrillaDetalleBoleta.Controls.Add(this.pnlTituloGrillaDetalle);
            this.pnlContenedorGrillaDetalleBoleta.Location = new System.Drawing.Point(492, 104);
            this.pnlContenedorGrillaDetalleBoleta.Name = "pnlContenedorGrillaDetalleBoleta";
            this.pnlContenedorGrillaDetalleBoleta.Size = new System.Drawing.Size(334, 418);
            this.pnlContenedorGrillaDetalleBoleta.TabIndex = 46;
            // 
            // grdDetalleBoleta
            // 
            this.grdDetalleBoleta.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.grdDetalleBoleta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdDetalleBoleta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDetalleBoleta.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdDetalleBoleta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdDetalleBoleta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalleBoleta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdDetalleBoleta.ColumnHeadersHeight = 30;
            this.grdDetalleBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdDetalleBoleta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalleBoleta.EnableHeadersVisualStyles = false;
            this.grdDetalleBoleta.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdDetalleBoleta.Location = new System.Drawing.Point(0, 39);
            this.grdDetalleBoleta.MultiSelect = false;
            this.grdDetalleBoleta.Name = "grdDetalleBoleta";
            this.grdDetalleBoleta.ReadOnly = true;
            this.grdDetalleBoleta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalleBoleta.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdDetalleBoleta.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.grdDetalleBoleta.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grdDetalleBoleta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalleBoleta.Size = new System.Drawing.Size(334, 379);
            this.grdDetalleBoleta.TabIndex = 7;
            // 
            // pnlTituloGrillaDetalle
            // 
            this.pnlTituloGrillaDetalle.BackColor = System.Drawing.Color.Silver;
            this.pnlTituloGrillaDetalle.Controls.Add(this.label2);
            this.pnlTituloGrillaDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloGrillaDetalle.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloGrillaDetalle.Name = "pnlTituloGrillaDetalle";
            this.pnlTituloGrillaDetalle.Size = new System.Drawing.Size(334, 39);
            this.pnlTituloGrillaDetalle.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Detalle de boleta";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.BackgroundImage")));
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAyuda.Location = new System.Drawing.Point(974, 4);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(21, 22);
            this.btnAyuda.TabIndex = 47;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnAnularBoleta
            // 
            this.btnAnularBoleta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAnularBoleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnAnularBoleta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAnularBoleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularBoleta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularBoleta.ForeColor = System.Drawing.Color.White;
            this.btnAnularBoleta.Location = new System.Drawing.Point(851, 493);
            this.btnAnularBoleta.Name = "btnAnularBoleta";
            this.btnAnularBoleta.Size = new System.Drawing.Size(128, 29);
            this.btnAnularBoleta.TabIndex = 48;
            this.btnAnularBoleta.Text = "Anular";
            this.btnAnularBoleta.UseVisualStyleBackColor = false;
            this.btnAnularBoleta.Click += new System.EventHandler(this.btnAnularBoleta_Click);
            // 
            // btnBuscarBoleta
            // 
            this.btnBuscarBoleta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarBoleta.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarBoleta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnBuscarBoleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarBoleta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarBoleta.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarBoleta.Location = new System.Drawing.Point(839, 38);
            this.btnBuscarBoleta.Name = "btnBuscarBoleta";
            this.btnBuscarBoleta.Size = new System.Drawing.Size(128, 21);
            this.btnBuscarBoleta.TabIndex = 49;
            this.btnBuscarBoleta.Text = "Buscar";
            this.btnBuscarBoleta.UseVisualStyleBackColor = false;
            this.btnBuscarBoleta.Click += new System.EventHandler(this.btnBuscarBoleta_Click);
            // 
            // frmRevisarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.btnAnularBoleta);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.pnlContenedorGrillaDetalleBoleta);
            this.Controls.Add(this.pnlContenedorGrilla);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRevisarVenta";
            this.Text = "frmVenta";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlContenedorGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBoleta)).EndInit();
            this.pnlTituloGrilla.ResumeLayout(false);
            this.pnlTituloGrilla.PerformLayout();
            this.pnlContenedorGrillaDetalleBoleta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleBoleta)).EndInit();
            this.pnlTituloGrillaDetalle.ResumeLayout(false);
            this.pnlTituloGrillaDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscarBoleta;
        private System.Windows.Forms.ComboBox cmbVendedores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMedioPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContenedorGrilla;
        private System.Windows.Forms.Panel pnlTituloGrilla;
        private System.Windows.Forms.Label nombreGrilla;
        protected System.Windows.Forms.DataGridView grdBoleta;
        private System.Windows.Forms.Panel pnlContenedorGrillaDetalleBoleta;
        protected System.Windows.Forms.DataGridView grdDetalleBoleta;
        private System.Windows.Forms.Panel pnlTituloGrillaDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnAnularBoleta;
        private System.Windows.Forms.Button btnBuscarBoleta;
    }
}