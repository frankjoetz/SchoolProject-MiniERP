using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Datos;

namespace LogicaDeNegocios
{
    public class metodosIngenieria
    {
        Conexion conectar = new Conexion();
        public metodosIngenieria()
        {

        }
        public int altaMateriaPrima(int idMateria, string Tipo, string descripcion)
        {
            int resultado = 0;
            IngenieriaCRUD ing = new IngenieriaCRUD();
            try
            {
                ing.IdMateria = idMateria;
                ing.Tipo = Tipo;
                ing.Descripcion = descripcion;
                int result = ing.materiaPrima(ing);
                if (result == 1)
                {
                    resultado = 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }
    }

}
