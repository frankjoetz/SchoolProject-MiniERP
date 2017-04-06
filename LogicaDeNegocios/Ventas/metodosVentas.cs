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
            bool alta = false;
            try
            {
                if (bd.insertar("insert into "+tabla+" values("+valoresAagregar+")"))
                return true;
            else
                return false;
            }
            catch { }
            return alta;
        }
        public bool actuTabla(string tabla, string set,string condicion)
        {
            bool actu = false;
            try
            {
                if (bd.actualizar("update " + tabla + " set " + set +" "+ condicion))
                return true;
            else
                return false;
            }
            catch { }
            return actu;
        }
        public bool bajasPedido(string query)
        {
            bool bajas = false;
            try
            {
                if (bd.eliminar(query))
                return true;
            else
                return false;
            }
            catch { }
            return bajas;
        }
        public string buscarUnDato(string columna, string tabla, string complemento)
        {
            string buscar = "";
            try
            {
                buscar= bd.buscar("select " + columna + " from " + tabla + " "+complemento,columna);
            }
            catch {}
            return buscar;
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
            catch (Exception)
            {

            }
            return erpTab;
        }
        public void comboBox(string query, string columna, ComboBox cmb)
        {
            bd.llenarComboBox(query, columna, cmb);
        }
    }
}
