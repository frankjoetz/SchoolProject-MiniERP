﻿namespace ERP.Planeacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planeacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAlerta = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GridPlaneacionesAgregadas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtBaja = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtAlta = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxGamaBaja = new System.Windows.Forms.CheckBox();
            this.checkBoxGamaMedia = new System.Windows.Forms.CheckBox();
            this.checkBoxGamaAlta = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DTPFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarPedido = new System.Windows.Forms.TextBox();
            this.comboBoxBuscarPedido = new System.Windows.Forms.ComboBox();
            this.btnNuevaPlaneacion = new System.Windows.Forms.Button();
            this.groupBoxGridPedidos = new System.Windows.Forms.GroupBox();
            this.GridPedidos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteDataSet = new ERP.Planeacion.ReporteDataSet();
            this.PlaneacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PlaneacionTableAdapter = new ERP.Planeacion.ReporteDataSetTableAdapters.PlaneacionTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPlaneacionesAgregadas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxGridPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPedidos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneacionBindingSource)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1331, 717);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAlerta);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnNuevaPlaneacion);
            this.tabPage1.Controls.Add(this.groupBoxGridPedidos);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1323, 683);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nueva";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnAlerta
            // 
            this.btnAlerta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAlerta.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlerta.Image = ((System.Drawing.Image)(resources.GetObject("btnAlerta.Image")));
            this.btnAlerta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlerta.Location = new System.Drawing.Point(704, 470);
            this.btnAlerta.Name = "btnAlerta";
            this.btnAlerta.Size = new System.Drawing.Size(278, 58);
            this.btnAlerta.TabIndex = 22;
            this.btnAlerta.Text = "Alertas Falta Material Compras";
            this.btnAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlerta.UseVisualStyleBackColor = true;
            this.btnAlerta.Click += new System.EventHandler(this.btnAlerta_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.GridPlaneacionesAgregadas);
            this.groupBox4.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(10, 534);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1301, 143);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // GridPlaneacionesAgregadas
            // 
            this.GridPlaneacionesAgregadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridPlaneacionesAgregadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPlaneacionesAgregadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPlaneacionesAgregadas.Location = new System.Drawing.Point(6, 15);
            this.GridPlaneacionesAgregadas.Name = "GridPlaneacionesAgregadas";
            this.GridPlaneacionesAgregadas.Size = new System.Drawing.Size(1289, 122);
            this.GridPlaneacionesAgregadas.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtpFechaInicio);
            this.groupBox2.Controls.Add(this.txtBaja);
            this.groupBox2.Controls.Add(this.txtMedia);
            this.groupBox2.Controls.Add(this.txtAlta);
            this.groupBox2.Controls.Add(this.txtObservaciones);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.checkBoxGamaBaja);
            this.groupBox2.Controls.Add(this.checkBoxGamaMedia);
            this.groupBox2.Controls.Add(this.checkBoxGamaAlta);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtIdPedido);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.DTPFechaEntrega);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1311, 179);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(358, 29);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(277, 26);
            this.dtpFechaInicio.TabIndex = 21;
            // 
            // txtBaja
            // 
            this.txtBaja.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaja.Location = new System.Drawing.Point(632, 100);
            this.txtBaja.Name = "txtBaja";
            this.txtBaja.Size = new System.Drawing.Size(81, 26);
            this.txtBaja.TabIndex = 20;
            // 
            // txtMedia
            // 
            this.txtMedia.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedia.Location = new System.Drawing.Point(373, 100);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(76, 26);
            this.txtMedia.TabIndex = 19;
            // 
            // txtAlta
            // 
            this.txtAlta.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlta.Location = new System.Drawing.Point(118, 100);
            this.txtAlta.Name = "txtAlta";
            this.txtAlta.Size = new System.Drawing.Size(73, 26);
            this.txtAlta.TabIndex = 18;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(124, 143);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(1174, 26);
            this.txtObservaciones.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 21);
            this.label12.TabIndex = 16;
            this.label12.Text = "Observaciones:";
            // 
            // checkBoxGamaBaja
            // 
            this.checkBoxGamaBaja.AutoSize = true;
            this.checkBoxGamaBaja.Location = new System.Drawing.Point(518, 107);
            this.checkBoxGamaBaja.Name = "checkBoxGamaBaja";
            this.checkBoxGamaBaja.Size = new System.Drawing.Size(15, 14);
            this.checkBoxGamaBaja.TabIndex = 15;
            this.checkBoxGamaBaja.UseVisualStyleBackColor = true;
            // 
            // checkBoxGamaMedia
            // 
            this.checkBoxGamaMedia.AutoSize = true;
            this.checkBoxGamaMedia.Location = new System.Drawing.Point(248, 107);
            this.checkBoxGamaMedia.Name = "checkBoxGamaMedia";
            this.checkBoxGamaMedia.Size = new System.Drawing.Size(15, 14);
            this.checkBoxGamaMedia.TabIndex = 14;
            this.checkBoxGamaMedia.UseVisualStyleBackColor = true;
            // 
            // checkBoxGamaAlta
            // 
            this.checkBoxGamaAlta.AutoSize = true;
            this.checkBoxGamaAlta.Location = new System.Drawing.Point(6, 107);
            this.checkBoxGamaAlta.Name = "checkBoxGamaAlta";
            this.checkBoxGamaAlta.Size = new System.Drawing.Size(15, 14);
            this.checkBoxGamaAlta.TabIndex = 13;
            this.checkBoxGamaAlta.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(539, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 21);
            this.label10.TabIndex = 12;
            this.label10.Text = "Gama Baja:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(269, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Gama Media:";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPedido.Location = new System.Drawing.Point(86, 31);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(119, 26);
            this.txtIdPedido.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Gama Alta: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Se crearan las siguientes planeaciones:";
            // 
            // DTPFechaEntrega
            // 
            this.DTPFechaEntrega.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFechaEntrega.Location = new System.Drawing.Point(856, 29);
            this.DTPFechaEntrega.Name = "DTPFechaEntrega";
            this.DTPFechaEntrega.Size = new System.Drawing.Size(292, 26);
            this.DTPFechaEntrega.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(784, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(788, 100);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(156, 26);
            this.txtStatus.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(656, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha Estimada de Entrega";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id Pedido";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBuscarPedido);
            this.groupBox1.Controls.Add(this.comboBoxBuscarPedido);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(570, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 78);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar pedido por:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresa tu Busqueda";
            // 
            // txtBuscarPedido
            // 
            this.txtBuscarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarPedido.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPedido.Location = new System.Drawing.Point(158, 33);
            this.txtBuscarPedido.Multiline = true;
            this.txtBuscarPedido.Name = "txtBuscarPedido";
            this.txtBuscarPedido.Size = new System.Drawing.Size(583, 29);
            this.txtBuscarPedido.TabIndex = 1;
            this.txtBuscarPedido.TextChanged += new System.EventHandler(this.txtBuscarPedido_TextChanged);
            // 
            // comboBoxBuscarPedido
            // 
            this.comboBoxBuscarPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscarPedido.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBuscarPedido.FormattingEnabled = true;
            this.comboBoxBuscarPedido.Items.AddRange(new object[] {
            "IdPedido",
            "Nombre",
            "Empresa"});
            this.comboBoxBuscarPedido.Location = new System.Drawing.Point(11, 33);
            this.comboBoxBuscarPedido.Name = "comboBoxBuscarPedido";
            this.comboBoxBuscarPedido.Size = new System.Drawing.Size(121, 29);
            this.comboBoxBuscarPedido.TabIndex = 0;
            // 
            // btnNuevaPlaneacion
            // 
            this.btnNuevaPlaneacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuevaPlaneacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevaPlaneacion.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaPlaneacion.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaPlaneacion.Image")));
            this.btnNuevaPlaneacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaPlaneacion.Location = new System.Drawing.Point(343, 470);
            this.btnNuevaPlaneacion.Name = "btnNuevaPlaneacion";
            this.btnNuevaPlaneacion.Size = new System.Drawing.Size(260, 58);
            this.btnNuevaPlaneacion.TabIndex = 19;
            this.btnNuevaPlaneacion.Text = "Agregar Nueva Planeacion";
            this.btnNuevaPlaneacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaPlaneacion.UseVisualStyleBackColor = true;
            this.btnNuevaPlaneacion.Click += new System.EventHandler(this.btnNuevaPlaneacion_Click);
            // 
            // groupBoxGridPedidos
            // 
            this.groupBoxGridPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGridPedidos.Controls.Add(this.GridPedidos);
            this.groupBoxGridPedidos.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGridPedidos.Location = new System.Drawing.Point(6, 71);
            this.groupBoxGridPedidos.Name = "groupBoxGridPedidos";
            this.groupBoxGridPedidos.Size = new System.Drawing.Size(1311, 211);
            this.groupBoxGridPedidos.TabIndex = 17;
            this.groupBoxGridPedidos.TabStop = false;
            this.groupBoxGridPedidos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GridPedidos
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPedidos.Location = new System.Drawing.Point(6, 16);
            this.GridPedidos.Name = "GridPedidos";
            this.GridPedidos.ReadOnly = true;
            this.GridPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPedidos.Size = new System.Drawing.Size(1299, 189);
            this.GridPedidos.TabIndex = 0;
            this.GridPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPedidos_CellClick);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "NUEVA PLANEACIÓN";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1323, 683);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reportes";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "REPORTES ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "reporteTabla";
            reportDataSource1.Value = this.PlaneacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERP.Planeacion.ReportPlaneacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(19, 49);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1283, 615);
            this.reportViewer1.TabIndex = 18;
            // 
            // ReporteDataSet
            // 
            this.ReporteDataSet.DataSetName = "ReporteDataSet";
            this.ReporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PlaneacionBindingSource
            // 
            this.PlaneacionBindingSource.DataMember = "Planeacion";
            this.PlaneacionBindingSource.DataSource = this.ReporteDataSet;
            // 
            // PlaneacionTableAdapter
            // 
            this.PlaneacionTableAdapter.ClearBeforeFill = true;
            // 
            // Planeacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 741);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "Planeacion";
            this.Text = "Planeacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Planeacion_Load);
            this.Shown += new System.EventHandler(this.Planeacion_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPlaneacionesAgregadas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxGridPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPedidos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnNuevaPlaneacion;
        private System.Windows.Forms.DataGridView GridPedidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxBuscarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarPedido;
        private System.Windows.Forms.GroupBox groupBoxGridPedidos;
        private System.Windows.Forms.Button btnAlerta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView GridPlaneacionesAgregadas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxGamaBaja;
        private System.Windows.Forms.CheckBox checkBoxGamaMedia;
        private System.Windows.Forms.CheckBox checkBoxGamaAlta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTPFechaEntrega;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBaja;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtAlta;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PlaneacionBindingSource;
        private ReporteDataSet ReporteDataSet;
        private ReporteDataSetTableAdapters.PlaneacionTableAdapter PlaneacionTableAdapter;

    }
}