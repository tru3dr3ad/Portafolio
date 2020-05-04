namespace Vista
{
    partial class frmEstadistica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbSeleccionarEstadistica = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionarEstadistica = new System.Windows.Forms.Button();
            this.grpEstadistica = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.grpEstadistica.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(27, 50);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(700, 450);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // cmbSeleccionarEstadistica
            // 
            this.cmbSeleccionarEstadistica.FormattingEnabled = true;
            this.cmbSeleccionarEstadistica.Location = new System.Drawing.Point(25, 47);
            this.cmbSeleccionarEstadistica.Name = "cmbSeleccionarEstadistica";
            this.cmbSeleccionarEstadistica.Size = new System.Drawing.Size(179, 21);
            this.cmbSeleccionarEstadistica.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione:";
            // 
            // btnSeleccionarEstadistica
            // 
            this.btnSeleccionarEstadistica.Location = new System.Drawing.Point(56, 85);
            this.btnSeleccionarEstadistica.Name = "btnSeleccionarEstadistica";
            this.btnSeleccionarEstadistica.Size = new System.Drawing.Size(120, 30);
            this.btnSeleccionarEstadistica.TabIndex = 3;
            this.btnSeleccionarEstadistica.Text = "Seleccionar";
            this.btnSeleccionarEstadistica.UseVisualStyleBackColor = true;
            // 
            // grpEstadistica
            // 
            this.grpEstadistica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEstadistica.Controls.Add(this.btnSeleccionarEstadistica);
            this.grpEstadistica.Controls.Add(this.label1);
            this.grpEstadistica.Controls.Add(this.cmbSeleccionarEstadistica);
            this.grpEstadistica.Location = new System.Drawing.Point(744, 50);
            this.grpEstadistica.Name = "grpEstadistica";
            this.grpEstadistica.Size = new System.Drawing.Size(225, 141);
            this.grpEstadistica.TabIndex = 4;
            this.grpEstadistica.TabStop = false;
            this.grpEstadistica.Text = "Estadisticas";
            // 
            // frmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.grpEstadistica);
            this.Controls.Add(this.chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstadistica";
            this.Text = "frmEstadistica";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.grpEstadistica.ResumeLayout(false);
            this.grpEstadistica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ComboBox cmbSeleccionarEstadistica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionarEstadistica;
        private System.Windows.Forms.GroupBox grpEstadistica;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}