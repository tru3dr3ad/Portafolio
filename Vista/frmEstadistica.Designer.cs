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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionarEst = new System.Windows.Forms.Button();
            this.grpEstadistica = new System.Windows.Forms.GroupBox();
            this.rdEstadistica = new System.Windows.Forms.RadioButton();
            this.rdInforme = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpInforme = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dgrInforme = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.grpEstadistica.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpInforme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrInforme)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea4.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart.Legends.Add(legend4);
            this.chart.Location = new System.Drawing.Point(27, 50);
            this.chart.Name = "chart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(700, 450);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 1;
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
            // btnSeleccionarEst
            // 
            this.btnSeleccionarEst.Location = new System.Drawing.Point(56, 85);
            this.btnSeleccionarEst.Name = "btnSeleccionarEst";
            this.btnSeleccionarEst.Size = new System.Drawing.Size(120, 30);
            this.btnSeleccionarEst.TabIndex = 3;
            this.btnSeleccionarEst.Text = "Seleccionar";
            this.btnSeleccionarEst.UseVisualStyleBackColor = true;
            // 
            // grpEstadistica
            // 
            this.grpEstadistica.Controls.Add(this.btnSeleccionarEst);
            this.grpEstadistica.Controls.Add(this.label1);
            this.grpEstadistica.Controls.Add(this.comboBox1);
            this.grpEstadistica.Location = new System.Drawing.Point(742, 282);
            this.grpEstadistica.Name = "grpEstadistica";
            this.grpEstadistica.Size = new System.Drawing.Size(225, 141);
            this.grpEstadistica.TabIndex = 4;
            this.grpEstadistica.TabStop = false;
            this.grpEstadistica.Text = "Estadisticas";
            // 
            // rdEstadistica
            // 
            this.rdEstadistica.AutoSize = true;
            this.rdEstadistica.Checked = true;
            this.rdEstadistica.Location = new System.Drawing.Point(21, 29);
            this.rdEstadistica.Name = "rdEstadistica";
            this.rdEstadistica.Size = new System.Drawing.Size(81, 17);
            this.rdEstadistica.TabIndex = 5;
            this.rdEstadistica.TabStop = true;
            this.rdEstadistica.Text = "Estadisticas";
            this.rdEstadistica.UseVisualStyleBackColor = true;
            this.rdEstadistica.CheckedChanged += new System.EventHandler(this.rdEstadistica_CheckedChanged);
            // 
            // rdInforme
            // 
            this.rdInforme.AutoSize = true;
            this.rdInforme.Location = new System.Drawing.Point(115, 29);
            this.rdInforme.Name = "rdInforme";
            this.rdInforme.Size = new System.Drawing.Size(65, 17);
            this.rdInforme.TabIndex = 6;
            this.rdInforme.Text = "Informes";
            this.rdInforme.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdInforme);
            this.groupBox2.Controls.Add(this.rdEstadistica);
            this.groupBox2.Location = new System.Drawing.Point(742, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 66);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reporte";
            // 
            // grpInforme
            // 
            this.grpInforme.Controls.Add(this.button1);
            this.grpInforme.Controls.Add(this.label2);
            this.grpInforme.Controls.Add(this.comboBox2);
            this.grpInforme.Location = new System.Drawing.Point(742, 135);
            this.grpInforme.Name = "grpInforme";
            this.grpInforme.Size = new System.Drawing.Size(225, 141);
            this.grpInforme.TabIndex = 5;
            this.grpInforme.TabStop = false;
            this.grpInforme.Text = "Informes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(25, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(179, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // dgrInforme
            // 
            this.dgrInforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrInforme.Location = new System.Drawing.Point(27, 50);
            this.dgrInforme.Name = "dgrInforme";
            this.dgrInforme.Size = new System.Drawing.Size(700, 450);
            this.dgrInforme.TabIndex = 8;
            // 
            // frmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.dgrInforme);
            this.Controls.Add(this.grpInforme);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpEstadistica);
            this.Controls.Add(this.chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstadistica";
            this.Text = "frmEstadistica";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.grpEstadistica.ResumeLayout(false);
            this.grpEstadistica.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpInforme.ResumeLayout(false);
            this.grpInforme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrInforme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionarEst;
        private System.Windows.Forms.GroupBox grpEstadistica;
        private System.Windows.Forms.RadioButton rdEstadistica;
        private System.Windows.Forms.RadioButton rdInforme;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpInforme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dgrInforme;
    }
}