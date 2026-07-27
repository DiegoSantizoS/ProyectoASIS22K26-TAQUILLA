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
            Tlp_formularioTitulo = new TableLayoutPanel();
            Tlp_formulario = new TableLayoutPanel();
            Tlp_dgvFormato = new TableLayoutPanel();
            Dgv_formato = new DataGridView();
            Dgvc_nombre = new DataGridViewTextBoxColumn();
            Dgvb_formatoQuitar = new DataGridViewButtonColumn();
            Tlp_grupoFormato = new TableLayoutPanel();
            Cb_formato = new ComboBox();
            Tx_formato = new Label();
            Btn_agregarFormato = new Button();
            Tlp_grupoGenero = new TableLayoutPanel();
            Cb_genero = new ComboBox();
            Tx_Genero = new Label();
            Btn_agregarGenero = new Button();
            Btn_buscar = new Button();
            Tlp_grupoNombre = new TableLayoutPanel();
            label2 = new Label();
            Txt_nombre = new TextBox();
            Tlp_grupoID = new TableLayoutPanel();
            Tx_id = new Label();
            Txt_id = new TextBox();
            Tlp_dgvGenero = new TableLayoutPanel();
            Dgv_genero = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Dgvb_generoQuitar = new DataGridViewButtonColumn();
            Btn_eliminar = new Button();
            Btn_actualizar = new Button();
            label6 = new Label();
            id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            formato = new DataGridViewTextBoxColumn();
            genero = new DataGridViewTextBoxColumn();
            estreno = new DataGridViewTextBoxColumn();
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
            Dgv_Cartelera.Columns.AddRange(new DataGridViewColumn[] { id, Nombre, formato, genero, estreno });
            Dgv_Cartelera.Dock = DockStyle.Fill;
            Dgv_Cartelera.Location = new Point(3, 353);
            Dgv_Cartelera.Name = "Dgv_Cartelera";
            Dgv_Cartelera.ReadOnly = true;
            Dgv_Cartelera.RowHeadersWidth = 51;
            Dgv_Cartelera.Size = new Size(1044, 344);
            Dgv_Cartelera.TabIndex = 0;
            Dgv_Cartelera.CellContentClick += dataGridView1_CellContentClick;
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
            Tlp_formulario.Controls.Add(Btn_buscar, 2, 0);
            Tlp_formulario.Controls.Add(Tlp_grupoNombre, 0, 0);
            Tlp_formulario.Controls.Add(Tlp_grupoID, 1, 0);
            Tlp_formulario.Controls.Add(Tlp_dgvGenero, 0, 2);
            Tlp_formulario.Controls.Add(Btn_eliminar, 2, 3);
            Tlp_formulario.Controls.Add(Btn_actualizar, 2, 2);
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
            Dgv_formato.Columns.AddRange(new DataGridViewColumn[] { Dgvc_nombre, Dgvb_formatoQuitar });
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
            // Dgvb_formatoQuitar
            // 
            Dgvb_formatoQuitar.HeaderText = "Quitar";
            Dgvb_formatoQuitar.MinimumWidth = 6;
            Dgvb_formatoQuitar.Name = "Dgvb_formatoQuitar";
            // 
            // Tlp_grupoFormato
            // 
            Tlp_grupoFormato.ColumnCount = 3;
            Tlp_grupoFormato.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            Tlp_grupoFormato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_grupoFormato.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_grupoFormato.Controls.Add(Cb_formato, 1, 0);
            Tlp_grupoFormato.Controls.Add(Tx_formato, 0, 0);
            Tlp_grupoFormato.Controls.Add(Btn_agregarFormato, 2, 0);
            Tlp_grupoFormato.Dock = DockStyle.Fill;
            Tlp_grupoFormato.Location = new Point(445, 50);
            Tlp_grupoFormato.Margin = new Padding(0);
            Tlp_grupoFormato.Name = "Tlp_grupoFormato";
            Tlp_grupoFormato.RowCount = 1;
            Tlp_grupoFormato.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_grupoFormato.Size = new Size(445, 50);
            Tlp_grupoFormato.TabIndex = 19;
            // 
            // Cb_formato
            // 
            Cb_formato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Cb_formato.FormattingEnabled = true;
            Cb_formato.Location = new Point(83, 11);
            Cb_formato.Name = "Cb_formato";
            Cb_formato.Size = new Size(259, 28);
            Cb_formato.TabIndex = 3;
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
            // Btn_agregarFormato
            // 
            Btn_agregarFormato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Btn_agregarFormato.Location = new Point(345, 10);
            Btn_agregarFormato.Margin = new Padding(0);
            Btn_agregarFormato.Name = "Btn_agregarFormato";
            Btn_agregarFormato.Size = new Size(100, 30);
            Btn_agregarFormato.TabIndex = 2;
            Btn_agregarFormato.Text = "Agregar";
            Btn_agregarFormato.UseVisualStyleBackColor = true;
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
            // Btn_buscar
            // 
            Btn_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_buscar.Location = new Point(913, 3);
            Btn_buscar.Name = "Btn_buscar";
            Btn_buscar.Size = new Size(114, 44);
            Btn_buscar.TabIndex = 2;
            Btn_buscar.Text = "BUSCAR";
            Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Tlp_grupoNombre
            // 
            Tlp_grupoNombre.ColumnCount = 2;
            Tlp_grupoNombre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            Tlp_grupoNombre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_grupoNombre.Controls.Add(label2, 0, 0);
            Tlp_grupoNombre.Controls.Add(Txt_nombre, 1, 0);
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
            // Txt_nombre
            // 
            Txt_nombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Txt_nombre.Location = new Point(83, 11);
            Txt_nombre.Name = "Txt_nombre";
            Txt_nombre.Size = new Size(359, 27);
            Txt_nombre.TabIndex = 1;
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
            Dgv_genero.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Dgvb_generoQuitar });
            Dgv_genero.Dock = DockStyle.Fill;
            Dgv_genero.Location = new Point(80, 0);
            Dgv_genero.Margin = new Padding(0);
            Dgv_genero.Name = "Dgv_genero";
            Dgv_genero.RowHeadersWidth = 51;
            Dgv_genero.Size = new Size(365, 155);
            Dgv_genero.TabIndex = 16;
            Dgv_genero.CellContentClick += Dgv_genero_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 200F;
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Dgvb_generoQuitar
            // 
            Dgvb_generoQuitar.HeaderText = "Quitar";
            Dgvb_generoQuitar.MinimumWidth = 6;
            Dgvb_generoQuitar.Name = "Dgvb_generoQuitar";
            // 
            // Btn_eliminar
            // 
            Btn_eliminar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_eliminar.Location = new Point(913, 153);
            Btn_eliminar.Name = "Btn_eliminar";
            Btn_eliminar.Size = new Size(114, 44);
            Btn_eliminar.TabIndex = 1;
            Btn_eliminar.Text = "ELIMINAR";
            Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_actualizar
            // 
            Btn_actualizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_actualizar.Location = new Point(913, 103);
            Btn_actualizar.Name = "Btn_actualizar";
            Btn_actualizar.Size = new Size(114, 44);
            Btn_actualizar.TabIndex = 0;
            Btn_actualizar.Text = "ACTUALIZAR";
            Btn_actualizar.UseVisualStyleBackColor = true;
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
            // formato
            // 
            formato.HeaderText = "Formato";
            formato.MinimumWidth = 6;
            formato.Name = "formato";
            formato.ReadOnly = true;
            // 
            // genero
            // 
            genero.HeaderText = "Generos";
            genero.MinimumWidth = 6;
            genero.Name = "genero";
            genero.ReadOnly = true;
            // 
            // estreno
            // 
            estreno.HeaderText = "Fecha de Estreno";
            estreno.MinimumWidth = 6;
            estreno.Name = "estreno";
            estreno.ReadOnly = true;
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
        private TableLayoutPanel Tlp_formularioTitulo;
        private TableLayoutPanel Tlp_formulario;
        private TableLayoutPanel Tlp_grupoID;
        private Label Tx_id;
        private TextBox Txt_id;
        private TableLayoutPanel Tlp_grupoNombre;
        private Label label2;
        private TextBox Txt_nombre;
        private Label label6;
        private Button Btn_buscar;
        private Button Btn_eliminar;
        private Button Btn_actualizar;
        private TableLayoutPanel Tlp_grupoGenero;
        private ComboBox Cb_genero;
        private Label Tx_Genero;
        private Button Btn_agregarGenero;
        private TableLayoutPanel Tlp_grupoFormato;
        private ComboBox Cb_formato;
        private Label Tx_formato;
        private Button Btn_agregarFormato;
        private TableLayoutPanel Tlp_dgvGenero;
        private DataGridView Dgv_genero;
        private TableLayoutPanel Tlp_dgvFormato;
        private DataGridView Dgv_formato;
        private DataGridViewTextBoxColumn Dgvc_nombre;
        private DataGridViewButtonColumn Dgvb_formatoQuitar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewButtonColumn Dgvb_generoQuitar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn formato;
        private DataGridViewTextBoxColumn genero;
        private DataGridViewTextBoxColumn estreno;
    }
}
