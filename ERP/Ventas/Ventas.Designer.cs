namespace ERP.Ventas
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbcVentas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddC = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCanGA = new System.Windows.Forms.TextBox();
            this.txtCanGM = new System.Windows.Forms.TextBox();
            this.chkGA = new System.Windows.Forms.CheckBox();
            this.chkGM = new System.Windows.Forms.CheckBox();
            this.chkGB = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtaCom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCanGB = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIDcliente = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rdbtnNC = new System.Windows.Forms.RadioButton();
            this.rdbtnID = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomCliHis = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDBorrar = new System.Windows.Forms.TextBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.txtIDHis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BClient = new System.Windows.Forms.TabPage();
            this.txtApell = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.txtNomb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.lblFH = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblH = new System.Windows.Forms.Label();
            this.tbcVentas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.BClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbcVentas
            // 
            this.tbcVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcVentas.Controls.Add(this.tabPage1);
            this.tbcVentas.Controls.Add(this.tabPage2);
            this.tbcVentas.Controls.Add(this.BClient);
            this.tbcVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbcVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcVentas.ItemSize = new System.Drawing.Size(119, 18);
            this.tbcVentas.Location = new System.Drawing.Point(12, 6);
            this.tbcVentas.Name = "tbcVentas";
            this.tbcVentas.SelectedIndex = 0;
            this.tbcVentas.Size = new System.Drawing.Size(900, 504);
            this.tbcVentas.TabIndex = 8;
            this.tbcVentas.SelectedIndexChanged += new System.EventHandler(this.tbcVentas_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.btnAddC);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.txtIDcliente);
            this.tabPage1.Controls.Add(this.txtEmpresa);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Venta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddC
            // 
            this.btnAddC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddC.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddC.Image = ((System.Drawing.Image)(resources.GetObject("btnAddC.Image")));
            this.btnAddC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddC.Location = new System.Drawing.Point(614, 26);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(237, 58);
            this.btnAddC.TabIndex = 42;
            this.btnAddC.Text = "Agregar Cliente";
            this.btnAddC.UseVisualStyleBackColor = true;
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(23, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 24);
            this.txtNombre.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCanGA);
            this.groupBox1.Controls.Add(this.txtCanGM);
            this.groupBox1.Controls.Add(this.chkGA);
            this.groupBox1.Controls.Add(this.chkGM);
            this.groupBox1.Controls.Add(this.chkGB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtaCom);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCanGB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 344);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCTO";
            // 
            // txtCanGA
            // 
            this.txtCanGA.Enabled = false;
            this.txtCanGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanGA.Location = new System.Drawing.Point(432, 122);
            this.txtCanGA.Name = "txtCanGA";
            this.txtCanGA.Size = new System.Drawing.Size(126, 24);
            this.txtCanGA.TabIndex = 39;
            this.txtCanGA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCanGA_KeyPress);
            // 
            // txtCanGM
            // 
            this.txtCanGM.Enabled = false;
            this.txtCanGM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanGM.Location = new System.Drawing.Point(432, 92);
            this.txtCanGM.Name = "txtCanGM";
            this.txtCanGM.Size = new System.Drawing.Size(126, 24);
            this.txtCanGM.TabIndex = 38;
            this.txtCanGM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCanGM_KeyPress);
            // 
            // chkGA
            // 
            this.chkGA.AutoSize = true;
            this.chkGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGA.Location = new System.Drawing.Point(23, 118);
            this.chkGA.Name = "chkGA";
            this.chkGA.Size = new System.Drawing.Size(96, 22);
            this.chkGA.TabIndex = 37;
            this.chkGA.Text = "Gama Alta";
            this.chkGA.UseVisualStyleBackColor = true;
            // 
            // chkGM
            // 
            this.chkGM.AutoSize = true;
            this.chkGM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGM.Location = new System.Drawing.Point(23, 89);
            this.chkGM.Name = "chkGM";
            this.chkGM.Size = new System.Drawing.Size(112, 22);
            this.chkGM.TabIndex = 36;
            this.chkGM.Text = "Gama Media";
            this.chkGM.UseVisualStyleBackColor = true;
            // 
            // chkGB
            // 
            this.chkGB.AutoSize = true;
            this.chkGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGB.Location = new System.Drawing.Point(23, 62);
            this.chkGB.Name = "chkGB";
            this.chkGB.Size = new System.Drawing.Size(101, 22);
            this.chkGB.TabIndex = 35;
            this.chkGB.Text = "Gama Baja";
            this.chkGB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Equipos de cómputo";
            // 
            // txtaCom
            // 
            this.txtaCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaCom.Location = new System.Drawing.Point(23, 173);
            this.txtaCom.Multiline = true;
            this.txtaCom.Name = "txtaCom";
            this.txtaCom.Size = new System.Drawing.Size(706, 92);
            this.txtaCom.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "Comentarios:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(343, 271);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(113, 35);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(429, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cantidad";
            // 
            // txtCanGB
            // 
            this.txtCanGB.Enabled = false;
            this.txtCanGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanGB.Location = new System.Drawing.Point(432, 63);
            this.txtCanGB.Name = "txtCanGB";
            this.txtCanGB.Size = new System.Drawing.Size(126, 24);
            this.txtCanGB.TabIndex = 4;
            this.txtCanGB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCanGB_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(168, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(18, 17);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIDcliente
            // 
            this.txtIDcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDcliente.Location = new System.Drawing.Point(131, 49);
            this.txtIDcliente.Name = "txtIDcliente";
            this.txtIDcliente.Size = new System.Drawing.Size(31, 24);
            this.txtIDcliente.TabIndex = 0;
            this.txtIDcliente.TextChanged += new System.EventHandler(this.txtIDcliente_TextChanged);
            this.txtIDcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDcliente_KeyPress);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.Location = new System.Drawing.Point(278, 49);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(163, 24);
            this.txtEmpresa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(275, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cliente (ID)";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.rdbtnNC);
            this.tabPage2.Controls.Add(this.rdbtnID);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtNomCliHis);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtIDBorrar);
            this.tabPage2.Controls.Add(this.dgvPedido);
            this.tabPage2.Controls.Add(this.txtIDHis);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historial";
            // 
            // rdbtnNC
            // 
            this.rdbtnNC.AutoSize = true;
            this.rdbtnNC.Location = new System.Drawing.Point(507, 24);
            this.rdbtnNC.Name = "rdbtnNC";
            this.rdbtnNC.Size = new System.Drawing.Size(14, 13);
            this.rdbtnNC.TabIndex = 12;
            this.rdbtnNC.TabStop = true;
            this.rdbtnNC.UseVisualStyleBackColor = true;
            // 
            // rdbtnID
            // 
            this.rdbtnID.AutoSize = true;
            this.rdbtnID.Checked = true;
            this.rdbtnID.Location = new System.Drawing.Point(230, 24);
            this.rdbtnID.Name = "rdbtnID";
            this.rdbtnID.Size = new System.Drawing.Size(14, 13);
            this.rdbtnID.TabIndex = 11;
            this.rdbtnID.TabStop = true;
            this.rdbtnID.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Buscar pedido por:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label10.Location = new System.Drawing.Point(264, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nombre del cliente";
            // 
            // txtNomCliHis
            // 
            this.txtNomCliHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNomCliHis.Location = new System.Drawing.Point(401, 18);
            this.txtNomCliHis.Name = "txtNomCliHis";
            this.txtNomCliHis.Size = new System.Drawing.Size(100, 24);
            this.txtNomCliHis.TabIndex = 7;
            this.txtNomCliHis.TextChanged += new System.EventHandler(this.txtHis_TextChanged);
            this.txtNomCliHis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomCliHis_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(792, 21);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(572, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "ID del pedido a cancelar";
            // 
            // txtIDBorrar
            // 
            this.txtIDBorrar.Enabled = false;
            this.txtIDBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtIDBorrar.Location = new System.Drawing.Point(752, 18);
            this.txtIDBorrar.Name = "txtIDBorrar";
            this.txtIDBorrar.Size = new System.Drawing.Size(23, 24);
            this.txtIDBorrar.TabIndex = 4;
            // 
            // dgvPedido
            // 
            this.dgvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPedido.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(6, 61);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPedido.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(880, 563);
            this.dgvPedido.TabIndex = 3;
            this.dgvPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellClick);
            // 
            // txtIDHis
            // 
            this.txtIDHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtIDHis.Location = new System.Drawing.Point(193, 18);
            this.txtIDHis.Name = "txtIDHis";
            this.txtIDHis.Size = new System.Drawing.Size(31, 24);
            this.txtIDHis.TabIndex = 1;
            this.txtIDHis.TextChanged += new System.EventHandler(this.txtHis_TextChanged);
            this.txtIDHis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDHis_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(165, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // BClient
            // 
            this.BClient.Controls.Add(this.txtApell);
            this.BClient.Controls.Add(this.label12);
            this.BClient.Controls.Add(this.label4);
            this.BClient.Controls.Add(this.txtEmp);
            this.BClient.Controls.Add(this.txtNomb);
            this.BClient.Controls.Add(this.label8);
            this.BClient.Controls.Add(this.dgvBuscar);
            this.BClient.Location = new System.Drawing.Point(4, 22);
            this.BClient.Name = "BClient";
            this.BClient.Padding = new System.Windows.Forms.Padding(3);
            this.BClient.Size = new System.Drawing.Size(892, 478);
            this.BClient.TabIndex = 2;
            this.BClient.Text = "Clientes";
            this.BClient.UseVisualStyleBackColor = true;
            // 
            // txtApell
            // 
            this.txtApell.Enabled = false;
            this.txtApell.Location = new System.Drawing.Point(92, 39);
            this.txtApell.Name = "txtApell";
            this.txtApell.Size = new System.Drawing.Size(100, 23);
            this.txtApell.TabIndex = 12;
            this.txtApell.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            this.txtApell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApell_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "APELLIDO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(245, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "EMPRESA";
            // 
            // txtEmp
            // 
            this.txtEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmp.Location = new System.Drawing.Point(332, 24);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(100, 24);
            this.txtEmp.TabIndex = 2;
            this.txtEmp.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            this.txtEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmp_KeyPress);
            // 
            // txtNomb
            // 
            this.txtNomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomb.Location = new System.Drawing.Point(92, 9);
            this.txtNomb.Name = "txtNomb";
            this.txtNomb.Size = new System.Drawing.Size(100, 24);
            this.txtNomb.TabIndex = 1;
            this.txtNomb.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            this.txtNomb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomb_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(11, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "NOMBRE";
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvBuscar.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBuscar.Location = new System.Drawing.Point(6, 68);
            this.dgvBuscar.MultiSelect = false;
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.ReadOnly = true;
            this.dgvBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscar.Size = new System.Drawing.Size(880, 556);
            this.dgvBuscar.TabIndex = 3;
            this.dgvBuscar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscar_Click);
            // 
            // lblFH
            // 
            this.lblFH.AutoSize = true;
            this.lblFH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFH.ForeColor = System.Drawing.Color.Black;
            this.lblFH.Location = new System.Drawing.Point(627, 6);
            this.lblFH.Name = "lblFH";
            this.lblFH.Size = new System.Drawing.Size(98, 18);
            this.lblFH.TabIndex = 40;
            this.lblFH.Text = "label de fecha";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(742, 6);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(38, 18);
            this.lblH.TabIndex = 40;
            this.lblH.Text = "hora";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(924, 523);
            this.ControlBox = false;
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblFH);
            this.Controls.Add(this.tbcVentas);
            this.Name = "Ventas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.tbcVentas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.BClient.ResumeLayout(false);
            this.BClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tbcVentas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCanGB;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtIDHis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtaCom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIDcliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage BClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.TextBox txtNomb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.Label lblFH;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCanGA;
        private System.Windows.Forms.TextBox txtCanGM;
        private System.Windows.Forms.CheckBox chkGA;
        private System.Windows.Forms.CheckBox chkGM;
        private System.Windows.Forms.CheckBox chkGB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomCliHis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdbtnNC;
        private System.Windows.Forms.RadioButton rdbtnID;
        private System.Windows.Forms.TextBox txtApell;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddC;
    }
}