namespace Plantilla_Admin
{
    partial class logo
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
            tableLayoutPanel_landing = new TableLayoutPanel();
            tableLayoutPanel_Reportes = new TableLayoutPanel();
            tableLayoutPanel_Sedes = new TableLayoutPanel();
            tableLayoutPanel_Cartelera = new TableLayoutPanel();
            tableLayoutPanel_Ayuda = new TableLayoutPanel();
            Txt_Ayuda = new Label();
            Txt_Cartelera = new Label();
            Txt_Sedes = new Label();
            Txt_Reportes = new Label();
            tableLayoutPanel_landing.SuspendLayout();
            tableLayoutPanel_Reportes.SuspendLayout();
            tableLayoutPanel_Sedes.SuspendLayout();
            tableLayoutPanel_Cartelera.SuspendLayout();
            tableLayoutPanel_Ayuda.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel_landing
            // 
            tableLayoutPanel_landing.ColumnCount = 2;
            tableLayoutPanel_landing.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_landing.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_landing.Controls.Add(tableLayoutPanel_Reportes, 1, 1);
            tableLayoutPanel_landing.Controls.Add(tableLayoutPanel_Sedes, 0, 1);
            tableLayoutPanel_landing.Controls.Add(tableLayoutPanel_Cartelera, 1, 0);
            tableLayoutPanel_landing.Controls.Add(tableLayoutPanel_Ayuda, 0, 0);
            tableLayoutPanel_landing.Dock = DockStyle.Fill;
            tableLayoutPanel_landing.Location = new Point(0, 0);
            tableLayoutPanel_landing.Name = "tableLayoutPanel_landing";
            tableLayoutPanel_landing.RowCount = 2;
            tableLayoutPanel_landing.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_landing.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_landing.Size = new Size(837, 403);
            tableLayoutPanel_landing.TabIndex = 0;
            // 
            // tableLayoutPanel_Reportes
            // 
            tableLayoutPanel_Reportes.BackColor = Color.FromArgb(128, 255, 128);
            tableLayoutPanel_Reportes.ColumnCount = 1;
            tableLayoutPanel_Reportes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Reportes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Reportes.Controls.Add(Txt_Reportes, 0, 0);
            tableLayoutPanel_Reportes.Dock = DockStyle.Fill;
            tableLayoutPanel_Reportes.Location = new Point(418, 201);
            tableLayoutPanel_Reportes.Margin = new Padding(0);
            tableLayoutPanel_Reportes.Name = "tableLayoutPanel_Reportes";
            tableLayoutPanel_Reportes.RowCount = 2;
            tableLayoutPanel_Reportes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Reportes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Reportes.Size = new Size(419, 202);
            tableLayoutPanel_Reportes.TabIndex = 0;
            // 
            // tableLayoutPanel_Sedes
            // 
            tableLayoutPanel_Sedes.BackColor = Color.FromArgb(255, 128, 128);
            tableLayoutPanel_Sedes.ColumnCount = 1;
            tableLayoutPanel_Sedes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Sedes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Sedes.Controls.Add(Txt_Sedes, 0, 0);
            tableLayoutPanel_Sedes.Dock = DockStyle.Fill;
            tableLayoutPanel_Sedes.Location = new Point(0, 201);
            tableLayoutPanel_Sedes.Margin = new Padding(0);
            tableLayoutPanel_Sedes.Name = "tableLayoutPanel_Sedes";
            tableLayoutPanel_Sedes.RowCount = 2;
            tableLayoutPanel_Sedes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Sedes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Sedes.Size = new Size(418, 202);
            tableLayoutPanel_Sedes.TabIndex = 0;
            // 
            // tableLayoutPanel_Cartelera
            // 
            tableLayoutPanel_Cartelera.BackColor = Color.FromArgb(255, 255, 128);
            tableLayoutPanel_Cartelera.ColumnCount = 1;
            tableLayoutPanel_Cartelera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Cartelera.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Cartelera.Controls.Add(Txt_Cartelera, 0, 0);
            tableLayoutPanel_Cartelera.Dock = DockStyle.Fill;
            tableLayoutPanel_Cartelera.Location = new Point(418, 0);
            tableLayoutPanel_Cartelera.Margin = new Padding(0);
            tableLayoutPanel_Cartelera.Name = "tableLayoutPanel_Cartelera";
            tableLayoutPanel_Cartelera.RowCount = 2;
            tableLayoutPanel_Cartelera.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Cartelera.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Cartelera.Size = new Size(419, 201);
            tableLayoutPanel_Cartelera.TabIndex = 0;
            // 
            // tableLayoutPanel_Ayuda
            // 
            tableLayoutPanel_Ayuda.BackColor = Color.FromArgb(255, 192, 128);
            tableLayoutPanel_Ayuda.ColumnCount = 1;
            tableLayoutPanel_Ayuda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Ayuda.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Ayuda.Controls.Add(Txt_Ayuda, 0, 0);
            tableLayoutPanel_Ayuda.Dock = DockStyle.Fill;
            tableLayoutPanel_Ayuda.Location = new Point(0, 0);
            tableLayoutPanel_Ayuda.Margin = new Padding(0);
            tableLayoutPanel_Ayuda.Name = "tableLayoutPanel_Ayuda";
            tableLayoutPanel_Ayuda.RowCount = 2;
            tableLayoutPanel_Ayuda.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Ayuda.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Ayuda.Size = new Size(418, 201);
            tableLayoutPanel_Ayuda.TabIndex = 0;
            tableLayoutPanel_Ayuda.Paint += tableLayoutPanel_Ayuda_Paint;
            // 
            // Txt_Ayuda
            // 
            Txt_Ayuda.AutoSize = true;
            Txt_Ayuda.Dock = DockStyle.Bottom;
            Txt_Ayuda.Location = new Point(3, 80);
            Txt_Ayuda.Name = "Txt_Ayuda";
            Txt_Ayuda.Size = new Size(412, 20);
            Txt_Ayuda.TabIndex = 0;
            Txt_Ayuda.Text = "REVISA LA GUÍA DE AYUDA";
            Txt_Ayuda.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Txt_Cartelera
            // 
            Txt_Cartelera.AutoSize = true;
            Txt_Cartelera.Dock = DockStyle.Bottom;
            Txt_Cartelera.Location = new Point(3, 80);
            Txt_Cartelera.Name = "Txt_Cartelera";
            Txt_Cartelera.Size = new Size(413, 20);
            Txt_Cartelera.TabIndex = 0;
            Txt_Cartelera.Text = "CARTELERA ACTUAL";
            Txt_Cartelera.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Txt_Sedes
            // 
            Txt_Sedes.AutoSize = true;
            Txt_Sedes.Dock = DockStyle.Bottom;
            Txt_Sedes.Location = new Point(3, 81);
            Txt_Sedes.Name = "Txt_Sedes";
            Txt_Sedes.Size = new Size(412, 20);
            Txt_Sedes.TabIndex = 0;
            Txt_Sedes.Text = "VERIFICACIÓN DE SEDES";
            Txt_Sedes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Txt_Reportes
            // 
            Txt_Reportes.AutoSize = true;
            Txt_Reportes.Dock = DockStyle.Bottom;
            Txt_Reportes.Location = new Point(3, 81);
            Txt_Reportes.Name = "Txt_Reportes";
            Txt_Reportes.Size = new Size(413, 20);
            Txt_Reportes.TabIndex = 0;
            Txt_Reportes.Text = "REPORTES MENSUALES";
            Txt_Reportes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(tableLayoutPanel_landing);
            Name = "logo";
            Size = new Size(837, 403);
            tableLayoutPanel_landing.ResumeLayout(false);
            tableLayoutPanel_Reportes.ResumeLayout(false);
            tableLayoutPanel_Reportes.PerformLayout();
            tableLayoutPanel_Sedes.ResumeLayout(false);
            tableLayoutPanel_Sedes.PerformLayout();
            tableLayoutPanel_Cartelera.ResumeLayout(false);
            tableLayoutPanel_Cartelera.PerformLayout();
            tableLayoutPanel_Ayuda.ResumeLayout(false);
            tableLayoutPanel_Ayuda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel_landing;
        private TableLayoutPanel tableLayoutPanel_Cartelera;
        private TableLayoutPanel tableLayoutPanel_Ayuda;
        private TableLayoutPanel tableLayoutPanel_Reportes;
        private TableLayoutPanel tableLayoutPanel_Sedes;
        private Label Txt_Reportes;
        private Label Txt_Sedes;
        private Label Txt_Cartelera;
        private Label Txt_Ayuda;
    }
}
