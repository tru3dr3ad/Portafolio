namespace Vista
{
    partial class InfDelMes
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
            this.BOLETABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsDelMes = new Vista.DsDelMes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BOLETATableAdapter = new Vista.DsDelMesTableAdapters.BOLETATableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.TEXTDESDE = new System.Windows.Forms.Label();
            this.BUSCAR = new System.Windows.Forms.Button();
            this.dtpHASTA = new System.Windows.Forms.DateTimePicker();
            this.dtpDESDE = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.BOLETABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsDelMes)).BeginInit();
            this.SuspendLayout();
            // 
            // BOLETABindingSource
            // 
            this.BOLETABindingSource.DataMember = "BOLETA";
            this.BOLETABindingSource.DataSource = this.DsDelMes;
            // 
            // DsDelMes
            // 
            this.DsDelMes.DataSetName = "DsDelMes";
            this.DsDelMes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BOLETABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista.ReportDelMes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(218, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(582, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // BOLETATableAdapter
            // 
            this.BOLETATableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "HASTA:";
            // 
            // TEXTDESDE
            // 
            this.TEXTDESDE.AutoSize = true;
            this.TEXTDESDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXTDESDE.Location = new System.Drawing.Point(12, 115);
            this.TEXTDESDE.Name = "TEXTDESDE";
            this.TEXTDESDE.Size = new System.Drawing.Size(53, 13);
            this.TEXTDESDE.TabIndex = 9;
            this.TEXTDESDE.Text = "DESDE:";
            // 
            // BUSCAR
            // 
            this.BUSCAR.Location = new System.Drawing.Point(79, 292);
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.Size = new System.Drawing.Size(75, 23);
            this.BUSCAR.TabIndex = 8;
            this.BUSCAR.Text = "BUSCAR";
            this.BUSCAR.UseVisualStyleBackColor = true;
            this.BUSCAR.Click += new System.EventHandler(this.BUSCAR_Click);
            // 
            // dtpHASTA
            // 
            this.dtpHASTA.Location = new System.Drawing.Point(12, 230);
            this.dtpHASTA.Name = "dtpHASTA";
            this.dtpHASTA.Size = new System.Drawing.Size(200, 20);
            this.dtpHASTA.TabIndex = 7;
            // 
            // dtpDESDE
            // 
            this.dtpDESDE.Location = new System.Drawing.Point(12, 140);
            this.dtpDESDE.Name = "dtpDESDE";
            this.dtpDESDE.Size = new System.Drawing.Size(200, 20);
            this.dtpDESDE.TabIndex = 6;
            // 
            // InfDelMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TEXTDESDE);
            this.Controls.Add(this.BUSCAR);
            this.Controls.Add(this.dtpHASTA);
            this.Controls.Add(this.dtpDESDE);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InfDelMes";
            this.Text = "InfDelMes";
            this.Load += new System.EventHandler(this.InfDelMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BOLETABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsDelMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BOLETABindingSource;
        private DsDelMes DsDelMes;
        private DsDelMesTableAdapters.BOLETATableAdapter BOLETATableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TEXTDESDE;
        private System.Windows.Forms.Button BUSCAR;
        private System.Windows.Forms.DateTimePicker dtpHASTA;
        private System.Windows.Forms.DateTimePicker dtpDESDE;
    }
}