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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            carteleraToolStripMenuItem = new ToolStripMenuItem();
            funcionesToolStripMenuItem = new ToolStripMenuItem();
            salasToolStripMenuItem = new ToolStripMenuItem();
            promocionesToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            pnlMenuAdmin = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, carteleraToolStripMenuItem, funcionesToolStripMenuItem, salasToolStripMenuItem, promocionesToolStripMenuItem, reportesToolStripMenuItem, usuariosToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(61, 24);
            homeToolStripMenuItem.Text = "LOGO";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // carteleraToolStripMenuItem
            // 
            carteleraToolStripMenuItem.Name = "carteleraToolStripMenuItem";
            carteleraToolStripMenuItem.Size = new Size(83, 24);
            carteleraToolStripMenuItem.Text = "Cartelera";
            carteleraToolStripMenuItem.Click += carteleraToolStripMenuItem_Click;
            // 
            // funcionesToolStripMenuItem
            // 
            funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            funcionesToolStripMenuItem.Size = new Size(88, 24);
            funcionesToolStripMenuItem.Text = "Funciones";
            funcionesToolStripMenuItem.Click += funcionesToolStripMenuItem_Click;
            // 
            // salasToolStripMenuItem
            // 
            salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            salasToolStripMenuItem.Size = new Size(62, 24);
            salasToolStripMenuItem.Text = "Sedes";
            salasToolStripMenuItem.Click += salasToolStripMenuItem_Click;
            // 
            // promocionesToolStripMenuItem
            // 
            promocionesToolStripMenuItem.Name = "promocionesToolStripMenuItem";
            promocionesToolStripMenuItem.Size = new Size(109, 24);
            promocionesToolStripMenuItem.Text = "Promociones";
            promocionesToolStripMenuItem.Click += promocionesToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(79, 24);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            ayudaToolStripMenuItem.Click += ayudaToolStripMenuItem_Click;
            // 
            // pnlMenuAdmin
            // 
            pnlMenuAdmin.BackColor = SystemColors.MenuHighlight;
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrMenuAdmin";
            Text = "FrMenuAdmin";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem carteleraToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private Panel pnlMenuAdmin;
        private ToolStripMenuItem funcionesToolStripMenuItem;
        private ToolStripMenuItem salasToolStripMenuItem;
        private ToolStripMenuItem promocionesToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
    }
}