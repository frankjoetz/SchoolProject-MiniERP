using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;

namespace LogicaDeNegocios.Produccion
{
    public class metodosProduccion
    {
        Datos.BaseDeDatos bd = new Datos.BaseDeDatos();

        public bool insertarProduccion(string idPlaneacion, string fechaInicio, string etapa, string fechaEntrega, string observaciones)
        {
            if (bd.insertar("insert into Produccion values(NULL, '" + idPlaneacion + "', '" + fechaInicio + "', '" + etapa + "', '" + fechaEntrega + "', '" + observaciones + "')"))
                return true;
            else
                return false;
        }

        public void llenarTablaProduccion(DataGridView tablaProduccion)
        {
            bd.llenarTabla("select * from Produccion order by idProduccion DESC", tablaProduccion);
        }

        public void llenarTablaPlaneaciones(DataGridView tablaPlaneacion)
        {
            bd.llenarTabla("select * from Vista_PlaneacionesAProducir", tablaPlaneacion);
        }

        public void filtrarTablaPlaneacion(TextBox texto, DataGridView tablaPlaneacion)
        {
        }
    }
}
