using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class IngenieriaADO
    {

        private int idmateria;

        public int Idmateria
        {
            get { return idmateria; }
            set { idmateria = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private string unidad;

        public string Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }
        private int idproducto;

        public int Idproducto
        {
            get { return idproducto; }
            set { idproducto = value; }
        }
        private string descripcionprod;

        public string Descripcionprod
        {
            get { return descripcionprod; }
            set { descripcionprod = value; }
        }
        private int cantidadprod;

        public int Cantidadprod
        {
            get { return cantidadprod; }
            set { cantidadprod = value; }
        }
        private int cantidadmat;

        public int Cantidadmat
        {
            get { return cantidadmat; }
            set { cantidadmat = value; }
        }
        private int fecharep;

        public int Fecharep
        {
            get { return fecharep; }
            set { fecharep = value; }
        }
    }
    //public IngenieriaADO()
    //{
        
    //}
    //public IngenieriaADO(int id, string desc, string fecha, string unidad, int idprod, string descprod, int cantprod, int cantmin, int fecharep)
    //{
    //    this.Idmateria = id;
    //    this.
    //}

}
