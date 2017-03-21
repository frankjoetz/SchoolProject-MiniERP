using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace LogicaDeNegocios.Ventas
{
    public class metodosVentas
    {
        Conexion conectar = new Conexion();
        public metodosVentas()
        { }
        public int altaCliente(string nombre, string empresa, string apellido, int telefono, string direccion, string email, int status)
        {
            int flag = 0;
            VentasCRUD vcli = new VentasCRUD();
            try
            {
                vcli.NombCliente = nombre;
                vcli.ApeCliente = apellido;
                vcli.Empresa = empresa;
                vcli.TelClient = telefono;
                vcli.DireClient = direccion;
                vcli.Email = email;
                vcli.StatusClient = status;
                int resultado = vcli.agregarCliente(vcli);
                if (resultado == 1)
                {
                    flag = 1;
                }
            }
            catch (Exception ex)
            {

            }
            return flag;
        }
    }
}
