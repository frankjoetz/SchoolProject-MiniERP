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
        }

        private void Produccion_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
