using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using MySql.Data.MySqlClient;

namespace LogicaDeNegocios.Compras
{
    public class metodosCompras
    {
        Datos.BaseDeDatos bd = new Datos.BaseDeDatos();

        public void llenarGridViewLocacion(DataGridView locacion)
        {
            bd.llenarTabla("select * from Locacion order by idLocacion asc", locacion);
        }

        public void llenarGridViewCaptura(DataGridView material)
        {
            bd.llenarTabla("select * from InventarioMateria order by nFolio asc", material);
        }

        public bool altaLocacion(int Idlocacion, string descripcion, string FechaCreacion)
        {
            if (bd.insertar("insert into Locacion(idLocacion, descripcion, fCreada) values('" + Idlocacion + "', '" + descripcion + "', '" + FechaCreacion + "'" + ")"))
                return true;
            else
                return false;
        }
    }
}
