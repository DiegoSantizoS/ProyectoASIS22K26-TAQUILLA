namespace Plantilla_Admin
{
    partial class FrCuBuscarCartelera1
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
            Tlp_formularioTitulo = new TableLayoutPanel();
            Tlp_formulario = new TableLayoutPanel();
            Tlp_dgvFormato = new TableLayoutPanel();
            Dgv_formato = new DataGridView();
            Dgvc_nombre = new DataGridViewTextBoxColumn();
            Dgvb_borrar = new DataGridViewButtonColumn();
            Tlp_grupoFormato = new TableLayoutPanel();
            cb_formato = new ComboBox();
            Tx_formato = new Label();
            Btn_insertarFormato = new Button();
            Tlp_grupoGenero = new TableLayoutPanel();
            Cb_genero = new ComboBox();
            Tx_Genero = new Label();
            Btn_agregarGenero = new Button();
            button3 = new Button();
            Tlp_grupoNombre = new TableLayoutPanel();
            label2 = new Label();
            textBox2 = new TextBox();
            Tlp_grupoID = new TableLayoutPanel();
            Tx_id = new Label();
            Txt_id = new TextBox();
            Tlp_dgvGenero = new TableLayoutPanel();
            Dgv_genero = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Borrar = new DataGridViewButtonColumn();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Cartelera).BeginInit();
            Tlp_formularioTitulo.SuspendLayout();
            Tlp_formulario.SuspendLayout();
            Tlp_dgvFormato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_formato).BeginInit();
            Tlp_grupoFormato.SuspendLayout();
            Tlp_grupoGenero.SuspendLayout();
            Tlp_grupoNombre.SuspendLayout();
            Tlp_grupoID.SuspendLayout();
            Tlp_dgvGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_genero).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Dgv_Cartelera, 0, 1);
            tableLayoutPanel1.Controls.Add(Tlp_formularioTitulo, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1050, 700);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Dgv_Cartelera
            // 
            Dgv_Cartelera.AllowUserToDeleteRows = false;
            Dgv_Cartelera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Cartelera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Cartelera.Columns.AddRange(new DataGridViewColumn[] { id, Nombre, Clasificación, Subtitulado, Idioma });
            Dgv_Cartelera.Dock = DockStyle.Fill;
            Dgv_Cartelera.Location = new Point(3, 353);
            Dgv_Cartelera.Name = "Dgv_Cartelera";
            Dgv_Cartelera.ReadOnly = true;
            Dgv_Cartelera.RowHeadersWidth = 51;
            Dgv_Cartelera.Size = new Size(1044, 344);
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
            // Tlp_formularioTitulo
            // 
            Tlp_formularioTitulo.ColumnCount = 1;
            Tlp_formularioTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_formularioTitulo.Controls.Add(Tlp_formulario, 0, 1);
            Tlp_formularioTitulo.Controls.Add(label6, 0, 0);
            Tlp_formularioTitulo.Dock = DockStyle.Fill;
            Tlp_formularioTitulo.Location = new Point(0, 0);
            Tlp_formularioTitulo.Margin = new Padding(0, 0, 20, 20);
            Tlp_formularioTitulo.Name = "Tlp_formularioTitulo";
            Tlp_formularioTitulo.RowCount = 2;
            Tlp_formularioTitulo.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            Tlp_formularioTitulo.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            Tlp_formularioTitulo.Size = new Size(1030, 330);
            Tlp_formularioTitulo.TabIndex = 1;
            // 
            // Tlp_formulario
            // 
            Tlp_formulario.ColumnCount = 3;
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            Tlp_formulario.Controls.Add(Tlp_dgvFormato, 1, 2);
            Tlp_formulario.Controls.Add(Tlp_grupoFormato, 1, 1);
            Tlp_formulario.Controls.Add(Tlp_grupoGenero, 0, 1);
            Tlp_formulario.Controls.Add(button3, 2, 0);
            Tlp_formulario.Controls.Add(Tlp_grupoNombre, 0, 0);
            Tlp_formulario.Controls.Add(Tlp_grupoID, 1, 0);
            Tlp_formulario.Controls.Add(Tlp_dgvGenero, 0, 2);
            Tlp_formulario.Controls.Add(button2, 2, 3);
            Tlp_formulario.Controls.Add(button1, 2, 2);
            Tlp_formulario.Dock = DockStyle.Fill;
            Tlp_formulario.Location = new Point(0, 75);
            Tlp_formulario.Margin = new Padding(0);
            Tlp_formulario.Name = "Tlp_formulario";
            Tlp_formulario.RowCount = 4;
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.Size = new Size(1030, 255);
            Tlp_formulario.TabIndex = 0;
            // 
            // Tlp_dgvFormato
            // 
            Tlp_dgvFormato.ColumnCount = 2;
            Tlp_dgvFormato.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            Tlp_dgvFormato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_dgvFormato.Controls.Add(Dgv_formato, 1, 0);
            Tlp_dgvFormato.Dock = DockStyle.Fill;
            Tlp_dgvFormato.Location = new Point(445, 100);
            Tlp_dgvFormato.Margin = new Padding(0);
            Tlp_dgvFormato.Name = "Tlp_dgvFormato";
            Tlp_dgvFormato.RowCount = 1;
            Tlp_formulario.SetRowSpan(Tlp_dgvFormato, 3);
            Tlp_dgvFormato.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_dgvFormato.Size = new Size(445, 155);
            Tlp_dgvFormato.TabIndex = 21;
            // 
            // Dgv_formato
            // 
            Dgv_formato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_formato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_formato.Columns.AddRange(new DataGridViewColumn[] { Dgvc_nombre, Dgvb_borrar });
            Dgv_formato.Dock = DockStyle.Fill;
            Dgv_formato.Location = new Point(80, 0);
            Dgv_formato.Margin = new Padding(0);
            Dgv_formato.Name = "Dgv_formato";
            Dgv_formato.RowHeadersWidth = 51;
            Dgv_formato.Size = new Size(365, 155);
            Dgv_formato.TabIndex = 16;
            // 
            // Dgvc_nombre
            // 
            Dgvc_nombre.FillWeight = 200F;
            Dgvc_nombre.HeaderText = "Nombre";
            Dgvc_nombre.MinimumWidth = 6;
            Dgvc_nombre.Name = "Dgvc_nombre";
            // 
            // Dgvb_borrar
            // 
            Dgvb_borrar.HeaderText = "Borrar";
            Dgvb_borrar.MinimumWidth = 6;
            Dgvb_borrar.Name = "Dgvb_borrar";
            // 
            // Tlp_grupoFormato
            // 
            Tlp_grupoFormato.ColumnCount = 3;
            Tlp_grupoFormato.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            Tlp_grupoFormato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_grupoFormato.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_grupoFormato.Controls.Add(cb_formato, 1, 0);
            Tlp_grupoFormato.Controls.Add(Tx_formato, 0, 0);
            Tlp_grupoFormato.Controls.Add(Btn_insertarFormato, 2, 0);
            Tlp_grupoFormato.Dock = DockStyle.Fill;
            Tlp_grupoFormato.Location = new Point(445, 50);
            Tlp_grupoFormato.Margin = new Padding(0);
            Tlp_grupoFormato.Name = "Tlp_grupoFormato";
            Tlp_grupoFormato.RowCount = 1;
            Tlp_grupoFormato.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_grupoFormato.Size = new Size(445, 50);
            Tlp_grupoFormato.TabIndex = 19;
            // 
            // cb_formato
            // 
            cb_formato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_formato.FormattingEnabled = true;
            cb_formato.Location = new Point(83, 11);
            cb_formato.Name = "cb_formato";
            cb_formato.Size = new Size(259, 28);
            cb_formato.TabIndex = 3;
            // 
            // Tx_formato
            // 
            Tx_formato.AutoSize = true;
            Tx_formato.Dock = DockStyle.Fill;
            Tx_formato.Location = new Point(3, 0);
            Tx_formato.Margin = new Padding(3, 0, 3, 3);
            Tx_formato.Name = "Tx_formato";
            Tx_formato.Size = new Size(74, 47);
            Tx_formato.TabIndex = 0;
            Tx_formato.Text = "Formato";
            Tx_formato.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Btn_insertarFormato
            // 
            Btn_insertarFormato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Btn_insertarFormato.Location = new Point(345, 10);
            Btn_insertarFormato.Margin = new Padding(0);
            Btn_insertarFormato.Name = "Btn_insertarFormato";
            Btn_insertarFormato.Size = new Size(100, 30);
            Btn_insertarFormato.TabIndex = 2;
            Btn_insertarFormato.Text = "Agregar";
            Btn_insertarFormato.UseVisualStyleBackColor = true;
            // 
            // Tlp_grupoGenero
            // 
            Tlp_grupoGenero.ColumnCount = 3;
            Tlp_grupoGenero.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            Tlp_grupoGenero.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_grupoGenero.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_grupoGenero.Controls.Add(Cb_genero, 1, 0);
            Tlp_grupoGenero.Controls.Add(Tx_Genero, 0, 0);
            Tlp_grupoGenero.Controls.Add(Btn_agregarGenero, 2, 0);
            Tlp_grupoGenero.Dock = DockStyle.Fill;
            Tlp_grupoGenero.Location = new Point(0, 50);
            Tlp_grupoGenero.Margin = new Padding(0);
            Tlp_grupoGenero.Name = "Tlp_grupoGenero";
            Tlp_grupoGenero.RowCount = 1;
            Tlp_grupoGenero.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_grupoGenero.Size = new Size(445, 50);
            Tlp_grupoGenero.TabIndex = 16;
            // 
            // Cb_genero
            // 
            Cb_genero.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Cb_genero.FormattingEnabled = true;
            Cb_genero.Location = new Point(83, 11);
            Cb_genero.Name = "Cb_genero";
            Cb_genero.Size = new Size(259, 28);
            Cb_genero.TabIndex = 3;
            // 
            // Tx_Genero
            // 
            Tx_Genero.AutoSize = true;
            Tx_Genero.Dock = DockStyle.Fill;
            Tx_Genero.Location = new Point(3, 0);
            Tx_Genero.Margin = new Padding(3, 0, 3, 3);
            Tx_Genero.Name = "Tx_Genero";
            Tx_Genero.Size = new Size(74, 47);
            Tx_Genero.TabIndex = 0;
            Tx_Genero.Text = "Genero";
            Tx_Genero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Btn_agregarGenero
            // 
            Btn_agregarGenero.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Btn_agregarGenero.Location = new Point(345, 10);
            Btn_agregarGenero.Margin = new Padding(0);
            Btn_agregarGenero.Name = "Btn_agregarGenero";
            Btn_agregarGenero.Size = new Size(100, 30);
            Btn_agregarGenero.TabIndex = 2;
            Btn_agregarGenero.Text = "Agregar";
            Btn_agregarGenero.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Location = new Point(913, 3);
            button3.Name = "button3";
            button3.Size = new Size(114, 44);
            button3.TabIndex = 2;
            button3.Text = "REFRESCAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // Tlp_grupoNombre
            // 
            Tlp_grupoNombre.ColumnCount = 2;
            Tlp_grupoNombre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            Tlp_grupoNombre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_grupoNombre.Controls.Add(label2, 0, 0);
            Tlp_grupoNombre.Controls.Add(textBox2, 1, 0);
            Tlp_grupoNombre.Dock = DockStyle.Fill;
            Tlp_grupoNombre.Location = new Point(0, 0);
            Tlp_grupoNombre.Margin = new Padding(0);
            Tlp_grupoNombre.Name = "Tlp_grupoNombre";
            Tlp_grupoNombre.RowCount = 1;
            Tlp_grupoNombre.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_grupoNombre.Size = new Size(445, 50);
            Tlp_grupoNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 50);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(83, 11);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(359, 27);
            textBox2.TabIndex = 1;
            // 
            // Tlp_grupoID
            // 
            Tlp_grupoID.ColumnCount = 2;
            Tlp_grupoID.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            Tlp_grupoID.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_grupoID.Controls.Add(Tx_id, 0, 0);
            Tlp_grupoID.Controls.Add(Txt_id, 1, 0);
            Tlp_grupoID.Dock = DockStyle.Fill;
            Tlp_grupoID.Location = new Point(445, 0);
            Tlp_grupoID.Margin = new Padding(0);
            Tlp_grupoID.Name = "Tlp_grupoID";
            Tlp_grupoID.RowCount = 1;
            Tlp_grupoID.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_grupoID.Size = new Size(445, 50);
            Tlp_grupoID.TabIndex = 0;
            // 
            // Tx_id
            // 
            Tx_id.AutoSize = true;
            Tx_id.Dock = DockStyle.Fill;
            Tx_id.Location = new Point(3, 0);
            Tx_id.Name = "Tx_id";
            Tx_id.Size = new Size(74, 50);
            Tx_id.TabIndex = 0;
            Tx_id.Text = "ID";
            Tx_id.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Txt_id
            // 
            Txt_id.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Txt_id.Location = new Point(83, 11);
            Txt_id.Name = "Txt_id";
            Txt_id.Size = new Size(359, 27);
            Txt_id.TabIndex = 1;
            // 
            // Tlp_dgvGenero
            // 
            Tlp_dgvGenero.ColumnCount = 2;
            Tlp_dgvGenero.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            Tlp_dgvGenero.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_dgvGenero.Controls.Add(Dgv_genero, 1, 0);
            Tlp_dgvGenero.Dock = DockStyle.Fill;
            Tlp_dgvGenero.Location = new Point(0, 100);
            Tlp_dgvGenero.Margin = new Padding(0);
            Tlp_dgvGenero.Name = "Tlp_dgvGenero";
            Tlp_dgvGenero.RowCount = 1;
            Tlp_formulario.SetRowSpan(Tlp_dgvGenero, 3);
            Tlp_dgvGenero.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_dgvGenero.Size = new Size(445, 155);
            Tlp_dgvGenero.TabIndex = 20;
            // 
            // Dgv_genero
            // 
            Dgv_genero.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_genero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_genero.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Borrar });
            Dgv_genero.Dock = DockStyle.Fill;
            Dgv_genero.Location = new Point(80, 0);
            Dgv_genero.Margin = new Padding(0);
            Dgv_genero.Name = "Dgv_genero";
            Dgv_genero.RowHeadersWidth = 51;
            Dgv_genero.Size = new Size(365, 155);
            Dgv_genero.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 200F;
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Borrar
            // 
            Borrar.HeaderText = "Borrar";
            Borrar.MinimumWidth = 6;
            Borrar.Name = "Borrar";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(913, 153);
            button2.Name = "button2";
            button2.Size = new Size(114, 44);
            button2.TabIndex = 1;
            button2.Text = "ELIMINAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(913, 103);
            button1.Name = "button1";
            button1.Size = new Size(114, 44);
            button1.TabIndex = 0;
            button1.Text = "ACTUALIZAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 19.8000011F);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(1024, 75);
            label6.TabIndex = 1;
            label6.Text = "BUSCAR CARTELERA";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrCuBuscarCartelera1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "FrCuBuscarCartelera1";
            Size = new Size(1050, 700);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_Cartelera).EndInit();
            Tlp_formularioTitulo.ResumeLayout(false);
            Tlp_formularioTitulo.PerformLayout();
            Tlp_formulario.ResumeLayout(false);
            Tlp_dgvFormato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_formato).EndInit();
            Tlp_grupoFormato.ResumeLayout(false);
            Tlp_grupoFormato.PerformLayout();
            Tlp_grupoGenero.ResumeLayout(false);
            Tlp_grupoGenero.PerformLayout();
            Tlp_grupoNombre.ResumeLayout(false);
            Tlp_grupoNombre.PerformLayout();
            Tlp_grupoID.ResumeLayout(false);
            Tlp_grupoID.PerformLayout();
            Tlp_dgvGenero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_genero).EndInit();
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
        private TableLayoutPanel Tlp_formularioTitulo;
        private TableLayoutPanel Tlp_formulario;
        private TableLayoutPanel Tlp_grupoID;
        private Label Tx_id;
        private TextBox Txt_id;
        private TableLayoutPanel Tlp_grupoNombre;
        private Label label2;
        private TextBox textBox2;
        private Label label6;
        private Button button3;
        private Button button2;
        private Button button1;
        private TableLayoutPanel Tlp_grupoGenero;
        private ComboBox Cb_genero;
        private Label Tx_Genero;
        private Button Btn_agregarGenero;
        private TableLayoutPanel Tlp_grupoFormato;
        private ComboBox cb_formato;
        private Label Tx_formato;
        private Button Btn_insertarFormato;
        private TableLayoutPanel Tlp_dgvGenero;
        private DataGridView Dgv_genero;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewButtonColumn Borrar;
        private TableLayoutPanel Tlp_dgvFormato;
        private DataGridView Dgv_formato;
        private DataGridViewTextBoxColumn Dgvc_nombre;
        private DataGridViewButtonColumn Dgvb_borrar;
    }
}
