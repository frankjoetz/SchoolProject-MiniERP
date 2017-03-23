using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using MySql.Data.MySqlClient;

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
        public string buscarUnDato(string columna, string tabla, string complemento)
        {
            return bd.buscar("select " + columna + " from " + tabla + " "+complemento,columna);
        }
        public DataSet cargarClientes(string query)
        {
            DataSet erpCli = new DataSet();
            try
            {
                conectar.conectar();
                MySqlDataAdapter daCliente = new MySqlDataAdapter(query, conectar.conn);
                daCliente.Fill(erpCli, "Cliente");
                conectar.conn.Close();
            }
            catch (Exception ex)
            {
                
            }
            return erpCli;
        }
    }
}
