namespace Plantilla_Admin
{
    partial class FrUcMantenimientoCartelera
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
            Tlp_main = new TableLayoutPanel();
            Tlp_formulario = new TableLayoutPanel();
            Tlp_id = new TableLayoutPanel();
            Txt_id = new TextBox();
            Tx_id = new Label();
            Tlp_titulo = new TableLayoutPanel();
            Txt_titulo = new TextBox();
            Tx_titulo = new Label();
            Tlp_estado = new TableLayoutPanel();
            Tx_Estado = new Label();
            Cb_estado = new ComboBox();
            Tlp_duracion = new TableLayoutPanel();
            Txt_duracion = new TextBox();
            Tx_duracion = new Label();
            Tlp_costo = new TableLayoutPanel();
            Txt_costo = new TextBox();
            Tx_costo = new Label();
            Tlp_director = new TableLayoutPanel();
            Tx_director = new Label();
            Txt_director = new TextBox();
            Tlp_clasificacion = new TableLayoutPanel();
            Tx_clasificacion = new Label();
            Cb_clasificacion = new ComboBox();
            Tlp_estreno = new TableLayoutPanel();
            Tx_estreno = new Label();
            dateTimePicker1 = new DateTimePicker();
            Tlp_grupoGenero = new TableLayoutPanel();
            Cb_genero = new ComboBox();
            Tx_Genero = new Label();
            Btn_agregarGenero = new Button();
            Tlp_dgvGenero = new TableLayoutPanel();
            Dgv_genero = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Borrar = new DataGridViewButtonColumn();
            Tlp_grupoDescripcion = new TableLayoutPanel();
            Rtxt_descripcion = new RichTextBox();
            Tx_descripcion = new Label();
            Tlp_trailer = new TableLayoutPanel();
            Tx_trailer = new Label();
            Txt_trailer = new TextBox();
            Btn_cargar = new Button();
            Tlp_thumbnail = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            Tlp_grupoFormato = new TableLayoutPanel();
            Cb_formato = new ComboBox();
            Tx_formato = new Label();
            Btn_insertarFormato = new Button();
            Tlp_dgvFormato = new TableLayoutPanel();
            Dgv_formato = new DataGridView();
            Dgvc_nombre = new DataGridViewTextBoxColumn();
            Dgvb_borrar = new DataGridViewButtonColumn();
            tableLayoutPanel14 = new TableLayoutPanel();
            Btn_cambiarImagen = new Button();
            Btn_agregarNuevaCartelera = new Button();
            pictureBox2 = new PictureBox();
            Tx_tab = new Label();
            Pnl_panelEstatico = new Panel();
            openFileDialog1 = new OpenFileDialog();
            Tlp_main.SuspendLayout();
            Tlp_formulario.SuspendLayout();
            Tlp_id.SuspendLayout();
            Tlp_titulo.SuspendLayout();
            Tlp_estado.SuspendLayout();
            Tlp_duracion.SuspendLayout();
            Tlp_costo.SuspendLayout();
            Tlp_director.SuspendLayout();
            Tlp_clasificacion.SuspendLayout();
            Tlp_estreno.SuspendLayout();
            Tlp_grupoGenero.SuspendLayout();
            Tlp_dgvGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_genero).BeginInit();
            Tlp_grupoDescripcion.SuspendLayout();
            Tlp_trailer.SuspendLayout();
            Tlp_thumbnail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Tlp_grupoFormato.SuspendLayout();
            Tlp_dgvFormato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_formato).BeginInit();
            tableLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Pnl_panelEstatico.SuspendLayout();
            SuspendLayout();
            // 
            // Tlp_main
            // 
            Tlp_main.ColumnCount = 2;
            Tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            Tlp_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Tlp_main.Controls.Add(Tlp_formulario, 0, 1);
            Tlp_main.Controls.Add(tableLayoutPanel14, 1, 1);
            Tlp_main.Controls.Add(Tx_tab, 0, 0);
            Tlp_main.Dock = DockStyle.Fill;
            Tlp_main.Location = new Point(0, 0);
            Tlp_main.Margin = new Padding(3, 3, 20, 20);
            Tlp_main.Name = "Tlp_main";
            Tlp_main.RowCount = 2;
            Tlp_main.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            Tlp_main.RowStyles.Add(new RowStyle(SizeType.Absolute, 450F));
            Tlp_main.Size = new Size(1050, 700);
            Tlp_main.TabIndex = 0;
            // 
            // Tlp_formulario
            // 
            Tlp_formulario.ColumnCount = 2;
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tlp_formulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tlp_formulario.Controls.Add(Tlp_id, 0, 0);
            Tlp_formulario.Controls.Add(Tlp_titulo, 0, 1);
            Tlp_formulario.Controls.Add(Tlp_estado, 0, 2);
            Tlp_formulario.Controls.Add(Tlp_duracion, 0, 3);
            Tlp_formulario.Controls.Add(Tlp_costo, 0, 4);
            Tlp_formulario.Controls.Add(Tlp_director, 0, 5);
            Tlp_formulario.Controls.Add(Tlp_clasificacion, 0, 6);
            Tlp_formulario.Controls.Add(Tlp_estreno, 0, 7);
            Tlp_formulario.Controls.Add(Tlp_grupoGenero, 0, 8);
            Tlp_formulario.Controls.Add(Tlp_dgvGenero, 0, 9);
            Tlp_formulario.Controls.Add(Tlp_grupoDescripcion, 1, 0);
            Tlp_formulario.Controls.Add(Tlp_trailer, 1, 3);
            Tlp_formulario.Controls.Add(Tlp_thumbnail, 1, 4);
            Tlp_formulario.Controls.Add(Tlp_grupoFormato, 1, 8);
            Tlp_formulario.Controls.Add(Tlp_dgvFormato, 1, 9);
            Tlp_formulario.Dock = DockStyle.Fill;
            Tlp_formulario.Location = new Point(0, 75);
            Tlp_formulario.Margin = new Padding(0, 0, 0, 20);
            Tlp_formulario.Name = "Tlp_formulario";
            Tlp_formulario.RowCount = 12;
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_formulario.Size = new Size(787, 605);
            Tlp_formulario.TabIndex = 3;
            // 
            // Tlp_id
            // 
            Tlp_id.ColumnCount = 2;
            Tlp_id.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_id.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_id.Controls.Add(Txt_id, 1, 0);
            Tlp_id.Controls.Add(Tx_id, 0, 0);
            Tlp_id.Dock = DockStyle.Fill;
            Tlp_id.Location = new Point(0, 0);
            Tlp_id.Margin = new Padding(0);
            Tlp_id.Name = "Tlp_id";
            Tlp_id.RowCount = 1;
            Tlp_id.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_id.Size = new Size(393, 50);
            Tlp_id.TabIndex = 20;
            // 
            // Txt_id
            // 
            Txt_id.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_id.Location = new Point(103, 3);
            Txt_id.Name = "Txt_id";
            Txt_id.Size = new Size(287, 27);
            Txt_id.TabIndex = 3;
            // 
            // Tx_id
            // 
            Tx_id.AutoSize = true;
            Tx_id.Dock = DockStyle.Fill;
            Tx_id.Location = new Point(3, 0);
            Tx_id.Margin = new Padding(3, 0, 3, 3);
            Tx_id.Name = "Tx_id";
            Tx_id.Size = new Size(94, 47);
            Tx_id.TabIndex = 0;
            Tx_id.Text = "ID";
            Tx_id.TextAlign = ContentAlignment.TopRight;
            // 
            // Tlp_titulo
            // 
            Tlp_titulo.ColumnCount = 2;
            Tlp_titulo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_titulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_titulo.Controls.Add(Txt_titulo, 1, 0);
            Tlp_titulo.Controls.Add(Tx_titulo, 0, 0);
            Tlp_titulo.Dock = DockStyle.Fill;
            Tlp_titulo.Location = new Point(0, 50);
            Tlp_titulo.Margin = new Padding(0);
            Tlp_titulo.Name = "Tlp_titulo";
            Tlp_titulo.RowCount = 1;
            Tlp_titulo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_titulo.Size = new Size(393, 50);
            Tlp_titulo.TabIndex = 3;
            // 
            // Txt_titulo
            // 
            Txt_titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_titulo.Location = new Point(103, 3);
            Txt_titulo.Name = "Txt_titulo";
            Txt_titulo.Size = new Size(287, 27);
            Txt_titulo.TabIndex = 3;
            // 
            // Tx_titulo
            // 
            Tx_titulo.AutoSize = true;
            Tx_titulo.Dock = DockStyle.Fill;
            Tx_titulo.Location = new Point(3, 0);
            Tx_titulo.Margin = new Padding(3, 0, 3, 3);
            Tx_titulo.Name = "Tx_titulo";
            Tx_titulo.Size = new Size(94, 47);
            Tx_titulo.TabIndex = 0;
            Tx_titulo.Text = "Titulo";
            Tx_titulo.TextAlign = ContentAlignment.TopRight;
            // 
            // Tlp_estado
            // 
            Tlp_estado.ColumnCount = 2;
            Tlp_estado.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_estado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_estado.Controls.Add(Tx_Estado, 0, 0);
            Tlp_estado.Controls.Add(Cb_estado, 1, 0);
            Tlp_estado.Dock = DockStyle.Fill;
            Tlp_estado.Location = new Point(0, 100);
            Tlp_estado.Margin = new Padding(0);
            Tlp_estado.Name = "Tlp_estado";
            Tlp_estado.RowCount = 1;
            Tlp_estado.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_estado.Size = new Size(393, 50);
            Tlp_estado.TabIndex = 4;
            // 
            // Tx_Estado
            // 
            Tx_Estado.AutoSize = true;
            Tx_Estado.Dock = DockStyle.Fill;
            Tx_Estado.ImageAlign = ContentAlignment.TopRight;
            Tx_Estado.Location = new Point(3, 0);
            Tx_Estado.Margin = new Padding(3, 0, 3, 3);
            Tx_Estado.Name = "Tx_Estado";
            Tx_Estado.Size = new Size(94, 47);
            Tx_Estado.TabIndex = 0;
            Tx_Estado.Text = "Estado";
            Tx_Estado.TextAlign = ContentAlignment.TopRight;
            // 
            // Cb_estado
            // 
            Cb_estado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Cb_estado.FormattingEnabled = true;
            Cb_estado.Location = new Point(103, 3);
            Cb_estado.Name = "Cb_estado";
            Cb_estado.Size = new Size(287, 28);
            Cb_estado.TabIndex = 1;
            // 
            // Tlp_duracion
            // 
            Tlp_duracion.ColumnCount = 2;
            Tlp_duracion.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_duracion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_duracion.Controls.Add(Txt_duracion, 1, 0);
            Tlp_duracion.Controls.Add(Tx_duracion, 0, 0);
            Tlp_duracion.Dock = DockStyle.Fill;
            Tlp_duracion.Location = new Point(0, 150);
            Tlp_duracion.Margin = new Padding(0);
            Tlp_duracion.Name = "Tlp_duracion";
            Tlp_duracion.RowCount = 1;
            Tlp_duracion.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_duracion.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_duracion.Size = new Size(393, 50);
            Tlp_duracion.TabIndex = 5;
            // 
            // Txt_duracion
            // 
            Txt_duracion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_duracion.Location = new Point(103, 3);
            Txt_duracion.Name = "Txt_duracion";
            Txt_duracion.Size = new Size(287, 27);
            Txt_duracion.TabIndex = 2;
            // 
            // Tx_duracion
            // 
            Tx_duracion.AutoSize = true;
            Tx_duracion.Dock = DockStyle.Fill;
            Tx_duracion.Location = new Point(3, 0);
            Tx_duracion.Margin = new Padding(3, 0, 3, 3);
            Tx_duracion.Name = "Tx_duracion";
            Tx_duracion.Size = new Size(94, 47);
            Tx_duracion.TabIndex = 0;
            Tx_duracion.Text = "Duración";
            Tx_duracion.TextAlign = ContentAlignment.TopRight;
            // 
            // Tlp_costo
            // 
            Tlp_costo.ColumnCount = 2;
            Tlp_costo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_costo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_costo.Controls.Add(Txt_costo, 1, 0);
            Tlp_costo.Controls.Add(Tx_costo, 0, 0);
            Tlp_costo.Dock = DockStyle.Fill;
            Tlp_costo.Location = new Point(0, 200);
            Tlp_costo.Margin = new Padding(0);
            Tlp_costo.Name = "Tlp_costo";
            Tlp_costo.RowCount = 1;
            Tlp_costo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_costo.Size = new Size(393, 50);
            Tlp_costo.TabIndex = 8;
            // 
            // Txt_costo
            // 
            Txt_costo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_costo.Location = new Point(103, 3);
            Txt_costo.Name = "Txt_costo";
            Txt_costo.Size = new Size(287, 27);
            Txt_costo.TabIndex = 2;
            // 
            // Tx_costo
            // 
            Tx_costo.AutoSize = true;
            Tx_costo.Dock = DockStyle.Fill;
            Tx_costo.Location = new Point(3, 0);
            Tx_costo.Margin = new Padding(3, 0, 3, 3);
            Tx_costo.Name = "Tx_costo";
            Tx_costo.Size = new Size(94, 47);
            Tx_costo.TabIndex = 0;
            Tx_costo.Text = "Costo";
            Tx_costo.TextAlign = ContentAlignment.TopRight;
            // 
            // Tlp_director
            // 
            Tlp_director.ColumnCount = 2;
            Tlp_director.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_director.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_director.Controls.Add(Tx_director, 0, 0);
            Tlp_director.Controls.Add(Txt_director, 1, 0);
            Tlp_director.Dock = DockStyle.Fill;
            Tlp_director.Location = new Point(0, 250);
            Tlp_director.Margin = new Padding(0);
            Tlp_director.Name = "Tlp_director";
            Tlp_director.RowCount = 1;
            Tlp_director.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_director.Size = new Size(393, 50);
            Tlp_director.TabIndex = 11;
            // 
            // Tx_director
            // 
            Tx_director.AutoSize = true;
            Tx_director.Dock = DockStyle.Fill;
            Tx_director.Location = new Point(3, 0);
            Tx_director.Margin = new Padding(3, 0, 3, 3);
            Tx_director.Name = "Tx_director";
            Tx_director.Size = new Size(94, 47);
            Tx_director.TabIndex = 0;
            Tx_director.Text = "Director";
            Tx_director.TextAlign = ContentAlignment.TopRight;
            // 
            // Txt_director
            // 
            Txt_director.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_director.Location = new Point(103, 3);
            Txt_director.Name = "Txt_director";
            Txt_director.Size = new Size(287, 27);
            Txt_director.TabIndex = 1;
            // 
            // Tlp_clasificacion
            // 
            Tlp_clasificacion.ColumnCount = 2;
            Tlp_clasificacion.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_clasificacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_clasificacion.Controls.Add(Tx_clasificacion, 0, 0);
            Tlp_clasificacion.Controls.Add(Cb_clasificacion, 1, 0);
            Tlp_clasificacion.Dock = DockStyle.Fill;
            Tlp_clasificacion.Location = new Point(0, 300);
            Tlp_clasificacion.Margin = new Padding(0);
            Tlp_clasificacion.Name = "Tlp_clasificacion";
            Tlp_clasificacion.RowCount = 1;
            Tlp_clasificacion.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_clasificacion.Size = new Size(393, 50);
            Tlp_clasificacion.TabIndex = 12;
            // 
            // Tx_clasificacion
            // 
            Tx_clasificacion.AutoSize = true;
            Tx_clasificacion.Dock = DockStyle.Fill;
            Tx_clasificacion.Location = new Point(3, 0);
            Tx_clasificacion.Margin = new Padding(3, 0, 3, 3);
            Tx_clasificacion.Name = "Tx_clasificacion";
            Tx_clasificacion.Size = new Size(94, 47);
            Tx_clasificacion.TabIndex = 0;
            Tx_clasificacion.Text = "Clasificación";
            Tx_clasificacion.TextAlign = ContentAlignment.TopRight;
            // 
            // Cb_clasificacion
            // 
            Cb_clasificacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Cb_clasificacion.FormattingEnabled = true;
            Cb_clasificacion.Location = new Point(103, 3);
            Cb_clasificacion.Name = "Cb_clasificacion";
            Cb_clasificacion.Size = new Size(287, 28);
            Cb_clasificacion.TabIndex = 1;
            // 
            // Tlp_estreno
            // 
            Tlp_estreno.ColumnCount = 2;
            Tlp_estreno.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_estreno.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_estreno.Controls.Add(Tx_estreno, 0, 0);
            Tlp_estreno.Controls.Add(dateTimePicker1, 1, 0);
            Tlp_estreno.Dock = DockStyle.Fill;
            Tlp_estreno.Location = new Point(0, 350);
            Tlp_estreno.Margin = new Padding(0);
            Tlp_estreno.Name = "Tlp_estreno";
            Tlp_estreno.RowCount = 1;
            Tlp_estreno.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_estreno.Size = new Size(393, 50);
            Tlp_estreno.TabIndex = 2;
            // 
            // Tx_estreno
            // 
            Tx_estreno.AutoSize = true;
            Tx_estreno.Dock = DockStyle.Fill;
            Tx_estreno.Location = new Point(3, 0);
            Tx_estreno.Margin = new Padding(3, 0, 3, 3);
            Tx_estreno.Name = "Tx_estreno";
            Tx_estreno.Size = new Size(94, 47);
            Tx_estreno.TabIndex = 0;
            Tx_estreno.Text = "Fecha de Estreno";
            Tx_estreno.TextAlign = ContentAlignment.TopRight;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(103, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(287, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // Tlp_grupoGenero
            // 
            Tlp_grupoGenero.ColumnCount = 3;
            Tlp_grupoGenero.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_grupoGenero.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_grupoGenero.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_grupoGenero.Controls.Add(Cb_genero, 1, 0);
            Tlp_grupoGenero.Controls.Add(Tx_Genero, 0, 0);
            Tlp_grupoGenero.Controls.Add(Btn_agregarGenero, 2, 0);
            Tlp_grupoGenero.Dock = DockStyle.Fill;
            Tlp_grupoGenero.Location = new Point(0, 400);
            Tlp_grupoGenero.Margin = new Padding(0);
            Tlp_grupoGenero.Name = "Tlp_grupoGenero";
            Tlp_grupoGenero.RowCount = 1;
            Tlp_grupoGenero.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_grupoGenero.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_grupoGenero.Size = new Size(393, 50);
            Tlp_grupoGenero.TabIndex = 15;
            // 
            // Cb_genero
            // 
            Cb_genero.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Cb_genero.FormattingEnabled = true;
            Cb_genero.Location = new Point(103, 11);
            Cb_genero.Name = "Cb_genero";
            Cb_genero.Size = new Size(187, 28);
            Cb_genero.TabIndex = 3;
            // 
            // Tx_Genero
            // 
            Tx_Genero.AutoSize = true;
            Tx_Genero.Dock = DockStyle.Fill;
            Tx_Genero.Location = new Point(3, 0);
            Tx_Genero.Margin = new Padding(3, 0, 3, 3);
            Tx_Genero.Name = "Tx_Genero";
            Tx_Genero.Size = new Size(94, 47);
            Tx_Genero.TabIndex = 0;
            Tx_Genero.Text = "Genero";
            Tx_Genero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Btn_agregarGenero
            // 
            Btn_agregarGenero.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Btn_agregarGenero.Location = new Point(293, 10);
            Btn_agregarGenero.Margin = new Padding(0);
            Btn_agregarGenero.Name = "Btn_agregarGenero";
            Btn_agregarGenero.Size = new Size(100, 29);
            Btn_agregarGenero.TabIndex = 2;
            Btn_agregarGenero.Text = "AGREGAR";
            Btn_agregarGenero.UseVisualStyleBackColor = true;
            // 
            // Tlp_dgvGenero
            // 
            Tlp_dgvGenero.ColumnCount = 2;
            Tlp_dgvGenero.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_dgvGenero.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_dgvGenero.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tlp_dgvGenero.Controls.Add(Dgv_genero, 1, 0);
            Tlp_dgvGenero.Dock = DockStyle.Fill;
            Tlp_dgvGenero.Location = new Point(0, 450);
            Tlp_dgvGenero.Margin = new Padding(0);
            Tlp_dgvGenero.Name = "Tlp_dgvGenero";
            Tlp_dgvGenero.RowCount = 1;
            Tlp_formulario.SetRowSpan(Tlp_dgvGenero, 3);
            Tlp_dgvGenero.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_dgvGenero.Size = new Size(393, 155);
            Tlp_dgvGenero.TabIndex = 17;
            // 
            // Dgv_genero
            // 
            Dgv_genero.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_genero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_genero.Columns.AddRange(new DataGridViewColumn[] { Nombre, Borrar });
            Dgv_genero.Dock = DockStyle.Fill;
            Dgv_genero.Location = new Point(100, 0);
            Dgv_genero.Margin = new Padding(0);
            Dgv_genero.Name = "Dgv_genero";
            Dgv_genero.RowHeadersWidth = 51;
            Dgv_genero.Size = new Size(293, 155);
            Dgv_genero.TabIndex = 16;
            // 
            // Nombre
            // 
            Nombre.FillWeight = 200F;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Borrar
            // 
            Borrar.HeaderText = "Borrar";
            Borrar.MinimumWidth = 6;
            Borrar.Name = "Borrar";
            // 
            // Tlp_grupoDescripcion
            // 
            Tlp_grupoDescripcion.ColumnCount = 2;
            Tlp_grupoDescripcion.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_grupoDescripcion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_grupoDescripcion.Controls.Add(Rtxt_descripcion, 1, 0);
            Tlp_grupoDescripcion.Controls.Add(Tx_descripcion, 0, 0);
            Tlp_grupoDescripcion.Dock = DockStyle.Fill;
            Tlp_grupoDescripcion.Location = new Point(393, 0);
            Tlp_grupoDescripcion.Margin = new Padding(0);
            Tlp_grupoDescripcion.Name = "Tlp_grupoDescripcion";
            Tlp_grupoDescripcion.RowCount = 1;
            Tlp_formulario.SetRowSpan(Tlp_grupoDescripcion, 3);
            Tlp_grupoDescripcion.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_grupoDescripcion.Size = new Size(394, 150);
            Tlp_grupoDescripcion.TabIndex = 13;
            // 
            // Rtxt_descripcion
            // 
            Rtxt_descripcion.Dock = DockStyle.Fill;
            Rtxt_descripcion.Location = new Point(103, 3);
            Rtxt_descripcion.Name = "Rtxt_descripcion";
            Rtxt_descripcion.Size = new Size(288, 144);
            Rtxt_descripcion.TabIndex = 1;
            Rtxt_descripcion.Text = "";
            // 
            // Tx_descripcion
            // 
            Tx_descripcion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Tx_descripcion.AutoSize = true;
            Tx_descripcion.Location = new Point(10, 0);
            Tx_descripcion.Name = "Tx_descripcion";
            Tx_descripcion.Size = new Size(87, 20);
            Tx_descripcion.TabIndex = 0;
            Tx_descripcion.Text = "Descripción";
            Tx_descripcion.TextAlign = ContentAlignment.TopRight;
            // 
            // Tlp_trailer
            // 
            Tlp_trailer.ColumnCount = 3;
            Tlp_trailer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_trailer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_trailer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_trailer.Controls.Add(Tx_trailer, 0, 0);
            Tlp_trailer.Controls.Add(Txt_trailer, 1, 0);
            Tlp_trailer.Controls.Add(Btn_cargar, 2, 0);
            Tlp_trailer.Dock = DockStyle.Fill;
            Tlp_trailer.Location = new Point(393, 150);
            Tlp_trailer.Margin = new Padding(0);
            Tlp_trailer.Name = "Tlp_trailer";
            Tlp_trailer.RowCount = 1;
            Tlp_trailer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_trailer.Size = new Size(394, 50);
            Tlp_trailer.TabIndex = 6;
            // 
            // Tx_trailer
            // 
            Tx_trailer.AutoSize = true;
            Tx_trailer.Dock = DockStyle.Fill;
            Tx_trailer.Location = new Point(3, 0);
            Tx_trailer.Margin = new Padding(3, 0, 3, 3);
            Tx_trailer.Name = "Tx_trailer";
            Tx_trailer.Size = new Size(94, 47);
            Tx_trailer.TabIndex = 0;
            Tx_trailer.Text = "Trailer";
            Tx_trailer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Txt_trailer
            // 
            Txt_trailer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Txt_trailer.Location = new Point(103, 11);
            Txt_trailer.Name = "Txt_trailer";
            Txt_trailer.Size = new Size(188, 27);
            Txt_trailer.TabIndex = 1;
            // 
            // Btn_cargar
            // 
            Btn_cargar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Btn_cargar.Location = new Point(294, 10);
            Btn_cargar.Margin = new Padding(0);
            Btn_cargar.Name = "Btn_cargar";
            Btn_cargar.Size = new Size(100, 29);
            Btn_cargar.TabIndex = 2;
            Btn_cargar.Text = "CARGAR";
            Btn_cargar.UseVisualStyleBackColor = true;
            Btn_cargar.Click += button1_Click;
            // 
            // Tlp_thumbnail
            // 
            Tlp_thumbnail.ColumnCount = 2;
            Tlp_thumbnail.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_thumbnail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_thumbnail.Controls.Add(pictureBox1, 1, 0);
            Tlp_thumbnail.Dock = DockStyle.Fill;
            Tlp_thumbnail.Location = new Point(393, 200);
            Tlp_thumbnail.Margin = new Padding(0);
            Tlp_thumbnail.Name = "Tlp_thumbnail";
            Tlp_thumbnail.RowCount = 1;
            Tlp_formulario.SetRowSpan(Tlp_thumbnail, 4);
            Tlp_thumbnail.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_thumbnail.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_thumbnail.Size = new Size(394, 200);
            Tlp_thumbnail.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(100, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Tlp_grupoFormato
            // 
            Tlp_grupoFormato.ColumnCount = 3;
            Tlp_grupoFormato.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_grupoFormato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_grupoFormato.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_grupoFormato.Controls.Add(Cb_formato, 1, 0);
            Tlp_grupoFormato.Controls.Add(Tx_formato, 0, 0);
            Tlp_grupoFormato.Controls.Add(Btn_insertarFormato, 2, 0);
            Tlp_grupoFormato.Dock = DockStyle.Fill;
            Tlp_grupoFormato.Location = new Point(393, 400);
            Tlp_grupoFormato.Margin = new Padding(0);
            Tlp_grupoFormato.Name = "Tlp_grupoFormato";
            Tlp_grupoFormato.RowCount = 1;
            Tlp_grupoFormato.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_grupoFormato.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_grupoFormato.Size = new Size(394, 50);
            Tlp_grupoFormato.TabIndex = 18;
            // 
            // Cb_formato
            // 
            Cb_formato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Cb_formato.FormattingEnabled = true;
            Cb_formato.Location = new Point(103, 11);
            Cb_formato.Name = "Cb_formato";
            Cb_formato.Size = new Size(188, 28);
            Cb_formato.TabIndex = 3;
            // 
            // Tx_formato
            // 
            Tx_formato.AutoSize = true;
            Tx_formato.Dock = DockStyle.Fill;
            Tx_formato.Location = new Point(3, 0);
            Tx_formato.Margin = new Padding(3, 0, 3, 3);
            Tx_formato.Name = "Tx_formato";
            Tx_formato.Size = new Size(94, 47);
            Tx_formato.TabIndex = 0;
            Tx_formato.Text = "Formato";
            Tx_formato.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Btn_insertarFormato
            // 
            Btn_insertarFormato.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Btn_insertarFormato.Location = new Point(294, 10);
            Btn_insertarFormato.Margin = new Padding(0);
            Btn_insertarFormato.Name = "Btn_insertarFormato";
            Btn_insertarFormato.Size = new Size(100, 29);
            Btn_insertarFormato.TabIndex = 2;
            Btn_insertarFormato.Text = "AGREGAR";
            Btn_insertarFormato.UseVisualStyleBackColor = true;
            // 
            // Tlp_dgvFormato
            // 
            Tlp_dgvFormato.ColumnCount = 2;
            Tlp_dgvFormato.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp_dgvFormato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_dgvFormato.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tlp_dgvFormato.Controls.Add(Dgv_formato, 1, 0);
            Tlp_dgvFormato.Dock = DockStyle.Fill;
            Tlp_dgvFormato.Location = new Point(393, 450);
            Tlp_dgvFormato.Margin = new Padding(0);
            Tlp_dgvFormato.Name = "Tlp_dgvFormato";
            Tlp_dgvFormato.RowCount = 1;
            Tlp_formulario.SetRowSpan(Tlp_dgvFormato, 3);
            Tlp_dgvFormato.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp_dgvFormato.Size = new Size(394, 155);
            Tlp_dgvFormato.TabIndex = 19;
            // 
            // Dgv_formato
            // 
            Dgv_formato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_formato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_formato.Columns.AddRange(new DataGridViewColumn[] { Dgvc_nombre, Dgvb_borrar });
            Dgv_formato.Dock = DockStyle.Fill;
            Dgv_formato.Location = new Point(100, 0);
            Dgv_formato.Margin = new Padding(0);
            Dgv_formato.Name = "Dgv_formato";
            Dgv_formato.RowHeadersWidth = 51;
            Dgv_formato.Size = new Size(294, 155);
            Dgv_formato.TabIndex = 16;
            // 
            // Dgvc_nombre
            // 
            Dgvc_nombre.FillWeight = 200F;
            Dgvc_nombre.HeaderText = "Nombre";
            Dgvc_nombre.MinimumWidth = 6;
            Dgvc_nombre.Name = "Dgvc_nombre";
            // 
            // Dgvb_borrar
            // 
            Dgvb_borrar.HeaderText = "Borrar";
            Dgvb_borrar.MinimumWidth = 6;
            Dgvb_borrar.Name = "Dgvb_borrar";
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 1;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Controls.Add(Btn_cambiarImagen, 0, 1);
            tableLayoutPanel14.Controls.Add(Btn_agregarNuevaCartelera, 0, 2);
            tableLayoutPanel14.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(807, 75);
            tableLayoutPanel14.Margin = new Padding(20, 0, 20, 0);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 3;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 400F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel14.Size = new Size(223, 625);
            tableLayoutPanel14.TabIndex = 4;
            // 
            // Btn_cambiarImagen
            // 
            Btn_cambiarImagen.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Btn_cambiarImagen.Location = new Point(0, 410);
            Btn_cambiarImagen.Margin = new Padding(0);
            Btn_cambiarImagen.Name = "Btn_cambiarImagen";
            Btn_cambiarImagen.Size = new Size(223, 29);
            Btn_cambiarImagen.TabIndex = 6;
            Btn_cambiarImagen.Text = "NUEVA IMAGEN";
            Btn_cambiarImagen.UseVisualStyleBackColor = true;
            Btn_cambiarImagen.Click += Btn_cambiarImagen_Click;
            // 
            // Btn_agregarNuevaCartelera
            // 
            Btn_agregarNuevaCartelera.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Btn_agregarNuevaCartelera.Location = new Point(11, 500);
            Btn_agregarNuevaCartelera.Margin = new Padding(0, 50, 0, 50);
            Btn_agregarNuevaCartelera.Name = "Btn_agregarNuevaCartelera";
            Btn_agregarNuevaCartelera.Size = new Size(200, 75);
            Btn_agregarNuevaCartelera.TabIndex = 4;
            Btn_agregarNuevaCartelera.Text = "AGREGAR NUEVA CARTELERA";
            Btn_agregarNuevaCartelera.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.EjemploCartelera;
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(223, 394);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Tx_tab
            // 
            Tx_tab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Tx_tab.AutoSize = true;
            Tlp_main.SetColumnSpan(Tx_tab, 2);
            Tx_tab.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tx_tab.Location = new Point(3, 0);
            Tx_tab.Name = "Tx_tab";
            Tx_tab.Size = new Size(1044, 75);
            Tx_tab.TabIndex = 6;
            Tx_tab.Text = "AGREGAR / ACTUALIZAR CARTELERA";
            Tx_tab.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Pnl_panelEstatico
            // 
            Pnl_panelEstatico.Controls.Add(Tlp_main);
            Pnl_panelEstatico.Location = new Point(0, 0);
            Pnl_panelEstatico.Margin = new Padding(3, 3, 20, 20);
            Pnl_panelEstatico.MinimumSize = new Size(1050, 700);
            Pnl_panelEstatico.Name = "Pnl_panelEstatico";
            Pnl_panelEstatico.Size = new Size(1050, 700);
            Pnl_panelEstatico.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrUcMantenimientoCartelera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Pnl_panelEstatico);
            Name = "FrUcMantenimientoCartelera";
            Size = new Size(1050, 700);
            Tlp_main.ResumeLayout(false);
            Tlp_main.PerformLayout();
            Tlp_formulario.ResumeLayout(false);
            Tlp_id.ResumeLayout(false);
            Tlp_id.PerformLayout();
            Tlp_titulo.ResumeLayout(false);
            Tlp_titulo.PerformLayout();
            Tlp_estado.ResumeLayout(false);
            Tlp_estado.PerformLayout();
            Tlp_duracion.ResumeLayout(false);
            Tlp_duracion.PerformLayout();
            Tlp_costo.ResumeLayout(false);
            Tlp_costo.PerformLayout();
            Tlp_director.ResumeLayout(false);
            Tlp_director.PerformLayout();
            Tlp_clasificacion.ResumeLayout(false);
            Tlp_clasificacion.PerformLayout();
            Tlp_estreno.ResumeLayout(false);
            Tlp_estreno.PerformLayout();
            Tlp_grupoGenero.ResumeLayout(false);
            Tlp_grupoGenero.PerformLayout();
            Tlp_dgvGenero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_genero).EndInit();
            Tlp_grupoDescripcion.ResumeLayout(false);
            Tlp_grupoDescripcion.PerformLayout();
            Tlp_trailer.ResumeLayout(false);
            Tlp_trailer.PerformLayout();
            Tlp_thumbnail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Tlp_grupoFormato.ResumeLayout(false);
            Tlp_grupoFormato.PerformLayout();
            Tlp_dgvFormato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_formato).EndInit();
            tableLayoutPanel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Pnl_panelEstatico.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Tlp_main;
        private Panel Pnl_panelEstatico;
        private TableLayoutPanel Tlp_formulario;
        private TableLayoutPanel Tlp_estreno;
        private TableLayoutPanel Tlp_duracion;
        private Label Tx_duracion;
        private TableLayoutPanel Tlp_estado;
        private Label Tx_Estado;
        private ComboBox Cb_estado;
        private TableLayoutPanel Tlp_titulo;
        private Label Tx_titulo;
        private Label Tx_estreno;
        private TableLayoutPanel Tlp_trailer;
        private Label Tx_trailer;
        private TableLayoutPanel Tlp_thumbnail;
        private TextBox Txt_trailer;
        private TableLayoutPanel Tlp_director;
        private Label Tx_director;
        private TableLayoutPanel Tlp_costo;
        private Label Tx_costo;
        private TableLayoutPanel Tlp_clasificacion;
        private Label Tx_clasificacion;
        private ComboBox Cb_clasificacion;
        private Button Btn_cargar;
        private OpenFileDialog openFileDialog1;
        private TableLayoutPanel Tlp_grupoDescripcion;
        private Label Tx_descripcion;
        private RichTextBox Rtxt_descripcion;
        private Label Tx_tab;
        private TableLayoutPanel Tlp_grupoGenero;
        private Label Tx_Genero;
        private Button Btn_agregarGenero;
        private TableLayoutPanel Tlp_dgvGenero;
        private DataGridView Dgv_genero;
        private TableLayoutPanel tableLayoutPanel14;
        private Button Btn_agregarNuevaCartelera;
        private DateTimePicker dateTimePicker1;
        private TextBox Txt_director;
        private TextBox Txt_costo;
        private TextBox Txt_duracion;
        private ComboBox Cb_genero;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewButtonColumn Borrar;
        private TableLayoutPanel Tlp_dgvFormato;
        private DataGridView Dgv_formato;
        private DataGridViewTextBoxColumn Dgvc_nombre;
        private DataGridViewButtonColumn Dgvb_borrar;
        private TableLayoutPanel Tlp_grupoFormato;
        private ComboBox Cb_formato;
        private Label Tx_formato;
        private Button Btn_insertarFormato;
        private TextBox Txt_titulo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button Btn_cambiarImagen;
        private TableLayoutPanel Tlp_id;
        private TextBox Txt_id;
        private Label Tx_id;
    }
}
