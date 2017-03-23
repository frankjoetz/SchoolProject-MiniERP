namespace ERP.Ingenieria
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
            this.components = new System.ComponentModel.Container();
            this.ingenieriatc = new System.Windows.Forms.TabControl();
            this.ingenieriaform = new System.Windows.Forms.TabPage();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaPrimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpdbDataSet1 = new ERP.erpdbDataSet1();
            this.label9 = new System.Windows.Forms.Label();
            this.unidadtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.idmateriatxt = new System.Windows.Forms.TextBox();
            this.btnagregarmp = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cantidadtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnagregarcomponentes = new System.Windows.Forms.Button();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btncapturarlin = new System.Windows.Forms.Button();
            this.descripcionltxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buscarrtxt = new System.Windows.Forms.Button();
            this.fechaptxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.materiaPrimaTableAdapter = new ERP.erpdbDataSet1TableAdapters.MateriaPrimaTableAdapter();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtlocalidad = new System.Windows.Forms.TextBox();
            this.txtfhora = new System.Windows.Forms.TextBox();
            this.inventarioproducto = new ERP.inventarioproducto();
            this.inventarioproductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nFolioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioProductoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.erpdbDataSet3 = new ERP.erpdbDataSet3();
            this.inventarioProductoTableAdapter = new ERP.erpdbDataSet3TableAdapters.InventarioProductoTableAdapter();
            this.ingenieriatc.SuspendLayout();
            this.ingenieriaform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaPrimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpdbDataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioproductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioProductoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpdbDataSet3)).BeginInit();
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
            this.ingenieriatc.Size = new System.Drawing.Size(1042, 471);
            this.ingenieriatc.TabIndex = 1;
            // 
            // ingenieriaform
            // 
            this.ingenieriaform.AutoScroll = true;
            this.ingenieriaform.Controls.Add(this.txttipo);
            this.ingenieriaform.Controls.Add(this.label6);
            this.ingenieriaform.Controls.Add(this.dataGridView1);
            this.ingenieriaform.Controls.Add(this.label9);
            this.ingenieriaform.Controls.Add(this.unidadtxt);
            this.ingenieriaform.Controls.Add(this.label3);
            this.ingenieriaform.Controls.Add(this.label2);
            this.ingenieriaform.Controls.Add(this.label1);
            this.ingenieriaform.Controls.Add(this.txtFecha);
            this.ingenieriaform.Controls.Add(this.txtDesc);
            this.ingenieriaform.Controls.Add(this.idmateriatxt);
            this.ingenieriaform.Controls.Add(this.btnagregarmp);
            this.ingenieriaform.Location = new System.Drawing.Point(4, 27);
            this.ingenieriaform.Margin = new System.Windows.Forms.Padding(4);
            this.ingenieriaform.Name = "ingenieriaform";
            this.ingenieriaform.Padding = new System.Windows.Forms.Padding(4);
            this.ingenieriaform.Size = new System.Drawing.Size(1034, 440);
            this.ingenieriaform.TabIndex = 0;
            this.ingenieriaform.Text = "Captura de Materia Prima";
            this.ingenieriaform.UseVisualStyleBackColor = true;
            this.ingenieriaform.Click += new System.EventHandler(this.ingenieriaform_Click);
            // 
            // txttipo
            // 
            this.txttipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipo.Location = new System.Drawing.Point(184, 180);
            this.txttipo.Margin = new System.Windows.Forms.Padding(4);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(148, 24);
            this.txttipo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateriaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materiaPrimaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(409, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 336);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idMateriaDataGridViewTextBoxColumn
            // 
            this.idMateriaDataGridViewTextBoxColumn.DataPropertyName = "idMateria";
            this.idMateriaDataGridViewTextBoxColumn.HeaderText = "idMateria";
            this.idMateriaDataGridViewTextBoxColumn.Name = "idMateriaDataGridViewTextBoxColumn";
            this.idMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materiaPrimaBindingSource
            // 
            this.materiaPrimaBindingSource.DataMember = "MateriaPrima";
            this.materiaPrimaBindingSource.DataSource = this.erpdbDataSet1;
            // 
            // erpdbDataSet1
            // 
            this.erpdbDataSet1.DataSetName = "erpdbDataSet1";
            this.erpdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 144);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Unidad";
            // 
            // unidadtxt
            // 
            this.unidadtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidadtxt.Location = new System.Drawing.Point(184, 141);
            this.unidadtxt.Margin = new System.Windows.Forms.Padding(4);
            this.unidadtxt.Name = "unidadtxt";
            this.unidadtxt.Size = new System.Drawing.Size(148, 24);
            this.unidadtxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Materia";
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(184, 98);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(148, 24);
            this.txtFecha.TabIndex = 3;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(184, 62);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(148, 24);
            this.txtDesc.TabIndex = 2;
            // 
            // idmateriatxt
            // 
            this.idmateriatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idmateriatxt.Location = new System.Drawing.Point(184, 22);
            this.idmateriatxt.Margin = new System.Windows.Forms.Padding(4);
            this.idmateriatxt.Name = "idmateriatxt";
            this.idmateriatxt.Size = new System.Drawing.Size(148, 24);
            this.idmateriatxt.TabIndex = 1;
            // 
            // btnagregarmp
            // 
            this.btnagregarmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarmp.Location = new System.Drawing.Point(198, 242);
            this.btnagregarmp.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregarmp.Name = "btnagregarmp";
            this.btnagregarmp.Size = new System.Drawing.Size(112, 32);
            this.btnagregarmp.TabIndex = 0;
            this.btnagregarmp.Text = "Agregar";
            this.btnagregarmp.UseVisualStyleBackColor = true;
            this.btnagregarmp.Click += new System.EventHandler(this.btnagregarmp_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtfhora);
            this.tabPage2.Controls.Add(this.txtlocalidad);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.cantidadtxt);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btnagregarcomponentes);
            this.tabPage2.Controls.Add(this.txtdescripcion);
            this.tabPage2.Controls.Add(this.txtidproducto);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1034, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Captura de Producto Final";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nFolioDataGridViewTextBoxColumn,
            this.fHoraDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn1,
            this.locacionDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.inventarioProductoBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(368, 53);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(644, 276);
            this.dataGridView2.TabIndex = 9;
            // 
            // cantidadtxt
            // 
            this.cantidadtxt.Location = new System.Drawing.Point(212, 159);
            this.cantidadtxt.Margin = new System.Windows.Forms.Padding(4);
            this.cantidadtxt.Name = "cantidadtxt";
            this.cantidadtxt.Size = new System.Drawing.Size(148, 24);
            this.cantidadtxt.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 162);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "Cantidad";
            // 
            // btnagregarcomponentes
            // 
            this.btnagregarcomponentes.Location = new System.Drawing.Point(188, 377);
            this.btnagregarcomponentes.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregarcomponentes.Name = "btnagregarcomponentes";
            this.btnagregarcomponentes.Size = new System.Drawing.Size(112, 32);
            this.btnagregarcomponentes.TabIndex = 4;
            this.btnagregarcomponentes.Text = "Ingresar";
            this.btnagregarcomponentes.UseVisualStyleBackColor = true;
            this.btnagregarcomponentes.Click += new System.EventHandler(this.btnagregarcomponentes_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(212, 72);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(148, 24);
            this.txtdescripcion.TabIndex = 3;
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(212, 24);
            this.txtidproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(148, 24);
            this.txtidproducto.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Descripción";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.btncapturarlin);
            this.tabPage3.Controls.Add(this.descripcionltxt);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1034, 440);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Captura Lineas de Produccion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Linea 1",
            "Linea 2",
            "Linea 3"});
            this.comboBox1.Location = new System.Drawing.Point(152, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 26);
            this.comboBox1.TabIndex = 7;
            // 
            // btncapturarlin
            // 
            this.btncapturarlin.Location = new System.Drawing.Point(152, 176);
            this.btncapturarlin.Margin = new System.Windows.Forms.Padding(4);
            this.btncapturarlin.Name = "btncapturarlin";
            this.btncapturarlin.Size = new System.Drawing.Size(124, 44);
            this.btncapturarlin.TabIndex = 6;
            this.btncapturarlin.Text = "Agregar";
            this.btncapturarlin.UseVisualStyleBackColor = true;
            this.btncapturarlin.Click += new System.EventHandler(this.btncapturarlin_Click);
            // 
            // descripcionltxt
            // 
            this.descripcionltxt.Location = new System.Drawing.Point(152, 72);
            this.descripcionltxt.Margin = new System.Windows.Forms.Padding(4);
            this.descripcionltxt.Multiline = true;
            this.descripcionltxt.Name = "descripcionltxt";
            this.descripcionltxt.Size = new System.Drawing.Size(289, 82);
            this.descripcionltxt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Línea";
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
            this.tabPage1.Size = new System.Drawing.Size(1034, 440);
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
            // materiaPrimaTableAdapter
            // 
            this.materiaPrimaTableAdapter.ClearBeforeFill = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 235);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 18);
            this.label15.TabIndex = 14;
            this.label15.Text = "Fecha";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 197);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 18);
            this.label16.TabIndex = 15;
            this.label16.Text = "Localidad";
            // 
            // txtlocalidad
            // 
            this.txtlocalidad.Location = new System.Drawing.Point(212, 194);
            this.txtlocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtlocalidad.Name = "txtlocalidad";
            this.txtlocalidad.Size = new System.Drawing.Size(148, 24);
            this.txtlocalidad.TabIndex = 16;
            // 
            // txtfhora
            // 
            this.txtfhora.Location = new System.Drawing.Point(212, 232);
            this.txtfhora.Margin = new System.Windows.Forms.Padding(4);
            this.txtfhora.Name = "txtfhora";
            this.txtfhora.Size = new System.Drawing.Size(148, 24);
            this.txtfhora.TabIndex = 17;
            // 
            // inventarioproducto
            // 
            this.inventarioproducto.DataSetName = "inventarioproducto";
            this.inventarioproducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioproductoBindingSource
            // 
            this.inventarioproductoBindingSource.DataSource = this.inventarioproducto;
            this.inventarioproductoBindingSource.Position = 0;
            // 
            // nFolioDataGridViewTextBoxColumn
            // 
            this.nFolioDataGridViewTextBoxColumn.DataPropertyName = "nFolio";
            this.nFolioDataGridViewTextBoxColumn.HeaderText = "nFolio";
            this.nFolioDataGridViewTextBoxColumn.Name = "nFolioDataGridViewTextBoxColumn";
            this.nFolioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fHoraDataGridViewTextBoxColumn
            // 
            this.fHoraDataGridViewTextBoxColumn.DataPropertyName = "fHora";
            this.fHoraDataGridViewTextBoxColumn.HeaderText = "fHora";
            this.fHoraDataGridViewTextBoxColumn.Name = "fHoraDataGridViewTextBoxColumn";
            this.fHoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn1
            // 
            this.cantidadDataGridViewTextBoxColumn1.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn1.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn1.Name = "cantidadDataGridViewTextBoxColumn1";
            this.cantidadDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // locacionDataGridViewTextBoxColumn
            // 
            this.locacionDataGridViewTextBoxColumn.DataPropertyName = "locacion";
            this.locacionDataGridViewTextBoxColumn.HeaderText = "locacion";
            this.locacionDataGridViewTextBoxColumn.Name = "locacionDataGridViewTextBoxColumn";
            this.locacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn1
            // 
            this.descripcionDataGridViewTextBoxColumn1.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn1.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn1.Name = "descripcionDataGridViewTextBoxColumn1";
            this.descripcionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // inventarioProductoBindingSource1
            // 
            this.inventarioProductoBindingSource1.DataMember = "InventarioProducto";
            this.inventarioProductoBindingSource1.DataSource = this.erpdbDataSet3;
            // 
            // erpdbDataSet3
            // 
            this.erpdbDataSet3.DataSetName = "erpdbDataSet3";
            this.erpdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioProductoTableAdapter
            // 
            this.inventarioProductoTableAdapter.ClearBeforeFill = true;
            // 
            // Ingenieria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 550);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaPrimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpdbDataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioproductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioProductoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpdbDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ingenieriatc;
        private System.Windows.Forms.TabPage ingenieriaform;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox unidadtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox idmateriatxt;
        private System.Windows.Forms.Button btnagregarmp;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox cantidadtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnagregarcomponentes;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btncapturarlin;
        private System.Windows.Forms.TextBox descripcionltxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buscarrtxt;
        private System.Windows.Forms.TextBox fechaptxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.Label label6;
        private erpdbDataSet1 erpdbDataSet1;
        private System.Windows.Forms.BindingSource materiaPrimaBindingSource;
        private erpdbDataSet1TableAdapters.MateriaPrimaTableAdapter materiaPrimaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtfhora;
        private System.Windows.Forms.TextBox txtlocalidad;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private inventarioproducto inventarioproducto;
        private System.Windows.Forms.BindingSource inventarioproductoBindingSource;
        private erpdbDataSet3 erpdbDataSet3;
        private System.Windows.Forms.BindingSource inventarioProductoBindingSource1;
        private erpdbDataSet3TableAdapters.InventarioProductoTableAdapter inventarioProductoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFolioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn locacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn1;
    }
}