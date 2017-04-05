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
        Datos.BaseDeDatos datos = new Datos.BaseDeDatos();

        //llenar datagridview con datos de pedidos y clientes
        public void LlenarTablaVistaPedidos(DataGridView GridPedidos)
        {
            datos.llenarTabla("select * from Vista_PedidosPlaneacion where Status='En proceso'", GridPedidos);
        }

        // metodo para el buscador
        public void Buscarid(TextBox txtBuscar, DataGridView tabla)
        {
            string consulta = "select * from Vista_PedidosPlaneacion where Status='En proceso' and idPedido  like '%" + int.Parse(txtBuscar.Text) + "%'";
            datos.llenarTabla(consulta, tabla);
        }

        // llenar planeaciones
        public void llenarPlaneaciones(DataGridView GridPlaneaciones)
        {
            datos.llenarTabla("select * from Planeacion", GridPlaneaciones);
        }

        // Mandar alerta
       
        //insertar planeacion
        public void InsertarPlaneacionAlta(TextBox idPedido, TextBox Cantidad, TextBox fInicio, DateTimePicker fEntregar, TextBox status, TextBox Observaciones)
        { // Método para agregar planeacion
            string id = idPedido.Text;
            string ti = "Gama alta";
            string ca = Cantidad.Text;
            string fi = fInicio.Text;
            string ff = fEntregar.Value.ToString("yyyy-MM-dd"); // Fecha estimada
            string st = status.Text;
            string ob = Observaciones.Text;
            string query = String.Format("INSERT INTO Planeacion VALUES (NULL, '{0}', '{1}', '{2}', '1', '{3}', '{4}', '{5}', '{6}')", id, ti ,ca,fi,ff,st, ob);
            if (datos.insertar(query))
            {
                MessageBox.Show("Planeacion Agregada");
            }
            else
                MessageBox.Show("error 404 not found. :(", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void InsertarPlaneacionMedia(TextBox idPedido, TextBox Cantidad, TextBox fInicio, DateTimePicker fEntregar, TextBox status, TextBox Observaciones)
        { // Método para agregar planeacion
            string id = idPedido.Text;
            string ti = "Gama media";
            string ca = Cantidad.Text;
            string fi = fInicio.Text;
            string ff = fEntregar.Value.ToString("yyyy-MM-dd"); // Fecha estimada
            string st = status.Text;
            string ob = Observaciones.Text;
            string query = String.Format("INSERT INTO Planeacion VALUES (NULL, '{0}', '{1}', '{2}', '1', '{3}', '{4}', '{5}', '{6}')", id, ti, ca, fi, ff, st, ob);
            if (datos.insertar(query))
            {
                MessageBox.Show("Planeacion Agregada");
            }
            else
                MessageBox.Show("error 404 not found. :(", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void InsertarPlaneacionBaja(TextBox idPedido, TextBox Cantidad, TextBox fInicio, DateTimePicker fEntregar, TextBox status, TextBox Observaciones)
        { // Método para agregar planeacion
            string id = idPedido.Text;
            string ti = "Gama baja";
            string ca = Cantidad.Text;
            string fi = fInicio.Text;
            string ff = fEntregar.Value.ToString("yyyy-MM-dd"); // Fecha estimada
            string st = status.Text;
            string ob = Observaciones.Text;
            string query = String.Format("INSERT INTO Planeacion VALUES (NULL, '{0}', '{1}', '{2}', '1', '{3}', '{4}', '{5}', '{6}')", id, ti, ca, fi, ff, st, ob);
            if (datos.insertar(query))
            {
                MessageBox.Show("Planeacion Agregada");
            }
            else
                MessageBox.Show("error 404 not found. :(", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        



    }
}
