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
            PicLogo = new Krypton.Toolkit.KryptonPictureBox();
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            Tlp_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicLogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Tlp_main
            // 
            Tlp_main.ColumnCount = 1;
            Tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_main.Controls.Add(Tlp_formulario, 0, 2);
            Tlp_main.Controls.Add(PicLogo, 0, 1);
            Tlp_main.Controls.Add(panel1, 0, 0);
            Tlp_main.Dock = DockStyle.Fill;
            Tlp_main.Location = new Point(0, 0);
            Tlp_main.Name = "Tlp_main";
            Tlp_main.RowCount = 3;
            Tlp_main.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            Tlp_main.RowStyles.Add(new RowStyle(SizeType.Absolute, 225F));
            Tlp_main.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            Tlp_main.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_main.Size = new Size(300, 500);
            Tlp_main.TabIndex = 0;
            // 
            // Tlp_formulario
            // 
            Tlp_formulario.BackColor = Color.Black;
            Tlp_formulario.ColumnCount = 1;
            Tlp_main.SetColumnSpan(Tlp_formulario, 2);
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_formulario.Dock = DockStyle.Fill;
            Tlp_formulario.Location = new Point(17, 283);
            Tlp_formulario.Margin = new Padding(17, 27, 17, 7);
            Tlp_formulario.Name = "Tlp_formulario";
            Tlp_formulario.RowCount = 5;
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.Size = new Size(266, 210);
            Tlp_formulario.TabIndex = 8;
            // 
            // PicLogo
            // 
            PicLogo.Anchor = AnchorStyles.None;
            PicLogo.BackgroundImage = (Image)resources.GetObject("PicLogo.BackgroundImage");
            PicLogo.BackgroundImageLayout = ImageLayout.Stretch;
            PicLogo.Location = new Point(25, 31);
            PicLogo.Margin = new Padding(0);
            PicLogo.MaximumSize = new Size(250, 250);
            PicLogo.MinimumSize = new Size(250, 250);
            PicLogo.Name = "PicLogo";
            PicLogo.Size = new Size(250, 250);
            PicLogo.TabIndex = 7;
            PicLogo.TabStop = false;
            PicLogo.Click += PicLogo_Click;
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
            panel1.Size = new Size(300, 31);
            panel1.TabIndex = 6;
            panel1.MouseMove += panel1_MouseMove_1;
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
            nightControlBox1.Location = new Point(161, 0);
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
            ClientSize = new Size(300, 500);
            Controls.Add(Tlp_main);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(300, 500);
            MinimumSize = new Size(300, 500);
            Name = "FrLogin";
            Text = "Login";
            Tlp_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicLogo).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Tlp_main;
        private Label Tx_logo;
        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Krypton.Toolkit.KryptonPictureBox PicLogo;
        private TableLayoutPanel Tlp_formulario;
        private Componentes.CustomLabel LbUsuario;
        private Componentes.CustomLabel LbContra;
        private Componentes.CustomTextBox TbContra;
        private Componentes.CustomTextBox TbUsuario;
        private Componentes.CustomButton BtnIngresar;
    }
}