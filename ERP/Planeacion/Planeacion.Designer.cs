namespace ERP.Planeacion
{
    partial class Planeacion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNuevaPlaneacion = new System.Windows.Forms.Button();
            this.groupBoxGridPedidos = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GridPedidos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxBuscarPedido = new System.Windows.Forms.ComboBox();
            this.txtBuscarPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxGridPedidos.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 630);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnNuevaPlaneacion);
            this.tabPage1.Controls.Add(this.groupBoxGridPedidos);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(941, 596);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nueva";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnNuevaPlaneacion
            // 
            this.btnNuevaPlaneacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaPlaneacion.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaPlaneacion.Location = new System.Drawing.Point(196, 523);
            this.btnNuevaPlaneacion.Name = "btnNuevaPlaneacion";
            this.btnNuevaPlaneacion.Size = new System.Drawing.Size(598, 58);
            this.btnNuevaPlaneacion.TabIndex = 19;
            this.btnNuevaPlaneacion.Text = "Agregar Nueva Planeacion";
            this.btnNuevaPlaneacion.UseVisualStyleBackColor = true;
            this.btnNuevaPlaneacion.Click += new System.EventHandler(this.btnNuevaPlaneacion_Click);
            // 
            // groupBoxGridPedidos
            // 
            this.groupBoxGridPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGridPedidos.Controls.Add(this.GridPedidos);
            this.groupBoxGridPedidos.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGridPedidos.Location = new System.Drawing.Point(6, 71);
            this.groupBoxGridPedidos.Name = "groupBoxGridPedidos";
            this.groupBoxGridPedidos.Size = new System.Drawing.Size(929, 211);
            this.groupBoxGridPedidos.TabIndex = 17;
            this.groupBoxGridPedidos.TabStop = false;
            this.groupBoxGridPedidos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "NUEVA PLANEACIÓN";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(712, 233);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(246, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "BUSCAR PLANEACIÓN";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // GridPedidos
            // 
            this.GridPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPedidos.Location = new System.Drawing.Point(29, 16);
            this.GridPedidos.Name = "GridPedidos";
            this.GridPedidos.Size = new System.Drawing.Size(869, 189);
            this.GridPedidos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBuscarPedido);
            this.groupBox1.Controls.Add(this.comboBoxBuscarPedido);
            this.groupBox1.Location = new System.Drawing.Point(570, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 78);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar pedido por:";
            // 
            // comboBoxBuscarPedido
            // 
            this.comboBoxBuscarPedido.FormattingEnabled = true;
            this.comboBoxBuscarPedido.Items.AddRange(new object[] {
            "IdPedido",
            "Nombre",
            "Empresa"});
            this.comboBoxBuscarPedido.Location = new System.Drawing.Point(16, 33);
            this.comboBoxBuscarPedido.Name = "comboBoxBuscarPedido";
            this.comboBoxBuscarPedido.Size = new System.Drawing.Size(121, 29);
            this.comboBoxBuscarPedido.TabIndex = 0;
            // 
            // txtBuscarPedido
            // 
            this.txtBuscarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarPedido.Location = new System.Drawing.Point(158, 33);
            this.txtBuscarPedido.Multiline = true;
            this.txtBuscarPedido.Name = "txtBuscarPedido";
            this.txtBuscarPedido.Size = new System.Drawing.Size(201, 29);
            this.txtBuscarPedido.TabIndex = 1;
            this.txtBuscarPedido.TextChanged += new System.EventHandler(this.txtBuscarPedido_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresa tu Busqueda";
            // 
            // Planeacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 654);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "Planeacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planeacion";
            this.Load += new System.EventHandler(this.Planeacion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxGridPedidos.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBoxGridPedidos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNuevaPlaneacion;
        private System.Windows.Forms.DataGridView GridPedidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxBuscarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarPedido;

    }
}