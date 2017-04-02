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
        Ventas ventas = new Ventas();
        private void BCliente_Load(object sender, EventArgs e)
        {
            tmBuscar.Enabled = false;
            cargarClientes("select * from Cliente");
        }
        public void cargarClientes(string query)
        {
            DataSet cargar;
            cargar = mV.cargarClientes(query);
            dgvBuscar.DataSource = cargar;
            dgvBuscar.DataMember = "Cliente";
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
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

        private void dgvBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ventas.Id = dgvBuscar.Rows[dgvBuscar.CurrentRow.Index].Cells["idCliente"].Value.ToString();
            ventas.Empresa = dgvBuscar.Rows[dgvBuscar.CurrentRow.Index].Cells["empresa"].Value.ToString();
            this.Dispose();
        }
    }
}
