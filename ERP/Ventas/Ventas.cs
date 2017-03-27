using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Ventas
{
    public partial class Ventas : Form
    {
        LogicaDeNegocios.Ventas.metodosVentas mV = new LogicaDeNegocios.Ventas.metodosVentas();
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string empresa;

        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
        public Ventas()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFH.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            ACliente agc = new ACliente();
            agc.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tbcVentas.SelectedIndex = 2;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool result = mV.altaPedido(int.Parse(txtIDcliente.Text), lblFH.Text);
            bool res = mV.altaDetallesPedido(int.Parse(mV.buscarUnDato("idPedido","Pedido"," order by fecha DESC LIMIT 1")),cmbGamas.SelectedIndex, int.Parse(txtCan.Text), txtaCom.Text);
            if (result && res)
                MessageBox.Show("simona la mona");
        }

        public void cargarPedido(string query)
        {
            DataSet cargar2;
            cargar2 = mV.cargarPedidos(query);
            dgvPedido.DataSource = cargar2;
            dgvPedido.DataMember = "Pedido";
        }
        public void cargarClientes(string query)
        {
            DataSet cargar;
            cargar = mV.cargarClientes(query);
            dgvBuscar.DataSource = cargar;
            dgvBuscar.DataMember = "Cliente";
        }

        private void txtIDHis_TextChanged(object sender, EventArgs e)
        {
            if (txtIDHis.Text != "")
                cargarPedido("select Pedido.idPedido, Cliente.idCliente, Cliente.nombre, Cliente.apellidos, Cliente.empresa, Cliente.telefono, Cliente.direccion, Cliente.email, Cliente.statusCliente, Pedido.fecha, DetallePedido.idproducto, DetallePedido.cantidad, DetallePedido.detallepedido from Cliente inner join Pedido on Pedido.idCliente = Cliente.idCliente inner join DetallePedido on DetallePedido.idPedido = Pedido.idPedido where Pedido.idPedido >= " + int.Parse(txtIDHis.Text));
            else
                cargarPedido("select Pedido.idPedido, Cliente.idCliente, Cliente.nombre, Cliente.apellidos, Cliente.empresa, Cliente.telefono, Cliente.direccion, Cliente.email, Cliente.statusCliente, Pedido.fecha, DetallePedido.idproducto, DetallePedido.cantidad, DetallePedido.detallepedido from Cliente inner join Pedido on Pedido.idCliente = Cliente.idCliente inner join DetallePedido on DetallePedido.idPedido = Pedido.idPedido");
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            cargarPedido("select Pedido.idPedido, Cliente.idCliente, Cliente.nombre, Cliente.apellidos, Cliente.empresa, Cliente.telefono, Cliente.direccion, Cliente.email, Cliente.statusCliente, Pedido.fecha, DetallePedido.idproducto, DetallePedido.cantidad, DetallePedido.detallepedido from Cliente inner join Pedido on Pedido.idCliente = Cliente.idCliente inner join DetallePedido on DetallePedido.idPedido = Pedido.idPedido");
            cargarClientes("select * from Cliente");
        }
        //////////////////////////////////////////////////////////////////
        private void txtNomb_TextChanged(object sender, EventArgs e)
        {
            if (txtNomb.Text != "")
            {
                if (txtEmp.Text != "")
                {
                    cargarClientes("select * from Cliente where nombre like '" + txtNomb.Text + "%' and empresa like '" + txtEmp.Text + "%'");
                }
                else
                {
                    cargarClientes("select * from Cliente where nombre like '" + txtNomb.Text + "%'");
                }
            }
            else
            {
                cargarClientes("select * from Cliente where empresa like '" + txtEmp.Text + "%'");
            }
        }

        private void dgvBuscar_Click(object sender, DataGridViewCellEventArgs e)
        {
            txtIDcliente.Text = dgvBuscar.Rows[dgvBuscar.CurrentRow.Index].Cells["idCliente"].Value.ToString();
            txtNombre.Text = dgvBuscar.Rows[dgvBuscar.CurrentRow.Index].Cells["nombre"].Value.ToString();
            txtEmpresa.Text = dgvBuscar.Rows[dgvBuscar.CurrentRow.Index].Cells["empresa"].Value.ToString();
            tbcVentas.SelectedIndex = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblH.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void txtIDcliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIDcliente.Text != "")
            {
                txtNombre.Text = mV.buscarUnDato("nombre", "Cliente", " where idCliente = " + txtIDcliente.Text);
                txtEmpresa.Text = mV.buscarUnDato("empresa", "Cliente", " where idCliente = " + txtIDcliente.Text);
            }
            else
            {
                txtNombre.Text = "";
                txtEmpresa.Text = "";
            }
        }

    }
}
