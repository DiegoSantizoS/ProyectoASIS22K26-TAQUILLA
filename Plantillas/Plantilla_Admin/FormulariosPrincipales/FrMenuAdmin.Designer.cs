namespace Plantilla_Admin
{
    partial class FrMenuAdmin
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
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            PnlTop = new Panel();
            button1 = new Button();
            crownButton1 = new ReaLTaiizor.Controls.CrownButton();
            button3 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // nightControlBox1
            // 
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.Cursor = Cursors.Hand;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.Dock = DockStyle.Fill;
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1064, 3);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            tableLayoutPanel1.Controls.Add(nightControlBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(PnlTop, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1200, 700);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // PnlTop
            // 
            PnlTop.Dock = DockStyle.Fill;
            PnlTop.Location = new Point(0, 0);
            PnlTop.Margin = new Padding(0);
            PnlTop.Name = "PnlTop";
            PnlTop.Size = new Size(1061, 35);
            PnlTop.TabIndex = 2;
            PnlTop.MouseMove += panel2_MouseMove_1;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.logo1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-3, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(150, 150);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // crownButton1
            // 
            crownButton1.Image = Properties.Resources.logo1;
            crownButton1.Location = new Point(-3, 277);
            crownButton1.Name = "crownButton1";
            crownButton1.Padding = new Padding(5);
            crownButton1.Size = new Size(170, 47);
            crownButton1.TabIndex = 0;
            crownButton1.Text = "crownButton1";
            crownButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.logo1;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-3, -3);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(150, 150);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = true;
            // 
            // FrMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1200, 700);
            Controls.Add(tableLayoutPanel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1200, 700);
            Name = "FrMenuAdmin";
            Text = "MENU";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip_MenuAdmin;
        private ToolStripMenuItem toolStripMenuItem_cartelera;
        private ToolStripMenuItem toolStripMenuItem_reportes;
        private ToolStripMenuItem toolStripMenuItem_usuarios;
        private ToolStripMenuItem toolStripMenuItem_ayuda;
        private ToolStripMenuItem toolStripMenuItem_funciones;
        private ToolStripMenuItem toolStripMenuItem_sedes;
        private ToolStripMenuItem toolStripMenuItem_promociones;
        private ToolStripMenuItem toolStripMenuItem_landing;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel PnlTop;
        private Componentes.TableLayoutSlider tableLayoutSlider1;
        private ReaLTaiizor.Controls.CrownButton crownButton1;
        private Button button1;
        private Button button3;
    }
}