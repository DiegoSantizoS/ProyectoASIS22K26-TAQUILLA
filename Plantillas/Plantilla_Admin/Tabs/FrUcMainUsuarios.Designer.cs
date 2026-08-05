namespace Plantilla_Admin
{
    partial class FrUcMainUsuarios
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
            PnlMain = new Panel();
            PnlTop = new Panel();
            CbCatalog = new Krypton.Toolkit.KryptonComboBox();
            BtnAsignarPermisos = new Button();
            BtnBitacora = new Button();
            BtnPerfiles = new Button();
            BtnUsuarios = new Button();
            PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CbCatalog).BeginInit();
            SuspendLayout();
            // 
            // PnlMain
            // 
            PnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PnlMain.Location = new Point(0, 30);
            PnlMain.Margin = new Padding(0);
            PnlMain.Name = "PnlMain";
            PnlMain.Size = new Size(1050, 670);
            PnlMain.TabIndex = 2;
            // 
            // PnlTop
            // 
            PnlTop.BackColor = Color.Black;
            PnlTop.BorderStyle = BorderStyle.FixedSingle;
            PnlTop.Controls.Add(CbCatalog);
            PnlTop.Controls.Add(BtnAsignarPermisos);
            PnlTop.Controls.Add(BtnBitacora);
            PnlTop.Controls.Add(BtnPerfiles);
            PnlTop.Controls.Add(BtnUsuarios);
            PnlTop.Dock = DockStyle.Top;
            PnlTop.Location = new Point(0, 0);
            PnlTop.Margin = new Padding(0);
            PnlTop.Name = "PnlTop";
            PnlTop.Size = new Size(1050, 35);
            PnlTop.TabIndex = 0;
            // 
            // CbCatalog
            // 
            CbCatalog.Dock = DockStyle.Right;
            CbCatalog.DropDownHeight = 250;
            CbCatalog.DropDownStyle = ComboBoxStyle.DropDownList;
            CbCatalog.IntegralHeight = false;
            CbCatalog.Items.AddRange(new object[] { "Acciones", "Aplicaciones", "Permisos" });
            CbCatalog.Location = new Point(887, 0);
            CbCatalog.Margin = new Padding(0);
            CbCatalog.Name = "CbCatalog";
            CbCatalog.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkModeAlternate;
            CbCatalog.Size = new Size(161, 33);
            CbCatalog.StateCommon.ComboBox.Back.Color1 = Color.Black;
            CbCatalog.StateCommon.ComboBox.Border.Width = 1;
            CbCatalog.StateCommon.ComboBox.Content.Color1 = Color.FromArgb(220, 210, 210);
            CbCatalog.StateCommon.ComboBox.Content.Font = new Font("Times New Roman", 13.8F);
            CbCatalog.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            CbCatalog.TabIndex = 2;
            // 
            // BtnAsignarPermisos
            // 
            BtnAsignarPermisos.BackColor = Color.Black;
            BtnAsignarPermisos.Cursor = Cursors.Hand;
            BtnAsignarPermisos.Dock = DockStyle.Left;
            BtnAsignarPermisos.FlatAppearance.BorderColor = Color.White;
            BtnAsignarPermisos.FlatStyle = FlatStyle.Flat;
            BtnAsignarPermisos.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAsignarPermisos.ForeColor = Color.FromArgb(220, 210, 210);
            BtnAsignarPermisos.Location = new Point(387, 0);
            BtnAsignarPermisos.Margin = new Padding(0, 2, 0, 0);
            BtnAsignarPermisos.Name = "BtnAsignarPermisos";
            BtnAsignarPermisos.Size = new Size(129, 33);
            BtnAsignarPermisos.TabIndex = 7;
            BtnAsignarPermisos.Text = "Permisos";
            BtnAsignarPermisos.UseVisualStyleBackColor = false;
            // 
            // BtnBitacora
            // 
            BtnBitacora.BackColor = Color.Black;
            BtnBitacora.Cursor = Cursors.Hand;
            BtnBitacora.Dock = DockStyle.Left;
            BtnBitacora.FlatAppearance.BorderColor = Color.White;
            BtnBitacora.FlatStyle = FlatStyle.Flat;
            BtnBitacora.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBitacora.ForeColor = Color.FromArgb(220, 210, 210);
            BtnBitacora.Location = new Point(258, 0);
            BtnBitacora.Margin = new Padding(0, 2, 0, 0);
            BtnBitacora.Name = "BtnBitacora";
            BtnBitacora.Size = new Size(129, 33);
            BtnBitacora.TabIndex = 6;
            BtnBitacora.Text = "Bitácora";
            BtnBitacora.UseVisualStyleBackColor = false;
            // 
            // BtnPerfiles
            // 
            BtnPerfiles.BackColor = Color.Black;
            BtnPerfiles.Cursor = Cursors.Hand;
            BtnPerfiles.Dock = DockStyle.Left;
            BtnPerfiles.FlatAppearance.BorderColor = Color.White;
            BtnPerfiles.FlatStyle = FlatStyle.Flat;
            BtnPerfiles.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnPerfiles.ForeColor = Color.FromArgb(220, 210, 210);
            BtnPerfiles.Location = new Point(129, 0);
            BtnPerfiles.Margin = new Padding(0, 2, 0, 0);
            BtnPerfiles.Name = "BtnPerfiles";
            BtnPerfiles.Size = new Size(129, 33);
            BtnPerfiles.TabIndex = 5;
            BtnPerfiles.Text = "Perfiles";
            BtnPerfiles.UseVisualStyleBackColor = false;
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.BackColor = Color.Black;
            BtnUsuarios.Cursor = Cursors.Hand;
            BtnUsuarios.Dock = DockStyle.Left;
            BtnUsuarios.FlatAppearance.BorderColor = Color.White;
            BtnUsuarios.FlatStyle = FlatStyle.Flat;
            BtnUsuarios.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUsuarios.ForeColor = Color.FromArgb(220, 210, 210);
            BtnUsuarios.Location = new Point(0, 0);
            BtnUsuarios.Margin = new Padding(0, 2, 0, 0);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Size = new Size(129, 33);
            BtnUsuarios.TabIndex = 4;
            BtnUsuarios.Text = "Usuarios";
            BtnUsuarios.UseVisualStyleBackColor = false;
            // 
            // FrUcMainUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(PnlTop);
            Controls.Add(PnlMain);
            Name = "FrUcMainUsuarios";
            Size = new Size(1050, 700);
            PnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CbCatalog).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel PnlMain;
        private Panel PnlTop;
        private Button BtnPerfiles;
        private Button BtnUsuarios;
        private Button BtnAsignarPermisos;
        private Button BtnBitacora;
        private Krypton.Toolkit.KryptonComboBox CbCatalog;
    }
}
