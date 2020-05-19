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
            this.btnMostrarRecepcion = new System.Windows.Forms.Button();
            this.btnEliminarOrden = new System.Windows.Forms.Button();
            this.btnModificarOrden = new System.Windows.Forms.Button();
            this.grdOrden = new System.Windows.Forms.DataGridView();
            this.btnDescargarOrden = new System.Windows.Forms.Button();
            this.grpRecepcion = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEstadoOrden = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.btnBuscarOrden = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarOrden = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrden)).BeginInit();
            this.grpRecepcion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMostrarRecepcion
            // 
            this.btnMostrarRecepcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMostrarRecepcion.Location = new System.Drawing.Point(816, 303);
            this.btnMostrarRecepcion.Name = "btnMostrarRecepcion";
            this.btnMostrarRecepcion.Size = new System.Drawing.Size(128, 62);
            this.btnMostrarRecepcion.TabIndex = 38;
            this.btnMostrarRecepcion.Text = "Recepcionar Orden";
            this.btnMostrarRecepcion.UseVisualStyleBackColor = true;
            // 
            // btnEliminarOrden
            // 
            this.btnEliminarOrden.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarOrden.Location = new System.Drawing.Point(816, 506);
            this.btnEliminarOrden.Name = "btnEliminarOrden";
            this.btnEliminarOrden.Size = new System.Drawing.Size(128, 21);
            this.btnEliminarOrden.TabIndex = 35;
            this.btnEliminarOrden.Text = "Eliminar";
            this.btnEliminarOrden.UseVisualStyleBackColor = true;
            this.btnEliminarOrden.Click += new System.EventHandler(this.btnEliminarOrden_Click);
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
            // 
            // grdOrden
            // 
            this.grdOrden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrden.Location = new System.Drawing.Point(12, 103);
            this.grdOrden.Name = "grdOrden";
            this.grdOrden.ReadOnly = true;
            this.grdOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOrden.Size = new System.Drawing.Size(758, 424);
            this.grdOrden.TabIndex = 41;
            this.grdOrden.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrden_CellDoubleClick);
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
            // 
            // grpRecepcion
            // 
            this.grpRecepcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grpRecepcion.Controls.Add(this.label9);
            this.grpRecepcion.Controls.Add(this.cmbEstadoOrden);
            this.grpRecepcion.Controls.Add(this.btnConfirmar);
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
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(40, 100);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(128, 21);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.cmbProveedores);
            this.groupBox1.Controls.Add(this.btnBuscarOrden);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBuscarOrden);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 73);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Boleta:";
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(68, 28);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(181, 21);
            this.cmbProveedores.TabIndex = 48;
            // 
            // btnBuscarOrden
            // 
            this.btnBuscarOrden.Location = new System.Drawing.Point(540, 28);
            this.btnBuscarOrden.Name = "btnBuscarOrden";
            this.btnBuscarOrden.Size = new System.Drawing.Size(128, 21);
            this.btnBuscarOrden.TabIndex = 2;
            this.btnBuscarOrden.Text = "Buscar";
            this.btnBuscarOrden.UseVisualStyleBackColor = true;
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
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpRecepcion);
            this.Controls.Add(this.btnDescargarOrden);
            this.Controls.Add(this.grdOrden);
            this.Controls.Add(this.btnMostrarRecepcion);
            this.Controls.Add(this.btnEliminarOrden);
            this.Controls.Add(this.btnModificarOrden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPedido";
            this.Text = "frmPedido";
            ((System.ComponentModel.ISupportInitialize)(this.grdOrden)).EndInit();
            this.grpRecepcion.ResumeLayout(false);
            this.grpRecepcion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMostrarRecepcion;
        private System.Windows.Forms.Button btnEliminarOrden;
        private System.Windows.Forms.Button btnModificarOrden;
        private System.Windows.Forms.DataGridView grdOrden;
        private System.Windows.Forms.Button btnDescargarOrden;
        private System.Windows.Forms.GroupBox grpRecepcion;
        private System.Windows.Forms.ComboBox cmbEstadoOrden;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.Button btnBuscarOrden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarOrden;
    }
}