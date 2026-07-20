namespace Plantilla_Admin
{
    partial class sedes
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
            pruebaToolStripMenuItem = new ToolStripMenuItem();
            pruebaToolStripMenuItem1 = new ToolStripMenuItem();
            actualizarSedeToolStripMenuItem = new ToolStripMenuItem();
            eliminarSedeToolStripMenuItem = new ToolStripMenuItem();
            buscarSalaToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            eliminarSalaToolStripMenuItem = new ToolStripMenuItem();
            actualizarSalaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 192, 192);
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pruebaToolStripMenuItem, pruebaToolStripMenuItem1, actualizarSedeToolStripMenuItem, eliminarSedeToolStripMenuItem, buscarSalaToolStripMenuItem, agregarToolStripMenuItem, actualizarSalaToolStripMenuItem, eliminarSalaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(132, 418);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // pruebaToolStripMenuItem
            // 
            pruebaToolStripMenuItem.Name = "pruebaToolStripMenuItem";
            pruebaToolStripMenuItem.Size = new Size(143, 24);
            pruebaToolStripMenuItem.Text = "Buscar Sede";
            // 
            // pruebaToolStripMenuItem1
            // 
            pruebaToolStripMenuItem1.Name = "pruebaToolStripMenuItem1";
            pruebaToolStripMenuItem1.Size = new Size(143, 24);
            pruebaToolStripMenuItem1.Text = "Agregar Sede";
            // 
            // actualizarSedeToolStripMenuItem
            // 
            actualizarSedeToolStripMenuItem.Name = "actualizarSedeToolStripMenuItem";
            actualizarSedeToolStripMenuItem.Size = new Size(143, 24);
            actualizarSedeToolStripMenuItem.Text = "Actualizar Sede";
            // 
            // eliminarSedeToolStripMenuItem
            // 
            eliminarSedeToolStripMenuItem.Name = "eliminarSedeToolStripMenuItem";
            eliminarSedeToolStripMenuItem.Size = new Size(143, 24);
            eliminarSedeToolStripMenuItem.Text = "Eliminar Sede";
            // 
            // buscarSalaToolStripMenuItem
            // 
            buscarSalaToolStripMenuItem.Name = "buscarSalaToolStripMenuItem";
            buscarSalaToolStripMenuItem.Size = new Size(143, 24);
            buscarSalaToolStripMenuItem.Text = "Buscar Sala ";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(119, 24);
            agregarToolStripMenuItem.Text = "Agregar Sala";
            // 
            // eliminarSalaToolStripMenuItem
            // 
            eliminarSalaToolStripMenuItem.Name = "eliminarSalaToolStripMenuItem";
            eliminarSalaToolStripMenuItem.Size = new Size(119, 24);
            eliminarSalaToolStripMenuItem.Text = "Eliminar Sala";
            // 
            // actualizarSalaToolStripMenuItem
            // 
            actualizarSalaToolStripMenuItem.Name = "actualizarSalaToolStripMenuItem";
            actualizarSalaToolStripMenuItem.Size = new Size(119, 24);
            actualizarSalaToolStripMenuItem.Text = "Actualizar Sala";
            // 
            // sedes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            Controls.Add(menuStrip1);
            Name = "sedes";
            Size = new Size(757, 418);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pruebaToolStripMenuItem;
        private ToolStripMenuItem pruebaToolStripMenuItem1;
        private ToolStripMenuItem actualizarSedeToolStripMenuItem;
        private ToolStripMenuItem eliminarSedeToolStripMenuItem;
        private ToolStripMenuItem buscarSalaToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem actualizarSalaToolStripMenuItem;
        private ToolStripMenuItem eliminarSalaToolStripMenuItem;
    }
}
