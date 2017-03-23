using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Almacen
{
    public partial class Almacen : Form
    {
        LogicaDeNegocios.Compras.metodosCompras comp = new LogicaDeNegocios.Compras.metodosCompras();

        public Almacen()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            comp.llenarGridViewLocacion(GridViewLocacion);
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
        }

    }
}
