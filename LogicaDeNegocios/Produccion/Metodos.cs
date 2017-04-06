using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;

namespace LogicaDeNegocios.Produccion
{
    public class Metodos
    {
        BaseDeDatos bd = new BaseDeDatos(); // Instancia de la base de datos

        // ◘◘◘◘◘◘◘ Métodos esclusivos para tab 1 ("Agregar producción") ◘◘◘◘◘◘◘

        public void ActualizarPlaneaciones(DataGridView tablaPlaneacion)
        { // Método para actualizar planeaciones en tab 1
            bd.llenarTabla("select * from Vista_PlaneacionesAProducir where Status='Listo para producir'", tablaPlaneacion);
        }

        public void FiltrarPlaneacion(ComboBox columna, TextBox valor, DataGridView tabla)
        { // Método para filtrar planeaciones dependiendo del tipo
            bd.llenarTabla("select * from Vista_PlaneacionesAProducir where " + columna.Text + " like '%" + valor.Text + "%' and Status='Listo para producir'", tabla);
        }

        public void LlenarDetallesPlaneacion(DataGridView tabla, TextBox idPlaneacion, TextBox linea, DateTimePicker inicio, DateTimePicker estimada, Label tiempo)
        { // Método para llenar automáticamente los controles
            idPlaneacion.Text = RetornarValor(tabla, "IdPlaneacion");
            linea.Text = GetLinea(linea, tabla);
            MostrarTiempo(inicio, estimada, tiempo, tabla);
        }

        private string GetLinea(TextBox linea, DataGridView tabla)
        { // Método para convertir descripción de gama en linea a producir
            switch (RetornarValor(tabla, "tipo"))
            {
                case "Gama baja": return "1";
                case "Gama media": return "2";
                case "Gama alta": return "3";
                default: return "0";
            }
        }

        public void MostrarTiempo(DateTimePicker inicio, DateTimePicker estimada, Label tiempo, DataGridView tabla)
        { // Método para editar label, dtp y calcular tiempo
            DateTime fechaInicio = inicio.Value;
            float cantidad = float.Parse(RetornarValor(tabla, "Cantidad"));
            float resultado = cantidad / 60;
            estimada.Value = fechaInicio.AddDays(resultado);
            string mensaje = "Se producen 60 computadoras diarias, sus " + cantidad + " computadoras se producirán en aproximadamente " + resultado + " días. \n";
            tiempo.Text = mensaje;
        }

        public void MostrarDetallePlaneacion(Label detalle, DataGridView tabla)
        { // Método para editar el label y mostrar información de la producción
            string mensaje = "Se producirán " + RetornarValor(tabla, "Cantidad") + " ordenadores de " + RetornarValor(tabla, "Tipo");
            detalle.Text = mensaje;
        }

