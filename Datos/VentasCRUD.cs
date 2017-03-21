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
        private int equipoCom;

        public int EquipoCom
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
        private string detallePedido;

        public string DetallePedido
        {
            get { return detallePedido; }
            set { detallePedido = value; }
        }
        private int idPedido;

        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }
        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

      
        //constructor sin nada
        public VentasCRUD() { }
        //constructor para cliente
        public VentasCRUD(string NomClient, string Empresa, string ApeCliente, int telClient, string direClient, string Email, int StatusClient)
        {
            //primero va el atributo global privado y despues el local (parametros)
            this.empresa = Empresa;
            this.nombCliente = NomClient;
            this.apeCliente = ApeCliente;
            this.telClient = telClient;
            this.direClient = direClient;
            this.email = Email;
            this.statusClient = StatusClient;
        }
        //constructor para pedido
        public VentasCRUD(int idcliente, string fecha)
        {
            this.idCliente = idcliente;
            this.fecha = fecha;
        }
        public int agregarPedido(VentasCRUD vped)
        {
            int resultado = 0;
            try
            {
                MySqlCommand comandosql;
                Conexion conecta = new Conexion();
                conecta.conectar();                                                                                  //variable global
                string query = string.Format("Insert into Pedido(idCliente,fecha) values('{0}','{1}')",vped.idCliente, vped.fecha);
                comandosql = new MySqlCommand(query, conecta.conn);
                resultado = comandosql.ExecuteNonQuery();
                conecta.Desconectar();
                conecta.conn.Close();
            }
            catch (Exception ex)
            {

            }

            return resultado;
        }

        public int agregarCliente(VentasCRUD vcli)
        {
            int resultado = 0;
            try
            {
                MySqlCommand comandosql;
                Conexion conecta = new Conexion();
                conecta.conectar();
                string query = string.Format("Insert into Cliente(nombre,apellidos,empresa,telefono,direccion,email,statusCliente) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", vcli.nombCliente, vcli.apeCliente, vcli.empresa, vcli.telClient, vcli.direClient, vcli.email, vcli.statusClient);
                comandosql = new MySqlCommand(query, conecta.conn);
                resultado = comandosql.ExecuteNonQuery();
                conecta.Desconectar();
                conecta.conn.Close();
            }
            catch (Exception ex)
            {

            }

            return resultado;
        }

    }

   

    
}
