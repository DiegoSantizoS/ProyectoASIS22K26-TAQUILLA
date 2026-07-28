
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
            Pnl_Buscador = new TableLayoutPanel();
            Pnl_Filtros1 = new TableLayoutPanel();
            Cbo_Ciudad = new ComboBox();
            Cbo_Cine = new ComboBox();
            Btn_Cargar_Cartelera = new Button();
            label1 = new Label();
            Pnl_Filtros2 = new TableLayoutPanel();
            Btn_2DFilter = new Button();
            Btn_3DFilter = new Button();
            Btn_4DXFilter = new Button();
            Btn_IMAXFilter = new Button();
            Btn_DobFilter = new Button();
            Btn_SubFilter = new Button();
            Tb_Hora = new TrackBar();
            Dgv_Cartelera = new DataGridView();
            Reservar = new DataGridViewButtonColumn();
            comboBox2 = new ComboBox();
            Pnl_Buscador.SuspendLayout();
            Pnl_Filtros1.SuspendLayout();
            Pnl_Filtros2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tb_Hora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Cartelera).BeginInit();
            SuspendLayout();
            // 
            // Pnl_Buscador
            // 
            Pnl_Buscador.BackColor = Color.FromArgb(28, 17, 69);
            Pnl_Buscador.ColumnCount = 2;
            Pnl_Buscador.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.1888237F));
            Pnl_Buscador.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.81118F));
            Pnl_Buscador.Controls.Add(Pnl_Filtros1, 1, 0);
            Pnl_Buscador.Controls.Add(label1, 0, 0);
            Pnl_Buscador.Controls.Add(Pnl_Filtros2, 1, 1);
            Pnl_Buscador.Controls.Add(Dgv_Cartelera, 0, 3);
            Pnl_Buscador.Dock = DockStyle.Fill;
            Pnl_Buscador.Location = new Point(0, 0);
            Pnl_Buscador.Name = "Pnl_Buscador";
            Pnl_Buscador.RowCount = 4;
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Percent, 7.3347106F));
            Pnl_Buscador.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3305788F));
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
            Pnl_Filtros1.Controls.Add(Cbo_Ciudad, 0, 0);
            Pnl_Filtros1.Controls.Add(Cbo_Cine, 1, 0);
            Pnl_Filtros1.Controls.Add(Btn_Cargar_Cartelera, 2, 0);
            Pnl_Filtros1.Dock = DockStyle.Fill;
            Pnl_Filtros1.Location = new Point(375, 3);
            Pnl_Filtros1.Name = "Pnl_Filtros1";
            Pnl_Filtros1.RowCount = 1;
            Pnl_Filtros1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Pnl_Filtros1.Size = new Size(1787, 65);
            Pnl_Filtros1.TabIndex = 6;
            // 
            // Cbo_Ciudad
            // 
            Cbo_Ciudad.Dock = DockStyle.Fill;
            Cbo_Ciudad.FormattingEnabled = true;
            Cbo_Ciudad.ItemHeight = 20;
            Cbo_Ciudad.Location = new Point(3, 3);
            Cbo_Ciudad.Name = "Cbo_Ciudad";
            Cbo_Ciudad.Size = new Size(589, 28);
            Cbo_Ciudad.TabIndex = 2;
            Cbo_Ciudad.Text = "Seleccionar Ciudad";
            // 
            // Cbo_Cine
            // 
            Cbo_Cine.Dock = DockStyle.Fill;
            Cbo_Cine.DrawMode = DrawMode.OwnerDrawFixed;
            Cbo_Cine.FormattingEnabled = true;
            Cbo_Cine.ItemHeight = 50;
            Cbo_Cine.Location = new Point(598, 3);
            Cbo_Cine.Name = "Cbo_Cine";
            Cbo_Cine.Size = new Size(589, 56);
            Cbo_Cine.TabIndex = 3;
            Cbo_Cine.Text = "Seleccionar Cine";
            // 
            // Btn_Cargar_Cartelera
            // 
            Btn_Cargar_Cartelera.Cursor = Cursors.Hand;
            Btn_Cargar_Cartelera.Dock = DockStyle.Fill;
            Btn_Cargar_Cartelera.Location = new Point(1193, 3);
            Btn_Cargar_Cartelera.Name = "Btn_Cargar_Cartelera";
            Btn_Cargar_Cartelera.Size = new Size(591, 59);
            Btn_Cargar_Cartelera.TabIndex = 4;
            Btn_Cargar_Cartelera.Text = "Consultar cartelera";
            Btn_Cargar_Cartelera.UseVisualStyleBackColor = true;
            Btn_Cargar_Cartelera.Click += Btn_Cargar_Cartelera_Click;
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
            Pnl_Filtros2.Controls.Add(Btn_DobFilter, 0, 1);
            Pnl_Filtros2.Controls.Add(Btn_SubFilter, 1, 1);
            Pnl_Filtros2.Controls.Add(Tb_Hora, 2, 1);
            Pnl_Filtros2.Dock = DockStyle.Fill;
            Pnl_Filtros2.Location = new Point(375, 74);
            Pnl_Filtros2.Name = "Pnl_Filtros2";
            Pnl_Filtros2.RowCount = 2;
            Pnl_Buscador.SetRowSpan(Pnl_Filtros2, 2);
            Pnl_Filtros2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Pnl_Filtros2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Pnl_Filtros2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Pnl_Filtros2.Size = new Size(1787, 175);
            Pnl_Filtros2.TabIndex = 7;
            // 
            // Btn_2DFilter
            // 
            Btn_2DFilter.BackColor = Color.White;
            Btn_2DFilter.Cursor = Cursors.Hand;
            Btn_2DFilter.Dock = DockStyle.Fill;
            Btn_2DFilter.Location = new Point(3, 3);
            Btn_2DFilter.Name = "Btn_2DFilter";
            Btn_2DFilter.Size = new Size(440, 81);
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
            Btn_3DFilter.Location = new Point(449, 3);
            Btn_3DFilter.Name = "Btn_3DFilter";
            Btn_3DFilter.Size = new Size(440, 81);
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
            Btn_4DXFilter.Location = new Point(895, 3);
            Btn_4DXFilter.Name = "Btn_4DXFilter";
            Btn_4DXFilter.Size = new Size(440, 81);
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
            Btn_IMAXFilter.Location = new Point(1341, 3);
            Btn_IMAXFilter.Name = "Btn_IMAXFilter";
            Btn_IMAXFilter.Size = new Size(443, 81);
            Btn_IMAXFilter.TabIndex = 3;
            Btn_IMAXFilter.Text = "IMAX";
            Btn_IMAXFilter.UseVisualStyleBackColor = false;
            Btn_IMAXFilter.Click += Btn_IMAXFilter_Click;
            // 
            // Btn_DobFilter
            // 
            Btn_DobFilter.BackColor = Color.White;
            Btn_DobFilter.Dock = DockStyle.Fill;
            Btn_DobFilter.Location = new Point(3, 90);
            Btn_DobFilter.Name = "Btn_DobFilter";
            Btn_DobFilter.Size = new Size(440, 82);
            Btn_DobFilter.TabIndex = 4;
            Btn_DobFilter.Text = "Doblado";
            Btn_DobFilter.UseVisualStyleBackColor = false;
            Btn_DobFilter.Click += Btn_DobFilter_Click;
            // 
            // Btn_SubFilter
            // 
            Btn_SubFilter.BackColor = Color.White;
            Btn_SubFilter.Dock = DockStyle.Fill;
            Btn_SubFilter.Location = new Point(449, 90);
            Btn_SubFilter.Name = "Btn_SubFilter";
            Btn_SubFilter.Size = new Size(440, 82);
            Btn_SubFilter.TabIndex = 5;
            Btn_SubFilter.Text = "Subtitulado";
            Btn_SubFilter.UseVisualStyleBackColor = false;
            Btn_SubFilter.Click += Btn_SubFilter_Click;
            // 
            // Tb_Hora
            // 
            Pnl_Filtros2.SetColumnSpan(Tb_Hora, 2);
            Tb_Hora.Dock = DockStyle.Fill;
            Tb_Hora.LargeChange = 1;
            Tb_Hora.Location = new Point(895, 90);
            Tb_Hora.Maximum = 12;
            Tb_Hora.Name = "Tb_Hora";
            Tb_Hora.Size = new Size(889, 82);
            Tb_Hora.TabIndex = 6;
            // 
            // Dgv_Cartelera
            // 
            Dgv_Cartelera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Cartelera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Cartelera.Columns.AddRange(new DataGridViewColumn[] { Reservar });
            Pnl_Buscador.SetColumnSpan(Dgv_Cartelera, 2);
            Dgv_Cartelera.Cursor = Cursors.Hand;
            Dgv_Cartelera.Dock = DockStyle.Fill;
            Dgv_Cartelera.Location = new Point(3, 255);
            Dgv_Cartelera.Name = "Dgv_Cartelera";
            Dgv_Cartelera.RowHeadersWidth = 51;
            Dgv_Cartelera.Size = new Size(2159, 710);
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
            Pnl_Filtros2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tb_Hora).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Cartelera).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Pnl_Buscador;
        private Label label1;
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
        private DataGridViewButtonColumn Reservar;
        private Button Btn_DobFilter;
        private Button Btn_SubFilter;
        private TrackBar Tb_Hora;
        private ComboBox Cbo_Ciudad;
    }
}
