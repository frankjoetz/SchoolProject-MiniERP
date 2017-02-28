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
        public static Produccion.Produccion frmPr = new Produccion.Produccion();
        public static Ingenieria.Ingenieria frmIn = new Ingenieria.Ingenieria();
        public static Planeacion.Planeacion frmPl = new Planeacion.Planeacion();
        public static Ventas.Ventas frmVe = new Ventas.Ventas();


        public void esconderForms()
        {
            frmIn.Hide();
            frmPl.Hide();
            frmPr.Hide();
            frmVe.Hide();
        }

        public Home()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            frmIn.MdiParent = this;
            frmPl.MdiParent = this;
            frmPr.MdiParent = this;
            frmVe.MdiParent = this;
            
        }

        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esconderForms();
            frmPr.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void ingenieríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esconderForms();
            frmIn.Show();
        }

        private void planeaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esconderForms();
            frmPl.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esconderForms();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esconderForms();
            frmVe.Show();
        }
    }
}
