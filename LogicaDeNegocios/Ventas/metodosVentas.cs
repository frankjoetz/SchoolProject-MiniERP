using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using MySql.Data.MySqlClient;

namespace LogicaDeNegocios.Ventas
{
    public class metodosVentas
    {
        Conexion conectar = new Conexion();
        Datos.BaseDeDatos bd = new Datos.BaseDeDatos();

        public bool altaCliente(string nombre, string apellidos, string empresa, int telefono, string direccion, string email, int status)
        {
            if (bd.insertar("insert into Clientes(nombre,apellidos,empresa,telefono,direccion,email,statusCliente) values('" + nombre + "', '" + apellidos + "', '" + empresa + "', " + telefono + ",'"+direccion+"','"+email+"',"+status+")"))
                return true;
            else
                return false;
        }
        public bool altaPedido(int idCliente, string fecha)
        {
            if (bd.insertar("insert into Pedido(idCliente,fecha) values(" + idCliente + ",'" + fecha + "')"))
                return true;
            else
                return false;
        }
        //public metodosVentas()
        //{ }
        //public int altaPedido(int idCliente, string fecha)
        //{
        //    int flag = 0;
        //    VentasCRUD vped = new VentasCRUD();
        //    try
        //    {
        //        vped.IdCliente = idCliente;
        //        vped.Fecha = fecha;
        //        int resultado = vped.agregarPedido(vped);
        //        if (resultado == 1)
        //        {
        //            flag = 1;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return flag;
        //}
        //public int altaCliente(string nombre, string empresa, string apellido, int telefono, string direccion, string email, int status)
        //{
        //    int flag = 0;
        //    VentasCRUD vcli = new VentasCRUD(); //instanciar el constructor sin nada
        //    try
        //    {
        //        //ingresar en los get\set los datos locales
        //        vcli.NombCliente = nombre;
        //        vcli.ApeCliente = apellido;
        //        vcli.Empresa = empresa;
        //        vcli.TelClient = telefono;
        //        vcli.DireClient = direccion;
        //        vcli.Email = email;
        //        vcli.StatusClient = status;
        //        int resultado = vcli.agregarCliente(vcli); //metodo de la clase
        //        if (resultado == 1)
        //        {
        //            flag = 1;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return flag;
        //}
        public DataSet cargarClientes(string query)
        {
            DataSet erpCli = new DataSet();
            try
            {
                conectar.conectar();
                MySqlDataAdapter daCliente = new MySqlDataAdapter(query, conectar.conn);
                daCliente.Fill(erpCli, "Cliente");
                conectar.conn.Close();
            }
            catch (Exception ex)
            {
                
            }
            return erpCli;
        }
    }
}
