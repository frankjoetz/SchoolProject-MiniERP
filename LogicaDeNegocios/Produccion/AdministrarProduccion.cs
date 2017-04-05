using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;
using System.Threading;

namespace LogicaDeNegocios.Produccion
{
    public class AdministrarProduccion
    {
        static Thread hiloActualizar;
        BaseDeDatos bd = new BaseDeDatos();
        
        public void IniciarHilo()
        {
            hiloActualizar = new Thread(new ThreadStart(funcionRecorrerHilos));
            hiloActualizar.Start();
        }

        public void funcionRecorrerHilos()
        {
            for (int i = 0; i < 8; i++)
            {
                //MessageBox.Show("Wuju> " + i);
                //Thread.Sleep(7000);
            }
        }

        public void LlenarProducciones(DataGridView tabla)
        {
            string query = "select * from Vista_ProduccionesOverview";
            bd.llenarTabla(query, tabla);
        }

        public void llenarEtapa(Label etapa, ProgressBar barra, DataGridView tabla)
        {
            string et = RetornarValor(tabla, "Etapa");
            string descripcion = bd.retornarValor("select * from Etapas where Id=" + et, "Detalle");
            etapa.Text = descripcion;
            barra.Value = int.Parse(et);
        }

        public bool AvanzarEtapa(DataGridView tabla)
        {
            int etapa = int.Parse(RetornarValor(tabla, "Etapa")) + 1;
            string id = RetornarValor(tabla, "idProduccion");
            bd.actualizar("update Produccion set Etapa=" + etapa + " where idProduccion=" + id);
            if (etapa == 8)
                return true;
            else
                return false;
        }

        public bool RetrocederEtapa(DataGridView tabla)
        {
            int etapa = int.Parse(RetornarValor(tabla, "Etapa")) - 1;
            string id = RetornarValor(tabla, "idProduccion");
            bd.actualizar("update Produccion set Etapa=" + etapa + " where idProduccion=" + id);
            if (etapa == 1)
                return true;
            else
                return false;
        }

        public bool CancelarProduccion(DataGridView tabla)
        {
            string idPl = RetornarValor(tabla, "idPlaneacion");
            string idPr = RetornarValor(tabla, "idProduccion");

            if (bd.actualizar("update Planeacion set status='Listo para producir' where idPlaneacion=" + idPl))
                if (bd.eliminar("delete from Produccion where idProduccion=" + idPr))
                    return true;
                else
                    return false;
            else
                return false;
        }

        public string RetornarValor(DataGridView tabla, string columna)
        {
            DataGridViewRow fila = tabla.SelectedRows[0];
            return fila.Cells[columna].Value.ToString();
        }
    }
}
