namespace ERP.Dashboard
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpocomaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotaldepedidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtproduccionenproceso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtproductofinalizado = new System.Windows.Forms.TextBox();
            this.txtmenosvendido = new System.Windows.Forms.TextBox();
            this.txtmasvendido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartcomputadora = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartcomputadora)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(18, 351);
            this.chart2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "PORCENTAJES";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(643, 318);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chartgraficaporcientos";
            title2.Name = "Title1";
            title2.Text = "GRAFICA PORCIENTOS";
            this.chart2.Titles.Add(title2);
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(811, 625);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Poco material en #";
            // 
            // txtpocomaterial
            // 
            this.txtpocomaterial.Location = new System.Drawing.Point(184, 66);
            this.txtpocomaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpocomaterial.Name = "txtpocomaterial";
            this.txtpocomaterial.Size = new System.Drawing.Size(148, 27);
            this.txtpocomaterial.TabIndex = 4;
            this.txtpocomaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total de pedidos";
            // 
            // txttotaldepedidos
            // 
            this.txttotaldepedidos.Location = new System.Drawing.Point(184, 156);
            this.txttotaldepedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttotaldepedidos.Name = "txttotaldepedidos";
            this.txttotaldepedidos.Size = new System.Drawing.Size(148, 27);
            this.txttotaldepedidos.TabIndex = 6;
            this.txttotaldepedidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Producción en proceso";
            // 
            // txtproduccionenproceso
            // 
            this.txtproduccionenproceso.Location = new System.Drawing.Point(184, 253);
            this.txtproduccionenproceso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtproduccionenproceso.Name = "txtproduccionenproceso";
            this.txtproduccionenproceso.Size = new System.Drawing.Size(148, 27);
            this.txtproduccionenproceso.TabIndex = 8;
            this.txtproduccionenproceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 410);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Modelo más vendido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Modelo menos vendido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 502);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad de producto finalizado";
            // 
            // txtproductofinalizado
            // 
            this.txtproductofinalizado.Location = new System.Drawing.Point(184, 525);
            this.txtproductofinalizado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtproductofinalizado.Name = "txtproductofinalizado";
            this.txtproductofinalizado.Size = new System.Drawing.Size(148, 27);
            this.txtproductofinalizado.TabIndex = 13;
            this.txtproductofinalizado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtmenosvendido
            // 
            this.txtmenosvendido.Location = new System.Drawing.Point(184, 338);
            this.txtmenosvendido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmenosvendido.Name = "txtmenosvendido";
            this.txtmenosvendido.Size = new System.Drawing.Size(148, 27);
            this.txtmenosvendido.TabIndex = 14;
            this.txtmenosvendido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtmasvendido
            // 
            this.txtmasvendido.Location = new System.Drawing.Point(184, 433);
            this.txtmasvendido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmasvendido.Name = "txtmasvendido";
            this.txtmasvendido.Size = new System.Drawing.Size(148, 27);
            this.txtmasvendido.TabIndex = 15;
            this.txtmasvendido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmasvendido);
            this.groupBox1.Controls.Add(this.txtpocomaterial);
            this.groupBox1.Controls.Add(this.txtmenosvendido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtproductofinalizado);
            this.groupBox1.Controls.Add(this.txttotaldepedidos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtproduccionenproceso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(669, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(344, 576);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros generales";
            // 
            // chartcomputadora
            // 
            chartArea4.Name = "ChartArea1";
            this.chartcomputadora.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartcomputadora.Legends.Add(legend4);
            this.chartcomputadora.Location = new System.Drawing.Point(13, 13);
            this.chartcomputadora.Name = "chartcomputadora";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartcomputadora.Series.Add(series4);
            this.chartcomputadora.Size = new System.Drawing.Size(648, 331);
            this.chartcomputadora.TabIndex = 17;
            this.chartcomputadora.Text = "chart1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 682);
            this.ControlBox = false;
            this.Controls.Add(this.chartcomputadora);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart2);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Activated += new System.EventHandler(this.Dashboard_Activated);
            this.Deactivate += new System.EventHandler(this.Dashboard_Deactivate);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartcomputadora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpocomaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotaldepedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtproduccionenproceso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtproductofinalizado;
        private System.Windows.Forms.TextBox txtmenosvendido;
        private System.Windows.Forms.TextBox txtmasvendido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartcomputadora;
    }
}