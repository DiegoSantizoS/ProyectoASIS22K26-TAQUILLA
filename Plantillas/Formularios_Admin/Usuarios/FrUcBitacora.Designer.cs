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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            TlpDivFormAndDgv = new TableLayoutPanel();
            TlpAux1 = new TableLayoutPanel();
            TlpTitleLabel = new TableLayoutPanel();
            LbTitulo = new Componentes.CustomTitleLabel();
            TlpAux3 = new TableLayoutPanel();
            TlpFilter = new TableLayoutPanel();
            BtnFiltro1 = new Componentes.CustomButton();
            TbFiltro1 = new Componentes.CustomTextBox();
            CbFiltro1 = new Componentes.CustomComboBox();
            DgvBitacora = new Componentes.CustomDataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            BtnFiltro2 = new Componentes.CustomButton();
            TbFiltro2 = new Componentes.CustomTextBox();
            CbFiltro2 = new Componentes.CustomComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnFiltro3 = new Componentes.CustomButton();
            TbFiltro3 = new Componentes.CustomTextBox();
            CbFiltro3 = new Componentes.CustomComboBox();
            TlpDivFormAndDgv.SuspendLayout();
            TlpAux1.SuspendLayout();
            TlpTitleLabel.SuspendLayout();
            TlpAux3.SuspendLayout();
            TlpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBitacora).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Size = new Size(1050, 700);
            TlpDivFormAndDgv.TabIndex = 9;
            // 
            // TlpAux1
            // 
            TlpAux1.ColumnCount = 1;
            TlpAux1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpAux1.Controls.Add(TlpTitleLabel, 0, 0);
            TlpAux1.Controls.Add(TlpAux3, 0, 1);
            TlpAux1.Dock = DockStyle.Fill;
            TlpAux1.Location = new Point(0, 0);
            TlpAux1.Margin = new Padding(0);
            TlpAux1.Name = "TlpAux1";
            TlpAux1.RowCount = 2;
            TlpAux1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TlpAux1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpAux1.Size = new Size(1050, 300);
            TlpAux1.TabIndex = 1;
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
            // TlpAux3
            // 
            TlpAux3.ColumnCount = 3;
            TlpAux3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 510F));
            TlpAux3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux3.Controls.Add(tableLayoutPanel2, 1, 2);
            TlpAux3.Controls.Add(tableLayoutPanel1, 1, 1);
            TlpAux3.Controls.Add(TlpFilter, 1, 0);
            TlpAux3.Dock = DockStyle.Fill;
            TlpAux3.Location = new Point(0, 75);
            TlpAux3.Margin = new Padding(0);
            TlpAux3.Name = "TlpAux3";
            TlpAux3.RowCount = 4;
            TlpAux3.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TlpAux3.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            TlpAux3.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            TlpAux3.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TlpAux3.Size = new Size(1050, 225);
            TlpAux3.TabIndex = 2;
            // 
            // TlpFilter
            // 
            TlpFilter.ColumnCount = 3;
            TlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            TlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            TlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpFilter.Controls.Add(BtnFiltro1, 2, 0);
            TlpFilter.Controls.Add(TbFiltro1, 1, 0);
            TlpFilter.Controls.Add(CbFiltro1, 0, 0);
            TlpFilter.Dock = DockStyle.Fill;
            TlpFilter.Location = new Point(270, 0);
            TlpFilter.Margin = new Padding(0);
            TlpFilter.Name = "TlpFilter";
            TlpFilter.RowCount = 1;
            TlpFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpFilter.Size = new Size(510, 75);
            TlpFilter.TabIndex = 1;
            // 
            // BtnFiltro1
            // 
            BtnFiltro1.Action = Componentes.ButtonAction.Buscar;
            BtnFiltro1.Anchor = AnchorStyles.None;
            BtnFiltro1.BackColor = Color.FromArgb(39, 174, 96);
            BtnFiltro1.FlatAppearance.BorderSize = 0;
            BtnFiltro1.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 104, 57);
            BtnFiltro1.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 186, 103);
            BtnFiltro1.FlatStyle = FlatStyle.Flat;
            BtnFiltro1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnFiltro1.ForeColor = Color.White;
            BtnFiltro1.Location = new Point(405, 17);
            BtnFiltro1.Margin = new Padding(0);
            BtnFiltro1.MaximumSize = new Size(100, 40);
            BtnFiltro1.MinimumSize = new Size(100, 40);
            BtnFiltro1.Name = "BtnFiltro1";
            BtnFiltro1.Size = new Size(100, 40);
            BtnFiltro1.TabIndex = 5;
            BtnFiltro1.Text = "Buscar";
            BtnFiltro1.UseVisualStyleBackColor = false;
            // 
            // TbFiltro1
            // 
            TbFiltro1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbFiltro1.BackColor = Color.FromArgb(55, 60, 72);
            TbFiltro1.BorderStyle = BorderStyle.FixedSingle;
            TbFiltro1.Font = new Font("Segoe UI", 10F);
            TbFiltro1.ForeColor = Color.FromArgb(230, 230, 230);
            TbFiltro1.Location = new Point(205, 22);
            TbFiltro1.Margin = new Padding(5);
            TbFiltro1.MaximumSize = new Size(0, 30);
            TbFiltro1.MinimumSize = new Size(190, 30);
            TbFiltro1.Name = "TbFiltro1";
            TbFiltro1.Size = new Size(190, 30);
            TbFiltro1.TabIndex = 7;
            // 
            // CbFiltro1
            // 
            CbFiltro1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CbFiltro1.BackColor = Color.FromArgb(55, 60, 72);
            CbFiltro1.BaseColor = Color.FromArgb(40, 40, 40);
            CbFiltro1.BGColor = Color.FromArgb(55, 60, 72);
            CbFiltro1.DrawMode = DrawMode.OwnerDrawFixed;
            CbFiltro1.DropDownStyle = ComboBoxStyle.DropDownList;
            CbFiltro1.FlatStyle = FlatStyle.Flat;
            CbFiltro1.Font = new Font("Segoe UI", 9.5F);
            CbFiltro1.ForeColor = Color.FromArgb(230, 230, 230);
            CbFiltro1.FormattingEnabled = true;
            CbFiltro1.HoverColor = Color.Crimson;
            CbFiltro1.HoverFontColor = Color.White;
            CbFiltro1.ItemHeight = 24;
            CbFiltro1.Location = new Point(5, 22);
            CbFiltro1.Margin = new Padding(5);
            CbFiltro1.MinimumSize = new Size(190, 0);
            CbFiltro1.Name = "CbFiltro1";
            CbFiltro1.Size = new Size(190, 30);
            CbFiltro1.TabIndex = 8;
            // 
            // DgvBitacora
            // 
            DgvBitacora.AllowUserToAddRows = false;
            DgvBitacora.AllowUserToResizeColumns = false;
            DgvBitacora.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(50, 55, 66);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            DgvBitacora.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DgvBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvBitacora.BackgroundColor = Color.FromArgb(55, 60, 72);
            DgvBitacora.BorderStyle = BorderStyle.None;
            DgvBitacora.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvBitacora.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DgvBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DgvBitacora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(55, 60, 72);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle6.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DgvBitacora.DefaultCellStyle = dataGridViewCellStyle6;
            DgvBitacora.Dock = DockStyle.Fill;
            DgvBitacora.EnableHeadersVisualStyles = false;
            DgvBitacora.Font = new Font("Segoe UI", 9.5F);
            DgvBitacora.GridColor = Color.FromArgb(70, 76, 90);
            DgvBitacora.Location = new Point(0, 300);
            DgvBitacora.Margin = new Padding(0);
            DgvBitacora.MultiSelect = false;
            DgvBitacora.Name = "DgvBitacora";
            DgvBitacora.ReadOnly = true;
            DgvBitacora.RowHeadersVisible = false;
            DgvBitacora.RowHeadersWidth = 51;
            DgvBitacora.RowTemplate.Height = 36;
            DgvBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvBitacora.Size = new Size(1050, 400);
            DgvBitacora.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.Controls.Add(BtnFiltro2, 2, 0);
            tableLayoutPanel1.Controls.Add(TbFiltro2, 1, 0);
            tableLayoutPanel1.Controls.Add(CbFiltro2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(270, 75);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(510, 74);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // BtnFiltro2
            // 
            BtnFiltro2.Action = Componentes.ButtonAction.Buscar;
            BtnFiltro2.Anchor = AnchorStyles.None;
            BtnFiltro2.BackColor = Color.FromArgb(39, 174, 96);
            BtnFiltro2.FlatAppearance.BorderSize = 0;
            BtnFiltro2.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 104, 57);
            BtnFiltro2.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 186, 103);
            BtnFiltro2.FlatStyle = FlatStyle.Flat;
            BtnFiltro2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnFiltro2.ForeColor = Color.White;
            BtnFiltro2.Location = new Point(405, 17);
            BtnFiltro2.Margin = new Padding(0);
            BtnFiltro2.MaximumSize = new Size(100, 40);
            BtnFiltro2.MinimumSize = new Size(100, 40);
            BtnFiltro2.Name = "BtnFiltro2";
            BtnFiltro2.Size = new Size(100, 40);
            BtnFiltro2.TabIndex = 5;
            BtnFiltro2.Text = "Buscar";
            BtnFiltro2.UseVisualStyleBackColor = false;
            // 
            // TbFiltro2
            // 
            TbFiltro2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbFiltro2.BackColor = Color.FromArgb(55, 60, 72);
            TbFiltro2.BorderStyle = BorderStyle.FixedSingle;
            TbFiltro2.Font = new Font("Segoe UI", 10F);
            TbFiltro2.ForeColor = Color.FromArgb(230, 230, 230);
            TbFiltro2.Location = new Point(205, 22);
            TbFiltro2.Margin = new Padding(5);
            TbFiltro2.MaximumSize = new Size(0, 30);
            TbFiltro2.MinimumSize = new Size(190, 30);
            TbFiltro2.Name = "TbFiltro2";
            TbFiltro2.Size = new Size(190, 30);
            TbFiltro2.TabIndex = 7;
            // 
            // CbFiltro2
            // 
            CbFiltro2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CbFiltro2.BackColor = Color.FromArgb(55, 60, 72);
            CbFiltro2.BaseColor = Color.FromArgb(40, 40, 40);
            CbFiltro2.BGColor = Color.FromArgb(55, 60, 72);
            CbFiltro2.DrawMode = DrawMode.OwnerDrawFixed;
            CbFiltro2.DropDownStyle = ComboBoxStyle.DropDownList;
            CbFiltro2.FlatStyle = FlatStyle.Flat;
            CbFiltro2.Font = new Font("Segoe UI", 9.5F);
            CbFiltro2.ForeColor = Color.FromArgb(230, 230, 230);
            CbFiltro2.FormattingEnabled = true;
            CbFiltro2.HoverColor = Color.Crimson;
            CbFiltro2.HoverFontColor = Color.White;
            CbFiltro2.ItemHeight = 24;
            CbFiltro2.Location = new Point(5, 22);
            CbFiltro2.Margin = new Padding(5);
            CbFiltro2.MinimumSize = new Size(190, 0);
            CbFiltro2.Name = "CbFiltro2";
            CbFiltro2.Size = new Size(190, 30);
            CbFiltro2.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel2.Controls.Add(BtnFiltro3, 2, 0);
            tableLayoutPanel2.Controls.Add(TbFiltro3, 1, 0);
            tableLayoutPanel2.Controls.Add(CbFiltro3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(270, 149);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(510, 76);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // BtnFiltro3
            // 
            BtnFiltro3.Action = Componentes.ButtonAction.Buscar;
            BtnFiltro3.Anchor = AnchorStyles.None;
            BtnFiltro3.BackColor = Color.FromArgb(39, 174, 96);
            BtnFiltro3.FlatAppearance.BorderSize = 0;
            BtnFiltro3.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 104, 57);
            BtnFiltro3.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 186, 103);
            BtnFiltro3.FlatStyle = FlatStyle.Flat;
            BtnFiltro3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnFiltro3.ForeColor = Color.White;
            BtnFiltro3.Location = new Point(405, 18);
            BtnFiltro3.Margin = new Padding(0);
            BtnFiltro3.MaximumSize = new Size(100, 40);
            BtnFiltro3.MinimumSize = new Size(100, 40);
            BtnFiltro3.Name = "BtnFiltro3";
            BtnFiltro3.Size = new Size(100, 40);
            BtnFiltro3.TabIndex = 5;
            BtnFiltro3.Text = "Buscar";
            BtnFiltro3.UseVisualStyleBackColor = false;
            // 
            // TbFiltro3
            // 
            TbFiltro3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbFiltro3.BackColor = Color.FromArgb(55, 60, 72);
            TbFiltro3.BorderStyle = BorderStyle.FixedSingle;
            TbFiltro3.Font = new Font("Segoe UI", 10F);
            TbFiltro3.ForeColor = Color.FromArgb(230, 230, 230);
            TbFiltro3.Location = new Point(205, 23);
            TbFiltro3.Margin = new Padding(5);
            TbFiltro3.MaximumSize = new Size(0, 30);
            TbFiltro3.MinimumSize = new Size(190, 30);
            TbFiltro3.Name = "TbFiltro3";
            TbFiltro3.Size = new Size(190, 30);
            TbFiltro3.TabIndex = 7;
            // 
            // CbFiltro3
            // 
            CbFiltro3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CbFiltro3.BackColor = Color.FromArgb(55, 60, 72);
            CbFiltro3.BaseColor = Color.FromArgb(40, 40, 40);
            CbFiltro3.BGColor = Color.FromArgb(55, 60, 72);
            CbFiltro3.DrawMode = DrawMode.OwnerDrawFixed;
            CbFiltro3.DropDownStyle = ComboBoxStyle.DropDownList;
            CbFiltro3.FlatStyle = FlatStyle.Flat;
            CbFiltro3.Font = new Font("Segoe UI", 9.5F);
            CbFiltro3.ForeColor = Color.FromArgb(230, 230, 230);
            CbFiltro3.FormattingEnabled = true;
            CbFiltro3.HoverColor = Color.Crimson;
            CbFiltro3.HoverFontColor = Color.White;
            CbFiltro3.ItemHeight = 24;
            CbFiltro3.Location = new Point(5, 23);
            CbFiltro3.Margin = new Padding(5);
            CbFiltro3.MinimumSize = new Size(190, 0);
            CbFiltro3.Name = "CbFiltro3";
            CbFiltro3.Size = new Size(190, 30);
            CbFiltro3.TabIndex = 8;
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
            TlpTitleLabel.ResumeLayout(false);
            TlpTitleLabel.PerformLayout();
            TlpAux3.ResumeLayout(false);
            TlpFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvBitacora).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpDivFormAndDgv;
        private TableLayoutPanel TlpAux1;
        private TableLayoutPanel TlpTitleLabel;
        private Componentes.CustomTitleLabel LbTitulo;
        private TableLayoutPanel TlpAux3;
        private TableLayoutPanel TlpFilter;
        private Componentes.CustomButton BtnFiltro1;
        private Componentes.CustomTextBox TbFiltro1;
        private Componentes.CustomComboBox CbFiltro1;
        private Componentes.CustomDataGridView DgvBitacora;
        private TableLayoutPanel tableLayoutPanel2;
        private Componentes.CustomButton BtnFiltro3;
        private Componentes.CustomTextBox TbFiltro3;
        private Componentes.CustomComboBox CbFiltro3;
        private TableLayoutPanel tableLayoutPanel1;
        private Componentes.CustomButton BtnFiltro2;
        private Componentes.CustomTextBox TbFiltro2;
        private Componentes.CustomComboBox CbFiltro2;
    }
}
