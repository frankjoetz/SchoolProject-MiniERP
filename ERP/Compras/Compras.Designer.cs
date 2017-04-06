namespace ERP.Compras
{
    partial class Compras
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
            this.tabControlCompras = new System.Windows.Forms.TabControl();
            this.tabPageLocalizacion = new System.Windows.Forms.TabPage();
            this.grpAlertas = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dataGridViewAlertas = new System.Windows.Forms.DataGridView();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.lblIdAlerta = new System.Windows.Forms.Label();
            this.tabPageInventario = new System.Windows.Forms.TabPage();
            this.grpAgregarMaterial = new System.Windows.Forms.GroupBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarMaterial = new System.Windows.Forms.Button();
            this.lblMemoriaRam = new System.Windows.Forms.Label();
            this.lblIdMateria = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.grpMaterialStock = new System.Windows.Forms.GroupBox();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.tabPageConsumos = new System.Windows.Forms.TabPage();
            this.grpAgregarLocacion = new System.Windows.Forms.GroupBox();
            this.lblFechaLocacion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.fLocacion = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewLocacion = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.revStock = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControlCompras.SuspendLayout();
            this.tabPageLocalizacion.SuspendLayout();
            this.grpAlertas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlertas)).BeginInit();
            this.tabPageInventario.SuspendLayout();
            this.grpAgregarMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.grpMaterialStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.tabPageConsumos.SuspendLayout();
            this.grpAgregarLocacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocacion)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCompras
            // 
            this.tabControlCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlCompras.Controls.Add(this.tabPageLocalizacion);
            this.tabControlCompras.Controls.Add(this.tabPageInventario);
            this.tabControlCompras.Controls.Add(this.tabPageConsumos);
            this.tabControlCompras.Controls.Add(this.tabPage1);
            this.tabControlCompras.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlCompras.Location = new System.Drawing.Point(12, 12);
            this.tabControlCompras.Name = "tabControlCompras";
            this.tabControlCompras.SelectedIndex = 0;
            this.tabControlCompras.Size = new System.Drawing.Size(690, 540);
            this.tabControlCompras.TabIndex = 3;
            this.tabControlCompras.Tag = "";
            this.tabControlCompras.SelectedIndexChanged += new System.EventHandler(this.tabControlCompras_SelectedIndexChanged);
            // 
            // tabPageLocalizacion
            // 
            this.tabPageLocalizacion.Controls.Add(this.grpAlertas);
            this.tabPageLocalizacion.Location = new System.Drawing.Point(4, 30);
            this.tabPageLocalizacion.Name = "tabPageLocalizacion";
            this.tabPageLocalizacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocalizacion.Size = new System.Drawing.Size(682, 506);
            this.tabPageLocalizacion.TabIndex = 0;
            this.tabPageLocalizacion.Text = "Alertas";
            this.tabPageLocalizacion.UseVisualStyleBackColor = true;
            // 
            // grpAlertas
            // 
            this.grpAlertas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAlertas.Controls.Add(this.btnConfirmar);
            this.grpAlertas.Controls.Add(this.dataGridViewAlertas);
            this.grpAlertas.Controls.Add(this.lblAlerta);
            this.grpAlertas.Controls.Add(this.lblIdAlerta);
            this.grpAlertas.Location = new System.Drawing.Point(17, 18);
            this.grpAlertas.Name = "grpAlertas";
            this.grpAlertas.Size = new System.Drawing.Size(647, 337);
            this.grpAlertas.TabIndex = 0;
            this.grpAlertas.TabStop = false;
            this.grpAlertas.Text = "Alertas por verificar";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmar.AutoSize = true;
            this.btnConfirmar.Image = global::ERP.Properties.Resources.iconplane;
            this.btnConfirmar.Location = new System.Drawing.Point(344, 274);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(124, 43);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar ";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dataGridViewAlertas
            // 
            this.dataGridViewAlertas.AllowUserToAddRows = false;
            this.dataGridViewAlertas.AllowUserToDeleteRows = false;
            this.dataGridViewAlertas.AllowUserToResizeRows = false;
            this.dataGridViewAlertas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAlertas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlertas.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewAlertas.Name = "dataGridViewAlertas";
            this.dataGridViewAlertas.ReadOnly = true;
            this.dataGridViewAlertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlertas.Size = new System.Drawing.Size(635, 247);
            this.dataGridViewAlertas.TabIndex = 1;
            this.dataGridViewAlertas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlertas_CellClick);
            // 
            // lblAlerta
            // 
            this.lblAlerta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAlerta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlerta.Location = new System.Drawing.Point(258, 289);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(54, 18);
            this.lblAlerta.TabIndex = 2;
            // 
            // lblIdAlerta
            // 
            this.lblIdAlerta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIdAlerta.AutoSize = true;
            this.lblIdAlerta.Location = new System.Drawing.Point(187, 288);
            this.lblIdAlerta.Name = "lblIdAlerta";
            this.lblIdAlerta.Size = new System.Drawing.Size(67, 21);
            this.lblIdAlerta.TabIndex = 1;
            this.lblIdAlerta.Text = "Id alerta";
            // 
            // tabPageInventario
            // 
            this.tabPageInventario.Controls.Add(this.grpAgregarMaterial);
            this.tabPageInventario.Controls.Add(this.grpMaterialStock);
            this.tabPageInventario.Location = new System.Drawing.Point(4, 30);
            this.tabPageInventario.Name = "tabPageInventario";
            this.tabPageInventario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInventario.Size = new System.Drawing.Size(682, 506);
            this.tabPageInventario.TabIndex = 3;
            this.tabPageInventario.Text = "Stock";
            this.tabPageInventario.UseVisualStyleBackColor = true;
            // 
            // grpAgregarMaterial
            // 
            this.grpAgregarMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAgregarMaterial.Controls.Add(this.nudCantidad);
            this.grpAgregarMaterial.Controls.Add(this.btnAgregarMaterial);
            this.grpAgregarMaterial.Controls.Add(this.lblMemoriaRam);
            this.grpAgregarMaterial.Controls.Add(this.lblIdMateria);
            this.grpAgregarMaterial.Controls.Add(this.lblCantidad);
            this.grpAgregarMaterial.Controls.Add(this.lblDescripcion);
            this.grpAgregarMaterial.Controls.Add(this.lblMateria);
            this.grpAgregarMaterial.Location = new System.Drawing.Point(20, 309);
            this.grpAgregarMaterial.Name = "grpAgregarMaterial";
            this.grpAgregarMaterial.Size = new System.Drawing.Size(647, 165);
            this.grpAgregarMaterial.TabIndex = 6;
            this.grpAgregarMaterial.TabStop = false;
            this.grpAgregarMaterial.Text = "Agregar material";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(500, 70);
            this.nudCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 26);
            this.nudCantidad.TabIndex = 10;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregarMaterial
            // 
            this.btnAgregarMaterial.AutoSize = true;
            this.btnAgregarMaterial.Image = global::ERP.Properties.Resources.iconAdd;
            this.btnAgregarMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarMaterial.Location = new System.Drawing.Point(343, 108);
            this.btnAgregarMaterial.Name = "btnAgregarMaterial";
            this.btnAgregarMaterial.Size = new System.Drawing.Size(167, 42);
            this.btnAgregarMaterial.TabIndex = 9;
            this.btnAgregarMaterial.Text = "Agregar material";
            this.btnAgregarMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarMaterial.UseVisualStyleBackColor = true;
            this.btnAgregarMaterial.Click += new System.EventHandler(this.btnAgregarMaterial_Click);
            // 
            // lblMemoriaRam
            // 
            this.lblMemoriaRam.AutoSize = true;
            this.lblMemoriaRam.Location = new System.Drawing.Point(371, 30);
            this.lblMemoriaRam.Name = "lblMemoriaRam";
            this.lblMemoriaRam.Size = new System.Drawing.Size(88, 21);
            this.lblMemoriaRam.TabIndex = 7;
            this.lblMemoriaRam.Text = "Descripción";
            // 
            // lblIdMateria
            // 
            this.lblIdMateria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdMateria.Location = new System.Drawing.Point(192, 64);
            this.lblIdMateria.Name = "lblIdMateria";
            this.lblIdMateria.Size = new System.Drawing.Size(119, 32);
            this.lblIdMateria.TabIndex = 6;
            this.lblIdMateria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(515, 30);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 21);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescripcion.Location = new System.Drawing.Point(343, 64);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(132, 32);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(225, 30);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(63, 21);
            this.lblMateria.TabIndex = 0;
            this.lblMateria.Text = "Materia";
            // 
            // grpMaterialStock
            // 
            this.grpMaterialStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMaterialStock.Controls.Add(this.dataGridViewStock);
            this.grpMaterialStock.Location = new System.Drawing.Point(20, 18);
            this.grpMaterialStock.Name = "grpMaterialStock";
            this.grpMaterialStock.Size = new System.Drawing.Size(647, 272);
            this.grpMaterialStock.TabIndex = 2;
            this.grpMaterialStock.TabStop = false;
            this.grpMaterialStock.Text = "Material en stock";
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.AllowUserToResizeRows = false;
            this.dataGridViewStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.ReadOnly = true;
            this.dataGridViewStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStock.Size = new System.Drawing.Size(632, 245);
            this.dataGridViewStock.TabIndex = 5;
            this.dataGridViewStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStock_CellClick);
            // 
            // tabPageConsumos
            // 
            this.tabPageConsumos.Controls.Add(this.grpAgregarLocacion);
            this.tabPageConsumos.Controls.Add(this.groupBox1);
            this.tabPageConsumos.Location = new System.Drawing.Point(4, 30);
            this.tabPageConsumos.Name = "tabPageConsumos";
            this.tabPageConsumos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsumos.Size = new System.Drawing.Size(682, 506);
            this.tabPageConsumos.TabIndex = 4;
            this.tabPageConsumos.Text = "Locación";
            this.tabPageConsumos.UseVisualStyleBackColor = true;
            // 
            // grpAgregarLocacion
            // 
            this.grpAgregarLocacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAgregarLocacion.Controls.Add(this.lblFechaLocacion);
            this.grpAgregarLocacion.Controls.Add(this.lblFecha);
            this.grpAgregarLocacion.Controls.Add(this.fLocacion);
            this.grpAgregarLocacion.Controls.Add(this.btnAgregar);
            this.grpAgregarLocacion.Controls.Add(this.rtbDescripcion);
            this.grpAgregarLocacion.Location = new System.Drawing.Point(17, 252);
            this.grpAgregarLocacion.Name = "grpAgregarLocacion";
            this.grpAgregarLocacion.Size = new System.Drawing.Size(648, 238);
            this.grpAgregarLocacion.TabIndex = 16;
            this.grpAgregarLocacion.TabStop = false;
            this.grpAgregarLocacion.Text = "Agregar locación";
            // 
            // lblFechaLocacion
            // 
            this.lblFechaLocacion.AutoSize = true;
            this.lblFechaLocacion.Location = new System.Drawing.Point(185, 36);
            this.lblFechaLocacion.Name = "lblFechaLocacion";
            this.lblFechaLocacion.Size = new System.Drawing.Size(112, 21);
            this.lblFechaLocacion.TabIndex = 12;
            this.lblFechaLocacion.Text = "Fecha creación";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(185, 94);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(88, 21);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Descripción";
            // 
            // fLocacion
            // 
            this.fLocacion.Enabled = false;
            this.fLocacion.Location = new System.Drawing.Point(303, 36);
            this.fLocacion.Name = "fLocacion";
            this.fLocacion.Size = new System.Drawing.Size(249, 26);
            this.fLocacion.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.Image = global::ERP.Properties.Resources.iconAdd;
            this.btnAgregar.Location = new System.Drawing.Point(306, 183);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 45);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(303, 91);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(301, 69);
            this.rtbDescripcion.TabIndex = 14;
            this.rtbDescripcion.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewLocacion);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 220);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Locaciones";
            // 
            // dataGridViewLocacion
            // 
            this.dataGridViewLocacion.AllowUserToResizeRows = false;
            this.dataGridViewLocacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLocacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLocacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocacion.Location = new System.Drawing.Point(8, 21);
            this.dataGridViewLocacion.Name = "dataGridViewLocacion";
            this.dataGridViewLocacion.ReadOnly = true;
            this.dataGridViewLocacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLocacion.Size = new System.Drawing.Size(636, 193);
            this.dataGridViewLocacion.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.revStock);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 506);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Reporte stock";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // revStock
            // 
            this.revStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.revStock.Location = new System.Drawing.Point(15, 15);
            this.revStock.Name = "revStock";
            this.revStock.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.revStock.Size = new System.Drawing.Size(661, 281);
            this.revStock.TabIndex = 0;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 569);
            this.ControlBox = false;
            this.Controls.Add(this.tabControlCompras);
            this.Name = "Compras";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Compras_Load);
            this.tabControlCompras.ResumeLayout(false);
            this.tabPageLocalizacion.ResumeLayout(false);
            this.grpAlertas.ResumeLayout(false);
            this.grpAlertas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlertas)).EndInit();
            this.tabPageInventario.ResumeLayout(false);
            this.grpAgregarMaterial.ResumeLayout(false);
            this.grpAgregarMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.grpMaterialStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.tabPageConsumos.ResumeLayout(false);
            this.grpAgregarLocacion.ResumeLayout(false);
            this.grpAgregarLocacion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocacion)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCompras;
        private System.Windows.Forms.TabPage tabPageLocalizacion;
        private System.Windows.Forms.TabPage tabPageInventario;
        private System.Windows.Forms.TabPage tabPageConsumos;
        private System.Windows.Forms.DateTimePicker fLocacion;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblFechaLocacion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewLocacion;
        private System.Windows.Forms.GroupBox grpAlertas;
        private System.Windows.Forms.DataGridView dataGridViewAlertas;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblAlerta;
        private System.Windows.Forms.Label lblIdAlerta;
        private System.Windows.Forms.GroupBox grpMaterialStock;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.GroupBox grpAgregarMaterial;
        private System.Windows.Forms.Label lblMemoriaRam;
        private System.Windows.Forms.Label lblIdMateria;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Button btnAgregarMaterial;
        private System.Windows.Forms.GroupBox grpAgregarLocacion;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer revStock;
    }
}