﻿namespace Vista
{
    partial class InfProductoMas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsProductoMas = new Vista.DsProductoMas();
            this.PRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRODUCTOTableAdapter = new Vista.DsProductoMasTableAdapters.PRODUCTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsProductoMas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PRODUCTOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista.ReportProductoMas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsProductoMas
            // 
            this.DsProductoMas.DataSetName = "DsProductoMas";
            this.DsProductoMas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PRODUCTOBindingSource
            // 
            this.PRODUCTOBindingSource.DataMember = "PRODUCTO";
            this.PRODUCTOBindingSource.DataSource = this.DsProductoMas;
            // 
            // PRODUCTOTableAdapter
            // 
            this.PRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // InfProductoMas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InfProductoMas";
            this.Text = "InfProductoMas";
            this.Load += new System.EventHandler(this.InfProductoMas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsProductoMas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PRODUCTOBindingSource;
        private DsProductoMas DsProductoMas;
        private DsProductoMasTableAdapters.PRODUCTOTableAdapter PRODUCTOTableAdapter;
    }
}