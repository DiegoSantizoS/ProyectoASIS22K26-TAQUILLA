namespace Plantilla_Cliente
{
    partial class Butacas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TlpButacas = new TableLayoutPanel();
            BtnConfirmacion = new Button();
            Tlpbutacaselector = new TableLayoutPanel();
            TlpButacas.SuspendLayout();
            SuspendLayout();
            // 
            // TlpButacas
            // 
            TlpButacas.ColumnCount = 1;
            TlpButacas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButacas.Controls.Add(BtnConfirmacion, 0, 1);
            TlpButacas.Controls.Add(Tlpbutacaselector, 0, 0);
            TlpButacas.Dock = DockStyle.Fill;
            TlpButacas.Location = new Point(0, 0);
            TlpButacas.Name = "TlpButacas";
            TlpButacas.RowCount = 2;
            TlpButacas.RowStyles.Add(new RowStyle(SizeType.Percent, 81.8314F));
            TlpButacas.RowStyles.Add(new RowStyle(SizeType.Percent, 18.1686039F));
            TlpButacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpButacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpButacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpButacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpButacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpButacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpButacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpButacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpButacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpButacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpButacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpButacas.Size = new Size(1288, 501);
            TlpButacas.TabIndex = 0;
            // 
            // BtnConfirmacion
            // 
            BtnConfirmacion.BackColor = Color.FromArgb(197, 155, 39);
            BtnConfirmacion.Cursor = Cursors.Hand;
            BtnConfirmacion.Dock = DockStyle.Fill;
            BtnConfirmacion.FlatAppearance.MouseDownBackColor = Color.FromArgb(112, 27, 40);
            BtnConfirmacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(112, 27, 40);
            BtnConfirmacion.FlatStyle = FlatStyle.Popup;
            BtnConfirmacion.ForeColor = Color.FromArgb(250, 248, 245);
            BtnConfirmacion.Location = new Point(3, 412);
            BtnConfirmacion.Name = "BtnConfirmacion";
            BtnConfirmacion.Size = new Size(1282, 86);
            BtnConfirmacion.TabIndex = 1;
            BtnConfirmacion.Text = "Continuar";
            BtnConfirmacion.UseVisualStyleBackColor = false;
            BtnConfirmacion.Click += Btn_Confirmacion_Click;
            // 
            // Tlpbutacaselector
            // 
            Tlpbutacaselector.BackColor = Color.FromArgb(18, 18, 18);
            Tlpbutacaselector.ColumnCount = 2;
            Tlpbutacaselector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tlpbutacaselector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tlpbutacaselector.Dock = DockStyle.Fill;
            Tlpbutacaselector.Location = new Point(3, 3);
            Tlpbutacaselector.Name = "Tlpbutacaselector";
            Tlpbutacaselector.RowCount = 2;
            Tlpbutacaselector.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Tlpbutacaselector.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Tlpbutacaselector.Size = new Size(1282, 403);
            Tlpbutacaselector.TabIndex = 2;
            // 
            // Butacas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 501);
            Controls.Add(TlpButacas);
            Name = "Butacas";
            Text = "Selector de butacas";
            Load += Butacas_Load;
            TlpButacas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpButacas;
        private Button BtnConfirmacion;
        private TableLayoutPanel Tlpbutacaselector;
    }
}