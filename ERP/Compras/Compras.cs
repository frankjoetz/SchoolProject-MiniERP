using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Compras
{
    public partial class Compras : Form
    {
        LogicaDeNegocios.Compras.metodosCompras comp = new LogicaDeNegocios.Compras.metodosCompras();
        string idAlerta;
        
        public Compras()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            comp.llenarGridViewAlertas(dataGridViewAlertas);
            comp.llenarGridViewLocacion(dataGridViewLocacion);
            comp.llenarDrigViewMaterial(dataGridViewStock);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            comp.llenarGridViewAlertas(dataGridViewAlertas);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool locacion = comp.altaLocacion(rtbDescripcion.Text, fLocacion.Value.ToString("yyyy-MM-dd"));
            if (locacion)
            {
                MessageBox.Show("Locacion agregada con exito");
            }
            else
            {
                MessageBox.Show("Llenar todos los campos");
            }

            comp.llenarGridViewLocacion(dataGridViewLocacion);
            rtbDescripcion.Text = null;
        }

        private void dataGridViewAlertas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idAlerta = dataGridViewAlertas.Rows[dataGridViewAlertas.CurrentRow.Index].Cells["IdAlerta"].Value.ToString();
            lblAlerta.Text = idAlerta;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool modificacion = comp.modificarAlerta(idAlerta);
            if(modificacion)
            {
                MessageBox.Show("Alerta confirmada");
                comp.llenarGridViewAlertas(dataGridViewAlertas);
                lblAlerta.Text = null;
            }
            else
            {
                MessageBox.Show("Error al confirmar");
            }
        }

        

        
    }
}
