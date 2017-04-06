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
        LogicaDeNegocios.Produccion.AgregarProduccion metodosAgregar = new LogicaDeNegocios.Produccion.AgregarProduccion();
        LogicaDeNegocios.Produccion.AdministrarProduccion metodosAdministrar = new LogicaDeNegocios.Produccion.AdministrarProduccion();
        
        public Produccion()
        {
            InitializeComponent();

            cboxBuscar.SelectedIndex = 0;

        }

        private void Produccion_Load(object sender, EventArgs e)
        {
            // Métodos para el primer tab
            metodosAgregar.LlenarTablaPlaneaciones(dgvPlaneaciones);
            metodosAgregar.LlenarDetalles(dgvPlaneaciones, txtIdPlaneacion, txtLinea, dtpFechaInicio, dtpFechaEstimada, lblTiempo);
            metodosAgregar.mostrarDetalle(lblDetalle, dgvPlaneaciones);

            // Métodos para el segundo tab
            metodosAdministrar.LlenarProducciones(dgvProducciones);

            // Método para el automaximizar
            this.WindowState = FormWindowState.Maximized;
        }

        // <<<<<<<<<<<<<<<<<<<<<< Inicio de métodos para agregar producción (tab 1) >>>>>>>>>>>>>>>>>>>>>>>>>>>

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            metodosAgregar.Buscar(cboxBuscar, txtBuscar, dgvPlaneaciones);
        }

        private void dgvPlaneaciones_Click(object sender, EventArgs e)
        {
            metodosAgregar.LlenarDetalles(dgvPlaneaciones, txtIdPlaneacion, txtLinea, dtpFechaInicio, dtpFechaEstimada, lblTiempo);
            metodosAgregar.mostrarDetalle(lblDetalle, dgvPlaneaciones);

        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            metodosAgregar.MostrarTiempo(dtpFechaInicio, dtpFechaEstimada, lblTiempo, dgvPlaneaciones);
        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            metodosAgregar.InsertarProduccion(dgvPlaneaciones, dtpFechaInicio, dtpFechaEstimada, txtObservaciones);
            metodosAgregar.LlenarTablaPlaneaciones(dgvPlaneaciones);
            metodosAgregar.LlenarDetalles(dgvPlaneaciones, txtIdPlaneacion, txtLinea, dtpFechaInicio, dtpFechaEstimada, lblTiempo);
            
        }

        // <<<<<<<<<<<<<<<<<<<<<< Final de métodos para agregar producción (tab 1) >>>>>>>>>>>>>>>>>>>>>>>>>>>


        private void tabProduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            metodosAdministrar.LlenarProducciones(dgvProducciones);
            metodosAgregar.LlenarTablaPlaneaciones(dgvPlaneaciones);
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            metodosAdministrar.AvanzarEtapa(dgvProducciones);
           
            metodosAdministrar.LlenarProducciones(dgvProducciones);
            metodosAdministrar.llenarEtapa(lblEtapa, prgrsEtapa, dgvProducciones);
            validarBotones();
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            metodosAdministrar.RetrocederEtapa(dgvProducciones);
            
            
            metodosAdministrar.llenarEtapa(lblEtapa, prgrsEtapa, dgvProducciones);
            validarBotones();

        }

        private void validarBotones()
        {
            string etapa = metodosAdministrar.RetornarValor(dgvProducciones, "Etapa");
            if (etapa == "8")
            {
                btnAvanzar.Enabled = false;
                btnRetroceder.Enabled = true;
            }
            else if(etapa == "1")
            {
                btnAvanzar.Enabled = true;
                btnRetroceder.Enabled = false;
            }
            else
            {
                btnAvanzar.Enabled = true;
                btnRetroceder.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de querer cancelar esta producción?\nRegresará a planeación.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (metodosAdministrar.CancelarProduccion(dgvProducciones))
                {
                    MessageBox.Show("La producción se ha regresado a planeación.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarTablaProduccion();
                } else
                {
                    MessageBox.Show("Ocurrió un error cancelando esta producción, contacte al administrador");
                }

            }
        }

        private void actualizarTablaProduccion()
        {
            metodosAdministrar.LlenarProducciones(dgvProducciones);
        }

        private void dgvProducciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metodosAdministrar.llenarEtapa(lblEtapa, prgrsEtapa, dgvProducciones);
            validarBotones();
        }
        
    }
}
