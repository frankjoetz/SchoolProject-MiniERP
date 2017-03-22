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

        LogicaDeNegocios.Ventas.metodosVentas mV = new LogicaDeNegocios.Ventas.metodosVentas();
        private void BCliente_Load(object sender, EventArgs e)
        {
            cargarClientes("select * from Cliente");
        }
        public void cargarClientes(string query)
        {
            DataSet cargar;
            cargar = mV.cargarClientes(query);
            dgvBuscar.DataSource = cargar;
            dgvBuscar.DataMember = "Cliente";
        }

        private void tmBuscar_Tick(object sender, EventArgs e)
        {
            if (txtNom.Text != "")
            {
                if (txtEmpresa.Text != "")
                {
                    cargarClientes("select * from Cliente where nombre like '" + txtNom.Text + "%' and empresa like '" + txtEmpresa.Text + "%'");
                }
                else
                {
                    cargarClientes("select * from Cliente where nombre like '" + txtNom.Text + "%'");
                }
            }
            else
            {
                cargarClientes("select * from Cliente where empresa like '" + txtEmpresa.Text + "%'");
            }
        }
    }
}
