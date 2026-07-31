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
            Tlp_main = new TableLayoutPanel();
            Tlp_formulario = new TableLayoutPanel();
            LbUsuario = new Componentes.CustomLabel();
            LbContra = new Componentes.CustomLabel();
            TbUsuario = new Componentes.CustomTextBox();
            TbContra = new Componentes.CustomTextBox();
            BtnIngresar = new Componentes.CustomButton();
            PbLogo = new PictureBox();
            Tlp_main.SuspendLayout();
            Tlp_formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbLogo).BeginInit();
            SuspendLayout();
            // 
            // Tlp_main
            // 
            Tlp_main.ColumnCount = 2;
            Tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.998127F));
            Tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.00188F));
            Tlp_main.Controls.Add(Tlp_formulario, 1, 0);
            Tlp_main.Controls.Add(PbLogo, 0, 0);
            Tlp_main.Dock = DockStyle.Fill;
            Tlp_main.Location = new Point(0, 0);
            Tlp_main.Name = "Tlp_main";
            Tlp_main.RowCount = 1;
            Tlp_main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_main.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_main.Size = new Size(582, 153);
            Tlp_main.TabIndex = 0;
            // 
            // Tlp_formulario
            // 
            Tlp_formulario.ColumnCount = 2;
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_formulario.Controls.Add(LbUsuario, 0, 0);
            Tlp_formulario.Controls.Add(LbContra, 0, 1);
            Tlp_formulario.Controls.Add(TbUsuario, 1, 0);
            Tlp_formulario.Controls.Add(TbContra, 1, 1);
            Tlp_formulario.Controls.Add(BtnIngresar, 1, 2);
            Tlp_formulario.Dock = DockStyle.Fill;
            Tlp_formulario.Location = new Point(152, 7);
            Tlp_formulario.Margin = new Padding(7);
            Tlp_formulario.Name = "Tlp_formulario";
            Tlp_formulario.RowCount = 3;
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Tlp_formulario.Size = new Size(423, 139);
            Tlp_formulario.TabIndex = 2;
            Tlp_formulario.Paint += tableLayoutPanel2_Paint;
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
            LbUsuario.Size = new Size(104, 46);
            LbUsuario.TabIndex = 0;
            LbUsuario.Text = "Usuario";
            LbUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbContra
            // 
            LbContra.AutoSize = true;
            LbContra.Dock = DockStyle.Fill;
            LbContra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbContra.ForeColor = Color.FromArgb(220, 220, 220);
            LbContra.Location = new Point(3, 46);
            LbContra.Name = "LbContra";
            LbContra.Padding = new Padding(0, 0, 2, 0);
            LbContra.Size = new Size(104, 46);
            LbContra.TabIndex = 1;
            LbContra.Text = "Contraseña";
            LbContra.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbUsuario
            // 
            TbUsuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbUsuario.BackColor = Color.FromArgb(55, 60, 72);
            TbUsuario.BorderStyle = BorderStyle.FixedSingle;
            TbUsuario.Font = new Font("Segoe UI", 10F);
            TbUsuario.ForeColor = Color.FromArgb(230, 230, 230);
            TbUsuario.Location = new Point(115, 8);
            TbUsuario.Margin = new Padding(5);
            TbUsuario.MaximumSize = new Size(0, 30);
            TbUsuario.MinimumSize = new Size(190, 30);
            TbUsuario.Name = "TbUsuario";
            TbUsuario.Size = new Size(303, 30);
            TbUsuario.TabIndex = 2;
            // 
            // TbContra
            // 
            TbContra.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbContra.BackColor = Color.FromArgb(55, 60, 72);
            TbContra.BorderStyle = BorderStyle.FixedSingle;
            TbContra.Font = new Font("Segoe UI", 10F);
            TbContra.ForeColor = Color.FromArgb(230, 230, 230);
            TbContra.Location = new Point(115, 54);
            TbContra.Margin = new Padding(5);
            TbContra.MaximumSize = new Size(0, 30);
            TbContra.MinimumSize = new Size(190, 30);
            TbContra.Name = "TbContra";
            TbContra.PasswordChar = '*';
            TbContra.Size = new Size(303, 30);
            TbContra.TabIndex = 3;
            // 
            // BtnIngresar
            // 
            BtnIngresar.Action = Componentes.ButtonAction.Actualizar;
            BtnIngresar.Anchor = AnchorStyles.None;
            BtnIngresar.BackColor = Color.FromArgb(214, 157, 15);
            BtnIngresar.FlatAppearance.BorderSize = 0;
            BtnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(130, 97, 9);
            BtnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 169, 16);
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnIngresar.ForeColor = Color.White;
            BtnIngresar.Location = new Point(216, 95);
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
            // PbLogo
            // 
            PbLogo.BackgroundImage = Plantilla_Admin.Properties.Resources.logo;
            PbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            PbLogo.Dock = DockStyle.Fill;
            PbLogo.Location = new Point(0, 0);
            PbLogo.Margin = new Padding(0);
            PbLogo.Name = "PbLogo";
            PbLogo.Size = new Size(145, 153);
            PbLogo.TabIndex = 3;
            PbLogo.TabStop = false;
            // 
            // FrLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(582, 153);
            Controls.Add(Tlp_main);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(600, 200);
            MinimumSize = new Size(600, 200);
            Name = "FrLogin";
            Text = "Login";
            Tlp_main.ResumeLayout(false);
            Tlp_formulario.ResumeLayout(false);
            Tlp_formulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbLogo).EndInit();
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
        private PictureBox PbLogo;
    }
}