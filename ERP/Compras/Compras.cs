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
            comp.llenarGridViewCaptura(GridViewCapturar);
        }

        private int idLocacion;
        public int IdLocacion
        {
            get{return idLocacion;}
            set{idLocacion = value;}
        }

        private string FechaCreada;
        public string FechaCreada1
        {
            get{return FechaCreada;}
            set{FechaCreada = value;}
        }

        private string descripcion;
        public string Descripcion
        {
            get{return descripcion;}
            set{descripcion = value;}
        }

        
        

        private void Almacen_Load(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool loca = comp.altaLocacion(int.Parse(txtIdLocacion.Text), richTxtDescripcion.Text, DTPfechacreado.Value.ToString("yyyy-MM-dd"));
            if (loca)
                MessageBox.Show("Locacion agregada correctamente");
            comp.llenarGridViewLocacion(GridViewLocacion);
        }

        

        
    }
}
