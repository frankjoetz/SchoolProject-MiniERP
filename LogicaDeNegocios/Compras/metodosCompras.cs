using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaDeNegocios.Compras
{
    public class metodosCompras
    {
        Datos.BaseDeDatos bd = new Datos.BaseDeDatos();

        public void llenarGridViewLocacion(DataGridView locacion)
        {
            bd.llenarTabla("select * from Locacion order by idLocacion asc", locacion);
        }
    }
}
