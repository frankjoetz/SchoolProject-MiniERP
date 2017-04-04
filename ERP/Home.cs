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

namespace ERP
{
    public partial class Home : Form
    {
        public static Produccion.Produccion frmPr = new Produccion.Produccion();
        public static Ingenieria.Ingenieria frmIn = new Ingenieria.Ingenieria();
        public static Planeacion.Planeacion frmPl = new Planeacion.Planeacion();
        public static Ventas.Ventas frmVe = new Ventas.Ventas();
        public static Dashboard.Dashboard frmDsh = new Dashboard.Dashboard();
        public static Compras.Compras frmCo = new Compras.Compras();
        LogIn frmLogin;

        public void esconderForms()
        {
            frmIn.Hide();
            frmPl.Hide();
            frmPr.Hide();
            frmVe.Hide();
            frmDsh.Hide();
            frmCo.Hide();
        }

        public Home()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            frmIn.MdiParent = this;
            frmPl.MdiParent = this;
            frmPr.MdiParent = this;
            frmVe.MdiParent = this;
            frmDsh.MdiParent = this;
            frmCo.MdiParent = this;
        }

        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esconderForms();
            frmPr.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            frmLogin = new LogIn();
            frmLogin.MdiParent = this;
            frmLogin.FormClosed += new FormClosedEventHandler(LogIn_FormClosed);
            frmLogin.Show();
            //--//
            strpHome.Items[1].Enabled = false;
            strpHome.Items[2].Enabled = false;
            strpHome.Items[3].Enabled = false;
            strpHome.Items[4].Enabled = false;
            strpHome.Items[5].Enabled = false;
            strpHome.Items[6].Enabled = false;
        }
        /////////////
        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmLogin != null)
            {
                string puesto = frmLogin.validar();
                if (puesto == "Vendedor")
                {
                    strpHome.Items[1].Enabled = false;
                    strpHome.Items[2].Enabled = false;
                    strpHome.Items[3].Enabled = true;
                    strpHome.Items[4].Enabled = false;
                    strpHome.Items[5].Enabled = false;
                    strpHome.Items[6].Enabled = false;
                }
                if (puesto == "Master")
                {
                    strpHome.Items[1].Enabled = true;
                    strpHome.Items[2].Enabled = true;
                    strpHome.Items[3].Enabled = true;
                    strpHome.Items[4].Enabled = true;
                    strpHome.Items[5].Enabled = true;
                    strpHome.Items[6].Enabled = true;
                }
            }
        }
        ////////////

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

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esconderForms();
            frmDsh.Show();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esconderForms();
            frmCo.Show();
        }        
    }
}
