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



namespace ERP.Ingenieria
{
    public partial class Ingenieria : Form
    {
        LogicaDeNegocios.metodosIngenieriaa MIngenieria = new metodosIngenieriaa();
        public Ingenieria()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnagregarmp_Click(object sender, EventArgs e)
        {
            bool result = MIngenieria.altaMateria(int.Parse(txtidmateria.Text), txttipo.Text, txtDesc.Text, txtFecha.Text, int.Parse(unidadtxt.Text));
            if (result)
            {
                MessageBox.Show("Se inserto con exito");
                txtidmateria.Clear();
                txttipo.Clear();
                txtDesc.Clear();
                txtFecha.Clear();
                unidadtxt.Clear();
            }
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }

        }
        private void ingenieriaform_Click(object sender, EventArgs e)
        {

        }

        private void btncapturarlin_Click(object sender, EventArgs e)
        {

        }

        private void Ingenieria_Load(object sender, EventArgs e)
        {
            MIngenieria.comboBox("select descripcion from Producto", "descripcion", cmbgamascp);
            // TODO: esta línea de código carga datos en la tabla 'erpdbDataSet3.InventarioProducto' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'erpdbDataSet1.MateriaPrima' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'erpdbDataSet2.MateriaPrima' Puede moverla o quitarla según sea necesario.
            //this.materiaPrimaTableAdapter.Fill(this.erpdbDataSet1.MateriaPrima);

            //this.reportViewer1.RefreshReport();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void btnagregarcomponentes_Click(object sender, EventArgs e)
        {
            //bool result = MIngenieria.altaProducto(int.Parse(txtidproducto.Text), txtdescripcion.Text, int.Parse(cantidadtxt.Text), int.Parse(txtlocalidad.Text), txtfhora.Text);
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
            //    txtidproducto.Clear();
            //    txtdescripcion.Clear();
            //    cantidadtxt.Clear();
            //    txtlocalidad.Clear();
            //    txtfhora.Clear();

            //}
        }

        private void rbnelimnar_CheckedChanged(object sender, EventArgs e)
        {
            txtidmateria.Visible = true;
            txtDesc.Visible = false;
            txtFecha.Visible = false;
            unidadtxt.Visible = false;
            txttipo.Visible = false;
            btneliminar.Visible = true;
            btnagregarmp.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label9.Visible = false;
            label6.Visible = false;
            btnmodificar.Visible = false;
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
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
        }

        private void rbdmodificar_CheckedChanged(object sender, EventArgs e)
        {
            txtidmateria.Visible = true;
            txtDesc.Visible = true;
            txtFecha.Visible = true;
            unidadtxt.Visible = true;
            txttipo.Visible = true;
            btneliminar.Visible = false;
            btnagregarmp.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            label9.Visible = true;
            label6.Visible = true;
            btnmodificar.Visible = true;
        }

        private void rbnagregar_CheckedChanged(object sender, EventArgs e)
        {
            txtidmateria.Visible = true;
            txtDesc.Visible = true;
            txtFecha.Visible = true;
            unidadtxt.Visible = true;
            txttipo.Visible = true;
            btneliminar.Visible = false;
            btnagregarmp.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label9.Visible = true;
            label6.Visible = true;
            btnmodificar.Visible = false;
        }

        private void rbnmodificar_CheckedChanged(object sender, EventArgs e)
        {
            txtidmateria.Visible = true;
            txtDesc.Visible = true;
            txtFecha.Visible = true;
            unidadtxt.Visible = true;
            txttipo.Visible = true;
            btneliminar.Visible = false;
            btnagregarmp.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            label9.Visible = true;
            label6.Visible = true;
            btnmodificar.Visible = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }
    }
}