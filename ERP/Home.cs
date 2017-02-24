using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produccion.Produccion frmP = new Produccion.Produccion();
            frmP.MdiParent = this;
            frmP.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
