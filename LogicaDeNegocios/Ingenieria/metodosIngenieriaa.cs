using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using MySql.Data.MySqlClient;

namespace LogicaDeNegocios
{
    public class metodosIngenieriaa
    {
        Conexion conectar = new Conexion();
        BaseDeDatos bd = new BaseDeDatos();

        public bool altaMateria(int idmateria,string tipo, string descrip, string fecha, int cantidad)
        {
            if (bd.insertar("insert into MateriaPrima(idMateria, Tipo, descripcion, Fecha, cantidad) values('" + idmateria + "','" + tipo + "', '" + descrip + "', '" + fecha + "', '" + cantidad + "')"))
                return true;
            else
                return false;
        }
        public bool altaProducto(int idCliente, string fecha)
        {
            if (bd.insertar("insert into Pedido(idCliente,fecha) values(" + idCliente + ",'" + fecha + "')"))
                return true;
            else
                return false;
        }
    }
}
