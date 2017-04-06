using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocios.Produccion; // Cargar métodos de producción

namespace ERP.Produccion
{
    public partial class Produccion : Form
    {
        Metodos met = new Metodos(); // Instanciar métodos de la Lógica de negocios
        
        public Produccion()
        {
            InitializeComponent();
            // Métodos a llamar cuando el form se instancia
            cboxBuscar.SelectedIndex = 0;
            this.WindowState = FormWindowState.Maximized;

            // Métodos para primer tab 
            ActualizarTabla(dgvPlaneaciones);
            ControlesActivados(1, false);
            EvaluarNumeroFilas();

        }

        private void tabProduccion_SelectedIndexChanged(object sender, EventArgs e)
        { // Métodos a llamar cuando se cambia de tab
            ActualizarTabla(dgvProducciones);
            ActualizarTabla(dgvPlaneaciones);
            ActualizarTabla(dgvPedidos);
            ControlesActivados(1, false);
            ControlesActivados(2, false);
        }

        // ◘◘◘◘◘ Eventos relacionados a tab 1 (Agregar una producción) ◘◘◘◘◘

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        { // Evento de tecla en TextBox búsqueda
            met.FiltrarPlaneacion(cboxBuscar, txtBuscar, dgvPlaneaciones);
            ControlesActivados(1, false);
        }

        private void dgvPlaneaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        { // Evento de click en celda de tabla Planeaciones
            met.LlenarDetallesPlaneacion(dgvPlaneaciones, txtIdPlaneacion, txtLinea, dtpFechaInicio, dtpFechaEstimada, lblTiempo);
            met.MostrarDetallePlaneacion(lblDetalle, dgvPlaneaciones);
            ControlesActivados(1, true);
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        { // Evento para fecha de inicio modificada
            met.MostrarTiempo(dtpFechaInicio, dtpFechaEstimada, lblTiempo, dgvPlaneaciones);
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        { // Evento para click en botón de "Comenzar a producir"
            met.InsertarProduccion(dgvPlaneaciones, dtpFechaInicio, dtpFechaEstimada, txtObservaciones);
            ActualizarTabla(dgvPlaneaciones);
            ControlesActivados(1, false);
            EvaluarNumeroFilas();
        }

        // ◘◘◘◘◘ Métodos para eventos de Administrar producciones (tab2) ◘◘◘◘◘

        private void dgvProducciones_CellClick(object sender, DataGridViewCellEventArgs e)
        { // Evento de click en celda de tabla producciones
            met.LlenarDetallesProduccion(lblEtapa, prgrsEtapa, dgvProducciones);
            ControlesActivados(2, true);
            if (dgvProducciones.SelectedRows[0].Cells["Etapa"].Value.ToString() == "1")
                btnRetroceder.Enabled = false;
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        { // Evento para click en botón de Cancelar
            if(MessageBox.Show("¿Estás seguro de querer cancelar esta producción?\nRegresará a planeación.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (met.CancelarProduccion(dgvProducciones))
                {
                    MessageBox.Show("La producción se ha regresado a planeación.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarTabla(dgvProducciones);
                    ControlesActivados(2, false);
                }
                else
                    MessageBox.Show("Ocurrió un error cancelando esta producción, contacte al administrador");
            }
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        { // Evento para click en botón de Avanzar
            if (met.AvanzarEtapa(dgvProducciones))
            {
                ActualizarTabla(dgvProducciones);
                met.LlenarDetallesProduccion(lblEtapa, prgrsEtapa, dgvProducciones);
                ControlesActivados(2, false); // Si se llegó a 8, desactiva los controles
            }
            else
            {
                met.LlenarDetallesProduccion(lblEtapa, prgrsEtapa, dgvProducciones);
                ActualizarTabla(dgvProducciones);
                ControlesActivados(2, true); // Si no se llegó a la 8, activa los controles
            }
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        { // Evento para click en botón de Retroceder
            if (met.RetrocederEtapa(dgvProducciones))
            {
                ActualizarTabla(dgvProducciones);
                ControlesActivados(2, false); // Si se llegó a 8, desactiva los controles
            }
            else
            {
                ActualizarTabla(dgvProducciones);
                ControlesActivados(2, true); // Si no se llegó a la 8, activa los controles
            }

        }

        // ◘◘◘◘◘ Métodos para eventos de tab 3 (Entregar pedido) ◘◘◘◘◘

         private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (met.ActualizarProduccionesCorrespondientes(dgvPedidos, dgvProduccionesCorrespondientes, lblInfoPedido))
                btnEntregar.Enabled = true;
            else
                btnEntregar.Enabled = false;
        }


        private void btnEntregar_Click(object sender, EventArgs e)
        {
            met.EntregarPedido(dgvPedidos);
            ActualizarTabla(dgvPedidos);
            dgvProduccionesCorrespondientes.DataSource = null;
            btnEntregar.Enabled = false;
            lblInfoPedido.Text = "";
        }

        // ◘◘◘◘◘ Métodos privados de el formulario ◘◘◘◘◘

        private void ActualizarTabla(DataGridView tabla)
        { // Método para refrescar valores de tabla
            switch (tabla.Name)
            {
                case "dgvPlaneaciones":
                    met.ActualizarPlaneaciones(tabla);
                    break;
                case "dgvProducciones":
                    met.ActualizarProducciones(tabla);
                    break;
                case "dgvPedidos":
                    met.ActualizarPedidos(tabla);
                    break;
                default: break;
            }
        }

        private void ControlesActivados(int tab, bool estado)
        { // Método versátil para activar o desactivar controles
            switch (tab)
            {
                case 1:
                    dtpFechaInicio.Enabled = estado;
                    txtObservaciones.Enabled = estado;
                    btnGuardar.Enabled = estado;
                    break;
                case 2:
                    btnCancelar.Enabled = estado;
                    btnRetroceder.Enabled = estado;
                    btnAvanzar.Enabled = estado;
                    btnComenzar.Enabled = estado;
                    nudSegundos.Enabled = estado;
                    break;
                default:
                    break;
            }
        }

        private void EvaluarNumeroFilas()
        {
           // if (dgvPlaneaciones.RowCount == 0)
               // dgvPlaneaciones.Enabled = false;
        }

        private void Produccion_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }


        /*
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
   }*/

    }
}
