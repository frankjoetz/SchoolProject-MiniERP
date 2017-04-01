using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocios;

namespace ERP.Ventas
{
    public partial class PedidosFinal : Form
    {
        public PedidosFinal()
        {
            InitializeComponent();
        }

        LogicaDeNegocios.Ventas.metodosVentas mV = new LogicaDeNegocios.Ventas.metodosVentas();
        private void PedidosFinal_Load(object sender, EventArgs e)
        {
            cargarTabla("select * from PedidoFinal");
        }
        public void cargarTabla(string query)
        {
            DataSet cargar;
            cargar = mV.cargarTablas(query,"PedidoFinal");
            dgvPedidoFinal.DataSource = cargar;
            dgvPedidoFinal.DataMember = "PedidoFinal";
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if (txtIDpedFin.Text != "")
            {
                cargarTabla("select * from PedidoFinal where idPedido = "+ int.Parse(txtIDpedFin.Text));
            }
        }
    }
}
