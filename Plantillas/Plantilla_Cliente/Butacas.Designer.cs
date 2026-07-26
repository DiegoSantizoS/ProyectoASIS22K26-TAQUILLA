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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            Tlp_butacaselector = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(Tlp_butacaselector, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.8314F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.1686039F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1288, 501);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 412);
            button1.Name = "button1";
            button1.Size = new Size(1282, 86);
            button1.TabIndex = 1;
            button1.Text = "Continuar";
            button1.UseVisualStyleBackColor = false;
            // 
            // Tlp_butacaselector
            // 
            Tlp_butacaselector.ColumnCount = 2;
            Tlp_butacaselector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tlp_butacaselector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tlp_butacaselector.Dock = DockStyle.Fill;
            Tlp_butacaselector.Location = new Point(3, 3);
            Tlp_butacaselector.Name = "Tlp_butacaselector";
            Tlp_butacaselector.RowCount = 2;
            Tlp_butacaselector.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Tlp_butacaselector.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Tlp_butacaselector.Size = new Size(1282, 403);
            Tlp_butacaselector.TabIndex = 2;
            // 
            // Butacas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 501);
            Controls.Add(tableLayoutPanel1);
            Name = "Butacas";
            Text = "Selector de butacas";
            Load += Butacas_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private TableLayoutPanel Tlp_butacaselector;
    }
}