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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservas));
            TlP_Reservas = new TableLayoutPanel();
            Tlp_Info = new TableLayoutPanel();
            Tx_DirectorHead = new Label();
            Tx_DuracionHead = new Label();
            Tx_RestriccionHead = new Label();
            Tx_Director = new Label();
            Tx_Duracion = new Label();
            Tx_Restriccion = new Label();
            Pic_Pelicula = new PictureBox();
            Tlp_Eleccion_Funciones = new TableLayoutPanel();
            Flp_Horarios = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            Flp_Funciones = new FlowLayoutPanel();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            Tx_Horarios = new Label();
            Tx_Funciones = new Label();
            Cbo_Cines = new ComboBox();
            Btn_Continuar = new Button();
            TlP_Reservas.SuspendLayout();
            Tlp_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Pelicula).BeginInit();
            Tlp_Eleccion_Funciones.SuspendLayout();
            Flp_Horarios.SuspendLayout();
            Flp_Funciones.SuspendLayout();
            SuspendLayout();
            // 
            // TlP_Reservas
            // 
            TlP_Reservas.BackColor = Color.FromArgb(28, 17, 69);
            TlP_Reservas.ColumnCount = 3;
            TlP_Reservas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6427555F));
            TlP_Reservas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.0948061F));
            TlP_Reservas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.28551F));
            TlP_Reservas.Controls.Add(Tlp_Info, 2, 0);
            TlP_Reservas.Controls.Add(Pic_Pelicula, 0, 0);
            TlP_Reservas.Controls.Add(Tlp_Eleccion_Funciones, 2, 1);
            TlP_Reservas.Controls.Add(Btn_Continuar, 2, 2);
            TlP_Reservas.Dock = DockStyle.Fill;
            TlP_Reservas.Location = new Point(0, 0);
            TlP_Reservas.Name = "TlP_Reservas";
            TlP_Reservas.RowCount = 3;
            TlP_Reservas.RowStyles.Add(new RowStyle(SizeType.Percent, 19.5034332F));
            TlP_Reservas.RowStyles.Add(new RowStyle(SizeType.Percent, 42.3368759F));
            TlP_Reservas.RowStyles.Add(new RowStyle(SizeType.Percent, 38.2397575F));
            TlP_Reservas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlP_Reservas.Size = new Size(1394, 659);
            TlP_Reservas.TabIndex = 0;
            TlP_Reservas.Paint += TlP_Reservas_Paint;
            // 
            // Tlp_Info
            // 
            Tlp_Info.ColumnCount = 2;
            Tlp_Info.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.03139F));
            Tlp_Info.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.96861F));
            Tlp_Info.Controls.Add(Tx_DirectorHead, 0, 0);
            Tlp_Info.Controls.Add(Tx_DuracionHead, 0, 1);
            Tlp_Info.Controls.Add(Tx_RestriccionHead, 0, 2);
            Tlp_Info.Controls.Add(Tx_Director, 1, 0);
            Tlp_Info.Controls.Add(Tx_Duracion, 1, 1);
            Tlp_Info.Controls.Add(Tx_Restriccion, 1, 2);
            Tlp_Info.Dock = DockStyle.Fill;
            Tlp_Info.Location = new Point(235, 3);
            Tlp_Info.Name = "Tlp_Info";
            Tlp_Info.RowCount = 3;
            Tlp_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Tlp_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Tlp_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Tlp_Info.Size = new Size(1156, 122);
            Tlp_Info.TabIndex = 4;
            // 
            // Tx_DirectorHead
            // 
            Tx_DirectorHead.AutoSize = true;
            Tx_DirectorHead.BackColor = Color.White;
            Tx_DirectorHead.Dock = DockStyle.Fill;
            Tx_DirectorHead.Location = new Point(3, 0);
            Tx_DirectorHead.Name = "Tx_DirectorHead";
            Tx_DirectorHead.Size = new Size(121, 40);
            Tx_DirectorHead.TabIndex = 0;
            Tx_DirectorHead.Text = "Director";
            Tx_DirectorHead.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tx_DuracionHead
            // 
            Tx_DuracionHead.AutoSize = true;
            Tx_DuracionHead.BackColor = Color.White;
            Tx_DuracionHead.Dock = DockStyle.Fill;
            Tx_DuracionHead.Location = new Point(3, 40);
            Tx_DuracionHead.Name = "Tx_DuracionHead";
            Tx_DuracionHead.Size = new Size(121, 40);
            Tx_DuracionHead.TabIndex = 1;
            Tx_DuracionHead.Text = "Duración";
            Tx_DuracionHead.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tx_RestriccionHead
            // 
            Tx_RestriccionHead.AutoSize = true;
            Tx_RestriccionHead.BackColor = Color.White;
            Tx_RestriccionHead.Dock = DockStyle.Fill;
            Tx_RestriccionHead.Location = new Point(3, 80);
            Tx_RestriccionHead.Name = "Tx_RestriccionHead";
            Tx_RestriccionHead.Size = new Size(121, 42);
            Tx_RestriccionHead.TabIndex = 2;
            Tx_RestriccionHead.Text = "Restricción";
            Tx_RestriccionHead.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tx_Director
            // 
            Tx_Director.AutoSize = true;
            Tx_Director.BackColor = Color.White;
            Tx_Director.Dock = DockStyle.Fill;
            Tx_Director.Location = new Point(130, 0);
            Tx_Director.Name = "Tx_Director";
            Tx_Director.Size = new Size(1023, 40);
            Tx_Director.TabIndex = 3;
            Tx_Director.Text = "XXX";
            // 
            // Tx_Duracion
            // 
            Tx_Duracion.AutoSize = true;
            Tx_Duracion.BackColor = Color.White;
            Tx_Duracion.Dock = DockStyle.Fill;
            Tx_Duracion.Location = new Point(130, 40);
            Tx_Duracion.Name = "Tx_Duracion";
            Tx_Duracion.Size = new Size(1023, 40);
            Tx_Duracion.TabIndex = 4;
            Tx_Duracion.Text = "XXX";
            // 
            // Tx_Restriccion
            // 
            Tx_Restriccion.AutoSize = true;
            Tx_Restriccion.BackColor = Color.White;
            Tx_Restriccion.Dock = DockStyle.Fill;
            Tx_Restriccion.Location = new Point(130, 80);
            Tx_Restriccion.Name = "Tx_Restriccion";
            Tx_Restriccion.Size = new Size(1023, 42);
            Tx_Restriccion.TabIndex = 5;
            Tx_Restriccion.Text = "XXX";
            // 
            // Pic_Pelicula
            // 
            Pic_Pelicula.BackColor = Color.White;
            TlP_Reservas.SetColumnSpan(Pic_Pelicula, 2);
            Pic_Pelicula.Dock = DockStyle.Fill;
            Pic_Pelicula.Image = (Image)resources.GetObject("Pic_Pelicula.Image");
            Pic_Pelicula.Location = new Point(3, 3);
            Pic_Pelicula.Name = "Pic_Pelicula";
            TlP_Reservas.SetRowSpan(Pic_Pelicula, 2);
            Pic_Pelicula.Size = new Size(226, 400);
            Pic_Pelicula.SizeMode = PictureBoxSizeMode.CenterImage;
            Pic_Pelicula.TabIndex = 0;
            Pic_Pelicula.TabStop = false;
            // 
            // Tlp_Eleccion_Funciones
            // 
            Tlp_Eleccion_Funciones.BackColor = Color.White;
            Tlp_Eleccion_Funciones.ColumnCount = 2;
            Tlp_Eleccion_Funciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.9482794F));
            Tlp_Eleccion_Funciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.05172F));
            Tlp_Eleccion_Funciones.Controls.Add(Flp_Horarios, 1, 2);
            Tlp_Eleccion_Funciones.Controls.Add(Flp_Funciones, 1, 1);
            Tlp_Eleccion_Funciones.Controls.Add(Tx_Horarios, 0, 2);
            Tlp_Eleccion_Funciones.Controls.Add(Tx_Funciones, 0, 1);
            Tlp_Eleccion_Funciones.Controls.Add(Cbo_Cines, 0, 0);
            Tlp_Eleccion_Funciones.Dock = DockStyle.Fill;
            Tlp_Eleccion_Funciones.Location = new Point(235, 131);
            Tlp_Eleccion_Funciones.Name = "Tlp_Eleccion_Funciones";
            Tlp_Eleccion_Funciones.RowCount = 3;
            Tlp_Eleccion_Funciones.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Tlp_Eleccion_Funciones.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Tlp_Eleccion_Funciones.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Tlp_Eleccion_Funciones.Size = new Size(1156, 272);
            Tlp_Eleccion_Funciones.TabIndex = 13;
            // 
            // Flp_Horarios
            // 
            Flp_Horarios.BackColor = Color.White;
            Flp_Horarios.Controls.Add(button1);
            Flp_Horarios.Controls.Add(button2);
            Flp_Horarios.Controls.Add(button3);
            Flp_Horarios.Controls.Add(button4);
            Flp_Horarios.Controls.Add(button5);
            Flp_Horarios.Controls.Add(button6);
            Flp_Horarios.Controls.Add(button7);
            Flp_Horarios.Controls.Add(button8);
            Flp_Horarios.Controls.Add(button9);
            Flp_Horarios.Controls.Add(button10);
            Flp_Horarios.Dock = DockStyle.Fill;
            Flp_Horarios.Location = new Point(129, 183);
            Flp_Horarios.Name = "Flp_Horarios";
            Flp_Horarios.Size = new Size(1024, 86);
            Flp_Horarios.TabIndex = 17;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(80, 60);
            button1.TabIndex = 0;
            button1.Text = "Fecha 1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(89, 3);
            button2.Name = "button2";
            button2.Size = new Size(80, 60);
            button2.TabIndex = 1;
            button2.Text = "Fecha 2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(175, 3);
            button3.Name = "button3";
            button3.Size = new Size(80, 60);
            button3.TabIndex = 2;
            button3.Text = "Fecha 3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(261, 3);
            button4.Name = "button4";
            button4.Size = new Size(80, 60);
            button4.TabIndex = 3;
            button4.Text = "Fecha 4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(347, 3);
            button5.Name = "button5";
            button5.Size = new Size(80, 60);
            button5.TabIndex = 4;
            button5.Text = "Fecha 5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(433, 3);
            button6.Name = "button6";
            button6.Size = new Size(80, 60);
            button6.TabIndex = 5;
            button6.Text = "Fecha 6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(519, 3);
            button7.Name = "button7";
            button7.Size = new Size(80, 60);
            button7.TabIndex = 6;
            button7.Text = "Fecha 7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(605, 3);
            button8.Name = "button8";
            button8.Size = new Size(80, 60);
            button8.TabIndex = 7;
            button8.Text = "Fecha 8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(691, 3);
            button9.Name = "button9";
            button9.Size = new Size(80, 60);
            button9.TabIndex = 8;
            button9.Text = "Fecha 9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(777, 3);
            button10.Name = "button10";
            button10.Size = new Size(80, 60);
            button10.TabIndex = 9;
            button10.Text = "Fecha 10";
            button10.UseVisualStyleBackColor = true;
            // 
            // Flp_Funciones
            // 
            Flp_Funciones.BackColor = Color.White;
            Flp_Funciones.Controls.Add(button11);
            Flp_Funciones.Controls.Add(button12);
            Flp_Funciones.Controls.Add(button13);
            Flp_Funciones.Controls.Add(button14);
            Flp_Funciones.Controls.Add(button15);
            Flp_Funciones.Controls.Add(button16);
            Flp_Funciones.Controls.Add(button17);
            Flp_Funciones.Dock = DockStyle.Fill;
            Flp_Funciones.Location = new Point(129, 93);
            Flp_Funciones.Name = "Flp_Funciones";
            Flp_Funciones.Size = new Size(1024, 84);
            Flp_Funciones.TabIndex = 16;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(3, 3);
            button11.Name = "button11";
            button11.Size = new Size(80, 60);
            button11.TabIndex = 0;
            button11.Text = "Fecha 1";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(89, 3);
            button12.Name = "button12";
            button12.Size = new Size(80, 60);
            button12.TabIndex = 1;
            button12.Text = "Fecha 2";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.FlatStyle = FlatStyle.Flat;
            button13.Location = new Point(175, 3);
            button13.Name = "button13";
            button13.Size = new Size(80, 60);
            button13.TabIndex = 2;
            button13.Text = "Fecha 3";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.FlatStyle = FlatStyle.Flat;
            button14.Location = new Point(261, 3);
            button14.Name = "button14";
            button14.Size = new Size(80, 60);
            button14.TabIndex = 3;
            button14.Text = "Fecha 4";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.FlatStyle = FlatStyle.Flat;
            button15.Location = new Point(347, 3);
            button15.Name = "button15";
            button15.Size = new Size(80, 60);
            button15.TabIndex = 4;
            button15.Text = "Fecha 5";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.FlatStyle = FlatStyle.Flat;
            button16.Location = new Point(433, 3);
            button16.Name = "button16";
            button16.Size = new Size(80, 60);
            button16.TabIndex = 5;
            button16.Text = "Fecha 6";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.FlatStyle = FlatStyle.Flat;
            button17.Location = new Point(519, 3);
            button17.Name = "button17";
            button17.Size = new Size(80, 60);
            button17.TabIndex = 6;
            button17.Text = "Fecha 7";
            button17.UseVisualStyleBackColor = true;
            // 
            // Tx_Horarios
            // 
            Tx_Horarios.AutoSize = true;
            Tx_Horarios.BackColor = Color.White;
            Tx_Horarios.Dock = DockStyle.Fill;
            Tx_Horarios.Location = new Point(3, 180);
            Tx_Horarios.Name = "Tx_Horarios";
            Tx_Horarios.Size = new Size(120, 92);
            Tx_Horarios.TabIndex = 15;
            Tx_Horarios.Text = "Horarios disponibles";
            Tx_Horarios.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tx_Funciones
            // 
            Tx_Funciones.AutoSize = true;
            Tx_Funciones.BackColor = Color.White;
            Tx_Funciones.Dock = DockStyle.Fill;
            Tx_Funciones.Location = new Point(3, 90);
            Tx_Funciones.Name = "Tx_Funciones";
            Tx_Funciones.Size = new Size(120, 90);
            Tx_Funciones.TabIndex = 13;
            Tx_Funciones.Text = "Funciones disponibles";
            Tx_Funciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cbo_Cines
            // 
            Tlp_Eleccion_Funciones.SetColumnSpan(Cbo_Cines, 2);
            Cbo_Cines.Dock = DockStyle.Fill;
            Cbo_Cines.DrawMode = DrawMode.OwnerDrawFixed;
            Cbo_Cines.FormattingEnabled = true;
            Cbo_Cines.ItemHeight = 50;
            Cbo_Cines.Location = new Point(3, 3);
            Cbo_Cines.Name = "Cbo_Cines";
            Cbo_Cines.Size = new Size(1150, 56);
            Cbo_Cines.TabIndex = 14;
            Cbo_Cines.Text = "Seleccione un cine...";
            // 
            // Btn_Continuar
            // 
            Btn_Continuar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Continuar.Location = new Point(235, 409);
            Btn_Continuar.Name = "Btn_Continuar";
            Btn_Continuar.Size = new Size(1156, 60);
            Btn_Continuar.TabIndex = 14;
            Btn_Continuar.Text = "Continuar";
            Btn_Continuar.UseVisualStyleBackColor = true;
            Btn_Continuar.Click += Btn_Continuar_Click;
            // 
            // Reservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TlP_Reservas);
            Name = "Reservas";
            Size = new Size(1394, 659);
            TlP_Reservas.ResumeLayout(false);
            Tlp_Info.ResumeLayout(false);
            Tlp_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Pelicula).EndInit();
            Tlp_Eleccion_Funciones.ResumeLayout(false);
            Tlp_Eleccion_Funciones.PerformLayout();
            Flp_Horarios.ResumeLayout(false);
            Flp_Funciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlP_Reservas;
        private TableLayoutPanel Tlp_Info;
        private Label Tx_DuracionHead;
        private Label Tx_RestriccionHead;
        private Label Tx_Restriccion;
        private PictureBox Pic_Pelicula;
        private TableLayoutPanel Tlp_Eleccion_Funciones;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private FlowLayoutPanel Flp_Funciones;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Label Tx_Funciones;
        private ComboBox Cbo_Cines;
        private Button Btn_Continuar;
        private Label Tx_DirectorHead;
        private Label Tx_Director;
        private Label Tx_Duracion;
        private FlowLayoutPanel Flp_Horarios;
        private Label Tx_Horarios;
        private Button Btn_DobFilter;
        private Button Btn_SubFilter;
    }
}
