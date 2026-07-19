namespace Plantilla_Cliente
{
    partial class FrMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrMenu));
            Pnl_Cines = new Panel();
            textBox1 = new TextBox();
            Lupa = new PictureBox();
            Pnl_Menú = new Panel();
            Pnl_Peliculas = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            Pnl_Filtros2 = new TableLayoutPanel();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            panel1 = new Panel();
            Pnl_Filtros1 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            Pnl_Cines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Lupa).BeginInit();
            Pnl_Menú.SuspendLayout();
            Pnl_Peliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            Pnl_Filtros2.SuspendLayout();
            panel1.SuspendLayout();
            Pnl_Filtros1.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_Cines
            // 
            Pnl_Cines.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Pnl_Cines.BackColor = Color.FromArgb(217, 217, 217);
            Pnl_Cines.Controls.Add(textBox1);
            Pnl_Cines.Controls.Add(Lupa);
            Pnl_Cines.Location = new Point(227, 10);
            Pnl_Cines.Name = "Pnl_Cines";
            Pnl_Cines.Size = new Size(1001, 55);
            Pnl_Cines.TabIndex = 1;
            Pnl_Cines.SizeChanged += Pnl_Cines_SizeChanged;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(49, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(949, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "Buscar una película";
            // 
            // Lupa
            // 
            Lupa.BackColor = Color.FromArgb(217, 217, 217);
            Lupa.Image = (Image)resources.GetObject("Lupa.Image");
            Lupa.Location = new Point(0, 0);
            Lupa.Margin = new Padding(0);
            Lupa.Name = "Lupa";
            Lupa.Size = new Size(48, 54);
            Lupa.SizeMode = PictureBoxSizeMode.StretchImage;
            Lupa.TabIndex = 0;
            Lupa.TabStop = false;
            Lupa.Click += pictureBox1_Click;
            // 
            // Pnl_Menú
            // 
            Pnl_Menú.BackColor = Color.FromArgb(28, 17, 69);
            Pnl_Menú.Controls.Add(Pnl_Peliculas);
            Pnl_Menú.Controls.Add(panel2);
            Pnl_Menú.Controls.Add(panel1);
            Pnl_Menú.Controls.Add(Pnl_Cines);
            Pnl_Menú.Controls.Add(label1);
            Pnl_Menú.Dock = DockStyle.Fill;
            Pnl_Menú.Location = new Point(0, 0);
            Pnl_Menú.Name = "Pnl_Menú";
            Pnl_Menú.Size = new Size(1240, 770);
            Pnl_Menú.TabIndex = 0;
            Pnl_Menú.Paint += Pnl_Menú_Paint;
            // 
            // Pnl_Peliculas
            // 
            Pnl_Peliculas.Controls.Add(pictureBox1);
            Pnl_Peliculas.Location = new Point(3, 185);
            Pnl_Peliculas.Name = "Pnl_Peliculas";
            Pnl_Peliculas.Size = new Size(1225, 573);
            Pnl_Peliculas.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1225, 573);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(217, 217, 217);
            panel2.Controls.Add(Pnl_Filtros2);
            panel2.Location = new Point(227, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(1001, 55);
            panel2.TabIndex = 2;
            // 
            // Pnl_Filtros2
            // 
            Pnl_Filtros2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Pnl_Filtros2.BackColor = Color.FromArgb(95, 93, 100);
            Pnl_Filtros2.ColumnCount = 3;
            Pnl_Filtros2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            Pnl_Filtros2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            Pnl_Filtros2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            Pnl_Filtros2.Controls.Add(radioButton1, 0, 0);
            Pnl_Filtros2.Controls.Add(radioButton2, 1, 0);
            Pnl_Filtros2.Controls.Add(radioButton3, 2, 0);
            Pnl_Filtros2.Location = new Point(0, 0);
            Pnl_Filtros2.Name = "Pnl_Filtros2";
            Pnl_Filtros2.RowCount = 1;
            Pnl_Filtros2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Pnl_Filtros2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Pnl_Filtros2.Size = new Size(1001, 55);
            Pnl_Filtros2.TabIndex = 6;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.FromArgb(95, 93, 100);
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(3, 15);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(327, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "3D";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Dock = DockStyle.Fill;
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(336, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(327, 49);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "4DX";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Dock = DockStyle.Fill;
            radioButton3.ForeColor = SystemColors.ButtonHighlight;
            radioButton3.Location = new Point(669, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(329, 49);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "IMAX";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(217, 217, 217);
            panel1.Controls.Add(Pnl_Filtros1);
            panel1.Location = new Point(227, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(1001, 50);
            panel1.TabIndex = 2;
            // 
            // Pnl_Filtros1
            // 
            Pnl_Filtros1.BackColor = Color.FromArgb(28, 17, 69);
            Pnl_Filtros1.ColumnCount = 3;
            Pnl_Filtros1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            Pnl_Filtros1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            Pnl_Filtros1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            Pnl_Filtros1.Controls.Add(comboBox1, 0, 0);
            Pnl_Filtros1.Controls.Add(comboBox2, 1, 0);
            Pnl_Filtros1.Controls.Add(button1, 2, 0);
            Pnl_Filtros1.Dock = DockStyle.Fill;
            Pnl_Filtros1.Location = new Point(0, 0);
            Pnl_Filtros1.Name = "Pnl_Filtros1";
            Pnl_Filtros1.RowCount = 1;
            Pnl_Filtros1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Pnl_Filtros1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Pnl_Filtros1.Size = new Size(1001, 50);
            Pnl_Filtros1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 38;
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(327, 44);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Seleccionar Ciudad";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox2.FormattingEnabled = true;
            comboBox2.ItemHeight = 38;
            comboBox2.Location = new Point(336, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(327, 44);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "Seleccionar Cine";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(669, 3);
            button1.Name = "button1";
            button1.Size = new Size(329, 44);
            button1.TabIndex = 4;
            button1.Text = "Ver cartelera";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(218, 169);
            label1.TabIndex = 0;
            label1.Text = "Logo aquí";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // FrMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 770);
            Controls.Add(Pnl_Menú);
            Name = "FrMenu";
            Text = "Menú principal";
            Load += Form1_Load;
            Pnl_Cines.ResumeLayout(false);
            Pnl_Cines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Lupa).EndInit();
            Pnl_Menú.ResumeLayout(false);
            Pnl_Peliculas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            Pnl_Filtros2.ResumeLayout(false);
            Pnl_Filtros2.PerformLayout();
            panel1.ResumeLayout(false);
            Pnl_Filtros1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Cines;
        private Panel Pnl_Menú;
        private Label label1;
        private PictureBox Lupa;
        private TextBox textBox1;
        private Panel panel1;
        private TableLayoutPanel Pnl_Filtros1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Panel panel2;
        private TableLayoutPanel Pnl_Filtros2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Panel Pnl_Peliculas;
        private PictureBox pictureBox1;
    }
}
