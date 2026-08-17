namespace Plantilla_Admin.FormulariosPrincipales
{
    partial class FrConexion
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
            TlpAux = new TableLayoutPanel();
            PnlControlBox = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            LbServer = new Componentes.CustomLabel();
            LbUser = new Componentes.CustomLabel();
            LbPassword = new Componentes.CustomLabel();
            TbServer = new Componentes.CustomTextBox();
            TbUser = new Componentes.CustomTextBox();
            TbPassword = new Componentes.CustomTextBox();
            BtnGuardar = new Componentes.CustomButton();
            TlpAux.SuspendLayout();
            PnlControlBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            // 
            // TlpAux
            // 
            TlpAux.ColumnCount = 1;
            TlpAux.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpAux.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TlpAux.Controls.Add(PnlControlBox, 0, 0);
            TlpAux.Controls.Add(tableLayoutPanel1, 0, 1);
            TlpAux.Dock = DockStyle.Fill;
            TlpAux.Location = new Point(0, 0);
            TlpAux.Name = "TlpAux";
            TlpAux.RowCount = 2;
            TlpAux.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            TlpAux.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpAux.Size = new Size(400, 350);
            TlpAux.TabIndex = 0;
            // 
            // PnlControlBox
            // 
            PnlControlBox.BackColor = Color.FromArgb(74, 21, 26);
            PnlControlBox.Controls.Add(nightControlBox1);
            PnlControlBox.Dock = DockStyle.Fill;
            PnlControlBox.Location = new Point(0, 0);
            PnlControlBox.Margin = new Padding(0);
            PnlControlBox.Name = "PnlControlBox";
            PnlControlBox.Size = new Size(400, 31);
            PnlControlBox.TabIndex = 7;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.Cursor = Cursors.Hand;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(261, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(LbServer, 0, 0);
            tableLayoutPanel1.Controls.Add(LbUser, 0, 2);
            tableLayoutPanel1.Controls.Add(LbPassword, 0, 4);
            tableLayoutPanel1.Controls.Add(TbServer, 0, 1);
            tableLayoutPanel1.Controls.Add(TbUser, 0, 3);
            tableLayoutPanel1.Controls.Add(TbPassword, 0, 5);
            tableLayoutPanel1.Controls.Add(BtnGuardar, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(25, 56);
            tableLayoutPanel1.Margin = new Padding(25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(350, 269);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // LbServer
            // 
            LbServer.AutoSize = true;
            LbServer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbServer.ForeColor = Color.FromArgb(220, 220, 220);
            LbServer.Location = new Point(3, 0);
            LbServer.Name = "LbServer";
            LbServer.Padding = new Padding(0, 0, 2, 0);
            LbServer.Size = new Size(81, 23);
            LbServer.TabIndex = 0;
            LbServer.Text = "Servidor";
            LbServer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbUser
            // 
            LbUser.AutoSize = true;
            LbUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbUser.ForeColor = Color.FromArgb(220, 220, 220);
            LbUser.Location = new Point(3, 75);
            LbUser.Name = "LbUser";
            LbUser.Padding = new Padding(0, 0, 2, 0);
            LbUser.Size = new Size(72, 23);
            LbUser.TabIndex = 1;
            LbUser.Text = "Usuario";
            LbUser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbPassword
            // 
            LbPassword.AutoSize = true;
            LbPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbPassword.ForeColor = Color.FromArgb(220, 220, 220);
            LbPassword.Location = new Point(3, 150);
            LbPassword.Name = "LbPassword";
            LbPassword.Padding = new Padding(0, 0, 2, 0);
            LbPassword.Size = new Size(101, 23);
            LbPassword.TabIndex = 2;
            LbPassword.Text = "Contraseña";
            LbPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbServer
            // 
            TbServer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbServer.BackColor = Color.FromArgb(55, 60, 72);
            TbServer.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(TbServer, 2);
            TbServer.Font = new Font("Segoe UI", 10F);
            TbServer.ForeColor = Color.FromArgb(160, 165, 175);
            TbServer.Location = new Point(5, 30);
            TbServer.Margin = new Padding(5, 0, 5, 10);
            TbServer.MaximumSize = new Size(0, 30);
            TbServer.MinimumSize = new Size(190, 30);
            TbServer.Name = "TbServer";
            TbServer.PlaceholderText = "localhost";
            TbServer.Size = new Size(340, 30);
            TbServer.TabIndex = 3;
            // 
            // TbUser
            // 
            TbUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbUser.BackColor = Color.FromArgb(55, 60, 72);
            TbUser.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(TbUser, 2);
            TbUser.Font = new Font("Segoe UI", 10F);
            TbUser.ForeColor = Color.FromArgb(160, 165, 175);
            TbUser.Location = new Point(5, 105);
            TbUser.Margin = new Padding(5, 0, 5, 10);
            TbUser.MaximumSize = new Size(0, 30);
            TbUser.MinimumSize = new Size(190, 30);
            TbUser.Name = "TbUser";
            TbUser.PlaceholderText = "root";
            TbUser.Size = new Size(340, 30);
            TbUser.TabIndex = 4;
            // 
            // TbPassword
            // 
            TbPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbPassword.BackColor = Color.FromArgb(55, 60, 72);
            TbPassword.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(TbPassword, 2);
            TbPassword.Font = new Font("Segoe UI", 10F);
            TbPassword.ForeColor = Color.FromArgb(160, 165, 175);
            TbPassword.Location = new Point(5, 180);
            TbPassword.Margin = new Padding(5, 0, 5, 10);
            TbPassword.MaximumSize = new Size(0, 30);
            TbPassword.MinimumSize = new Size(190, 30);
            TbPassword.Name = "TbPassword";
            TbPassword.PasswordChar = '*';
            TbPassword.PlaceholderText = "root";
            TbPassword.Size = new Size(340, 30);
            TbPassword.TabIndex = 5;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Action = Componentes.ButtonAction.Eliminar;
            BtnGuardar.Anchor = AnchorStyles.None;
            BtnGuardar.BackColor = Color.FromArgb(192, 57, 43);
            tableLayoutPanel1.SetColumnSpan(BtnGuardar, 2);
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(116, 35, 27);
            BtnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 62, 46);
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnGuardar.ForeColor = Color.White;
            BtnGuardar.Location = new Point(100, 230);
            BtnGuardar.Margin = new Padding(0);
            BtnGuardar.MaximumSize = new Size(150, 40);
            BtnGuardar.MinimumSize = new Size(150, 40);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(150, 40);
            BtnGuardar.TabIndex = 6;
            BtnGuardar.Text = "Configurar";
            BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // FrConexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(400, 350);
            Controls.Add(TlpAux);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrConexion";
            Text = "FrConexion";
            TlpAux.ResumeLayout(false);
            PnlControlBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpAux;
        private Panel PnlControlBox;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Componentes.CustomLabel LbServer;
        private Componentes.CustomLabel LbUser;
        private Componentes.CustomLabel LbPassword;
        private Componentes.CustomTextBox TbServer;
        private Componentes.CustomTextBox TbUser;
        private Componentes.CustomTextBox TbPassword;
        private Componentes.CustomButton BtnGuardar;
    }
}