namespace Plantilla_Admin.FormulariosPrincipales
{
    partial class FrMenuAdminProvisional
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
            formMenuStrip1 = new ReaLTaiizor.Controls.FormMenuStrip();
            logo = new ToolStripMenuItem();
            funciones = new ToolStripMenuItem();
            vENTASToolStripMenuItem = new ToolStripMenuItem();
            uSUARIOSToolStripMenuItem = new ToolStripMenuItem();
            rEPORTESToolStripMenuItem = new ToolStripMenuItem();
            materialToolStripMenuItem1 = new ReaLTaiizor.Controls.MaterialToolStripMenuItem();
            kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            panel1 = new Panel();
            formMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // formMenuStrip1
            // 
            formMenuStrip1.BackColor = Color.FromArgb(23, 23, 23);
            formMenuStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formMenuStrip1.ImageScalingSize = new Size(20, 20);
            formMenuStrip1.Items.AddRange(new ToolStripItem[] { logo, funciones, vENTASToolStripMenuItem, uSUARIOSToolStripMenuItem, rEPORTESToolStripMenuItem });
            formMenuStrip1.Location = new Point(0, 0);
            formMenuStrip1.Name = "formMenuStrip1";
            formMenuStrip1.Size = new Size(800, 33);
            formMenuStrip1.TabIndex = 0;
            formMenuStrip1.Text = "formMenuStrip1";
            // 
            // logo
            // 
            logo.ForeColor = Color.FromArgb(210, 210, 210);
            logo.Name = "logo";
            logo.Size = new Size(73, 29);
            logo.Text = "LOGO";
            // 
            // funciones
            // 
            funciones.ForeColor = Color.FromArgb(210, 210, 210);
            funciones.Name = "funciones";
            funciones.Size = new Size(122, 29);
            funciones.Text = "FUNCIONES";
            // 
            // vENTASToolStripMenuItem
            // 
            vENTASToolStripMenuItem.ForeColor = Color.FromArgb(210, 210, 210);
            vENTASToolStripMenuItem.Name = "vENTASToolStripMenuItem";
            vENTASToolStripMenuItem.Size = new Size(89, 29);
            vENTASToolStripMenuItem.Text = "VENTAS";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            uSUARIOSToolStripMenuItem.ForeColor = Color.FromArgb(210, 210, 210);
            uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            uSUARIOSToolStripMenuItem.Size = new Size(112, 29);
            uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            // 
            // rEPORTESToolStripMenuItem
            // 
            rEPORTESToolStripMenuItem.ForeColor = Color.FromArgb(210, 210, 210);
            rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            rEPORTESToolStripMenuItem.Size = new Size(108, 29);
            rEPORTESToolStripMenuItem.Text = "REPORTES";
            // 
            // materialToolStripMenuItem1
            // 
            materialToolStripMenuItem1.AutoSize = false;
            materialToolStripMenuItem1.Name = "materialToolStripMenuItem1";
            materialToolStripMenuItem1.Size = new Size(32, 19);
            materialToolStripMenuItem1.Text = "materialToolStripMenuItem1";
            // 
            // kryptonContextMenu1
            // 
            kryptonContextMenu1.PaletteMode = Krypton.Toolkit.PaletteMode.VisualStudio2010Render365;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 33);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 417);
            panel1.TabIndex = 1;
            // 
            // FrMenuAdminProvisional
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(formMenuStrip1);
            MainMenuStrip = formMenuStrip1;
            Name = "FrMenuAdminProvisional";
            Text = "FrMenuAdminProvisional";
            formMenuStrip1.ResumeLayout(false);
            formMenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.FormMenuStrip formMenuStrip1;
        private ReaLTaiizor.Controls.MaterialToolStripMenuItem materialToolStripMenuItem1;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Panel panel1;
        private ToolStripMenuItem logo;
        private ToolStripMenuItem funciones;
        private ToolStripMenuItem vENTASToolStripMenuItem;
        private ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private ToolStripMenuItem rEPORTESToolStripMenuItem;
    }
}