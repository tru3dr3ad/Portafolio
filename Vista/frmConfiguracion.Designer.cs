﻿namespace Vista
{
    partial class frmConfiguracion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValorDolar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNombreMoneda = new System.Windows.Forms.ComboBox();
            this.btnMoneda = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gpbCategoria = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.gpbEstadoOrden = new System.Windows.Forms.GroupBox();
            this.cmbEstadoOrden = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminarEstadoOrden = new System.Windows.Forms.Button();
            this.btnAgregarEstadoOrden = new System.Windows.Forms.Button();
            this.txtEstadoOrden = new System.Windows.Forms.TextBox();
            this.gpbEstadoFiado = new System.Windows.Forms.GroupBox();
            this.cmbEstadoFiado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminarEstadoFiado = new System.Windows.Forms.Button();
            this.btnAgregarEstadoFiado = new System.Windows.Forms.Button();
            this.txtEstadoFiado = new System.Windows.Forms.TextBox();
            this.gpbTipoCliente = new System.Windows.Forms.GroupBox();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarTipoCliente = new System.Windows.Forms.Button();
            this.btnAgregarTipoCliente = new System.Windows.Forms.Button();
            this.txtTipoCliente = new System.Windows.Forms.TextBox();
            this.gpbRubro = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.btnEliminarRubro = new System.Windows.Forms.Button();
            this.btnAgregarRubro = new System.Windows.Forms.Button();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gpbCategoria.SuspendLayout();
            this.gpbEstadoOrden.SuspendLayout();
            this.gpbEstadoFiado.SuspendLayout();
            this.gpbTipoCliente.SuspendLayout();
            this.gpbRubro.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValorDolar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbNombreMoneda);
            this.groupBox1.Controls.Add(this.btnMoneda);
            this.groupBox1.Location = new System.Drawing.Point(89, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multimonetario";
            // 
            // lblValorDolar
            // 
            this.lblValorDolar.AutoSize = true;
            this.lblValorDolar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDolar.Location = new System.Drawing.Point(171, 207);
            this.lblValorDolar.Name = "lblValorDolar";
            this.lblValorDolar.Size = new System.Drawing.Size(66, 25);
            this.lblValorDolar.TabIndex = 7;
            this.lblValorDolar.Text = "850.25";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Valor Dolar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Peso Chileno CLP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Moneda Actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione Moneda:";
            // 
            // cmbNombreMoneda
            // 
            this.cmbNombreMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreMoneda.FormattingEnabled = true;
            this.cmbNombreMoneda.Items.AddRange(new object[] {
            "CLP",
            "USD"});
            this.cmbNombreMoneda.Location = new System.Drawing.Point(89, 118);
            this.cmbNombreMoneda.Name = "cmbNombreMoneda";
            this.cmbNombreMoneda.Size = new System.Drawing.Size(123, 21);
            this.cmbNombreMoneda.TabIndex = 1;
            // 
            // btnMoneda
            // 
            this.btnMoneda.Location = new System.Drawing.Point(116, 155);
            this.btnMoneda.Name = "btnMoneda";
            this.btnMoneda.Size = new System.Drawing.Size(75, 23);
            this.btnMoneda.TabIndex = 0;
            this.btnMoneda.Text = "Cambiar";
            this.btnMoneda.UseVisualStyleBackColor = true;
            this.btnMoneda.Click += new System.EventHandler(this.btnMoneda_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gpbCategoria);
            this.groupBox3.Controls.Add(this.gpbEstadoOrden);
            this.groupBox3.Controls.Add(this.gpbEstadoFiado);
            this.groupBox3.Controls.Add(this.gpbTipoCliente);
            this.groupBox3.Controls.Add(this.gpbRubro);
            this.groupBox3.Location = new System.Drawing.Point(534, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 526);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Administrador";
            // 
            // gpbCategoria
            // 
            this.gpbCategoria.Controls.Add(this.cmbCategoria);
            this.gpbCategoria.Controls.Add(this.label8);
            this.gpbCategoria.Controls.Add(this.btnEliminarCategoria);
            this.gpbCategoria.Controls.Add(this.btnAgregarCategoria);
            this.gpbCategoria.Controls.Add(this.txtCategoria);
            this.gpbCategoria.Location = new System.Drawing.Point(17, 387);
            this.gpbCategoria.Name = "gpbCategoria";
            this.gpbCategoria.Size = new System.Drawing.Size(417, 86);
            this.gpbCategoria.TabIndex = 7;
            this.gpbCategoria.TabStop = false;
            this.gpbCategoria.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(15, 42);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Listado Categoria";
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(328, 40);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCategoria.TabIndex = 4;
            this.btnEliminarCategoria.Text = "ELIMINAR";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(247, 39);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCategoria.TabIndex = 3;
            this.btnAgregarCategoria.Text = "AGREGAR";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(141, 40);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 2;
            // 
            // gpbEstadoOrden
            // 
            this.gpbEstadoOrden.Controls.Add(this.cmbEstadoOrden);
            this.gpbEstadoOrden.Controls.Add(this.label7);
            this.gpbEstadoOrden.Controls.Add(this.btnEliminarEstadoOrden);
            this.gpbEstadoOrden.Controls.Add(this.btnAgregarEstadoOrden);
            this.gpbEstadoOrden.Controls.Add(this.txtEstadoOrden);
            this.gpbEstadoOrden.Location = new System.Drawing.Point(17, 295);
            this.gpbEstadoOrden.Name = "gpbEstadoOrden";
            this.gpbEstadoOrden.Size = new System.Drawing.Size(416, 86);
            this.gpbEstadoOrden.TabIndex = 7;
            this.gpbEstadoOrden.TabStop = false;
            this.gpbEstadoOrden.Text = "Estado Orden";
            // 
            // cmbEstadoOrden
            // 
            this.cmbEstadoOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoOrden.FormattingEnabled = true;
            this.cmbEstadoOrden.Location = new System.Drawing.Point(9, 45);
            this.cmbEstadoOrden.Name = "cmbEstadoOrden";
            this.cmbEstadoOrden.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoOrden.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Listado Estado Orden";
            // 
            // btnEliminarEstadoOrden
            // 
            this.btnEliminarEstadoOrden.Location = new System.Drawing.Point(323, 43);
            this.btnEliminarEstadoOrden.Name = "btnEliminarEstadoOrden";
            this.btnEliminarEstadoOrden.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEstadoOrden.TabIndex = 4;
            this.btnEliminarEstadoOrden.Text = "ELIMINAR";
            this.btnEliminarEstadoOrden.UseVisualStyleBackColor = true;
            this.btnEliminarEstadoOrden.Click += new System.EventHandler(this.btnEliminarEstadoOrden_Click);
            // 
            // btnAgregarEstadoOrden
            // 
            this.btnAgregarEstadoOrden.Location = new System.Drawing.Point(242, 42);
            this.btnAgregarEstadoOrden.Name = "btnAgregarEstadoOrden";
            this.btnAgregarEstadoOrden.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEstadoOrden.TabIndex = 3;
            this.btnAgregarEstadoOrden.Text = "AGREGAR";
            this.btnAgregarEstadoOrden.UseVisualStyleBackColor = true;
            this.btnAgregarEstadoOrden.Click += new System.EventHandler(this.btnAgregarEstadoOrden_Click);
            // 
            // txtEstadoOrden
            // 
            this.txtEstadoOrden.Location = new System.Drawing.Point(136, 43);
            this.txtEstadoOrden.Name = "txtEstadoOrden";
            this.txtEstadoOrden.Size = new System.Drawing.Size(100, 20);
            this.txtEstadoOrden.TabIndex = 2;
            // 
            // gpbEstadoFiado
            // 
            this.gpbEstadoFiado.Controls.Add(this.cmbEstadoFiado);
            this.gpbEstadoFiado.Controls.Add(this.label6);
            this.gpbEstadoFiado.Controls.Add(this.btnEliminarEstadoFiado);
            this.gpbEstadoFiado.Controls.Add(this.btnAgregarEstadoFiado);
            this.gpbEstadoFiado.Controls.Add(this.txtEstadoFiado);
            this.gpbEstadoFiado.Location = new System.Drawing.Point(18, 203);
            this.gpbEstadoFiado.Name = "gpbEstadoFiado";
            this.gpbEstadoFiado.Size = new System.Drawing.Size(416, 86);
            this.gpbEstadoFiado.TabIndex = 7;
            this.gpbEstadoFiado.TabStop = false;
            this.gpbEstadoFiado.Text = "Estado Fiado";
            // 
            // cmbEstadoFiado
            // 
            this.cmbEstadoFiado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoFiado.FormattingEnabled = true;
            this.cmbEstadoFiado.Location = new System.Drawing.Point(6, 40);
            this.cmbEstadoFiado.Name = "cmbEstadoFiado";
            this.cmbEstadoFiado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoFiado.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Listado Estado Fiado";
            // 
            // btnEliminarEstadoFiado
            // 
            this.btnEliminarEstadoFiado.Location = new System.Drawing.Point(318, 40);
            this.btnEliminarEstadoFiado.Name = "btnEliminarEstadoFiado";
            this.btnEliminarEstadoFiado.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEstadoFiado.TabIndex = 4;
            this.btnEliminarEstadoFiado.Text = "ELIMINAR";
            this.btnEliminarEstadoFiado.UseVisualStyleBackColor = true;
            this.btnEliminarEstadoFiado.Click += new System.EventHandler(this.btnEliminarEstadoFiado_Click);
            // 
            // btnAgregarEstadoFiado
            // 
            this.btnAgregarEstadoFiado.Location = new System.Drawing.Point(237, 37);
            this.btnAgregarEstadoFiado.Name = "btnAgregarEstadoFiado";
            this.btnAgregarEstadoFiado.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEstadoFiado.TabIndex = 3;
            this.btnAgregarEstadoFiado.Text = "AGREGAR";
            this.btnAgregarEstadoFiado.UseVisualStyleBackColor = true;
            this.btnAgregarEstadoFiado.Click += new System.EventHandler(this.btnAgregarEstadoFiado_Click);
            // 
            // txtEstadoFiado
            // 
            this.txtEstadoFiado.Location = new System.Drawing.Point(131, 40);
            this.txtEstadoFiado.Name = "txtEstadoFiado";
            this.txtEstadoFiado.Size = new System.Drawing.Size(100, 20);
            this.txtEstadoFiado.TabIndex = 2;
            // 
            // gpbTipoCliente
            // 
            this.gpbTipoCliente.Controls.Add(this.cmbTipoCliente);
            this.gpbTipoCliente.Controls.Add(this.label5);
            this.gpbTipoCliente.Controls.Add(this.btnEliminarTipoCliente);
            this.gpbTipoCliente.Controls.Add(this.btnAgregarTipoCliente);
            this.gpbTipoCliente.Controls.Add(this.txtTipoCliente);
            this.gpbTipoCliente.Location = new System.Drawing.Point(18, 111);
            this.gpbTipoCliente.Name = "gpbTipoCliente";
            this.gpbTipoCliente.Size = new System.Drawing.Size(416, 86);
            this.gpbTipoCliente.TabIndex = 7;
            this.gpbTipoCliente.TabStop = false;
            this.gpbTipoCliente.Text = "Tipo Cliente";
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Location = new System.Drawing.Point(6, 47);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoCliente.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Listado Tipo Cliente";
            // 
            // btnEliminarTipoCliente
            // 
            this.btnEliminarTipoCliente.Location = new System.Drawing.Point(320, 48);
            this.btnEliminarTipoCliente.Name = "btnEliminarTipoCliente";
            this.btnEliminarTipoCliente.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTipoCliente.TabIndex = 4;
            this.btnEliminarTipoCliente.Text = "ELIMINAR";
            this.btnEliminarTipoCliente.UseVisualStyleBackColor = true;
            this.btnEliminarTipoCliente.Click += new System.EventHandler(this.btnEliminarTipoCliente_Click);
            // 
            // btnAgregarTipoCliente
            // 
            this.btnAgregarTipoCliente.Location = new System.Drawing.Point(239, 47);
            this.btnAgregarTipoCliente.Name = "btnAgregarTipoCliente";
            this.btnAgregarTipoCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTipoCliente.TabIndex = 3;
            this.btnAgregarTipoCliente.Text = "AGREGAR";
            this.btnAgregarTipoCliente.UseVisualStyleBackColor = true;
            this.btnAgregarTipoCliente.Click += new System.EventHandler(this.btnAgregarTipoCliente_Click);
            // 
            // txtTipoCliente
            // 
            this.txtTipoCliente.Location = new System.Drawing.Point(133, 48);
            this.txtTipoCliente.Name = "txtTipoCliente";
            this.txtTipoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCliente.TabIndex = 2;
            // 
            // gpbRubro
            // 
            this.gpbRubro.Controls.Add(this.label4);
            this.gpbRubro.Controls.Add(this.cmbRubro);
            this.gpbRubro.Controls.Add(this.btnEliminarRubro);
            this.gpbRubro.Controls.Add(this.btnAgregarRubro);
            this.gpbRubro.Controls.Add(this.txtRubro);
            this.gpbRubro.Location = new System.Drawing.Point(17, 19);
            this.gpbRubro.Name = "gpbRubro";
            this.gpbRubro.Size = new System.Drawing.Size(416, 86);
            this.gpbRubro.TabIndex = 6;
            this.gpbRubro.TabStop = false;
            this.gpbRubro.Text = "Rubro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Listado Rubro";
            // 
            // cmbRubro
            // 
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(6, 41);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(121, 21);
            this.cmbRubro.TabIndex = 0;
            // 
            // btnEliminarRubro
            // 
            this.btnEliminarRubro.Location = new System.Drawing.Point(320, 43);
            this.btnEliminarRubro.Name = "btnEliminarRubro";
            this.btnEliminarRubro.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarRubro.TabIndex = 4;
            this.btnEliminarRubro.Text = "ELIMINAR";
            this.btnEliminarRubro.UseVisualStyleBackColor = true;
            this.btnEliminarRubro.Click += new System.EventHandler(this.btnEliminarRubro_Click);
            // 
            // btnAgregarRubro
            // 
            this.btnAgregarRubro.Location = new System.Drawing.Point(239, 42);
            this.btnAgregarRubro.Name = "btnAgregarRubro";
            this.btnAgregarRubro.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarRubro.TabIndex = 3;
            this.btnAgregarRubro.Text = "AGREGAR";
            this.btnAgregarRubro.UseVisualStyleBackColor = true;
            this.btnAgregarRubro.Click += new System.EventHandler(this.btnAgregarRubro_Click);
            // 
            // txtRubro
            // 
            this.txtRubro.Location = new System.Drawing.Point(133, 43);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(100, 20);
            this.txtRubro.TabIndex = 2;
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfiguracion";
            this.Text = "frmConfiguracion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.gpbCategoria.ResumeLayout(false);
            this.gpbCategoria.PerformLayout();
            this.gpbEstadoOrden.ResumeLayout(false);
            this.gpbEstadoOrden.PerformLayout();
            this.gpbEstadoFiado.ResumeLayout(false);
            this.gpbEstadoFiado.PerformLayout();
            this.gpbTipoCliente.ResumeLayout(false);
            this.gpbTipoCliente.PerformLayout();
            this.gpbRubro.ResumeLayout(false);
            this.gpbRubro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNombreMoneda;
        private System.Windows.Forms.Button btnMoneda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminarRubro;
        private System.Windows.Forms.Button btnAgregarRubro;
        private System.Windows.Forms.TextBox txtRubro;
        private System.Windows.Forms.ComboBox cmbRubro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpbCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.GroupBox gpbEstadoOrden;
        private System.Windows.Forms.ComboBox cmbEstadoOrden;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminarEstadoOrden;
        private System.Windows.Forms.Button btnAgregarEstadoOrden;
        private System.Windows.Forms.TextBox txtEstadoOrden;
        private System.Windows.Forms.GroupBox gpbEstadoFiado;
        private System.Windows.Forms.ComboBox cmbEstadoFiado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarEstadoFiado;
        private System.Windows.Forms.Button btnAgregarEstadoFiado;
        private System.Windows.Forms.TextBox txtEstadoFiado;
        private System.Windows.Forms.GroupBox gpbTipoCliente;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarTipoCliente;
        private System.Windows.Forms.Button btnAgregarTipoCliente;
        private System.Windows.Forms.TextBox txtTipoCliente;
        private System.Windows.Forms.GroupBox gpbRubro;
        private System.Windows.Forms.Label lblValorDolar;
        private System.Windows.Forms.Label label9;
    }
}