namespace Plantilla_Cliente
{
    partial class Reservas
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
            TlP_Reservas = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            Lbl_Director = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TlP_Reservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TlP_Reservas
            // 
            TlP_Reservas.BackColor = Color.FromArgb(28, 17, 69);
            TlP_Reservas.ColumnCount = 2;
            TlP_Reservas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.6556664F));
            TlP_Reservas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.34433F));
            TlP_Reservas.Controls.Add(pictureBox1, 0, 0);
            TlP_Reservas.Controls.Add(tableLayoutPanel1, 1, 0);
            TlP_Reservas.Dock = DockStyle.Fill;
            TlP_Reservas.Location = new Point(0, 0);
            TlP_Reservas.Name = "TlP_Reservas";
            TlP_Reservas.RowCount = 2;
            TlP_Reservas.RowStyles.Add(new RowStyle(SizeType.Percent, 41.6387978F));
            TlP_Reservas.RowStyles.Add(new RowStyle(SizeType.Percent, 58.3612022F));
            TlP_Reservas.Size = new Size(1394, 598);
            TlP_Reservas.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 243);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.03139F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.96861F));
            tableLayoutPanel1.Controls.Add(Lbl_Director, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(276, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1115, 243);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Lbl_Director
            // 
            Lbl_Director.AutoSize = true;
            Lbl_Director.BackColor = Color.White;
            Lbl_Director.Dock = DockStyle.Fill;
            Lbl_Director.Location = new Point(3, 0);
            Lbl_Director.Name = "Lbl_Director";
            Lbl_Director.Size = new Size(117, 80);
            Lbl_Director.TabIndex = 0;
            Lbl_Director.Text = "Director";
            Lbl_Director.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 80);
            label1.Name = "label1";
            label1.Size = new Size(117, 80);
            label1.TabIndex = 1;
            label1.Text = "Duración";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 160);
            label2.Name = "label2";
            label2.Size = new Size(117, 83);
            label2.TabIndex = 2;
            label2.Text = "Restricción";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(126, 0);
            label3.Name = "label3";
            label3.Size = new Size(986, 80);
            label3.TabIndex = 3;
            label3.Text = "XXX";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(126, 80);
            label4.Name = "label4";
            label4.Size = new Size(986, 80);
            label4.TabIndex = 4;
            label4.Text = "XXX";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(126, 160);
            label5.Name = "label5";
            label5.Size = new Size(986, 83);
            label5.TabIndex = 5;
            label5.Text = "XXX";
            // 
            // Reservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TlP_Reservas);
            Name = "Reservas";
            Size = new Size(1394, 598);
            TlP_Reservas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlP_Reservas;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label Lbl_Director;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
