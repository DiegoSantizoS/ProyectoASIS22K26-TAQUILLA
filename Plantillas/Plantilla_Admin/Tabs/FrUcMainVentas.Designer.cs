namespace Plantilla_Admin.Tabs
{
    partial class FrUcMainVentas
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
            PnlTop = new Panel();
            CbCatalog = new Krypton.Toolkit.KryptonComboBox();
            BtnClientes = new Button();
            BtnBoletos = new Button();
            BtnVentas = new Button();
            PnlMain = new Panel();
            PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CbCatalog).BeginInit();
            SuspendLayout();
            // 
            // PnlTop
            // 
            PnlTop.BackColor = Color.Black;
            PnlTop.BorderStyle = BorderStyle.FixedSingle;
            PnlTop.Controls.Add(CbCatalog);
            PnlTop.Controls.Add(BtnClientes);
            PnlTop.Controls.Add(BtnBoletos);
            PnlTop.Controls.Add(BtnVentas);
            PnlTop.Dock = DockStyle.Top;
            PnlTop.Location = new Point(0, 0);
            PnlTop.Margin = new Padding(0);
            PnlTop.Name = "PnlTop";
            PnlTop.Size = new Size(1050, 35);
            PnlTop.TabIndex = 2;
            // 
            // CbCatalog
            // 
            CbCatalog.Dock = DockStyle.Right;
            CbCatalog.DropDownHeight = 250;
            CbCatalog.DropDownStyle = ComboBoxStyle.DropDownList;
            CbCatalog.IntegralHeight = false;
            CbCatalog.Items.AddRange(new object[] { "Estados De Boleto", "Métodos De Pago" });
            CbCatalog.Location = new Point(798, 0);
            CbCatalog.Margin = new Padding(0);
            CbCatalog.Name = "CbCatalog";
            CbCatalog.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkModeAlternate;
            CbCatalog.Size = new Size(250, 33);
            CbCatalog.StateCommon.ComboBox.Back.Color1 = Color.Black;
            CbCatalog.StateCommon.ComboBox.Border.Width = 1;
            CbCatalog.StateCommon.ComboBox.Content.Color1 = Color.FromArgb(220, 210, 210);
            CbCatalog.StateCommon.ComboBox.Content.Font = new Font("Times New Roman", 13.8F);
            CbCatalog.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            CbCatalog.TabIndex = 2;
            // 
            // BtnClientes
            // 
            BtnClientes.BackColor = Color.Black;
            BtnClientes.Cursor = Cursors.Hand;
            BtnClientes.Dock = DockStyle.Left;
            BtnClientes.FlatAppearance.BorderColor = Color.White;
            BtnClientes.FlatStyle = FlatStyle.Flat;
            BtnClientes.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnClientes.ForeColor = Color.FromArgb(220, 210, 210);
            BtnClientes.Location = new Point(258, 0);
            BtnClientes.Margin = new Padding(0, 2, 0, 0);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(129, 33);
            BtnClientes.TabIndex = 6;
            BtnClientes.Text = "Clientes";
            BtnClientes.UseVisualStyleBackColor = false;
            // 
            // BtnBoletos
            // 
            BtnBoletos.BackColor = Color.Black;
            BtnBoletos.Cursor = Cursors.Hand;
            BtnBoletos.Dock = DockStyle.Left;
            BtnBoletos.FlatAppearance.BorderColor = Color.White;
            BtnBoletos.FlatStyle = FlatStyle.Flat;
            BtnBoletos.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBoletos.ForeColor = Color.FromArgb(220, 210, 210);
            BtnBoletos.Location = new Point(129, 0);
            BtnBoletos.Margin = new Padding(0, 2, 0, 0);
            BtnBoletos.Name = "BtnBoletos";
            BtnBoletos.Size = new Size(129, 33);
            BtnBoletos.TabIndex = 5;
            BtnBoletos.Text = "Boletos";
            BtnBoletos.UseVisualStyleBackColor = false;
            // 
            // BtnVentas
            // 
            BtnVentas.BackColor = Color.Black;
            BtnVentas.Cursor = Cursors.Hand;
            BtnVentas.Dock = DockStyle.Left;
            BtnVentas.FlatAppearance.BorderColor = Color.White;
            BtnVentas.FlatStyle = FlatStyle.Flat;
            BtnVentas.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnVentas.ForeColor = Color.FromArgb(220, 210, 210);
            BtnVentas.Location = new Point(0, 0);
            BtnVentas.Margin = new Padding(0, 2, 0, 0);
            BtnVentas.Name = "BtnVentas";
            BtnVentas.Size = new Size(129, 33);
            BtnVentas.TabIndex = 4;
            BtnVentas.Text = "Ventas";
            BtnVentas.UseVisualStyleBackColor = false;
            // 
            // PnlMain
            // 
            PnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PnlMain.Location = new Point(0, 35);
            PnlMain.Margin = new Padding(0);
            PnlMain.Name = "PnlMain";
            PnlMain.Size = new Size(1050, 665);
            PnlMain.TabIndex = 4;
            // 
            // FrUcMainVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(PnlMain);
            Controls.Add(PnlTop);
            Name = "FrUcMainVentas";
            Size = new Size(1050, 700);
            PnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CbCatalog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlTop;
        private Krypton.Toolkit.KryptonComboBox CbCatalog;
        private Button BtnClientes;
        private Button BtnBoletos;
        private Button BtnVentas;
        private Panel PnlMain;
    }
}
