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
        
        public Ingenieria()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnagregarmp_Click(object sender, EventArgs e)
        {
            LogicaDeNegocios.metodosIngenieria mI = new metodosIngenieria();
            int x = mI.altaMateriaPrima(int.Parse(idmateriatxt.Text), txtDesc.Text, txtFecha.Text);
        }

        private void ingenieriaform_Click(object sender, EventArgs e)
        {

        }

        private void btncapturarlin_Click(object sender, EventArgs e)
        {

        }
    }
}
