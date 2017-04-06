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
        //Aqui se instancia un hilo de ejecucion para ejecutar acciones asincronas
        //Basicamente es para que la informacion se ingrese en tiempo real.
        Thread hilo1;

        /*Estos atributos son para alimentar la grafica, en los siguientes metodos se les
         asignaran valores*/
        double[] dataGamaBaja;
        double[] dataGamaMedia;
        double[] dataGamaAlta;
        string[] dataFechas;

        /**
         Obtiene la logica del dashboard
            que es lo necesario para obtener los datos de la base de datos*/
        LogicaDeNegocios.Dashboard.metodosDashboard dash = new LogicaDeNegocios.Dashboard.metodosDashboard();


        public Dashboard()
        {
            InitializeComponent();

        }

        private void chartcomputadora_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            actualizarChart();

            CheckForIllegalCrossThreadCalls = false;
            
        }

        /*Este metodo actualiza la grafica cada cierto tiempo, por cuestiones del sistema
         no se pudo implementar tiempo real en esta grafica, se actualiza por eventos
         */
        public void actualizarChart()
        {
            //Se obtienen los datos necesarios de la BD y se asignan a las variables
            dataGamaBaja = dash.getGamaBajaChart();
            dataGamaMedia = dash.getGamaMediaChart();
            dataGamaAlta = dash.getAltaChart();
            dataFechas = dash.getFechaChart();

            //Para limpiar la grafica para poder poner datos nuevos
            chartcomputadora.Series["Gama Baja"].Points.Clear();
            chartcomputadora.Series["Gama Media"].Points.Clear();
            chartcomputadora.Series["Gama Alta"].Points.Clear();

            //Aqui se agregan los datos a la gráfica
            //Por un problema de sistema con hilos no se pudieron implementar ciclos correctamente
            chartcomputadora.Series["Gama Baja"].Points.AddXY(dataFechas[4], dataGamaBaja[4]);
            chartcomputadora.Series["Gama Baja"].Points.AddXY(dataFechas[3], dataGamaBaja[3]);
            chartcomputadora.Series["Gama Baja"].Points.AddXY(dataFechas[2], dataGamaBaja[2]);
            chartcomputadora.Series["Gama Baja"].Points.AddXY(dataFechas[1], dataGamaBaja[1]);
            chartcomputadora.Series["Gama Baja"].Points.AddXY(dataFechas[0], dataGamaBaja[0]);

            chartcomputadora.Series["Gama Media"].Points.AddXY(dataFechas[4], dataGamaMedia[4]);
            chartcomputadora.Series["Gama Media"].Points.AddXY(dataFechas[3], dataGamaMedia[3]);
            chartcomputadora.Series["Gama Media"].Points.AddXY(dataFechas[2], dataGamaMedia[2]);
            chartcomputadora.Series["Gama Media"].Points.AddXY(dataFechas[1], dataGamaMedia[1]);
            chartcomputadora.Series["Gama Media"].Points.AddXY(dataFechas[0], dataGamaMedia[0]);

            chartcomputadora.Series["Gama Alta"].Points.AddXY(dataFechas[4], dataGamaAlta[4]);
            chartcomputadora.Series["Gama Alta"].Points.AddXY(dataFechas[3], dataGamaAlta[3]);
            chartcomputadora.Series["Gama Alta"].Points.AddXY(dataFechas[2], dataGamaAlta[2]);
            chartcomputadora.Series["Gama Alta"].Points.AddXY(dataFechas[1], dataGamaAlta[1]);
            chartcomputadora.Series["Gama Alta"].Points.AddXY(dataFechas[0], dataGamaAlta[0]);
            //Aqui termina de agregar los datos a la gráfica
        }

        //En este hilo se agregan en tiempo real los datos en los Textbox
        //Vienen directo de la base de datos asi que si se realiza un cambio
        //se vera reflejado instantaneamente
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
            //Para detener el hilo cuando se cierre el Dashboard
            hilo1.Abort();
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            actualizarChart();
            //Para iniciar el hilo y que ejecute en tiempo real
            this.hilo1 = new Thread(new ThreadStart(this.hiloTiempoReal));
            this.hilo1.Start();
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
