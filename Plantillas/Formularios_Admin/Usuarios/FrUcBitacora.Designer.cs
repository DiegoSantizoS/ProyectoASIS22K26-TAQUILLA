namespace Forms_Admin.Usuarios
{
    partial class FrUcBitacora
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
            TlpForm = new TableLayoutPanel();
            RtbDatosUsuario = new Componentes.CustomRichTextBox();
            LbIDPermiso = new Componentes.CustomLabel();
            TbIdPermiso = new Componentes.CustomTextBox();
            LbNombreDePC = new Componentes.CustomLabel();
            TbIdUsuario = new Componentes.CustomTextBox();
            RtbDatosCliente = new Componentes.CustomRichTextBox();
            BtnBuscarNombreDePC = new Componentes.CustomButton();
            LbFecha = new Componentes.CustomLabel();
            DatePickerFecha = new Componentes.CustomDatePicker();
            LbIP = new Componentes.CustomLabel();
            TbTotalDeVenta = new Componentes.CustomTextBox();
            customRichTextBox1 = new Componentes.CustomRichTextBox();
            customLabel1 = new Componentes.CustomLabel();
            customTextBox1 = new Componentes.CustomTextBox();
            BtnBuscarPermiso = new Componentes.CustomButton();
            BtnBuscarUsuario = new Componentes.CustomButton();
            TlpButtons = new TableLayoutPanel();
            BtnBuscar = new Componentes.CustomButton();
            BtnLimpiar = new Componentes.CustomButton();
            TlpTitleLabel = new TableLayoutPanel();
            LbTitulo = new Componentes.CustomTitleLabel();
            DgvBitacora = new Componentes.CustomDataGridView();
            TlpDivFormAndDgv.SuspendLayout();
            TlpAux1.SuspendLayout();
            TlpAux2.SuspendLayout();
            TlpFormWithButtons.SuspendLayout();
            TlpForm.SuspendLayout();
            TlpButtons.SuspendLayout();
            TlpTitleLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBitacora).BeginInit();
            SuspendLayout();
            // 
            // TlpDivFormAndDgv
            // 
            TlpDivFormAndDgv.BackColor = Color.Black;
            TlpDivFormAndDgv.ColumnCount = 1;
            TlpDivFormAndDgv.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Controls.Add(TlpAux1, 0, 0);
            TlpDivFormAndDgv.Controls.Add(DgvBitacora, 0, 1);
            TlpDivFormAndDgv.Dock = DockStyle.Fill;
            TlpDivFormAndDgv.Location = new Point(0, 0);
            TlpDivFormAndDgv.Margin = new Padding(0);
            TlpDivFormAndDgv.Name = "TlpDivFormAndDgv";
            TlpDivFormAndDgv.RowCount = 2;
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Absolute, 500F));
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Size = new Size(1050, 700);
            TlpDivFormAndDgv.TabIndex = 9;
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
            TlpAux1.Size = new Size(1050, 500);
            TlpAux1.TabIndex = 1;
            // 
            // TlpAux2
            // 
            TlpAux2.ColumnCount = 3;
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 930F));
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux2.Controls.Add(TlpFormWithButtons, 1, 0);
            TlpAux2.Dock = DockStyle.Fill;
            TlpAux2.Location = new Point(0, 75);
            TlpAux2.Margin = new Padding(0);
            TlpAux2.Name = "TlpAux2";
            TlpAux2.RowCount = 1;
            TlpAux2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpAux2.Size = new Size(1050, 425);
            TlpAux2.TabIndex = 2;
            // 
            // TlpFormWithButtons
            // 
            TlpFormWithButtons.ColumnCount = 1;
            TlpFormWithButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpFormWithButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TlpFormWithButtons.Controls.Add(TlpForm, 0, 0);
            TlpFormWithButtons.Controls.Add(TlpButtons, 0, 1);
            TlpFormWithButtons.Dock = DockStyle.Fill;
            TlpFormWithButtons.Location = new Point(60, 0);
            TlpFormWithButtons.Margin = new Padding(0);
            TlpFormWithButtons.Name = "TlpFormWithButtons";
            TlpFormWithButtons.RowCount = 2;
            TlpFormWithButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpFormWithButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TlpFormWithButtons.Size = new Size(930, 425);
            TlpFormWithButtons.TabIndex = 0;
            // 
            // TlpForm
            // 
            TlpForm.ColumnCount = 6;
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TlpForm.Controls.Add(RtbDatosUsuario, 4, 4);
            TlpForm.Controls.Add(LbIDPermiso, 2, 2);
            TlpForm.Controls.Add(TbIdPermiso, 2, 3);
            TlpForm.Controls.Add(LbNombreDePC, 4, 2);
            TlpForm.Controls.Add(TbIdUsuario, 4, 3);
            TlpForm.Controls.Add(RtbDatosCliente, 2, 4);
            TlpForm.Controls.Add(BtnBuscarNombreDePC, 5, 2);
            TlpForm.Controls.Add(LbFecha, 0, 0);
            TlpForm.Controls.Add(DatePickerFecha, 0, 1);
            TlpForm.Controls.Add(customRichTextBox1, 0, 4);
            TlpForm.Controls.Add(customLabel1, 0, 2);
            TlpForm.Controls.Add(customTextBox1, 0, 3);
            TlpForm.Controls.Add(BtnBuscarPermiso, 3, 2);
            TlpForm.Controls.Add(BtnBuscarUsuario, 1, 2);
            TlpForm.Controls.Add(LbIP, 2, 0);
            TlpForm.Controls.Add(TbTotalDeVenta, 2, 1);
            TlpForm.Dock = DockStyle.Fill;
            TlpForm.Location = new Point(0, 0);
            TlpForm.Margin = new Padding(0);
            TlpForm.Name = "TlpForm";
            TlpForm.RowCount = 8;
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpForm.Size = new Size(930, 350);
            TlpForm.TabIndex = 0;
            // 
            // RtbDatosUsuario
            // 
            RtbDatosUsuario.BackColor = Color.FromArgb(35, 40, 52);
            RtbDatosUsuario.BorderStyle = BorderStyle.None;
            TlpForm.SetColumnSpan(RtbDatosUsuario, 2);
            RtbDatosUsuario.Dock = DockStyle.Fill;
            RtbDatosUsuario.Font = new Font("Segoe UI", 10F);
            RtbDatosUsuario.ForeColor = Color.FromArgb(230, 230, 230);
            RtbDatosUsuario.Location = new Point(625, 160);
            RtbDatosUsuario.Margin = new Padding(5, 10, 5, 10);
            RtbDatosUsuario.MinimumSize = new Size(190, 60);
            RtbDatosUsuario.Name = "RtbDatosUsuario";
            TlpForm.SetRowSpan(RtbDatosUsuario, 4);
            RtbDatosUsuario.Size = new Size(300, 180);
            RtbDatosUsuario.TabIndex = 84;
            RtbDatosUsuario.Text = "";
            // 
            // LbIDPermiso
            // 
            LbIDPermiso.AutoSize = true;
            LbIDPermiso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbIDPermiso.ForeColor = Color.FromArgb(220, 220, 220);
            LbIDPermiso.Location = new Point(313, 75);
            LbIDPermiso.Margin = new Padding(3, 0, 0, 0);
            LbIDPermiso.Name = "LbIDPermiso";
            LbIDPermiso.Padding = new Padding(0, 0, 2, 0);
            LbIDPermiso.Size = new Size(98, 23);
            LbIDPermiso.TabIndex = 12;
            LbIDPermiso.Text = "ID Permiso";
            LbIDPermiso.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbIdPermiso
            // 
            TbIdPermiso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbIdPermiso.BackColor = Color.FromArgb(55, 60, 72);
            TbIdPermiso.BorderStyle = BorderStyle.FixedSingle;
            TbIdPermiso.Font = new Font("Segoe UI", 10F);
            TbIdPermiso.ForeColor = Color.FromArgb(160, 165, 175);
            TbIdPermiso.Location = new Point(315, 100);
            TbIdPermiso.Margin = new Padding(5, 0, 5, 10);
            TbIdPermiso.MaximumSize = new Size(0, 30);
            TbIdPermiso.MinimumSize = new Size(190, 30);
            TbIdPermiso.Name = "TbIdPermiso";
            TbIdPermiso.PlaceholderText = "1";
            TbIdPermiso.Size = new Size(190, 30);
            TbIdPermiso.TabIndex = 80;
            // 
            // LbNombreDePC
            // 
            LbNombreDePC.AutoSize = true;
            LbNombreDePC.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbNombreDePC.ForeColor = Color.FromArgb(220, 220, 220);
            LbNombreDePC.Location = new Point(623, 75);
            LbNombreDePC.Name = "LbNombreDePC";
            LbNombreDePC.Padding = new Padding(0, 0, 2, 0);
            LbNombreDePC.Size = new Size(131, 23);
            LbNombreDePC.TabIndex = 68;
            LbNombreDePC.Text = "Nombre De PC";
            LbNombreDePC.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbIdUsuario
            // 
            TbIdUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbIdUsuario.BackColor = Color.FromArgb(55, 60, 72);
            TbIdUsuario.BorderStyle = BorderStyle.FixedSingle;
            TbIdUsuario.Font = new Font("Segoe UI", 10F);
            TbIdUsuario.ForeColor = Color.FromArgb(160, 165, 175);
            TbIdUsuario.Location = new Point(625, 100);
            TbIdUsuario.Margin = new Padding(5, 0, 5, 10);
            TbIdUsuario.MaximumSize = new Size(0, 30);
            TbIdUsuario.MinimumSize = new Size(190, 30);
            TbIdUsuario.Name = "TbIdUsuario";
            TbIdUsuario.PlaceholderText = "1";
            TbIdUsuario.Size = new Size(190, 30);
            TbIdUsuario.TabIndex = 79;
            // 
            // RtbDatosCliente
            // 
            RtbDatosCliente.BackColor = Color.FromArgb(35, 40, 52);
            RtbDatosCliente.BorderStyle = BorderStyle.None;
            TlpForm.SetColumnSpan(RtbDatosCliente, 2);
            RtbDatosCliente.Dock = DockStyle.Fill;
            RtbDatosCliente.Font = new Font("Segoe UI", 10F);
            RtbDatosCliente.ForeColor = Color.FromArgb(230, 230, 230);
            RtbDatosCliente.Location = new Point(315, 160);
            RtbDatosCliente.Margin = new Padding(5, 10, 5, 10);
            RtbDatosCliente.MinimumSize = new Size(190, 60);
            RtbDatosCliente.Name = "RtbDatosCliente";
            TlpForm.SetRowSpan(RtbDatosCliente, 4);
            RtbDatosCliente.Size = new Size(300, 180);
            RtbDatosCliente.TabIndex = 83;
            RtbDatosCliente.Text = "";
            // 
            // BtnBuscarNombreDePC
            // 
            BtnBuscarNombreDePC.Action = Componentes.ButtonAction.Actualizar;
            BtnBuscarNombreDePC.Anchor = AnchorStyles.None;
            BtnBuscarNombreDePC.BackColor = Color.FromArgb(214, 157, 15);
            BtnBuscarNombreDePC.FlatAppearance.BorderSize = 0;
            BtnBuscarNombreDePC.FlatAppearance.MouseDownBackColor = Color.FromArgb(130, 97, 9);
            BtnBuscarNombreDePC.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 169, 16);
            BtnBuscarNombreDePC.FlatStyle = FlatStyle.Flat;
            BtnBuscarNombreDePC.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnBuscarNombreDePC.ForeColor = Color.White;
            BtnBuscarNombreDePC.Location = new Point(820, 90);
            BtnBuscarNombreDePC.Margin = new Padding(0, 0, 0, 4);
            BtnBuscarNombreDePC.MaximumSize = new Size(100, 40);
            BtnBuscarNombreDePC.MinimumSize = new Size(100, 40);
            BtnBuscarNombreDePC.Name = "BtnBuscarNombreDePC";
            TlpForm.SetRowSpan(BtnBuscarNombreDePC, 2);
            BtnBuscarNombreDePC.Size = new Size(100, 40);
            BtnBuscarNombreDePC.TabIndex = 82;
            BtnBuscarNombreDePC.Text = "Buscar";
            BtnBuscarNombreDePC.UseVisualStyleBackColor = false;
            // 
            // LbFecha
            // 
            LbFecha.AutoSize = true;
            LbFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbFecha.ForeColor = Color.FromArgb(220, 220, 220);
            LbFecha.Location = new Point(3, 0);
            LbFecha.Name = "LbFecha";
            LbFecha.Padding = new Padding(0, 0, 2, 0);
            LbFecha.Size = new Size(57, 23);
            LbFecha.TabIndex = 61;
            LbFecha.Text = "Fecha";
            LbFecha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DatePickerFecha
            // 
            DatePickerFecha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TlpForm.SetColumnSpan(DatePickerFecha, 2);
            DatePickerFecha.CustomFormat = "dd/MM/yyyy";
            DatePickerFecha.Format = DateTimePickerFormat.Custom;
            DatePickerFecha.Location = new Point(5, 25);
            DatePickerFecha.Margin = new Padding(5, 0, 5, 10);
            DatePickerFecha.MaximumSize = new Size(0, 30);
            DatePickerFecha.MinimumSize = new Size(190, 30);
            DatePickerFecha.Name = "DatePickerFecha";
            DatePickerFecha.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkModeAlternate;
            DatePickerFecha.Size = new Size(300, 30);
            DatePickerFecha.StateActive.Back.Color1 = Color.FromArgb(55, 60, 72);
            DatePickerFecha.StateActive.Border.Color1 = Color.FromArgb(40, 40, 40);
            DatePickerFecha.StateActive.Border.Color2 = Color.FromArgb(40, 40, 40);
            DatePickerFecha.StateActive.Content.Color1 = Color.FromArgb(230, 230, 230);
            DatePickerFecha.StateCommon.Back.Color1 = Color.FromArgb(55, 60, 72);
            DatePickerFecha.StateCommon.Border.Color1 = Color.FromArgb(40, 40, 40);
            DatePickerFecha.StateCommon.Border.Color2 = Color.FromArgb(40, 40, 40);
            DatePickerFecha.StateCommon.Content.Color1 = Color.FromArgb(230, 230, 230);
            DatePickerFecha.TabIndex = 73;
            // 
            // LbIP
            // 
            LbIP.AutoSize = true;
            LbIP.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbIP.ForeColor = Color.FromArgb(220, 220, 220);
            LbIP.Location = new Point(313, 0);
            LbIP.Name = "LbIP";
            LbIP.Padding = new Padding(0, 0, 2, 0);
            LbIP.Size = new Size(46, 23);
            LbIP.TabIndex = 72;
            LbIP.Text = "IPv4";
            LbIP.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbTotalDeVenta
            // 
            TbTotalDeVenta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbTotalDeVenta.BackColor = Color.FromArgb(55, 60, 72);
            TbTotalDeVenta.BorderStyle = BorderStyle.FixedSingle;
            TlpForm.SetColumnSpan(TbTotalDeVenta, 2);
            TbTotalDeVenta.Font = new Font("Segoe UI", 10F);
            TbTotalDeVenta.ForeColor = Color.FromArgb(160, 165, 175);
            TbTotalDeVenta.Location = new Point(315, 25);
            TbTotalDeVenta.Margin = new Padding(5, 0, 5, 10);
            TbTotalDeVenta.MaximumSize = new Size(0, 30);
            TbTotalDeVenta.MinimumSize = new Size(190, 30);
            TbTotalDeVenta.Name = "TbTotalDeVenta";
            TbTotalDeVenta.PlaceholderText = "100";
            TbTotalDeVenta.Size = new Size(300, 30);
            TbTotalDeVenta.TabIndex = 66;
            // 
            // customRichTextBox1
            // 
            customRichTextBox1.BackColor = Color.FromArgb(35, 40, 52);
            customRichTextBox1.BorderStyle = BorderStyle.None;
            TlpForm.SetColumnSpan(customRichTextBox1, 2);
            customRichTextBox1.Dock = DockStyle.Fill;
            customRichTextBox1.Font = new Font("Segoe UI", 10F);
            customRichTextBox1.ForeColor = Color.FromArgb(230, 230, 230);
            customRichTextBox1.Location = new Point(5, 160);
            customRichTextBox1.Margin = new Padding(5, 10, 5, 10);
            customRichTextBox1.MinimumSize = new Size(190, 60);
            customRichTextBox1.Name = "customRichTextBox1";
            TlpForm.SetRowSpan(customRichTextBox1, 4);
            customRichTextBox1.Size = new Size(300, 180);
            customRichTextBox1.TabIndex = 85;
            customRichTextBox1.Text = "";
            // 
            // customLabel1
            // 
            customLabel1.AutoSize = true;
            customLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            customLabel1.ForeColor = Color.FromArgb(220, 220, 220);
            customLabel1.Location = new Point(3, 75);
            customLabel1.Margin = new Padding(3, 0, 0, 0);
            customLabel1.Name = "customLabel1";
            customLabel1.Padding = new Padding(0, 0, 2, 0);
            customLabel1.Size = new Size(91, 23);
            customLabel1.TabIndex = 86;
            customLabel1.Text = "ID Cliente";
            customLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // customTextBox1
            // 
            customTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customTextBox1.BackColor = Color.FromArgb(55, 60, 72);
            customTextBox1.BorderStyle = BorderStyle.FixedSingle;
            customTextBox1.Font = new Font("Segoe UI", 10F);
            customTextBox1.ForeColor = Color.FromArgb(160, 165, 175);
            customTextBox1.Location = new Point(5, 100);
            customTextBox1.Margin = new Padding(5, 0, 5, 10);
            customTextBox1.MaximumSize = new Size(0, 30);
            customTextBox1.MinimumSize = new Size(190, 30);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.PlaceholderText = "1";
            customTextBox1.Size = new Size(190, 30);
            customTextBox1.TabIndex = 87;
            // 
            // BtnBuscarPermiso
            // 
            BtnBuscarPermiso.Action = Componentes.ButtonAction.Actualizar;
            BtnBuscarPermiso.Anchor = AnchorStyles.None;
            BtnBuscarPermiso.BackColor = Color.FromArgb(214, 157, 15);
            BtnBuscarPermiso.FlatAppearance.BorderSize = 0;
            BtnBuscarPermiso.FlatAppearance.MouseDownBackColor = Color.FromArgb(130, 97, 9);
            BtnBuscarPermiso.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 169, 16);
            BtnBuscarPermiso.FlatStyle = FlatStyle.Flat;
            BtnBuscarPermiso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnBuscarPermiso.ForeColor = Color.White;
            BtnBuscarPermiso.Location = new Point(510, 90);
            BtnBuscarPermiso.Margin = new Padding(0, 0, 0, 4);
            BtnBuscarPermiso.MaximumSize = new Size(100, 40);
            BtnBuscarPermiso.MinimumSize = new Size(100, 40);
            BtnBuscarPermiso.Name = "BtnBuscarPermiso";
            TlpForm.SetRowSpan(BtnBuscarPermiso, 2);
            BtnBuscarPermiso.Size = new Size(100, 40);
            BtnBuscarPermiso.TabIndex = 81;
            BtnBuscarPermiso.Text = "Buscar";
            BtnBuscarPermiso.UseVisualStyleBackColor = false;
            // 
            // BtnBuscarUsuario
            // 
            BtnBuscarUsuario.Action = Componentes.ButtonAction.Actualizar;
            BtnBuscarUsuario.Anchor = AnchorStyles.None;
            BtnBuscarUsuario.BackColor = Color.FromArgb(214, 157, 15);
            BtnBuscarUsuario.FlatAppearance.BorderSize = 0;
            BtnBuscarUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(130, 97, 9);
            BtnBuscarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 169, 16);
            BtnBuscarUsuario.FlatStyle = FlatStyle.Flat;
            BtnBuscarUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnBuscarUsuario.ForeColor = Color.White;
            BtnBuscarUsuario.Location = new Point(200, 90);
            BtnBuscarUsuario.Margin = new Padding(0, 0, 0, 4);
            BtnBuscarUsuario.MaximumSize = new Size(100, 40);
            BtnBuscarUsuario.MinimumSize = new Size(100, 40);
            BtnBuscarUsuario.Name = "BtnBuscarUsuario";
            TlpForm.SetRowSpan(BtnBuscarUsuario, 2);
            BtnBuscarUsuario.Size = new Size(100, 40);
            BtnBuscarUsuario.TabIndex = 88;
            BtnBuscarUsuario.Text = "Buscar";
            BtnBuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // TlpButtons
            // 
            TlpButtons.ColumnCount = 4;
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TlpButtons.Controls.Add(BtnBuscar, 2, 0);
            TlpButtons.Controls.Add(BtnLimpiar, 1, 0);
            TlpButtons.Dock = DockStyle.Fill;
            TlpButtons.Location = new Point(0, 350);
            TlpButtons.Margin = new Padding(0);
            TlpButtons.Name = "TlpButtons";
            TlpButtons.RowCount = 1;
            TlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpButtons.Size = new Size(930, 75);
            TlpButtons.TabIndex = 3;
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
            BtnBuscar.Location = new Point(470, 17);
            BtnBuscar.Margin = new Padding(0);
            BtnBuscar.MaximumSize = new Size(100, 40);
            BtnBuscar.MinimumSize = new Size(100, 40);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(100, 40);
            BtnBuscar.TabIndex = 1;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Action = Componentes.ButtonAction.Limpiar;
            BtnLimpiar.Anchor = AnchorStyles.None;
            BtnLimpiar.BackColor = Color.FromArgb(22, 160, 133);
            BtnLimpiar.FlatAppearance.BorderSize = 0;
            BtnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(14, 97, 80);
            BtnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 174, 145);
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnLimpiar.ForeColor = Color.White;
            BtnLimpiar.Location = new Point(360, 17);
            BtnLimpiar.Margin = new Padding(0);
            BtnLimpiar.MaximumSize = new Size(100, 40);
            BtnLimpiar.MinimumSize = new Size(100, 40);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(100, 40);
            BtnLimpiar.TabIndex = 2;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
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
            LbTitulo.Text = "BITÁCORA";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DgvBitacora
            // 
            DgvBitacora.AllowUserToAddRows = false;
            DgvBitacora.AllowUserToResizeColumns = false;
            DgvBitacora.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(42, 44, 49);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(178, 44, 48);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            DgvBitacora.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvBitacora.BackgroundColor = Color.FromArgb(37, 38, 43);
            DgvBitacora.BorderStyle = BorderStyle.None;
            DgvBitacora.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvBitacora.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 47, 52);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 47, 52);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvBitacora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 38, 43);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 44, 48);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvBitacora.DefaultCellStyle = dataGridViewCellStyle3;
            DgvBitacora.Dock = DockStyle.Fill;
            DgvBitacora.EnableHeadersVisualStyles = false;
            DgvBitacora.Font = new Font("Segoe UI", 9.5F);
            DgvBitacora.GridColor = Color.FromArgb(58, 60, 66);
            DgvBitacora.Location = new Point(0, 500);
            DgvBitacora.Margin = new Padding(0);
            DgvBitacora.MultiSelect = false;
            DgvBitacora.Name = "DgvBitacora";
            DgvBitacora.ReadOnly = true;
            DgvBitacora.RowHeadersVisible = false;
            DgvBitacora.RowHeadersWidth = 51;
            DgvBitacora.RowTemplate.Height = 36;
            DgvBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvBitacora.Size = new Size(1050, 200);
            DgvBitacora.TabIndex = 2;
            // 
            // FrUcBitacora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TlpDivFormAndDgv);
            Name = "FrUcBitacora";
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
            ((System.ComponentModel.ISupportInitialize)DgvBitacora).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpDivFormAndDgv;
        private TableLayoutPanel TlpAux1;
        private TableLayoutPanel TlpTitleLabel;
        private Componentes.CustomTitleLabel LbTitulo;
        private Componentes.CustomDataGridView DgvBitacora;
        private TableLayoutPanel TlpAux2;
        private TableLayoutPanel TlpFormWithButtons;
        private TableLayoutPanel TlpForm;
        private Componentes.CustomRichTextBox RtbDatosUsuario;
        private Componentes.CustomIDTextBox TbID;
        private Componentes.CustomLabel LbID;
        private Componentes.CustomLabel LbFecha;
        private Componentes.CustomDatePicker DatePickerFecha;
        private Componentes.CustomComboBox CbMetodoDePago;
        private Componentes.CustomLabel LbIP;
        private Componentes.CustomTextBox TbTotalDeVenta;
        private Componentes.CustomLabel LbPromocion;
        private Componentes.CustomComboBox CbPromocion;
        private Componentes.CustomLabel LbMetodoDePago;
        private Componentes.CustomLabel LbIDPermiso;
        private Componentes.CustomTextBox TbIdPermiso;
        private Componentes.CustomLabel LbNombreDePC;
        private Componentes.CustomTextBox TbIdUsuario;
        private Componentes.CustomRichTextBox RtbDatosCliente;
        private Componentes.CustomButton BtnBuscarPermiso;
        private Componentes.CustomButton BtnBuscarNombreDePC;
        private TableLayoutPanel TlpButtons;
        private Componentes.CustomButton BtnEliminar;
        private Componentes.CustomButton BtnActualizar;
        private Componentes.CustomButton BtnCopiar;
        private Componentes.CustomButton BtnAgregar;
        private Componentes.CustomButton BtnLimpiar;
        private Componentes.CustomRichTextBox customRichTextBox1;
        private Componentes.CustomLabel customLabel1;
        private Componentes.CustomTextBox customTextBox1;
        private Componentes.CustomButton BtnBuscarUsuario;
        private Componentes.CustomButton BtnBuscar;
    }
}
