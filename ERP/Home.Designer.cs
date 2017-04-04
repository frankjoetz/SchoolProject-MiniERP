namespace ERP
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.strpHome = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingenieríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planeaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.strpHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // strpHome
            // 
            this.strpHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.strpHome.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strpHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.ingenieríaToolStripMenuItem,
            this.almacenToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.planeaciónToolStripMenuItem,
            this.producciónToolStripMenuItem,
            this.dashboardToolStripMenuItem,
            this.toolStripMenuItem1});
            this.strpHome.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.strpHome.Location = new System.Drawing.Point(0, 0);
            this.strpHome.Name = "strpHome";
            this.strpHome.Size = new System.Drawing.Size(146, 750);
            this.strpHome.TabIndex = 4;
            this.strpHome.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(133, 36);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // ingenieríaToolStripMenuItem
            // 
            this.ingenieríaToolStripMenuItem.Name = "ingenieríaToolStripMenuItem";
            this.ingenieríaToolStripMenuItem.Size = new System.Drawing.Size(133, 36);
            this.ingenieríaToolStripMenuItem.Text = "Ingeniería";
            this.ingenieríaToolStripMenuItem.Click += new System.EventHandler(this.ingenieríaToolStripMenuItem_Click);
            // 
            // almacenToolStripMenuItem
            // 
            this.almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            this.almacenToolStripMenuItem.Size = new System.Drawing.Size(133, 36);
            this.almacenToolStripMenuItem.Text = "Almacen";
            this.almacenToolStripMenuItem.Click += new System.EventHandler(this.almacenToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(133, 36);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // planeaciónToolStripMenuItem
            // 
            this.planeaciónToolStripMenuItem.Name = "planeaciónToolStripMenuItem";
            this.planeaciónToolStripMenuItem.Size = new System.Drawing.Size(133, 36);
            this.planeaciónToolStripMenuItem.Text = "Planeación";
            this.planeaciónToolStripMenuItem.Click += new System.EventHandler(this.planeaciónToolStripMenuItem_Click);
            // 
            // producciónToolStripMenuItem
            // 
            this.producciónToolStripMenuItem.Name = "producciónToolStripMenuItem";
            this.producciónToolStripMenuItem.Size = new System.Drawing.Size(133, 36);
            this.producciónToolStripMenuItem.Text = "Producción";
            this.producciónToolStripMenuItem.Click += new System.EventHandler(this.producciónToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(133, 36);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 4);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 750);
            this.Controls.Add(this.strpHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(10, 10);
            this.MainMenuStrip = this.strpHome;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1000, 736);
            this.Name = "Home";
            this.Text = "ERP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.Resize += new System.EventHandler(this.Home_SizeChanged);
            this.strpHome.ResumeLayout(false);
            this.strpHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip strpHome;
        private System.Windows.Forms.ToolStripMenuItem producciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingenieríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planeaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

