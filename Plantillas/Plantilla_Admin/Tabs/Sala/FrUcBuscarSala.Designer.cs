namespace Plantilla_Admin.Tabs.Sala
{
    partial class FrUcBuscarSala
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
            panel1 = new Panel();
            Btn_eliminar = new Button();
            Btn_agregar = new Button();
            Btn_agregarNuevaCartelera = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            comboBox2 = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            Tlp_estado = new TableLayoutPanel();
            Tx_Estado = new Label();
            Cb_estado = new ComboBox();
            Tlp_id = new TableLayoutPanel();
            Txt_id = new TextBox();
            Tx_id = new Label();
            Tx_tab = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            Tlp_estado.SuspendLayout();
            Tlp_id.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1050F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1050, 700);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(Btn_eliminar);
            panel1.Controls.Add(Btn_agregar);
            panel1.Controls.Add(Btn_agregarNuevaCartelera);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(Tlp_estado);
            panel1.Controls.Add(Tlp_id);
            panel1.Controls.Add(Tx_tab);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 300);
            panel1.TabIndex = 0;
            // 
            // Btn_eliminar
            // 
            Btn_eliminar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Btn_eliminar.Location = new Point(227, 200);
            Btn_eliminar.Margin = new Padding(0, 50, 0, 50);
            Btn_eliminar.Name = "Btn_eliminar";
            Btn_eliminar.Size = new Size(100, 50);
            Btn_eliminar.TabIndex = 28;
            Btn_eliminar.Text = "ELIMINAR";
            Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_agregar
            // 
            Btn_agregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Btn_agregar.Location = new Point(114, 200);
            Btn_agregar.Margin = new Padding(0, 50, 0, 50);
            Btn_agregar.Name = "Btn_agregar";
            Btn_agregar.Size = new Size(100, 50);
            Btn_agregar.TabIndex = 27;
            Btn_agregar.Text = "AGREGAR";
            Btn_agregar.UseVisualStyleBackColor = true;
            // 
            // Btn_agregarNuevaCartelera
            // 
            Btn_agregarNuevaCartelera.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Btn_agregarNuevaCartelera.Location = new Point(848, 79);
            Btn_agregarNuevaCartelera.Margin = new Padding(0, 50, 0, 50);
            Btn_agregarNuevaCartelera.Name = "Btn_agregarNuevaCartelera";
            Btn_agregarNuevaCartelera.Size = new Size(100, 50);
            Btn_agregarNuevaCartelera.TabIndex = 26;
            Btn_agregarNuevaCartelera.Text = "REFRESCAR";
            Btn_agregarNuevaCartelera.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(comboBox2, 1, 0);
            tableLayoutPanel2.Location = new Point(404, 132);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(393, 50);
            tableLayoutPanel2.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.ImageAlign = ContentAlignment.TopRight;
            label1.Location = new Point(3, 0);
            label1.Margin = new Padding(3, 0, 3, 3);
            label1.Name = "label1";
            label1.Size = new Size(94, 47);
            label1.TabIndex = 0;
            label1.Text = "Filas";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(103, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(287, 28);
            comboBox2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel3.Location = new Point(11, 132);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(393, 50);
            tableLayoutPanel3.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.ImageAlign = ContentAlignment.TopRight;
            label2.Location = new Point(3, 0);
            label2.Margin = new Padding(3, 0, 3, 3);
            label2.Name = "label2";
            label2.Size = new Size(94, 47);
            label2.TabIndex = 0;
            label2.Text = "Número de Sala";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(103, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(287, 28);
            comboBox1.TabIndex = 1;
            // 
            // Tlp_estado
            // 
            Tlp_estado.ColumnCount = 2;
            Tlp_estado.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_estado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_estado.Controls.Add(Tx_Estado, 0, 0);
            Tlp_estado.Controls.Add(Cb_estado, 1, 0);
            Tlp_estado.Location = new Point(404, 82);
            Tlp_estado.Margin = new Padding(0);
            Tlp_estado.Name = "Tlp_estado";
            Tlp_estado.RowCount = 1;
            Tlp_estado.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_estado.Size = new Size(393, 50);
            Tlp_estado.TabIndex = 23;
            // 
            // Tx_Estado
            // 
            Tx_Estado.AutoSize = true;
            Tx_Estado.Dock = DockStyle.Fill;
            Tx_Estado.ImageAlign = ContentAlignment.TopRight;
            Tx_Estado.Location = new Point(3, 0);
            Tx_Estado.Margin = new Padding(3, 0, 3, 3);
            Tx_Estado.Name = "Tx_Estado";
            Tx_Estado.Size = new Size(94, 47);
            Tx_Estado.TabIndex = 0;
            Tx_Estado.Text = "Tipo";
            Tx_Estado.TextAlign = ContentAlignment.TopRight;
            // 
            // Cb_estado
            // 
            Cb_estado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Cb_estado.FormattingEnabled = true;
            Cb_estado.Location = new Point(103, 3);
            Cb_estado.Name = "Cb_estado";
            Cb_estado.Size = new Size(287, 28);
            Cb_estado.TabIndex = 1;
            // 
            // Tlp_id
            // 
            Tlp_id.ColumnCount = 2;
            Tlp_id.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_id.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_id.Controls.Add(Txt_id, 1, 0);
            Tlp_id.Controls.Add(Tx_id, 0, 0);
            Tlp_id.Location = new Point(11, 82);
            Tlp_id.Margin = new Padding(0);
            Tlp_id.Name = "Tlp_id";
            Tlp_id.RowCount = 1;
            Tlp_id.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_id.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_id.Size = new Size(393, 50);
            Tlp_id.TabIndex = 21;
            // 
            // Txt_id
            // 
            Txt_id.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_id.Location = new Point(103, 3);
            Txt_id.Name = "Txt_id";
            Txt_id.Size = new Size(287, 27);
            Txt_id.TabIndex = 3;
            // 
            // Tx_id
            // 
            Tx_id.AutoSize = true;
            Tx_id.Dock = DockStyle.Fill;
            Tx_id.Location = new Point(3, 0);
            Tx_id.Margin = new Padding(3, 0, 3, 3);
            Tx_id.Name = "Tx_id";
            Tx_id.Size = new Size(94, 47);
            Tx_id.TabIndex = 0;
            Tx_id.Text = "ID";
            Tx_id.TextAlign = ContentAlignment.TopRight;
            // 
            // Tx_tab
            // 
            Tx_tab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Tx_tab.AutoSize = true;
            Tx_tab.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tx_tab.Location = new Point(0, 10);
            Tx_tab.Name = "Tx_tab";
            Tx_tab.Size = new Size(117, 46);
            Tx_tab.TabIndex = 7;
            Tx_tab.Text = "SALAS";
            Tx_tab.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new Point(0, 303);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1050, 397);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // FrUcBuscarSala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            MinimumSize = new Size(1050, 700);
            Name = "FrUcBuscarSala";
            Size = new Size(1050, 700);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            Tlp_estado.ResumeLayout(false);
            Tlp_estado.PerformLayout();
            Tlp_id.ResumeLayout(false);
            Tlp_id.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label Tx_tab;
        private TableLayoutPanel Tlp_id;
        private TextBox Txt_id;
        private Label Tx_id;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private ComboBox comboBox1;
        private TableLayoutPanel Tlp_estado;
        private Label Tx_Estado;
        private ComboBox Cb_estado;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private ComboBox comboBox2;
        private Button Btn_eliminar;
        private Button Btn_agregar;
        private Button Btn_agregarNuevaCartelera;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
    }
}
