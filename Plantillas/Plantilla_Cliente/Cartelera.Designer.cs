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
            CB_Ciudad = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            Pnl_Filtros2 = new TableLayoutPanel();
            Btn_2DFilter = new Button();
            Btn_3DFilter = new Button();
            Btn_4DXFilter = new Button();
            Btn_IMAXFilter = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            Dgv_Cartelera = new DataGridView();
            Imagen = new DataGridViewImageColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Generos = new DataGridViewTextBoxColumn();
            Idioma = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            Reservar = new DataGridViewButtonColumn();
            comboBox2 = new ComboBox();
            Pnl_Buscador.SuspendLayout();
            Pnl_Filtros1.SuspendLayout();
            Pnl_Filtros2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Cartelera).BeginInit();
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
            Pnl_Buscador.Controls.Add(Dgv_Cartelera, 0, 3);
            Pnl_Buscador.Dock = DockStyle.Fill;
            Pnl_Buscador.Location = new Point(0, 0);
            Pnl_Buscador.Name = "Pnl_Buscador";
            Pnl_Buscador.RowCount = 4;
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Percent, 11.3899612F));
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Percent, 6.50826454F));
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Percent, 8.367768F));
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Percent, 73.86364F));
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
            Pnl_Filtros1.Controls.Add(CB_Ciudad, 0, 0);
            Pnl_Filtros1.Controls.Add(comboBox1, 1, 0);
            Pnl_Filtros1.Controls.Add(button1, 2, 0);
            Pnl_Filtros1.Dock = DockStyle.Fill;
            Pnl_Filtros1.Location = new Point(375, 113);
            Pnl_Filtros1.Name = "Pnl_Filtros1";
            Pnl_Filtros1.RowCount = 1;
            Pnl_Filtros1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Pnl_Filtros1.Size = new Size(1787, 56);
            Pnl_Filtros1.TabIndex = 6;
            // 
            // CB_Ciudad
            // 
            CB_Ciudad.Dock = DockStyle.Fill;
            CB_Ciudad.DrawMode = DrawMode.OwnerDrawFixed;
            CB_Ciudad.FormattingEnabled = true;
            CB_Ciudad.ItemHeight = 50;
            CB_Ciudad.Location = new Point(3, 3);
            CB_Ciudad.Name = "CB_Ciudad";
            CB_Ciudad.Size = new Size(589, 56);
            CB_Ciudad.TabIndex = 2;
            CB_Ciudad.Text = "Seleccionar Ciudad";
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 50;
            comboBox1.Location = new Point(598, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(589, 56);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Seleccionar Cine";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(1193, 3);
            button1.Name = "button1";
            button1.Size = new Size(591, 50);
            button1.TabIndex = 4;
            button1.Text = "Consultar cartelera";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            Pnl_Buscador.SetRowSpan(label1, 3);
            label1.Size = new Size(366, 252);
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
            Pnl_Filtros2.Controls.Add(Btn_4DXFilter, 2, 0);
            Pnl_Filtros2.Controls.Add(Btn_IMAXFilter, 3, 0);
            Pnl_Filtros2.Dock = DockStyle.Fill;
            Pnl_Filtros2.Location = new Point(375, 175);
            Pnl_Filtros2.Name = "Pnl_Filtros2";
            Pnl_Filtros2.RowCount = 1;
            Pnl_Filtros2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Pnl_Filtros2.Size = new Size(1787, 74);
            Pnl_Filtros2.TabIndex = 7;
            // 
            // Btn_2DFilter
            // 
            Btn_2DFilter.BackColor = Color.White;
            Btn_2DFilter.Dock = DockStyle.Fill;
            Btn_2DFilter.Location = new Point(3, 3);
            Btn_2DFilter.Name = "Btn_2DFilter";
            Btn_2DFilter.Size = new Size(440, 68);
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
            Btn_3DFilter.Size = new Size(440, 68);
            Btn_3DFilter.TabIndex = 1;
            Btn_3DFilter.Text = "3D";
            Btn_3DFilter.UseVisualStyleBackColor = false;
            Btn_3DFilter.Click += Btn_3DFilter_Click;
            // 
            // Btn_4DXFilter
            // 
            Btn_4DXFilter.BackColor = Color.White;
            Btn_4DXFilter.Dock = DockStyle.Fill;
            Btn_4DXFilter.Location = new Point(895, 3);
            Btn_4DXFilter.Name = "Btn_4DXFilter";
            Btn_4DXFilter.Size = new Size(440, 68);
            Btn_4DXFilter.TabIndex = 2;
            Btn_4DXFilter.Text = "4DX";
            Btn_4DXFilter.UseVisualStyleBackColor = false;
            Btn_4DXFilter.Click += Btn_4DXFilter_Click;
            // 
            // Btn_IMAXFilter
            // 
            Btn_IMAXFilter.BackColor = Color.White;
            Btn_IMAXFilter.Dock = DockStyle.Fill;
            Btn_IMAXFilter.Location = new Point(1341, 3);
            Btn_IMAXFilter.Name = "Btn_IMAXFilter";
            Btn_IMAXFilter.Size = new Size(443, 68);
            Btn_IMAXFilter.TabIndex = 3;
            Btn_IMAXFilter.Text = "IMAX";
            Btn_IMAXFilter.UseVisualStyleBackColor = false;
            Btn_IMAXFilter.Click += Btn_IMAXFilter_Click;
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
            tableLayoutPanel1.Size = new Size(1787, 104);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 98);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(129, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1655, 98);
            textBox1.TabIndex = 1;
            // 
            // Dgv_Cartelera
            // 
            Dgv_Cartelera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Cartelera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Cartelera.Columns.AddRange(new DataGridViewColumn[] { Imagen, Nombre, Generos, Idioma, Duracion, Reservar });
            Pnl_Buscador.SetColumnSpan(Dgv_Cartelera, 2);
            Dgv_Cartelera.Dock = DockStyle.Fill;
            Dgv_Cartelera.Location = new Point(3, 255);
            Dgv_Cartelera.Name = "Dgv_Cartelera";
            Dgv_Cartelera.RowHeadersWidth = 51;
            Dgv_Cartelera.Size = new Size(2159, 710);
            Dgv_Cartelera.TabIndex = 9;
            Dgv_Cartelera.CellContentClick += Dgv_Cartelera_CellContentClick;
            // 
            // Imagen
            // 
            Imagen.HeaderText = "Imágen";
            Imagen.MinimumWidth = 6;
            Imagen.Name = "Imagen";
            Imagen.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Generos
            // 
            Generos.HeaderText = "Generos";
            Generos.MinimumWidth = 6;
            Generos.Name = "Generos";
            Generos.ReadOnly = true;
            // 
            // Idioma
            // 
            Idioma.HeaderText = "Idioma";
            Idioma.MinimumWidth = 6;
            Idioma.Name = "Idioma";
            Idioma.ReadOnly = true;
            // 
            // Duracion
            // 
            Duracion.HeaderText = "Duración";
            Duracion.MinimumWidth = 6;
            Duracion.Name = "Duracion";
            Duracion.ReadOnly = true;
            // 
            // Reservar
            // 
            Reservar.HeaderText = "Reservar";
            Reservar.MinimumWidth = 6;
            Reservar.Name = "Reservar";
            Reservar.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)Dgv_Cartelera).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Pnl_Buscador;
        private Label label1;
        private TableLayoutPanel Pnl_Filtros1;
        private ComboBox CB_Ciudad;
        private ComboBox comboBox2;
        private Button Btn_4DFilter;
        private TableLayoutPanel Pnl_Filtros2;
        private Button Btn_4DXFilter;
        private Button Btn_3DFilter;
        private Button Btn_IMAXFilter;
        private Button Btn_2DFilter;
        private Button Btn_3DFitler;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private DataGridView Dgv_Cartelera;
        private DataGridViewImageColumn Imagen;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Generos;
        private DataGridViewTextBoxColumn Idioma;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewButtonColumn Reservar;
        private ComboBox comboBox1;
        private Button button1;
    }
}
