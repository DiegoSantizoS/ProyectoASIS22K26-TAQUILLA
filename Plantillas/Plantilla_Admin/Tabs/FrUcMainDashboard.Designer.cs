namespace Plantilla_Admin.Tabs
{
    partial class FrUcMainDashboard
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
            TlpArquitectura = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            LbMensajeDeUsuario = new Componentes.CustomTitleLabel();
            LbHora = new Componentes.CustomTitleLabel();
            LbBienvenida = new Componentes.CustomTitleLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            RcbDatosImportantes = new Componentes.CustomRichTextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            BtnNecesitasAyuda = new ReaLTaiizor.Controls.HopeButton();
            BtnAgregarFunciones = new ReaLTaiizor.Controls.HopeButton();
            BtnVerCartelera = new ReaLTaiizor.Controls.HopeButton();
            BtnVerReporte = new ReaLTaiizor.Controls.HopeButton();
            TlpCartelera = new TableLayoutPanel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            TlpArquitectura.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            TlpCartelera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TlpArquitectura
            // 
            TlpArquitectura.ColumnCount = 1;
            TlpArquitectura.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpArquitectura.Controls.Add(tableLayoutPanel2, 0, 0);
            TlpArquitectura.Controls.Add(tableLayoutPanel1, 0, 1);
            TlpArquitectura.Controls.Add(TlpCartelera, 0, 2);
            TlpArquitectura.Dock = DockStyle.Fill;
            TlpArquitectura.Location = new Point(0, 0);
            TlpArquitectura.Name = "TlpArquitectura";
            TlpArquitectura.RowCount = 3;
            TlpArquitectura.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            TlpArquitectura.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            TlpArquitectura.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpArquitectura.Size = new Size(1050, 700);
            TlpArquitectura.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(LbMensajeDeUsuario, 2, 0);
            tableLayoutPanel2.Controls.Add(LbHora, 1, 0);
            tableLayoutPanel2.Controls.Add(LbBienvenida, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1050, 70);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // LbMensajeDeUsuario
            // 
            LbMensajeDeUsuario.AutoSize = true;
            LbMensajeDeUsuario.Dock = DockStyle.Fill;
            LbMensajeDeUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LbMensajeDeUsuario.ForeColor = Color.Crimson;
            LbMensajeDeUsuario.Location = new Point(753, 0);
            LbMensajeDeUsuario.Name = "LbMensajeDeUsuario";
            LbMensajeDeUsuario.Size = new Size(194, 70);
            LbMensajeDeUsuario.TabIndex = 2;
            LbMensajeDeUsuario.Text = "05/08/2026";
            LbMensajeDeUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LbHora
            // 
            LbHora.AutoSize = true;
            LbHora.Dock = DockStyle.Fill;
            LbHora.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LbHora.ForeColor = Color.Crimson;
            LbHora.Location = new Point(603, 0);
            LbHora.Name = "LbHora";
            LbHora.Size = new Size(144, 70);
            LbHora.TabIndex = 1;
            LbHora.Text = "11:00";
            LbHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LbBienvenida
            // 
            LbBienvenida.AutoSize = true;
            LbBienvenida.Dock = DockStyle.Left;
            LbBienvenida.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LbBienvenida.ForeColor = Color.Crimson;
            LbBienvenida.Location = new Point(3, 0);
            LbBienvenida.Name = "LbBienvenida";
            LbBienvenida.Size = new Size(201, 70);
            LbBienvenida.TabIndex = 0;
            LbBienvenida.Text = "Buenos días, ";
            LbBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(RcbDatosImportantes, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 73);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1044, 294);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // RcbDatosImportantes
            // 
            RcbDatosImportantes.BackColor = Color.Black;
            RcbDatosImportantes.BorderStyle = BorderStyle.None;
            RcbDatosImportantes.Dock = DockStyle.Fill;
            RcbDatosImportantes.Font = new Font("Segoe UI", 10F);
            RcbDatosImportantes.ForeColor = Color.FromArgb(230, 230, 230);
            RcbDatosImportantes.Location = new Point(5, 10);
            RcbDatosImportantes.Margin = new Padding(5, 10, 5, 10);
            RcbDatosImportantes.MinimumSize = new Size(190, 60);
            RcbDatosImportantes.Name = "RcbDatosImportantes";
            RcbDatosImportantes.ReadOnly = true;
            RcbDatosImportantes.ScrollBars = RichTextBoxScrollBars.None;
            RcbDatosImportantes.Size = new Size(340, 274);
            RcbDatosImportantes.TabIndex = 1;
            RcbDatosImportantes.Text = "";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(BtnNecesitasAyuda, 3, 0);
            tableLayoutPanel4.Controls.Add(BtnAgregarFunciones, 2, 0);
            tableLayoutPanel4.Controls.Add(BtnVerCartelera, 0, 0);
            tableLayoutPanel4.Controls.Add(BtnVerReporte, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(353, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(594, 288);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // BtnNecesitasAyuda
            // 
            BtnNecesitasAyuda.BorderColor = Color.LawnGreen;
            BtnNecesitasAyuda.ButtonType = ReaLTaiizor.Util.HopeButtonType.Danger;
            BtnNecesitasAyuda.DangerColor = Color.FromArgb(245, 108, 108);
            BtnNecesitasAyuda.DefaultColor = Color.FromArgb(255, 255, 255);
            BtnNecesitasAyuda.Dock = DockStyle.Fill;
            BtnNecesitasAyuda.Font = new Font("Segoe UI", 12F);
            BtnNecesitasAyuda.HoverTextColor = Color.FromArgb(48, 49, 51);
            BtnNecesitasAyuda.InfoColor = Color.FromArgb(144, 147, 153);
            BtnNecesitasAyuda.Location = new Point(447, 3);
            BtnNecesitasAyuda.Name = "BtnNecesitasAyuda";
            BtnNecesitasAyuda.PrimaryColor = Color.FromArgb(64, 158, 255);
            BtnNecesitasAyuda.Size = new Size(144, 282);
            BtnNecesitasAyuda.SuccessColor = Color.FromArgb(103, 194, 58);
            BtnNecesitasAyuda.TabIndex = 5;
            BtnNecesitasAyuda.Text = "¿NECESITAS AYUDA?";
            BtnNecesitasAyuda.TextColor = Color.White;
            BtnNecesitasAyuda.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // BtnAgregarFunciones
            // 
            BtnAgregarFunciones.BorderColor = Color.LawnGreen;
            BtnAgregarFunciones.ButtonType = ReaLTaiizor.Util.HopeButtonType.Warning;
            BtnAgregarFunciones.DangerColor = Color.FromArgb(245, 108, 108);
            BtnAgregarFunciones.DefaultColor = Color.FromArgb(255, 255, 255);
            BtnAgregarFunciones.Dock = DockStyle.Fill;
            BtnAgregarFunciones.Font = new Font("Segoe UI", 12F);
            BtnAgregarFunciones.HoverTextColor = Color.FromArgb(48, 49, 51);
            BtnAgregarFunciones.InfoColor = Color.FromArgb(144, 147, 153);
            BtnAgregarFunciones.Location = new Point(299, 3);
            BtnAgregarFunciones.Name = "BtnAgregarFunciones";
            BtnAgregarFunciones.PrimaryColor = Color.FromArgb(64, 158, 255);
            BtnAgregarFunciones.Size = new Size(142, 282);
            BtnAgregarFunciones.SuccessColor = Color.FromArgb(103, 194, 58);
            BtnAgregarFunciones.TabIndex = 6;
            BtnAgregarFunciones.Text = "AGREGAR FUNCIONES";
            BtnAgregarFunciones.TextColor = Color.White;
            BtnAgregarFunciones.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // BtnVerCartelera
            // 
            BtnVerCartelera.BorderColor = Color.LawnGreen;
            BtnVerCartelera.ButtonType = ReaLTaiizor.Util.HopeButtonType.Warning;
            BtnVerCartelera.DangerColor = Color.FromArgb(245, 108, 108);
            BtnVerCartelera.DefaultColor = Color.FromArgb(255, 255, 255);
            BtnVerCartelera.Dock = DockStyle.Fill;
            BtnVerCartelera.Font = new Font("Segoe UI", 12F);
            BtnVerCartelera.HoverTextColor = Color.FromArgb(48, 49, 51);
            BtnVerCartelera.InfoColor = Color.FromArgb(144, 147, 153);
            BtnVerCartelera.Location = new Point(3, 3);
            BtnVerCartelera.Name = "BtnVerCartelera";
            BtnVerCartelera.PrimaryColor = Color.FromArgb(64, 158, 255);
            BtnVerCartelera.Size = new Size(142, 282);
            BtnVerCartelera.SuccessColor = Color.FromArgb(103, 194, 58);
            BtnVerCartelera.TabIndex = 3;
            BtnVerCartelera.Text = "VER CARTELERA";
            BtnVerCartelera.TextColor = Color.White;
            BtnVerCartelera.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // BtnVerReporte
            // 
            BtnVerReporte.BorderColor = Color.LawnGreen;
            BtnVerReporte.ButtonType = ReaLTaiizor.Util.HopeButtonType.Warning;
            BtnVerReporte.DangerColor = Color.FromArgb(245, 108, 108);
            BtnVerReporte.DefaultColor = Color.FromArgb(255, 255, 255);
            BtnVerReporte.Dock = DockStyle.Fill;
            BtnVerReporte.Font = new Font("Segoe UI", 12F);
            BtnVerReporte.HoverTextColor = Color.FromArgb(48, 49, 51);
            BtnVerReporte.InfoColor = Color.FromArgb(144, 147, 153);
            BtnVerReporte.Location = new Point(151, 3);
            BtnVerReporte.Name = "BtnVerReporte";
            BtnVerReporte.PrimaryColor = Color.FromArgb(64, 158, 255);
            BtnVerReporte.Size = new Size(142, 282);
            BtnVerReporte.SuccessColor = Color.FromArgb(103, 194, 58);
            BtnVerReporte.TabIndex = 4;
            BtnVerReporte.Text = "VER REPORTES";
            BtnVerReporte.TextColor = Color.White;
            BtnVerReporte.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // TlpCartelera
            // 
            TlpCartelera.ColumnCount = 4;
            TlpCartelera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TlpCartelera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TlpCartelera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TlpCartelera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TlpCartelera.Controls.Add(pictureBox4, 3, 0);
            TlpCartelera.Controls.Add(pictureBox3, 2, 0);
            TlpCartelera.Controls.Add(pictureBox2, 1, 0);
            TlpCartelera.Controls.Add(pictureBox1, 0, 0);
            TlpCartelera.Dock = DockStyle.Fill;
            TlpCartelera.Location = new Point(0, 370);
            TlpCartelera.Margin = new Padding(0);
            TlpCartelera.Name = "TlpCartelera";
            TlpCartelera.RowCount = 1;
            TlpCartelera.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpCartelera.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpCartelera.Size = new Size(1050, 330);
            TlpCartelera.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Location = new Point(789, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(258, 324);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Location = new Point(527, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(256, 324);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(265, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 324);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 324);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrUcMainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(TlpArquitectura);
            Name = "FrUcMainDashboard";
            Size = new Size(1050, 700);
            TlpArquitectura.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            TlpCartelera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpArquitectura;
        private TableLayoutPanel tableLayoutPanel2;
        private Componentes.CustomTitleLabel LbBienvenida;
        private Componentes.CustomTitleLabel LbHora;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.HopeButton BtnNecesitasAyuda;
        private ReaLTaiizor.Controls.HopeButton BtnVerReporte;
        private ReaLTaiizor.Controls.HopeButton BtnVerCartelera;
        private ReaLTaiizor.Controls.HopeButton BtnAgregarFunciones;
        private Componentes.CustomRichTextBox RcbDatosImportantes;
        private TableLayoutPanel TlpCartelera;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel4;
        private Componentes.CustomTitleLabel LbMensajeDeUsuario;
    }
}
