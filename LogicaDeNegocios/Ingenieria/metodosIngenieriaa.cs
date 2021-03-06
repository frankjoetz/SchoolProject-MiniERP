﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LogicaDeNegocios
{
    public class metodosIngenieriaa
    {
        BaseDeDatos bd = new BaseDeDatos();

        public bool altaMateria(string tipo, string descrip, string fecha)
        {
            if (bd.insertar("insert into MateriaPrima(Tipo, descripcion, Fecha) values('" + tipo + "', '" + descrip + "', '" + fecha + "')"))
                return true;
            else
                return false;
        }
        public bool altaProducto(string descripcion, string destino, string fHora)
        {
            if (bd.insertar("insert into Producto(descripcion, fecha, destino) values('" + descripcion + "','" + fHora + "', '" + destino + "')"))
                return true;
            else
                return false;
        }
        public bool EliminaMateria(int idmateria)
        {
            if (bd.eliminar("delete from MateriaPrima where idMateria=('" + idmateria + "')"))
                return true;
            else
                return false;
        }
        //public bool modificarMateria(int idmateria, string tipo, string descrip, string fecha, int cantidad)
        //{
        //    if (bd.modificar("UPDATE MateriaPrima SET Tipo='{0}',descripcion='{1}',fecha='{2}',destino='{3}' WHERE idMateria={4}", tipo, descrip, fecha, destino, idmateria))
        //        return true;
        //else
        //        return false;
        //}
        public void comboBox(string consulta, string columna, ComboBox cbx)
        {
            bd.llenarComboBox(consulta, columna, cbx);
        }
        public void llenarGridViewmateriaprima(DataGridView materiaprima)
        {
            bd.llenarTabla("select * from MateriaPrima order by idMateria asc", materiaprima);
        }

        public void llenarGridViewGamas(DataGridView gamas)
        {
            bd.llenarTabla("select * from Producto order by idProducto asc", gamas);
        }

        public void llenaGriedViewConsumos(DataGridView consumo)
        {
            bd.llenarTabla("select * from Vista_Consumos order by IdProducto asc", consumo);
        }

        public bool altaconsumo(int idproducto, int idmateria, int idline, int cantidad)
        {
            if (bd.insertar("insert into Consumo(idProducto,idMateria,idLinea,Cantidad) values('" + idproducto + "', '" + idmateria + "', '" + idline + "','" + cantidad + "')"))
                return true;
            else
                return false;
        }
    }
}
