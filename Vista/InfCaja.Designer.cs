namespace Vista
{
    partial class InfCaja
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BUSCAR = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.TEXTFECHA = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsCaja = new Vista.DsCaja();
            this.BOLETABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BOLETATableAdapter = new Vista.DsCajaTableAdapters.BOLETATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOLETABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BUSCAR
            // 
            this.BUSCAR.Location = new System.Drawing.Point(77, 231);
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.Size = new System.Drawing.Size(75, 23);
            this.BUSCAR.TabIndex = 4;
            this.BUSCAR.Text = "BUSCAR";
            this.BUSCAR.UseVisualStyleBackColor = true;
            this.BUSCAR.Click += new System.EventHandler(this.BUSCAR_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(12, 186);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // TEXTFECHA
            // 
            this.TEXTFECHA.AutoSize = true;
            this.TEXTFECHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXTFECHA.Location = new System.Drawing.Point(12, 150);
            this.TEXTFECHA.Name = "TEXTFECHA";
            this.TEXTFECHA.Size = new System.Drawing.Size(51, 13);
            this.TEXTFECHA.TabIndex = 5;
            this.TEXTFECHA.Text = "FECHA:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BOLETABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista.ReportCaja.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(218, -3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(582, 453);
            this.reportViewer1.TabIndex = 6;
            // 
            // DsCaja
            // 
            this.DsCaja.DataSetName = "DsCaja";
            this.DsCaja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BOLETABindingSource
            // 
            this.BOLETABindingSource.DataMember = "BOLETA";
            this.BOLETABindingSource.DataSource = this.DsCaja;
            // 
            // BOLETATableAdapter
            // 
            this.BOLETATableAdapter.ClearBeforeFill = true;
            // 
            // InfCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.TEXTFECHA);
            this.Controls.Add(this.BUSCAR);
            this.Controls.Add(this.dtpFecha);
            this.Name = "InfCaja";
            this.Text = "InfCaja";
            this.Load += new System.EventHandler(this.InfCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOLETABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BUSCAR;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label TEXTFECHA;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BOLETABindingSource;
        private DsCaja DsCaja;
        private DsCajaTableAdapters.BOLETATableAdapter BOLETATableAdapter;
    }
}