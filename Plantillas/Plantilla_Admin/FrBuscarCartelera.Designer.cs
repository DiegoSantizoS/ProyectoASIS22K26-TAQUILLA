namespace Plantilla_Admin
{
    partial class FrBuscarCartelera
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Dgv_Cartelera = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Clasificación = new DataGridViewTextBoxColumn();
            Subtitulado = new DataGridViewTextBoxColumn();
            Idioma = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            label5 = new Label();
            textBox5 = new TextBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            label4 = new Label();
            textBox4 = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label3 = new Label();
            textBox3 = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label2 = new Label();
            textBox2 = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Cartelera).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Dgv_Cartelera, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Size = new Size(886, 508);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Dgv_Cartelera
            // 
            Dgv_Cartelera.AllowUserToDeleteRows = false;
            Dgv_Cartelera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Cartelera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Cartelera.Columns.AddRange(new DataGridViewColumn[] { id, Nombre, Clasificación, Subtitulado, Idioma });
            Dgv_Cartelera.Dock = DockStyle.Fill;
            Dgv_Cartelera.Location = new Point(3, 155);
            Dgv_Cartelera.Name = "Dgv_Cartelera";
            Dgv_Cartelera.ReadOnly = true;
            Dgv_Cartelera.RowHeadersWidth = 51;
            Dgv_Cartelera.Size = new Size(880, 350);
            Dgv_Cartelera.TabIndex = 0;
            Dgv_Cartelera.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Clasificación
            // 
            Clasificación.HeaderText = "Clasificación";
            Clasificación.MinimumWidth = 6;
            Clasificación.Name = "Clasificación";
            Clasificación.ReadOnly = true;
            // 
            // Subtitulado
            // 
            Subtitulado.HeaderText = "Subtitulado";
            Subtitulado.MinimumWidth = 6;
            Subtitulado.Name = "Subtitulado";
            Subtitulado.ReadOnly = true;
            // 
            // Idioma
            // 
            Idioma.HeaderText = "Idioma";
            Idioma.MinimumWidth = 6;
            Idioma.Name = "Idioma";
            Idioma.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.7388287F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 81.26117F));
            tableLayoutPanel2.Size = new Size(880, 146);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 1, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel9, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 30);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.Size = new Size(874, 113);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(label5, 0, 0);
            tableLayoutPanel8.Controls.Add(textBox5, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 77);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(431, 33);
            tableLayoutPanel8.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(209, 33);
            label5.TabIndex = 0;
            label5.Text = "IDIOMA";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(218, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(210, 27);
            textBox5.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(label4, 0, 0);
            tableLayoutPanel7.Controls.Add(textBox4, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(440, 40);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(431, 31);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(209, 31);
            label4.TabIndex = 0;
            label4.Text = "SUBTITULADO";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(218, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(210, 27);
            textBox4.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label3, 0, 0);
            tableLayoutPanel6.Controls.Add(textBox3, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 40);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(431, 31);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(209, 31);
            label3.TabIndex = 0;
            label3.Text = "CLASIFICACIÓN";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(218, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(210, 27);
            textBox3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(440, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(431, 31);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(209, 31);
            label2.TabIndex = 0;
            label2.Text = "NOMBRE";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(218, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 27);
            textBox2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(431, 31);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(209, 31);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(218, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 27);
            textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.Controls.Add(button3, 2, 0);
            tableLayoutPanel9.Controls.Add(button2, 1, 0);
            tableLayoutPanel9.Controls.Add(button1, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(440, 77);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(431, 33);
            tableLayoutPanel9.TabIndex = 5;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(289, 3);
            button3.Name = "button3";
            button3.Size = new Size(139, 27);
            button3.TabIndex = 2;
            button3.Text = "REFRESCAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(146, 3);
            button2.Name = "button2";
            button2.Size = new Size(137, 27);
            button2.TabIndex = 1;
            button2.Text = "ELIMINAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(137, 27);
            button1.TabIndex = 0;
            button1.Text = "ACTUALIZAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(874, 27);
            label6.TabIndex = 1;
            label6.Text = "VER CARTELERA";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrBuscarCartelera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "FrBuscarCartelera";
            Size = new Size(886, 508);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_Cartelera).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView Dgv_Cartelera;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Clasificación;
        private DataGridViewTextBoxColumn Subtitulado;
        private DataGridViewTextBoxColumn Idioma;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label5;
        private TextBox textBox5;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label4;
        private TextBox textBox4;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label3;
        private TextBox textBox3;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label2;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label6;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
