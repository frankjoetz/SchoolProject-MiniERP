using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Produccion
{
    public partial class Produccion : Form
    {
        LogicaDeNegocios.Produccion.metodosProduccion metodos = new LogicaDeNegocios.Produccion.metodosProduccion();
        
        public Produccion()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Produccion_Load(object sender, EventArgs e)
        {
            metodos.llenarTablaPlaneaciones(dgvPlaneaciones);
        }

        private void dgvPlaneaciones_Click(object sender, EventArgs e)
        {

            DataGridViewRow fila = dgvPlaneaciones.SelectedRows[0];

            txtIdPlaneacion.Text = fila.Cells["idPlaneacion"].Value.ToString();

            lblInfo.Text = "Detalle: Se producirán " + fila.Cells["Cantidad"].Value + " computadoras de " + fila.Cells["Tipo"].Value;

            switch (fila.Cells["Tipo"].Value.ToString())
            {
                case "Gama baja":
                    txtLinea.Text = "Linea 1 - Gama baja";
                    break;
                case "Gama media":
                    txtLinea.Text = "Linea 2 - Gama media";
                    break;
                case "Gama alta":
                    txtLinea.Text = "Linea 3 - Gama alta";
                    break;
                default:
                    break;
            }
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            //DateTime inicio = dtpFechaInicio.Value.ToString("yyyy-MM-dd");
            
            DateTime inicio = dtpFechaInicio.Value;

            DataGridViewRow fila = dgvPlaneaciones.SelectedRows[0];

            float cantidad = float.Parse(fila.Cells["Cantidad"].Value.ToString());
            float resultado = cantidad / 120;
            string mensaje = "Se producen 120 computadoras por día, por ende, sus " + cantidad + " computadoras se producirán en aproximadamente " + resultado + " días. \n";
            dtpFechaEstimada.Value = inicio.AddDays(resultado);
            MessageBox.Show(mensaje + "\nFecha estimada de entrega: " + inicio.AddDays(resultado).ToString("MMMM dd, yyyy"));
            
        }
    }
}
