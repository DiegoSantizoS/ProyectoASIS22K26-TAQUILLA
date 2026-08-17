namespace Formularios_Admin
{
    partial class FrUcAsignarPermisos
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
            BtnBuscar = new Componentes.CustomButton();
            TbFiltro = new Componentes.CustomTextBox();
            TlpTitleLabel = new TableLayoutPanel();
            LbTitulo = new Componentes.CustomTitleLabel();
            TlpAux2 = new TableLayoutPanel();
            TlpFormWithButtons = new TableLayoutPanel();
            TlpForm = new TableLayoutPanel();
            ListBoxActualizar = new Componentes.CustomListBox();
            ListBoxEliminar = new Componentes.CustomListBox();
            ListBoxRegistrar = new Componentes.CustomListBox();
            LbRegistrar = new Componentes.CustomLabel();
            ListBoxMant = new Componentes.CustomListBox();
            LbPerfil = new Componentes.CustomLabel();
            CbPerfil = new Componentes.CustomComboBox();
            BtnActualizar = new Componentes.CustomButton();
            LbEliminar = new Componentes.CustomLabel();
            LbMantenimiento = new Componentes.CustomLabel();
            LbActualizar = new Componentes.CustomLabel();
            TlpAux1 = new TableLayoutPanel();
            TlpTitleLabel.SuspendLayout();
            TlpAux2.SuspendLayout();
            TlpFormWithButtons.SuspendLayout();
            TlpForm.SuspendLayout();
            TlpAux1.SuspendLayout();
            SuspendLayout();
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
            LbTitulo.Text = "ASIGNAR PERMISOS";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TlpAux2
            // 
            TlpAux2.ColumnCount = 3;
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 750F));
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux2.Controls.Add(TlpFormWithButtons, 1, 0);
            TlpAux2.Dock = DockStyle.Fill;
            TlpAux2.Location = new Point(0, 75);
            TlpAux2.Margin = new Padding(0);
            TlpAux2.Name = "TlpAux2";
            TlpAux2.RowCount = 1;
            TlpAux2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpAux2.Size = new Size(1050, 675);
            TlpAux2.TabIndex = 0;
            TlpAux2.Paint += TlpAux2_Paint;
            // 
            // TlpFormWithButtons
            // 
            TlpFormWithButtons.ColumnCount = 1;
            TlpFormWithButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpFormWithButtons.Controls.Add(TlpForm, 0, 0);
            TlpFormWithButtons.Dock = DockStyle.Fill;
            TlpFormWithButtons.Location = new Point(150, 0);
            TlpFormWithButtons.Margin = new Padding(0);
            TlpFormWithButtons.Name = "TlpFormWithButtons";
            TlpFormWithButtons.RowCount = 1;
            TlpFormWithButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpFormWithButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpFormWithButtons.Size = new Size(750, 675);
            TlpFormWithButtons.TabIndex = 0;
            // 
            // TlpForm
            // 
            TlpForm.ColumnCount = 2;
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpForm.Controls.Add(ListBoxActualizar, 1, 5);
            TlpForm.Controls.Add(ListBoxEliminar, 0, 5);
            TlpForm.Controls.Add(ListBoxRegistrar, 1, 3);
            TlpForm.Controls.Add(LbRegistrar, 1, 2);
            TlpForm.Controls.Add(ListBoxMant, 0, 3);
            TlpForm.Controls.Add(LbPerfil, 0, 0);
            TlpForm.Controls.Add(CbPerfil, 0, 1);
            TlpForm.Controls.Add(BtnActualizar, 1, 0);
            TlpForm.Controls.Add(LbEliminar, 0, 4);
            TlpForm.Controls.Add(LbMantenimiento, 0, 2);
            TlpForm.Controls.Add(LbActualizar, 1, 4);
            TlpForm.Dock = DockStyle.Fill;
            TlpForm.Location = new Point(0, 0);
            TlpForm.Margin = new Padding(0);
            TlpForm.Name = "TlpForm";
            TlpForm.RowCount = 7;
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 260F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 260F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpForm.Size = new Size(750, 675);
            TlpForm.TabIndex = 0;
            TlpForm.Paint += TlpForm_Paint;
            // 
            // ListBoxActualizar
            // 
            ListBoxActualizar.Dock = DockStyle.Fill;
            ListBoxActualizar.Location = new Point(380, 385);
            ListBoxActualizar.Margin = new Padding(5, 0, 5, 10);
            ListBoxActualizar.Name = "ListBoxActualizar";
            ListBoxActualizar.SelectionMode = SelectionMode.MultiSimple;
            ListBoxActualizar.Size = new Size(365, 250);
            ListBoxActualizar.StateCheckedNormal.Item.Back.Color1 = Color.Crimson;
            ListBoxActualizar.StateCheckedNormal.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxActualizar.StateCheckedNormal.Item.Content.LongText.Font = new Font("Segoe UI", 8.5F);
            ListBoxActualizar.StateCheckedNormal.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxActualizar.StateCheckedNormal.Item.Content.ShortText.Font = new Font("Segoe UI", 8.5F);
            ListBoxActualizar.StateCheckedTracking.Item.Back.Color1 = Color.Crimson;
            ListBoxActualizar.StateCheckedTracking.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxActualizar.StateCheckedTracking.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxActualizar.StateCommon.Back.Color1 = Color.FromArgb(55, 60, 72);
            ListBoxActualizar.StateCommon.Border.Color1 = Color.FromArgb(40, 40, 40);
            ListBoxActualizar.StateCommon.Border.Color2 = Color.FromArgb(40, 40, 40);
            ListBoxActualizar.StateCommon.Item.Back.Color1 = Color.FromArgb(55, 60, 72);
            ListBoxActualizar.StateCommon.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxActualizar.StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxActualizar.StateTracking.Item.Back.Color1 = Color.Crimson;
            ListBoxActualizar.StateTracking.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxActualizar.StateTracking.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxActualizar.TabIndex = 79;
            // 
            // ListBoxEliminar
            // 
            ListBoxEliminar.Dock = DockStyle.Fill;
            ListBoxEliminar.Location = new Point(5, 385);
            ListBoxEliminar.Margin = new Padding(5, 0, 5, 10);
            ListBoxEliminar.Name = "ListBoxEliminar";
            ListBoxEliminar.SelectionMode = SelectionMode.MultiSimple;
            ListBoxEliminar.Size = new Size(365, 250);
            ListBoxEliminar.StateCheckedNormal.Item.Back.Color1 = Color.Crimson;
            ListBoxEliminar.StateCheckedNormal.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxEliminar.StateCheckedNormal.Item.Content.LongText.Font = new Font("Segoe UI", 8.5F);
            ListBoxEliminar.StateCheckedNormal.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxEliminar.StateCheckedNormal.Item.Content.ShortText.Font = new Font("Segoe UI", 8.5F);
            ListBoxEliminar.StateCheckedTracking.Item.Back.Color1 = Color.Crimson;
            ListBoxEliminar.StateCheckedTracking.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxEliminar.StateCheckedTracking.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxEliminar.StateCommon.Back.Color1 = Color.FromArgb(55, 60, 72);
            ListBoxEliminar.StateCommon.Border.Color1 = Color.FromArgb(40, 40, 40);
            ListBoxEliminar.StateCommon.Border.Color2 = Color.FromArgb(40, 40, 40);
            ListBoxEliminar.StateCommon.Item.Back.Color1 = Color.FromArgb(55, 60, 72);
            ListBoxEliminar.StateCommon.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxEliminar.StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxEliminar.StateTracking.Item.Back.Color1 = Color.Crimson;
            ListBoxEliminar.StateTracking.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxEliminar.StateTracking.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxEliminar.TabIndex = 78;
            // 
            // ListBoxRegistrar
            // 
            ListBoxRegistrar.Dock = DockStyle.Fill;
            ListBoxRegistrar.Location = new Point(380, 100);
            ListBoxRegistrar.Margin = new Padding(5, 0, 5, 10);
            ListBoxRegistrar.Name = "ListBoxRegistrar";
            ListBoxRegistrar.SelectionMode = SelectionMode.MultiSimple;
            ListBoxRegistrar.Size = new Size(365, 250);
            ListBoxRegistrar.StateCheckedNormal.Item.Back.Color1 = Color.Crimson;
            ListBoxRegistrar.StateCheckedNormal.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxRegistrar.StateCheckedNormal.Item.Content.LongText.Font = new Font("Segoe UI", 8.5F);
            ListBoxRegistrar.StateCheckedNormal.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxRegistrar.StateCheckedNormal.Item.Content.ShortText.Font = new Font("Segoe UI", 8.5F);
            ListBoxRegistrar.StateCheckedTracking.Item.Back.Color1 = Color.Crimson;
            ListBoxRegistrar.StateCheckedTracking.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxRegistrar.StateCheckedTracking.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxRegistrar.StateCommon.Back.Color1 = Color.FromArgb(55, 60, 72);
            ListBoxRegistrar.StateCommon.Border.Color1 = Color.FromArgb(40, 40, 40);
            ListBoxRegistrar.StateCommon.Border.Color2 = Color.FromArgb(40, 40, 40);
            ListBoxRegistrar.StateCommon.Item.Back.Color1 = Color.FromArgb(55, 60, 72);
            ListBoxRegistrar.StateCommon.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxRegistrar.StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxRegistrar.StateTracking.Item.Back.Color1 = Color.Crimson;
            ListBoxRegistrar.StateTracking.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxRegistrar.StateTracking.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxRegistrar.TabIndex = 77;
            // 
            // LbRegistrar
            // 
            LbRegistrar.AutoSize = true;
            LbRegistrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbRegistrar.ForeColor = Color.FromArgb(220, 220, 220);
            LbRegistrar.Location = new Point(378, 75);
            LbRegistrar.Margin = new Padding(3, 0, 0, 0);
            LbRegistrar.Name = "LbRegistrar";
            LbRegistrar.Padding = new Padding(0, 0, 2, 0);
            LbRegistrar.Size = new Size(85, 23);
            LbRegistrar.TabIndex = 74;
            LbRegistrar.Text = "Registrar";
            LbRegistrar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ListBoxMant
            // 
            ListBoxMant.Dock = DockStyle.Fill;
            ListBoxMant.Location = new Point(5, 100);
            ListBoxMant.Margin = new Padding(5, 0, 5, 10);
            ListBoxMant.Name = "ListBoxMant";
            ListBoxMant.SelectionMode = SelectionMode.MultiSimple;
            ListBoxMant.Size = new Size(365, 250);
            ListBoxMant.StateCheckedNormal.Item.Back.Color1 = Color.Crimson;
            ListBoxMant.StateCheckedNormal.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxMant.StateCheckedNormal.Item.Content.LongText.Font = new Font("Segoe UI", 8.5F);
            ListBoxMant.StateCheckedNormal.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxMant.StateCheckedNormal.Item.Content.ShortText.Font = new Font("Segoe UI", 8.5F);
            ListBoxMant.StateCheckedTracking.Item.Back.Color1 = Color.Crimson;
            ListBoxMant.StateCheckedTracking.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxMant.StateCheckedTracking.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxMant.StateCommon.Back.Color1 = Color.FromArgb(55, 60, 72);
            ListBoxMant.StateCommon.Border.Color1 = Color.FromArgb(40, 40, 40);
            ListBoxMant.StateCommon.Border.Color2 = Color.FromArgb(40, 40, 40);
            ListBoxMant.StateCommon.Item.Back.Color1 = Color.FromArgb(55, 60, 72);
            ListBoxMant.StateCommon.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxMant.StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxMant.StateTracking.Item.Back.Color1 = Color.Crimson;
            ListBoxMant.StateTracking.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxMant.StateTracking.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxMant.TabIndex = 70;
            // 
            // LbPerfil
            // 
            LbPerfil.AutoSize = true;
            LbPerfil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbPerfil.ForeColor = Color.FromArgb(220, 220, 220);
            LbPerfil.Location = new Point(3, 0);
            LbPerfil.Margin = new Padding(3, 0, 0, 0);
            LbPerfil.Name = "LbPerfil";
            LbPerfil.Padding = new Padding(0, 0, 2, 0);
            LbPerfil.Size = new Size(54, 23);
            LbPerfil.TabIndex = 12;
            LbPerfil.Text = "Perfil";
            LbPerfil.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CbPerfil
            // 
            CbPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CbPerfil.BackColor = Color.FromArgb(55, 60, 72);
            CbPerfil.BaseColor = Color.FromArgb(40, 40, 40);
            CbPerfil.BGColor = Color.FromArgb(55, 60, 72);
            CbPerfil.DrawMode = DrawMode.OwnerDrawFixed;
            CbPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            CbPerfil.FlatStyle = FlatStyle.Flat;
            CbPerfil.Font = new Font("Segoe UI", 9.5F);
            CbPerfil.ForeColor = Color.FromArgb(230, 230, 230);
            CbPerfil.FormattingEnabled = true;
            CbPerfil.HoverColor = Color.Crimson;
            CbPerfil.HoverFontColor = Color.White;
            CbPerfil.ItemHeight = 24;
            CbPerfil.Location = new Point(5, 25);
            CbPerfil.Margin = new Padding(5, 0, 5, 10);
            CbPerfil.MinimumSize = new Size(190, 0);
            CbPerfil.Name = "CbPerfil";
            CbPerfil.Size = new Size(365, 30);
            CbPerfil.TabIndex = 73;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Action = Componentes.ButtonAction.Actualizar;
            BtnActualizar.Anchor = AnchorStyles.Left;
            BtnActualizar.BackColor = Color.FromArgb(214, 157, 15);
            BtnActualizar.FlatAppearance.BorderSize = 0;
            BtnActualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(130, 97, 9);
            BtnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 169, 16);
            BtnActualizar.FlatStyle = FlatStyle.Flat;
            BtnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnActualizar.ForeColor = Color.White;
            BtnActualizar.Location = new Point(375, 17);
            BtnActualizar.Margin = new Padding(0);
            BtnActualizar.MaximumSize = new Size(100, 40);
            BtnActualizar.MinimumSize = new Size(100, 40);
            BtnActualizar.Name = "BtnActualizar";
            TlpForm.SetRowSpan(BtnActualizar, 2);
            BtnActualizar.Size = new Size(100, 40);
            BtnActualizar.TabIndex = 5;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = false;
            // 
            // LbEliminar
            // 
            LbEliminar.AutoSize = true;
            LbEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbEliminar.ForeColor = Color.FromArgb(220, 220, 220);
            LbEliminar.Location = new Point(3, 360);
            LbEliminar.Margin = new Padding(3, 0, 0, 0);
            LbEliminar.Name = "LbEliminar";
            LbEliminar.Padding = new Padding(0, 0, 2, 0);
            LbEliminar.Size = new Size(78, 23);
            LbEliminar.TabIndex = 75;
            LbEliminar.Text = "Eliminar";
            LbEliminar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LbMantenimiento
            // 
            LbMantenimiento.AutoSize = true;
            LbMantenimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbMantenimiento.ForeColor = Color.FromArgb(220, 220, 220);
            LbMantenimiento.Location = new Point(3, 75);
            LbMantenimiento.Margin = new Padding(3, 0, 0, 0);
            LbMantenimiento.Name = "LbMantenimiento";
            LbMantenimiento.Padding = new Padding(0, 0, 2, 0);
            LbMantenimiento.Size = new Size(135, 23);
            LbMantenimiento.TabIndex = 69;
            LbMantenimiento.Text = "Mantenimiento";
            LbMantenimiento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LbActualizar
            // 
            LbActualizar.AutoSize = true;
            LbActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbActualizar.ForeColor = Color.FromArgb(220, 220, 220);
            LbActualizar.Location = new Point(378, 360);
            LbActualizar.Margin = new Padding(3, 0, 0, 0);
            LbActualizar.Name = "LbActualizar";
            LbActualizar.Padding = new Padding(0, 0, 2, 0);
            LbActualizar.Size = new Size(92, 23);
            LbActualizar.TabIndex = 76;
            LbActualizar.Text = "Actualizar";
            LbActualizar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TlpAux1
            // 
            TlpAux1.ColumnCount = 1;
            TlpAux1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpAux1.Controls.Add(TlpAux2, 0, 1);
            TlpAux1.Controls.Add(TlpTitleLabel, 0, 0);
            TlpAux1.Dock = DockStyle.Fill;
            TlpAux1.Location = new Point(0, 0);
            TlpAux1.Margin = new Padding(0);
            TlpAux1.Name = "TlpAux1";
            TlpAux1.RowCount = 2;
            TlpAux1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TlpAux1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpAux1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpAux1.Size = new Size(1050, 750);
            TlpAux1.TabIndex = 1;
            // 
            // FrUcAsignarPermisos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(TlpAux1);
            MinimumSize = new Size(1050, 750);
            Name = "FrUcAsignarPermisos";
            Size = new Size(1050, 750);
            TlpTitleLabel.ResumeLayout(false);
            TlpTitleLabel.PerformLayout();
            TlpAux2.ResumeLayout(false);
            TlpFormWithButtons.ResumeLayout(false);
            TlpForm.ResumeLayout(false);
            TlpForm.PerformLayout();
            TlpAux1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Componentes.CustomButton BtnBuscar;
        private Componentes.CustomTextBox TbFiltro;
        private TableLayoutPanel TlpTitleLabel;
        private Componentes.CustomTitleLabel LbTitulo;
        private TableLayoutPanel TlpAux2;
        private TableLayoutPanel TlpFormWithButtons;
        private TableLayoutPanel TlpForm;
        private Componentes.CustomListBox ListBoxMant;
        private Componentes.CustomLabel LbPerfil;
        private Componentes.CustomComboBox CbPerfil;
        private Componentes.CustomLabel LbMantenimiento;
        private Componentes.CustomButton BtnActualizar;
        private TableLayoutPanel TlpAux1;
        private Componentes.CustomLabel LbRegistrar;
        private Componentes.CustomListBox ListBoxActualizar;
        private Componentes.CustomListBox ListBoxEliminar;
        private Componentes.CustomListBox ListBoxRegistrar;
        private Componentes.CustomLabel LbEliminar;
        private Componentes.CustomLabel LbActualizar;
    }
}
