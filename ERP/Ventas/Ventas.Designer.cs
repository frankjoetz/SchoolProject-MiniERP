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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFH = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbGamas = new System.Windows.Forms.ComboBox();
            this.btnAddC = new System.Windows.Forms.Button();
            this.txtCan = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBusHis = new System.Windows.Forms.Button();
            this.txtIDHis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(579, 258);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.txtNom);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lblFH);
            this.tabPage1.Controls.Add(this.btnAceptar);
            this.tabPage1.Controls.Add(this.cmbGamas);
            this.tabPage1.Controls.Add(this.btnAddC);
            this.tabPage1.Controls.Add(this.txtCan);
            this.tabPage1.Controls.Add(this.txtEmpresa);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(571, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Venta";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(129, 58);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(18, 17);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(23, 54);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 21);
            this.txtNom.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Equipos de computo";
            // 
            // lblFH
            // 
            this.lblFH.AutoSize = true;
            this.lblFH.ForeColor = System.Drawing.Color.Black;
            this.lblFH.Location = new System.Drawing.Point(380, 198);
            this.lblFH.Name = "lblFH";
            this.lblFH.Size = new System.Drawing.Size(141, 15);
            this.lblFH.TabIndex = 29;
            this.lblFH.Text = "label de hora y fecha";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(212, 198);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 28;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // cmbGamas
            // 
            this.cmbGamas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGamas.ForeColor = System.Drawing.Color.Black;
            this.cmbGamas.FormattingEnabled = true;
            this.cmbGamas.Items.AddRange(new object[] {
            "Gama Baja",
            "Gama Media",
            "Gama Alta"});
            this.cmbGamas.Location = new System.Drawing.Point(43, 154);
            this.cmbGamas.Name = "cmbGamas";
            this.cmbGamas.Size = new System.Drawing.Size(121, 23);
            this.cmbGamas.TabIndex = 27;
            // 
            // btnAddC
            // 
            this.btnAddC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddC.ForeColor = System.Drawing.Color.Black;
            this.btnAddC.Location = new System.Drawing.Point(72, 198);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(101, 23);
            this.btnAddC.TabIndex = 25;
            this.btnAddC.Text = "Agregar Cliente";
            this.btnAddC.UseVisualStyleBackColor = true;
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            // 
            // txtCan
            // 
            this.txtCan.Location = new System.Drawing.Point(202, 154);
            this.txtCan.Name = "txtCan";
            this.txtCan.Size = new System.Drawing.Size(100, 21);
            this.txtCan.TabIndex = 24;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Cursor = System.Windows.Forms.Cursors.No;
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Location = new System.Drawing.Point(202, 54);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(100, 21);
            this.txtEmpresa.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(199, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(189, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cliente (ID)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.Location = new System.Drawing.Point(328, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 170);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btnBusHis);
            this.tabPage2.Controls.Add(this.txtIDHis);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 232);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historial";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 151);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnBusHis
            // 
            this.btnBusHis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusHis.ForeColor = System.Drawing.Color.Black;
            this.btnBusHis.Location = new System.Drawing.Point(365, 24);
            this.btnBusHis.Name = "btnBusHis";
            this.btnBusHis.Size = new System.Drawing.Size(75, 23);
            this.btnBusHis.TabIndex = 2;
            this.btnBusHis.Text = "Buscar";
            this.btnBusHis.UseVisualStyleBackColor = true;
            // 
            // txtIDHis
            // 
            this.txtIDHis.Location = new System.Drawing.Point(223, 24);
            this.txtIDHis.Name = "txtIDHis";
            this.txtIDHis.Size = new System.Drawing.Size(100, 21);
            this.txtIDHis.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(199, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(583, 264);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ventas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFH;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbGamas;
        private System.Windows.Forms.Button btnAddC;
        private System.Windows.Forms.TextBox txtCan;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBusHis;
        private System.Windows.Forms.TextBox txtIDHis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}