using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LogicaDeNegocios.Ventas
{
    public class metodosVentas
    {
        Conexion conectar = new Conexion();
        BaseDeDatos bd = new BaseDeDatos();

        public bool altaTabla(string tabla, string valoresAagregar)
        {
            if (bd.insertar("insert into "+tabla+" values("+valoresAagregar+")"))
                return true;
            else
                return false;
        }
        public bool actuTabla(string tabla, string set,string condicion)
        {
            if (bd.actualizar("update " + tabla + " set " + set +" "+ condicion))
                return true;
            else
                return false;
        }
        public bool bajasPedido(string query)
        {
            if (bd.eliminar(query))
                return true;
            else
                return false;
        }
        public string buscarUnDato(string columna, string tabla, string complemento)
        {
            return bd.buscar("select " + columna + " from " + tabla + " "+complemento,columna);
        }
        public DataSet cargarTablas(string query,string tabla)
        {
            DataSet erpTab = new DataSet();
            try
            {
                conectar.conectar();
                MySqlDataAdapter daCliente = new MySqlDataAdapter(query, conectar.conn);
                daCliente.Fill(erpTab, tabla);
                conectar.conn.Close();
                conectar.Desconectar();
            }
            catch (Exception ex)
            {

            }
            return erpTab;
        }
        public void comboBox(string consulta, string columna, ComboBox cbx)
        {
            bd.llenarComboBox(consulta, columna, cbx);
        }
    }
}
