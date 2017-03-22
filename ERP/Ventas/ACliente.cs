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

namespace ERP.Ventas
{
    public partial class ACliente : Form
    {
        LogicaDeNegocios.Ventas.metodosVentas mV = new LogicaDeNegocios.Ventas.metodosVentas();
        public ACliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int status = 0;
            if (chbStatus.Checked)
            {
                status = 1;
                bool result = mV.altaCliente(txtNombre.Text, txtApe.Text, txtEmpresa.Text, Int32.Parse(txtTel.Text), txtDir.Text, txtEmail.Text, status);
                if (result)
                {
                    MessageBox.Show("Si se pudo!");
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Se pudo, pero el cliente esta muerto");
                this.Dispose();
            }
            
        }
    }
}
