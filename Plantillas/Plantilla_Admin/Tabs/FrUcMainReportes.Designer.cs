using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Drawing;
using System.Windows.Forms;
using static ReaLTaiizor.Drawing.Poison.PoisonPaint;

namespace Plantilla_Admin
{
    partial class FrUcMainReportes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            PnlBarra = new Panel();
            TlpBarra = new TableLayoutPanel();
            LbReporte = new Componentes.CustomLabel();
            LbSemanaMes = new Componentes.CustomLabel();
            CbReporte = new Componentes.CustomComboBox();
            LbAnio = new Componentes.CustomLabel();
            NudAnio = new Krypton.Toolkit.KryptonNumericUpDown();
            NudMesSemana = new Krypton.Toolkit.KryptonNumericUpDown();
            BtnImprimir = new Componentes.CustomButton();
            BtnExportar = new Componentes.CustomButton();
            btnGenerar = new Componentes.CustomButton();
            PnlContenedor = new Panel();
            PnlHoja = new Panel();
            DgvReporte = new DataGridView();
            PnlTotales = new Panel();
            LbTotales = new Label();
            PnlEncabezado = new Panel();
            LbFecha = new Label();
            LbSubtitulo = new Label();
            LbTitulo = new Label();
            PnlBarra.SuspendLayout();
            TlpBarra.SuspendLayout();
            PnlContenedor.SuspendLayout();
            PnlHoja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvReporte).BeginInit();
            PnlTotales.SuspendLayout();
            PnlEncabezado.SuspendLayout();
            SuspendLayout();
            // 
            // PnlBarra
            // 
            PnlBarra.BackColor = Color.Black;
            PnlBarra.Controls.Add(TlpBarra);
            PnlBarra.Dock = DockStyle.Top;
            PnlBarra.Location = new Point(0, 0);
            PnlBarra.Name = "PnlBarra";
            PnlBarra.Padding = new Padding(16, 12, 16, 12);
            PnlBarra.Size = new Size(980, 92);
            PnlBarra.TabIndex = 1;
            // 
            // TlpBarra
            // 
            TlpBarra.ColumnCount = 6;
            TlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            TlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            TlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            TlpBarra.Controls.Add(LbReporte, 0, 0);
            TlpBarra.Controls.Add(LbSemanaMes, 2, 0);
            TlpBarra.Controls.Add(CbReporte, 0, 1);
            TlpBarra.Controls.Add(LbAnio, 1, 0);
            TlpBarra.Controls.Add(NudAnio, 1, 1);
            TlpBarra.Controls.Add(NudMesSemana, 2, 1);
            TlpBarra.Controls.Add(BtnImprimir, 4, 0);
            TlpBarra.Controls.Add(BtnExportar, 5, 0);
            TlpBarra.Controls.Add(btnGenerar, 3, 0);
            TlpBarra.Dock = DockStyle.Top;
            TlpBarra.Location = new Point(16, 12);
            TlpBarra.Margin = new Padding(0);
            TlpBarra.Name = "TlpBarra";
            TlpBarra.RowCount = 2;
            TlpBarra.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpBarra.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpBarra.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpBarra.Size = new Size(948, 74);
            TlpBarra.TabIndex = 20;
            // 
            // LbReporte
            // 
            LbReporte.AutoSize = true;
            LbReporte.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbReporte.ForeColor = Color.FromArgb(220, 220, 220);
            LbReporte.Location = new Point(3, 0);
            LbReporte.Name = "LbReporte";
            LbReporte.Padding = new Padding(0, 0, 2, 0);
            LbReporte.Size = new Size(76, 23);
            LbReporte.TabIndex = 17;
            LbReporte.Text = "Reporte";
            LbReporte.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbSemanaMes
            // 
            LbSemanaMes.AutoSize = true;
            LbSemanaMes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbSemanaMes.ForeColor = Color.FromArgb(220, 220, 220);
            LbSemanaMes.Location = new Point(416, 0);
            LbSemanaMes.Name = "LbSemanaMes";
            LbSemanaMes.Padding = new Padding(0, 0, 2, 0);
            LbSemanaMes.Size = new Size(92, 25);
            LbSemanaMes.TabIndex = 19;
            LbSemanaMes.Text = "Semana/Mes (0=Todos)";
            LbSemanaMes.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CbReporte
            // 
            CbReporte.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CbReporte.BackColor = Color.FromArgb(55, 60, 72);
            CbReporte.BaseColor = Color.FromArgb(40, 40, 40);
            CbReporte.BGColor = Color.FromArgb(55, 60, 72);
            CbReporte.DrawMode = DrawMode.OwnerDrawFixed;
            CbReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            CbReporte.FlatStyle = FlatStyle.Flat;
            CbReporte.Font = new Font("Segoe UI", 9.5F);
            CbReporte.ForeColor = Color.FromArgb(230, 230, 230);
            CbReporte.FormattingEnabled = true;
            CbReporte.HoverColor = Color.Crimson;
            CbReporte.HoverFontColor = Color.White;
            CbReporte.ItemHeight = 24;
            CbReporte.Location = new Point(5, 30);
            CbReporte.Margin = new Padding(5);
            CbReporte.MinimumSize = new Size(190, 0);
            CbReporte.Name = "CbReporte";
            CbReporte.Size = new Size(300, 30);
            CbReporte.TabIndex = 11;
            // 
            // LbAnio
            // 
            LbAnio.AutoSize = true;
            LbAnio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbAnio.ForeColor = Color.FromArgb(220, 220, 220);
            LbAnio.Location = new Point(313, 0);
            LbAnio.Name = "LbAnio";
            LbAnio.Padding = new Padding(0, 0, 2, 0);
            LbAnio.Size = new Size(44, 23);
            LbAnio.TabIndex = 18;
            LbAnio.Text = "Año";
            LbAnio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NudAnio
            // 
            NudAnio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NudAnio.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            NudAnio.Location = new Point(313, 28);
            NudAnio.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            NudAnio.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            NudAnio.Name = "NudAnio";
            NudAnio.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkModeAlternate;
            NudAnio.Size = new Size(97, 26);
            NudAnio.TabIndex = 12;
            NudAnio.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // NudMesSemana
            // 
            NudMesSemana.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NudMesSemana.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            NudMesSemana.Location = new Point(416, 28);
            NudMesSemana.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            NudMesSemana.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            NudMesSemana.Name = "NudMesSemana";
            NudMesSemana.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkModeAlternate;
            NudMesSemana.Size = new Size(97, 26);
            NudMesSemana.TabIndex = 13;
            NudMesSemana.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // BtnImprimir
            // 
            BtnImprimir.Action = Componentes.ButtonAction.Copiar;
            BtnImprimir.Anchor = AnchorStyles.None;
            BtnImprimir.BackColor = Color.FromArgb(26, 156, 156);
            BtnImprimir.FlatAppearance.BorderSize = 0;
            BtnImprimir.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 95, 95);
            BtnImprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 169, 169);
            BtnImprimir.FlatStyle = FlatStyle.Flat;
            BtnImprimir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnImprimir.ForeColor = Color.White;
            BtnImprimir.Location = new Point(631, 17);
            BtnImprimir.Margin = new Padding(0);
            BtnImprimir.MaximumSize = new Size(150, 40);
            BtnImprimir.MinimumSize = new Size(150, 40);
            BtnImprimir.Name = "BtnImprimir";
            TlpBarra.SetRowSpan(BtnImprimir, 2);
            BtnImprimir.Size = new Size(150, 40);
            BtnImprimir.TabIndex = 15;
            BtnImprimir.Text = "Imprimir PDF";
            BtnImprimir.UseVisualStyleBackColor = false;
            // 
            // BtnExportar
            // 
            BtnExportar.Action = Componentes.ButtonAction.Copiar;
            BtnExportar.Anchor = AnchorStyles.None;
            BtnExportar.BackColor = Color.FromArgb(26, 156, 156);
            BtnExportar.FlatAppearance.BorderSize = 0;
            BtnExportar.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 95, 95);
            BtnExportar.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 169, 169);
            BtnExportar.FlatStyle = FlatStyle.Flat;
            BtnExportar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnExportar.ForeColor = Color.White;
            BtnExportar.Location = new Point(792, 17);
            BtnExportar.Margin = new Padding(0);
            BtnExportar.MaximumSize = new Size(150, 40);
            BtnExportar.MinimumSize = new Size(150, 40);
            BtnExportar.Name = "BtnExportar";
            TlpBarra.SetRowSpan(BtnExportar, 2);
            BtnExportar.Size = new Size(150, 40);
            BtnExportar.TabIndex = 16;
            BtnExportar.Text = "Exportar CSV";
            BtnExportar.UseVisualStyleBackColor = false;
            // 
            // btnGenerar
            // 
            btnGenerar.Anchor = AnchorStyles.None;
            btnGenerar.BackColor = Color.FromArgb(41, 128, 185);
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 75, 109);
            btnGenerar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 134, 194);
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(521, 17);
            btnGenerar.Margin = new Padding(0);
            btnGenerar.MaximumSize = new Size(100, 40);
            btnGenerar.MinimumSize = new Size(100, 40);
            btnGenerar.Name = "btnGenerar";
            TlpBarra.SetRowSpan(btnGenerar, 2);
            btnGenerar.Size = new Size(100, 40);
            btnGenerar.TabIndex = 14;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            // 
            // PnlContenedor
            // 
            PnlContenedor.BackColor = Color.Gray;
            PnlContenedor.Controls.Add(PnlHoja);
            PnlContenedor.Dock = DockStyle.Fill;
            PnlContenedor.Location = new Point(0, 92);
            PnlContenedor.Name = "PnlContenedor";
            PnlContenedor.Padding = new Padding(20);
            PnlContenedor.Size = new Size(980, 568);
            PnlContenedor.TabIndex = 0;
            // 
            // PnlHoja
            // 
            PnlHoja.BackColor = Color.DarkGray;
            PnlHoja.BorderStyle = BorderStyle.FixedSingle;
            PnlHoja.Controls.Add(DgvReporte);
            PnlHoja.Controls.Add(PnlTotales);
            PnlHoja.Controls.Add(PnlEncabezado);
            PnlHoja.Dock = DockStyle.Fill;
            PnlHoja.Location = new Point(20, 20);
            PnlHoja.Name = "PnlHoja";
            PnlHoja.Padding = new Padding(28, 22, 28, 16);
            PnlHoja.Size = new Size(940, 528);
            PnlHoja.TabIndex = 0;
            // 
            // DgvReporte
            // 
            DgvReporte.AllowUserToAddRows = false;
            DgvReporte.AllowUserToDeleteRows = false;
            DgvReporte.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(246, 248, 250);
            DgvReporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvReporte.BackgroundColor = Color.DimGray;
            DgvReporte.BorderStyle = BorderStyle.None;
            DgvReporte.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(38, 50, 66);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvReporte.ColumnHeadersHeight = 34;
            DgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvReporte.Dock = DockStyle.Fill;
            DgvReporte.EnableHeadersVisualStyles = false;
            DgvReporte.GridColor = Color.FromArgb(224, 228, 232);
            DgvReporte.Location = new Point(28, 100);
            DgvReporte.Name = "DgvReporte";
            DgvReporte.ReadOnly = true;
            DgvReporte.RowHeadersVisible = false;
            DgvReporte.RowHeadersWidth = 51;
            DgvReporte.RowTemplate.Height = 28;
            DgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvReporte.Size = new Size(882, 374);
            DgvReporte.TabIndex = 0;
            // 
            // PnlTotales
            // 
            PnlTotales.BackColor = Color.DimGray;
            PnlTotales.Controls.Add(LbTotales);
            PnlTotales.Dock = DockStyle.Bottom;
            PnlTotales.Location = new Point(28, 474);
            PnlTotales.Name = "PnlTotales";
            PnlTotales.Size = new Size(882, 36);
            PnlTotales.TabIndex = 1;
            // 
            // LbTotales
            // 
            LbTotales.Dock = DockStyle.Fill;
            LbTotales.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbTotales.ForeColor = Color.FromArgb(30, 41, 55);
            LbTotales.Location = new Point(0, 0);
            LbTotales.Name = "LbTotales";
            LbTotales.Size = new Size(882, 36);
            LbTotales.TabIndex = 0;
            LbTotales.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PnlEncabezado
            // 
            PnlEncabezado.BackColor = Color.LightGray;
            PnlEncabezado.Controls.Add(LbFecha);
            PnlEncabezado.Controls.Add(LbSubtitulo);
            PnlEncabezado.Controls.Add(LbTitulo);
            PnlEncabezado.Dock = DockStyle.Top;
            PnlEncabezado.Location = new Point(28, 22);
            PnlEncabezado.Name = "PnlEncabezado";
            PnlEncabezado.Size = new Size(882, 78);
            PnlEncabezado.TabIndex = 2;
            // 
            // LbFecha
            // 
            LbFecha.Dock = DockStyle.Top;
            LbFecha.Font = new Font("Segoe UI", 8.5F);
            LbFecha.ForeColor = Color.FromArgb(140, 148, 158);
            LbFecha.Location = new Point(0, 56);
            LbFecha.Name = "LbFecha";
            LbFecha.Size = new Size(882, 20);
            LbFecha.TabIndex = 0;
            // 
            // LbSubtitulo
            // 
            LbSubtitulo.Dock = DockStyle.Top;
            LbSubtitulo.Font = new Font("Segoe UI", 10F);
            LbSubtitulo.ForeColor = Color.FromArgb(90, 100, 112);
            LbSubtitulo.Location = new Point(0, 34);
            LbSubtitulo.Name = "LbSubtitulo";
            LbSubtitulo.Size = new Size(882, 22);
            LbSubtitulo.TabIndex = 1;
            // 
            // LbTitulo
            // 
            LbTitulo.Dock = DockStyle.Top;
            LbTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            LbTitulo.ForeColor = Color.FromArgb(30, 41, 55);
            LbTitulo.Location = new Point(0, 0);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(882, 34);
            LbTitulo.TabIndex = 2;
            // 
            // FrUcMainReportes
            // 
            BackColor = Color.FromArgb(232, 235, 239);
            Controls.Add(PnlContenedor);
            Controls.Add(PnlBarra);
            Font = new Font("Segoe UI", 9F);
            Name = "FrUcMainReportes";
            Size = new Size(980, 660);
            PnlBarra.ResumeLayout(false);
            TlpBarra.ResumeLayout(false);
            TlpBarra.PerformLayout();
            PnlContenedor.ResumeLayout(false);
            PnlHoja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvReporte).EndInit();
            PnlTotales.ResumeLayout(false);
            PnlEncabezado.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel PnlBarra;
        private NumericUpDown numAnio;
        private NumericUpDown numMes;
        private NumericUpDown numMesSemana;
        private Label lblSemana;
        private NumericUpDown numSemana;
        private Button btnImprimir;
        private Componentes.CustomButton BtnExportar;
        private Componentes.CustomButton BtnImprimir;
        private Panel PnlContenedor;
        private Panel PnlHoja;
        private Panel PnlEncabezado;
        private Label LbTitulo;
        private Label LbSubtitulo;
        private Label LbFecha;
        private Panel PnlTotales;
        private Label LbTotales;
        private DataGridView DgvReporte;
        private Componentes.CustomComboBox customComboBox1;
        private Componentes.CustomButton customButton3;
        private Componentes.CustomButton customButton2;
        private Componentes.CustomButton customButton1;
        private Krypton.Toolkit.KryptonNumericUpDown kryptonNumericUpDown2;
        private Krypton.Toolkit.KryptonNumericUpDown NudAnio;
        private Krypton.Toolkit.KryptonNumericUpDown NudMesSemana;
        private Componentes.CustomLabel LbSemanaMes;
        private Componentes.CustomLabel LbAnio;
        private Componentes.CustomLabel LbReporte;
        private Componentes.CustomComboBox CbReporte;
        private Componentes.CustomButton btnGenerar;
        private TableLayoutPanel TlpBarra;
    }
}
