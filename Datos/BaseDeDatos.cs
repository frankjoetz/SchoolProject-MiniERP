﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Incluir cliente MySQL
using Datos.Properties; // Será utilizado para acceder a la cadena de conexión
using System.Windows.Forms;
using System.Data;

namespace Datos
{
    public class BaseDeDatos
    {
        // Atributo conexión almacenará la conexión a la BD.
        private MySqlConnection conexion;
        // Atributo que almacenará temporalmente el query en cada método.
        private MySqlCommand comandoLocal;


        public BaseDeDatos() // Constructor establecerá conexión
        {
            // Se carga la cadena y se asigna la conexión
            try
            {
                conexion = new MySqlConnection(Settings.Default.erpdbConnectionString);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /* Método de inserción, retornará "true" si se insertó exitosamente, 
        "false" de lo contrario */
        public bool insertar(string sqlQuery) 
        {
            conexion.Open(); // Se abre la conexión
            // Se manda como primer parametro la consulta recibida (sqlQuery)
            comandoLocal = new MySqlCommand(sqlQuery, conexion);

            /* El método "ExecuteNonQuery" retorna un entero con la cantidad
             * de filas afectadas, en caso de ser distinto a 1, se ejecutó 
             * exitosamente
             */
              
            if(comandoLocal.ExecuteNonQuery() != 0)
            {
                conexion.Close();
                return true;
            } else
            {
                conexion.Close();
                return false;
            }
        }

        public void llenarTabla(string sqlQuery, DataGridView tabla)
        {
            conexion.Open();
            comandoLocal = new MySqlCommand(sqlQuery, conexion);
            DataTable datos = new DataTable();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoLocal);
            adaptador.Fill(datos);
            tabla.DataSource = datos;
            tabla.DataMember = datos.TableName;
            tabla.AutoResizeColumns();
            conexion.Close();
        }

        public void llenarCombobox()
        {

        }
    }
}