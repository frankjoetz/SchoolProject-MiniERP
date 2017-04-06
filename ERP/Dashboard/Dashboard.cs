using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ERP.Dashboard
{
    public partial class Dashboard : Form
    {
        LogicaDeNegocios.Dashboard.metodosDashboard dash = new LogicaDeNegocios.Dashboard.metodosDashboard();

        public Dashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void chartcomputadora_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string[] series = { "Juan", "Roberto", "Alex" };
            int[] puntos = { 34, 56, 23 };
            chartcomputadora.Palette = ChartColorPalette.Pastel;
            chartcomputadora.Titles.Add("Veces que han hecho commit sin saber que pedo");

            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chartcomputadora.Series.Add(series[i]);
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }

            txttotaldepedidos.Text = dash.imprimirTotalPedidos();
            txtproduccionenproceso.Text = dash.imprimirProdEnProceso();
            txtmasvendido.Text = dash.imprimirMasVendido();
            txtmenosvendido.Text = dash.imprimirMenosVendido();
            txtpocomaterial.Text = dash.imprimirPocoMaterial();
        }
    }
}
