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
            this.label7 = new System.Windows.Forms.Label();
            this.cbnStatus = new System.Windows.Forms.ComboBox();
            this.dtpFec_Entr = new System.Windows.Forms.DateTimePicker();
            this.dtpFec_Ini = new System.Windows.Forms.DateTimePicker();
            this.txtbId_Ped = new System.Windows.Forms.TextBox();
            this.txtbId_Plan = new System.Windows.Forms.TextBox();
            this.txtbObser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbStatus_buscar = new System.Windows.Forms.ComboBox();
            this.dtp_Inicio_Buscar = new System.Windows.Forms.DateTimePicker();
            this.txtbId_ped_buscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(677, 352);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cbnStatus);
            this.tabPage1.Controls.Add(this.dtpFec_Entr);
            this.tabPage1.Controls.Add(this.dtpFec_Ini);
            this.tabPage1.Controls.Add(this.txtbId_Ped);
            this.tabPage1.Controls.Add(this.txtbId_Plan);
            this.tabPage1.Controls.Add(this.txtbObser);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(669, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NUEVA";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "NUEVA PLANEACIÓN";
            // 
            // cbnStatus
            // 
            this.cbnStatus.FormattingEnabled = true;
            this.cbnStatus.Items.AddRange(new object[] {
            "PEDIDO (VENTAS)",
            "PLANEACIÓN",
            "ALMACÉN",
            "PRODUCCIÓN"});
            this.cbnStatus.Location = new System.Drawing.Point(125, 155);
            this.cbnStatus.Name = "cbnStatus";
            this.cbnStatus.Size = new System.Drawing.Size(211, 21);
            this.cbnStatus.TabIndex = 15;
            // 
            // dtpFec_Entr
            // 
            this.dtpFec_Entr.Location = new System.Drawing.Point(124, 127);
            this.dtpFec_Entr.Name = "dtpFec_Entr";
            this.dtpFec_Entr.Size = new System.Drawing.Size(212, 20);
            this.dtpFec_Entr.TabIndex = 10;
            this.dtpFec_Entr.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtpFec_Ini
            // 
            this.dtpFec_Ini.Location = new System.Drawing.Point(123, 101);
            this.dtpFec_Ini.Name = "dtpFec_Ini";
            this.dtpFec_Ini.Size = new System.Drawing.Size(213, 20);
            this.dtpFec_Ini.TabIndex = 9;
            // 
            // txtbId_Ped
            // 
            this.txtbId_Ped.Location = new System.Drawing.Point(122, 70);
            this.txtbId_Ped.Name = "txtbId_Ped";
            this.txtbId_Ped.Size = new System.Drawing.Size(145, 20);
            this.txtbId_Ped.TabIndex = 8;
            // 
            // txtbId_Plan
            // 
            this.txtbId_Plan.Location = new System.Drawing.Point(123, 41);
            this.txtbId_Plan.Name = "txtbId_Plan";
            this.txtbId_Plan.Size = new System.Drawing.Size(144, 20);
            this.txtbId_Plan.TabIndex = 7;
            // 
            // txtbObser
            // 
            this.txtbObser.Location = new System.Drawing.Point(124, 193);
            this.txtbObser.Multiline = true;
            this.txtbObser.Name = "txtbObser";
            this.txtbObser.Size = new System.Drawing.Size(524, 100);
            this.txtbObser.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "OBSERVACIONES:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "STATUS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA ENTREGA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA INICIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
<<<<<<< HEAD
            this.label2.Size = new System.Drawing.Size(68, 13);
=======
            this.label2.Size = new System.Drawing.Size(75, 13);
>>>>>>> origin/master
            this.label2.TabIndex = 1;
            this.label2.Text = "ID PEDIDO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
<<<<<<< HEAD
            this.label1.Size = new System.Drawing.Size(95, 13);
=======
            this.label1.Size = new System.Drawing.Size(106, 13);
>>>>>>> origin/master
            this.label1.TabIndex = 0;
            this.label1.Text = "ID PLANEACION:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtbStatus_buscar);
            this.tabPage2.Controls.Add(this.dtp_Inicio_Buscar);
            this.tabPage2.Controls.Add(this.txtbId_ped_buscar);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(669, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BUSCAR";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(229, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(256, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "BUSCAR PLANEACIÓN";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtbStatus_buscar
            // 
            this.txtbStatus_buscar.FormattingEnabled = true;
            this.txtbStatus_buscar.Items.AddRange(new object[] {
            "PEDIDO (VENTAS)",
            "PLANEACIÓN",
            "ALMACÉN",
            "PRODUCCIÓN"});
            this.txtbStatus_buscar.Location = new System.Drawing.Point(149, 166);
            this.txtbStatus_buscar.Name = "txtbStatus_buscar";
            this.txtbStatus_buscar.Size = new System.Drawing.Size(458, 21);
            this.txtbStatus_buscar.TabIndex = 16;
            // 
            // dtp_Inicio_Buscar
            // 
            this.dtp_Inicio_Buscar.Location = new System.Drawing.Point(149, 117);
            this.dtp_Inicio_Buscar.Name = "dtp_Inicio_Buscar";
            this.dtp_Inicio_Buscar.Size = new System.Drawing.Size(458, 20);
            this.dtp_Inicio_Buscar.TabIndex = 4;
            // 
            // txtbId_ped_buscar
            // 
            this.txtbId_ped_buscar.Location = new System.Drawing.Point(149, 67);
            this.txtbId_ped_buscar.Name = "txtbId_ped_buscar";
            this.txtbId_ped_buscar.Size = new System.Drawing.Size(458, 20);
            this.txtbId_ped_buscar.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "STATUS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "FECHA INICIO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID PEDIDO:";
            // 
            // Planeacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 367);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Planeacion";
            this.Text = "Planeacion";
            this.Load += new System.EventHandler(this.Planeacion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFec_Entr;
        private System.Windows.Forms.DateTimePicker dtpFec_Ini;
        private System.Windows.Forms.TextBox txtbId_Ped;
        private System.Windows.Forms.TextBox txtbId_Plan;
        private System.Windows.Forms.TextBox txtbObser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbnStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_Inicio_Buscar;
        private System.Windows.Forms.TextBox txtbId_ped_buscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtbStatus_buscar;

    }
}