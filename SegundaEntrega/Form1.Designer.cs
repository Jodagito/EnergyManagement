namespace SegundaEntrega
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioConsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalDescuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ahorroPorEstratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superaronLaMetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.informaciónToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            resources.ApplyResources(this.registrarToolStripMenuItem, "registrarToolStripMenuItem");
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem
            // 
            resources.ApplyResources(this.informaciónToolStripMenuItem, "informaciónToolStripMenuItem");
            this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valorFacturaToolStripMenuItem,
            this.promedioConsumoToolStripMenuItem,
            this.totalDescuentosToolStripMenuItem,
            this.ahorroPorEstratoToolStripMenuItem,
            this.superaronLaMetaToolStripMenuItem});
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            // 
            // valorFacturaToolStripMenuItem
            // 
            resources.ApplyResources(this.valorFacturaToolStripMenuItem, "valorFacturaToolStripMenuItem");
            this.valorFacturaToolStripMenuItem.Name = "valorFacturaToolStripMenuItem";
            this.valorFacturaToolStripMenuItem.Click += new System.EventHandler(this.valorFacturaToolStripMenuItem_Click);
            // 
            // promedioConsumoToolStripMenuItem
            // 
            resources.ApplyResources(this.promedioConsumoToolStripMenuItem, "promedioConsumoToolStripMenuItem");
            this.promedioConsumoToolStripMenuItem.Name = "promedioConsumoToolStripMenuItem";
            this.promedioConsumoToolStripMenuItem.Click += new System.EventHandler(this.promedioConsumoToolStripMenuItem_Click);
            // 
            // totalDescuentosToolStripMenuItem
            // 
            resources.ApplyResources(this.totalDescuentosToolStripMenuItem, "totalDescuentosToolStripMenuItem");
            this.totalDescuentosToolStripMenuItem.Name = "totalDescuentosToolStripMenuItem";
            this.totalDescuentosToolStripMenuItem.Click += new System.EventHandler(this.totalDescuentosToolStripMenuItem_Click);
            // 
            // ahorroPorEstratoToolStripMenuItem
            // 
            resources.ApplyResources(this.ahorroPorEstratoToolStripMenuItem, "ahorroPorEstratoToolStripMenuItem");
            this.ahorroPorEstratoToolStripMenuItem.Name = "ahorroPorEstratoToolStripMenuItem";
            this.ahorroPorEstratoToolStripMenuItem.Click += new System.EventHandler(this.ahorroPorEstratoToolStripMenuItem_Click);
            // 
            // superaronLaMetaToolStripMenuItem
            // 
            resources.ApplyResources(this.superaronLaMetaToolStripMenuItem, "superaronLaMetaToolStripMenuItem");
            this.superaronLaMetaToolStripMenuItem.Name = "superaronLaMetaToolStripMenuItem";
            this.superaronLaMetaToolStripMenuItem.Click += new System.EventHandler(this.superaronLaMetaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valorFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promedioConsumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalDescuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ahorroPorEstratoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem superaronLaMetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
    }
}

