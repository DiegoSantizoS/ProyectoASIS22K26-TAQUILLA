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
            verUsuariosToolStripMenuItem = new ToolStripMenuItem();
            pruebaToolStripMenuItem = new ToolStripMenuItem();
            pruebaToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { verUsuariosToolStripMenuItem, pruebaToolStripMenuItem, pruebaToolStripMenuItem1, eliminarUsuarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(162, 396);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // verUsuariosToolStripMenuItem
            // 
            verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            verUsuariosToolStripMenuItem.Size = new Size(149, 24);
            verUsuariosToolStripMenuItem.Text = "AGREGAR FUNCIÓN";
            verUsuariosToolStripMenuItem.Click += verUsuariosToolStripMenuItem_Click;
            // 
            // pruebaToolStripMenuItem
            // 
            pruebaToolStripMenuItem.Name = "pruebaToolStripMenuItem";
            pruebaToolStripMenuItem.Size = new Size(149, 24);
            pruebaToolStripMenuItem.Text = "Nueva Función";
            // 
            // pruebaToolStripMenuItem1
            // 
            pruebaToolStripMenuItem1.Name = "pruebaToolStripMenuItem1";
            pruebaToolStripMenuItem1.Size = new Size(149, 24);
            pruebaToolStripMenuItem1.Text = "Actualizar Función";
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            eliminarUsuarioToolStripMenuItem.Size = new Size(149, 24);
            eliminarUsuarioToolStripMenuItem.Text = "Eliminar Función";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(162, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(631, 396);
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
        private ToolStripMenuItem verUsuariosToolStripMenuItem;
        private ToolStripMenuItem pruebaToolStripMenuItem;
        private ToolStripMenuItem pruebaToolStripMenuItem1;
        private ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private Panel panel1;
    }
}
