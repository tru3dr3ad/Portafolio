namespace Vista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValorDolar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMonedaActual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gpbCategoria = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.gpbRubro = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.btnAgregarRubro = new System.Windows.Forms.Button();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnMoneda = new System.Windows.Forms.Button();
            this.btnEliminarRubro = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gpbCategoria.SuspendLayout();
            this.gpbRubro.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMoneda);
            this.groupBox1.Controls.Add(this.lblValorDolar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblMonedaActual);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(89, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multi monetario";
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
            // lblMonedaActual
            // 
            this.lblMonedaActual.AutoSize = true;
            this.lblMonedaActual.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblMonedaActual.Location = new System.Drawing.Point(121, 58);
            this.lblMonedaActual.Name = "lblMonedaActual";
            this.lblMonedaActual.Size = new System.Drawing.Size(44, 25);
            this.lblMonedaActual.TabIndex = 4;
            this.lblMonedaActual.Text = "CLP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Moneda Actual";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gpbCategoria);
            this.groupBox3.Controls.Add(this.gpbRubro);
            this.groupBox3.Location = new System.Drawing.Point(472, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 212);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Administrador";
            // 
            // gpbCategoria
            // 
            this.gpbCategoria.Controls.Add(this.btnEliminarCategoria);
            this.gpbCategoria.Controls.Add(this.cmbCategoria);
            this.gpbCategoria.Controls.Add(this.btnAgregarCategoria);
            this.gpbCategoria.Controls.Add(this.label8);
            this.gpbCategoria.Controls.Add(this.txtCategoria);
            this.gpbCategoria.Location = new System.Drawing.Point(16, 114);
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
            this.cmbCategoria.TabIndex = 7;
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
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(141, 42);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 8;
            this.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoria_KeyPress);
            // 
            // gpbRubro
            // 
            this.gpbRubro.Controls.Add(this.btnEliminarRubro);
            this.gpbRubro.Controls.Add(this.label4);
            this.gpbRubro.Controls.Add(this.cmbRubro);
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
            this.label4.Location = new System.Drawing.Point(11, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Listado Rubro";
            // 
            // cmbRubro
            // 
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(13, 39);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(121, 21);
            this.cmbRubro.TabIndex = 3;
            // 
            // btnAgregarRubro
            // 
            this.btnAgregarRubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnAgregarRubro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAgregarRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRubro.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRubro.Location = new System.Drawing.Point(246, 38);
            this.btnAgregarRubro.Name = "btnAgregarRubro";
            this.btnAgregarRubro.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarRubro.TabIndex = 5;
            this.btnAgregarRubro.Text = "AGREGAR";
            this.btnAgregarRubro.UseVisualStyleBackColor = false;
            this.btnAgregarRubro.Click += new System.EventHandler(this.btnAgregarRubro_Click);
            // 
            // txtRubro
            // 
            this.txtRubro.Location = new System.Drawing.Point(140, 39);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(100, 20);
            this.txtRubro.TabIndex = 4;
            this.txtRubro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRubro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRubro_KeyPress);
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
            this.btnAyuda.TabIndex = 4;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnMoneda
            // 
            this.btnMoneda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnMoneda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoneda.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoneda.ForeColor = System.Drawing.Color.White;
            this.btnMoneda.Location = new System.Drawing.Point(89, 127);
            this.btnMoneda.Name = "btnMoneda";
            this.btnMoneda.Size = new System.Drawing.Size(116, 51);
            this.btnMoneda.TabIndex = 44;
            this.btnMoneda.Text = "Cambiar";
            this.btnMoneda.UseVisualStyleBackColor = false;
            this.btnMoneda.Click += new System.EventHandler(this.btnMoneda_Click);
            // 
            // btnEliminarRubro
            // 
            this.btnEliminarRubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnEliminarRubro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnEliminarRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarRubro.ForeColor = System.Drawing.Color.White;
            this.btnEliminarRubro.Location = new System.Drawing.Point(327, 38);
            this.btnEliminarRubro.Name = "btnEliminarRubro";
            this.btnEliminarRubro.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarRubro.TabIndex = 7;
            this.btnEliminarRubro.Text = "ELIMINAR";
            this.btnEliminarRubro.UseVisualStyleBackColor = false;
            this.btnEliminarRubro.Click += new System.EventHandler(this.btnEliminarRubro_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnEliminarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(328, 42);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCategoria.TabIndex = 9;
            this.btnEliminarCategoria.Text = "ELIMINAR";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnAgregarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(247, 42);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCategoria.TabIndex = 8;
            this.btnAgregarCategoria.Text = "AGREGAR";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfiguracion";
            this.Text = "frmConfiguracion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.gpbCategoria.ResumeLayout(false);
            this.gpbCategoria.PerformLayout();
            this.gpbRubro.ResumeLayout(false);
            this.gpbRubro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMonedaActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAgregarRubro;
        private System.Windows.Forms.TextBox txtRubro;
        private System.Windows.Forms.ComboBox cmbRubro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpbCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.GroupBox gpbRubro;
        private System.Windows.Forms.Label lblValorDolar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnMoneda;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnEliminarRubro;
    }
}