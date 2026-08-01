namespace Plantilla_Admin
{
    partial class FrUcMainFunciones
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
            pRUEBAToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pRUEBAToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(156, 396);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // pRUEBAToolStripMenuItem
            // 
            pRUEBAToolStripMenuItem.Name = "pRUEBAToolStripMenuItem";
            pRUEBAToolStripMenuItem.Size = new Size(143, 24);
            pRUEBAToolStripMenuItem.Text = "PRUEBA";
            pRUEBAToolStripMenuItem.Click += pRUEBAToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(156, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 396);
            panel1.TabIndex = 3;
            // 
            // FrUcMainFunciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "FrUcMainFunciones";
            Size = new Size(793, 396);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel panel1;
        private ToolStripMenuItem pRUEBAToolStripMenuItem;
    }
}
