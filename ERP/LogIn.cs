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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        LogicaDeNegocios.Ventas.metodosVentas datos = new LogicaDeNegocios.Ventas.metodosVentas();

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        ////////
        public string validar()
        {
            return datos.buscarUnDato("Puesto","Usuario"," where Nickname like '"+txtUserName.Text+"' and password like '"+txtPassword.Text+"'");
        }
        ////////
        
    }
}
