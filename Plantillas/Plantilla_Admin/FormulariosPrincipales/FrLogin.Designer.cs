namespace Plantilla_Cliente
{
    partial class FrLogin
    {
        /// José Pablo Cano Cóbar 
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
            Tlp_main = new TableLayoutPanel();
            Tx_logo = new Label();
            Tlp_formulario = new TableLayoutPanel();
            Txt_contrasena = new TextBox();
            Tx_contrasena = new Label();
            Btn_ingresar = new Button();
            Tx_usuario = new Label();
            Txt_usuario = new TextBox();
            Tlp_main.SuspendLayout();
            Tlp_formulario.SuspendLayout();
            SuspendLayout();
            // 
            // Tlp_main
            // 
            Tlp_main.BackColor = SystemColors.GradientInactiveCaption;
            Tlp_main.ColumnCount = 2;
            Tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.998127F));
            Tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.00188F));
            Tlp_main.Controls.Add(Tx_logo, 0, 0);
            Tlp_main.Controls.Add(Tlp_formulario, 1, 0);
            Tlp_main.Dock = DockStyle.Fill;
            Tlp_main.Location = new Point(0, 0);
            Tlp_main.Name = "Tlp_main";
            Tlp_main.RowCount = 1;
            Tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_main.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_main.Size = new Size(582, 153);
            Tlp_main.TabIndex = 0;
            // 
            // Tx_logo
            // 
            Tx_logo.AutoSize = true;
            Tx_logo.Dock = DockStyle.Fill;
            Tx_logo.Image = Plantilla_Admin.Properties.Resources.images;
            Tx_logo.Location = new Point(3, 0);
            Tx_logo.Name = "Tx_logo";
            Tx_logo.Size = new Size(139, 153);
            Tx_logo.TabIndex = 1;
            Tx_logo.TextAlign = ContentAlignment.MiddleCenter;
            Tx_logo.Click += Txt_logo_Click;
            // 
            // Tlp_formulario
            // 
            Tlp_formulario.ColumnCount = 2;
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            Tlp_formulario.Controls.Add(Txt_contrasena, 1, 1);
            Tlp_formulario.Controls.Add(Tx_contrasena, 0, 1);
            Tlp_formulario.Controls.Add(Btn_ingresar, 1, 2);
            Tlp_formulario.Controls.Add(Tx_usuario, 0, 0);
            Tlp_formulario.Controls.Add(Txt_usuario, 1, 0);
            Tlp_formulario.Dock = DockStyle.Fill;
            Tlp_formulario.Location = new Point(148, 3);
            Tlp_formulario.Name = "Tlp_formulario";
            Tlp_formulario.RowCount = 3;
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Tlp_formulario.Size = new Size(431, 147);
            Tlp_formulario.TabIndex = 2;
            Tlp_formulario.Paint += tableLayoutPanel2_Paint;
            // 
            // Txt_contrasena
            // 
            Txt_contrasena.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Txt_contrasena.Location = new Point(164, 60);
            Txt_contrasena.MinimumSize = new Size(0, 25);
            Txt_contrasena.Name = "Txt_contrasena";
            Txt_contrasena.PasswordChar = '*';
            Txt_contrasena.Size = new Size(264, 27);
            Txt_contrasena.TabIndex = 5;
            // 
            // Tx_contrasena
            // 
            Tx_contrasena.AutoSize = true;
            Tx_contrasena.Dock = DockStyle.Right;
            Tx_contrasena.Location = new Point(54, 49);
            Tx_contrasena.Name = "Tx_contrasena";
            Tx_contrasena.Size = new Size(104, 49);
            Tx_contrasena.TabIndex = 4;
            Tx_contrasena.Text = "CONTRASEÑA";
            Tx_contrasena.TextAlign = ContentAlignment.MiddleRight;
            Tx_contrasena.Click += Txt_contrasena_Click;
            // 
            // Btn_ingresar
            // 
            Btn_ingresar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_ingresar.Location = new Point(168, 105);
            Btn_ingresar.Margin = new Padding(7);
            Btn_ingresar.MinimumSize = new Size(0, 30);
            Btn_ingresar.Name = "Btn_ingresar";
            Btn_ingresar.Size = new Size(256, 35);
            Btn_ingresar.TabIndex = 0;
            Btn_ingresar.Text = "Ingresar";
            Btn_ingresar.UseVisualStyleBackColor = true;
            Btn_ingresar.Click += btnIngresar_Click;
            // 
            // Tx_usuario
            // 
            Tx_usuario.AutoSize = true;
            Tx_usuario.Dock = DockStyle.Right;
            Tx_usuario.Location = new Point(87, 0);
            Tx_usuario.Name = "Tx_usuario";
            Tx_usuario.Size = new Size(71, 49);
            Tx_usuario.TabIndex = 1;
            Tx_usuario.Text = "USUARIO";
            Tx_usuario.TextAlign = ContentAlignment.MiddleRight;
            Tx_usuario.Click += Txt_usuario_Click;
            // 
            // Txt_usuario
            // 
            Txt_usuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Txt_usuario.Location = new Point(164, 11);
            Txt_usuario.MinimumSize = new Size(0, 25);
            Txt_usuario.Name = "Txt_usuario";
            Txt_usuario.Size = new Size(264, 27);
            Txt_usuario.TabIndex = 3;
            // 
            // FrLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 153);
            Controls.Add(Tlp_main);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(600, 200);
            MinimumSize = new Size(600, 200);
            Name = "FrLogin";
            Text = "Login";
            Tlp_main.ResumeLayout(false);
            Tlp_main.PerformLayout();
            Tlp_formulario.ResumeLayout(false);
            Tlp_formulario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Tlp_main;
        private Label Tx_logo;
        private TableLayoutPanel Tlp_formulario;
        private Button Btn_ingresar;
        private Label Tx_usuario;
        private TextBox Txt_usuario;
        private TextBox Txt_contrasena;
        private Label Tx_contrasena;
    }
}