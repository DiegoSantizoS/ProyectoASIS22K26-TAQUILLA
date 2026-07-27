namespace Plantilla_Admin.Tabs.Funciones
{
    partial class FrUcMantenimientoFuncion
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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            pelicula = new DataGridViewImageColumn();
            formato = new DataGridViewTextBoxColumn();
            numero_sala = new DataGridViewTextBoxColumn();
            tipo_sala = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            hora = new DataGridViewTextBoxColumn();
            tableLayoutPanel8 = new TableLayoutPanel();
            pnl_estatico = new Panel();
            Tlp_tab = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label6 = new Label();
            label1 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label5 = new Label();
            textBox2 = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            comboBox1 = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            Cb_genero = new ComboBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            dataGridView2 = new DataGridView();
            horas_funcion = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            Tx_tab = new Label();
            Tlp_formulario = new TableLayoutPanel();
            button3 = new Button();
            Tlp_estreno = new TableLayoutPanel();
            Tx_estreno = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel8.SuspendLayout();
            pnl_estatico.SuspendLayout();
            Tlp_tab.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel9.SuspendLayout();
            Tlp_formulario.SuspendLayout();
            Tlp_estreno.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, pelicula, formato, numero_sala, tipo_sala, precio, hora });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 475);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1050, 225);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            // 
            // pelicula
            // 
            pelicula.HeaderText = "Película";
            pelicula.MinimumWidth = 6;
            pelicula.Name = "pelicula";
            // 
            // formato
            // 
            formato.HeaderText = "Formato";
            formato.MinimumWidth = 6;
            formato.Name = "formato";
            // 
            // numero_sala
            // 
            numero_sala.HeaderText = "Sala";
            numero_sala.MinimumWidth = 6;
            numero_sala.Name = "numero_sala";
            // 
            // tipo_sala
            // 
            tipo_sala.HeaderText = "Tipo de Sala";
            tipo_sala.MinimumWidth = 6;
            tipo_sala.Name = "tipo_sala";
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            // 
            // hora
            // 
            hora.HeaderText = "Hora";
            hora.MinimumWidth = 6;
            hora.Name = "hora";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Controls.Add(pnl_estatico, 0, 0);
            tableLayoutPanel8.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 475F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(1050, 700);
            tableLayoutPanel8.TabIndex = 11;
            // 
            // pnl_estatico
            // 
            pnl_estatico.Controls.Add(Tlp_tab);
            pnl_estatico.Location = new Point(0, 0);
            pnl_estatico.Margin = new Padding(0);
            pnl_estatico.MinimumSize = new Size(1050, 475);
            pnl_estatico.Name = "pnl_estatico";
            pnl_estatico.Padding = new Padding(0, 0, 20, 0);
            pnl_estatico.Size = new Size(1050, 475);
            pnl_estatico.TabIndex = 1;
            // 
            // Tlp_tab
            // 
            Tlp_tab.ColumnCount = 1;
            Tlp_tab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_tab.Controls.Add(tableLayoutPanel1, 0, 2);
            Tlp_tab.Controls.Add(Tx_tab, 0, 0);
            Tlp_tab.Controls.Add(Tlp_formulario, 0, 1);
            Tlp_tab.Dock = DockStyle.Fill;
            Tlp_tab.Location = new Point(0, 0);
            Tlp_tab.Name = "Tlp_tab";
            Tlp_tab.RowCount = 4;
            Tlp_tab.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            Tlp_tab.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_tab.RowStyles.Add(new RowStyle(SizeType.Absolute, 325F));
            Tlp_tab.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_tab.Size = new Size(1030, 475);
            Tlp_tab.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28531F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853079F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2881613F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 6, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 5, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 3, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 1, 1);
            tableLayoutPanel1.Controls.Add(dataGridView2, 3, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel9, 6, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 135);
            tableLayoutPanel1.Margin = new Padding(10, 0, 0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1020, 325);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label6, 0, 1);
            tableLayoutPanel6.Controls.Add(label1, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(145, 75);
            tableLayoutPanel6.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 30);
            label6.Margin = new Padding(3, 0, 3, 3);
            label6.Name = "label6";
            label6.Size = new Size(139, 42);
            label6.TabIndex = 5;
            label6.Text = "12345678";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Margin = new Padding(3, 0, 3, 3);
            label1.Name = "label1";
            label1.Size = new Size(139, 27);
            label1.TabIndex = 4;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label5, 0, 0);
            tableLayoutPanel5.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(870, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(150, 75);
            tableLayoutPanel5.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 0);
            label5.Margin = new Padding(3, 0, 3, 3);
            label5.Name = "label5";
            label5.Size = new Size(144, 27);
            label5.TabIndex = 4;
            label5.Text = "Hora";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(3, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 27);
            textBox2.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(725, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(145, 75);
            tableLayoutPanel4.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 0);
            label4.Margin = new Padding(3, 0, 3, 3);
            label4.Name = "label4";
            label4.Size = new Size(139, 27);
            label4.TabIndex = 4;
            label4.Text = "Precio";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 27);
            textBox1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel3, 2);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(comboBox1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(435, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(290, 75);
            tableLayoutPanel3.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Margin = new Padding(3, 0, 3, 3);
            label3.Name = "label3";
            label3.Size = new Size(284, 27);
            label3.TabIndex = 5;
            label3.Text = "Sala";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(284, 28);
            comboBox1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(Cb_genero, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(145, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(290, 75);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Margin = new Padding(3, 0, 3, 3);
            label2.Name = "label2";
            label2.Size = new Size(284, 27);
            label2.TabIndex = 5;
            label2.Text = "Película";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cb_genero
            // 
            Cb_genero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Cb_genero.FormattingEnabled = true;
            Cb_genero.Location = new Point(3, 33);
            Cb_genero.Name = "Cb_genero";
            Cb_genero.Size = new Size(284, 28);
            Cb_genero.TabIndex = 4;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel7, 2);
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(label14, 1, 3);
            tableLayoutPanel7.Controls.Add(label13, 0, 3);
            tableLayoutPanel7.Controls.Add(label12, 1, 2);
            tableLayoutPanel7.Controls.Add(label11, 0, 2);
            tableLayoutPanel7.Controls.Add(label10, 1, 1);
            tableLayoutPanel7.Controls.Add(label9, 0, 1);
            tableLayoutPanel7.Controls.Add(label8, 1, 0);
            tableLayoutPanel7.Controls.Add(label7, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(145, 75);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 4;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9981289F));
            tableLayoutPanel7.Size = new Size(290, 250);
            tableLayoutPanel7.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Location = new Point(103, 186);
            label14.Margin = new Padding(3, 0, 3, 3);
            label14.Name = "label14";
            label14.Size = new Size(184, 61);
            label14.TabIndex = 13;
            label14.Text = "75.00";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point(3, 186);
            label13.Margin = new Padding(3, 0, 3, 3);
            label13.Name = "label13";
            label13.Size = new Size(94, 61);
            label13.TabIndex = 12;
            label13.Text = "Precio";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(103, 124);
            label12.Margin = new Padding(3, 0, 3, 3);
            label12.Name = "label12";
            label12.Size = new Size(184, 59);
            label12.TabIndex = 11;
            label12.Text = "90";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(3, 124);
            label11.Margin = new Padding(3, 0, 3, 3);
            label11.Name = "label11";
            label11.Size = new Size(94, 59);
            label11.TabIndex = 10;
            label11.Text = "Duración";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(103, 62);
            label10.Margin = new Padding(3, 0, 3, 3);
            label10.Name = "label10";
            label10.Size = new Size(184, 59);
            label10.TabIndex = 9;
            label10.Text = "2D SUB";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 62);
            label9.Margin = new Padding(3, 0, 3, 3);
            label9.Name = "label9";
            label9.Size = new Size(94, 59);
            label9.TabIndex = 8;
            label9.Text = "Formato";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(103, 0);
            label8.Margin = new Padding(3, 0, 3, 3);
            label8.Name = "label8";
            label8.Size = new Size(184, 59);
            label8.TabIndex = 7;
            label8.Text = "Ejemplo";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 0);
            label7.Margin = new Padding(3, 0, 3, 3);
            label7.Name = "label7";
            label7.Size = new Size(94, 59);
            label7.TabIndex = 6;
            label7.Text = "ID Película";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { horas_funcion });
            tableLayoutPanel1.SetColumnSpan(dataGridView2, 2);
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(438, 78);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(284, 244);
            dataGridView2.TabIndex = 31;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // horas_funcion
            // 
            horas_funcion.HeaderText = "FUNCIONES DE SALA";
            horas_funcion.MinimumWidth = 6;
            horas_funcion.Name = "horas_funcion";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.EjemploCartelera;
            pictureBox1.Location = new Point(3, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 244);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(button1, 0, 0);
            tableLayoutPanel9.Controls.Add(button2, 0, 2);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(873, 78);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 4;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(144, 244);
            tableLayoutPanel9.TabIndex = 34;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(144, 50);
            button1.TabIndex = 33;
            button1.Text = "AGREGAR / ACTUALIZAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(0, 100);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(144, 50);
            button2.TabIndex = 34;
            button2.Text = "ELIMINAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // Tx_tab
            // 
            Tx_tab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Tx_tab.AutoSize = true;
            Tx_tab.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tx_tab.Location = new Point(3, 0);
            Tx_tab.Name = "Tx_tab";
            Tx_tab.Size = new Size(1024, 85);
            Tx_tab.TabIndex = 7;
            Tx_tab.Text = "AGREGAR / ACTUALIZAR FUNCIÓN";
            Tx_tab.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tlp_formulario
            // 
            Tlp_formulario.ColumnCount = 5;
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144F));
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_formulario.Controls.Add(button3, 1, 0);
            Tlp_formulario.Controls.Add(Tlp_estreno, 0, 0);
            Tlp_formulario.Dock = DockStyle.Fill;
            Tlp_formulario.Location = new Point(0, 85);
            Tlp_formulario.Margin = new Padding(0);
            Tlp_formulario.Name = "Tlp_formulario";
            Tlp_formulario.RowCount = 1;
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.Size = new Size(1030, 50);
            Tlp_formulario.TabIndex = 8;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(250, 11);
            button3.Margin = new Padding(0);
            button3.MaximumSize = new Size(144, 27);
            button3.MinimumSize = new Size(144, 27);
            button3.Name = "button3";
            button3.Size = new Size(144, 27);
            button3.TabIndex = 35;
            button3.Text = "REFRESCAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // Tlp_estreno
            // 
            Tlp_estreno.ColumnCount = 2;
            Tlp_estreno.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_estreno.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_estreno.Controls.Add(Tx_estreno, 0, 0);
            Tlp_estreno.Controls.Add(dateTimePicker1, 1, 0);
            Tlp_estreno.Dock = DockStyle.Fill;
            Tlp_estreno.Location = new Point(0, 0);
            Tlp_estreno.Margin = new Padding(0);
            Tlp_estreno.Name = "Tlp_estreno";
            Tlp_estreno.RowCount = 1;
            Tlp_estreno.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_estreno.Size = new Size(250, 50);
            Tlp_estreno.TabIndex = 22;
            // 
            // Tx_estreno
            // 
            Tx_estreno.AutoSize = true;
            Tx_estreno.Dock = DockStyle.Fill;
            Tx_estreno.Location = new Point(3, 0);
            Tx_estreno.Margin = new Padding(3, 0, 3, 3);
            Tx_estreno.Name = "Tx_estreno";
            Tx_estreno.Size = new Size(94, 47);
            Tx_estreno.TabIndex = 0;
            Tx_estreno.Text = "Fecha";
            Tx_estreno.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(103, 11);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(144, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // FrUcMantenimientoFuncion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            Controls.Add(tableLayoutPanel8);
            Margin = new Padding(0);
            MinimumSize = new Size(1050, 700);
            Name = "FrUcMantenimientoFuncion";
            Size = new Size(1050, 700);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel8.ResumeLayout(false);
            pnl_estatico.ResumeLayout(false);
            Tlp_tab.ResumeLayout(false);
            Tlp_tab.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel9.ResumeLayout(false);
            Tlp_formulario.ResumeLayout(false);
            Tlp_estreno.ResumeLayout(false);
            Tlp_estreno.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewImageColumn pelicula;
        private DataGridViewTextBoxColumn formato;
        private DataGridViewTextBoxColumn numero_sala;
        private DataGridViewTextBoxColumn tipo_sala;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn hora;
        private TableLayoutPanel tableLayoutPanel8;
        private Panel pnl_estatico;
        private TableLayoutPanel Tlp_tab;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label6;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label5;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private ComboBox comboBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private ComboBox Cb_genero;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn horas_funcion;
        private Label Tx_tab;
        private TableLayoutPanel Tlp_formulario;
        private TableLayoutPanel Tlp_estreno;
        private Label Tx_estreno;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel9;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
