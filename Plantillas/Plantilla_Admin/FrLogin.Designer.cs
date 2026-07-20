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
            tableLayoutPanel1 = new TableLayoutPanel();
            Txt_logo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox2 = new TextBox();
            Txt_contrasena = new Label();
            btnIngresar = new Button();
            Txt_usuario = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.998127F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.00188F));
            tableLayoutPanel1.Controls.Add(Txt_logo, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(582, 153);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Txt_logo
            // 
            Txt_logo.AutoSize = true;
            Txt_logo.Dock = DockStyle.Fill;
            Txt_logo.Image = Plantilla_Admin.Properties.Resources.images1;
            Txt_logo.Location = new Point(3, 0);
            Txt_logo.Name = "Txt_logo";
            Txt_logo.Size = new Size(139, 153);
            Txt_logo.TabIndex = 1;
            Txt_logo.TextAlign = ContentAlignment.MiddleCenter;
            Txt_logo.Click += Txt_logo_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel2.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel2.Controls.Add(Txt_contrasena, 0, 1);
            tableLayoutPanel2.Controls.Add(btnIngresar, 1, 2);
            tableLayoutPanel2.Controls.Add(Txt_usuario, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(148, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(431, 147);
            tableLayoutPanel2.TabIndex = 2;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(164, 60);
            textBox2.MinimumSize = new Size(0, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 27);
            textBox2.TabIndex = 5;
            // 
            // Txt_contrasena
            // 
            Txt_contrasena.AutoSize = true;
            Txt_contrasena.Dock = DockStyle.Right;
            Txt_contrasena.Location = new Point(54, 49);
            Txt_contrasena.Name = "Txt_contrasena";
            Txt_contrasena.Size = new Size(104, 49);
            Txt_contrasena.TabIndex = 4;
            Txt_contrasena.Text = "CONTRASEÑA";
            Txt_contrasena.TextAlign = ContentAlignment.MiddleRight;
            Txt_contrasena.Click += Txt_contrasena_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnIngresar.Location = new Point(168, 105);
            btnIngresar.Margin = new Padding(7);
            btnIngresar.MinimumSize = new Size(0, 30);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(256, 35);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Txt_usuario
            // 
            Txt_usuario.AutoSize = true;
            Txt_usuario.Dock = DockStyle.Right;
            Txt_usuario.Location = new Point(87, 0);
            Txt_usuario.Name = "Txt_usuario";
            Txt_usuario.Size = new Size(71, 49);
            Txt_usuario.TabIndex = 1;
            Txt_usuario.Text = "USUARIO";
            Txt_usuario.TextAlign = ContentAlignment.MiddleRight;
            Txt_usuario.Click += Txt_usuario_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(164, 11);
            textBox1.MinimumSize = new Size(0, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 27);
            textBox1.TabIndex = 3;
            // 
            // FrLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 153);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(600, 200);
            MinimumSize = new Size(600, 200);
            Name = "FrLogin";
            Text = "FrLoginAdmin";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Txt_logo;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnIngresar;
        private Label Txt_usuario;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Txt_contrasena;
    }
}