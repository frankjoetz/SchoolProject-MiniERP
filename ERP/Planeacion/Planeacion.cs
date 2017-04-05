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

namespace ERP.Planeacion
{
    public partial class Planeacion : Form
    {
        LogicaDeNegocios.Planeacion.metodosPlaneacion planeacion = new LogicaDeNegocios.Planeacion.metodosPlaneacion();

        public Planeacion()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
           
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Planeacion_Load(object sender, EventArgs e)
        {
            planeacion.LlenarTablaVistaPedidos(GridPedidos);
            planeacion.llenarPlaneaciones(GridPlaneacionesAgregadas);
            txtIdPedido.Enabled = false;
            txtFechaInicio.Enabled = false;
            txtStatus.Enabled = false;
            txtAlta.Enabled = false;
            txtMedia.Enabled = false;
            txtBaja.Enabled = false;
            checkBoxGamaAlta.Enabled = false;
            checkBoxGamaMedia.Enabled = false;
            checkBoxGamaBaja.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtbStatus_buscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNuevaPlaneacion_Click(object sender, EventArgs e)
        {
            
        }

        private void txtbId_ped_buscar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarPedido_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBuscarPedido_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void GridPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridPedidos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // llenar textbox con informacion del GRIDVIEW
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.GridPedidos.Rows[e.RowIndex];

                txtIdPedido.Text = row.Cells["idPedido"].Value.ToString();
                txtFechaInicio.Text = row.Cells["Fecha"].Value.ToString();
                txtStatus.Text = row.Cells["Status"].Value.ToString();
                txtAlta.Text = row.Cells["CantGamaAlta"].Value.ToString();
                txtMedia.Text =  row.Cells["CantGamaMedia"].Value.ToString();
                txtBaja.Text = row.Cells["CantGamaBaja"].Value.ToString();

            // llenar o quitar checkbox
                //alta
                if (int.Parse(txtAlta.Text) >= 1)
                {
                    checkBoxGamaAlta.Checked = true;
                }
                if (int.Parse(txtAlta.Text) == 0)
                {
                    checkBoxGamaAlta.Checked = false;
                }
                //media
                if (int.Parse(txtMedia.Text) >= 1)
                {
                    checkBoxGamaMedia.Checked = true;
                }
                if (int.Parse(txtMedia.Text) == 0)
                {
                    checkBoxGamaMedia.Checked = false;
                }
                //baja
                if (int.Parse(txtBaja.Text) >= 1)
                {
                    checkBoxGamaBaja.Checked = true;
                }

                if (int.Parse(txtBaja.Text) == 0)
                {
                    checkBoxGamaBaja.Checked = false;
                }
                
            }
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void txtBuscarPedido_Enter(object sender, EventArgs e)
        {
            planeacion.Buscar(comboBoxBuscarPedido, txtBuscarPedido, GridPedidos);
        }
    }
}
