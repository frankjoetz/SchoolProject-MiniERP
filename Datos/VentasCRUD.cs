using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class VentasCRUD
    {
        public String cadenadeconexion;
        protected String sql;
        public SqlCommand comandosql;
        public SqlConnection cnn;
        public SqlDataAdapter da;

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
        private string fotoclient;

        public string Fotoclient
        {
            get { return fotoclient; }
            set { fotoclient = value; }
        }
        private string nombCliente;

        public string NombCliente
        {
            get { return nombCliente; }
            set { nombCliente = value; }
        }
        private int telClient;

        public int TelClient
        {
            get { return telClient; }
            set { telClient = value; }
        }
        private string empresaClient;

        public string EmpresaClient
        {
            get { return empresaClient; }
            set { empresaClient = value; }
        }
        private string direClient;

        public string DireClient
        {
            get { return direClient; }
            set { direClient = value; }
        }

        public VentasCRUD(int idClient, string Empresa, string equipoCom, int cant, string fotoClient, string NomClient, int telClient, string empresaClient,string direClient)
        {
            /* this.idCliente = IdCliente;
            this.empresa = Empresa;
            this.equipoCom = EquipoCom;
            this.cant = Cant;
            this.fotoclient = Fotoclient;
            this.nombCliente = NombCliente;
            this.telClient = TelClient;
            this.empresaClient = EmpresaClient;
            this.direClient = DireClient; */

            this.IdCliente = idCliente;
            this.Empresa = Empresa;
            this.EquipoCom = equipoCom;
            this.Cant = cant;
            this.Fotoclient = fotoClient;
            this.NombCliente = NomClient;
            this.TelClient = telClient;
            this.EmpresaClient = empresaClient;
            this.DireClient = direClient;
        }

        //public int agregarCliente(VentasCRUD vcrud)
        //{
        //    int resultado = 0;
        //    try
        //    {
        //        SqlCommand comandosql;
        //        Conexion conecta = new Conexion();
        //        conecta.conectar();
        //        //conecta.isConnected();
               
        //        string query = string.Format("Insert into 
        //        string query = string.Format("insert into Inventario(Nomb_Producto,Descripcion,Precio_Compra,Precio_Unidad,Stock_Minimo,Stock,Foto) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", pinventario.nombreProducto, pinventario.categoria, pinventario.precioVen, pinventario.precioUni, pinventario.cantMin, pinventario.cantExist, pinventario.foto);
        //        comandosql = new SqlCommand(query, conecta.conn);
        //        //comandosql = new SqlCommand(query, conecta.cnn);
        //        resultado = comandosql.ExecuteNonQuery();
        //        conecta.Desconectar();
        //        //conecta.notConnected();
        //        conecta.conn.Close();
        //        //conecta.cnn.Close();
        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //    return resultado;
        //}

    }

   

    
}
