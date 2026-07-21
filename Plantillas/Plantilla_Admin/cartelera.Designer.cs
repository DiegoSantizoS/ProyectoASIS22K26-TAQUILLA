namespace Plantilla_Admin
{
    partial class cartelera
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            aGREGARToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { buscarToolStripMenuItem, aGREGARToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(95, 394);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(82, 24);
            buscarToolStripMenuItem.Text = "BUSCAR";
            buscarToolStripMenuItem.Click += buscarToolStripMenuItem_Click;
            // 
            // aGREGARToolStripMenuItem
            // 
            aGREGARToolStripMenuItem.Name = "aGREGARToolStripMenuItem";
            aGREGARToolStripMenuItem.Size = new Size(82, 24);
            aGREGARToolStripMenuItem.Text = "AGREGAR";
            aGREGARToolStripMenuItem.Click += aGREGARToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(95, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 394);
            panel1.TabIndex = 1;
            // 
            // cartelera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "cartelera";
            Size = new Size(857, 394);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem aGREGARToolStripMenuItem;
        private Panel panel1;
    }
}
