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
            this.grdVentaFiadas = new System.Windows.Forms.DataGridView();
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
            this.grdAbono = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdVentaFiadas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAbono)).BeginInit();
            this.SuspendLayout();
            // 
            // grdVentaFiadas
            // 
            this.grdVentaFiadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdVentaFiadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVentaFiadas.Location = new System.Drawing.Point(12, 10);
            this.grdVentaFiadas.MultiSelect = false;
            this.grdVentaFiadas.Name = "grdVentaFiadas";
            this.grdVentaFiadas.ReadOnly = true;
            this.grdVentaFiadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVentaFiadas.Size = new System.Drawing.Size(740, 266);
            this.grdVentaFiadas.TabIndex = 37;
            this.grdVentaFiadas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVentaFiadas_CellDoubleClick);
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
            // grdAbono
            // 
            this.grdAbono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAbono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAbono.Location = new System.Drawing.Point(12, 294);
            this.grdAbono.MultiSelect = false;
            this.grdAbono.Name = "grdAbono";
            this.grdAbono.ReadOnly = true;
            this.grdAbono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAbono.Size = new System.Drawing.Size(740, 236);
            this.grdAbono.TabIndex = 38;
            // 
            // frmFiado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.grdAbono);
            this.Controls.Add(this.grdVentaFiadas);
            this.Controls.Add(this.btnEliminarAbono);
            this.Controls.Add(this.btnAgregarAbono);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnModificarAbono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFiado";
            this.Text = "frmFiado";
            ((System.ComponentModel.ISupportInitialize)(this.grdVentaFiadas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAbono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdVentaFiadas;
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
        private System.Windows.Forms.DataGridView grdAbono;
    }
}