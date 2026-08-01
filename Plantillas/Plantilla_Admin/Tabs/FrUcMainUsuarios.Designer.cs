namespace Plantilla_Admin
{
    partial class FrUcMainUsuarios
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
            TsmUsuarios = new ToolStripMenuItem();
            TsmPerfiles = new ToolStripMenuItem();
            TsmAsignarPermisos = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TsmUsuarios, TsmPerfiles, TsmAsignarPermisos });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(156, 360);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // TsmUsuarios
            // 
            TsmUsuarios.Name = "TsmUsuarios";
            TsmUsuarios.Size = new Size(143, 24);
            TsmUsuarios.Text = "Usuarios";
            TsmUsuarios.Click += TsmUsuarios_Click;
            // 
            // TsmPerfiles
            // 
            TsmPerfiles.Name = "TsmPerfiles";
            TsmPerfiles.Size = new Size(143, 24);
            TsmPerfiles.Text = "Perfiles";
            TsmPerfiles.Click += pruebaToolStripMenuItem_Click;
            // 
            // TsmAsignarPermisos
            // 
            TsmAsignarPermisos.Name = "TsmAsignarPermisos";
            TsmAsignarPermisos.Size = new Size(143, 24);
            TsmAsignarPermisos.Text = "Asignar Permisos";
            TsmAsignarPermisos.Click += TsmAsignarPermisos_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(156, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 360);
            panel1.TabIndex = 2;
            // 
            // FrUcMainUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "FrUcMainUsuarios";
            Size = new Size(621, 360);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem TsmPerfiles;
        private ToolStripMenuItem TsmAsignarPermisos;
        private ToolStripMenuItem TsmUsuarios;
        private Panel panel1;
    }
}
