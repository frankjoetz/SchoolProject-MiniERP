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
        string desc;
        public Ventas()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFH.Text = DateTime.Now.ToString("yyyy-MM-dd");
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
            bool res = false;
            bool result = mV.altaPedido(int.Parse(txtIDcliente.Text), lblFH.Text);
            if (cmbGamas.SelectedIndex == 0)
                res = mV.altaDetallesPedido(int.Parse(mV.buscarUnDato("idPedido", "Pedido", " order by idPedido DESC LIMIT 1")), 1, int.Parse(txtCan.Text), txtaCom.Text);
            if (cmbGamas.SelectedIndex == 1)
                res = mV.altaDetallesPedido(int.Parse(mV.buscarUnDato("idPedido", "Pedido", " order by idPedido DESC LIMIT 1")), 2, int.Parse(txtCan.Text), txtaCom.Text);
            if (cmbGamas.SelectedIndex == 2)
                res = mV.altaDetallesPedido(int.Parse(mV.buscarUnDato("idPedido", "Pedido", " order by idPedido DESC LIMIT 1")), 3, int.Parse(txtCan.Text), txtaCom.Text);
            if (result && res)
            {
                MessageBox.Show("simona la mona");
                cargarTablas(dgvPedido, "select Pedido.idPedido, Cliente.idCliente, Cliente.nombre, Cliente.apellidos, Cliente.empresa, Cliente.telefono, Cliente.direccion, Cliente.email, Cliente.statusCliente, Pedido.fecha, DetallePedido.idproducto, DetallePedido.cantidad, DetallePedido.detallepedido from Cliente inner join Pedido on Pedido.idCliente = Cliente.idCliente inner join DetallePedido on DetallePedido.idPedido = Pedido.idPedido", "Pedido");
                txtIDcliente.Text = "";
                cmbGamas.SelectedIndex = -1;
                txtCan.Text = "";
                txtaCom.Text = "";
            }
        }
        public void cargarTablas(DataGridView dgv, string query,string tablas)
        {
            DataSet cargar;
            cargar = mV.cargarTablas(query,tablas);
            dgv.DataSource = cargar;
            dgv.DataMember = tablas;
        }

        private void txtIDHis_TextChanged(object sender, EventArgs e)
        {
            if (txtIDHis.Text != "")
                cargarTablas(dgvPedido,string.Format("select Pedido.idPedido, Cliente.idCliente, Cliente.nombre, Cliente.apellidos, Cliente.empresa, Cliente.telefono, Cliente.direccion, Cliente.email, Cliente.statusCliente, Pedido.fecha, DetallePedido.idproducto, DetallePedido.cantidad, DetallePedido.detallepedido from Cliente inner join Pedido on Pedido.idCliente = Cliente.idCliente inner join DetallePedido on DetallePedido.idPedido = Pedido.idPedido where Pedido.idPedido >= " + int.Parse(txtIDHis.Text)),"Pedido");
            else
                cargarTablas(dgvPedido,"select Pedido.idPedido, Cliente.idCliente, Cliente.nombre, Cliente.apellidos, Cliente.empresa, Cliente.telefono, Cliente.direccion, Cliente.email, Cliente.statusCliente, Pedido.fecha, DetallePedido.idproducto, DetallePedido.cantidad, DetallePedido.detallepedido from Cliente inner join Pedido on Pedido.idCliente = Cliente.idCliente inner join DetallePedido on DetallePedido.idPedido = Pedido.idPedido","Pedido");
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            cargarTablas(dgvPedido,"select Pedido.idPedido, Cliente.idCliente, Cliente.nombre, Cliente.apellidos, Cliente.empresa, Cliente.telefono, Cliente.direccion, Cliente.email, Cliente.statusCliente, Pedido.fecha, DetallePedido.idproducto, DetallePedido.cantidad, DetallePedido.detallepedido from Cliente inner join Pedido on Pedido.idCliente = Cliente.idCliente inner join DetallePedido on DetallePedido.idPedido = Pedido.idPedido","Pedido");
            cargarTablas(dgvBuscar,"select * from Cliente","Cliente");
            mV.comboBox("select descripcion from Producto", "descripcion", cmbGamas);
        }
        //////////////////////////////////////////////////////////////////
        private void txtNomb_TextChanged(object sender, EventArgs e)
        {
            if (txtNomb.Text != "")
            {
                if (txtEmp.Text != "")
                {
                    cargarTablas(dgvBuscar,string.Format("select * from Cliente where nombre like '" + txtNomb.Text + "%' and empresa like '" + txtEmp.Text + "%'"),"Cliente");
                }
                else
                {
                    cargarTablas(dgvBuscar,string.Format("select * from Cliente where nombre like '" + txtNomb.Text + "%'"),"Cliente");
                }
            }
            else
            {
                cargarTablas(dgvBuscar,string.Format("select * from Cliente where empresa like '" + txtEmp.Text + "%'"),"Cliente");
            }
        }

        private void dgvBuscar_Click(object sender, DataGridViewCellEventArgs e)
        {
            txtIDcliente.Text = dgvBuscar.Rows[dgvBuscar.CurrentRow.Index].Cells["idCliente"].Value.ToString();
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

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDBorrar.Text = dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells["idPedido"].Value.ToString();
            desc = "idCliente|Nombre|Producto|Cantidad|Y si tiene un detallito = "+dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells["idCliente"].Value.ToString() +"|"+ dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells["nombre"].Value.ToString() +"|"+ dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells["idproducto"].Value.ToString() +"|"+ dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells["cantidad"].Value.ToString() +"|"+ dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells["detallepedido"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool x = mV.altaPedidoFinal(int.Parse(txtIDBorrar.Text), lblFH.Text,desc);
            if (x)
            {
                bool y = mV.bajasPedido(string.Format("delete from DetallePedido where idPedido = "+int.Parse(txtIDBorrar.Text)));
                if (y)
                {
                    mV.bajasPedido(string.Format("delete from Pedido where idPedido = " + int.Parse(txtIDBorrar.Text)));
                    MessageBox.Show("Ya se borro");
                    cargarTablas(dgvPedido,"select Pedido.idPedido, Cliente.idCliente, Cliente.nombre, Cliente.apellidos, Cliente.empresa, Cliente.telefono, Cliente.direccion, Cliente.email, Cliente.statusCliente, Pedido.fecha, DetallePedido.idproducto, DetallePedido.cantidad, DetallePedido.detallepedido from Cliente inner join Pedido on Pedido.idCliente = Cliente.idCliente inner join DetallePedido on DetallePedido.idPedido = Pedido.idPedido","Pedido");
                }
            }
        }

        private void btnPedFin_Click(object sender, EventArgs e)
        {
            PedidosFinal pdF = new PedidosFinal();
            pdF.Show();
        }

    }
}
