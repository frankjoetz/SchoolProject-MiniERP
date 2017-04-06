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
            string pocoMaterial = bd.retornarValor("select * from Stock_Materiales where StockActual <= StockMinimo", "idMateria");
            return pocoMaterial;
        }
    }
}
