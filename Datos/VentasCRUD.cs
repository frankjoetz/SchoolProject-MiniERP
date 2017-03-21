using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Datos
{
    public class VentasCRUD
    {
        public String cadenadeconexion;
        protected String sql;
        public MySqlCommand comandosql;
        public MySqlConnection cnn;
        public MySqlDataAdapter da;

        private int idCliente;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        private string empresa;

        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
        private string equipoCom;

        public string EquipoCom
        {
            get { return equipoCom; }
            set { equipoCom = value; }
        }
        private int cant;

        public int Cant
        {
            get { return cant; }
            set { cant = value; }
        }
        private string nombCliente;

        public string NombCliente
        {
            get { return nombCliente; }
            set { nombCliente = value; }
        }
        private string apeCliente;

        public string ApeCliente
        {
            get { return apeCliente; }
            set { apeCliente = value; }
        }
        private int telClient;

        public int TelClient
        {
            get { return telClient; }
            set { telClient = value; }
        }
        private string direClient;

        public string DireClient
        {
            get { return direClient; }
            set { direClient = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private int statusClient;

        public int StatusClient
        {
            get { return statusClient; }
            set { statusClient = value; }
        }
        public VentasCRUD() { }

        public VentasCRUD(string NomClient, string Empresa, string ApeCliente, int telClient, string direClient, string Email, int StatusClient)
        {
            /* this.idCliente = IdCliente;
            this.empresa = Empresa;
            this.equipoCom = EquipoCom;
            this.cant = Cant;
            this.nombCliente = NombCliente;
            this.telClient = TelClient;
            this.empresaClient = EmpresaClient;
            this.direClient = DireClient; */

            this.empresa = Empresa;
            this.nombCliente = NomClient;
            this.apeCliente = ApeCliente;
            this.telClient = telClient;
            this.direClient = direClient;
            this.email = Email;
            this.statusClient = StatusClient;
        }

        public int agregarCliente(VentasCRUD vcli)
        {
            int resultado = 0;
            try
            {
                MySqlCommand comandosql;
                Conexion conecta = new Conexion();
                conecta.conectar();
                //conecta.isConnected();
                string query = string.Format("Insert into Cliente(nombre,apellidos,empresa,telefono,direccion,email,statusCliente) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", vcli.nombCliente, vcli.apeCliente, vcli.empresa, vcli.telClient, vcli.direClient, vcli.email, vcli.statusClient);
                comandosql = new MySqlCommand(query, conecta.conn);
                //comandosql = new SqlCommand(query, conecta.cnn);
                resultado = comandosql.ExecuteNonQuery();
                conecta.Desconectar();
                //conecta.notConnected();
                conecta.conn.Close();
                //conecta.cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return resultado;
        }

    }

   

    
}
