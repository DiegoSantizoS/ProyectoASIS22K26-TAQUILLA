namespace Formularios_Admin
{
    partial class FrUcPeliculaPromocionada
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            TlpDivFormAndDgv = new TableLayoutPanel();
            TlpAux1 = new TableLayoutPanel();
            TlpAux2 = new TableLayoutPanel();
            TlpFormWithButtons = new TableLayoutPanel();
            BtnLimpiar = new Componentes.CustomButton();
            TlpForm = new TableLayoutPanel();
            customComboBox2 = new Componentes.CustomComboBox();
            customComboBox1 = new Componentes.CustomComboBox();
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
            customLabel1 = new Componentes.CustomLabel();
            customLabel2 = new Componentes.CustomLabel();
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
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Absolute, 394F));
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Size = new Size(919, 525);
            TlpDivFormAndDgv.TabIndex = 5;
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
            TlpAux1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            TlpAux1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpAux1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            TlpAux1.Size = new Size(919, 394);
            TlpAux1.TabIndex = 1;
            // 
            // TlpAux2
            // 
            TlpAux2.ColumnCount = 3;
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 766F));
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux2.Controls.Add(TlpFormWithButtons, 1, 0);
            TlpAux2.Dock = DockStyle.Fill;
            TlpAux2.Location = new Point(0, 56);
            TlpAux2.Margin = new Padding(0);
            TlpAux2.Name = "TlpAux2";
            TlpAux2.RowCount = 1;
            TlpAux2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpAux2.Size = new Size(919, 282);
            TlpAux2.TabIndex = 0;
            // 
            // TlpFormWithButtons
            // 
            TlpFormWithButtons.ColumnCount = 2;
            TlpFormWithButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpFormWithButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            TlpFormWithButtons.Controls.Add(BtnLimpiar, 1, 0);
            TlpFormWithButtons.Controls.Add(TlpForm, 0, 0);
            TlpFormWithButtons.Controls.Add(TlpButtons, 0, 1);
            TlpFormWithButtons.Dock = DockStyle.Fill;
            TlpFormWithButtons.Location = new Point(76, 0);
            TlpFormWithButtons.Margin = new Padding(0);
            TlpFormWithButtons.Name = "TlpFormWithButtons";
            TlpFormWithButtons.RowCount = 2;
            TlpFormWithButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpFormWithButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            TlpFormWithButtons.Size = new Size(766, 282);
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
            BtnLimpiar.Location = new Point(678, 8);
            BtnLimpiar.Margin = new Padding(0, 8, 0, 0);
            BtnLimpiar.MaximumSize = new Size(88, 30);
            BtnLimpiar.MinimumSize = new Size(88, 30);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(88, 30);
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
            TlpForm.Controls.Add(customComboBox1, 1, 2);
            TlpForm.Controls.Add(customComboBox2, 3, 2);
            TlpForm.Controls.Add(customLabel1, 0, 2);
            TlpForm.Controls.Add(customLabel2, 2, 2);
            TlpForm.Dock = DockStyle.Fill;
            TlpForm.Location = new Point(0, 0);
            TlpForm.Margin = new Padding(0);
            TlpForm.Name = "TlpForm";
            TlpForm.RowCount = 6;
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            TlpForm.Size = new Size(670, 226);
            TlpForm.TabIndex = 0;
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
            customComboBox2.Location = new Point(452, 86);
            customComboBox2.Margin = new Padding(5);
            customComboBox2.MinimumSize = new Size(190, 0);
            customComboBox2.Name = "customComboBox2";
            customComboBox2.Size = new Size(213, 30);
            customComboBox2.TabIndex = 7;
            // 
            // customComboBox1
            // 
            customComboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customComboBox1.BaseColor = Color.FromArgb(25, 27, 29);
            customComboBox1.BGColor = Color.FromArgb(45, 47, 49);
            customComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            customComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            customComboBox1.Font = new Font("Segoe UI", 9F);
            customComboBox1.ForeColor = Color.White;
            customComboBox1.FormattingEnabled = true;
            customComboBox1.HoverColor = Color.FromArgb(35, 168, 109);
            customComboBox1.HoverFontColor = Color.White;
            customComboBox1.ItemHeight = 24;
            customComboBox1.Location = new Point(118, 86);
            customComboBox1.Margin = new Padding(5);
            customComboBox1.MinimumSize = new Size(190, 0);
            customComboBox1.Name = "customComboBox1";
            customComboBox1.Size = new Size(211, 30);
            customComboBox1.TabIndex = 6;
            // 
            // TlpButtons
            // 
            TlpButtons.ColumnCount = 6;
            TlpFormWithButtons.SetColumnSpan(TlpButtons, 2);
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.Controls.Add(BtnIngresar, 1, 0);
            TlpButtons.Controls.Add(BtnEliminar, 4, 0);
            TlpButtons.Controls.Add(BtnCopiar, 2, 0);
            TlpButtons.Controls.Add(BtnActualizar, 3, 0);
            TlpButtons.Dock = DockStyle.Fill;
            TlpButtons.Location = new Point(0, 226);
            TlpButtons.Margin = new Padding(0);
            TlpButtons.Name = "TlpButtons";
            TlpButtons.RowCount = 1;
            TlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpButtons.Size = new Size(766, 56);
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
            BtnIngresar.Location = new Point(195, 13);
            BtnIngresar.Margin = new Padding(0);
            BtnIngresar.MaximumSize = new Size(88, 30);
            BtnIngresar.MinimumSize = new Size(88, 30);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(88, 30);
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
            BtnEliminar.Location = new Point(483, 13);
            BtnEliminar.Margin = new Padding(0);
            BtnEliminar.MaximumSize = new Size(88, 30);
            BtnEliminar.MinimumSize = new Size(88, 30);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(88, 30);
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
            BtnCopiar.Location = new Point(291, 13);
            BtnCopiar.Margin = new Padding(0);
            BtnCopiar.MaximumSize = new Size(88, 30);
            BtnCopiar.MinimumSize = new Size(88, 30);
            BtnCopiar.Name = "BtnCopiar";
            BtnCopiar.Size = new Size(88, 30);
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
            BtnActualizar.Location = new Point(387, 13);
            BtnActualizar.Margin = new Padding(0);
            BtnActualizar.MaximumSize = new Size(88, 30);
            BtnActualizar.MinimumSize = new Size(88, 30);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(88, 30);
            BtnActualizar.TabIndex = 2;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = false;
            // 
            // TlpTitleLabel
            // 
            TlpTitleLabel.ColumnCount = 3;
            TlpTitleLabel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpTitleLabel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 438F));
            TlpTitleLabel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpTitleLabel.Controls.Add(LbTitulo, 1, 0);
            TlpTitleLabel.Dock = DockStyle.Fill;
            TlpTitleLabel.Location = new Point(0, 0);
            TlpTitleLabel.Margin = new Padding(0);
            TlpTitleLabel.Name = "TlpTitleLabel";
            TlpTitleLabel.RowCount = 1;
            TlpTitleLabel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpTitleLabel.Size = new Size(919, 56);
            TlpTitleLabel.TabIndex = 1;
            // 
            // LbTitulo
            // 
            LbTitulo.AutoSize = true;
            LbTitulo.Dock = DockStyle.Fill;
            LbTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LbTitulo.ForeColor = Color.FromArgb(41, 128, 185);
            LbTitulo.Location = new Point(243, 0);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(432, 56);
            LbTitulo.TabIndex = 0;
            LbTitulo.Text = "PELÍCULA PROMOCIONADA";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            LbTitulo.Click += LbTitulo_Click;
            // 
            // TlpAux3
            // 
            TlpAux3.ColumnCount = 3;
            TlpAux3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 446F));
            TlpAux3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux3.Controls.Add(TlpFilter, 1, 0);
            TlpAux3.Dock = DockStyle.Fill;
            TlpAux3.Location = new Point(0, 338);
            TlpAux3.Margin = new Padding(0);
            TlpAux3.Name = "TlpAux3";
            TlpAux3.RowCount = 1;
            TlpAux3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpAux3.Size = new Size(919, 56);
            TlpAux3.TabIndex = 2;
            // 
            // TlpFilter
            // 
            TlpFilter.ColumnCount = 3;
            TlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            TlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            TlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            TlpFilter.Controls.Add(customButton6, 2, 0);
            TlpFilter.Controls.Add(CbFiltro, 0, 0);
            TlpFilter.Controls.Add(TbFiltro, 1, 0);
            TlpFilter.Dock = DockStyle.Fill;
            TlpFilter.Location = new Point(236, 0);
            TlpFilter.Margin = new Padding(0);
            TlpFilter.Name = "TlpFilter";
            TlpFilter.RowCount = 1;
            TlpFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpFilter.Size = new Size(446, 56);
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
            customButton6.Location = new Point(354, 13);
            customButton6.Margin = new Padding(0);
            customButton6.MaximumSize = new Size(88, 30);
            customButton6.MinimumSize = new Size(88, 30);
            customButton6.Name = "customButton6";
            customButton6.Size = new Size(88, 30);
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
            CbFiltro.Location = new Point(4, 15);
            CbFiltro.Margin = new Padding(4);
            CbFiltro.MinimumSize = new Size(167, 0);
            CbFiltro.Name = "CbFiltro";
            CbFiltro.Size = new Size(167, 26);
            CbFiltro.TabIndex = 6;
            // 
            // TbFiltro
            // 
            TbFiltro.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbFiltro.BackColor = Color.FromArgb(55, 60, 72);
            TbFiltro.BorderStyle = BorderStyle.FixedSingle;
            TbFiltro.Font = new Font("Segoe UI", 10F);
            TbFiltro.ForeColor = Color.FromArgb(230, 230, 230);
            TbFiltro.Location = new Point(179, 16);
            TbFiltro.Margin = new Padding(4);
            TbFiltro.MaximumSize = new Size(2, 23);
            TbFiltro.MinimumSize = new Size(166, 23);
            TbFiltro.Name = "TbFiltro";
            TbFiltro.Size = new Size(166, 23);
            TbFiltro.TabIndex = 7;
            // 
            // DgvPelicula
            // 
            DgvPelicula.AllowUserToAddRows = false;
            DgvPelicula.AllowUserToResizeColumns = false;
            DgvPelicula.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(50, 55, 66);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            DgvPelicula.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            DgvPelicula.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPelicula.BackgroundColor = Color.FromArgb(55, 60, 72);
            DgvPelicula.BorderStyle = BorderStyle.None;
            DgvPelicula.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvPelicula.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            DgvPelicula.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            DgvPelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(55, 60, 72);
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle15.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            DgvPelicula.DefaultCellStyle = dataGridViewCellStyle15;
            DgvPelicula.Dock = DockStyle.Fill;
            DgvPelicula.EnableHeadersVisualStyles = false;
            DgvPelicula.Font = new Font("Segoe UI", 9.5F);
            DgvPelicula.GridColor = Color.FromArgb(70, 76, 90);
            DgvPelicula.Location = new Point(0, 394);
            DgvPelicula.Margin = new Padding(0);
            DgvPelicula.MultiSelect = false;
            DgvPelicula.Name = "DgvPelicula";
            DgvPelicula.ReadOnly = true;
            DgvPelicula.RowHeadersVisible = false;
            DgvPelicula.RowHeadersWidth = 51;
            DgvPelicula.RowTemplate.Height = 36;
            DgvPelicula.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPelicula.Size = new Size(919, 131);
            DgvPelicula.TabIndex = 2;
            // 
            // customLabel1
            // 
            customLabel1.AutoSize = true;
            customLabel1.Dock = DockStyle.Fill;
            customLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            customLabel1.ForeColor = Color.FromArgb(220, 220, 220);
            customLabel1.Location = new Point(3, 76);
            customLabel1.Name = "customLabel1";
            customLabel1.Padding = new Padding(0, 0, 2, 0);
            customLabel1.Size = new Size(107, 38);
            customLabel1.TabIndex = 8;
            customLabel1.Text = "Pelicula";
            customLabel1.TextAlign = ContentAlignment.MiddleRight;
            customLabel1.Click += customLabel1_Click;
            // 
            // customLabel2
            // 
            customLabel2.AutoSize = true;
            customLabel2.Dock = DockStyle.Fill;
            customLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            customLabel2.ForeColor = Color.FromArgb(220, 220, 220);
            customLabel2.Location = new Point(337, 76);
            customLabel2.Name = "customLabel2";
            customLabel2.Padding = new Padding(0, 0, 2, 0);
            customLabel2.Size = new Size(107, 38);
            customLabel2.TabIndex = 9;
            customLabel2.Text = "Promoción";
            customLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrUcPeliculaPromocionada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(TlpDivFormAndDgv);
            Name = "FrUcPeliculaPromocionada";
            Size = new Size(919, 525);
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
        private Componentes.CustomComboBox customComboBox2;
        private Componentes.CustomComboBox customComboBox1;
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
        private Componentes.CustomComboBox CbFiltro;
        private Componentes.CustomTextBox TbFiltro;
        private Componentes.CustomDataGridView DgvPelicula;
        private Componentes.CustomLabel customLabel1;
        private Componentes.CustomLabel customLabel2;
    }
}
