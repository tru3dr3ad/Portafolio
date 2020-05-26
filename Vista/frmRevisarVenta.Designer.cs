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
            this.grdBoleta = new System.Windows.Forms.DataGridView();
            this.btnEliminarBoleta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVendedores = new System.Windows.Forms.ComboBox();
            this.btnBuscarBoleta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarBoleta = new System.Windows.Forms.TextBox();
            this.btnModificarBoleta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBoleta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdBoleta
            // 
            this.grdBoleta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBoleta.Location = new System.Drawing.Point(12, 104);
            this.grdBoleta.MultiSelect = false;
            this.grdBoleta.Name = "grdBoleta";
            this.grdBoleta.ReadOnly = true;
            this.grdBoleta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBoleta.Size = new System.Drawing.Size(787, 434);
            this.grdBoleta.TabIndex = 32;
            // 
            // btnEliminarBoleta
            // 
            this.btnEliminarBoleta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarBoleta.Location = new System.Drawing.Point(832, 493);
            this.btnEliminarBoleta.Name = "btnEliminarBoleta";
            this.btnEliminarBoleta.Size = new System.Drawing.Size(128, 21);
            this.btnEliminarBoleta.TabIndex = 35;
            this.btnEliminarBoleta.Text = "Anular";
            this.btnEliminarBoleta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.cmbMedioPago);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbVendedores);
            this.groupBox2.Controls.Add(this.btnBuscarBoleta);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBuscarBoleta);
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 73);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Boleta:";
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(336, 28);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(181, 21);
            this.cmbMedioPago.TabIndex = 50;
            this.cmbMedioPago.SelectedValueChanged += new System.EventHandler(this.cmbMedioPago_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Medio Pago:";
            // 
            // cmbVendedores
            // 
            this.cmbVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedores.FormattingEnabled = true;
            this.cmbVendedores.Location = new System.Drawing.Point(68, 28);
            this.cmbVendedores.Name = "cmbVendedores";
            this.cmbVendedores.Size = new System.Drawing.Size(181, 21);
            this.cmbVendedores.TabIndex = 48;
            this.cmbVendedores.SelectedIndexChanged += new System.EventHandler(this.cmbVendedores_SelectedIndexChanged);
            // 
            // btnBuscarBoleta
            // 
            this.btnBuscarBoleta.Location = new System.Drawing.Point(729, 27);
            this.btnBuscarBoleta.Name = "btnBuscarBoleta";
            this.btnBuscarBoleta.Size = new System.Drawing.Size(128, 21);
            this.btnBuscarBoleta.TabIndex = 2;
            this.btnBuscarBoleta.Text = "Buscar";
            this.btnBuscarBoleta.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Vendedor:";
            // 
            // txtBuscarBoleta
            // 
            this.txtBuscarBoleta.Location = new System.Drawing.Point(530, 28);
            this.txtBuscarBoleta.Name = "txtBuscarBoleta";
            this.txtBuscarBoleta.Size = new System.Drawing.Size(182, 20);
            this.txtBuscarBoleta.TabIndex = 1;
            // 
            // btnModificarBoleta
            // 
            this.btnModificarBoleta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModificarBoleta.Location = new System.Drawing.Point(832, 454);
            this.btnModificarBoleta.Name = "btnModificarBoleta";
            this.btnModificarBoleta.Size = new System.Drawing.Size(128, 21);
            this.btnModificarBoleta.TabIndex = 34;
            this.btnModificarBoleta.Text = "Modificar";
            this.btnModificarBoleta.UseVisualStyleBackColor = true;
            // 
            // frmRevisarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.btnEliminarBoleta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnModificarBoleta);
            this.Controls.Add(this.grdBoleta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRevisarVenta";
            this.Text = "frmVenta";
            ((System.ComponentModel.ISupportInitialize)(this.grdBoleta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBoleta;
        private System.Windows.Forms.Button btnEliminarBoleta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarBoleta;
        private System.Windows.Forms.TextBox txtBuscarBoleta;
        private System.Windows.Forms.Button btnModificarBoleta;
        private System.Windows.Forms.ComboBox cmbVendedores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMedioPago;
        private System.Windows.Forms.Label label1;
    }
}