using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios.Dashboard
{
    public class metodosDashboard
    {
        Datos.BaseDeDatos bd = new Datos.BaseDeDatos();

        public string imprimirAdvertencias()
        {
            string contPed = bd.retornarValor("select count(*) as conteo from Pedido", "conteo");
            return contPed;
        }

        public string imprimirProdEnProceso()
        {
            string contProd = bd.retornarValor("select count(*) as conteo from Produccion", "conteo");
            return contProd;
        }
    }
}
