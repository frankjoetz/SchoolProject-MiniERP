using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;

namespace LogicaDeNegocios.Produccion
{
    public class AgregarProduccion
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

        public void LlenarDetalles(DataGridView tabla, TextBox idPlaneacion, TextBox linea, DateTimePicker inicio, DateTimePicker estimada, Label tiempo)
        {
            idPlaneacion.Text = RetornarValor(tabla, "IdPlaneacion");
            linea.Text = getLinea(linea, tabla);
            MostrarTiempo(inicio, estimada, tiempo, tabla);
        }

        

        private string getLinea(TextBox linea, DataGridView tabla)
        {
            string gama = RetornarValor(tabla, "tipo");
            switch (gama)
            {
                case "Gama baja": return "1";
                case "Gama media": return "2";
                case "Gama alta": return "3";
                default: return "0";
            }
        }

        public void mostrarDetalle(Label detalle, DataGridView tabla)
        {
            string mensaje = "Se producirán " + RetornarValor(tabla, "Cantidad") + " ordenadores de " + RetornarValor(tabla, "Tipo");
            detalle.Text = mensaje;
        }

        public void MostrarTiempo(DateTimePicker inicio, DateTimePicker estimada, Label tiempo, DataGridView tabla)
        {
            DateTime fechaInicio = inicio.Value;
            
            float cantidad = float.Parse(RetornarValor(tabla, "Cantidad"));
            float resultado = cantidad / 60;
            estimada.Value = fechaInicio.AddDays(resultado);

            string mensaje = "Se producen 60 computadoras diarias, sus " + cantidad + " computadoras se producirán en aproximadamente " + resultado + " días. \n";
            tiempo.Text = mensaje;
            
        }

        public void InsertarProduccion(DataGridView tabla, DateTimePicker inicio, DateTimePicker estimada, RichTextBox observaciones)
        {
            string ip = RetornarValor(tabla, "idPlaneacion");
            string fi = inicio.Value.ToString("yyyy-MM-dd");
            string li = getLinea(new TextBox(), tabla);
            string ff = estimada.Value.ToString("yyyy-MM-dd");
            string ob = observaciones.Text;
            string query = String.Format("INSERT INTO Produccion VALUES (NULL, '{0}', '{1}', '{2}', '1', '{3}', '{4}')", ip, fi, li, ff, ob);
            if (bd.insertar(query))
            {
                editarStatusPlaneacion(ip);
                MessageBox.Show("La planeación se ha puesto en producción correctamente :)\n", "Producción en marcha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
                MessageBox.Show("Ocurrió un error agregando esta producción. :(", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void editarStatusPlaneacion(string idPlaneacion)
        {
            string consulta = "update Planeacion set status='En proceso' where idPlaneacion=" + idPlaneacion;
            bd.actualizar(consulta);
        }
        
        private string RetornarValor(DataGridView tabla, string columna)
        {
            DataGridViewRow fila = tabla.SelectedRows[0];
            return fila.Cells[columna].Value.ToString();
        }

    }
}
