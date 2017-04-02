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

        private void Ventas_Load(object sender, EventArgs e)
        {
            cargarTablas(dgvBuscar, "select * from Cliente", "Cliente");
            cargarTablas(dgvPedido, "select * from Pedido inner join Cliente on Pedido.idCliente = Cliente.idCliente", "Pedido");
        }

        //Load de la ventana///////////////////////////////////////////////////////////
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFH.Text = DateTime.Now.ToString("yyyy-MM-dd");
            if (rdbtnID.Checked)
            {
                txtIDHis.Enabled = true;
                txtNomCliHis.Text = "";
                txtNomCliHis.Enabled = false;
            }
            if (rdbtnNC.Checked)
            {
                txtNomCliHis.Enabled = true;
                txtIDHis.Text = "";
                txtIDHis.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblH.Text = DateTime.Now.ToString("hh:mm:ss");
            if (chkGB.Checked)
                txtCanGB.Enabled = true;
            else
                txtCanGB.Enabled = false;
            if (chkGM.Checked)
                txtCanGM.Enabled = true;
            else
                txtCanGM.Enabled = false;
            if (chkGA.Checked)
                txtCanGA.Enabled = true;
            else
                txtCanGA.Enabled = false;
        }

        //Timers//////////////////////////////////////////////////////////////////////////////////////////
        private void btnAddC_Click(object sender, EventArgs e)
        {
            ACliente agc = new ACliente();
            agc.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tbcVentas.SelectedIndex = 2;
        }

        private void dgvBuscar_Click(object sender, DataGridViewCellEventArgs e)
        {
            txtIDcliente.Text = dgvBuscar.Rows[dgvBuscar.CurrentRow.Index].Cells["idCliente"].Value.ToString();
            tbcVentas.SelectedIndex = 0;
        }

        //Botones de redireccion/////////////////////////////////////////////////////////////////////////
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

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtNomb.Text != "")
            {
                if (txtEmp.Text != "")
                {
                    cargarTablas(dgvBuscar, string.Format("select * from Cliente where nombre like '" + txtNomb.Text + "%' and empresa like '" + txtEmp.Text + "%'"), "Cliente");
                }
                else
                {
                    cargarTablas(dgvBuscar, string.Format("select * from Cliente where nombre like '" + txtNomb.Text + "%'"), "Cliente");
                }
            }
            else
            {
                cargarTablas(dgvBuscar, string.Format("select * from Cliente where empresa like '" + txtEmp.Text + "%'"), "Cliente");
            }
        }

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDBorrar.Text = dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells["idPedido"].Value.ToString();
        }

        private void txtHis_TextChanged(object sender, EventArgs e)
        {
            if (txtIDHis.Text != "")
            {
                cargarTablas(dgvPedido, "select * from Pedido inner join Cliente on Pedido.idCliente = Cliente.idCliente where Pedido.idPedido >= " + int.Parse(txtIDHis.Text), "Pedido");
            }
            if (txtNomCliHis.Text != "")
            {
                cargarTablas(dgvPedido, "select * from Pedido inner join Cliente on Pedido.idCliente = Cliente.idCliente where Cliente.nombre like '" + txtNomCliHis.Text + "%'", "Pedido");
            }
            else
                cargarTablas(dgvPedido, "select * from Pedido inner join Cliente on Pedido.idCliente = Cliente.idCliente", "Pedido");
        }

        //Buscar y/o rellendar campos//////////////////////////////////////////////////////////////////////////////////////
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string status = "En proceso";
            int cGB =0,cGM = 0,cGA=0;
            if (txtCanGB.Text != "")
                cGB = int.Parse(txtCanGB.Text);
            if (txtCanGM.Text != "")
                cGM = int.Parse(txtCanGM.Text);
            if (txtCanGA.Text != "")
                cGA = int.Parse(txtCanGA.Text);
            string values = string.Format(int.Parse(txtIDcliente.Text) + ",'" + lblFH.Text + "','" + status + "'," + cGB + "," + cGM + "," + cGA + ",'" + txtaCom.Text+"'");
            bool result = mV.altaTabla("Pedido(idCliente,Fecha,Status,CantGamaBaja,CantGamaMedia,CantGamaAlta,Observacion)", values);
            if (result)
            {
                MessageBox.Show("simona la mona");
                cargarTablas(dgvPedido,"select * from Pedido inner join Cliente on Pedido.idCliente = Cliente.idCliente" ,"Pedido");
                txtIDcliente.Text = "";
                txtCanGB.Text = "";
                txtCanGM.Text = "";
                txtCanGA.Text = "";
                chkGB.Checked = false;
                chkGM.Checked = false;
                chkGA.Checked = false;
                txtaCom.Text = "";
            }
        }

        //Insercion/////////////////////////////////////////////////////////////////////////////////////
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bool actu = mV.actuTabla("Pedido", "Status = 'Cancelado'", "where idPedido = " + int.Parse(txtIDBorrar.Text));
            if (actu)
                MessageBox.Show("Actualizado");
            else
                MessageBox.Show("Error");
            cargarTablas(dgvPedido, "select * from Pedido inner join Cliente on Pedido.idCliente = Cliente.idCliente", "Pedido");

        }

        //Actualizacion//////////////////////////////////////////////////////////////////////////////////////
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public void cargarTablas(DataGridView dgv, string query, string tablas)
        {
            DataSet cargar;
            cargar = mV.cargarTablas(query, tablas);
            dgv.DataSource = cargar;
            dgv.DataMember = tablas;
        }
    }
}
