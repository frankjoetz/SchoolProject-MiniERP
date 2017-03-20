using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    class Conexion
    {
        public SqlConnection conn;
        public string cadenadeconexion;
        public SqlCommand cmd;
        //
        public Conexion()
        {
            this.cadenadeconexion = "server=tics41.ddns.net;User Id=root;database=erpdb";
            conn = new SqlConnection(cadenadeconexion);
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
