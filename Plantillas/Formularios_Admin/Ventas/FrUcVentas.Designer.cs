namespace Forms_Admin.Ventas
{
    partial class FrUcVentas
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
            TbID = new Componentes.CustomIDTextBox();
            LbID = new Componentes.CustomLabel();
            LbFecha = new Componentes.CustomLabel();
            DatePickerFecha = new Componentes.CustomDatePicker();
            LbHora = new Componentes.CustomLabel();
            TimePickerHora = new Componentes.CustomTimePicker();
            CbMetodoDePago = new Componentes.CustomComboBox();
            LbTotalDeVenta = new Componentes.CustomLabel();
            TbTotalDeVenta = new Componentes.CustomTextBox();
            LbPromocion = new Componentes.CustomLabel();
            CbPromocion = new Componentes.CustomComboBox();
            LbMetodoDePago = new Componentes.CustomLabel();
            LbIDCliente = new Componentes.CustomLabel();
            TbIdCliente = new Componentes.CustomTextBox();
            LbUsuario = new Componentes.CustomLabel();
            TbIdUsuario = new Componentes.CustomTextBox();
            RtbDatosCliente = new Componentes.CustomRichTextBox();
            BtnBuscarCliente = new Componentes.CustomButton();
            BtnBuscarUsuario = new Componentes.CustomButton();
            TlpButtons = new TableLayoutPanel();
            BtnEliminar = new Componentes.CustomButton();
            BtnActualizar = new Componentes.CustomButton();
            BtnCopiar = new Componentes.CustomButton();
            BtnAgregar = new Componentes.CustomButton();
            BtnLimpiar = new Componentes.CustomButton();
            TlpTitleLabel = new TableLayoutPanel();
            LbTitulo = new Componentes.CustomTitleLabel();
            TlpAux3 = new TableLayoutPanel();
            TlpFilter = new TableLayoutPanel();
            BtnBuscar = new Componentes.CustomButton();
            TbFiltro = new Componentes.CustomTextBox();
            CbFiltro = new Componentes.CustomComboBox();
            DgvVentas = new Componentes.CustomDataGridView();
            TlpDivFormAndDgv.SuspendLayout();
            TlpAux1.SuspendLayout();
            TlpAux2.SuspendLayout();
            TlpFormWithButtons.SuspendLayout();
            TlpForm.SuspendLayout();
            TlpButtons.SuspendLayout();
            TlpTitleLabel.SuspendLayout();
            TlpAux3.SuspendLayout();
            TlpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvVentas).BeginInit();
            SuspendLayout();
            // 
            // TlpDivFormAndDgv
            // 
            TlpDivFormAndDgv.ColumnCount = 1;
            TlpDivFormAndDgv.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Controls.Add(TlpAux1, 0, 0);
            TlpDivFormAndDgv.Controls.Add(DgvVentas, 0, 1);
            TlpDivFormAndDgv.Dock = DockStyle.Fill;
            TlpDivFormAndDgv.Location = new Point(0, 0);
            TlpDivFormAndDgv.Margin = new Padding(0);
            TlpDivFormAndDgv.Name = "TlpDivFormAndDgv";
            TlpDivFormAndDgv.RowCount = 2;
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Absolute, 525F));
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Size = new Size(1050, 700);
            TlpDivFormAndDgv.TabIndex = 12;
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
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 930F));
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
            TlpFormWithButtons.Size = new Size(930, 375);
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
            TlpForm.Controls.Add(TbID, 0, 1);
            TlpForm.Controls.Add(LbID, 0, 0);
            TlpForm.Controls.Add(LbFecha, 2, 0);
            TlpForm.Controls.Add(DatePickerFecha, 2, 1);
            TlpForm.Controls.Add(LbHora, 4, 0);
            TlpForm.Controls.Add(TimePickerHora, 4, 1);
            TlpForm.Controls.Add(CbMetodoDePago, 0, 5);
            TlpForm.Controls.Add(LbTotalDeVenta, 0, 6);
            TlpForm.Controls.Add(TbTotalDeVenta, 0, 7);
            TlpForm.Controls.Add(LbPromocion, 0, 2);
            TlpForm.Controls.Add(CbPromocion, 0, 3);
            TlpForm.Controls.Add(LbMetodoDePago, 0, 4);
            TlpForm.Controls.Add(LbIDCliente, 2, 2);
            TlpForm.Controls.Add(TbIdCliente, 2, 3);
            TlpForm.Controls.Add(LbUsuario, 4, 2);
            TlpForm.Controls.Add(TbIdUsuario, 4, 3);
            TlpForm.Controls.Add(RtbDatosCliente, 2, 4);
            TlpForm.Controls.Add(BtnBuscarCliente, 3, 2);
            TlpForm.Controls.Add(BtnBuscarUsuario, 5, 2);
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
            TlpForm.Size = new Size(930, 300);
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
            RtbDatosUsuario.Size = new Size(300, 130);
            RtbDatosUsuario.TabIndex = 84;
            RtbDatosUsuario.Text = "";
            // 
            // TbID
            // 
            TbID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbID.BackColor = Color.FromArgb(28, 30, 38);
            TbID.BorderStyle = BorderStyle.FixedSingle;
            TlpForm.SetColumnSpan(TbID, 2);
            TbID.Font = new Font("Segoe UI", 10F);
            TbID.ForeColor = Color.FromArgb(120, 125, 135);
            TbID.Location = new Point(5, 25);
            TbID.Margin = new Padding(5, 0, 5, 10);
            TbID.MaximumSize = new Size(0, 30);
            TbID.MinimumSize = new Size(190, 30);
            TbID.Name = "TbID";
            TbID.ReadOnly = true;
            TbID.Size = new Size(300, 30);
            TbID.TabIndex = 60;
            TbID.TabStop = false;
            // 
            // LbID
            // 
            LbID.AutoSize = true;
            LbID.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbID.ForeColor = Color.FromArgb(220, 220, 220);
            LbID.Location = new Point(3, 0);
            LbID.Margin = new Padding(3, 0, 0, 0);
            LbID.Name = "LbID";
            LbID.Padding = new Padding(0, 0, 2, 0);
            LbID.Size = new Size(87, 23);
            LbID.TabIndex = 11;
            LbID.Text = "ID Ventas";
            LbID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbFecha
            // 
            LbFecha.AutoSize = true;
            LbFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbFecha.ForeColor = Color.FromArgb(220, 220, 220);
            LbFecha.Location = new Point(313, 0);
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
            DatePickerFecha.Location = new Point(315, 25);
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
            // LbHora
            // 
            LbHora.AutoSize = true;
            LbHora.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbHora.ForeColor = Color.FromArgb(220, 220, 220);
            LbHora.Location = new Point(623, 0);
            LbHora.Name = "LbHora";
            LbHora.Padding = new Padding(0, 0, 2, 0);
            LbHora.Size = new Size(51, 23);
            LbHora.TabIndex = 71;
            LbHora.Text = "Hora";
            LbHora.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TimePickerHora
            // 
            TimePickerHora.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TimePickerHora.BackColor = Color.FromArgb(55, 60, 72);
            TimePickerHora.BorderStyle = BorderStyle.FixedSingle;
            TlpForm.SetColumnSpan(TimePickerHora, 2);
            TimePickerHora.Font = new Font("Segoe UI", 11F);
            TimePickerHora.ForeColor = Color.FromArgb(230, 230, 230);
            TimePickerHora.Location = new Point(625, 25);
            TimePickerHora.Margin = new Padding(5, 0, 5, 10);
            TimePickerHora.Mask = "00:00";
            TimePickerHora.MaximumSize = new Size(0, 30);
            TimePickerHora.MinimumSize = new Size(190, 30);
            TimePickerHora.Name = "TimePickerHora";
            TimePickerHora.Size = new Size(300, 30);
            TimePickerHora.TabIndex = 74;
            TimePickerHora.Text = "1200";
            // 
            // CbMetodoDePago
            // 
            CbMetodoDePago.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CbMetodoDePago.BackColor = Color.FromArgb(55, 60, 72);
            CbMetodoDePago.BaseColor = Color.FromArgb(40, 40, 40);
            CbMetodoDePago.BGColor = Color.FromArgb(55, 60, 72);
            TlpForm.SetColumnSpan(CbMetodoDePago, 2);
            CbMetodoDePago.DrawMode = DrawMode.OwnerDrawFixed;
            CbMetodoDePago.DropDownStyle = ComboBoxStyle.DropDownList;
            CbMetodoDePago.FlatStyle = FlatStyle.Flat;
            CbMetodoDePago.Font = new Font("Segoe UI", 9.5F);
            CbMetodoDePago.ForeColor = Color.FromArgb(230, 230, 230);
            CbMetodoDePago.FormattingEnabled = true;
            CbMetodoDePago.HoverColor = Color.Crimson;
            CbMetodoDePago.HoverFontColor = Color.White;
            CbMetodoDePago.ItemHeight = 24;
            CbMetodoDePago.Location = new Point(5, 175);
            CbMetodoDePago.Margin = new Padding(5, 0, 5, 10);
            CbMetodoDePago.MinimumSize = new Size(190, 0);
            CbMetodoDePago.Name = "CbMetodoDePago";
            CbMetodoDePago.Size = new Size(300, 30);
            CbMetodoDePago.TabIndex = 77;
            // 
            // LbTotalDeVenta
            // 
            LbTotalDeVenta.AutoSize = true;
            LbTotalDeVenta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbTotalDeVenta.ForeColor = Color.FromArgb(220, 220, 220);
            LbTotalDeVenta.Location = new Point(3, 225);
            LbTotalDeVenta.Name = "LbTotalDeVenta";
            LbTotalDeVenta.Padding = new Padding(0, 0, 2, 0);
            LbTotalDeVenta.Size = new Size(160, 23);
            LbTotalDeVenta.TabIndex = 72;
            LbTotalDeVenta.Text = "Total de Venta (Q.)";
            LbTotalDeVenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbTotalDeVenta
            // 
            TbTotalDeVenta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbTotalDeVenta.BackColor = Color.FromArgb(55, 60, 72);
            TbTotalDeVenta.BorderStyle = BorderStyle.FixedSingle;
            TlpForm.SetColumnSpan(TbTotalDeVenta, 2);
            TbTotalDeVenta.Font = new Font("Segoe UI", 10F);
            TbTotalDeVenta.ForeColor = Color.FromArgb(160, 165, 175);
            TbTotalDeVenta.Location = new Point(5, 250);
            TbTotalDeVenta.Margin = new Padding(5, 0, 5, 10);
            TbTotalDeVenta.MaximumSize = new Size(0, 30);
            TbTotalDeVenta.MinimumSize = new Size(190, 30);
            TbTotalDeVenta.Name = "TbTotalDeVenta";
            TbTotalDeVenta.PlaceholderText = "100";
            TbTotalDeVenta.Size = new Size(300, 30);
            TbTotalDeVenta.TabIndex = 66;
            // 
            // LbPromocion
            // 
            LbPromocion.AutoSize = true;
            LbPromocion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbPromocion.ForeColor = Color.FromArgb(220, 220, 220);
            LbPromocion.Location = new Point(3, 75);
            LbPromocion.Name = "LbPromocion";
            LbPromocion.Padding = new Padding(0, 0, 2, 0);
            LbPromocion.Size = new Size(98, 23);
            LbPromocion.TabIndex = 67;
            LbPromocion.Text = "Promoción";
            LbPromocion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CbPromocion
            // 
            CbPromocion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CbPromocion.BackColor = Color.FromArgb(55, 60, 72);
            CbPromocion.BaseColor = Color.FromArgb(40, 40, 40);
            CbPromocion.BGColor = Color.FromArgb(55, 60, 72);
            TlpForm.SetColumnSpan(CbPromocion, 2);
            CbPromocion.DrawMode = DrawMode.OwnerDrawFixed;
            CbPromocion.DropDownStyle = ComboBoxStyle.DropDownList;
            CbPromocion.FlatStyle = FlatStyle.Flat;
            CbPromocion.Font = new Font("Segoe UI", 9.5F);
            CbPromocion.ForeColor = Color.FromArgb(230, 230, 230);
            CbPromocion.FormattingEnabled = true;
            CbPromocion.HoverColor = Color.Crimson;
            CbPromocion.HoverFontColor = Color.White;
            CbPromocion.ItemHeight = 24;
            CbPromocion.Location = new Point(5, 100);
            CbPromocion.Margin = new Padding(5, 0, 5, 10);
            CbPromocion.MinimumSize = new Size(190, 0);
            CbPromocion.Name = "CbPromocion";
            CbPromocion.Size = new Size(300, 30);
            CbPromocion.TabIndex = 64;
            // 
            // LbMetodoDePago
            // 
            LbMetodoDePago.AutoSize = true;
            LbMetodoDePago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbMetodoDePago.ForeColor = Color.FromArgb(220, 220, 220);
            LbMetodoDePago.Location = new Point(3, 150);
            LbMetodoDePago.Name = "LbMetodoDePago";
            LbMetodoDePago.Padding = new Padding(0, 0, 2, 0);
            LbMetodoDePago.Size = new Size(145, 23);
            LbMetodoDePago.TabIndex = 75;
            LbMetodoDePago.Text = "Método de Pago";
            LbMetodoDePago.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbIDCliente
            // 
            LbIDCliente.AutoSize = true;
            LbIDCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbIDCliente.ForeColor = Color.FromArgb(220, 220, 220);
            LbIDCliente.Location = new Point(313, 75);
            LbIDCliente.Margin = new Padding(3, 0, 0, 0);
            LbIDCliente.Name = "LbIDCliente";
            LbIDCliente.Padding = new Padding(0, 0, 2, 0);
            LbIDCliente.Size = new Size(91, 23);
            LbIDCliente.TabIndex = 12;
            LbIDCliente.Text = "ID Cliente";
            LbIDCliente.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbIdCliente
            // 
            TbIdCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbIdCliente.BackColor = Color.FromArgb(55, 60, 72);
            TbIdCliente.BorderStyle = BorderStyle.FixedSingle;
            TbIdCliente.Font = new Font("Segoe UI", 10F);
            TbIdCliente.ForeColor = Color.FromArgb(160, 165, 175);
            TbIdCliente.Location = new Point(315, 100);
            TbIdCliente.Margin = new Padding(5, 0, 5, 10);
            TbIdCliente.MaximumSize = new Size(0, 30);
            TbIdCliente.MinimumSize = new Size(190, 30);
            TbIdCliente.Name = "TbIdCliente";
            TbIdCliente.PlaceholderText = "1";
            TbIdCliente.Size = new Size(190, 30);
            TbIdCliente.TabIndex = 80;
            // 
            // LbUsuario
            // 
            LbUsuario.AutoSize = true;
            LbUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbUsuario.ForeColor = Color.FromArgb(220, 220, 220);
            LbUsuario.Location = new Point(623, 75);
            LbUsuario.Name = "LbUsuario";
            LbUsuario.Padding = new Padding(0, 0, 2, 0);
            LbUsuario.Size = new Size(95, 23);
            LbUsuario.TabIndex = 68;
            LbUsuario.Text = "ID Usuario";
            LbUsuario.TextAlign = ContentAlignment.MiddleRight;
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
            RtbDatosCliente.Size = new Size(300, 130);
            RtbDatosCliente.TabIndex = 83;
            RtbDatosCliente.Text = "";
            // 
            // BtnBuscarCliente
            // 
            BtnBuscarCliente.Action = Componentes.ButtonAction.Buscar;
            BtnBuscarCliente.Anchor = AnchorStyles.None;
            BtnBuscarCliente.BackColor = Color.FromArgb(39, 174, 96);
            BtnBuscarCliente.FlatAppearance.BorderSize = 0;
            BtnBuscarCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 104, 57);
            BtnBuscarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 186, 103);
            BtnBuscarCliente.FlatStyle = FlatStyle.Flat;
            BtnBuscarCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnBuscarCliente.ForeColor = Color.White;
            BtnBuscarCliente.Location = new Point(510, 90);
            BtnBuscarCliente.Margin = new Padding(0, 0, 0, 4);
            BtnBuscarCliente.MaximumSize = new Size(100, 40);
            BtnBuscarCliente.MinimumSize = new Size(100, 40);
            BtnBuscarCliente.Name = "BtnBuscarCliente";
            TlpForm.SetRowSpan(BtnBuscarCliente, 2);
            BtnBuscarCliente.Size = new Size(100, 40);
            BtnBuscarCliente.TabIndex = 81;
            BtnBuscarCliente.Text = "Buscar";
            BtnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // BtnBuscarUsuario
            // 
            BtnBuscarUsuario.Action = Componentes.ButtonAction.Buscar;
            BtnBuscarUsuario.Anchor = AnchorStyles.None;
            BtnBuscarUsuario.BackColor = Color.FromArgb(39, 174, 96);
            BtnBuscarUsuario.FlatAppearance.BorderSize = 0;
            BtnBuscarUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 104, 57);
            BtnBuscarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 186, 103);
            BtnBuscarUsuario.FlatStyle = FlatStyle.Flat;
            BtnBuscarUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnBuscarUsuario.ForeColor = Color.White;
            BtnBuscarUsuario.Location = new Point(820, 90);
            BtnBuscarUsuario.Margin = new Padding(0, 0, 0, 4);
            BtnBuscarUsuario.MaximumSize = new Size(100, 40);
            BtnBuscarUsuario.MinimumSize = new Size(100, 40);
            BtnBuscarUsuario.Name = "BtnBuscarUsuario";
            TlpForm.SetRowSpan(BtnBuscarUsuario, 2);
            BtnBuscarUsuario.Size = new Size(100, 40);
            BtnBuscarUsuario.TabIndex = 82;
            BtnBuscarUsuario.Text = "Buscar";
            BtnBuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // TlpButtons
            // 
            TlpButtons.ColumnCount = 7;
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.Controls.Add(BtnEliminar, 5, 0);
            TlpButtons.Controls.Add(BtnActualizar, 4, 0);
            TlpButtons.Controls.Add(BtnCopiar, 3, 0);
            TlpButtons.Controls.Add(BtnAgregar, 2, 0);
            TlpButtons.Controls.Add(BtnLimpiar, 1, 0);
            TlpButtons.Dock = DockStyle.Fill;
            TlpButtons.Location = new Point(0, 300);
            TlpButtons.Margin = new Padding(0);
            TlpButtons.Name = "TlpButtons";
            TlpButtons.RowCount = 1;
            TlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpButtons.Size = new Size(930, 75);
            TlpButtons.TabIndex = 3;
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
            BtnEliminar.Location = new Point(635, 17);
            BtnEliminar.Margin = new Padding(0);
            BtnEliminar.MaximumSize = new Size(100, 40);
            BtnEliminar.MinimumSize = new Size(100, 40);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(100, 40);
            BtnEliminar.TabIndex = 4;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
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
            BtnActualizar.Location = new Point(525, 17);
            BtnActualizar.Margin = new Padding(0);
            BtnActualizar.MaximumSize = new Size(100, 40);
            BtnActualizar.MinimumSize = new Size(100, 40);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(100, 40);
            BtnActualizar.TabIndex = 2;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = false;
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
            BtnCopiar.Location = new Point(415, 17);
            BtnCopiar.Margin = new Padding(0);
            BtnCopiar.MaximumSize = new Size(100, 40);
            BtnCopiar.MinimumSize = new Size(100, 40);
            BtnCopiar.Name = "BtnCopiar";
            BtnCopiar.Size = new Size(100, 40);
            BtnCopiar.TabIndex = 3;
            BtnCopiar.Text = "Copiar";
            BtnCopiar.UseVisualStyleBackColor = false;
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
            BtnAgregar.Location = new Point(305, 17);
            BtnAgregar.Margin = new Padding(0);
            BtnAgregar.MaximumSize = new Size(100, 40);
            BtnAgregar.MinimumSize = new Size(100, 40);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(100, 40);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
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
            BtnLimpiar.Location = new Point(195, 17);
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
            LbTitulo.Text = "VENTAS";
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
            TlpFilter.Controls.Add(BtnBuscar, 2, 0);
            TlpFilter.Controls.Add(TbFiltro, 1, 0);
            TlpFilter.Controls.Add(CbFiltro, 0, 0);
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
            // CbFiltro
            // 
            CbFiltro.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CbFiltro.BackColor = Color.FromArgb(55, 60, 72);
            CbFiltro.BaseColor = Color.FromArgb(40, 40, 40);
            CbFiltro.BGColor = Color.FromArgb(55, 60, 72);
            CbFiltro.DrawMode = DrawMode.OwnerDrawFixed;
            CbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            CbFiltro.FlatStyle = FlatStyle.Flat;
            CbFiltro.Font = new Font("Segoe UI", 9.5F);
            CbFiltro.ForeColor = Color.FromArgb(230, 230, 230);
            CbFiltro.FormattingEnabled = true;
            CbFiltro.HoverColor = Color.Crimson;
            CbFiltro.HoverFontColor = Color.White;
            CbFiltro.ItemHeight = 24;
            CbFiltro.Location = new Point(5, 22);
            CbFiltro.Margin = new Padding(5);
            CbFiltro.MinimumSize = new Size(190, 0);
            CbFiltro.Name = "CbFiltro";
            CbFiltro.Size = new Size(190, 30);
            CbFiltro.TabIndex = 8;
            // 
            // DgvVentas
            // 
            DgvVentas.AllowUserToAddRows = false;
            DgvVentas.AllowUserToResizeColumns = false;
            DgvVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(42, 44, 49);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(178, 44, 48);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            DgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvVentas.BackgroundColor = Color.FromArgb(37, 38, 43);
            DgvVentas.BorderStyle = BorderStyle.None;
            DgvVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 47, 52);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 47, 52);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 38, 43);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 44, 48);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvVentas.DefaultCellStyle = dataGridViewCellStyle3;
            DgvVentas.Dock = DockStyle.Fill;
            DgvVentas.EnableHeadersVisualStyles = false;
            DgvVentas.Font = new Font("Segoe UI", 9.5F);
            DgvVentas.GridColor = Color.FromArgb(58, 60, 66);
            DgvVentas.Location = new Point(0, 525);
            DgvVentas.Margin = new Padding(0);
            DgvVentas.MultiSelect = false;
            DgvVentas.Name = "DgvVentas";
            DgvVentas.ReadOnly = true;
            DgvVentas.RowHeadersVisible = false;
            DgvVentas.RowHeadersWidth = 51;
            DgvVentas.RowTemplate.Height = 36;
            DgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvVentas.Size = new Size(1050, 175);
            DgvVentas.TabIndex = 2;
            // 
            // FrUcVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(TlpDivFormAndDgv);
            Name = "FrUcVentas";
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
            ((System.ComponentModel.ISupportInitialize)DgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpDivFormAndDgv;
        private TableLayoutPanel TlpAux1;
        private TableLayoutPanel TlpAux2;
        private TableLayoutPanel TlpFormWithButtons;
        private TableLayoutPanel TlpForm;
        private Componentes.CustomIDTextBox TbID;
        private Componentes.CustomLabel LbID;
        private Componentes.CustomLabel LbIDCliente;
        private Componentes.CustomLabel LbFecha;
        private Componentes.CustomComboBox CbPromocion;
        private Componentes.CustomLabel LbPromocion;
        private Componentes.CustomLabel LbUsuario;
        private Componentes.CustomLabel LbHora;
        private Componentes.CustomLabel LbTotalDeVenta;
        private Componentes.CustomTextBox TbTotalDeVenta;
        private Componentes.CustomDatePicker DatePickerFecha;
        private Componentes.CustomTimePicker TimePickerHora;
        private TableLayoutPanel TlpButtons;
        private Componentes.CustomButton BtnEliminar;
        private Componentes.CustomButton BtnActualizar;
        private Componentes.CustomButton BtnCopiar;
        private Componentes.CustomButton BtnAgregar;
        private Componentes.CustomButton BtnLimpiar;
        private TableLayoutPanel TlpTitleLabel;
        private Componentes.CustomTitleLabel LbTitulo;
        private TableLayoutPanel TlpAux3;
        private TableLayoutPanel TlpFilter;
        private Componentes.CustomButton BtnBuscar;
        private Componentes.CustomTextBox TbFiltro;
        private Componentes.CustomComboBox CbFiltro;
        private Componentes.CustomLabel LbMetodoDePago;
        private Componentes.CustomComboBox CbMetodoDePago;
        private Componentes.CustomTextBox TbIdUsuario;
        private Componentes.CustomTextBox TbIdCliente;
        private Componentes.CustomRichTextBox RtbDatosUsuario;
        private Componentes.CustomButton BtnBuscarUsuario;
        private Componentes.CustomRichTextBox RtbDatosCliente;
        private Componentes.CustomButton BtnBuscarCliente;
        private Componentes.CustomDataGridView DgvVentas;
    }
}
