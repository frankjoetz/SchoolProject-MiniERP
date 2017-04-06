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
            comp.llenarGridViewAlertas(dataGridViewAlertas);
            comp.llenarGridViewLocacion(dataGridViewLocacion);
            comp.llenarDrigViewMaterial(dataGridViewStock);

        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtbDescripcion.Text))
            {
                bool locacion = comp.altaLocacion(rtbDescripcion.Text, fLocacion.Value.ToString("yyyy-MM-dd"));
                if (locacion)
                {
                    MessageBox.Show("Locacion agregada con exito");
                }
            }
            else
                MessageBox.Show("Llenar todos los campos");

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
            if (MessageBox.Show("¿Estas seguro de la confirmacion?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool modificacion = comp.modificarAlerta(idAlerta);
                if (modificacion)
                {
                    MessageBox.Show("Alerta confirmada");
                    comp.llenarGridViewAlertas(dataGridViewAlertas);
                    lblAlerta.Text = null;
                }
            }
            else
            {
                MessageBox.Show("Error al confirmar");
            }
        }
        
        public void pintarColumnas(DataGridView stock)
        {
            int stockActual = 0;
            int stockMinimo = 0;
            int tamanioTabla = stock.Rows.Count - 1;

            for (int i = 0; i < tamanioTabla; i++)
            {
                stockActual = int.Parse(stock.Rows[i].Cells[3].Value.ToString());
                stockMinimo = int.Parse(stock.Rows[i].Cells[4].Value.ToString());
                if (stockActual < stockMinimo)
                {
                    stock.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void dataGridViewStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string stock = dataGridViewStock.Rows[dataGridViewStock.CurrentRow.Index].Cells["Tipo"].Value.ToString();
            lblIdMateria.Text = stock;
            string des = dataGridViewStock.Rows[dataGridViewStock.CurrentRow.Index].Cells["Descripcion"].Value.ToString();
            lblDescripcion.Text = des;
        }

        private void tabControlCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            pintarColumnas(dataGridViewStock);
            comp.llenarGridViewAlertas(dataGridViewAlertas);
        }

        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            string stockActual = dataGridViewStock.Rows[dataGridViewStock.CurrentRow.Index].Cells["StockActual"].Value.ToString();
            string valorAgregar = nudCantidad.Value.ToString();
            string StockUpdate = (int.Parse(stockActual) + int.Parse(valorAgregar)).ToString();
            string id = dataGridViewStock.Rows[dataGridViewStock.CurrentRow.Index].Cells["idMateria"].Value.ToString();

            if (MessageBox.Show("¿Estas seguro de agregar esa cantidad?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(stockActual))
                {
                    bool agregado = comp.agregarStock(id, StockUpdate);
                    if (agregado)
                        MessageBox.Show("Materia agregado exitosamente");
                    comp.llenarDrigViewMaterial(dataGridViewStock);
                    pintarColumnas(dataGridViewStock);
                    lblIdMateria.Text = null;
                    lblDescripcion.Text = null;
                    nudCantidad.Value = 1;
                }
                else
                {
                    MessageBox.Show("Seleccionar una materia prima");
                }
            }
            else
            {
                MessageBox.Show("Error al agregar la materia prima");
            }

        }

        private void Compras_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
