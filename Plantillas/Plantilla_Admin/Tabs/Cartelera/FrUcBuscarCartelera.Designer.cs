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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            Dgv_cartelera = new DataGridView();
            Tlp_formularioTitulo = new TableLayoutPanel();
            Tlp_formulario = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            Cb_estado = new ComboBox();
            Tx_estado = new Label();
            Tlp_grupoNombre = new TableLayoutPanel();
            label2 = new Label();
            Txt_nombre = new TextBox();
            Tlp_grupoID = new TableLayoutPanel();
            Tx_id = new Label();
            Txt_id = new TextBox();
            Btn_eliminar = new Button();
            Btn_actualizar = new Button();
            label6 = new Label();
            conexionBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_cartelera).BeginInit();
            Tlp_formularioTitulo.SuspendLayout();
            Tlp_formulario.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            Tlp_grupoNombre.SuspendLayout();
            Tlp_grupoID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Dgv_cartelera, 0, 1);
            tableLayoutPanel1.Controls.Add(Tlp_formularioTitulo, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1050, 700);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Dgv_cartelera
            // 
            Dgv_cartelera.AllowUserToDeleteRows = false;
            Dgv_cartelera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_cartelera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_cartelera.Dock = DockStyle.Fill;
            Dgv_cartelera.Location = new Point(3, 303);
            Dgv_cartelera.Name = "Dgv_cartelera";
            Dgv_cartelera.ReadOnly = true;
            Dgv_cartelera.RowHeadersWidth = 51;
            Dgv_cartelera.Size = new Size(1044, 394);
            Dgv_cartelera.TabIndex = 0;
            Dgv_cartelera.CellClick += Dgv_cartelera_CellClick;
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
            Tlp_formularioTitulo.Size = new Size(1030, 280);
            Tlp_formularioTitulo.TabIndex = 1;
            // 
            // Tlp_formulario
            // 
            Tlp_formulario.ColumnCount = 3;
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            Tlp_formulario.Controls.Add(tableLayoutPanel2, 0, 2);
            Tlp_formulario.Controls.Add(Tlp_grupoNombre, 1, 0);
            Tlp_formulario.Controls.Add(Tlp_grupoID, 0, 0);
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
            Tlp_formulario.Size = new Size(1030, 205);
            Tlp_formulario.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(Cb_estado, 1, 0);
            tableLayoutPanel2.Controls.Add(Tx_estado, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 100);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(445, 50);
            tableLayoutPanel2.TabIndex = 20;
            // 
            // Cb_estado
            // 
            Cb_estado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Cb_estado.FormattingEnabled = true;
            Cb_estado.Location = new Point(83, 11);
            Cb_estado.Name = "Cb_estado";
            Cb_estado.Size = new Size(359, 28);
            Cb_estado.TabIndex = 3;
            // 
            // Tx_estado
            // 
            Tx_estado.AutoSize = true;
            Tx_estado.Dock = DockStyle.Fill;
            Tx_estado.Location = new Point(3, 0);
            Tx_estado.Margin = new Padding(3, 0, 3, 3);
            Tx_estado.Name = "Tx_estado";
            Tx_estado.Size = new Size(74, 47);
            Tx_estado.TabIndex = 0;
            Tx_estado.Text = "Estado";
            Tx_estado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tlp_grupoNombre
            // 
            Tlp_grupoNombre.ColumnCount = 2;
            Tlp_grupoNombre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            Tlp_grupoNombre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_grupoNombre.Controls.Add(label2, 0, 0);
            Tlp_grupoNombre.Controls.Add(Txt_nombre, 1, 0);
            Tlp_grupoNombre.Dock = DockStyle.Fill;
            Tlp_grupoNombre.Location = new Point(445, 0);
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
            Tlp_grupoID.Location = new Point(0, 0);
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
            // Btn_eliminar
            // 
            Btn_eliminar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_eliminar.Location = new Point(913, 153);
            Btn_eliminar.Name = "Btn_eliminar";
            Btn_eliminar.Size = new Size(114, 49);
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
            Btn_actualizar.Click += Btn_actualizar_Click;
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
            // conexionBindingSource
            // 
            conexionBindingSource.DataSource = typeof(clase_conexion.conexion);
            // 
            // FrCuBuscarCartelera1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "FrCuBuscarCartelera1";
            Size = new Size(1050, 700);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_cartelera).EndInit();
            Tlp_formularioTitulo.ResumeLayout(false);
            Tlp_formularioTitulo.PerformLayout();
            Tlp_formulario.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            Tlp_grupoNombre.ResumeLayout(false);
            Tlp_grupoNombre.PerformLayout();
            Tlp_grupoID.ResumeLayout(false);
            Tlp_grupoID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView Dgv_cartelera;
        private TableLayoutPanel Tlp_formularioTitulo;
        private TableLayoutPanel Tlp_formulario;
        private TableLayoutPanel Tlp_grupoID;
        private Label Tx_id;
        private TextBox Txt_id;
        private TableLayoutPanel Tlp_grupoNombre;
        private Label label2;
        private TextBox Txt_nombre;
        private Label label6;
        private Button Btn_eliminar;
        private Button Btn_actualizar;
        private BindingSource conexionBindingSource;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox Cb_estado;
        private Label Tx_estado;
    }
}
