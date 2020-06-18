namespace Vista
{
    partial class frmRevisarPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAnularOrden = new System.Windows.Forms.Button();
            this.btnModificarOrden = new System.Windows.Forms.Button();
            this.btnDescargarOrden = new System.Windows.Forms.Button();
            this.grpRecepcion = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEstadoOrden = new System.Windows.Forms.ComboBox();
            this.btnRecepcionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.btnBuscarOrden = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarOrden = new System.Windows.Forms.TextBox();
            this.pnlContenedorGrilla = new System.Windows.Forms.Panel();
            this.grdOrden = new System.Windows.Forms.DataGridView();
            this.pnlTituloGrilla = new System.Windows.Forms.Panel();
            this.nombreGrilla = new System.Windows.Forms.Label();
            this.pnlContenedorGrillaDetalle = new System.Windows.Forms.Panel();
            this.grdDetalleOrden = new System.Windows.Forms.DataGridView();
            this.pnlTituloDetallle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpRecepcion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlContenedorGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrden)).BeginInit();
            this.pnlTituloGrilla.SuspendLayout();
            this.pnlContenedorGrillaDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleOrden)).BeginInit();
            this.pnlTituloDetallle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnularOrden
            // 
            this.btnAnularOrden.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAnularOrden.Location = new System.Drawing.Point(816, 506);
            this.btnAnularOrden.Name = "btnAnularOrden";
            this.btnAnularOrden.Size = new System.Drawing.Size(128, 21);
            this.btnAnularOrden.TabIndex = 35;
            this.btnAnularOrden.Text = "Anular";
            this.btnAnularOrden.UseVisualStyleBackColor = true;
            this.btnAnularOrden.Click += new System.EventHandler(this.btnAnularOrden_Click);
            // 
            // btnModificarOrden
            // 
            this.btnModificarOrden.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModificarOrden.Location = new System.Drawing.Point(816, 467);
            this.btnModificarOrden.Name = "btnModificarOrden";
            this.btnModificarOrden.Size = new System.Drawing.Size(128, 21);
            this.btnModificarOrden.TabIndex = 34;
            this.btnModificarOrden.Text = "Modificar";
            this.btnModificarOrden.UseVisualStyleBackColor = true;
            this.btnModificarOrden.Click += new System.EventHandler(this.btnModificarOrden_Click);
            // 
            // btnDescargarOrden
            // 
            this.btnDescargarOrden.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDescargarOrden.Location = new System.Drawing.Point(816, 426);
            this.btnDescargarOrden.Name = "btnDescargarOrden";
            this.btnDescargarOrden.Size = new System.Drawing.Size(128, 21);
            this.btnDescargarOrden.TabIndex = 42;
            this.btnDescargarOrden.Text = "Descargar";
            this.btnDescargarOrden.UseVisualStyleBackColor = true;
            this.btnDescargarOrden.Click += new System.EventHandler(this.btnDescargarOrden_Click);
            // 
            // grpRecepcion
            // 
            this.grpRecepcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grpRecepcion.Controls.Add(this.label9);
            this.grpRecepcion.Controls.Add(this.cmbEstadoOrden);
            this.grpRecepcion.Controls.Add(this.btnRecepcionar);
            this.grpRecepcion.Location = new System.Drawing.Point(776, 12);
            this.grpRecepcion.Name = "grpRecepcion";
            this.grpRecepcion.Size = new System.Drawing.Size(212, 135);
            this.grpRecepcion.TabIndex = 38;
            this.grpRecepcion.TabStop = false;
            this.grpRecepcion.Text = "Recepción:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "¿Orden de Pedido Completa?";
            // 
            // cmbEstadoOrden
            // 
            this.cmbEstadoOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoOrden.FormattingEnabled = true;
            this.cmbEstadoOrden.Location = new System.Drawing.Point(13, 52);
            this.cmbEstadoOrden.Name = "cmbEstadoOrden";
            this.cmbEstadoOrden.Size = new System.Drawing.Size(181, 21);
            this.cmbEstadoOrden.TabIndex = 3;
            // 
            // btnRecepcionar
            // 
            this.btnRecepcionar.Location = new System.Drawing.Point(40, 100);
            this.btnRecepcionar.Name = "btnRecepcionar";
            this.btnRecepcionar.Size = new System.Drawing.Size(128, 21);
            this.btnRecepcionar.TabIndex = 2;
            this.btnRecepcionar.Text = "Confirmar";
            this.btnRecepcionar.UseVisualStyleBackColor = true;
            this.btnRecepcionar.Click += new System.EventHandler(this.btnRecepcionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProveedores);
            this.groupBox1.Controls.Add(this.btnBuscarOrden);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBuscarOrden);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 73);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Orden de pedido:";
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(68, 28);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(181, 21);
            this.cmbProveedores.TabIndex = 48;
            this.cmbProveedores.SelectedValueChanged += new System.EventHandler(this.cmbProveedores_SelectedValueChanged);
            // 
            // btnBuscarOrden
            // 
            this.btnBuscarOrden.Location = new System.Drawing.Point(540, 28);
            this.btnBuscarOrden.Name = "btnBuscarOrden";
            this.btnBuscarOrden.Size = new System.Drawing.Size(128, 21);
            this.btnBuscarOrden.TabIndex = 2;
            this.btnBuscarOrden.Text = "Buscar";
            this.btnBuscarOrden.UseVisualStyleBackColor = true;
            this.btnBuscarOrden.Click += new System.EventHandler(this.btnBuscarOrden_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Proveedor:";
            // 
            // txtBuscarOrden
            // 
            this.txtBuscarOrden.Location = new System.Drawing.Point(341, 29);
            this.txtBuscarOrden.Name = "txtBuscarOrden";
            this.txtBuscarOrden.Size = new System.Drawing.Size(182, 20);
            this.txtBuscarOrden.TabIndex = 1;
            // 
            // pnlContenedorGrilla
            // 
            this.pnlContenedorGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedorGrilla.Controls.Add(this.grdOrden);
            this.pnlContenedorGrilla.Controls.Add(this.pnlTituloGrilla);
            this.pnlContenedorGrilla.Location = new System.Drawing.Point(12, 91);
            this.pnlContenedorGrilla.Name = "pnlContenedorGrilla";
            this.pnlContenedorGrilla.Size = new System.Drawing.Size(446, 436);
            this.pnlContenedorGrilla.TabIndex = 44;
            // 
            // grdOrden
            // 
            this.grdOrden.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.grdOrden.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.grdOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdOrden.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdOrden.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdOrden.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOrden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.grdOrden.ColumnHeadersHeight = 30;
            this.grdOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOrden.EnableHeadersVisualStyles = false;
            this.grdOrden.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdOrden.Location = new System.Drawing.Point(0, 39);
            this.grdOrden.MultiSelect = false;
            this.grdOrden.Name = "grdOrden";
            this.grdOrden.ReadOnly = true;
            this.grdOrden.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOrden.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.grdOrden.RowHeadersVisible = false;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.grdOrden.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.grdOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOrden.Size = new System.Drawing.Size(446, 397);
            this.grdOrden.TabIndex = 28;
            this.grdOrden.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrden_CellClick);
            // 
            // pnlTituloGrilla
            // 
            this.pnlTituloGrilla.BackColor = System.Drawing.Color.Silver;
            this.pnlTituloGrilla.Controls.Add(this.nombreGrilla);
            this.pnlTituloGrilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloGrilla.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloGrilla.Name = "pnlTituloGrilla";
            this.pnlTituloGrilla.Size = new System.Drawing.Size(446, 39);
            this.pnlTituloGrilla.TabIndex = 25;
            // 
            // nombreGrilla
            // 
            this.nombreGrilla.AutoSize = true;
            this.nombreGrilla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreGrilla.Location = new System.Drawing.Point(15, 10);
            this.nombreGrilla.Name = "nombreGrilla";
            this.nombreGrilla.Size = new System.Drawing.Size(158, 19);
            this.nombreGrilla.TabIndex = 0;
            this.nombreGrilla.Text = "Ordenes de Pedido";
            // 
            // pnlContenedorGrillaDetalle
            // 
            this.pnlContenedorGrillaDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedorGrillaDetalle.Controls.Add(this.grdDetalleOrden);
            this.pnlContenedorGrillaDetalle.Controls.Add(this.pnlTituloDetallle);
            this.pnlContenedorGrillaDetalle.Location = new System.Drawing.Point(477, 91);
            this.pnlContenedorGrillaDetalle.Name = "pnlContenedorGrillaDetalle";
            this.pnlContenedorGrillaDetalle.Size = new System.Drawing.Size(293, 436);
            this.pnlContenedorGrillaDetalle.TabIndex = 45;
            // 
            // grdDetalleOrden
            // 
            this.grdDetalleOrden.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.grdDetalleOrden.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.grdDetalleOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDetalleOrden.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdDetalleOrden.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdDetalleOrden.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalleOrden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.grdDetalleOrden.ColumnHeadersHeight = 30;
            this.grdDetalleOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdDetalleOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalleOrden.EnableHeadersVisualStyles = false;
            this.grdDetalleOrden.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdDetalleOrden.Location = new System.Drawing.Point(0, 39);
            this.grdDetalleOrden.MultiSelect = false;
            this.grdDetalleOrden.Name = "grdDetalleOrden";
            this.grdDetalleOrden.ReadOnly = true;
            this.grdDetalleOrden.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalleOrden.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.grdDetalleOrden.RowHeadersVisible = false;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.grdDetalleOrden.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.grdDetalleOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalleOrden.Size = new System.Drawing.Size(293, 397);
            this.grdDetalleOrden.TabIndex = 28;
            // 
            // pnlTituloDetallle
            // 
            this.pnlTituloDetallle.BackColor = System.Drawing.Color.Silver;
            this.pnlTituloDetallle.Controls.Add(this.label1);
            this.pnlTituloDetallle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloDetallle.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloDetallle.Name = "pnlTituloDetallle";
            this.pnlTituloDetallle.Size = new System.Drawing.Size(293, 39);
            this.pnlTituloDetallle.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle de orden de pedido";
            // 
            // frmRevisarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pnlContenedorGrillaDetalle);
            this.Controls.Add(this.pnlContenedorGrilla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpRecepcion);
            this.Controls.Add(this.btnDescargarOrden);
            this.Controls.Add(this.btnAnularOrden);
            this.Controls.Add(this.btnModificarOrden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRevisarPedido";
            this.Text = "frmPedido";
            this.grpRecepcion.ResumeLayout(false);
            this.grpRecepcion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlContenedorGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrden)).EndInit();
            this.pnlTituloGrilla.ResumeLayout(false);
            this.pnlTituloGrilla.PerformLayout();
            this.pnlContenedorGrillaDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleOrden)).EndInit();
            this.pnlTituloDetallle.ResumeLayout(false);
            this.pnlTituloDetallle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAnularOrden;
        private System.Windows.Forms.Button btnModificarOrden;
        private System.Windows.Forms.Button btnDescargarOrden;
        private System.Windows.Forms.GroupBox grpRecepcion;
        private System.Windows.Forms.ComboBox cmbEstadoOrden;
        private System.Windows.Forms.Button btnRecepcionar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.Button btnBuscarOrden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarOrden;
        private System.Windows.Forms.Panel pnlContenedorGrilla;
        private System.Windows.Forms.Panel pnlTituloGrilla;
        private System.Windows.Forms.Label nombreGrilla;
        protected System.Windows.Forms.DataGridView grdOrden;
        private System.Windows.Forms.Panel pnlContenedorGrillaDetalle;
        protected System.Windows.Forms.DataGridView grdDetalleOrden;
        private System.Windows.Forms.Panel pnlTituloDetallle;
        private System.Windows.Forms.Label label1;
    }
}