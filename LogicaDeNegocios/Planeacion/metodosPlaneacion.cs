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
        Datos.BaseDeDatos bd = new Datos.BaseDeDatos();

        public bool insertarNuevaPlaneacion(string idPedido, string fInicio, string fEntrega, string status, string observaciones)
        {
            if (bd.insertar("insert into Planeacion values(NULL, '" + idPedido + "', '" + fInicio + "', '" + fEntrega + "', '" + status + "', '" + observaciones + "')"))
                return true;
            else
                return false;
        }

        public void llenarGridViewPlaneacion(DataGridView DGVPlaneacion)
        {
            bd.llenarTabla("select * from Planeacion order by idPlaneacion DESC", DGVPlaneacion);
        }
    }
}
