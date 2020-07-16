namespace Vista
{
    partial class frmInforme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInforme));
            this.btnAyuda = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.VerForma = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxForma = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.VerCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxCliente = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VerDinero = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxDinero = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VerProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxProducto = new System.Windows.Forms.ComboBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.BackgroundImage")));
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.btnAyuda.Location = new System.Drawing.Point(975, 4);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(21, 22);
            this.btnAyuda.TabIndex = 27;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox4.Controls.Add(this.VerForma);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cboxForma);
            this.groupBox4.Location = new System.Drawing.Point(596, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 168);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Forma de Pago:";
            // 
            // VerForma
            // 
            this.VerForma.Location = new System.Drawing.Point(45, 108);
            this.VerForma.Name = "VerForma";
            this.VerForma.Size = new System.Drawing.Size(176, 21);
            this.VerForma.TabIndex = 21;
            this.VerForma.Text = "Mostrar Informe";
            this.VerForma.UseVisualStyleBackColor = true;
            this.VerForma.Click += new System.EventHandler(this.VerForma_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Seleccione:";
            // 
            // cboxForma
            // 
            this.cboxForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxForma.FormattingEnabled = true;
            this.cboxForma.Location = new System.Drawing.Point(45, 58);
            this.cboxForma.Name = "cboxForma";
            this.cboxForma.Size = new System.Drawing.Size(176, 21);
            this.cboxForma.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Teal;
            this.groupBox3.Controls.Add(this.VerCliente);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cboxCliente);
            this.groupBox3.Location = new System.Drawing.Point(596, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 168);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clientes:";
            // 
            // VerCliente
            // 
            this.VerCliente.Location = new System.Drawing.Point(45, 113);
            this.VerCliente.Name = "VerCliente";
            this.VerCliente.Size = new System.Drawing.Size(176, 21);
            this.VerCliente.TabIndex = 22;
            this.VerCliente.Text = "Mostrar Informe";
            this.VerCliente.UseVisualStyleBackColor = true;
            this.VerCliente.Click += new System.EventHandler(this.VerCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Seleccione:";
            // 
            // cboxCliente
            // 
            this.cboxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCliente.FormattingEnabled = true;
            this.cboxCliente.Location = new System.Drawing.Point(45, 63);
            this.cboxCliente.Name = "cboxCliente";
            this.cboxCliente.Size = new System.Drawing.Size(176, 21);
            this.cboxCliente.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox2.Controls.Add(this.VerDinero);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboxDinero);
            this.groupBox2.Location = new System.Drawing.Point(140, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 168);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dinero:";
            // 
            // VerDinero
            // 
            this.VerDinero.Location = new System.Drawing.Point(45, 113);
            this.VerDinero.Name = "VerDinero";
            this.VerDinero.Size = new System.Drawing.Size(176, 21);
            this.VerDinero.TabIndex = 22;
            this.VerDinero.Text = "Mostrar Informe";
            this.VerDinero.UseVisualStyleBackColor = true;
            this.VerDinero.Click += new System.EventHandler(this.VerDinero_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Seleccione:";
            // 
            // cboxDinero
            // 
            this.cboxDinero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDinero.FormattingEnabled = true;
            this.cboxDinero.Location = new System.Drawing.Point(45, 63);
            this.cboxDinero.Name = "cboxDinero";
            this.cboxDinero.Size = new System.Drawing.Size(176, 21);
            this.cboxDinero.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox1.Controls.Add(this.VerProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboxProducto);
            this.groupBox1.Location = new System.Drawing.Point(140, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 168);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos:";
            // 
            // VerProducto
            // 
            this.VerProducto.Location = new System.Drawing.Point(45, 108);
            this.VerProducto.Name = "VerProducto";
            this.VerProducto.Size = new System.Drawing.Size(176, 21);
            this.VerProducto.TabIndex = 22;
            this.VerProducto.Text = "Mostrar Informe";
            this.VerProducto.UseVisualStyleBackColor = true;
            this.VerProducto.Click += new System.EventHandler(this.VerProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Seleccione:";
            // 
            // cboxProducto
            // 
            this.cboxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProducto.FormattingEnabled = true;
            this.cboxProducto.Location = new System.Drawing.Point(45, 58);
            this.cboxProducto.Name = "cboxProducto";
            this.cboxProducto.Size = new System.Drawing.Size(176, 21);
            this.cboxProducto.TabIndex = 16;
            // 
            // frmInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAyuda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInforme";
            this.Text = "frmInforme";
            this.Load += new System.EventHandler(this.frmInforme_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button VerForma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxForma;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button VerCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button VerDinero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxDinero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button VerProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxProducto;
    }
}