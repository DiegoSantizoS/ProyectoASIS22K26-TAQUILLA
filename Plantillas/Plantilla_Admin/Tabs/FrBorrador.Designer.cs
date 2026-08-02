namespace Plantilla_Admin.Tabs
{
    partial class FrBorrador
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
            DpEstreno = new Componentes.CustomDatePicker();
            LbDescripcion = new Componentes.CustomLabel();
            RtbDescripcion = new Componentes.CustomRichTextBox();
            TbTitulo = new Componentes.CustomTextBox();
            TbDuracion = new Componentes.CustomTextBox();
            TbDirector = new Componentes.CustomTextBox();
            TbTrailer = new Componentes.CustomTextBox();
            TbID = new Componentes.CustomIDTextBox();
            TbGeneros = new Componentes.CustomIDTextBox();
            TbFormatos = new Componentes.CustomIDTextBox();
            TlpButtons = new TableLayoutPanel();
            BtnIngresar = new Componentes.CustomButton();
            BtnEliminar = new Componentes.CustomButton();
            BtnCopiar = new Componentes.CustomButton();
            BtnActualizar = new Componentes.CustomButton();
            TlpTitleLabel = new TableLayoutPanel();
            LbTitulo = new Componentes.CustomTitleLabel();
            TlpAux3 = new TableLayoutPanel();
            TlpFilter = new TableLayoutPanel();
            customButton6 = new Componentes.CustomButton();
            CbFiltro = new Componentes.CustomComboBox();
            TbFiltro = new Componentes.CustomTextBox();
            DgvPelicula = new Componentes.CustomDataGridView();
            customComboBox2 = new Componentes.CustomComboBox();
            customComboBox3 = new Componentes.CustomComboBox();
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
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Absolute, 525F));
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Size = new Size(1050, 700);
            TlpDivFormAndDgv.TabIndex = 3;
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
            TlpAux1.Size = new Size(1050, 525);
            TlpAux1.TabIndex = 1;
            // 
            // TlpAux2
            // 
            TlpAux2.ColumnCount = 3;
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 875F));
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux2.Controls.Add(TlpFormWithButtons, 1, 0);
            TlpAux2.Dock = DockStyle.Fill;
            TlpAux2.Location = new Point(0, 75);
            TlpAux2.Margin = new Padding(0);
            TlpAux2.Name = "TlpAux2";
            TlpAux2.RowCount = 1;
            TlpAux2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpAux2.Size = new Size(1050, 375);
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
            TlpFormWithButtons.Location = new Point(87, 0);
            TlpFormWithButtons.Margin = new Padding(0);
            TlpFormWithButtons.Name = "TlpFormWithButtons";
            TlpFormWithButtons.RowCount = 2;
            TlpFormWithButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpFormWithButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TlpFormWithButtons.Size = new Size(875, 375);
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
            BtnLimpiar.Location = new Point(775, 10);
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
            TlpForm.Controls.Add(LbID, 0, 0);
            TlpForm.Controls.Add(LbDirector, 2, 0);
            TlpForm.Controls.Add(LbPelicula, 0, 1);
            TlpForm.Controls.Add(LbTrailer, 2, 1);
            TlpForm.Controls.Add(LbDuracion, 0, 2);
            TlpForm.Controls.Add(LbClasificacion, 0, 3);
            TlpForm.Controls.Add(LbGeneros, 0, 4);
            TlpForm.Controls.Add(LbFormatos, 0, 5);
            TlpForm.Controls.Add(LbEstreno, 2, 5);
            TlpForm.Controls.Add(LbEstado, 2, 4);
            TlpForm.Controls.Add(DpEstreno, 3, 5);
            TlpForm.Controls.Add(LbDescripcion, 2, 2);
            TlpForm.Controls.Add(RtbDescripcion, 3, 2);
            TlpForm.Controls.Add(TbTitulo, 1, 1);
            TlpForm.Controls.Add(TbDuracion, 1, 2);
            TlpForm.Controls.Add(TbDirector, 3, 0);
            TlpForm.Controls.Add(TbTrailer, 3, 1);
            TlpForm.Controls.Add(TbID, 1, 0);
            TlpForm.Controls.Add(TbGeneros, 1, 4);
            TlpForm.Controls.Add(TbFormatos, 1, 5);
            TlpForm.Controls.Add(customComboBox2, 1, 3);
            TlpForm.Controls.Add(customComboBox3, 3, 4);
            TlpForm.Dock = DockStyle.Fill;
            TlpForm.Location = new Point(0, 0);
            TlpForm.Margin = new Padding(0);
            TlpForm.Name = "TlpForm";
            TlpForm.RowCount = 6;
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.Size = new Size(765, 300);
            TlpForm.TabIndex = 0;
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
            LbID.Size = new Size(127, 50);
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
            LbDirector.Location = new Point(385, 0);
            LbDirector.Margin = new Padding(3, 0, 0, 0);
            LbDirector.Name = "LbDirector";
            LbDirector.Padding = new Padding(0, 0, 2, 0);
            LbDirector.Size = new Size(127, 50);
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
            LbPelicula.Size = new Size(127, 50);
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
            LbTrailer.Location = new Point(385, 50);
            LbTrailer.Margin = new Padding(3, 0, 0, 0);
            LbTrailer.Name = "LbTrailer";
            LbTrailer.Padding = new Padding(0, 0, 2, 0);
            LbTrailer.Size = new Size(127, 50);
            LbTrailer.TabIndex = 14;
            LbTrailer.Text = "Trailer";
            LbTrailer.TextAlign = ContentAlignment.MiddleRight;
            LbTrailer.Click += LbTrailer_Click;
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
            LbDuracion.Size = new Size(127, 50);
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
            LbClasificacion.Location = new Point(3, 150);
            LbClasificacion.Margin = new Padding(3, 0, 0, 0);
            LbClasificacion.Name = "LbClasificacion";
            LbClasificacion.Padding = new Padding(0, 0, 2, 0);
            LbClasificacion.Size = new Size(127, 49);
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
            LbGeneros.Location = new Point(3, 199);
            LbGeneros.Margin = new Padding(3, 0, 0, 0);
            LbGeneros.Name = "LbGeneros";
            LbGeneros.Padding = new Padding(0, 0, 2, 0);
            LbGeneros.Size = new Size(127, 51);
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
            LbFormatos.Size = new Size(127, 50);
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
            LbEstreno.Location = new Point(385, 250);
            LbEstreno.Margin = new Padding(3, 0, 0, 0);
            LbEstreno.Name = "LbEstreno";
            LbEstreno.Padding = new Padding(0, 0, 2, 0);
            LbEstreno.Size = new Size(127, 50);
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
            LbEstado.Location = new Point(385, 199);
            LbEstado.Margin = new Padding(3, 0, 0, 0);
            LbEstado.Name = "LbEstado";
            LbEstado.Padding = new Padding(0, 0, 2, 0);
            LbEstado.Size = new Size(127, 51);
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
            LbDescripcion.Location = new Point(385, 100);
            LbDescripcion.Margin = new Padding(3, 0, 0, 0);
            LbDescripcion.Name = "LbDescripcion";
            LbDescripcion.Padding = new Padding(0, 0, 2, 0);
            LbDescripcion.Size = new Size(127, 50);
            LbDescripcion.TabIndex = 50;
            LbDescripcion.Text = "Descripción";
            LbDescripcion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RtbDescripcion
            // 
            RtbDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RtbDescripcion.BackColor = Color.FromArgb(55, 60, 72);
            RtbDescripcion.BorderStyle = BorderStyle.FixedSingle;
            RtbDescripcion.Font = new Font("Segoe UI", 10F);
            RtbDescripcion.ForeColor = Color.FromArgb(230, 230, 230);
            RtbDescripcion.Location = new Point(517, 105);
            RtbDescripcion.Margin = new Padding(5);
            RtbDescripcion.MinimumSize = new Size(190, 60);
            RtbDescripcion.Name = "RtbDescripcion";
            TlpForm.SetRowSpan(RtbDescripcion, 2);
            RtbDescripcion.Size = new Size(243, 89);
            RtbDescripcion.TabIndex = 52;
            RtbDescripcion.Text = "";
            // 
            // TbTitulo
            // 
            TbTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbTitulo.BackColor = Color.FromArgb(55, 60, 72);
            TbTitulo.BorderStyle = BorderStyle.FixedSingle;
            TbTitulo.Font = new Font("Segoe UI", 10F);
            TbTitulo.ForeColor = Color.FromArgb(160, 165, 175);
            TbTitulo.Location = new Point(135, 60);
            TbTitulo.Margin = new Padding(5);
            TbTitulo.MaximumSize = new Size(0, 30);
            TbTitulo.MinimumSize = new Size(190, 30);
            TbTitulo.Name = "TbTitulo";
            TbTitulo.PlaceholderText = "Evil Dead";
            TbTitulo.Size = new Size(242, 30);
            TbTitulo.TabIndex = 53;
            // 
            // TbDuracion
            // 
            TbDuracion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbDuracion.BackColor = Color.FromArgb(55, 60, 72);
            TbDuracion.BorderStyle = BorderStyle.FixedSingle;
            TbDuracion.Font = new Font("Segoe UI", 10F);
            TbDuracion.ForeColor = Color.FromArgb(160, 165, 175);
            TbDuracion.Location = new Point(135, 110);
            TbDuracion.Margin = new Padding(5);
            TbDuracion.MaximumSize = new Size(0, 30);
            TbDuracion.MinimumSize = new Size(190, 30);
            TbDuracion.Name = "TbDuracion";
            TbDuracion.PlaceholderText = "120";
            TbDuracion.Size = new Size(242, 30);
            TbDuracion.TabIndex = 54;
            // 
            // TbDirector
            // 
            TbDirector.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbDirector.BackColor = Color.FromArgb(55, 60, 72);
            TbDirector.BorderStyle = BorderStyle.FixedSingle;
            TbDirector.Font = new Font("Segoe UI", 10F);
            TbDirector.ForeColor = Color.FromArgb(230, 230, 230);
            TbDirector.Location = new Point(517, 10);
            TbDirector.Margin = new Padding(5);
            TbDirector.MaximumSize = new Size(0, 30);
            TbDirector.MinimumSize = new Size(190, 30);
            TbDirector.Name = "TbDirector";
            TbDirector.Size = new Size(243, 30);
            TbDirector.TabIndex = 57;
            // 
            // TbTrailer
            // 
            TbTrailer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbTrailer.BackColor = Color.FromArgb(55, 60, 72);
            TbTrailer.BorderStyle = BorderStyle.FixedSingle;
            TbTrailer.Font = new Font("Segoe UI", 10F);
            TbTrailer.ForeColor = Color.FromArgb(230, 230, 230);
            TbTrailer.Location = new Point(517, 60);
            TbTrailer.Margin = new Padding(5);
            TbTrailer.MaximumSize = new Size(0, 30);
            TbTrailer.MinimumSize = new Size(190, 30);
            TbTrailer.Name = "TbTrailer";
            TbTrailer.Size = new Size(243, 30);
            TbTrailer.TabIndex = 59;
            // 
            // TbID
            // 
            TbID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbID.BackColor = Color.FromArgb(28, 30, 38);
            TbID.BorderStyle = BorderStyle.FixedSingle;
            TbID.Font = new Font("Segoe UI", 10F);
            TbID.ForeColor = Color.FromArgb(120, 125, 135);
            TbID.Location = new Point(135, 10);
            TbID.Margin = new Padding(5);
            TbID.MaximumSize = new Size(0, 30);
            TbID.MinimumSize = new Size(190, 30);
            TbID.Name = "TbID";
            TbID.ReadOnly = true;
            TbID.Size = new Size(242, 30);
            TbID.TabIndex = 60;
            TbID.TabStop = false;
            // 
            // TbGeneros
            // 
            TbGeneros.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbGeneros.BackColor = Color.FromArgb(28, 30, 38);
            TbGeneros.BorderStyle = BorderStyle.FixedSingle;
            TbGeneros.Font = new Font("Segoe UI", 10F);
            TbGeneros.ForeColor = Color.FromArgb(120, 125, 135);
            TbGeneros.Location = new Point(135, 209);
            TbGeneros.Margin = new Padding(5);
            TbGeneros.MaximumSize = new Size(0, 30);
            TbGeneros.MinimumSize = new Size(190, 30);
            TbGeneros.Name = "TbGeneros";
            TbGeneros.ReadOnly = true;
            TbGeneros.Size = new Size(242, 30);
            TbGeneros.TabIndex = 61;
            TbGeneros.TabStop = false;
            // 
            // TbFormatos
            // 
            TbFormatos.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbFormatos.BackColor = Color.FromArgb(28, 30, 38);
            TbFormatos.BorderStyle = BorderStyle.FixedSingle;
            TbFormatos.Font = new Font("Segoe UI", 10F);
            TbFormatos.ForeColor = Color.FromArgb(120, 125, 135);
            TbFormatos.Location = new Point(135, 260);
            TbFormatos.Margin = new Padding(5);
            TbFormatos.MaximumSize = new Size(0, 30);
            TbFormatos.MinimumSize = new Size(190, 30);
            TbFormatos.Name = "TbFormatos";
            TbFormatos.ReadOnly = true;
            TbFormatos.Size = new Size(242, 30);
            TbFormatos.TabIndex = 62;
            TbFormatos.TabStop = false;
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
            TlpButtons.Controls.Add(BtnIngresar, 1, 0);
            TlpButtons.Controls.Add(BtnEliminar, 4, 0);
            TlpButtons.Controls.Add(BtnCopiar, 2, 0);
            TlpButtons.Controls.Add(BtnActualizar, 3, 0);
            TlpButtons.Dock = DockStyle.Fill;
            TlpButtons.Location = new Point(0, 300);
            TlpButtons.Margin = new Padding(0);
            TlpButtons.Name = "TlpButtons";
            TlpButtons.RowCount = 1;
            TlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpButtons.Size = new Size(875, 75);
            TlpButtons.TabIndex = 3;
            // 
            // BtnIngresar
            // 
            BtnIngresar.Anchor = AnchorStyles.None;
            BtnIngresar.BackColor = Color.FromArgb(41, 128, 185);
            BtnIngresar.FlatAppearance.BorderSize = 0;
            BtnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 75, 109);
            BtnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 134, 194);
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnIngresar.ForeColor = Color.White;
            BtnIngresar.Location = new Point(222, 17);
            BtnIngresar.Margin = new Padding(0);
            BtnIngresar.MaximumSize = new Size(100, 40);
            BtnIngresar.MinimumSize = new Size(100, 40);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(100, 40);
            BtnIngresar.TabIndex = 1;
            BtnIngresar.Text = "Ingresar";
            BtnIngresar.UseVisualStyleBackColor = false;
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
            BtnEliminar.Location = new Point(552, 17);
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
            BtnCopiar.Location = new Point(332, 17);
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
            BtnActualizar.Location = new Point(442, 17);
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
            LbTitulo.ForeColor = Color.FromArgb(41, 128, 185);
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
            TlpAux3.Location = new Point(0, 450);
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
            TlpFilter.Controls.Add(customButton6, 2, 0);
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
            // customButton6
            // 
            customButton6.Action = Componentes.ButtonAction.Buscar;
            customButton6.Anchor = AnchorStyles.None;
            customButton6.BackColor = Color.FromArgb(39, 174, 96);
            customButton6.FlatAppearance.BorderSize = 0;
            customButton6.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 104, 57);
            customButton6.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 186, 103);
            customButton6.FlatStyle = FlatStyle.Flat;
            customButton6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            customButton6.ForeColor = Color.White;
            customButton6.Location = new Point(405, 17);
            customButton6.Margin = new Padding(0);
            customButton6.MaximumSize = new Size(100, 40);
            customButton6.MinimumSize = new Size(100, 40);
            customButton6.Name = "customButton6";
            customButton6.Size = new Size(100, 40);
            customButton6.TabIndex = 5;
            customButton6.Text = "Buscar";
            customButton6.UseVisualStyleBackColor = false;
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
            CbFiltro.Font = new Font("Segoe UI", 9F);
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
            DgvPelicula.Location = new Point(0, 525);
            DgvPelicula.Margin = new Padding(0);
            DgvPelicula.MultiSelect = false;
            DgvPelicula.Name = "DgvPelicula";
            DgvPelicula.ReadOnly = true;
            DgvPelicula.RowHeadersVisible = false;
            DgvPelicula.RowHeadersWidth = 51;
            DgvPelicula.RowTemplate.Height = 36;
            DgvPelicula.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPelicula.Size = new Size(1050, 175);
            DgvPelicula.TabIndex = 2;
            // 
            // customComboBox2
            // 
            customComboBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customComboBox2.BaseColor = Color.FromArgb(25, 27, 29);
            customComboBox2.BGColor = Color.FromArgb(45, 47, 49);
            customComboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            customComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            customComboBox2.Font = new Font("Segoe UI", 9F);
            customComboBox2.ForeColor = Color.White;
            customComboBox2.FormattingEnabled = true;
            customComboBox2.HoverColor = Color.FromArgb(35, 168, 109);
            customComboBox2.HoverFontColor = Color.White;
            customComboBox2.ItemHeight = 24;
            customComboBox2.Location = new Point(135, 165);
            customComboBox2.Margin = new Padding(5);
            customComboBox2.MinimumSize = new Size(190, 0);
            customComboBox2.Name = "customComboBox2";
            customComboBox2.Size = new Size(242, 30);
            customComboBox2.TabIndex = 64;
            // 
            // customComboBox3
            // 
            customComboBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customComboBox3.BaseColor = Color.FromArgb(25, 27, 29);
            customComboBox3.BGColor = Color.FromArgb(45, 47, 49);
            customComboBox3.DrawMode = DrawMode.OwnerDrawFixed;
            customComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            customComboBox3.Font = new Font("Segoe UI", 9F);
            customComboBox3.ForeColor = Color.White;
            customComboBox3.FormattingEnabled = true;
            customComboBox3.HoverColor = Color.FromArgb(35, 168, 109);
            customComboBox3.HoverFontColor = Color.White;
            customComboBox3.ItemHeight = 24;
            customComboBox3.Location = new Point(517, 215);
            customComboBox3.Margin = new Padding(5);
            customComboBox3.MinimumSize = new Size(190, 0);
            customComboBox3.Name = "customComboBox3";
            customComboBox3.Size = new Size(243, 30);
            customComboBox3.TabIndex = 65;
            // 
            // FrBorrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            Controls.Add(TlpDivFormAndDgv);
            Name = "FrBorrador";
            Size = new Size(1050, 700);
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
        private TableLayoutPanel TlpButtons;
        private Componentes.CustomButton BtnIngresar;
        private Componentes.CustomButton BtnEliminar;
        private Componentes.CustomButton BtnCopiar;
        private Componentes.CustomButton BtnActualizar;
        private TableLayoutPanel TlpTitleLabel;
        private Componentes.CustomTitleLabel LbTitulo;
        private TableLayoutPanel TlpAux3;
        private TableLayoutPanel TlpFilter;
        private Componentes.CustomButton customButton6;
        private Componentes.CustomDataGridView DgvPelicula;
        private Componentes.CustomComboBox customComboBox4;
        private Componentes.CustomComboBox customComboBox1;
        private Componentes.CustomDatePicker DpEstreno;
        private Componentes.CustomTextBox customTextBox2;
        private Componentes.CustomTextBox customTextBox4;
        private Componentes.CustomTextBox customTextBox5;
        private Componentes.CustomLabel LbDescripcion;
        private Componentes.CustomComboBox CbFiltro;
        private Componentes.CustomTextBox TbFiltro;
        private Componentes.CustomRichTextBox RtbDescripcion;
        private Componentes.CustomTextBox TbTitulo;
        private Componentes.CustomTextBox TbDuracion;
        private Componentes.CustomTextBox TbDirector;
        private Componentes.CustomTextBox TbTrailer;
        private Componentes.CustomIDTextBox TbID;
        private Componentes.CustomIDTextBox TbGeneros;
        private Componentes.CustomIDTextBox TbFormatos;
        private Componentes.CustomComboBox customComboBox2;
        private Componentes.CustomComboBox customComboBox3;
    }
}
