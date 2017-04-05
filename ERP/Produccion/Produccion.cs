using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Produccion
{
    public partial class Produccion : Form
    {
        LogicaDeNegocios.Produccion.metodosProduccion metodos = new LogicaDeNegocios.Produccion.metodosProduccion();
        
        public Produccion()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            cboxBuscar.SelectedIndex = 0;

        }

        private void Produccion_Load(object sender, EventArgs e)
        {
            metodos.LlenarTablaPlaneaciones(dgvPlaneaciones);
            metodos.LlenarDetalles(dgvPlaneaciones, txtIdPlaneacion, txtLinea, dtpFechaInicio, dtpFechaEstimada, lblTiempo);
            metodos.mostrarDetalle(lblDetalle, dgvPlaneaciones);
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            metodos.Buscar(cboxBuscar, txtBuscar, dgvPlaneaciones);
        }

        private void dgvPlaneaciones_Click(object sender, EventArgs e)
        {
            metodos.LlenarDetalles(dgvPlaneaciones, txtIdPlaneacion, txtLinea, dtpFechaInicio, dtpFechaEstimada, lblTiempo);
            metodos.mostrarDetalle(lblDetalle, dgvPlaneaciones);

        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            metodos.MostrarTiempo(dtpFechaInicio, dtpFechaEstimada, lblTiempo, dgvPlaneaciones);
        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            metodos.AgregarProduccion(dgvPlaneaciones, dtpFechaInicio, dtpFechaEstimada, txtObservaciones);
            metodos.LlenarTablaPlaneaciones(dgvPlaneaciones);
            metodos.LlenarDetalles(dgvPlaneaciones, txtIdPlaneacion, txtLinea, dtpFechaInicio, dtpFechaEstimada, lblTiempo);
            
        }

    }
}
