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
            Ms_Opciones = new MenuStrip();
            Tsmi_Cartelera = new ToolStripMenuItem();
            Tsmi_Reservas = new ToolStripMenuItem();
            Pnl_Menu = new Panel();
            Pnl_MenuLayout.SuspendLayout();
            Ms_Opciones.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_MenuLayout
            // 
            Pnl_MenuLayout.BackColor = SystemColors.ControlDark;
            Pnl_MenuLayout.ColumnCount = 1;
            Pnl_MenuLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Pnl_MenuLayout.Controls.Add(Ms_Opciones, 0, 0);
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
            // Ms_Opciones
            // 
            Ms_Opciones.ImageScalingSize = new Size(20, 20);
            Ms_Opciones.Items.AddRange(new ToolStripItem[] { Tsmi_Cartelera, Tsmi_Reservas });
            Ms_Opciones.Location = new Point(0, 0);
            Ms_Opciones.Name = "Ms_Opciones";
            Ms_Opciones.Size = new Size(1240, 28);
            Ms_Opciones.TabIndex = 1;
            Ms_Opciones.Text = "menuStrip1";
            // 
            // Tsmi_Cartelera
            // 
            Tsmi_Cartelera.Name = "Tsmi_Cartelera";
            Tsmi_Cartelera.Size = new Size(83, 24);
            Tsmi_Cartelera.Text = "Cartelera";
            Tsmi_Cartelera.Click += carteleraToolStripMenuItem_Click_1;
            // 
            // Tsmi_Reservas
            // 
            Tsmi_Reservas.Name = "Tsmi_Reservas";
            Tsmi_Reservas.Size = new Size(80, 24);
            Tsmi_Reservas.Text = "Reservas";
            Tsmi_Reservas.Click += reservasToolStripMenuItem_Click;
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
            MinimumSize = new Size(1200, 700);
            Name = "FrMenu";
            Text = "Menú principal";
            Pnl_MenuLayout.ResumeLayout(false);
            Pnl_MenuLayout.PerformLayout();
            Ms_Opciones.ResumeLayout(false);
            Ms_Opciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Pnl_MenuLayout;
        private MenuStrip Ms_Opciones;
        private ToolStripMenuItem Tsmi_Cartelera;
        private ToolStripMenuItem Tsmi_Reservas;
        private Panel Pnl_Menu;
    }
}
