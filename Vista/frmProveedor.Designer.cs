namespace Vista
{
    partial class frmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRutProveedor = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscarProveedor = new System.Windows.Forms.TextBox();
            this.pnlContenedorGrilla = new System.Windows.Forms.Panel();
            this.grdProveedor = new System.Windows.Forms.DataGridView();
            this.pnlTituloGrilla = new System.Windows.Forms.Panel();
            this.nombreGrilla = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlContenedorGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProveedor)).BeginInit();
            this.pnlTituloGrilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDv);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbRubro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRutProveedor);
            this.groupBox1.Location = new System.Drawing.Point(776, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 295);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Proveedor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "-";
            // 
            // txtDv
            // 
            this.txtDv.Location = new System.Drawing.Point(175, 31);
            this.txtDv.MaxLength = 1;
            this.txtDv.Name = "txtDv";
            this.txtDv.Size = new System.Drawing.Size(20, 20);
            this.txtDv.TabIndex = 4;
            this.txtDv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rubro:";
            // 
            // cmbRubro
            // 
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(13, 246);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(182, 21);
            this.cmbRubro.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(13, 202);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(182, 20);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo Electronico:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(13, 158);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(182, 20);
            this.txtCorreo.TabIndex = 7;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(13, 114);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(182, 20);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(13, 70);
            this.txtNombre.MaxLength = 70;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rut:";
            // 
            // txtRutProveedor
            // 
            this.txtRutProveedor.Location = new System.Drawing.Point(13, 31);
            this.txtRutProveedor.MaxLength = 8;
            this.txtRutProveedor.Name = "txtRutProveedor";
            this.txtRutProveedor.Size = new System.Drawing.Size(139, 20);
            this.txtRutProveedor.TabIndex = 3;
            this.txtRutProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRutProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRutProveedor_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.btnBuscarProveedor);
            this.groupBox2.Controls.Add(this.txtBuscarProveedor);
            this.groupBox2.Location = new System.Drawing.Point(776, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 85);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Proveedor:";
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.Location = new System.Drawing.Point(13, 19);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(182, 20);
            this.txtBuscarProveedor.TabIndex = 1;
            this.txtBuscarProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarProveedor_KeyPress);
            // 
            // pnlContenedorGrilla
            // 
            this.pnlContenedorGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedorGrilla.Controls.Add(this.grdProveedor);
            this.pnlContenedorGrilla.Controls.Add(this.pnlTituloGrilla);
            this.pnlContenedorGrilla.Location = new System.Drawing.Point(12, 12);
            this.pnlContenedorGrilla.Name = "pnlContenedorGrilla";
            this.pnlContenedorGrilla.Size = new System.Drawing.Size(758, 526);
            this.pnlContenedorGrilla.TabIndex = 36;
            // 
            // grdProveedor
            // 
            this.grdProveedor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.grdProveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdProveedor.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdProveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdProveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdProveedor.ColumnHeadersHeight = 30;
            this.grdProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdProveedor.EnableHeadersVisualStyles = false;
            this.grdProveedor.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdProveedor.Location = new System.Drawing.Point(0, 39);
            this.grdProveedor.MultiSelect = false;
            this.grdProveedor.Name = "grdProveedor";
            this.grdProveedor.ReadOnly = true;
            this.grdProveedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdProveedor.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.grdProveedor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProveedor.Size = new System.Drawing.Size(758, 487);
            this.grdProveedor.TabIndex = 14;
            this.grdProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProveedor_CellDoubleClick);
            // 
            // pnlTituloGrilla
            // 
            this.pnlTituloGrilla.BackColor = System.Drawing.Color.Silver;
            this.pnlTituloGrilla.Controls.Add(this.nombreGrilla);
            this.pnlTituloGrilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloGrilla.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloGrilla.Name = "pnlTituloGrilla";
            this.pnlTituloGrilla.Size = new System.Drawing.Size(758, 39);
            this.pnlTituloGrilla.TabIndex = 25;
            // 
            // nombreGrilla
            // 
            this.nombreGrilla.AutoSize = true;
            this.nombreGrilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreGrilla.Location = new System.Drawing.Point(15, 10);
            this.nombreGrilla.Name = "nombreGrilla";
            this.nombreGrilla.Size = new System.Drawing.Size(109, 20);
            this.nombreGrilla.TabIndex = 0;
            this.nombreGrilla.Text = "Proveedores";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.BackgroundImage")));
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAyuda.Location = new System.Drawing.Point(976, 3);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(21, 22);
            this.btnAyuda.TabIndex = 13;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnAgregarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(816, 439);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(128, 29);
            this.btnAgregarProveedor.TabIndex = 46;
            this.btnAgregarProveedor.Text = "Agregar";
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModificarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnModificarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnModificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnModificarProveedor.Location = new System.Drawing.Point(816, 474);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(128, 29);
            this.btnModificarProveedor.TabIndex = 45;
            this.btnModificarProveedor.Text = "Modificar";
            this.btnModificarProveedor.UseVisualStyleBackColor = false;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnEliminarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(816, 509);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(128, 29);
            this.btnEliminarProveedor.TabIndex = 44;
            this.btnEliminarProveedor.Text = "Eliminar";
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProveedor.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(40, 51);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(128, 21);
            this.btnBuscarProveedor.TabIndex = 47;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.btnModificarProveedor);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.pnlContenedorGrilla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProveedor";
            this.Text = "frmProveedor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlContenedorGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProveedor)).EndInit();
            this.pnlTituloGrilla.ResumeLayout(false);
            this.pnlTituloGrilla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRubro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRutProveedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscarProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDv;
        private System.Windows.Forms.Panel pnlContenedorGrilla;
        protected System.Windows.Forms.DataGridView grdProveedor;
        private System.Windows.Forms.Panel pnlTituloGrilla;
        private System.Windows.Forms.Label nombreGrilla;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnModificarProveedor;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
    }
}