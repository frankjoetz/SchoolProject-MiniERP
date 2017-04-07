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
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //mV.comboBox("select descripcion from Producto", "descripcion", cmbGamas);
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
            {
                txtCanGB.Text = "";
                txtCanGB.Enabled = false;
            }
            if (chkGM.Checked)
                txtCanGM.Enabled = true;
            else
            {
                txtCanGM.Text = "";
                txtCanGM.Enabled = false;
            }
            if (chkGA.Checked)
                txtCanGA.Enabled = true;
            else
            {
                txtCanGA.Text = "";
                txtCanGA.Enabled = false;
            }
        }

        //Timers//////////////////////////////////////////////////////////////////////////////////////////
        private void btnAddC_Click_1(object sender, EventArgs e)
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
            int id = int.Parse(mV.buscarUnDato("idCliente", "Cliente", "Limit 1"));
            int id2 = int.Parse(mV.buscarUnDato("idCliente", "Cliente", "ORDER BY idCliente DESC Limit 1"));
            try
            {
                if (int.Parse(txtIDcliente.Text) >= id && int.Parse(txtIDcliente.Text) <= id2)
                {
                    if (txtIDcliente.Text != "")
                    {
                        txtNombre.Text = mV.buscarUnDato("nombre", "Cliente", " where idCliente = " + txtIDcliente.Text);
                        txtEmpresa.Text = mV.buscarUnDato("empresa", "Cliente", " where idCliente = " + txtIDcliente.Text);
                    }
                    if (txtIDcliente.Text == "")
                    {
                        txtNombre.Text = "";
                        txtEmpresa.Clear();
                    }
                }
            }
            catch { }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtNomb.Text != "")
            {
                txtApell.Enabled = true;
                if (txtEmp.Text != "" && txtApell.Text != "")
                    cargarTablas(dgvBuscar, string.Format("select * from Cliente where Nombre like '" + txtNomb.Text + "%' and Apellido like '" + txtApell.Text + "%' and Empresa like '" + txtEmp.Text + "%'"), "Cliente");
                if (txtApell.Text != "")
                    cargarTablas(dgvBuscar, string.Format("select * from Cliente where Nombre like '" + txtNomb.Text + "%' and Apellido like '" + txtApell.Text + "%'"), "Cliente");
                if (txtEmp.Text == "" && txtApell.Text == "")
                    cargarTablas(dgvBuscar, string.Format("select * from Cliente where Nombre like '" + txtNomb.Text + "%'"), "Cliente");
            }
            if (txtEmp.Text != "")
            {
                if (txtEmp.Text != "")
                    cargarTablas(dgvBuscar, string.Format("select * from Cliente where Empresa like '" + txtEmp.Text + "%'"), "Cliente");
                if (txtApell.Text != "")
                    cargarTablas(dgvBuscar, string.Format("select * from Cliente where Nombre like '" + txtNomb.Text + "%' and Apellido like '" + txtApell.Text + "%'"), "Cliente");
            }
            if (txtNomb.Text == "" && txtEmp.Text == "")
            {
                txtApell.Enabled = false;
                cargarTablas(dgvBuscar, "select * from Cliente", "Cliente");
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
            if (txtIDHis.Text == "" && txtNomCliHis.Text == "")
                cargarTablas(dgvPedido, "select * from Pedido inner join Cliente on Pedido.idCliente = Cliente.idCliente", "Pedido");
        }

        //Buscar y/o rellendar campos//////////////////////////////////////////////////////////////////////////////////////
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(mV.buscarUnDato("idCliente", "Cliente", "Limit 1"));
                int id2 = int.Parse(mV.buscarUnDato("idCliente", "Cliente", "ORDER BY idCliente DESC Limit 1"));
                if (int.Parse(txtIDcliente.Text)>=id && (int.Parse(txtIDcliente.Text)<=id2))
                {
                    string status = "En proceso";
                    int cGB = 0, cGM = 0, cGA = 0;
                    if (txtCanGB.Text != "")
                        cGB = int.Parse(txtCanGB.Text);
                    if (txtCanGM.Text != "")
                        cGM = int.Parse(txtCanGM.Text);
                    if (txtCanGA.Text != "")
                        cGA = int.Parse(txtCanGA.Text);
                    string values = string.Format(int.Parse(txtIDcliente.Text) + ",'" + lblFH.Text + "','" + status + "'," + cGB + "," + cGM + "," + cGA + ",'" + txtaCom.Text + "'");
                    bool result = mV.altaTabla("Pedido(idCliente,Fecha,Status,CantGamaBaja,CantGamaMedia,CantGamaAlta,Observacion)", values);
                    if (result)
                    {
                        MessageBox.Show("Pedido agregado");
                        txtIDcliente.Text = "";
                        txtCanGB.Text = "";
                        txtCanGM.Text = "";
                        txtCanGA.Text = "";
                        chkGB.Checked = false;
                        chkGM.Checked = false;
                        chkGA.Checked = false;
                        txtaCom.Text = "";
                    }
                    else
                        MessageBox.Show("Ingresa un cliente válido");
                }
            }
            catch {}
        }

        //Insercion/////////////////////////////////////////////////////////////////////////////////////
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                bool actu = mV.actuTabla("Pedido", "Status = 'Cancelado'", "where idPedido = " + int.Parse(txtIDBorrar.Text));
                if (actu)
                    MessageBox.Show("Cancelado");
                else
                    MessageBox.Show("Error");
                cargarTablas(dgvPedido, "select * from Pedido inner join Cliente on Pedido.idCliente = Cliente.idCliente", "Pedido");
            }
            catch { }
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

        private void tbcVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbcVentas.SelectedIndex == 2)
                    cargarTablas(dgvBuscar, "select * from Cliente", "Cliente");
                if (tbcVentas.SelectedIndex == 1)
                    cargarTablas(dgvPedido, "select Pedido.idPedido, Pedido.idCliente, Pedido.Fecha, Pedido.Status, Pedido.CantGamaBaja, Pedido.CantGamaMedia, Pedido.CantGamaAlta, Pedido.Observacion, Cliente.Nombre, Cliente.Apellido, Cliente.Empresa, Cliente.email from Pedido inner join Cliente on Pedido.idCliente = Cliente.idCliente", "Pedido");

                int id = int.Parse(mV.buscarUnDato("idCliente", "Cliente", "Limit 1"));
                int id2 = int.Parse(mV.buscarUnDato("idCliente", "Cliente", "ORDER BY idCliente DESC Limit 1"));
                if (int.Parse(txtIDcliente.Text) < id || int.Parse(txtIDcliente.Text) > id2)
                {
                    tbcVentas.SelectedIndex = 0;
                }
            }
            catch { }
        }

        //////Filtros de Caracteres en Textbox//////////////////////////////////////////////////////////////////////////////////////
        private void txtIDcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIDHis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNomCliHis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        ///Igual son filtros pero de las Gama Alta,Media & Baja//////////////////////
        private void txtCanGB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCanGM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCanGA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIDcliente_Leave(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(mV.buscarUnDato("idCliente", "Cliente", "Limit 1"));
                int id2 = int.Parse(mV.buscarUnDato("idCliente", "Cliente", "ORDER BY idCliente DESC Limit 1"));
                if (int.Parse(txtIDcliente.Text) < id || int.Parse(txtIDcliente.Text) > id2)
                {
                    MessageBox.Show("No existe cliente");
                    txtIDcliente.Focus();
                    txtNombre.Clear();
                    txtEmpresa.Clear();
                }
            }
            catch { 
            }
        }

        private void cmbGamas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    string materia;
            //    string condicion;
            //    if (cmbGamas.SelectedIndex  == 0)
            //        {
            //            string idmat = mV.buscarUnDato("idMateria", "Consumo", " where idproducto = " + 1);
            //            materia = string.Format("descripcion");
            //            condicion = "where idMateria = " + idmat +" ORDER BY idMateria ASC "+" LIMIT ";
            //            lblDescrip.Text = string.Format(mV.buscarUnDato(materia, "MateriaPrima", condicion + 1) + ", " + mV.buscarUnDato(materia, "MateriaPrima", condicion + 2) + ", " + mV.buscarUnDato(materia, "MateriaPrima", condicion + 3) + ", " + mV.buscarUnDato(materia, "MateriaPrima", condicion + 4) + ", " + mV.buscarUnDato(materia, "MateriaPrima", condicion + 5) + ", " + mV.buscarUnDato(materia, "MateriaPrima", condicion + 6) + ", " + mV.buscarUnDato(materia, "MateriaPrima", condicion + 7) + ", " + mV.buscarUnDato(materia, "MateriaPrima", condicion + 8) + ", " + mV.buscarUnDato(materia, "MateriaPrima", condicion + 9) + ", " + mV.buscarUnDato(materia, "MateriaPrima", condicion + 10));
            //        }
            //}
            //catch { }
        }
    }
}
