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
            datos.llenarTabla("select * from Planeacion where status='Listo para producir'", GridPlaneaciones);
        }

        // Mandar alerta
       
        //insertar planeacion
        public void InsertarPlaneacionAlta(TextBox idPedido, TextBox Cantidad, DateTimePicker fInicio, DateTimePicker fEntregar, TextBox status, TextBox Observaciones)
        { // Método para agregar planeacion
            string id = idPedido.Text;
            string ti = "Gama alta";
            string caa = Cantidad.Text;
            string fi = fInicio.Value.ToString("yyyy-MM-dd");
            string ff = fEntregar.Value.ToString("yyyy-MM-dd"); // Fecha estimada
            string st = status.Text;
            string ob = Observaciones.Text;
            string query = String.Format("INSERT INTO Planeacion VALUES (NULL, '{0}', '{1}', '{2}','{3}', '{4}', '{5}', '{6}')", id, ti, caa, fi, ff, st, ob);
            if (datos.insertar(query))
            {
                MessageBox.Show("Planeacion de " + caa + " computadoras de gama alta agregadas a planeacion");
            }
            else
                MessageBox.Show("error 404 not found. :(", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void InsertarPlaneacionMedia(TextBox idPedido, TextBox Cantidad, DateTimePicker fInicio, DateTimePicker fEntregar, TextBox status, TextBox Observaciones)
        { // Método para agregar planeacion
            string id = idPedido.Text;
            string ti = "Gama media";
            string cam = Cantidad.Text;
            string fi = fInicio.Value.ToString("yyyy-MM-dd");
            string ff = fEntregar.Value.ToString("yyyy-MM-dd"); // Fecha estimada
            string st = status.Text;
            string ob = Observaciones.Text;
            string query = String.Format("INSERT INTO Planeacion VALUES (NULL, '{0}', '{1}', '{2}','{3}', '{4}', '{5}', '{6}')", id, ti, cam, fi, ff, st, ob);
            if (datos.insertar(query))
            {
                MessageBox.Show("Planeacion de " + cam + " computadoras de gama media agregadas a planeacion");
            }
            else
                MessageBox.Show("error 404 not found. :(", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void InsertarPlaneacionBaja(TextBox idPedido, TextBox Cantidad, DateTimePicker fInicio, DateTimePicker fEntregar, TextBox status, TextBox Observaciones)
        { // Método para agregar planeacion
            string id = idPedido.Text;
            string ti = "Gama baja";
            string cab = Cantidad.Text;
            string fi = fInicio.Value.ToString("yyyy-MM-dd");
            string ff = fEntregar.Value.ToString("yyyy-MM-dd"); // Fecha estimada
            string st = status.Text;
            string ob = Observaciones.Text;
            string query = String.Format("INSERT INTO Planeacion VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", id, ti, cab, fi, ff, st, ob);
            if (datos.insertar(query))
            {
                MessageBox.Show("Planeacion de " + cab + " computadoras de gama baja agregadas a planeacion");
            }
            else
                MessageBox.Show("error 404 not found. :(", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        

        // Metodo para enviar alerta

        public void MandarAlerta(TextBox mensaje)
        {
            string msg = mensaje.Text;
            string query = String.Format("INSERT INTO Alertas(Mensaje) VALUES ('{0}')", msg);
            if (datos.insertar(query))
            {
                MessageBox.Show("Se envio alerta correctamente");
                
 
            }
            else
                MessageBox.Show("Oops algo salio mal", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


    }
}
 