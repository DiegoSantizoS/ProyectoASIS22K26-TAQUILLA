namespace Plantilla_Cliente
{
    partial class FrMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Pnl_MenuLayout = new TableLayoutPanel();
            MSOpciones = new MenuStrip();
            carteleraToolStripMenuItem = new ToolStripMenuItem();
            reservasToolStripMenuItem = new ToolStripMenuItem();
            Pnl_Menu = new Panel();
            Pnl_MenuLayout.SuspendLayout();
            MSOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_MenuLayout
            // 
            Pnl_MenuLayout.BackColor = SystemColors.ControlDark;
            Pnl_MenuLayout.ColumnCount = 1;
            Pnl_MenuLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Pnl_MenuLayout.Controls.Add(MSOpciones, 0, 0);
            Pnl_MenuLayout.Controls.Add(Pnl_Menu, 0, 1);
            Pnl_MenuLayout.Dock = DockStyle.Fill;
            Pnl_MenuLayout.Location = new Point(0, 0);
            Pnl_MenuLayout.Name = "Pnl_MenuLayout";
            Pnl_MenuLayout.RowCount = 2;
            Pnl_MenuLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 4.285714F));
            Pnl_MenuLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 95.71429F));
            Pnl_MenuLayout.Size = new Size(1240, 770);
            Pnl_MenuLayout.TabIndex = 0;
            Pnl_MenuLayout.Paint += tableLayoutPanel1_Paint;
            // 
            // MSOpciones
            // 
            MSOpciones.ImageScalingSize = new Size(20, 20);
            MSOpciones.Items.AddRange(new ToolStripItem[] { carteleraToolStripMenuItem, reservasToolStripMenuItem });
            MSOpciones.Location = new Point(0, 0);
            MSOpciones.Name = "MSOpciones";
            MSOpciones.Size = new Size(1240, 28);
            MSOpciones.TabIndex = 1;
            MSOpciones.Text = "menuStrip1";
            // 
            // carteleraToolStripMenuItem
            // 
            carteleraToolStripMenuItem.Name = "carteleraToolStripMenuItem";
            carteleraToolStripMenuItem.Size = new Size(83, 24);
            carteleraToolStripMenuItem.Text = "Cartelera";
            carteleraToolStripMenuItem.Click += carteleraToolStripMenuItem_Click_1;
            // 
            // reservasToolStripMenuItem
            // 
            reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            reservasToolStripMenuItem.Size = new Size(80, 24);
            reservasToolStripMenuItem.Text = "Reservas";
            // 
            // Pnl_Menu
            // 
            Pnl_Menu.BackColor = SystemColors.ActiveCaption;
            Pnl_Menu.Dock = DockStyle.Fill;
            Pnl_Menu.Location = new Point(3, 36);
            Pnl_Menu.Name = "Pnl_Menu";
            Pnl_Menu.Size = new Size(1234, 731);
            Pnl_Menu.TabIndex = 2;
            // 
            // FrMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 770);
            Controls.Add(Pnl_MenuLayout);
            Name = "FrMenu";
            Text = "Menú principal";
            Pnl_MenuLayout.ResumeLayout(false);
            Pnl_MenuLayout.PerformLayout();
            MSOpciones.ResumeLayout(false);
            MSOpciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Pnl_MenuLayout;
        private MenuStrip MSOpciones;
        private ToolStripMenuItem carteleraToolStripMenuItem;
        private ToolStripMenuItem reservasToolStripMenuItem;
        private Panel Pnl_Menu;
    }
}
