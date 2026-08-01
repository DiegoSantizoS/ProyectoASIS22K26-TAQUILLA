namespace Formularios_Admin
{
    partial class FrUcPermisos
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
            LbAplicacion = new Componentes.CustomLabel();
            LbID = new Componentes.CustomLabel();
            LbNombreUsuario = new Componentes.CustomLabel();
            TbDirector = new Componentes.CustomTextBox();
            TbID = new Componentes.CustomIDTextBox();
            LbTipos = new Componentes.CustomLabel();
            ListBoxTipos = new Krypton.Toolkit.KryptonListBox();
            LbAccion = new Componentes.CustomLabel();
            ListBoxAccion = new Krypton.Toolkit.KryptonListBox();
            ListBoxAplicacion = new Krypton.Toolkit.KryptonListBox();
            TlpButtons = new TableLayoutPanel();
            BtnSeleccionar = new Componentes.CustomButton();
            BtnActualizar = new Componentes.CustomButton();
            TlpTitleLabel = new TableLayoutPanel();
            LbTitulo = new Componentes.CustomTitleLabel();
            TlpAux3 = new TableLayoutPanel();
            TlpFilter = new TableLayoutPanel();
            BtnBuscar = new Componentes.CustomButton();
            CbFiltro = new Componentes.CustomComboBox();
            TbFiltro = new Componentes.CustomTextBox();
            DgvUsuarios = new Componentes.CustomDataGridView();
            TlpDivFormAndDgv.SuspendLayout();
            TlpAux1.SuspendLayout();
            TlpAux2.SuspendLayout();
            TlpFormWithButtons.SuspendLayout();
            TlpForm.SuspendLayout();
            TlpButtons.SuspendLayout();
            TlpTitleLabel.SuspendLayout();
            TlpAux3.SuspendLayout();
            TlpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // TlpDivFormAndDgv
            // 
            TlpDivFormAndDgv.ColumnCount = 1;
            TlpDivFormAndDgv.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Controls.Add(TlpAux1, 0, 0);
            TlpDivFormAndDgv.Controls.Add(DgvUsuarios, 0, 1);
            TlpDivFormAndDgv.Dock = DockStyle.Fill;
            TlpDivFormAndDgv.Location = new Point(0, 0);
            TlpDivFormAndDgv.Margin = new Padding(0);
            TlpDivFormAndDgv.Name = "TlpDivFormAndDgv";
            TlpDivFormAndDgv.RowCount = 2;
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Absolute, 575F));
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Size = new Size(1050, 750);
            TlpDivFormAndDgv.TabIndex = 8;
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
            TlpAux1.Size = new Size(1050, 575);
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
            TlpAux2.Size = new Size(1050, 425);
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
            TlpFormWithButtons.Size = new Size(900, 425);
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
            TlpForm.Controls.Add(LbAplicacion, 3, 1);
            TlpForm.Controls.Add(LbID, 0, 0);
            TlpForm.Controls.Add(LbNombreUsuario, 2, 0);
            TlpForm.Controls.Add(TbDirector, 3, 0);
            TlpForm.Controls.Add(TbID, 1, 0);
            TlpForm.Controls.Add(LbTipos, 1, 1);
            TlpForm.Controls.Add(LbAccion, 1, 4);
            TlpForm.Controls.Add(ListBoxAccion, 1, 5);
            TlpForm.Controls.Add(ListBoxAplicacion, 3, 2);
            TlpForm.Controls.Add(ListBoxTipos, 1, 2);
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
            TlpForm.Size = new Size(790, 350);
            TlpForm.TabIndex = 0;
            // 
            // LbAplicacion
            // 
            LbAplicacion.AutoSize = true;
            LbAplicacion.Dock = DockStyle.Fill;
            LbAplicacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbAplicacion.ForeColor = Color.FromArgb(220, 220, 220);
            LbAplicacion.Location = new Point(531, 50);
            LbAplicacion.Margin = new Padding(3, 0, 0, 0);
            LbAplicacion.Name = "LbAplicacion";
            LbAplicacion.Padding = new Padding(0, 0, 2, 0);
            LbAplicacion.Size = new Size(259, 50);
            LbAplicacion.TabIndex = 69;
            LbAplicacion.Text = "Generos";
            LbAplicacion.TextAlign = ContentAlignment.MiddleLeft;
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
            // LbNombreUsuario
            // 
            LbNombreUsuario.AutoSize = true;
            LbNombreUsuario.Dock = DockStyle.Fill;
            LbNombreUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbNombreUsuario.ForeColor = Color.FromArgb(220, 220, 220);
            LbNombreUsuario.Location = new Point(397, 0);
            LbNombreUsuario.Margin = new Padding(3, 0, 0, 0);
            LbNombreUsuario.Name = "LbNombreUsuario";
            LbNombreUsuario.Padding = new Padding(0, 0, 2, 0);
            LbNombreUsuario.Size = new Size(131, 50);
            LbNombreUsuario.TabIndex = 12;
            LbNombreUsuario.Text = "Usuario";
            LbNombreUsuario.TextAlign = ContentAlignment.MiddleRight;
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
            TbDirector.PlaceholderText = "DSantizoS";
            TbDirector.Size = new Size(252, 30);
            TbDirector.TabIndex = 57;
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
            // LbTipos
            // 
            LbTipos.AutoSize = true;
            LbTipos.Dock = DockStyle.Fill;
            LbTipos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbTipos.ForeColor = Color.FromArgb(220, 220, 220);
            LbTipos.Location = new Point(137, 50);
            LbTipos.Margin = new Padding(3, 0, 0, 0);
            LbTipos.Name = "LbTipos";
            LbTipos.Padding = new Padding(0, 0, 2, 0);
            LbTipos.Size = new Size(257, 50);
            LbTipos.TabIndex = 21;
            LbTipos.Text = "Tipos";
            LbTipos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ListBoxTipos
            // 
            ListBoxTipos.Items.AddRange(new object[] { "fsdf", "sdfsd", "fsdf", "sdf", "sdf", "s\t\t\t" });
            ListBoxTipos.Location = new Point(137, 103);
            ListBoxTipos.Name = "ListBoxTipos";
            TlpForm.SetRowSpan(ListBoxTipos, 2);
            ListBoxTipos.Size = new Size(250, 94);
            ListBoxTipos.TabIndex = 67;
            // 
            // LbAccion
            // 
            LbAccion.AutoSize = true;
            LbAccion.Dock = DockStyle.Fill;
            LbAccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbAccion.ForeColor = Color.FromArgb(220, 220, 220);
            LbAccion.Location = new Point(137, 200);
            LbAccion.Margin = new Padding(3, 0, 0, 0);
            LbAccion.Name = "LbAccion";
            LbAccion.Padding = new Padding(0, 0, 2, 0);
            LbAccion.Size = new Size(257, 50);
            LbAccion.TabIndex = 19;
            LbAccion.Text = "Acción";
            LbAccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ListBoxAccion
            // 
            ListBoxAccion.Items.AddRange(new object[] { "fsdf", "sdfsd", "fsdf", "sdf", "sdf", "s\t\t\t" });
            ListBoxAccion.Location = new Point(137, 253);
            ListBoxAccion.Name = "ListBoxAccion";
            TlpForm.SetRowSpan(ListBoxAccion, 2);
            ListBoxAccion.SelectionMode = SelectionMode.MultiSimple;
            ListBoxAccion.Size = new Size(250, 94);
            ListBoxAccion.TabIndex = 5;
            // 
            // ListBoxAplicacion
            // 
            ListBoxAplicacion.Items.AddRange(new object[] { "fsdf", "sdfsd", "fsdf", "sdf", "sdf", "s\t\t\t" });
            ListBoxAplicacion.Location = new Point(531, 103);
            ListBoxAplicacion.Name = "ListBoxAplicacion";
            TlpForm.SetRowSpan(ListBoxAplicacion, 5);
            ListBoxAplicacion.SelectionMode = SelectionMode.MultiSimple;
            ListBoxAplicacion.Size = new Size(250, 244);
            ListBoxAplicacion.TabIndex = 68;
            // 
            // TlpButtons
            // 
            TlpButtons.ColumnCount = 4;
            TlpFormWithButtons.SetColumnSpan(TlpButtons, 2);
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.Controls.Add(BtnSeleccionar, 1, 0);
            TlpButtons.Controls.Add(BtnActualizar, 2, 0);
            TlpButtons.Dock = DockStyle.Fill;
            TlpButtons.Location = new Point(0, 350);
            TlpButtons.Margin = new Padding(0);
            TlpButtons.Name = "TlpButtons";
            TlpButtons.RowCount = 1;
            TlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpButtons.Size = new Size(900, 75);
            TlpButtons.TabIndex = 3;
            // 
            // BtnSeleccionar
            // 
            BtnSeleccionar.Action = Componentes.ButtonAction.Copiar;
            BtnSeleccionar.Anchor = AnchorStyles.None;
            BtnSeleccionar.BackColor = Color.FromArgb(26, 156, 156);
            BtnSeleccionar.FlatAppearance.BorderSize = 0;
            BtnSeleccionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 95, 95);
            BtnSeleccionar.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 169, 169);
            BtnSeleccionar.FlatStyle = FlatStyle.Flat;
            BtnSeleccionar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSeleccionar.ForeColor = Color.White;
            BtnSeleccionar.Location = new Point(340, 17);
            BtnSeleccionar.Margin = new Padding(0);
            BtnSeleccionar.MaximumSize = new Size(110, 40);
            BtnSeleccionar.MinimumSize = new Size(110, 40);
            BtnSeleccionar.Name = "BtnSeleccionar";
            BtnSeleccionar.Size = new Size(110, 40);
            BtnSeleccionar.TabIndex = 3;
            BtnSeleccionar.Text = "Seleccionar";
            BtnSeleccionar.UseVisualStyleBackColor = false;
            BtnSeleccionar.Click += BtnCopiar_Click_1;
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
            BtnActualizar.Location = new Point(460, 17);
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
            LbTitulo.Text = "PERMISOS";
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
            TlpAux3.Location = new Point(0, 500);
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
            // DgvUsuarios
            // 
            DgvUsuarios.AllowUserToAddRows = false;
            DgvUsuarios.AllowUserToResizeColumns = false;
            DgvUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 55, 66);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            DgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvUsuarios.BackgroundColor = Color.FromArgb(55, 60, 72);
            DgvUsuarios.BorderStyle = BorderStyle.None;
            DgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(55, 60, 72);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            DgvUsuarios.Dock = DockStyle.Fill;
            DgvUsuarios.EnableHeadersVisualStyles = false;
            DgvUsuarios.Font = new Font("Segoe UI", 9.5F);
            DgvUsuarios.GridColor = Color.FromArgb(70, 76, 90);
            DgvUsuarios.Location = new Point(0, 575);
            DgvUsuarios.Margin = new Padding(0);
            DgvUsuarios.MultiSelect = false;
            DgvUsuarios.Name = "DgvUsuarios";
            DgvUsuarios.ReadOnly = true;
            DgvUsuarios.RowHeadersVisible = false;
            DgvUsuarios.RowHeadersWidth = 51;
            DgvUsuarios.RowTemplate.Height = 36;
            DgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvUsuarios.Size = new Size(1050, 175);
            DgvUsuarios.TabIndex = 2;
            // 
            // FrUcPermisos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(TlpDivFormAndDgv);
            MinimumSize = new Size(1050, 750);
            Name = "FrUcPermisos";
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
            ((System.ComponentModel.ISupportInitialize)DgvUsuarios).EndInit();
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
        private Componentes.CustomLabel LbNombreUsuario;
        private Componentes.CustomLabel LbAccion;
        private Componentes.CustomLabel LbTipos;
        private Componentes.CustomTextBox TbDirector;
        private Componentes.CustomIDTextBox TbID;
        private Krypton.Toolkit.KryptonListBox ListBoxTipos;
        private Krypton.Toolkit.KryptonListBox ListBoxAccion;
        private TableLayoutPanel TlpButtons;
        private Componentes.CustomButton BtnAgregar;
        private Componentes.CustomButton BtnSeleccionar;
        private Componentes.CustomButton BtnActualizar;
        private TableLayoutPanel TlpTitleLabel;
        private Componentes.CustomTitleLabel LbTitulo;
        private TableLayoutPanel TlpAux3;
        private TableLayoutPanel TlpFilter;
        private Componentes.CustomButton BtnBuscar;
        private Componentes.CustomComboBox CbFiltro;
        private Componentes.CustomTextBox TbFiltro;
        private Componentes.CustomDataGridView DgvUsuarios;
        private Componentes.CustomLabel LbAplicacion;
        private Krypton.Toolkit.KryptonListBox ListBoxAplicacion;
    }
}
