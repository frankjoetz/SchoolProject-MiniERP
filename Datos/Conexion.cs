using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using Datos.Properties;
using System.Data;

namespace Datos
{
    public class Conexion
    {
        public MySqlConnection conn;
        public string cadenadeconexion;
        public MySqlCommand cmd;
        //
        public Conexion()
        {
            this.cadenadeconexion = Settings.Default.erpdbConnectionString;
            conn = new MySqlConnection(cadenadeconexion);
        }
        public Boolean conectar() //abrir conexion
        {
            bool flag = false;
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                
            }
            return flag;
        }
        public Boolean Desconectar() //cerrar conexion
        {
            bool flag = false;
            try
            {
                conn.Close();
                if (conn.State == ConnectionState.Closed)
                {
                    flag = false;
                }
            }
            catch (Exception ex)
            {
                
            }
            return flag;
        }
    }
}
