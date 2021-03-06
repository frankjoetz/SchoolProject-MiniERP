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



namespace ERP.Ingenieria
{
    public partial class Ingenieria : Form
    {
        LogicaDeNegocios.metodosIngenieriaa MIngenieria = new metodosIngenieriaa();
        public Ingenieria()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            MIngenieria.llenarGridViewmateriaprima(dgwmateriaprima);
            MIngenieria.comboBox("select idLinea, descripcion from Linea","idLinea, descripcion", cmblineacp);
        }

        private void ingenieriaform_Click(object sender, EventArgs e)
        {

        }

        private void btncapturarlin_Click(object sender, EventArgs e)
        {

        }

        private void Ingenieria_Load(object sender, EventArgs e)
        {
            
            //this.reportViewer1.RefreshReport();
            this.WindowState = FormWindowState.Maximized;
            MIngenieria.comboBox("select DISTINCT Tipo from MateriaPrima ", "Tipo", cmbprocesadorcp);
            MIngenieria.comboBox("select descripcion from MateriaPrima where Tipo = '"+cmbprocesadorcp.Text+"'", "descripcion", cmbmemoriaramcp);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }

        //private void btnagregarcomponentes_Click(object sender, EventArgs e)
        //{
        //    bool result = MIngenieria.altaProducto(cmbdescripcion.Text, dtpfecha.Value.ToString("yyyy-MM-dd"), cmbdestino.Text);
        //    if (result)
        //    {
        //        MessageBox.Show("Se inserto con exito");
        //        try
        //        {
        //        }
        //        catch (System.Exception ex)
        //        {
        //            System.Windows.Forms.MessageBox.Show(ex.Message);
        //        }


        //    }
        //}

        private void rbnelimnar_CheckedChanged(object sender, EventArgs e)
        {
            txtidmateria.Visible = true;
            txtDesc.Visible = false;
            cmbtipo.Visible = false;
            btneliminar.Visible = true;
            btnagregarmp.Visible = false;
            lbldesc.Visible = false;
            lblfecha.Visible = false;
            lbltipo.Visible = false;
            btnmodificar.Visible = false;
            pikerfecha.Visible = false;
            lblidmateria.Visible = true;

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
        }

        private void rbdmodificar_CheckedChanged(object sender, EventArgs e)
        {
            //nombre.value.ToString("yyyy-MM-dd");
            txtidmateria.Visible = true;
            txtDesc.Visible = true;
            cmbtipo.Visible = true;
            btneliminar.Visible = false;
            btnagregarmp.Visible = false;
            lbldesc.Visible = true;
            lblfecha.Visible = true;
            lbltipo.Visible = true;
            btnmodificar.Visible = true;
            pikerfecha.Visible = true;
        }

        //private void rbnagregar_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtidmateria.Visible = false;
        //    txtDesc.Visible = true;


        //    cmbtipo.Visible = true;
        //    btneliminar.Visible = false;
        //    btnagregarmp.Visible = true;
        //    lbldesc.Visible = true;
        //    lblfecha.Visible = true;

        //    lbltipo.Visible = true;
        //    btnmodificar.Visible = false;
        //}

