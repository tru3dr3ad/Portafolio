﻿namespace Vista
{
    partial class frmPedido
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
            this.btnRecepcionarOrden = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarOrden = new System.Windows.Forms.Button();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.btnEliminarOrden = new System.Windows.Forms.Button();
            this.btnGuardarOrden = new System.Windows.Forms.Button();
            this.btnModificarOrden = new System.Windows.Forms.Button();
            this.grdOrden = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDescargarOrden = new System.Windows.Forms.Button();
            this.grpRecepcion = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cmbEstadoOrden = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpRecepcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecepcionarOrden
            // 
            this.btnRecepcionarOrden.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRecepcionarOrden.Location = new System.Drawing.Point(816, 303);
            this.btnRecepcionarOrden.Name = "btnRecepcionarOrden";
            this.btnRecepcionarOrden.Size = new System.Drawing.Size(128, 62);
            this.btnRecepcionarOrden.TabIndex = 38;
            this.btnRecepcionarOrden.Text = "Recepcionar Orden";
            this.btnRecepcionarOrden.UseVisualStyleBackColor = true;
            this.btnRecepcionarOrden.Click += new System.EventHandler(this.btnRecepcionarOrden_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.btnBuscarOrden);
            this.groupBox2.Controls.Add(this.txtBuscarUsuario);
            this.groupBox2.Location = new System.Drawing.Point(776, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 85);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Orden:";
            // 
            // btnBuscarOrden
            // 
            this.btnBuscarOrden.Location = new System.Drawing.Point(40, 55);
            this.btnBuscarOrden.Name = "btnBuscarOrden";
            this.btnBuscarOrden.Size = new System.Drawing.Size(128, 21);
            this.btnBuscarOrden.TabIndex = 2;
            this.btnBuscarOrden.Text = "Buscar";
            this.btnBuscarOrden.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(this.txtCorreoElectronico);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefonoProveedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreProveedor);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 231);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Orden Pedido:";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(13, 186);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(182, 20);
            this.txtCorreoElectronico.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo Electronico;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefono:";
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(13, 135);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(182, 20);
            this.txtTelefonoProveedor.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rut:";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(13, 83);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(182, 20);
            this.txtRut.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Proveedor:";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(13, 31);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(182, 20);
            this.txtNombreProveedor.TabIndex = 3;
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
            // 
            // btnGuardarOrden
            // 
            this.btnGuardarOrden.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardarOrden.Location = new System.Drawing.Point(816, 389);
            this.btnGuardarOrden.Name = "btnGuardarOrden";
            this.btnGuardarOrden.Size = new System.Drawing.Size(128, 21);
            this.btnGuardarOrden.TabIndex = 33;
            this.btnGuardarOrden.Text = "Guardar";
            this.btnGuardarOrden.UseVisualStyleBackColor = true;
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
            this.grdOrden.Location = new System.Drawing.Point(12, 283);
            this.grdOrden.Name = "grdOrden";
            this.grdOrden.Size = new System.Drawing.Size(740, 255);
            this.grdOrden.TabIndex = 41;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox4.Location = new System.Drawing.Point(179, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(182, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nombre Producto";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox2.Location = new System.Drawing.Point(179, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Precio Compra:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscarProducto.Location = new System.Drawing.Point(391, 31);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(128, 21);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarProducto.Location = new System.Drawing.Point(391, 186);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(128, 21);
            this.btnAgregarProducto.TabIndex = 9;
            this.btnAgregarProducto.Text = "Agregar Productos";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.Location = new System.Drawing.Point(179, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDown1.Location = new System.Drawing.Point(179, 83);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(182, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.btnAgregarProducto);
            this.groupBox3.Controls.Add(this.btnBuscarProducto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Location = new System.Drawing.Point(227, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(525, 231);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(156, 174);
            this.dataGridView1.TabIndex = 14;
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
            this.grpRecepcion.Location = new System.Drawing.Point(776, 134);
            this.grpRecepcion.Name = "grpRecepcion";
            this.grpRecepcion.Size = new System.Drawing.Size(212, 135);
            this.grpRecepcion.TabIndex = 38;
            this.grpRecepcion.TabStop = false;
            this.grpRecepcion.Text = "Recepción:";
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
            // cmbEstadoOrden
            // 
            this.cmbEstadoOrden.FormattingEnabled = true;
            this.cmbEstadoOrden.Location = new System.Drawing.Point(13, 52);
            this.cmbEstadoOrden.Name = "cmbEstadoOrden";
            this.cmbEstadoOrden.Size = new System.Drawing.Size(181, 21);
            this.cmbEstadoOrden.TabIndex = 3;
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
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.grpRecepcion);
            this.Controls.Add(this.btnDescargarOrden);
            this.Controls.Add(this.grdOrden);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRecepcionarOrden);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminarOrden);
            this.Controls.Add(this.btnGuardarOrden);
            this.Controls.Add(this.btnModificarOrden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPedido";
            this.Text = "frmPedido";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpRecepcion.ResumeLayout(false);
            this.grpRecepcion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRecepcionarOrden;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarOrden;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Button btnEliminarOrden;
        private System.Windows.Forms.Button btnGuardarOrden;
        private System.Windows.Forms.Button btnModificarOrden;
        private System.Windows.Forms.DataGridView grdOrden;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDescargarOrden;
        private System.Windows.Forms.GroupBox grpRecepcion;
        private System.Windows.Forms.ComboBox cmbEstadoOrden;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label9;
    }
}