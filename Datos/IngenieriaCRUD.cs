using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Datos
{
    public class IngenieriaCRUD
    {
        public String cadenadeconexion;
        protected String sql;
        public MySqlCommand comandosql;
        public MySqlConnection cnn;
        public MySqlDataAdapter da;

        private int idLinea;

        public int IdLinea
        {
            get { return idLinea; }
            set { idLinea = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private int idMateria;

        public int IdMateria
        {
            get { return idMateria; }
            set { idMateria = value; }
        }

        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public IngenieriaCRUD()
        {
            
        }
        public IngenieriaCRUD(int idLinea, string descripcion) 
        {
            this.idLinea = idLinea;
            this.descripcion = descripcion;

        }
        public IngenieriaCRUD(int idMAteria, string tipo, string descripcion)
        {
            this.idMateria = idMAteria;
            this.tipo = tipo;
            this.descripcion = descripcion;
        }
        public int materiaPrima(IngenieriaCRUD mt)
        {
            int resultado = 0;
            try
            {
                MySqlCommand comandosql;
                Conexion conecta = new Conexion();
                conecta.conectar();                                                                                  //variable global
                string query = string.Format("Insert into MateriaPrima(idMateria,Tipo,descripcion) values('{0}','{1}','{2}')", mt.idMateria, mt.tipo, mt.descripcion);
                comandosql = new MySqlCommand(query, conecta.conn);
                resultado = comandosql.ExecuteNonQuery();
                conecta.Desconectar();
                conecta.conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
      
        
    }
}