        public void InsertarProduccion(DataGridView tabla, DateTimePicker inicio, DateTimePicker estimada, RichTextBox observaciones)
        { // Método para agregar registro de producción
            string ip = RetornarValor(tabla, "idPlaneacion"); // Id de planeación
            string fi = inicio.Value.ToString("yyyy-MM-dd"); // Fecha de inicio
            string li = GetLinea(new TextBox(), tabla); // Linea de producción
            string ff = estimada.Value.ToString("yyyy-MM-dd"); // Fecha estimada
            string ob = observaciones.Text; 
            string query = String.Format("INSERT INTO Produccion VALUES (NULL, '{0}', '{1}', '{2}', '1', '{3}', '{4}')", ip, fi, li, ff, ob);
            if (bd.insertar(query))
            {
                EditarStatusPlaneacion(ip);
                MessageBox.Show("La planeación se ha puesto en producción correctamente :)\n", "Producción en marcha", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Ocurrió un error agregando esta producción. :(", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void EditarStatusPlaneacion(string idPlaneacion)
        { // Método para Editar el estado de la planeación
            string consulta = "update Planeacion set status='En proceso' where idPlaneacion=" + idPlaneacion;
            bd.actualizar(consulta);
        }

        // ◘◘◘◘◘ Métodos esclusivos para tab 2 ("Administrar producción") ◘◘◘◘◘

        public void ActualizarProducciones(DataGridView tabla)
        { // Método para actualizar producciones en tab 2
            bd.llenarTabla("select * from Vista_ProduccionesOverview where Etapa != 8", tabla);
        }

        public void LlenarDetallesProduccion(Label etapa, ProgressBar barra, DataGridView tabla)
        { // Método para llenar detalles y progreso de una producción
            string et = RetornarValor(tabla, "Etapa");
            string descripcion = bd.retornarValor("select * from Etapas where Id=" + et, "Detalle");
            etapa.Text = descripcion;
            barra.Value = int.Parse(et);
        }

        public bool CancelarProduccion(DataGridView tabla)
        { // Método para actualizar planeación y eliminar producción
            string idPl = RetornarValor(tabla, "idPlaneacion");
            string idPr = RetornarValor(tabla, "idProduccion");

            if (bd.actualizar("update Planeacion set status='Listo para producir' where idPlaneacion=" + idPl))
                if (bd.eliminar("delete from Produccion where idProduccion=" + idPr))
                    return true;
                else
                    return false;
            else
                return false;
        }

        public bool AvanzarEtapa(DataGridView tabla)
        { // Método para avanzar etapa y validar si se llegó a la 8
            int etapa = int.Parse(RetornarValor(tabla, "Etapa")) + 1;
            string id = RetornarValor(tabla, "idProduccion");
            bd.actualizar("update Produccion set Etapa=" + etapa + " where idProduccion=" + id);
            if (etapa == 7)
                return true;
            else
                return false;
        }

        public bool RetrocederEtapa(DataGridView tabla)
        { // Método para retroceder etapa y validar si se llegó a 1
            int etapa = int.Parse(RetornarValor(tabla, "Etapa")) - 1;
            string id = RetornarValor(tabla, "idProduccion");
            bd.actualizar("update Produccion set Etapa=" + etapa + " where idProduccion=" + id);
            if (etapa == 1)
                return true;
            else
                return false;
        }

        // ◘◘◘◘◘ Métodos para tab 3 - Entregar pedido ◘◘◘◘◘

        public void ActualizarPedidos(DataGridView tabla)
        { // Actualiza la lista de pedidos
            bd.llenarTabla("select * from Pedido where Status = 'En proceso'", tabla);
        }

        public bool ActualizarProduccionesCorrespondientes(DataGridView tablaPedido, DataGridView tablaProducciones, Label infoPedido)
        {
            string idPedido = tablaPedido.SelectedRows[0].Cells["idPedido"].Value.ToString();
            int cantGB = int.Parse(tablaPedido.SelectedRows[0].Cells["cantGamaBaja"].Value.ToString());
            int cantGM = int.Parse(tablaPedido.SelectedRows[0].Cells["cantGamaMedia"].Value.ToString());
            int cantGA = int.Parse(tablaPedido.SelectedRows[0].Cells["cantGamaAlta"].Value.ToString());
            int total = 0;
            if (cantGB != 0)
                total++;
            if (cantGM != 0)
                total++;
            if (cantGA != 0)
                total++;
            bd.llenarTabla("select idPedido, nombre, empresa, idProduccion, tipo, cantidad, Etapa from Vista_ProduccionesOverview where Etapa=8 AND idPedido=" + idPedido, tablaProducciones);
            int producido = tablaProducciones.RowCount;
            if (total == producido)
            {
                infoPedido.Text = "Pedido terminado, esperando entrega.";
                MessageBox.Show("Se ha/n producido la/s " + producido + " de " + total + " gama/s que el pedido solicitó. \nAhora se puede realizar la entrega, presione Entregar", "Producción finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                infoPedido.Text = producido + " de " + total + " gamas producidas.";
                MessageBox.Show("Al parecer aún falta/n " + (total - producido) + " de la/s " + total + " gama/s que el cliente ordenó. \nFinalice la producción para poder entregar.", "Pedido no terminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public void EntregarPedido(DataGridView tabla)
        {
            int idPedido = int.Parse(tabla.SelectedRows[0].Cells["idPedido"].Value.ToString());
            int idPlaneacion = int.Parse(tabla.SelectedRows[0].Cells["idPedido"].Value.ToString());
            bd.actualizar("update Pedido set Status='Entregado' where idPedido=" + idPedido);
            bd.actualizar("update Planeacion set status='Finalizado' where idPedido=" + idPedido);
            
        }

        // ◘◘◘◘◘ Métodos generales y esclusivos ◘◘◘◘◘

        private string RetornarValor(DataGridView tabla, string columna)
        { // Método para retornar el valor de la columna de una fila seleccionada
            DataGridViewRow fila = tabla.SelectedRows[0];
            return fila.Cells[columna].Value.ToString();
        }
    }
}
