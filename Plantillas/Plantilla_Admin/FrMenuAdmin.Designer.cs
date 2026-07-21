namespace Plantilla_Admin
{
    partial class FrMenuAdmin
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
            menuStrip_MenuAdmin = new MenuStrip();
            toolStripMenuItem_landing = new ToolStripMenuItem();
            toolStripMenuItem_cartelera = new ToolStripMenuItem();
            toolStripMenuItem_funciones = new ToolStripMenuItem();
            toolStripMenuItem_sedes = new ToolStripMenuItem();
            toolStripMenuItem_promociones = new ToolStripMenuItem();
            toolStripMenuItem_reportes = new ToolStripMenuItem();
            toolStripMenuItem_usuarios = new ToolStripMenuItem();
            toolStripMenuItem_ayuda = new ToolStripMenuItem();
            pnlMenuAdmin = new Panel();
            menuStrip_MenuAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_MenuAdmin
            // 
            menuStrip_MenuAdmin.ImageScalingSize = new Size(20, 20);
            menuStrip_MenuAdmin.Items.AddRange(new ToolStripItem[] { toolStripMenuItem_landing, toolStripMenuItem_cartelera, toolStripMenuItem_funciones, toolStripMenuItem_sedes, toolStripMenuItem_promociones, toolStripMenuItem_reportes, toolStripMenuItem_usuarios, toolStripMenuItem_ayuda });
            menuStrip_MenuAdmin.Location = new Point(0, 0);
            menuStrip_MenuAdmin.Name = "menuStrip_MenuAdmin";
            menuStrip_MenuAdmin.Size = new Size(800, 28);
            menuStrip_MenuAdmin.TabIndex = 0;
            menuStrip_MenuAdmin.Text = "menuStrip1";
            // 
            // toolStripMenuItem_landing
            // 
            toolStripMenuItem_landing.Name = "toolStripMenuItem_landing";
            toolStripMenuItem_landing.Size = new Size(61, 24);
            toolStripMenuItem_landing.Text = "LOGO";
            toolStripMenuItem_landing.Click += homeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem_cartelera
            // 
            toolStripMenuItem_cartelera.Name = "toolStripMenuItem_cartelera";
            toolStripMenuItem_cartelera.Size = new Size(83, 24);
            toolStripMenuItem_cartelera.Text = "Cartelera";
            toolStripMenuItem_cartelera.Click += carteleraToolStripMenuItem_Click;
            // 
            // toolStripMenuItem_funciones
            // 
            toolStripMenuItem_funciones.Name = "toolStripMenuItem_funciones";
            toolStripMenuItem_funciones.Size = new Size(88, 24);
            toolStripMenuItem_funciones.Text = "Funciones";
            toolStripMenuItem_funciones.Click += funcionesToolStripMenuItem_Click;
            // 
            // toolStripMenuItem_sedes
            // 
            toolStripMenuItem_sedes.Name = "toolStripMenuItem_sedes";
            toolStripMenuItem_sedes.Size = new Size(62, 24);
            toolStripMenuItem_sedes.Text = "Sedes";
            toolStripMenuItem_sedes.Click += salasToolStripMenuItem_Click;
            // 
            // toolStripMenuItem_promociones
            // 
            toolStripMenuItem_promociones.Name = "toolStripMenuItem_promociones";
            toolStripMenuItem_promociones.Size = new Size(109, 24);
            toolStripMenuItem_promociones.Text = "Promociones";
            toolStripMenuItem_promociones.Click += promocionesToolStripMenuItem_Click;
            // 
            // toolStripMenuItem_reportes
            // 
            toolStripMenuItem_reportes.Name = "toolStripMenuItem_reportes";
            toolStripMenuItem_reportes.Size = new Size(82, 24);
            toolStripMenuItem_reportes.Text = "Reportes";
            toolStripMenuItem_reportes.Click += reportesToolStripMenuItem_Click;
            // 
            // toolStripMenuItem_usuarios
            // 
            toolStripMenuItem_usuarios.Name = "toolStripMenuItem_usuarios";
            toolStripMenuItem_usuarios.Size = new Size(79, 24);
            toolStripMenuItem_usuarios.Text = "Usuarios";
            toolStripMenuItem_usuarios.Click += usuariosToolStripMenuItem_Click;
            // 
            // toolStripMenuItem_ayuda
            // 
            toolStripMenuItem_ayuda.Name = "toolStripMenuItem_ayuda";
            toolStripMenuItem_ayuda.Size = new Size(65, 24);
            toolStripMenuItem_ayuda.Text = "Ayuda";
            toolStripMenuItem_ayuda.Click += ayudaToolStripMenuItem_Click;
            // 
            // pnlMenuAdmin
            // 
            pnlMenuAdmin.Dock = DockStyle.Fill;
            pnlMenuAdmin.Location = new Point(0, 28);
            pnlMenuAdmin.Name = "pnlMenuAdmin";
            pnlMenuAdmin.Size = new Size(800, 422);
            pnlMenuAdmin.TabIndex = 1;
            // 
            // FrMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMenuAdmin);
            Controls.Add(menuStrip_MenuAdmin);
            MainMenuStrip = menuStrip_MenuAdmin;
            Name = "FrMenuAdmin";
            Text = "FrMenuAdmin";
            menuStrip_MenuAdmin.ResumeLayout(false);
            menuStrip_MenuAdmin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_MenuAdmin;
        private ToolStripMenuItem toolStripMenuItem_cartelera;
        private ToolStripMenuItem toolStripMenuItem_reportes;
        private ToolStripMenuItem toolStripMenuItem_usuarios;
        private ToolStripMenuItem toolStripMenuItem_ayuda;
        private Panel pnlMenuAdmin;
        private ToolStripMenuItem toolStripMenuItem_funciones;
        private ToolStripMenuItem toolStripMenuItem_sedes;
        private ToolStripMenuItem toolStripMenuItem_promociones;
        private ToolStripMenuItem toolStripMenuItem_landing;
    }
}