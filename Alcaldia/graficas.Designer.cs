namespace Alcaldia
{
    partial class graficas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.alcaldiaDataSet = new Alcaldia.alcaldiaDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Alcaldia.alcaldiaDataSetTableAdapters.usuariosTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.alcaldiaDataSet1 = new Alcaldia.alcaldiaDataSet1();
            this.graficaClificacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graficaClificacionTableAdapter = new Alcaldia.alcaldiaDataSet1TableAdapters.graficaClificacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.alcaldiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alcaldiaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficaClificacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alcaldiaDataSet
            // 
            this.alcaldiaDataSet.DataSetName = "alcaldiaDataSet";
            this.alcaldiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.alcaldiaDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.graficaClificacionBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(147, 59);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "estado";
            series1.YValueMembers = "cedula";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series2.XValueMember = "estado";
            series2.YValueMembers = "cedula";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(411, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // alcaldiaDataSet1
            // 
            this.alcaldiaDataSet1.DataSetName = "alcaldiaDataSet1";
            this.alcaldiaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // graficaClificacionBindingSource
            // 
            this.graficaClificacionBindingSource.DataMember = "graficaClificacion";
            this.graficaClificacionBindingSource.DataSource = this.alcaldiaDataSet1;
            // 
            // graficaClificacionTableAdapter
            // 
            this.graficaClificacionTableAdapter.ClearBeforeFill = true;
            // 
            // graficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 436);
            this.Controls.Add(this.chart1);
            this.Name = "graficas";
            this.Text = "graficas";
            this.Load += new System.EventHandler(this.graficas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alcaldiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alcaldiaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficaClificacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private alcaldiaDataSet alcaldiaDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private alcaldiaDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private alcaldiaDataSet1 alcaldiaDataSet1;
        private System.Windows.Forms.BindingSource graficaClificacionBindingSource;
        private alcaldiaDataSet1TableAdapters.graficaClificacionTableAdapter graficaClificacionTableAdapter;
    }
}