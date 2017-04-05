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
        public void LlenarTablaVistaPedidos(DataGridView GridPedidos)
        {
            datos.llenarTabla("select * from Vista_PedidosPlaneacion where Status='En proceso'", GridPedidos);
        }

        // metodo para el buscador
        public void Buscarid(TextBox txtBuscar, DataGridView tabla)
        {
            string consulta = "select * from Vista_PedidosPlaneacion where Status='En proceso' and idPedido  like '%" + int.Parse(txtBuscar.Text) + "%'";
            datos.llenarTabla(consulta, tabla);
        }

        // llenar planeaciones
        public void llenarPlaneaciones(DataGridView GridPlaneaciones)
        {
            datos.llenarTabla("select * from Planeacion", GridPlaneaciones);
        }

        // Mandar alerta
       
        

        



    }
}
