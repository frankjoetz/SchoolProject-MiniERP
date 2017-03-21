﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Ventas
{
    public partial class Ventas : Form
    {
        
        public Ventas()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFH.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            ACliente agc = new ACliente();
            agc.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BCliente bsc = new BCliente();
            bsc.Show();
        }
    }
}