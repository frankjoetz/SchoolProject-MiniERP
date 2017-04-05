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

        public void LlenarTablaPlaneaciones(DataGridView tablaPlaneacion)
        {
            bd.llenarTabla("select * from Vista_PlaneacionesAProducir where Status='Listo para producir'", tablaPlaneacion);
        }

        public void Buscar(ComboBox columna, TextBox valor, DataGridView tabla)
        {
            string consulta = "select * from Vista_PlaneacionesAProducir where " + columna.Text + " like '%" + valor.Text + "%'";
            bd.llenarTabla(consulta, tabla);
        }

        public void LlenarDetalles(DataGridView tabla, TextBox cantidad)
        {
            cantidad.Text = retornarValor(tabla, "IdPlaneacion");
        }

        private string retornarValor(DataGridView tabla, string columna)
        {
            DataGridViewRow fila = tabla.SelectedRows[0];
            return fila.Cells[columna].Value.ToString();
        }
    }
}
