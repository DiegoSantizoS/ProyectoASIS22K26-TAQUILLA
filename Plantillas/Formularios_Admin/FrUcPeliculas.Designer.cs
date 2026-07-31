namespace Formularios_Admin
{
    partial class FrUcPeliculas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TlpDivFormAndDgv = new TableLayoutPanel();
            TlpAux1 = new TableLayoutPanel();
            TlpAux2 = new TableLayoutPanel();
            TlpFormWithButtons = new TableLayoutPanel();
            BtnLimpiar = new Componentes.CustomButton();
            TlpForm = new TableLayoutPanel();
            TbDescripcion = new Componentes.CustomTextBox();
            LbID = new Componentes.CustomLabel();
            LbDirector = new Componentes.CustomLabel();
            LbPelicula = new Componentes.CustomLabel();
            LbTrailer = new Componentes.CustomLabel();
            LbDuracion = new Componentes.CustomLabel();
            LbClasificacion = new Componentes.CustomLabel();
            LbGeneros = new Componentes.CustomLabel();
            LbFormatos = new Componentes.CustomLabel();
            LbEstreno = new Componentes.CustomLabel();
            LbEstado = new Componentes.CustomLabel();
            LbDescripcion = new Componentes.CustomLabel();
            TbTitulo = new Componentes.CustomTextBox();
            TbDuracion = new Componentes.CustomTextBox();
            TbDirector = new Componentes.CustomTextBox();
            TbTrailer = new Componentes.CustomTextBox();
            TbID = new Componentes.CustomIDTextBox();
            CbEstado = new Componentes.CustomComboBox();
            ListBoxFormatos = new Krypton.Toolkit.KryptonListBox();
            ListBoxGeneros = new Krypton.Toolkit.KryptonListBox();
            DatePickerEstreno = new ReaLTaiizor.Controls.PoisonDateTime();
            CbClasificacion = new Componentes.CustomComboBox();
            TlpButtons = new TableLayoutPanel();
            BtnAgregar = new Componentes.CustomButton();
            BtnEliminar = new Componentes.CustomButton();
            BtnCopiar = new Componentes.CustomButton();
            BtnActualizar = new Componentes.CustomButton();
            TlpTitleLabel = new TableLayoutPanel();
            LbTitulo = new Componentes.CustomTitleLabel();
            TlpAux3 = new TableLayoutPanel();
            TlpFilter = new TableLayoutPanel();
            BtnBuscar = new Componentes.CustomButton();
            CbFiltro = new Componentes.CustomComboBox();
            TbFiltro = new Componentes.CustomTextBox();
            DgvPelicula = new Componentes.CustomDataGridView();
            materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox2 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox3 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox4 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox5 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox6 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox7 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox8 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox9 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox10 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox11 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox12 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox13 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox14 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox15 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox16 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox17 = new ReaLTaiizor.Controls.MaterialCheckBox();
            kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            TlpDivFormAndDgv.SuspendLayout();
            TlpAux1.SuspendLayout();
            TlpAux2.SuspendLayout();
            TlpFormWithButtons.SuspendLayout();
            TlpForm.SuspendLayout();
            TlpButtons.SuspendLayout();
            TlpTitleLabel.SuspendLayout();
            TlpAux3.SuspendLayout();
            TlpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPelicula).BeginInit();
            SuspendLayout();
            // 
            // TlpDivFormAndDgv
            // 
            TlpDivFormAndDgv.ColumnCount = 1;
            TlpDivFormAndDgv.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Controls.Add(TlpAux1, 0, 0);
            TlpDivFormAndDgv.Controls.Add(DgvPelicula, 0, 1);
            TlpDivFormAndDgv.Dock = DockStyle.Fill;
            TlpDivFormAndDgv.Location = new Point(0, 0);
            TlpDivFormAndDgv.Margin = new Padding(0);
            TlpDivFormAndDgv.Name = "TlpDivFormAndDgv";
            TlpDivFormAndDgv.RowCount = 2;
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Absolute, 725F));
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Size = new Size(1050, 750);
            TlpDivFormAndDgv.TabIndex = 4;
            // 
            // TlpAux1
            // 
            TlpAux1.ColumnCount = 1;
            TlpAux1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpAux1.Controls.Add(TlpAux2, 0, 1);
            TlpAux1.Controls.Add(TlpTitleLabel, 0, 0);
            TlpAux1.Controls.Add(TlpAux3, 0, 2);
            TlpAux1.Dock = DockStyle.Fill;
            TlpAux1.Location = new Point(0, 0);
            TlpAux1.Margin = new Padding(0);
            TlpAux1.Name = "TlpAux1";
            TlpAux1.RowCount = 3;
            TlpAux1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TlpAux1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpAux1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TlpAux1.Size = new Size(1050, 725);
            TlpAux1.TabIndex = 1;
            // 
            // TlpAux2
            // 
            TlpAux2.ColumnCount = 3;
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 900F));
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux2.Controls.Add(TlpFormWithButtons, 1, 0);
            TlpAux2.Dock = DockStyle.Fill;
            TlpAux2.Location = new Point(0, 75);
            TlpAux2.Margin = new Padding(0);
            TlpAux2.Name = "TlpAux2";
            TlpAux2.RowCount = 1;
            TlpAux2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpAux2.Size = new Size(1050, 575);
            TlpAux2.TabIndex = 0;
            // 
            // TlpFormWithButtons
            // 
            TlpFormWithButtons.ColumnCount = 2;
            TlpFormWithButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpFormWithButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpFormWithButtons.Controls.Add(BtnLimpiar, 1, 0);
            TlpFormWithButtons.Controls.Add(TlpForm, 0, 0);
            TlpFormWithButtons.Controls.Add(TlpButtons, 0, 1);
            TlpFormWithButtons.Dock = DockStyle.Fill;
            TlpFormWithButtons.Location = new Point(75, 0);
            TlpFormWithButtons.Margin = new Padding(0);
            TlpFormWithButtons.Name = "TlpFormWithButtons";
            TlpFormWithButtons.RowCount = 2;
            TlpFormWithButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpFormWithButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TlpFormWithButtons.Size = new Size(900, 575);
            TlpFormWithButtons.TabIndex = 0;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Action = Componentes.ButtonAction.Limpiar;
            BtnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnLimpiar.BackColor = Color.FromArgb(127, 140, 141);
            BtnLimpiar.FlatAppearance.BorderSize = 0;
            BtnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(77, 84, 85);
            BtnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(133, 145, 146);
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnLimpiar.ForeColor = Color.White;
            BtnLimpiar.Location = new Point(800, 10);
            BtnLimpiar.Margin = new Padding(0, 10, 0, 0);
            BtnLimpiar.MaximumSize = new Size(100, 40);
            BtnLimpiar.MinimumSize = new Size(100, 40);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(100, 40);
            BtnLimpiar.TabIndex = 2;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // TlpForm
            // 
            TlpForm.ColumnCount = 4;
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            TlpForm.Controls.Add(TbDescripcion, 3, 2);
            TlpForm.Controls.Add(LbID, 0, 0);
            TlpForm.Controls.Add(LbDirector, 2, 0);
            TlpForm.Controls.Add(LbPelicula, 0, 1);
            TlpForm.Controls.Add(LbTrailer, 2, 1);
            TlpForm.Controls.Add(LbDuracion, 0, 2);
            TlpForm.Controls.Add(LbClasificacion, 0, 4);
            TlpForm.Controls.Add(LbGeneros, 2, 5);
            TlpForm.Controls.Add(LbFormatos, 0, 5);
            TlpForm.Controls.Add(LbEstreno, 0, 3);
            TlpForm.Controls.Add(LbEstado, 2, 4);
            TlpForm.Controls.Add(LbDescripcion, 2, 2);
            TlpForm.Controls.Add(TbTitulo, 1, 1);
            TlpForm.Controls.Add(TbDuracion, 1, 2);
            TlpForm.Controls.Add(TbDirector, 3, 0);
            TlpForm.Controls.Add(TbTrailer, 3, 1);
            TlpForm.Controls.Add(TbID, 1, 0);
            TlpForm.Controls.Add(CbEstado, 3, 4);
            TlpForm.Controls.Add(ListBoxFormatos, 1, 5);
            TlpForm.Controls.Add(ListBoxGeneros, 3, 5);
            TlpForm.Controls.Add(DatePickerEstreno, 1, 3);
            TlpForm.Controls.Add(CbClasificacion, 1, 4);
            TlpForm.Dock = DockStyle.Fill;
            TlpForm.Location = new Point(0, 0);
            TlpForm.Margin = new Padding(0);
            TlpForm.Name = "TlpForm";
            TlpForm.RowCount = 12;
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.Size = new Size(790, 500);
            TlpForm.TabIndex = 0;
            // 
            // TbDescripcion
            // 
            TbDescripcion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbDescripcion.BackColor = Color.FromArgb(55, 60, 72);
            TbDescripcion.BorderStyle = BorderStyle.FixedSingle;
            TbDescripcion.Font = new Font("Segoe UI", 10F);
            TbDescripcion.ForeColor = Color.FromArgb(230, 230, 230);
            TbDescripcion.Location = new Point(533, 110);
            TbDescripcion.Margin = new Padding(5);
            TbDescripcion.MaximumSize = new Size(0, 30);
            TbDescripcion.MinimumSize = new Size(190, 80);
            TbDescripcion.Multiline = true;
            TbDescripcion.Name = "TbDescripcion";
            TlpForm.SetRowSpan(TbDescripcion, 2);
            TbDescripcion.Size = new Size(252, 80);
            TbDescripcion.TabIndex = 66;
            // 
            // LbID
            // 
            LbID.AutoSize = true;
            LbID.Dock = DockStyle.Fill;
            LbID.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbID.ForeColor = Color.FromArgb(220, 220, 220);
            LbID.Location = new Point(3, 0);
            LbID.Margin = new Padding(3, 0, 0, 0);
            LbID.Name = "LbID";
            LbID.Padding = new Padding(0, 0, 2, 0);
            LbID.Size = new Size(131, 50);
            LbID.TabIndex = 11;
            LbID.Text = "ID Pelicula";
            LbID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbDirector
            // 
            LbDirector.AutoSize = true;
            LbDirector.Dock = DockStyle.Fill;
            LbDirector.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbDirector.ForeColor = Color.FromArgb(220, 220, 220);
            LbDirector.Location = new Point(397, 0);
            LbDirector.Margin = new Padding(3, 0, 0, 0);
            LbDirector.Name = "LbDirector";
            LbDirector.Padding = new Padding(0, 0, 2, 0);
            LbDirector.Size = new Size(131, 50);
            LbDirector.TabIndex = 12;
            LbDirector.Text = "Director";
            LbDirector.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbPelicula
            // 
            LbPelicula.AutoSize = true;
            LbPelicula.Dock = DockStyle.Fill;
            LbPelicula.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbPelicula.ForeColor = Color.FromArgb(220, 220, 220);
            LbPelicula.Location = new Point(3, 50);
            LbPelicula.Margin = new Padding(3, 0, 0, 0);
            LbPelicula.Name = "LbPelicula";
            LbPelicula.Padding = new Padding(0, 0, 2, 0);
            LbPelicula.Size = new Size(131, 50);
            LbPelicula.TabIndex = 13;
            LbPelicula.Text = "Titulo";
            LbPelicula.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbTrailer
            // 
            LbTrailer.AutoSize = true;
            LbTrailer.Dock = DockStyle.Fill;
            LbTrailer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbTrailer.ForeColor = Color.FromArgb(220, 220, 220);
            LbTrailer.Location = new Point(397, 50);
            LbTrailer.Margin = new Padding(3, 0, 0, 0);
            LbTrailer.Name = "LbTrailer";
            LbTrailer.Padding = new Padding(0, 0, 2, 0);
            LbTrailer.Size = new Size(131, 50);
            LbTrailer.TabIndex = 14;
            LbTrailer.Text = "Trailer";
            LbTrailer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbDuracion
            // 
            LbDuracion.AutoSize = true;
            LbDuracion.Dock = DockStyle.Fill;
            LbDuracion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbDuracion.ForeColor = Color.FromArgb(220, 220, 220);
            LbDuracion.Location = new Point(3, 100);
            LbDuracion.Margin = new Padding(3, 0, 0, 0);
            LbDuracion.Name = "LbDuracion";
            LbDuracion.Padding = new Padding(0, 0, 2, 0);
            LbDuracion.Size = new Size(131, 50);
            LbDuracion.TabIndex = 15;
            LbDuracion.Text = "Duración(min)";
            LbDuracion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbClasificacion
            // 
            LbClasificacion.AutoSize = true;
            LbClasificacion.Dock = DockStyle.Fill;
            LbClasificacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbClasificacion.ForeColor = Color.FromArgb(220, 220, 220);
            LbClasificacion.Location = new Point(3, 200);
            LbClasificacion.Margin = new Padding(3, 0, 0, 0);
            LbClasificacion.Name = "LbClasificacion";
            LbClasificacion.Padding = new Padding(0, 0, 2, 0);
            LbClasificacion.Size = new Size(131, 50);
            LbClasificacion.TabIndex = 17;
            LbClasificacion.Text = "Clasificación";
            LbClasificacion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbGeneros
            // 
            LbGeneros.AutoSize = true;
            LbGeneros.Dock = DockStyle.Fill;
            LbGeneros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbGeneros.ForeColor = Color.FromArgb(220, 220, 220);
            LbGeneros.Location = new Point(397, 250);
            LbGeneros.Margin = new Padding(3, 0, 0, 0);
            LbGeneros.Name = "LbGeneros";
            LbGeneros.Padding = new Padding(0, 0, 2, 0);
            LbGeneros.Size = new Size(131, 50);
            LbGeneros.TabIndex = 19;
            LbGeneros.Text = "Generos";
            LbGeneros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbFormatos
            // 
            LbFormatos.AutoSize = true;
            LbFormatos.Dock = DockStyle.Fill;
            LbFormatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbFormatos.ForeColor = Color.FromArgb(220, 220, 220);
            LbFormatos.Location = new Point(3, 250);
            LbFormatos.Margin = new Padding(3, 0, 0, 0);
            LbFormatos.Name = "LbFormatos";
            LbFormatos.Padding = new Padding(0, 0, 2, 0);
            LbFormatos.Size = new Size(131, 50);
            LbFormatos.TabIndex = 21;
            LbFormatos.Text = "Formatos";
            LbFormatos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbEstreno
            // 
            LbEstreno.AutoSize = true;
            LbEstreno.Dock = DockStyle.Fill;
            LbEstreno.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbEstreno.ForeColor = Color.FromArgb(220, 220, 220);
            LbEstreno.Location = new Point(3, 150);
            LbEstreno.Margin = new Padding(3, 0, 0, 0);
            LbEstreno.Name = "LbEstreno";
            LbEstreno.Padding = new Padding(0, 0, 2, 0);
            LbEstreno.Size = new Size(131, 50);
            LbEstreno.TabIndex = 22;
            LbEstreno.Text = "Fecha de Estreno";
            LbEstreno.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbEstado
            // 
            LbEstado.AutoSize = true;
            LbEstado.Dock = DockStyle.Fill;
            LbEstado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbEstado.ForeColor = Color.FromArgb(220, 220, 220);
            LbEstado.Location = new Point(397, 200);
            LbEstado.Margin = new Padding(3, 0, 0, 0);
            LbEstado.Name = "LbEstado";
            LbEstado.Padding = new Padding(0, 0, 2, 0);
            LbEstado.Size = new Size(131, 50);
            LbEstado.TabIndex = 20;
            LbEstado.Text = "Estado";
            LbEstado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbDescripcion
            // 
            LbDescripcion.AutoSize = true;
            LbDescripcion.Dock = DockStyle.Fill;
            LbDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbDescripcion.ForeColor = Color.FromArgb(220, 220, 220);
            LbDescripcion.Location = new Point(397, 100);
            LbDescripcion.Margin = new Padding(3, 0, 0, 0);
            LbDescripcion.Name = "LbDescripcion";
            LbDescripcion.Padding = new Padding(0, 0, 2, 0);
            LbDescripcion.Size = new Size(131, 50);
            LbDescripcion.TabIndex = 50;
            LbDescripcion.Text = "Descripción";
            LbDescripcion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbTitulo
            // 
            TbTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbTitulo.BackColor = Color.FromArgb(55, 60, 72);
            TbTitulo.BorderStyle = BorderStyle.FixedSingle;
            TbTitulo.Font = new Font("Segoe UI", 10F);
            TbTitulo.ForeColor = Color.FromArgb(160, 165, 175);
            TbTitulo.Location = new Point(139, 60);
            TbTitulo.Margin = new Padding(5);
            TbTitulo.MaximumSize = new Size(0, 30);
            TbTitulo.MinimumSize = new Size(190, 30);
            TbTitulo.Name = "TbTitulo";
            TbTitulo.PlaceholderText = "Evil Dead";
            TbTitulo.Size = new Size(250, 30);
            TbTitulo.TabIndex = 53;
            // 
            // TbDuracion
            // 
            TbDuracion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbDuracion.BackColor = Color.FromArgb(55, 60, 72);
            TbDuracion.BorderStyle = BorderStyle.FixedSingle;
            TbDuracion.Font = new Font("Segoe UI", 10F);
            TbDuracion.ForeColor = Color.FromArgb(160, 165, 175);
            TbDuracion.Location = new Point(139, 110);
            TbDuracion.Margin = new Padding(5);
            TbDuracion.MaximumSize = new Size(0, 30);
            TbDuracion.MinimumSize = new Size(190, 30);
            TbDuracion.Name = "TbDuracion";
            TbDuracion.PlaceholderText = "120";
            TbDuracion.Size = new Size(250, 30);
            TbDuracion.TabIndex = 54;
            // 
            // TbDirector
            // 
            TbDirector.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbDirector.BackColor = Color.FromArgb(55, 60, 72);
            TbDirector.BorderStyle = BorderStyle.FixedSingle;
            TbDirector.Font = new Font("Segoe UI", 10F);
            TbDirector.ForeColor = Color.FromArgb(160, 165, 175);
            TbDirector.Location = new Point(533, 10);
            TbDirector.Margin = new Padding(5);
            TbDirector.MaximumSize = new Size(0, 30);
            TbDirector.MinimumSize = new Size(190, 30);
            TbDirector.Name = "TbDirector";
            TbDirector.PlaceholderText = "Diego Santizo";
            TbDirector.Size = new Size(252, 30);
            TbDirector.TabIndex = 57;
            // 
            // TbTrailer
            // 
            TbTrailer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbTrailer.BackColor = Color.FromArgb(55, 60, 72);
            TbTrailer.BorderStyle = BorderStyle.FixedSingle;
            TbTrailer.Font = new Font("Segoe UI", 10F);
            TbTrailer.ForeColor = Color.FromArgb(160, 165, 175);
            TbTrailer.Location = new Point(533, 60);
            TbTrailer.Margin = new Padding(5);
            TbTrailer.MaximumSize = new Size(0, 30);
            TbTrailer.MinimumSize = new Size(190, 30);
            TbTrailer.Name = "TbTrailer";
            TbTrailer.PlaceholderText = "https://www.youtube.com/watch?v=YH4Oo7HW9TM";
            TbTrailer.Size = new Size(252, 30);
            TbTrailer.TabIndex = 59;
            // 
            // TbID
            // 
            TbID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbID.BackColor = Color.FromArgb(28, 30, 38);
            TbID.BorderStyle = BorderStyle.FixedSingle;
            TbID.Font = new Font("Segoe UI", 10F);
            TbID.ForeColor = Color.FromArgb(120, 125, 135);
            TbID.Location = new Point(139, 10);
            TbID.Margin = new Padding(5);
            TbID.MaximumSize = new Size(0, 30);
            TbID.MinimumSize = new Size(190, 30);
            TbID.Name = "TbID";
            TbID.ReadOnly = true;
            TbID.Size = new Size(250, 30);
            TbID.TabIndex = 60;
            TbID.TabStop = false;
            // 
            // CbEstado
            // 
            CbEstado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CbEstado.BackColor = Color.FromArgb(55, 60, 72);
            CbEstado.BaseColor = Color.FromArgb(25, 27, 29);
            CbEstado.BGColor = Color.FromArgb(45, 47, 49);
            CbEstado.DrawMode = DrawMode.OwnerDrawFixed;
            CbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            CbEstado.FlatStyle = FlatStyle.Flat;
            CbEstado.Font = new Font("Segoe UI", 9F);
            CbEstado.ForeColor = Color.FromArgb(230, 230, 230);
            CbEstado.FormattingEnabled = true;
            CbEstado.HoverColor = Color.FromArgb(35, 168, 109);
            CbEstado.HoverFontColor = Color.White;
            CbEstado.ItemHeight = 20;
            CbEstado.Location = new Point(533, 212);
            CbEstado.Margin = new Padding(5);
            CbEstado.MinimumSize = new Size(190, 0);
            CbEstado.Name = "CbEstado";
            CbEstado.Size = new Size(252, 26);
            CbEstado.TabIndex = 63;
            // 
            // ListBoxFormatos
            // 
            ListBoxFormatos.Items.AddRange(new object[] { "fsdf", "sdfsd", "fsdf", "sdf", "sdf", "s\t\t\t" });
            ListBoxFormatos.Location = new Point(137, 253);
            ListBoxFormatos.Name = "ListBoxFormatos";
            TlpForm.SetRowSpan(ListBoxFormatos, 5);
            ListBoxFormatos.SelectionMode = SelectionMode.MultiSimple;
            ListBoxFormatos.Size = new Size(250, 230);
            ListBoxFormatos.TabIndex = 67;
            // 
            // ListBoxGeneros
            // 
            ListBoxGeneros.Items.AddRange(new object[] { "fsdf", "sdfsd", "fsdf", "sdf", "sdf", "s\t\t\t" });
            ListBoxGeneros.Location = new Point(531, 253);
            ListBoxGeneros.Name = "ListBoxGeneros";
            TlpForm.SetRowSpan(ListBoxGeneros, 5);
            ListBoxGeneros.SelectionMode = SelectionMode.MultiSimple;
            ListBoxGeneros.Size = new Size(250, 230);
            ListBoxGeneros.TabIndex = 5;
            ListBoxGeneros.SelectedIndexChanged += kryptonListBox1_SelectedIndexChanged;
            // 
            // DatePickerEstreno
            // 
            DatePickerEstreno.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DatePickerEstreno.Cursor = Cursors.Hand;
            DatePickerEstreno.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            DatePickerEstreno.Location = new Point(139, 160);
            DatePickerEstreno.Margin = new Padding(5);
            DatePickerEstreno.MinimumSize = new Size(0, 30);
            DatePickerEstreno.Name = "DatePickerEstreno";
            DatePickerEstreno.Size = new Size(250, 30);
            DatePickerEstreno.TabIndex = 65;
            // 
            // CbClasificacion
            // 
            CbClasificacion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CbClasificacion.BackColor = Color.FromArgb(55, 60, 72);
            CbClasificacion.BaseColor = Color.FromArgb(25, 27, 29);
            CbClasificacion.BGColor = Color.FromArgb(45, 47, 49);
            CbClasificacion.DrawMode = DrawMode.OwnerDrawFixed;
            CbClasificacion.DropDownStyle = ComboBoxStyle.DropDownList;
            CbClasificacion.FlatStyle = FlatStyle.Flat;
            CbClasificacion.Font = new Font("Segoe UI", 9F);
            CbClasificacion.ForeColor = Color.FromArgb(230, 230, 230);
            CbClasificacion.FormattingEnabled = true;
            CbClasificacion.HoverColor = Color.FromArgb(35, 168, 109);
            CbClasificacion.HoverFontColor = Color.White;
            CbClasificacion.ItemHeight = 20;
            CbClasificacion.Location = new Point(139, 212);
            CbClasificacion.Margin = new Padding(5);
            CbClasificacion.MinimumSize = new Size(190, 0);
            CbClasificacion.Name = "CbClasificacion";
            CbClasificacion.Size = new Size(250, 26);
            CbClasificacion.TabIndex = 41;
            // 
            // TlpButtons
            // 
            TlpButtons.ColumnCount = 6;
            TlpFormWithButtons.SetColumnSpan(TlpButtons, 2);
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.Controls.Add(BtnAgregar, 1, 0);
            TlpButtons.Controls.Add(BtnEliminar, 4, 0);
            TlpButtons.Controls.Add(BtnCopiar, 2, 0);
            TlpButtons.Controls.Add(BtnActualizar, 3, 0);
            TlpButtons.Dock = DockStyle.Fill;
            TlpButtons.Location = new Point(0, 500);
            TlpButtons.Margin = new Padding(0);
            TlpButtons.Name = "TlpButtons";
            TlpButtons.RowCount = 1;
            TlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpButtons.Size = new Size(900, 75);
            TlpButtons.TabIndex = 3;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.None;
            BtnAgregar.BackColor = Color.FromArgb(41, 128, 185);
            BtnAgregar.FlatAppearance.BorderSize = 0;
            BtnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 75, 109);
            BtnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 134, 194);
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnAgregar.ForeColor = Color.White;
            BtnAgregar.Location = new Point(235, 17);
            BtnAgregar.Margin = new Padding(0);
            BtnAgregar.MaximumSize = new Size(100, 40);
            BtnAgregar.MinimumSize = new Size(100, 40);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(100, 40);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Action = Componentes.ButtonAction.Eliminar;
            BtnEliminar.Anchor = AnchorStyles.None;
            BtnEliminar.BackColor = Color.FromArgb(192, 57, 43);
            BtnEliminar.FlatAppearance.BorderSize = 0;
            BtnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(116, 35, 27);
            BtnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 62, 46);
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnEliminar.ForeColor = Color.White;
            BtnEliminar.Location = new Point(565, 17);
            BtnEliminar.Margin = new Padding(0);
            BtnEliminar.MaximumSize = new Size(100, 40);
            BtnEliminar.MinimumSize = new Size(100, 40);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(100, 40);
            BtnEliminar.TabIndex = 4;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnCopiar
            // 
            BtnCopiar.Action = Componentes.ButtonAction.Copiar;
            BtnCopiar.Anchor = AnchorStyles.None;
            BtnCopiar.BackColor = Color.FromArgb(26, 156, 156);
            BtnCopiar.FlatAppearance.BorderSize = 0;
            BtnCopiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 95, 95);
            BtnCopiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 169, 169);
            BtnCopiar.FlatStyle = FlatStyle.Flat;
            BtnCopiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnCopiar.ForeColor = Color.White;
            BtnCopiar.Location = new Point(345, 17);
            BtnCopiar.Margin = new Padding(0);
            BtnCopiar.MaximumSize = new Size(100, 40);
            BtnCopiar.MinimumSize = new Size(100, 40);
            BtnCopiar.Name = "BtnCopiar";
            BtnCopiar.Size = new Size(100, 40);
            BtnCopiar.TabIndex = 3;
            BtnCopiar.Text = "Copiar";
            BtnCopiar.UseVisualStyleBackColor = false;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Action = Componentes.ButtonAction.Actualizar;
            BtnActualizar.Anchor = AnchorStyles.None;
            BtnActualizar.BackColor = Color.FromArgb(214, 157, 15);
            BtnActualizar.FlatAppearance.BorderSize = 0;
            BtnActualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(130, 97, 9);
            BtnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 169, 16);
            BtnActualizar.FlatStyle = FlatStyle.Flat;
            BtnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnActualizar.ForeColor = Color.White;
            BtnActualizar.Location = new Point(455, 17);
            BtnActualizar.Margin = new Padding(0);
            BtnActualizar.MaximumSize = new Size(100, 40);
            BtnActualizar.MinimumSize = new Size(100, 40);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(100, 40);
            BtnActualizar.TabIndex = 2;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = false;
            // 
            // TlpTitleLabel
            // 
            TlpTitleLabel.BackColor = Color.Black;
            TlpTitleLabel.ColumnCount = 3;
            TlpTitleLabel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpTitleLabel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            TlpTitleLabel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpTitleLabel.Controls.Add(LbTitulo, 1, 0);
            TlpTitleLabel.Dock = DockStyle.Fill;
            TlpTitleLabel.Location = new Point(0, 0);
            TlpTitleLabel.Margin = new Padding(0);
            TlpTitleLabel.Name = "TlpTitleLabel";
            TlpTitleLabel.RowCount = 1;
            TlpTitleLabel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpTitleLabel.Size = new Size(1050, 75);
            TlpTitleLabel.TabIndex = 1;
            // 
            // LbTitulo
            // 
            LbTitulo.AutoSize = true;
            LbTitulo.Dock = DockStyle.Fill;
            LbTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LbTitulo.ForeColor = Color.Crimson;
            LbTitulo.Location = new Point(278, 0);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(494, 75);
            LbTitulo.TabIndex = 0;
            LbTitulo.Text = "PELÍCULAS";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TlpAux3
            // 
            TlpAux3.ColumnCount = 3;
            TlpAux3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 510F));
            TlpAux3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux3.Controls.Add(TlpFilter, 1, 0);
            TlpAux3.Dock = DockStyle.Fill;
            TlpAux3.Location = new Point(0, 650);
            TlpAux3.Margin = new Padding(0);
            TlpAux3.Name = "TlpAux3";
            TlpAux3.RowCount = 1;
            TlpAux3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpAux3.Size = new Size(1050, 75);
            TlpAux3.TabIndex = 2;
            // 
            // TlpFilter
            // 
            TlpFilter.ColumnCount = 3;
            TlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            TlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            TlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpFilter.Controls.Add(BtnBuscar, 2, 0);
            TlpFilter.Controls.Add(CbFiltro, 0, 0);
            TlpFilter.Controls.Add(TbFiltro, 1, 0);
            TlpFilter.Dock = DockStyle.Fill;
            TlpFilter.Location = new Point(270, 0);
            TlpFilter.Margin = new Padding(0);
            TlpFilter.Name = "TlpFilter";
            TlpFilter.RowCount = 1;
            TlpFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpFilter.Size = new Size(510, 75);
            TlpFilter.TabIndex = 0;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Action = Componentes.ButtonAction.Buscar;
            BtnBuscar.Anchor = AnchorStyles.None;
            BtnBuscar.BackColor = Color.FromArgb(39, 174, 96);
            BtnBuscar.FlatAppearance.BorderSize = 0;
            BtnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 104, 57);
            BtnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 186, 103);
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.Location = new Point(405, 17);
            BtnBuscar.Margin = new Padding(0);
            BtnBuscar.MaximumSize = new Size(100, 40);
            BtnBuscar.MinimumSize = new Size(100, 40);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(100, 40);
            BtnBuscar.TabIndex = 5;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // CbFiltro
            // 
            CbFiltro.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CbFiltro.BackColor = Color.FromArgb(55, 60, 72);
            CbFiltro.BaseColor = Color.FromArgb(25, 27, 29);
            CbFiltro.BGColor = Color.FromArgb(45, 47, 49);
            CbFiltro.DrawMode = DrawMode.OwnerDrawFixed;
            CbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            CbFiltro.FlatStyle = FlatStyle.Flat;
            CbFiltro.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbFiltro.ForeColor = Color.FromArgb(230, 230, 230);
            CbFiltro.FormattingEnabled = true;
            CbFiltro.HoverColor = Color.FromArgb(35, 168, 109);
            CbFiltro.HoverFontColor = Color.White;
            CbFiltro.ItemHeight = 20;
            CbFiltro.Location = new Point(5, 24);
            CbFiltro.Margin = new Padding(5);
            CbFiltro.MinimumSize = new Size(190, 0);
            CbFiltro.Name = "CbFiltro";
            CbFiltro.Size = new Size(190, 26);
            CbFiltro.TabIndex = 6;
            // 
            // TbFiltro
            // 
            TbFiltro.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbFiltro.BackColor = Color.FromArgb(55, 60, 72);
            TbFiltro.BorderStyle = BorderStyle.FixedSingle;
            TbFiltro.Font = new Font("Segoe UI", 10F);
            TbFiltro.ForeColor = Color.FromArgb(230, 230, 230);
            TbFiltro.Location = new Point(205, 22);
            TbFiltro.Margin = new Padding(5);
            TbFiltro.MaximumSize = new Size(0, 30);
            TbFiltro.MinimumSize = new Size(190, 30);
            TbFiltro.Name = "TbFiltro";
            TbFiltro.Size = new Size(190, 30);
            TbFiltro.TabIndex = 7;
            // 
            // DgvPelicula
            // 
            DgvPelicula.AllowUserToAddRows = false;
            DgvPelicula.AllowUserToResizeColumns = false;
            DgvPelicula.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 55, 66);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            DgvPelicula.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvPelicula.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPelicula.BackgroundColor = Color.FromArgb(55, 60, 72);
            DgvPelicula.BorderStyle = BorderStyle.None;
            DgvPelicula.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvPelicula.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvPelicula.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvPelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(55, 60, 72);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvPelicula.DefaultCellStyle = dataGridViewCellStyle3;
            DgvPelicula.Dock = DockStyle.Fill;
            DgvPelicula.EnableHeadersVisualStyles = false;
            DgvPelicula.Font = new Font("Segoe UI", 9.5F);
            DgvPelicula.GridColor = Color.FromArgb(70, 76, 90);
            DgvPelicula.Location = new Point(0, 725);
            DgvPelicula.Margin = new Padding(0);
            DgvPelicula.MultiSelect = false;
            DgvPelicula.Name = "DgvPelicula";
            DgvPelicula.ReadOnly = true;
            DgvPelicula.RowHeadersVisible = false;
            DgvPelicula.RowHeadersWidth = 51;
            DgvPelicula.RowTemplate.Height = 36;
            DgvPelicula.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPelicula.Size = new Size(1050, 25);
            DgvPelicula.TabIndex = 2;
            // 
            // materialCheckBox1
            // 
            materialCheckBox1.AutoSize = true;
            materialCheckBox1.Depth = 0;
            materialCheckBox1.Location = new Point(0, 0);
            materialCheckBox1.Margin = new Padding(0);
            materialCheckBox1.MouseLocation = new Point(-1, -1);
            materialCheckBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox1.Name = "materialCheckBox1";
            materialCheckBox1.ReadOnly = false;
            materialCheckBox1.Ripple = true;
            materialCheckBox1.Size = new Size(272, 46);
            materialCheckBox1.TabIndex = 0;
            materialCheckBox1.Text = "materialCheckBox1";
            materialCheckBox1.UseAccentColor = false;
            materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox2
            // 
            materialCheckBox2.AutoSize = true;
            materialCheckBox2.Depth = 0;
            materialCheckBox2.Location = new Point(0, 0);
            materialCheckBox2.Margin = new Padding(0);
            materialCheckBox2.MouseLocation = new Point(-1, -1);
            materialCheckBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox2.Name = "materialCheckBox2";
            materialCheckBox2.ReadOnly = false;
            materialCheckBox2.Ripple = true;
            materialCheckBox2.Size = new Size(272, 46);
            materialCheckBox2.TabIndex = 0;
            materialCheckBox2.Text = "materialCheckBox2";
            materialCheckBox2.UseAccentColor = false;
            materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox3
            // 
            materialCheckBox3.AutoSize = true;
            materialCheckBox3.Depth = 0;
            materialCheckBox3.Location = new Point(0, 0);
            materialCheckBox3.Margin = new Padding(0);
            materialCheckBox3.MouseLocation = new Point(-1, -1);
            materialCheckBox3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox3.Name = "materialCheckBox3";
            materialCheckBox3.ReadOnly = false;
            materialCheckBox3.Ripple = true;
            materialCheckBox3.Size = new Size(272, 46);
            materialCheckBox3.TabIndex = 0;
            materialCheckBox3.Text = "materialCheckBox3";
            materialCheckBox3.UseAccentColor = false;
            materialCheckBox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox4
            // 
            materialCheckBox4.AutoSize = true;
            materialCheckBox4.Depth = 0;
            materialCheckBox4.Location = new Point(0, 0);
            materialCheckBox4.Margin = new Padding(0);
            materialCheckBox4.MouseLocation = new Point(-1, -1);
            materialCheckBox4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox4.Name = "materialCheckBox4";
            materialCheckBox4.ReadOnly = false;
            materialCheckBox4.Ripple = true;
            materialCheckBox4.Size = new Size(236, 46);
            materialCheckBox4.TabIndex = 0;
            materialCheckBox4.Text = "sdfasdfasdfsadf";
            materialCheckBox4.UseAccentColor = false;
            materialCheckBox4.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox5
            // 
            materialCheckBox5.AutoSize = true;
            materialCheckBox5.Depth = 0;
            materialCheckBox5.Location = new Point(0, 0);
            materialCheckBox5.Margin = new Padding(0);
            materialCheckBox5.MouseLocation = new Point(-1, -1);
            materialCheckBox5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox5.Name = "materialCheckBox5";
            materialCheckBox5.ReadOnly = false;
            materialCheckBox5.Ripple = true;
            materialCheckBox5.Size = new Size(272, 46);
            materialCheckBox5.TabIndex = 0;
            materialCheckBox5.Text = "materialCheckBox5";
            materialCheckBox5.UseAccentColor = false;
            materialCheckBox5.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox6
            // 
            materialCheckBox6.AutoSize = true;
            materialCheckBox6.Depth = 0;
            materialCheckBox6.Location = new Point(0, 0);
            materialCheckBox6.Margin = new Padding(0);
            materialCheckBox6.MouseLocation = new Point(-1, -1);
            materialCheckBox6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox6.Name = "materialCheckBox6";
            materialCheckBox6.ReadOnly = false;
            materialCheckBox6.Ripple = true;
            materialCheckBox6.Size = new Size(272, 46);
            materialCheckBox6.TabIndex = 0;
            materialCheckBox6.Text = "materialCheckBox6";
            materialCheckBox6.UseAccentColor = false;
            materialCheckBox6.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox7
            // 
            materialCheckBox7.AutoSize = true;
            materialCheckBox7.Depth = 0;
            materialCheckBox7.Location = new Point(0, 0);
            materialCheckBox7.Margin = new Padding(0);
            materialCheckBox7.MouseLocation = new Point(-1, -1);
            materialCheckBox7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox7.Name = "materialCheckBox7";
            materialCheckBox7.ReadOnly = false;
            materialCheckBox7.Ripple = true;
            materialCheckBox7.Size = new Size(272, 46);
            materialCheckBox7.TabIndex = 0;
            materialCheckBox7.Text = "materialCheckBox7";
            materialCheckBox7.UseAccentColor = false;
            materialCheckBox7.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox8
            // 
            materialCheckBox8.AutoSize = true;
            materialCheckBox8.Depth = 0;
            materialCheckBox8.Location = new Point(0, 0);
            materialCheckBox8.Margin = new Padding(0);
            materialCheckBox8.MouseLocation = new Point(-1, -1);
            materialCheckBox8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox8.Name = "materialCheckBox8";
            materialCheckBox8.ReadOnly = false;
            materialCheckBox8.Ripple = true;
            materialCheckBox8.Size = new Size(272, 46);
            materialCheckBox8.TabIndex = 0;
            materialCheckBox8.Text = "materialCheckBox8";
            materialCheckBox8.UseAccentColor = false;
            materialCheckBox8.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox9
            // 
            materialCheckBox9.AutoSize = true;
            materialCheckBox9.Depth = 0;
            materialCheckBox9.Location = new Point(0, 0);
            materialCheckBox9.Margin = new Padding(0);
            materialCheckBox9.MouseLocation = new Point(-1, -1);
            materialCheckBox9.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox9.Name = "materialCheckBox9";
            materialCheckBox9.ReadOnly = false;
            materialCheckBox9.Ripple = true;
            materialCheckBox9.Size = new Size(272, 46);
            materialCheckBox9.TabIndex = 0;
            materialCheckBox9.Text = "materialCheckBox9";
            materialCheckBox9.UseAccentColor = false;
            materialCheckBox9.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox10
            // 
            materialCheckBox10.AutoSize = true;
            materialCheckBox10.Depth = 0;
            materialCheckBox10.Location = new Point(0, 0);
            materialCheckBox10.Margin = new Padding(0);
            materialCheckBox10.MouseLocation = new Point(-1, -1);
            materialCheckBox10.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox10.Name = "materialCheckBox10";
            materialCheckBox10.ReadOnly = false;
            materialCheckBox10.Ripple = true;
            materialCheckBox10.Size = new Size(286, 46);
            materialCheckBox10.TabIndex = 0;
            materialCheckBox10.Text = "materialCheckBox10";
            materialCheckBox10.UseAccentColor = false;
            materialCheckBox10.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox11
            // 
            materialCheckBox11.AutoSize = true;
            materialCheckBox11.Depth = 0;
            materialCheckBox11.Location = new Point(0, 0);
            materialCheckBox11.Margin = new Padding(0);
            materialCheckBox11.MouseLocation = new Point(-1, -1);
            materialCheckBox11.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox11.Name = "materialCheckBox11";
            materialCheckBox11.ReadOnly = false;
            materialCheckBox11.Ripple = true;
            materialCheckBox11.Size = new Size(286, 46);
            materialCheckBox11.TabIndex = 0;
            materialCheckBox11.Text = "materialCheckBox11";
            materialCheckBox11.UseAccentColor = false;
            materialCheckBox11.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox12
            // 
            materialCheckBox12.AutoSize = true;
            materialCheckBox12.Depth = 0;
            materialCheckBox12.Location = new Point(0, 0);
            materialCheckBox12.Margin = new Padding(0);
            materialCheckBox12.MouseLocation = new Point(-1, -1);
            materialCheckBox12.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox12.Name = "materialCheckBox12";
            materialCheckBox12.ReadOnly = false;
            materialCheckBox12.Ripple = true;
            materialCheckBox12.Size = new Size(286, 46);
            materialCheckBox12.TabIndex = 0;
            materialCheckBox12.Text = "materialCheckBox12";
            materialCheckBox12.UseAccentColor = false;
            materialCheckBox12.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox13
            // 
            materialCheckBox13.AutoSize = true;
            materialCheckBox13.Depth = 0;
            materialCheckBox13.Location = new Point(0, 0);
            materialCheckBox13.Margin = new Padding(0);
            materialCheckBox13.MouseLocation = new Point(-1, -1);
            materialCheckBox13.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox13.Name = "materialCheckBox13";
            materialCheckBox13.ReadOnly = false;
            materialCheckBox13.Ripple = true;
            materialCheckBox13.Size = new Size(286, 46);
            materialCheckBox13.TabIndex = 0;
            materialCheckBox13.Text = "materialCheckBox13";
            materialCheckBox13.UseAccentColor = false;
            materialCheckBox13.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox14
            // 
            materialCheckBox14.AutoSize = true;
            materialCheckBox14.Depth = 0;
            materialCheckBox14.Location = new Point(0, 0);
            materialCheckBox14.Margin = new Padding(0);
            materialCheckBox14.MouseLocation = new Point(-1, -1);
            materialCheckBox14.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox14.Name = "materialCheckBox14";
            materialCheckBox14.ReadOnly = false;
            materialCheckBox14.Ripple = true;
            materialCheckBox14.Size = new Size(286, 46);
            materialCheckBox14.TabIndex = 0;
            materialCheckBox14.Text = "materialCheckBox14";
            materialCheckBox14.UseAccentColor = false;
            materialCheckBox14.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox15
            // 
            materialCheckBox15.AutoSize = true;
            materialCheckBox15.Depth = 0;
            materialCheckBox15.Location = new Point(0, 0);
            materialCheckBox15.Margin = new Padding(0);
            materialCheckBox15.MouseLocation = new Point(-1, -1);
            materialCheckBox15.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox15.Name = "materialCheckBox15";
            materialCheckBox15.ReadOnly = false;
            materialCheckBox15.Ripple = true;
            materialCheckBox15.Size = new Size(286, 46);
            materialCheckBox15.TabIndex = 0;
            materialCheckBox15.Text = "materialCheckBox15";
            materialCheckBox15.UseAccentColor = false;
            materialCheckBox15.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox16
            // 
            materialCheckBox16.AutoSize = true;
            materialCheckBox16.Depth = 0;
            materialCheckBox16.Location = new Point(0, 0);
            materialCheckBox16.Margin = new Padding(0);
            materialCheckBox16.MouseLocation = new Point(-1, -1);
            materialCheckBox16.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox16.Name = "materialCheckBox16";
            materialCheckBox16.ReadOnly = false;
            materialCheckBox16.Ripple = true;
            materialCheckBox16.Size = new Size(286, 46);
            materialCheckBox16.TabIndex = 0;
            materialCheckBox16.Text = "materialCheckBox16";
            materialCheckBox16.UseAccentColor = false;
            materialCheckBox16.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox17
            // 
            materialCheckBox17.AutoSize = true;
            materialCheckBox17.Depth = 0;
            materialCheckBox17.Location = new Point(0, 0);
            materialCheckBox17.Margin = new Padding(0);
            materialCheckBox17.MouseLocation = new Point(-1, -1);
            materialCheckBox17.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox17.Name = "materialCheckBox17";
            materialCheckBox17.ReadOnly = false;
            materialCheckBox17.Ripple = true;
            materialCheckBox17.Size = new Size(286, 46);
            materialCheckBox17.TabIndex = 0;
            materialCheckBox17.Text = "materialCheckBox17";
            materialCheckBox17.UseAccentColor = false;
            materialCheckBox17.UseVisualStyleBackColor = true;
            // 
            // kryptonContextMenu1
            // 
            kryptonContextMenu1.PaletteMode = Krypton.Toolkit.PaletteMode.MaterialDarkRipple;
            // 
            // FrUcPeliculas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(TlpDivFormAndDgv);
            Name = "FrUcPeliculas";
            Size = new Size(1050, 750);
            TlpDivFormAndDgv.ResumeLayout(false);
            TlpAux1.ResumeLayout(false);
            TlpAux2.ResumeLayout(false);
            TlpFormWithButtons.ResumeLayout(false);
            TlpForm.ResumeLayout(false);
            TlpForm.PerformLayout();
            TlpButtons.ResumeLayout(false);
            TlpTitleLabel.ResumeLayout(false);
            TlpTitleLabel.PerformLayout();
            TlpAux3.ResumeLayout(false);
            TlpFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvPelicula).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpDivFormAndDgv;
        private TableLayoutPanel TlpAux1;
        private TableLayoutPanel TlpAux2;
        private TableLayoutPanel TlpFormWithButtons;
        private Componentes.CustomButton BtnLimpiar;
        private TableLayoutPanel TlpForm;
        private Componentes.CustomLabel LbID;
        private Componentes.CustomLabel LbDirector;
        private Componentes.CustomLabel LbPelicula;
        private Componentes.CustomLabel LbTrailer;
        private Componentes.CustomLabel LbDuracion;
        private Componentes.CustomLabel LbClasificacion;
        private Componentes.CustomLabel LbGeneros;
        private Componentes.CustomLabel LbFormatos;
        private Componentes.CustomLabel LbEstreno;
        private Componentes.CustomLabel LbEstado;
        private Componentes.CustomComboBox CbClasificacion;
        private Componentes.CustomLabel LbDescripcion;
        private Componentes.CustomTextBox TbTitulo;
        private Componentes.CustomTextBox TbDuracion;
        private Componentes.CustomTextBox TbDirector;
        private Componentes.CustomTextBox TbTrailer;
        private Componentes.CustomIDTextBox TbID;
        private Componentes.CustomComboBox CbEstado;
        private TableLayoutPanel TlpButtons;
        private Componentes.CustomButton BtnAgregar;
        private Componentes.CustomButton BtnEliminar;
        private Componentes.CustomButton BtnCopiar;
        private Componentes.CustomButton BtnActualizar;
        private TableLayoutPanel TlpTitleLabel;
        private Componentes.CustomTitleLabel LbTitulo;
        private TableLayoutPanel TlpAux3;
        private TableLayoutPanel TlpFilter;
        private Componentes.CustomButton BtnBuscar;
        private Componentes.CustomComboBox CbFiltro;
        private Componentes.CustomTextBox TbFiltro;
        private Componentes.CustomDataGridView DgvPelicula;
        private ReaLTaiizor.Controls.PoisonDateTime DatePickerEstreno;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox1;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox2;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox3;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox4;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox5;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox6;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox7;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox8;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox9;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox10;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox11;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox12;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox13;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox14;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox15;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox16;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox17;
        private Componentes.CustomTextBox TbDescripcion;
        private Krypton.Toolkit.KryptonListBox ListBoxGeneros;
        private Krypton.Toolkit.KryptonListBox ListBoxFormatos;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
    }
}
