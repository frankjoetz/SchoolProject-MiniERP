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
        LogicaDeNegocios.Produccion.metodosProduccion prod = new LogicaDeNegocios.Produccion.metodosProduccion();

        public Produccion()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            prod.llenarTablaProduccion(tableProduccion);
        }

        private void Produccion_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (prod.insertarProduccion(cboxIdPlaneacion.SelectedItem.ToString(), dateInicio.Value.ToString("yyyy-MM-dd"), cboxEtapa.SelectedItem.ToString(), dateEntrega.Value.ToString("yyyy-MM-dd"), txtObservaciones.Text.ToString()))
            {
                prod.llenarTablaProduccion(tableProduccion);
                MessageBox.Show("El valor se insertó correctamente");
            }
            else
            {
                MessageBox.Show("Ocurrió un error insertando");
            }
        }
    }
}
