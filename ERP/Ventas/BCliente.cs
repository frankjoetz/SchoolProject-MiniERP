using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using LogicaDeNegocios;

namespace ERP.Ventas
{
    public partial class BCliente : Form
    {
        public BCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BCliente_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }
        public void cargarClientes()
        {
            LogicaDeNegocios.Ventas.metodosVentas mV = new LogicaDeNegocios.Ventas.metodosVentas();
            DataSet cargar;
            cargar = mV.cargarClientes();
            dgvBuscar.DataSource = cargar;
            dgvBuscar.DataMember = "Cliente";
        }
    }
}
