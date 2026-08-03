
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
            Cbo_Ciudad = new ComboBox();
            Cbo_Cine = new ComboBox();
            Btn_Cargar_Cartelera = new Button();
            Pnl_Filtros2 = new TableLayoutPanel();
            Btn_2DFilter = new Button();
            Btn_3DFilter = new Button();
            Btn_4DXFilter = new Button();
            Btn_IMAXFilter = new Button();
            Btn_DobFilter = new Button();
            Btn_SubFilter = new Button();
            Dgv_Cartelera = new DataGridView();
            Reservar = new DataGridViewButtonColumn();
            pictureBox1 = new PictureBox();
            comboBox2 = new ComboBox();
            Pnl_Buscador.SuspendLayout();
            Pnl_Filtros1.SuspendLayout();
            Pnl_Filtros2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Cartelera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Pnl_Buscador
            // 
            Pnl_Buscador.BackColor = Color.FromArgb(28, 17, 69);
            Pnl_Buscador.ColumnCount = 2;
            Pnl_Buscador.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.1888237F));
            Pnl_Buscador.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.81118F));
            Pnl_Buscador.Controls.Add(Pnl_Filtros1, 1, 0);
            Pnl_Buscador.Controls.Add(Pnl_Filtros2, 1, 1);
            Pnl_Buscador.Controls.Add(Dgv_Cartelera, 0, 3);
            Pnl_Buscador.Controls.Add(pictureBox1, 0, 0);
            Pnl_Buscador.Dock = DockStyle.Fill;
            Pnl_Buscador.Location = new Point(0, 0);
            Pnl_Buscador.Name = "Pnl_Buscador";
            Pnl_Buscador.RowCount = 4;
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Percent, 5.99173546F));
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Percent, 11.363636F));
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Percent, 4.235537F));
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Percent, 78.3057861F));
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Pnl_Buscador.Size = new Size(1053, 700);
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
            Pnl_Filtros1.Controls.Add(Cbo_Ciudad, 0, 0);
            Pnl_Filtros1.Controls.Add(Cbo_Cine, 1, 0);
            Pnl_Filtros1.Controls.Add(Btn_Cargar_Cartelera, 2, 0);
            Pnl_Filtros1.Dock = DockStyle.Fill;
            Pnl_Filtros1.Location = new Point(183, 3);
            Pnl_Filtros1.Name = "Pnl_Filtros1";
            Pnl_Filtros1.RowCount = 1;
            Pnl_Filtros1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Pnl_Filtros1.Size = new Size(867, 35);
            Pnl_Filtros1.TabIndex = 6;
            // 
            // Cbo_Ciudad
            // 
            Cbo_Ciudad.Dock = DockStyle.Fill;
            Cbo_Ciudad.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Ciudad.FormattingEnabled = true;
            Cbo_Ciudad.ItemHeight = 20;
            Cbo_Ciudad.Location = new Point(3, 3);
            Cbo_Ciudad.Name = "Cbo_Ciudad";
            Cbo_Ciudad.Size = new Size(282, 28);
            Cbo_Ciudad.TabIndex = 2;
            Cbo_Ciudad.SelectedIndexChanged += Cbo_Ciudad_SelectedIndexChanged;
            // 
            // Cbo_Cine
            // 
            Cbo_Cine.DisplayMember = "Seleccione Cine...";
            Cbo_Cine.Dock = DockStyle.Fill;
            Cbo_Cine.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Cine.FormattingEnabled = true;
            Cbo_Cine.ItemHeight = 20;
            Cbo_Cine.Location = new Point(291, 3);
            Cbo_Cine.Name = "Cbo_Cine";
            Cbo_Cine.Size = new Size(283, 28);
            Cbo_Cine.TabIndex = 3;
            Cbo_Cine.ValueMember = "Seleccione Cine...";
            Cbo_Cine.SelectedIndexChanged += Cbo_Cine_SelectedIndexChanged;
            // 
            // Btn_Cargar_Cartelera
            // 
            Btn_Cargar_Cartelera.Cursor = Cursors.Hand;
            Btn_Cargar_Cartelera.Dock = DockStyle.Fill;
            Btn_Cargar_Cartelera.Location = new Point(580, 3);
            Btn_Cargar_Cartelera.Name = "Btn_Cargar_Cartelera";
            Btn_Cargar_Cartelera.Size = new Size(284, 29);
            Btn_Cargar_Cartelera.TabIndex = 5;
            Btn_Cargar_Cartelera.Text = "Consultar cartelera";
            Btn_Cargar_Cartelera.UseVisualStyleBackColor = true;
            Btn_Cargar_Cartelera.Click += Btn_Cargar_Cartelera_Click_2;
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
            Pnl_Filtros2.Controls.Add(Btn_DobFilter, 0, 1);
            Pnl_Filtros2.Controls.Add(Btn_SubFilter, 1, 1);
            Pnl_Filtros2.Dock = DockStyle.Fill;
            Pnl_Filtros2.Location = new Point(183, 44);
            Pnl_Filtros2.Name = "Pnl_Filtros2";
            Pnl_Filtros2.RowCount = 2;
            Pnl_Buscador.SetRowSpan(Pnl_Filtros2, 2);
            Pnl_Filtros2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Pnl_Filtros2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Pnl_Filtros2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Pnl_Filtros2.Size = new Size(867, 102);
            Pnl_Filtros2.TabIndex = 7;
            // 
            // Btn_2DFilter
            // 
            Btn_2DFilter.BackColor = Color.White;
            Btn_2DFilter.Cursor = Cursors.Hand;
            Btn_2DFilter.Dock = DockStyle.Fill;
            Btn_2DFilter.Location = new Point(3, 3);
            Btn_2DFilter.Name = "Btn_2DFilter";
            Btn_2DFilter.Size = new Size(210, 45);
            Btn_2DFilter.TabIndex = 0;
            Btn_2DFilter.Text = "2D";
            Btn_2DFilter.UseVisualStyleBackColor = false;
            Btn_2DFilter.Click += Btn_2DFilter_Click;
            // 
            // Btn_3DFilter
            // 
            Btn_3DFilter.BackColor = Color.White;
            Btn_3DFilter.Cursor = Cursors.Hand;
            Btn_3DFilter.Dock = DockStyle.Fill;
            Btn_3DFilter.Location = new Point(219, 3);
            Btn_3DFilter.Name = "Btn_3DFilter";
            Btn_3DFilter.Size = new Size(210, 45);
            Btn_3DFilter.TabIndex = 1;
            Btn_3DFilter.Text = "3D";
            Btn_3DFilter.UseVisualStyleBackColor = false;
            Btn_3DFilter.Click += Btn_3DFilter_Click;
            // 
            // Btn_4DXFilter
            // 
            Btn_4DXFilter.BackColor = Color.White;
            Btn_4DXFilter.Cursor = Cursors.Hand;
            Btn_4DXFilter.Dock = DockStyle.Fill;
            Btn_4DXFilter.Location = new Point(435, 3);
            Btn_4DXFilter.Name = "Btn_4DXFilter";
            Btn_4DXFilter.Size = new Size(210, 45);
            Btn_4DXFilter.TabIndex = 2;
            Btn_4DXFilter.Text = "4DX";
            Btn_4DXFilter.UseVisualStyleBackColor = false;
            Btn_4DXFilter.Click += Btn_4DXFilter_Click;
            // 
            // Btn_IMAXFilter
            // 
            Btn_IMAXFilter.BackColor = Color.White;
            Btn_IMAXFilter.Cursor = Cursors.Hand;
            Btn_IMAXFilter.Dock = DockStyle.Fill;
            Btn_IMAXFilter.Location = new Point(651, 3);
            Btn_IMAXFilter.Name = "Btn_IMAXFilter";
            Btn_IMAXFilter.Size = new Size(213, 45);
            Btn_IMAXFilter.TabIndex = 3;
            Btn_IMAXFilter.Text = "IMAX";
            Btn_IMAXFilter.UseVisualStyleBackColor = false;
            Btn_IMAXFilter.Click += Btn_IMAXFilter_Click;
            // 
            // Btn_DobFilter
            // 
            Btn_DobFilter.BackColor = Color.White;
            Btn_DobFilter.Dock = DockStyle.Fill;
            Btn_DobFilter.Location = new Point(3, 54);
            Btn_DobFilter.Name = "Btn_DobFilter";
            Btn_DobFilter.Size = new Size(210, 45);
            Btn_DobFilter.TabIndex = 4;
            Btn_DobFilter.Text = "Doblado";
            Btn_DobFilter.UseVisualStyleBackColor = false;
            Btn_DobFilter.Click += Btn_DobFilter_Click;
            // 
            // Btn_SubFilter
            // 
            Btn_SubFilter.BackColor = Color.White;
            Btn_SubFilter.Dock = DockStyle.Fill;
            Btn_SubFilter.Location = new Point(219, 54);
            Btn_SubFilter.Name = "Btn_SubFilter";
            Btn_SubFilter.Size = new Size(210, 45);
            Btn_SubFilter.TabIndex = 5;
            Btn_SubFilter.Text = "Subtitulado";
            Btn_SubFilter.UseVisualStyleBackColor = false;
            Btn_SubFilter.Click += Btn_SubFilter_Click;
            // 
            // Dgv_Cartelera
            // 
            Dgv_Cartelera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Cartelera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Cartelera.Columns.AddRange(new DataGridViewColumn[] { Reservar });
            Pnl_Buscador.SetColumnSpan(Dgv_Cartelera, 2);
            Dgv_Cartelera.Cursor = Cursors.Hand;
            Dgv_Cartelera.Dock = DockStyle.Fill;
            Dgv_Cartelera.Location = new Point(3, 152);
            Dgv_Cartelera.Name = "Dgv_Cartelera";
            Dgv_Cartelera.RowHeadersWidth = 51;
            Dgv_Cartelera.Size = new Size(1047, 545);
            Dgv_Cartelera.TabIndex = 9;
            Dgv_Cartelera.CellContentClick += Dgv_Cartelera_CellContentClick;
            // 
            // Reservar
            // 
            Reservar.HeaderText = "Reservar";
            Reservar.MinimumWidth = 6;
            Reservar.Name = "Reservar";
            Reservar.ReadOnly = true;
            Reservar.Text = "Reservar";
            Reservar.UseColumnTextForButtonValue = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            Pnl_Buscador.SetRowSpan(pictureBox1, 3);
            pictureBox1.Size = new Size(174, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
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
            MinimumSize = new Size(1000, 700);
            Name = "Cartelera";
            Size = new Size(1053, 700);
            Load += Cartelera_Load;
            Pnl_Buscador.ResumeLayout(false);
            Pnl_Filtros1.ResumeLayout(false);
            Pnl_Filtros2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_Cartelera).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Pnl_Buscador;
        private TableLayoutPanel Pnl_Filtros1;
        private ComboBox comboBox2;
        private TableLayoutPanel Pnl_Filtros2;
        private Button Btn_4DXFilter;
        private Button Btn_3DFilter;
        private Button Btn_IMAXFilter;
        private Button Btn_2DFilter;
        private DataGridView Dgv_Cartelera;
        private ComboBox Cbo_Cine;
        private Button Btn_Cargar_Cartelera;
        private Button Btn_DobFilter;
        private Button Btn_SubFilter;
        private ComboBox Cbo_Ciudad;
        private DataGridViewButtonColumn Reservar;
        private PictureBox pictureBox1;
    }
}
