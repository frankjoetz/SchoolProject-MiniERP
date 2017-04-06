using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient; // Incluir cliente MySQL
using Datos.Properties; // Será utilizado para acceder a la cadena de conexión
using System.Windows.Forms;
using System.Data;

namespace Datos
{
    public class BaseDeDatos
    {
        //// Atributo conexión almacenará la conexión a la BD.
        //private MySqlConnection conexion;
        // Atributo que almacenará temporalmente el query en cada método.
        private MySqlCommand comandoLocal;
        Conexion conexion;


        public BaseDeDatos() // Constructor establecerá conexión
        {
            // Se carga la cadena y se asigna la conexión
            try
            {
                conexion = new Conexion();
            }
            catch (Exception)
            {
                throw;
            }
        }


        private bool ejecutarConsulta(string sqlQuery)
        {
            conexion.conectar(); // Se abre la conexión
            // Se manda como primer parametro la consulta recibida (sqlQuery)
            comandoLocal = new MySqlCommand(sqlQuery, conexion.conn);

            /* El método "ExecuteNonQuery" retorna un entero con la cantidad
             * de filas afectadas, en caso de ser distinto a 1, se ejecutó 
             * exitosamente
             */

            if (comandoLocal.ExecuteNonQuery() != 0)
            {
                conexion.Desconectar();
                return true;
            }
            else
            {
                conexion.Desconectar();
                return false;
            }
        }

        /* Método de inserción, retornará "true" si se insertó exitosamente, 
        "false" de lo contrario */
        public bool insertar(string sqlQuery) 
        {
            try
            {
                if (ejecutarConsulta(sqlQuery))
                    return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return false;
        }

        public string buscar(string sqlQuery, string columna)
        {
            return retornarValor(sqlQuery, columna);
        }

        public bool actualizar(string sqlQuery)
        {
            if (ejecutarConsulta(sqlQuery))
                return true;
            else
                return false;
        }

        public bool eliminar(string sqlQuery)
        {
            if (ejecutarConsulta(sqlQuery))
                return true;
            else
                return false;
        }
        public bool modificar(string sqlQuery)
        {
            if (ejecutarConsulta(sqlQuery))
                return true;
            else
                return false;
        }

        public void llenarTabla(string sqlQuery, DataGridView tabla)
        {
            conexion.conectar();
            comandoLocal = new MySqlCommand(sqlQuery, conexion.conn);
            DataTable datos = new DataTable();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoLocal);
            adaptador.Fill(datos);
            tabla.DataSource = datos;
            tabla.DataMember = datos.TableName;
            tabla.AutoResizeColumns();
            conexion.Desconectar();
        }

        public void buscarYLlenarTabla(string sqlQuery, DataGridView tablaALlenar)
        {
            llenarTabla(sqlQuery, tablaALlenar);
        }

        public void llenarComboBox(string consulta, string columna, ComboBox combo)
        {
            MySqlDataReader dr1;
            try
            {
                conexion.conectar();
                comandoLocal = new MySqlCommand(consulta, conexion.conn);
                dr1 = comandoLocal.ExecuteReader();
                while (dr1.Read())
                {
                    combo.Items.Add(dr1[columna].ToString());
                }
                dr1.Close();
            }
            catch (Exception)
            {
                
            }
            conexion.Desconectar();
        }

        public string retornarValor(string consulta, string columna)
        {
            string valor = "";
            try
            {
                conexion.conectar();
                comandoLocal = new MySqlCommand(consulta, conexion.conn);
                MySqlDataReader dr2 = comandoLocal.ExecuteReader();
                dr2.Read();
                valor = dr2.GetString(columna);
                conexion.Desconectar();
                dr2.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return valor;
        }

        public string[] retornarArreglo(string consulta, string columna)
        {
            
            try
            {
                
                conexion.conectar();
                comandoLocal = new MySqlCommand(consulta, conexion.conn);
                MySqlDataReader dr2 = comandoLocal.ExecuteReader();
                int i = 0;
                string[] valor = new string[5];
                while (i<5)
                {
                    dr2.Read();
                    valor[i] = dr2.GetString(columna);
                    i++;
                }
                conexion.Desconectar();
                dr2.Close();
                return valor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public double[] retornarArregloDouble(string consulta, string columna)
        {

            try
            {

                conexion.conectar();
                comandoLocal = new MySqlCommand(consulta, conexion.conn);
                MySqlDataReader dr2 = comandoLocal.ExecuteReader();
                int i = 0;
                double[] valor = new double[5];
                while (i < 5)
                {
                    dr2.Read();
                    valor[i] = dr2.GetDouble(columna);
                    i++;
                }
                conexion.Desconectar();
                dr2.Close();
                return valor;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
