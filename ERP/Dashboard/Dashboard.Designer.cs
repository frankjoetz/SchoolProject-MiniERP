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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartcomputadora = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpocomaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotaldepedidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtproduccionenproceso = new System.Windows.Forms.TextBox();
            this.txtmodelomasvendido = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtproductofinalizado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartcomputadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartcomputadora
            // 
            chartArea1.Name = "ChartArea1";
            this.chartcomputadora.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartcomputadora.Legends.Add(legend1);
            this.chartcomputadora.Location = new System.Drawing.Point(-3, 2);
            this.chartcomputadora.Name = "chartcomputadora";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "PRODUCCION";
            this.chartcomputadora.Series.Add(series1);
            this.chartcomputadora.Size = new System.Drawing.Size(623, 294);
            this.chartcomputadora.TabIndex = 0;
            this.chartcomputadora.Text = "chart1";
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.Blue;
            title1.Text = "GRAFICAS DE PRODUCCION";
            this.chartcomputadora.Titles.Add(title1);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(-3, 302);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "PORCENTAJES";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(390, 189);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chartgraficaporcientos";
            title2.Name = "Title1";
            title2.Text = "GRAFICA PORCIENTOS";
            this.chart2.Titles.Add(title2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(752, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "POCO MATERIAL";
            // 
            // txtpocomaterial
            // 
            this.txtpocomaterial.Location = new System.Drawing.Point(660, 39);
            this.txtpocomaterial.Name = "txtpocomaterial";
            this.txtpocomaterial.Size = new System.Drawing.Size(100, 20);
            this.txtpocomaterial.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TOTAL DE PEDIDOS";
            // 
            // txttotaldepedidos
            // 
            this.txttotaldepedidos.Location = new System.Drawing.Point(660, 118);
            this.txttotaldepedidos.Name = "txttotaldepedidos";
            this.txttotaldepedidos.Size = new System.Drawing.Size(100, 20);
            this.txttotaldepedidos.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PRODUCCION EN PROCESO";
            // 
            // txtproduccionenproceso
            // 
            this.txtproduccionenproceso.Location = new System.Drawing.Point(660, 220);
            this.txtproduccionenproceso.Name = "txtproduccionenproceso";
            this.txtproduccionenproceso.Size = new System.Drawing.Size(100, 20);
            this.txtproduccionenproceso.TabIndex = 8;
            // 
            // txtmodelomasvendido
            // 
            this.txtmodelomasvendido.FormattingEnabled = true;
            this.txtmodelomasvendido.Items.AddRange(new object[] {
            "SAMSUNG",
            "TOSHIBA",
            "LENOVO",
            "APPLE",
            "ACER",
            "DELL",
            "HP"});
            this.txtmodelomasvendido.Location = new System.Drawing.Point(650, 295);
            this.txtmodelomasvendido.Name = "txtmodelomasvendido";
            this.txtmodelomasvendido.Size = new System.Drawing.Size(121, 21);
            this.txtmodelomasvendido.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "MODELEO MAS VENDIDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "/ MODELO MENOS VENDIDO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "CANTIDAD DE PRODUCTO FINZALIZADO";
            // 
            // txtproductofinalizado
            // 
            this.txtproductofinalizado.Location = new System.Drawing.Point(660, 510);
            this.txtproductofinalizado.Name = "txtproductofinalizado";
            this.txtproductofinalizado.Size = new System.Drawing.Size(100, 20);
            this.txtproductofinalizado.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ERP.Properties.Resources.Alienware17R3__1_;
            this.pictureBox1.Location = new System.Drawing.Point(663, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 610);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtproductofinalizado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmodelomasvendido);
            this.Controls.Add(this.txtproduccionenproceso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttotaldepedidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpocomaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chartcomputadora);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartcomputadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartcomputadora;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpocomaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotaldepedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtproduccionenproceso;
        private System.Windows.Forms.ComboBox txtmodelomasvendido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtproductofinalizado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}