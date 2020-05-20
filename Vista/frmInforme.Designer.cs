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
            this.dgrInforme = new System.Windows.Forms.DataGridView();
            this.grpInforme = new System.Windows.Forms.GroupBox();
            this.btnSeleccionarInforme = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSeleccionarInforme = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.btnExportarInforme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrInforme)).BeginInit();
            this.grpInforme.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrInforme
            // 
            this.dgrInforme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrInforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrInforme.Location = new System.Drawing.Point(30, 50);
            this.dgrInforme.MultiSelect = false;
            this.dgrInforme.Name = "dgrInforme";
            this.dgrInforme.Size = new System.Drawing.Size(700, 450);
            this.dgrInforme.TabIndex = 10;
            // 
            // grpInforme
            // 
            this.grpInforme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInforme.Controls.Add(this.btnSeleccionarInforme);
            this.grpInforme.Controls.Add(this.label2);
            this.grpInforme.Controls.Add(this.cmbSeleccionarInforme);
            this.grpInforme.Location = new System.Drawing.Point(749, 50);
            this.grpInforme.Name = "grpInforme";
            this.grpInforme.Size = new System.Drawing.Size(225, 141);
            this.grpInforme.TabIndex = 9;
            this.grpInforme.TabStop = false;
            this.grpInforme.Text = "Informes";
            // 
            // btnSeleccionarInforme
            // 
            this.btnSeleccionarInforme.Location = new System.Drawing.Point(56, 85);
            this.btnSeleccionarInforme.Name = "btnSeleccionarInforme";
            this.btnSeleccionarInforme.Size = new System.Drawing.Size(120, 30);
            this.btnSeleccionarInforme.TabIndex = 3;
            this.btnSeleccionarInforme.Text = "Seleccionar";
            this.btnSeleccionarInforme.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione:";
            // 
            // cmbSeleccionarInforme
            // 
            this.cmbSeleccionarInforme.FormattingEnabled = true;
            this.cmbSeleccionarInforme.Location = new System.Drawing.Point(25, 47);
            this.cmbSeleccionarInforme.Name = "cmbSeleccionarInforme";
            this.cmbSeleccionarInforme.Size = new System.Drawing.Size(179, 21);
            this.cmbSeleccionarInforme.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbFormato);
            this.groupBox1.Controls.Add(this.btnExportarInforme);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(749, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 127);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exportar";
            // 
            // cmbFormato
            // 
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Location = new System.Drawing.Point(25, 58);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(179, 21);
            this.cmbFormato.TabIndex = 4;
            // 
            // btnExportarInforme
            // 
            this.btnExportarInforme.Location = new System.Drawing.Point(56, 85);
            this.btnExportarInforme.Name = "btnExportarInforme";
            this.btnExportarInforme.Size = new System.Drawing.Size(120, 30);
            this.btnExportarInforme.TabIndex = 3;
            this.btnExportarInforme.Text = "Exportar";
            this.btnExportarInforme.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Formato:";
            // 
            // frmInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgrInforme);
            this.Controls.Add(this.grpInforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInforme";
            this.Text = "frmInforme";
            ((System.ComponentModel.ISupportInitialize)(this.dgrInforme)).EndInit();
            this.grpInforme.ResumeLayout(false);
            this.grpInforme.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrInforme;
        private System.Windows.Forms.GroupBox grpInforme;
        private System.Windows.Forms.Button btnSeleccionarInforme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSeleccionarInforme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExportarInforme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFormato;
    }
}