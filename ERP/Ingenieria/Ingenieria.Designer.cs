﻿namespace ERP.Ingenieria
{
    partial class Ingenieria
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
            this.ingenieriatc = new System.Windows.Forms.TabControl();
            this.ingenieriaform = new System.Windows.Forms.TabPage();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.pikerfecha = new System.Windows.Forms.DateTimePicker();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnmodificar = new System.Windows.Forms.RadioButton();
            this.rbnelimnar = new System.Windows.Forms.RadioButton();
            this.lbltipo = new System.Windows.Forms.Label();
            this.dgwmateriaprima = new System.Windows.Forms.DataGridView();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblidmateria = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtidmateria = new System.Windows.Forms.TextBox();
            this.btnagregarmp = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtgama = new System.Windows.Forms.TextBox();
            this.cmbmemoriaramcp = new System.Windows.Forms.ComboBox();
            this.cmbprocesadorcp = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnagregarcomponentes = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnagregar = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buscarrtxt = new System.Windows.Forms.Button();
            this.fechaptxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.gbMaterial = new System.Windows.Forms.GroupBox();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btningresarpro = new System.Windows.Forms.Button();
            this.cmbdestino = new System.Windows.Forms.ComboBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.cmbdescripcion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ingenieriatc.SuspendLayout();
            this.ingenieriaform.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwmateriaprima)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.gbMaterial.SuspendLayout();
            this.gbProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // ingenieriatc
            // 
            this.ingenieriatc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ingenieriatc.Controls.Add(this.ingenieriaform);
            this.ingenieriatc.Controls.Add(this.tabPage2);
            this.ingenieriatc.Controls.Add(this.tabPage3);
            this.ingenieriatc.Controls.Add(this.tabPage1);
            this.ingenieriatc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingenieriatc.Location = new System.Drawing.Point(42, 39);
            this.ingenieriatc.Margin = new System.Windows.Forms.Padding(4);
            this.ingenieriatc.Name = "ingenieriatc";
            this.ingenieriatc.SelectedIndex = 0;
            this.ingenieriatc.Size = new System.Drawing.Size(1042, 550);
            this.ingenieriatc.TabIndex = 1;
            // 
            // ingenieriaform
            // 
            this.ingenieriaform.AutoScroll = true;
            this.ingenieriaform.Controls.Add(this.cmbtipo);
            this.ingenieriaform.Controls.Add(this.pikerfecha);
            this.ingenieriaform.Controls.Add(this.btnmodificar);
            this.ingenieriaform.Controls.Add(this.btneliminar);
            this.ingenieriaform.Controls.Add(this.groupBox1);
            this.ingenieriaform.Controls.Add(this.lbltipo);
            this.ingenieriaform.Controls.Add(this.dgwmateriaprima);
            this.ingenieriaform.Controls.Add(this.lblfecha);
            this.ingenieriaform.Controls.Add(this.lbldesc);
            this.ingenieriaform.Controls.Add(this.lblidmateria);
            this.ingenieriaform.Controls.Add(this.txtDesc);
            this.ingenieriaform.Controls.Add(this.txtidmateria);
            this.ingenieriaform.Controls.Add(this.btnagregarmp);
            this.ingenieriaform.Location = new System.Drawing.Point(4, 27);
            this.ingenieriaform.Margin = new System.Windows.Forms.Padding(4);
            this.ingenieriaform.Name = "ingenieriaform";
            this.ingenieriaform.Padding = new System.Windows.Forms.Padding(4);
            this.ingenieriaform.Size = new System.Drawing.Size(1034, 519);
            this.ingenieriaform.TabIndex = 0;
            this.ingenieriaform.Text = "Captura de Materia Prima";
            this.ingenieriaform.UseVisualStyleBackColor = true;
            this.ingenieriaform.Click += new System.EventHandler(this.ingenieriaform_Click);
            // 
            // cmbtipo
            // 
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Items.AddRange(new object[] {
            "Procesador",
            "Memoria RAM",
            "Disco Duro",
            "Fuente de poder",
            "Tarjeta madre",
            "Case",
            "Tarjeta gráfica",
            "Disipador",
            "Abanico"});
            this.cmbtipo.Location = new System.Drawing.Point(224, 128);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(148, 26);
            this.cmbtipo.TabIndex = 28;
            // 
            // pikerfecha
            // 
            this.pikerfecha.Location = new System.Drawing.Point(224, 215);
            this.pikerfecha.Name = "pikerfecha";
            this.pikerfecha.Size = new System.Drawing.Size(148, 24);
            this.pikerfecha.TabIndex = 27;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(136, 292);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(112, 32);
            this.btnmodificar.TabIndex = 26;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Visible = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click_1);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(136, 292);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(112, 32);
            this.btneliminar.TabIndex = 25;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnmodificar);
            this.groupBox1.Controls.Add(this.rbnelimnar);
            this.groupBox1.Location = new System.Drawing.Point(52, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 60);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mas opciones";
            // 
            // rbnmodificar
            // 
            this.rbnmodificar.AutoSize = true;
            this.rbnmodificar.Location = new System.Drawing.Point(184, 23);
            this.rbnmodificar.Name = "rbnmodificar";
            this.rbnmodificar.Size = new System.Drawing.Size(87, 22);
            this.rbnmodificar.TabIndex = 1;
            this.rbnmodificar.TabStop = true;
            this.rbnmodificar.Text = "Modificar";
            this.rbnmodificar.UseVisualStyleBackColor = true;
            this.rbnmodificar.CheckedChanged += new System.EventHandler(this.rbnmodificar_CheckedChanged_1);
            // 
            // rbnelimnar
            // 
            this.rbnelimnar.AutoSize = true;
            this.rbnelimnar.Location = new System.Drawing.Point(18, 23);
            this.rbnelimnar.Name = "rbnelimnar";
            this.rbnelimnar.Size = new System.Drawing.Size(79, 22);
            this.rbnelimnar.TabIndex = 0;
            this.rbnelimnar.TabStop = true;
            this.rbnelimnar.Text = "Eliminar";
            this.rbnelimnar.UseVisualStyleBackColor = true;
            this.rbnelimnar.CheckedChanged += new System.EventHandler(this.rbnelimnar_CheckedChanged_1);
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(49, 131);
            this.lbltipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(37, 18);
            this.lbltipo.TabIndex = 24;
            this.lbltipo.Text = "Tipo";
            // 
            // dgwmateriaprima
            // 
            this.dgwmateriaprima.AllowUserToAddRows = false;
            this.dgwmateriaprima.AllowUserToDeleteRows = false;
            this.dgwmateriaprima.AllowUserToOrderColumns = true;
            this.dgwmateriaprima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwmateriaprima.Location = new System.Drawing.Point(442, 61);
            this.dgwmateriaprima.Margin = new System.Windows.Forms.Padding(4);
            this.dgwmateriaprima.Name = "dgwmateriaprima";
            this.dgwmateriaprima.ReadOnly = true;
            this.dgwmateriaprima.Size = new System.Drawing.Size(544, 336);
            this.dgwmateriaprima.TabIndex = 23;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(48, 215);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(101, 18);
            this.lblfecha.TabIndex = 22;
            this.lblfecha.Text = "Ingrese Fecha";
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(48, 176);
            this.lbldesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(139, 18);
            this.lbldesc.TabIndex = 21;
            this.lbldesc.Text = "Ingrese Descripción";
            // 
            // lblidmateria
            // 
            this.lblidmateria.AutoSize = true;
            this.lblidmateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidmateria.Location = new System.Drawing.Point(48, 393);
            this.lblidmateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidmateria.Name = "lblidmateria";
            this.lblidmateria.Size = new System.Drawing.Size(75, 18);
            this.lblidmateria.TabIndex = 20;
            this.lblidmateria.Text = "ID Materia";
            this.lblidmateria.Visible = false;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(224, 170);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(148, 24);
            this.txtDesc.TabIndex = 19;
            // 
            // txtidmateria
            // 
            this.txtidmateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidmateria.Location = new System.Drawing.Point(224, 390);
            this.txtidmateria.Margin = new System.Windows.Forms.Padding(4);
            this.txtidmateria.Name = "txtidmateria";
            this.txtidmateria.Size = new System.Drawing.Size(148, 24);
            this.txtidmateria.TabIndex = 17;
            this.txtidmateria.Visible = false;
            // 
            // btnagregarmp
            // 
            this.btnagregarmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarmp.Location = new System.Drawing.Point(136, 292);
            this.btnagregarmp.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregarmp.Name = "btnagregarmp";
            this.btnagregarmp.Size = new System.Drawing.Size(112, 32);
            this.btnagregarmp.TabIndex = 16;
            this.btnagregarmp.Text = "Agregar";
            this.btnagregarmp.UseVisualStyleBackColor = true;
            this.btnagregarmp.Click += new System.EventHandler(this.btnagregarmp_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbProducto);
            this.tabPage2.Controls.Add(this.gbMaterial);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1034, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Captura de Producto Final";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(562, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 224);
            this.dataGridView1.TabIndex = 86;
            // 
            // txtgama
            // 
            this.txtgama.Location = new System.Drawing.Point(172, 43);
            this.txtgama.Name = "txtgama";
            this.txtgama.Size = new System.Drawing.Size(332, 24);
            this.txtgama.TabIndex = 83;
            this.txtgama.TextChanged += new System.EventHandler(this.txtgama_TextChanged);
            // 
            // cmbmemoriaramcp
            // 
            this.cmbmemoriaramcp.FormattingEnabled = true;
            this.cmbmemoriaramcp.Location = new System.Drawing.Point(311, 76);
            this.cmbmemoriaramcp.Name = "cmbmemoriaramcp";
            this.cmbmemoriaramcp.Size = new System.Drawing.Size(193, 26);
            this.cmbmemoriaramcp.TabIndex = 74;
            this.cmbmemoriaramcp.SelectedIndexChanged += new System.EventHandler(this.cmbmemoriaramcp_SelectedIndexChanged);
            // 
            // cmbprocesadorcp
            // 
            this.cmbprocesadorcp.FormattingEnabled = true;
            this.cmbprocesadorcp.Location = new System.Drawing.Point(60, 81);
            this.cmbprocesadorcp.Name = "cmbprocesadorcp";
            this.cmbprocesadorcp.Size = new System.Drawing.Size(140, 26);
            this.cmbprocesadorcp.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(245, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 18);
            this.label11.TabIndex = 65;
            this.label11.Text = "Material";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 64;
            this.label5.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 63;
            this.label4.Text = "Modelo / Descripcion";
            // 
            // btnagregarcomponentes
            // 
            this.btnagregarcomponentes.Location = new System.Drawing.Point(323, 147);
            this.btnagregarcomponentes.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregarcomponentes.Name = "btnagregarcomponentes";
            this.btnagregarcomponentes.Size = new System.Drawing.Size(176, 32);
            this.btnagregarcomponentes.TabIndex = 58;
            this.btnagregarcomponentes.Text = "Ingresar Material";
            this.btnagregarcomponentes.UseVisualStyleBackColor = true;
            this.btnagregarcomponentes.Click += new System.EventHandler(this.btnagregarcomponentes_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnagregar);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1034, 519);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Captura Lineas de Produccion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(514, 178);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(131, 54);
            this.btnagregar.TabIndex = 20;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buscarrtxt);
            this.tabPage1.Controls.Add(this.fechaptxt);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1034, 519);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Reportes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buscarrtxt
            // 
            this.buscarrtxt.Location = new System.Drawing.Point(579, 78);
            this.buscarrtxt.Margin = new System.Windows.Forms.Padding(4);
            this.buscarrtxt.Name = "buscarrtxt";
            this.buscarrtxt.Size = new System.Drawing.Size(112, 32);
            this.buscarrtxt.TabIndex = 3;
            this.buscarrtxt.Text = "Buscar";
            this.buscarrtxt.UseVisualStyleBackColor = true;
            // 
            // fechaptxt
            // 
            this.fechaptxt.Location = new System.Drawing.Point(378, 78);
            this.fechaptxt.Margin = new System.Windows.Forms.Padding(4);
            this.fechaptxt.Name = "fechaptxt";
            this.fechaptxt.Size = new System.Drawing.Size(148, 24);
            this.fechaptxt.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(298, 81);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Fecha";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(111, 112);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(716, 314);
            this.dataGridView3.TabIndex = 0;
            // 
            // gbMaterial
            // 
            this.gbMaterial.Controls.Add(this.label4);
            this.gbMaterial.Controls.Add(this.btnagregarcomponentes);
            this.gbMaterial.Controls.Add(this.label5);
            this.gbMaterial.Controls.Add(this.label11);
            this.gbMaterial.Controls.Add(this.txtgama);
            this.gbMaterial.Controls.Add(this.cmbprocesadorcp);
            this.gbMaterial.Controls.Add(this.cmbmemoriaramcp);
            this.gbMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMaterial.Location = new System.Drawing.Point(11, 142);
            this.gbMaterial.Name = "gbMaterial";
            this.gbMaterial.Size = new System.Drawing.Size(523, 224);
            this.gbMaterial.TabIndex = 87;
            this.gbMaterial.TabStop = false;
            this.gbMaterial.Text = "Material";
            this.gbMaterial.Enter += new System.EventHandler(this.gbMaterial_Enter);
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.label7);
            this.gbProducto.Controls.Add(this.label10);
            this.gbProducto.Controls.Add(this.cmbdescripcion);
            this.gbProducto.Controls.Add(this.dtpfecha);
            this.gbProducto.Controls.Add(this.cmbdestino);
            this.gbProducto.Controls.Add(this.btningresarpro);
            this.gbProducto.Controls.Add(this.label1);
            this.gbProducto.Location = new System.Drawing.Point(11, 27);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(997, 77);
            this.gbProducto.TabIndex = 88;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Datos Productos";
            this.gbProducto.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 62;
            this.label1.Text = "Destino";
            // 
            // btningresarpro
            // 
            this.btningresarpro.Location = new System.Drawing.Point(810, 31);
            this.btningresarpro.Name = "btningresarpro";
            this.btningresarpro.Size = new System.Drawing.Size(162, 26);
            this.btningresarpro.TabIndex = 84;
            this.btningresarpro.Text = "Ingresar Producto";
            this.btningresarpro.UseVisualStyleBackColor = true;
            this.btningresarpro.Click += new System.EventHandler(this.btningresarpro_Click);
            // 
            // cmbdestino
            // 
            this.cmbdestino.FormattingEnabled = true;
            this.cmbdestino.Items.AddRange(new object[] {
            "Mexico",
            "Estados Unidos",
            "Canada",
            "Siria"});
            this.cmbdestino.Location = new System.Drawing.Point(627, 32);
            this.cmbdestino.Name = "cmbdestino";
            this.cmbdestino.Size = new System.Drawing.Size(164, 26);
            this.cmbdestino.TabIndex = 61;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(337, 31);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 24);
            this.dtpfecha.TabIndex = 85;
            // 
            // cmbdescripcion
            // 
            this.cmbdescripcion.FormattingEnabled = true;
            this.cmbdescripcion.Items.AddRange(new object[] {
            "Equipo Gama Baja",
            "Equipo Gama Media",
            "Equipo Gama Alta"});
            this.cmbdescripcion.Location = new System.Drawing.Point(98, 30);
            this.cmbdescripcion.Name = "cmbdescripcion";
            this.cmbdescripcion.Size = new System.Drawing.Size(176, 26);
            this.cmbdescripcion.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 59;
            this.label10.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 57;
            this.label7.Text = "Descripción";
            // 
            // Ingenieria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 602);
            this.ControlBox = false;
            this.Controls.Add(this.ingenieriatc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ingenieria";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingenieria";
            this.Load += new System.EventHandler(this.Ingenieria_Load);
            this.ingenieriatc.ResumeLayout(false);
            this.ingenieriaform.ResumeLayout(false);
            this.ingenieriaform.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwmateriaprima)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.gbMaterial.ResumeLayout(false);
            this.gbMaterial.PerformLayout();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ingenieriatc;
        private System.Windows.Forms.TabPage ingenieriaform;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buscarrtxt;
        private System.Windows.Forms.TextBox fechaptxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFolioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn locacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ComboBox cmbtipo;
        private System.Windows.Forms.DateTimePicker pikerfecha;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnmodificar;
        private System.Windows.Forms.RadioButton rbnelimnar;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.DataGridView dgwmateriaprima;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lblidmateria;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtidmateria;
        private System.Windows.Forms.Button btnagregarmp;
        private System.Windows.Forms.TextBox txtgama;
        private System.Windows.Forms.ComboBox cmbmemoriaramcp;
        private System.Windows.Forms.ComboBox cmbprocesadorcp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnagregarcomponentes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbMaterial;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbdescripcion;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.ComboBox cmbdestino;
        private System.Windows.Forms.Button btningresarpro;
        private System.Windows.Forms.Label label1;
    }
}