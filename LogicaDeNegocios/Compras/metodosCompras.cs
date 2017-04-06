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

        public void llenarGridViewAlertas(DataGridView alertas)
        {
            bd.llenarTabla("select * from Alertas  where Status='No confirmado' order by IdAlerta desc", alertas);
        }

        public void llenarDrigViewMaterial(DataGridView materiales)
        {
            bd.llenarTabla("select * from Stock_Materiales order by idMateria asc", materiales);
        }
            
        public bool altaLocacion(string descripcion, string FechaCreacion)
        {
            if (bd.insertar("insert into Locacion(descripcion, fCreada) values('" + descripcion + "', '" + FechaCreacion + "'" + ")"))
                return true;
            else
                return false;
        }

        public bool moverStock(string id, string cantidad)
        {
            if (bd.actualizar("update InventarioMateria set StockActual='" + cantidad + "' where idMateria='" + id + "'"))
                return true;
            else
                return false;
        }

        public bool modificarAlerta(string id)
        {
            if(bd.actualizar("update Alertas set Status = 'Confirmado' where IdAlerta = '" + id +"'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
