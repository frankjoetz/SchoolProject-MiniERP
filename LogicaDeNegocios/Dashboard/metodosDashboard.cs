using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace LogicaDeNegocios.Dashboard
{
    public class metodosDashboard
    {
        Datos.BaseDeDatos bd = new Datos.BaseDeDatos();

        public string imprimirTotalPedidos()
        {
            string contPed = bd.retornarValor("select count(*) as conteo from Pedido", "conteo");
            return contPed;
        }

        public string imprimirProdEnProceso()
        {
            string contProd = bd.retornarValor("select count(*) as conteo from Produccion", "conteo");
            return contProd;
        }

        public string imprimirMasVendido()
        {
            string masVendido = bd.retornarValor("select * from Pedido order by CantGamaAlta DESC LIMIT 0, 1", "idPedido");
            return masVendido;
        }

        public string imprimirMenosVendido()
        {
            string menosVendido = bd.retornarValor("select * from Pedido order by CantGamaAlta ASC LIMIT 0, 1", "idPedido");
            return menosVendido;
        }

        public string imprimirPocoMaterial()
        {
            string pocoMaterial = bd.retornarValor("select * from Stock_Materiales where stockActual <= stockMinimo order by stockActual asc limit 1;", "descripcion");
            return pocoMaterial;
        }
        

        public string imprimirProdFinalizado()
        {
            string prod = bd.retornarValor("select count(*) as conteo from Planeacion where status = 'Finalizado'", "conteo");
            return prod;
        }

        public string[] getFechaChart()
        {
            return bd.retornarArreglo("Select Fecha from Vista_PedidosPlaneacion order by Fecha desc","Fecha");
        }

        public double[] getGamaBajaChart()
        {
            return bd.retornarArregloDouble("Select CantGamaBaja from Vista_PedidosPlaneacion order by Fecha desc", "CantGamaBaja");
        }
        public double[] getGamaMediaChart()
        {
            return bd.retornarArregloDouble("Select CantGamaMedia from Vista_PedidosPlaneacion order by Fecha desc", "CantGamaMedia");
        }
        public double[] getAltaChart()
        {
            return bd.retornarArregloDouble("Select CantGamaAlta from Vista_PedidosPlaneacion order by Fecha desc", "CantGamaAlta");
        }
    }
}
