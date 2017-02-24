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
        public static Produccion.Produccion frmP = new Produccion.Produccion();
        public static Ingenieria.Ingenieria frmI = new Ingenieria.Ingenieria();

        public void esconderForms()
        {
            frmI.Hide();
            frmP.Hide();
        }

        public Home()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            frmI.MdiParent = this;
            frmP.MdiParent = this;
            
        }

        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esconderForms();
            frmP.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void ingenieríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esconderForms();
            frmI.Show();
        }
    }
}
