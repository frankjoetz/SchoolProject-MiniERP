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
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Reporting.WinForms;
using Datos;

namespace ERP.Planeacion
{
    public partial class Planeacion : Form
    {
        LogicaDeNegocios.Planeacion.metodosPlaneacion planeacion = new LogicaDeNegocios.Planeacion.metodosPlaneacion();

        public Planeacion()
        {
            InitializeComponent();
           
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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
            // TODO: This line of code loads data into the 'ReporteDataSet.Planeacion' table. You can move, or remove it, as needed.
            this.PlaneacionTableAdapter.Fill(this.ReporteDataSet.Planeacion);
            // metodos implementados de llenado
            planeacion.LlenarTablaVistaPedidos(GridPedidos);
            planeacion.llenarPlaneaciones(GridPlaneacionesAgregadas);

            // inhabilitacion de txt y checkbox
            txtIdPedido.Enabled = false;
            dtpFechaInicio.Enabled = false;
            txtStatus.Enabled = false;
            txtAlta.Enabled = false;
            txtMedia.Enabled = false;
            txtBaja.Enabled = false;
            checkBoxGamaAlta.Enabled = false;
            checkBoxGamaMedia.Enabled = false;
            checkBoxGamaBaja.Enabled = false;
            comboBoxBuscarPedido.SelectedIndex = 0;
            this.reportViewer1.RefreshReport();
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
            if (txtAlta.Text != "0")
            {
                planeacion.InsertarPlaneacionAlta(txtIdPedido, txtAlta, dtpFechaInicio, DTPFechaEntrega, txtStatus, txtObservaciones);
                planeacion.llenarPlaneaciones(GridPlaneacionesAgregadas);

            }
            if (txtMedia.Text != "0")
            {
                planeacion.InsertarPlaneacionMedia(txtIdPedido, txtMedia, dtpFechaInicio, DTPFechaEntrega, txtStatus, txtObservaciones);
                planeacion.llenarPlaneaciones(GridPlaneacionesAgregadas);
            }
            if (txtBaja.Text != "0")
            {
                planeacion.InsertarPlaneacionBaja(txtIdPedido, txtBaja, dtpFechaInicio, DTPFechaEntrega, txtStatus, txtObservaciones);
                planeacion.llenarPlaneaciones(GridPlaneacionesAgregadas);
            }
        }

        private void txtbId_ped_buscar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarPedido_TextChanged(object sender, EventArgs e)
        {
            planeacion.Buscar(comboBoxBuscarPedido,txtBuscarPedido,GridPedidos);
        }

        private void txtBuscarPedido_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void GridPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // llenar textbox con informacion del GRIDVIEW
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.GridPedidos.Rows[e.RowIndex];

                txtIdPedido.Text = row.Cells["idPedido"].Value.ToString();
                dtpFechaInicio.Value = DateTime.Parse(row.Cells["Fecha"].Value.ToString());
                txtStatus.Text = "Listo para producir";
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAlerta_Click(object sender, EventArgs e)
        {
            MandarAlerta mandaralerta = new MandarAlerta();
            mandaralerta.Show();

        }

        private void Planeacion_Shown(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // metodos implementados de llenado
            planeacion.LlenarTablaVistaPedidos(GridPedidos);
            planeacion.llenarPlaneaciones(GridPlaneacionesAgregadas);

            
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
