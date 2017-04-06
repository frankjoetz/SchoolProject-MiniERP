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

namespace ERP.Planeacion
{
    public partial class MandarAlerta : Form
    {
        LogicaDeNegocios.Planeacion.metodosPlaneacion planeacion = new LogicaDeNegocios.Planeacion.metodosPlaneacion();

        public MandarAlerta()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            planeacion.MandarAlerta(txtMotivoAlerta);
            this.Dispose();
            
        }
    }
}
