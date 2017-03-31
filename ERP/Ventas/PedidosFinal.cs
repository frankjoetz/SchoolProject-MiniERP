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
    public partial class PedidosFinal : Form
    {
        public PedidosFinal()
        {
            InitializeComponent();
        }

        LogicaDeNegocios.Ventas.metodosVentas mV = new LogicaDeNegocios.Ventas.metodosVentas();
        private void BCliente_Load(object sender, EventArgs e)
        {
            cargarPedido("select PedidoFinal.idPedido, Cliente.idCliente, Cliente.nombre, Cliente.apellidos, Cliente.empresa, Cliente.telefono, Cliente.direccion, Cliente.email, Cliente.statusCliente, PedidoFinal.fecha, DetallePedido.idproducto, DetallePedido.cantidad, DetallePedido.detallepedido from Cliente inner join Pedido on Pedido.idCliente = Cliente.idCliente inner join DetallePedido on DetallePedido.idPedido = Pedido.idPedido inner join PedidoFinal on Pedido.idPedido = PedidoFinal.idPedido");
        }
        public void cargarPedido(string query)
        {
            DataSet cargar;
            cargar = mV.cargarClientes(query);
            dgvBuscar.DataSource = cargar;
            dgvBuscar.DataMember = "PedidoFinal";
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if (txtNom.Text != "")
            {
                cargarPedido("select PedidoFinal.idPedido, Cliente.idCliente, Cliente.nombre, Cliente.apellidos, Cliente.empresa, Cliente.telefono, Cliente.direccion, Cliente.email, Cliente.statusCliente, PedidoFinal.fecha, DetallePedido.idproducto, DetallePedido.cantidad, DetallePedido.detallepedido from Cliente inner join Pedido on Pedido.idCliente = Cliente.idCliente inner join DetallePedido on DetallePedido.idPedido = Pedido.idPedido inner join PedidoFinal on Pedido.idPedido = PedidoFinal.idPedido where PedidoFinal.idPedido = "+ int.Parse(txtNom.Text));
            }
        }
    }
}