        private void rbnmodificar_CheckedChanged(object sender, EventArgs e)
        {
            txtidmateria.Visible = true;
            txtDesc.Visible = true;
            cmbtipo.Visible = true;
            btneliminar.Visible = false;
            btnagregarmp.Visible = false;
            lbldesc.Visible = true;
            lblfecha.Visible = true;
            lbltipo.Visible = true;
            btnmodificar.Visible = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnagregarmp_Click_1(object sender, EventArgs e)
        {
            bool result = MIngenieria.altaMateria(cmbtipo.Text, txtDesc.Text, pikerfecha.Value.ToString("yyyy-MM-dd"));
            if (result)
            {
                MessageBox.Show("Se inserto con exito");
                MIngenieria.llenarGridViewmateriaprima(dgwmateriaprima);
                txtDesc.Clear();
                cmbtipo.Text = null;
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos");
                txtDesc.Focus();
            }
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }

        private void cmbdescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbgamascp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btningresarpro_Click(object sender, EventArgs e)
        {
            bool result = MIngenieria.altaProducto(cmbdescripcion.Text, cmbdestino.Text, dtpfecha.Value.ToString("yyyy-MM-dd"));
            if (result)
            {
                MessageBox.Show("Se inserto con exito");
                try
                {
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }


            }
        }

        private void btnmodificar_Click_1(object sender, EventArgs e)
        {

        }

        private void rbnmodificar_CheckedChanged_1(object sender, EventArgs e)
        {
            txtidmateria.Visible = true;
            txtDesc.Visible = true;
            cmbtipo.Visible = true;
            btneliminar.Visible = false;
            btnagregarmp.Visible = false;
            lbldesc.Visible = true;
            lblfecha.Visible = true;
            lbltipo.Visible = true;
            btnmodificar.Visible = true;

        }

        private void btnagregarcomponentes_Click(object sender, EventArgs e)
        {
            int cantidad = Int32.Parse(nudCantidad.Value.ToString());

            //bool result = MIngenieria.altaconsumo(Int32.Parse(lblIdShow.Text), cmbmemoriaramcp.Text, cmblineacp.Text, cantidad);
            //if (result)
            //{
            //    MessageBox.Show("Se inserto con exito");
            //    try
            //    {
            //    }
            //    catch (System.Exception ex)
            //    {
            //        System.Windows.Forms.MessageBox.Show(ex.Message);
            //    }
            //}
        }

        private void rbnelimnar_CheckedChanged_1(object sender, EventArgs e)
        {
            txtidmateria.Visible = true;
            txtDesc.Visible = false;
            cmbtipo.Visible = false;
            btneliminar.Visible = true;
            btnagregarmp.Visible = false;
            lbldesc.Visible = false;
            lblfecha.Visible = false;
            lbltipo.Visible = false;
            btnmodificar.Visible = false;
            pikerfecha.Visible = false;
            lblidmateria.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void gbMaterial_Enter(object sender, EventArgs e)
        {

        }

        private void txtgama_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbmemoriaramcp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ingenieriatc_SelectedIndexChanged(object sender, EventArgs e)
        {
            MIngenieria.llenaGriedViewConsumos(dataGridViewConsumo);
            MIngenieria.llenarGridViewmateriaprima(dgwmateriaprima);
            MIngenieria.llenarGridViewGamas(dataGridViewGamas);
        }

        private void dataGridViewGamas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridViewGamas.Rows[dataGridViewGamas.CurrentRow.Index].Cells["IdProducto"].Value.ToString();
            lblIdShow.Text = id;
            string gama = dataGridViewGamas.Rows[dataGridViewGamas.CurrentRow.Index].Cells["descripcion"].Value.ToString();
            txtgama.Text = gama;
            cmbmemoriaramcp.Text = null;
            cmbprocesadorcp.Text = null;
            cmbmemoriaramcp.Items.Clear();
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            bool result = MIngenieria.EliminaMateria(int.Parse(txtidmateria.Text));
            if (result)
            {
                MessageBox.Show("Se elimino con exito");
            }
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            MIngenieria.llenarGridViewmateriaprima(dgwmateriaprima);
            txtidmateria.Clear();
        }

        private void cmbprocesadorcp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbmemoriaramcp.Text = null;
            cmbmemoriaramcp.Items.Clear();
            MIngenieria.comboBox("select descripcion from MateriaPrima where Tipo = '"+cmbprocesadorcp.Text+"'", "descripcion", cmbmemoriaramcp);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bmblineacp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void lblIdShow_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtidmateria.Visible = false;
            txtDesc.Visible = true;
            cmbtipo.Visible = true;
            btneliminar.Visible = false;
            btnagregarmp.Visible = true;
            lbldesc.Visible = true;
            lblfecha.Visible = true;
            lbltipo.Visible = true;
            btnmodificar.Visible = false;
            pikerfecha.Visible = true;
            lblidmateria.Visible = false;
        }

    }
}