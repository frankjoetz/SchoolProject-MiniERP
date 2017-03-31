using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LogicaDeNegocios.Ventas
{
    public class metodosVentas
    {
        Conexion conectar = new Conexion();
        BaseDeDatos bd = new BaseDeDatos();

        public bool altaCliente(string nombre, string apellidos, string empresa, int telefono, string direccion, string email, int status)
        {
            if (bd.insertar("insert into Clientes(nombre,apellidos,empresa,telefono,direccion,email,statusCliente) values('" + nombre + "', '" + apellidos + "', '" + empresa + "', " + telefono + ",'"+direccion+"','"+email+"',"+status+")"))
                return true;
            else
                return false;
        }
        public bool altaPedido(int idCliente, string fecha)
        {
            if (bd.insertar("insert into Pedido(idCliente,fecha) values(" + idCliente + ",'" + fecha + "')"))
                return true;
            else
                return false;
        }
        public bool altaDetallesPedido(int idPedido,int idProducto, int cantidad, string observacion)
        {
            if (bd.insertar("insert into DetallePedido(idpedido,idproducto,cantidad,detallepedido) values("+idPedido+","+ idProducto + ","+cantidad+",'" + observacion + "')"))
                return true;
            else
                return false;
        }
        public bool altaPedidoFinal(int idPedido,string fecha,string detalles)
        {
            if (bd.insertar("insert into PedidoFinal(idpedido,fechaT,detalles) values(" + idPedido + ",'" + fecha + "','"+detalles+"')"))
                return true;
            else
                return false;
        }
        public bool bajasPedido(string query)
        {
            if (bd.eliminar(query))
                return true;
            else
                return false;
        }
        public string buscarUnDato(string columna, string tabla, string complemento)
        {
            return bd.buscar("select " + columna + " from " + tabla + " "+complemento,columna);
        }
        public DataSet cargarTablas(string query,string tabla)
        {
            DataSet erpTab = new DataSet();
            try
            {
                conectar.conectar();
                MySqlDataAdapter daCliente = new MySqlDataAdapter(query, conectar.conn);
                daCliente.Fill(erpTab, tabla);
                conectar.conn.Close();
                conectar.Desconectar();
            }
            catch (Exception ex)
            {

            }
            return erpTab;
        }
        public void comboBox(string consulta, string columna, ComboBox cbx)
        {
            bd.llenarComboBox(consulta, columna, cbx);
        }
    }
}
