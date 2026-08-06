namespace Forms_Admin.Usuarios
{
    partial class FrUcBitacora
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TlpDivFormAndDgv = new TableLayoutPanel();
            TlpAux1 = new TableLayoutPanel();
            TlpTitleLabel = new TableLayoutPanel();
            LbTitulo = new Componentes.CustomTitleLabel();
            TlpButtons = new TableLayoutPanel();
            BtnActualizar = new Componentes.CustomButton();
            DgvBitacora = new Componentes.CustomDataGridView();
            TlpDivFormAndDgv.SuspendLayout();
            TlpAux1.SuspendLayout();
            TlpTitleLabel.SuspendLayout();
            TlpButtons.SuspendLayout();
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
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Size = new Size(1050, 700);
            TlpDivFormAndDgv.TabIndex = 9;
            // 
            // TlpAux1
            // 
            TlpAux1.ColumnCount = 1;
            TlpAux1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpAux1.Controls.Add(TlpTitleLabel, 0, 0);
            TlpAux1.Controls.Add(TlpButtons, 0, 1);
            TlpAux1.Dock = DockStyle.Fill;
            TlpAux1.Location = new Point(0, 0);
            TlpAux1.Margin = new Padding(0);
            TlpAux1.Name = "TlpAux1";
            TlpAux1.RowCount = 2;
            TlpAux1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TlpAux1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TlpAux1.Size = new Size(1050, 150);
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
            TlpTitleLabel.TabIndex = 0;
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
            // TlpButtons
            // 
            TlpButtons.ColumnCount = 3;
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.Controls.Add(BtnActualizar, 1, 0);
            TlpButtons.Dock = DockStyle.Fill;
            TlpButtons.Location = new Point(0, 75);
            TlpButtons.Margin = new Padding(0);
            TlpButtons.Name = "TlpButtons";
            TlpButtons.RowCount = 1;
            TlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpButtons.Size = new Size(1050, 75);
            TlpButtons.TabIndex = 1;
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
            BtnActualizar.Location = new Point(470, 17);
            BtnActualizar.Margin = new Padding(0);
            BtnActualizar.MaximumSize = new Size(110, 40);
            BtnActualizar.MinimumSize = new Size(110, 40);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(110, 40);
            BtnActualizar.TabIndex = 0;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = false;
            BtnActualizar.Click += BtnActualizar_Click;
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
            DgvBitacora.Location = new Point(0, 150);
            DgvBitacora.Margin = new Padding(0);
            DgvBitacora.MultiSelect = false;
            DgvBitacora.Name = "DgvBitacora";
            DgvBitacora.ReadOnly = true;
            DgvBitacora.RowHeadersVisible = false;
            DgvBitacora.RowHeadersWidth = 51;
            DgvBitacora.RowTemplate.Height = 36;
            DgvBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvBitacora.Size = new Size(1050, 550);
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
            TlpTitleLabel.ResumeLayout(false);
            TlpTitleLabel.PerformLayout();
            TlpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvBitacora).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpDivFormAndDgv;
        private TableLayoutPanel TlpAux1;
        private TableLayoutPanel TlpTitleLabel;
        private Componentes.CustomTitleLabel LbTitulo;
        private TableLayoutPanel TlpButtons;
        private Componentes.CustomButton BtnActualizar;
        private Componentes.CustomDataGridView DgvBitacora;
    }
}
