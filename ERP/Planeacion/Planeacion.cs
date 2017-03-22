﻿using System;
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
            planeacion.llenarGridViewPlaneacion(DGVPlaneacion);
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
            planeacion.llenarComboBox(cbxPedido);
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
            if (planeacion.insertarNuevaPlaneacion(cbxPedido.SelectedItem.ToString(), dateFechaInicio.Value.ToString("yyyy-MM-dd"), dateFechaEntrega.Value.ToString("yyyy-MM-dd"), cbxStatus.SelectedItem.ToString(), txtObservaciones.Text.ToString()))
            {
                planeacion.llenarGridViewPlaneacion(DGVPlaneacion);
                MessageBox.Show("El valor se insertó correctamente");
            }
            else
            {
                MessageBox.Show("Ocurrió un error insertando");
            }
        }

        private void txtbId_ped_buscar_TextChanged(object sender, EventArgs e)
        {
            LogicaDeNegocios.Planeacion.metodosPlaneacion plan = new LogicaDeNegocios.Planeacion.metodosPlaneacion();
            plan.BuscarPlaneacion(DGVPlaneacion,txtPedido, dateBuscar);
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
