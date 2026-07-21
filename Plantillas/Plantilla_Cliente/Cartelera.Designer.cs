namespace Plantilla_Cliente
{
    partial class Cartelera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cartelera));
            Pnl_Buscador = new TableLayoutPanel();
            Pnl_Filtros1 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            Pnl_Filtros2 = new TableLayoutPanel();
            Btn_2DFilter = new Button();
            Btn_3DFilter = new Button();
            button4 = new Button();
            button5 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            Pnl_Buscador.SuspendLayout();
            Pnl_Filtros1.SuspendLayout();
            Pnl_Filtros2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Pnl_Buscador
            // 
            Pnl_Buscador.BackColor = Color.FromArgb(28, 17, 69);
            Pnl_Buscador.ColumnCount = 2;
            Pnl_Buscador.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.1888237F));
            Pnl_Buscador.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.81118F));
            Pnl_Buscador.Controls.Add(Pnl_Filtros1, 1, 1);
            Pnl_Buscador.Controls.Add(label1, 0, 0);
            Pnl_Buscador.Controls.Add(Pnl_Filtros2, 1, 2);
            Pnl_Buscador.Controls.Add(tableLayoutPanel1, 1, 0);
            Pnl_Buscador.Controls.Add(pictureBox2, 0, 3);
            Pnl_Buscador.Dock = DockStyle.Fill;
            Pnl_Buscador.Location = new Point(0, 0);
            Pnl_Buscador.Name = "Pnl_Buscador";
            Pnl_Buscador.RowCount = 4;
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Percent, 11.3899612F));
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Percent, 9.612142F));
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Percent, 9.274874F));
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Percent, 69.98314F));
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Pnl_Buscador.Size = new Size(2165, 968);
            Pnl_Buscador.TabIndex = 0;
            Pnl_Buscador.Paint += tableLayoutPanel1_Paint;
            // 
            // Pnl_Filtros1
            // 
            Pnl_Filtros1.BackColor = Color.FromArgb(28, 17, 69);
            Pnl_Filtros1.ColumnCount = 3;
            Pnl_Filtros1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            Pnl_Filtros1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            Pnl_Filtros1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            Pnl_Filtros1.Controls.Add(comboBox1, 0, 0);
            Pnl_Filtros1.Controls.Add(comboBox2, 1, 0);
            Pnl_Filtros1.Controls.Add(button1, 2, 0);
            Pnl_Filtros1.Dock = DockStyle.Fill;
            Pnl_Filtros1.Location = new Point(375, 112);
            Pnl_Filtros1.Name = "Pnl_Filtros1";
            Pnl_Filtros1.RowCount = 1;
            Pnl_Filtros1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Pnl_Filtros1.Size = new Size(1787, 86);
            Pnl_Filtros1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 38;
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(589, 44);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Seleccionar Ciudad";
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox2.FormattingEnabled = true;
            comboBox2.ItemHeight = 38;
            comboBox2.Location = new Point(598, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(589, 44);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "Seleccionar Cine";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(1193, 3);
            button1.Name = "button1";
            button1.Size = new Size(591, 80);
            button1.TabIndex = 4;
            button1.Text = "Ver cartelera";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            Pnl_Buscador.SetRowSpan(label1, 3);
            label1.Size = new Size(366, 290);
            label1.TabIndex = 1;
            label1.Text = "Logo aquí";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Pnl_Filtros2
            // 
            Pnl_Filtros2.BackColor = Color.FromArgb(95, 93, 100);
            Pnl_Filtros2.ColumnCount = 4;
            Pnl_Filtros2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Pnl_Filtros2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Pnl_Filtros2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Pnl_Filtros2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Pnl_Filtros2.Controls.Add(Btn_2DFilter, 0, 0);
            Pnl_Filtros2.Controls.Add(Btn_3DFilter, 1, 0);
            Pnl_Filtros2.Controls.Add(button4, 2, 0);
            Pnl_Filtros2.Controls.Add(button5, 3, 0);
            Pnl_Filtros2.Dock = DockStyle.Fill;
            Pnl_Filtros2.Location = new Point(375, 204);
            Pnl_Filtros2.Name = "Pnl_Filtros2";
            Pnl_Filtros2.RowCount = 1;
            Pnl_Filtros2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Pnl_Filtros2.Size = new Size(1787, 83);
            Pnl_Filtros2.TabIndex = 7;
            // 
            // Btn_2DFilter
            // 
            Btn_2DFilter.BackColor = Color.White;
            Btn_2DFilter.Dock = DockStyle.Fill;
            Btn_2DFilter.Location = new Point(3, 3);
            Btn_2DFilter.Name = "Btn_2DFilter";
            Btn_2DFilter.Size = new Size(440, 77);
            Btn_2DFilter.TabIndex = 0;
            Btn_2DFilter.Text = "2D";
            Btn_2DFilter.UseVisualStyleBackColor = false;
            Btn_2DFilter.Click += Btn_2DFilter_Click;
            // 
            // Btn_3DFilter
            // 
            Btn_3DFilter.BackColor = Color.White;
            Btn_3DFilter.Dock = DockStyle.Fill;
            Btn_3DFilter.Location = new Point(449, 3);
            Btn_3DFilter.Name = "Btn_3DFilter";
            Btn_3DFilter.Size = new Size(440, 77);
            Btn_3DFilter.TabIndex = 1;
            Btn_3DFilter.Text = "3D";
            Btn_3DFilter.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(895, 3);
            button4.Name = "button4";
            button4.Size = new Size(440, 77);
            button4.TabIndex = 2;
            button4.Text = "4DX";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(1341, 3);
            button5.Name = "button5";
            button5.Size = new Size(443, 77);
            button5.TabIndex = 3;
            button5.Text = "IMAX";
            button5.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.0907197F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.90928F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(375, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1787, 103);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 97);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(129, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1655, 97);
            textBox1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            Pnl_Buscador.SetColumnSpan(pictureBox2, 2);
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 293);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(2159, 672);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Cartelera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Pnl_Buscador);
            Name = "Cartelera";
            Size = new Size(2165, 968);
            Load += Cartelera_Load;
            Pnl_Buscador.ResumeLayout(false);
            Pnl_Filtros1.ResumeLayout(false);
            Pnl_Filtros2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Pnl_Buscador;
        private Label label1;
        private TableLayoutPanel Pnl_Filtros1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private TableLayoutPanel Pnl_Filtros2;
        private Button button2;
        private Button Btn_3DFilter;
        private Button button4;
        private Button button5;
        private Button Btn_2DFilter;
        private Button Btn_3DFitler;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
    }
}
