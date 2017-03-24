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
        BaseDeDatos bd = new BaseDeDatos();

        public bool altaMateria(int idmateria,string tipo, string descrip, string fecha, int cantidad)
        {
            if (bd.insertar("insert into MateriaPrima(idMateria, Tipo, descripcion, Fecha, cantidad) values('" + idmateria + "','" + tipo + "', '" + descrip + "', '" + fecha + "', '" + cantidad + "')"))
                return true;
            else
                return false;
        }
        public bool altaProducto(int idProducto,string descripcion, int cantidad, int locacion, string fHora)
        {
            if (bd.insertar("insert into InventarioProducto(idProducto, descripcion, cantidad, locacion, fHora) values(" + idProducto + ",'"+descripcion+"','" + cantidad + "', '"+locacion+"','"+fHora+"')"))
                return true;
            else
                return false;
        }
        public bool EliminaMateria(int idmateria)
        {
            if (bd.eliminar("delete from MateriaPrima where idMateria=('"+idmateria+"')"))
                return true;
            else
                return false;
        }
    }
}
