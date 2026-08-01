namespace Plantilla_Cliente
{
    partial class FrLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrLogin));
            Tlp_main = new TableLayoutPanel();
            Tlp_formulario = new TableLayoutPanel();
            LbUsuario = new Componentes.CustomLabel();
            LbContra = new Componentes.CustomLabel();
            BtnIngresar = new Componentes.CustomButton();
            TbContra = new Componentes.CustomTextBox();
            TbUsuario = new Componentes.CustomTextBox();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            Tlp_main.SuspendLayout();
            Tlp_formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Tlp_main
            // 
            Tlp_main.ColumnCount = 3;
            Tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 219F));
            Tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            Tlp_main.Controls.Add(Tlp_formulario, 1, 1);
            Tlp_main.Controls.Add(kryptonPictureBox1, 0, 1);
            Tlp_main.Controls.Add(panel1, 0, 0);
            Tlp_main.Dock = DockStyle.Fill;
            Tlp_main.Location = new Point(0, 0);
            Tlp_main.Name = "Tlp_main";
            Tlp_main.RowCount = 2;
            Tlp_main.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            Tlp_main.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            Tlp_main.Size = new Size(650, 250);
            Tlp_main.TabIndex = 0;
            // 
            // Tlp_formulario
            // 
            Tlp_formulario.BackColor = Color.Black;
            Tlp_formulario.ColumnCount = 1;
            Tlp_main.SetColumnSpan(Tlp_formulario, 2);
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tlp_formulario.Controls.Add(LbUsuario, 0, 0);
            Tlp_formulario.Controls.Add(LbContra, 0, 2);
            Tlp_formulario.Controls.Add(BtnIngresar, 0, 4);
            Tlp_formulario.Controls.Add(TbContra, 0, 3);
            Tlp_formulario.Controls.Add(TbUsuario, 0, 1);
            Tlp_formulario.Dock = DockStyle.Fill;
            Tlp_formulario.Location = new Point(226, 38);
            Tlp_formulario.Margin = new Padding(7);
            Tlp_formulario.Name = "Tlp_formulario";
            Tlp_formulario.RowCount = 5;
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.Size = new Size(417, 205);
            Tlp_formulario.TabIndex = 2;
            // 
            // LbUsuario
            // 
            LbUsuario.AutoSize = true;
            LbUsuario.Dock = DockStyle.Fill;
            LbUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbUsuario.ForeColor = Color.FromArgb(220, 220, 220);
            LbUsuario.Location = new Point(3, 0);
            LbUsuario.Name = "LbUsuario";
            LbUsuario.Padding = new Padding(0, 0, 2, 0);
            LbUsuario.Size = new Size(411, 38);
            LbUsuario.TabIndex = 0;
            LbUsuario.Text = "Usuario";
            LbUsuario.TextAlign = ContentAlignment.BottomLeft;
            // 
            // LbContra
            // 
            LbContra.AutoSize = true;
            LbContra.Dock = DockStyle.Fill;
            LbContra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbContra.ForeColor = Color.FromArgb(220, 220, 220);
            LbContra.Location = new Point(3, 76);
            LbContra.Name = "LbContra";
            LbContra.Padding = new Padding(0, 0, 2, 0);
            LbContra.Size = new Size(411, 38);
            LbContra.TabIndex = 1;
            LbContra.Text = "Contraseña";
            LbContra.TextAlign = ContentAlignment.BottomLeft;
            // 
            // BtnIngresar
            // 
            BtnIngresar.Action = Componentes.ButtonAction.Eliminar;
            BtnIngresar.Anchor = AnchorStyles.None;
            BtnIngresar.BackColor = Color.FromArgb(192, 57, 43);
            BtnIngresar.FlatAppearance.BorderSize = 0;
            BtnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(116, 35, 27);
            BtnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 62, 46);
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnIngresar.ForeColor = Color.White;
            BtnIngresar.Location = new Point(158, 158);
            BtnIngresar.Margin = new Padding(0);
            BtnIngresar.MaximumSize = new Size(100, 40);
            BtnIngresar.MinimumSize = new Size(100, 40);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(100, 40);
            BtnIngresar.TabIndex = 4;
            BtnIngresar.Text = "Ingresar";
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click_1;
            // 
            // TbContra
            // 
            TbContra.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbContra.BackColor = Color.FromArgb(55, 60, 72);
            TbContra.BorderStyle = BorderStyle.FixedSingle;
            TbContra.Font = new Font("Segoe UI", 10F);
            TbContra.ForeColor = Color.FromArgb(230, 230, 230);
            TbContra.Location = new Point(5, 119);
            TbContra.Margin = new Padding(5);
            TbContra.MaximumSize = new Size(0, 30);
            TbContra.MinimumSize = new Size(190, 30);
            TbContra.Name = "TbContra";
            TbContra.PasswordChar = '*';
            TbContra.Size = new Size(407, 30);
            TbContra.TabIndex = 3;
            // 
            // TbUsuario
            // 
            TbUsuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbUsuario.BackColor = Color.FromArgb(55, 60, 72);
            TbUsuario.BorderStyle = BorderStyle.FixedSingle;
            TbUsuario.Font = new Font("Segoe UI", 10F);
            TbUsuario.ForeColor = Color.FromArgb(230, 230, 230);
            TbUsuario.Location = new Point(5, 43);
            TbUsuario.Margin = new Padding(5);
            TbUsuario.MaximumSize = new Size(0, 30);
            TbUsuario.MinimumSize = new Size(190, 30);
            TbUsuario.Name = "TbUsuario";
            TbUsuario.Size = new Size(407, 30);
            TbUsuario.TabIndex = 2;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.BackgroundImage = (Image)resources.GetObject("kryptonPictureBox1.BackgroundImage");
            kryptonPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            kryptonPictureBox1.Dock = DockStyle.Fill;
            kryptonPictureBox1.Location = new Point(0, 31);
            kryptonPictureBox1.Margin = new Padding(0);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(219, 219);
            kryptonPictureBox1.TabIndex = 3;
            kryptonPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 21, 26);
            Tlp_main.SetColumnSpan(panel1, 34);
            panel1.Controls.Add(nightControlBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 31);
            panel1.TabIndex = 5;
            panel1.MouseMove += panel1_MouseMove;
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
            nightControlBox1.Location = new Point(511, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 4;
            // 
            // FrLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(650, 250);
            Controls.Add(Tlp_main);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(650, 250);
            MinimumSize = new Size(650, 250);
            Name = "FrLogin";
            Text = "Login";
            Tlp_main.ResumeLayout(false);
            Tlp_formulario.ResumeLayout(false);
            Tlp_formulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Tlp_main;
        private Label Tx_logo;
        private TableLayoutPanel Tlp_formulario;
        private Componentes.CustomLabel LbUsuario;
        private Componentes.CustomLabel LbContra;
        private Componentes.CustomTextBox TbUsuario;
        private Componentes.CustomTextBox TbContra;
        private Componentes.CustomButton BtnIngresar;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panel1;
    }
}