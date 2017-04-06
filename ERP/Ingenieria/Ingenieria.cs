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
            MIngenieria.llenarGridViewmateriaprima(dgwmateriaprima);
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
            MIngenieria.comboBox("select descripcion from Producto", "descripcion", cmbdiscodurocp);
            MIngenieria.comboBox("select descripcion from Producto", "descripcion", cmbdisipadorcp);
            MIngenieria.comboBox("select descripcion from Producto", "descripcion", cmbfuentepodercp);
            MIngenieria.comboBox("select descripcion from Producto", "descripcion", cmbmemoriaramcp);
            MIngenieria.comboBox("select descripcion from Producto", "descripcion", cmbprocesadorcp);
            MIngenieria.comboBox("select descripcion from Producto", "descripcion", cmbtarjetadevideocp);
            MIngenieria.comboBox("select descripcion from Producto", "descripcion", cmbtarjetamadrecp);
            MIngenieria.comboBox("select descripcion from Producto", "descripcion", cmbcasecp);
            MIngenieria.comboBox("Select descripcion from Produccion", "descripcion", cmbdescripcion);
            MIngenieria.comboBox("select idlinea from Linea", "idLinea", cmbidlinea);
            //MIngenieria.comboBox("select Tipo from MateriaPrima", "Tipo", cmbtipo);
            // TODO: esta línea de código carga datos en la tabla 'erpdbDataSet3.InventarioProducto' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'erpdbDataSet1.MateriaPrima' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'erpdbDataSet2.MateriaPrima' Puede moverla o quitarla según sea necesario.
            //this.materiaPrimaTableAdapter.Fill(this.erpdbDataSet1.MateriaPrima);

            //this.reportViewer1.RefreshReport();
            this.WindowState = FormWindowState.Maximized;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void btnagregarcomponentes_Click(object sender, EventArgs e)
        {
            bool result = MIngenieria.altaProducto(cmbdescripcion.Text, cmbidlinea.Text, cmbdestino.Text);
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
    }
}