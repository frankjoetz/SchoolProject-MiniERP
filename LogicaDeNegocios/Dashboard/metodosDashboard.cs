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
        //Se crea este objeto para hacer consulta a la BD
        Datos.BaseDeDatos bd = new Datos.BaseDeDatos();

        //Este metodo se utiliza para imprimir el total de pedidos
        public string imprimirTotalPedidos()
        {
            string contPed = bd.retornarValor("select count(*) as conteo from Pedido", "conteo");
            return contPed;
        }

        //Este metodo se utiliza para imprimir las producciones que estan en proceso
        public string imprimirProdEnProceso()
        {
            string contProd = bd.retornarValor("select count(*) as conteo from Produccion", "conteo");
            return contProd;
        }

        //Este metodo se utiliza para imprimir el articulo mas vendido con el id de Pedido
        //La base de datos esta un poco mal relacionada y no se pudo obtener el nombre del producto
        //Solo el idPedido de la tabla Pedido
        public string imprimirMasVendido()
        {
            string masVendido = bd.retornarValor("select * from Pedido order by CantGamaAlta DESC LIMIT 0, 1", "idPedido");
            return masVendido;
        }

        //Este metodo se utiliza para imprimir el articulo menos vendido con el id de Pedido
        //La base de datos esta un poco mal relacionada y no se pudo obtener el nombre del producto
        //Solo el idPedido de la tabla Pedido
        public string imprimirMenosVendido()
        {
            string menosVendido = bd.retornarValor("select * from Pedido order by CantGamaAlta ASC LIMIT 0, 1", "idPedido");
            return menosVendido;
        }

        //Este metodo permite imprimir aquel material que esta pronto a acabarse
        public string imprimirPocoMaterial()
        {
            string pocoMaterial = bd.retornarValor("select * from Stock_Materiales where stockActual <= stockMinimo order by stockActual asc limit 1;", "descripcion");
            return pocoMaterial;
        }
        
        //Permite imprimir cuatas producciones han sido finalizadas exitosamente
        public string imprimirProdFinalizado()
        {
            string prod = bd.retornarValor("select count(*) as conteo from Planeacion where status = 'Finalizado'", "conteo");
            return prod;
        }

        //Obtiene datos de fecha para llenar la grafica
        public string[] getFechaChart()
        {
            return bd.retornarArreglo("Select date(Fecha) as fecha from Vista_PedidosPlaneacion order by Fecha desc","fecha");
        }

        //Obtiene datos de compus de gama baja para llenar la grafica
        public double[] getGamaBajaChart()
        {
            return bd.retornarArregloDouble("Select CantGamaBaja from Vista_PedidosPlaneacion order by Fecha desc", "CantGamaBaja");
        }

        //Obtiene datos de compus de gama media para llenar la grafica
        public double[] getGamaMediaChart()
        {
            return bd.retornarArregloDouble("Select CantGamaMedia from Vista_PedidosPlaneacion order by Fecha desc", "CantGamaMedia");
        }

        //Obtiene datos de compus de gama alta para llenar la grafica
        public double[] getAltaChart()
        {
            return bd.retornarArregloDouble("Select CantGamaAlta from Vista_PedidosPlaneacion order by Fecha desc", "CantGamaAlta");
        }
    }
}
