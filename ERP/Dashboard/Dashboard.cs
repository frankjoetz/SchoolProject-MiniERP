using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ERP.Dashboard
{
    public partial class Dashboard : Form
    {
        Thread hilo1;
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
            double[] dataGamaBaja = dash.getGamaBajaChart();
            double[] dataGamaMedia = dash.getGamaMediaChart();
            double[] dataGamaAlta = dash.getAltaChart();
            string[] dataFechas = dash.getFechaChart();

            chartcomputadora.Series.Clear();
            chartcomputadora.Series.Add("Gama Baja");
            chartcomputadora.Series.Add("Gama Media");
            chartcomputadora.Series.Add("Gama Alta");

            chartcomputadora.Series["Gama Baja"].Color = Color.Brown;
            chartcomputadora.Series["Gama Baja"].ChartType = SeriesChartType.Line;
            chartcomputadora.Series["Gama Media"].Color = Color.Red;
            chartcomputadora.Series["Gama Media"].ChartType = SeriesChartType.Line;
            chartcomputadora.Series["Gama Alta"].Color = Color.Blue;
            chartcomputadora.Series["Gama Alta"].ChartType = SeriesChartType.Line;

            chartcomputadora.Series["Gama Baja"].Points.DataBindY(dataGamaBaja);

            CheckForIllegalCrossThreadCalls = false;
            
        }

        public void hiloTiempoReal()
        {
            while (true)
            {
                txttotaldepedidos.Text = dash.imprimirTotalPedidos();
                txtproduccionenproceso.Text = dash.imprimirProdEnProceso();
                txtmasvendido.Text = dash.imprimirMasVendido();
                txtmenosvendido.Text = dash.imprimirMenosVendido();
                txtpocomaterial.Text = dash.imprimirPocoMaterial();
                txtproductofinalizado.Text = dash.imprimirProdFinalizado();
                Thread.Sleep(1000);
            }
            
        }

        private void Dashboard_Deactivate(object sender, EventArgs e)
        {
            hilo1.Abort();
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            this.hilo1 = new Thread(new ThreadStart(this.hiloTiempoReal));
            this.hilo1.Start();
        }
    }
}
