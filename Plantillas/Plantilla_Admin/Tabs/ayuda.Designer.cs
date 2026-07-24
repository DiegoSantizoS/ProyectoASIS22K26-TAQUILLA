namespace Plantilla_Admin
{
    partial class ayuda
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
            carteleraToolStripMenuItem = new ToolStripMenuItem();
            pREGUNTASFRECUENTESToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            cOMOVERLASFUNCIONESDEUNASALAToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { carteleraToolStripMenuItem, pREGUNTASFRECUENTESToolStripMenuItem, reportesToolStripMenuItem, usuariosToolStripMenuItem, ayudaToolStripMenuItem, cOMOVERLASFUNCIONESDEUNASALAToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(309, 344);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // carteleraToolStripMenuItem
            // 
            carteleraToolStripMenuItem.Name = "carteleraToolStripMenuItem";
            carteleraToolStripMenuItem.Size = new Size(302, 24);
            carteleraToolStripMenuItem.Text = "DICCIONARIO DE CONCEPTOS";
            carteleraToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pREGUNTASFRECUENTESToolStripMenuItem
            // 
            pREGUNTASFRECUENTESToolStripMenuItem.Name = "pREGUNTASFRECUENTESToolStripMenuItem";
            pREGUNTASFRECUENTESToolStripMenuItem.Size = new Size(302, 24);
            pREGUNTASFRECUENTESToolStripMenuItem.Text = "PREGUNTAS FRECUENTES";
            pREGUNTASFRECUENTESToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            pREGUNTASFRECUENTESToolStripMenuItem.Click += pREGUNTASFRECUENTESToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(302, 24);
            reportesToolStripMenuItem.Text = "COMO AGREGAR UNA CARTELERA";
            reportesToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(302, 24);
            usuariosToolStripMenuItem.Text = "COMO AGREGAR UNA FUNCIÓN";
            usuariosToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(302, 24);
            ayudaToolStripMenuItem.Text = "COMO VER LAS FUNCIONES DE UNA SEDE";
            ayudaToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cOMOVERLASFUNCIONESDEUNASALAToolStripMenuItem
            // 
            cOMOVERLASFUNCIONESDEUNASALAToolStripMenuItem.Name = "cOMOVERLASFUNCIONESDEUNASALAToolStripMenuItem";
            cOMOVERLASFUNCIONESDEUNASALAToolStripMenuItem.Size = new Size(302, 24);
            cOMOVERLASFUNCIONESDEUNASALAToolStripMenuItem.Text = "COMO VER LAS FUNCIONES DE UNA SALA";
            cOMOVERLASFUNCIONESDEUNASALAToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ayuda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(menuStrip1);
            Name = "ayuda";
            Size = new Size(721, 344);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem carteleraToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem cOMOVERLASFUNCIONESDEUNASALAToolStripMenuItem;
        private ToolStripMenuItem pREGUNTASFRECUENTESToolStripMenuItem;
    }
}
