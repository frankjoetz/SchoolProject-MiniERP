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
            string status = "'Activo'";
            string valores = "'" + txtNombre.Text + "','" + txtApe.Text + "','" + txtEmpresa.Text + "'," +Int32.Parse(mtxtTel.Text) + ",'" + txtDir.Text + "','" + txtEmail.Text + "'," + status;
            bool result = mV.altaTabla("Cliente(Nombre,Apellido,Empresa,Telefono,Direccion,email,StatusCliente)",valores);
            if (result)
            {
                MessageBox.Show("Si se pudo!");
                this.Dispose();
            }
            
        }
    }
}
