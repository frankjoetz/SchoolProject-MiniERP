namespace ERP.Ventas
{
    partial class PedidosFinal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPedidoFinal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDpedFin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidoFinal
            // 
            this.dgvPedidoFinal.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPedidoFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoFinal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPedidoFinal.Location = new System.Drawing.Point(12, 54);
            this.dgvPedidoFinal.MultiSelect = false;
            this.dgvPedidoFinal.Name = "dgvPedidoFinal";
            this.dgvPedidoFinal.Size = new System.Drawing.Size(975, 176);
            this.dgvPedidoFinal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID del pedido finalizado";
            // 
            // txtIDpedFin
            // 
            this.txtIDpedFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDpedFin.Location = new System.Drawing.Point(177, 15);
            this.txtIDpedFin.Name = "txtIDpedFin";
            this.txtIDpedFin.Size = new System.Drawing.Size(128, 24);
            this.txtIDpedFin.TabIndex = 0;
            this.txtIDpedFin.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // PedidosFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(999, 242);
            this.ControlBox = false;
            this.Controls.Add(this.txtIDpedFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPedidoFinal);
            this.Name = "PedidosFinal";
            this.Text = "Buscar un cliente";
            this.Load += new System.EventHandler(this.PedidosFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidoFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDpedFin;
    }
}