using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;

namespace LogicaDeNegocios.Planeacion
{
    public class metodosPlaneacion
    {
        Datos.BaseDeDatos datos = new Datos.BaseDeDatos();

        //llenar datagridview con datos de pedidos y clientes
        public void llenarTablaPedidos(DataGridView GridPedidos)
        {
            datos.llenarTabla("select * from Vista_PedidosPlaneacion where Status='En proceso'", GridPedidos);
        }

        //metodos para el buscador

        //por idPedido

        public void BuscarIdPedido(DataGridView GridPedidos, TextBox txtBuscar)
        {
            datos.llenarTabla("select * from Vista_PedidosPlaneacion where idPedido='" + txtBuscar.Text + "'", GridPedidos);
        }



    }
}
