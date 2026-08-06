/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Con_Admin;
using CartelerasImg = Plantillas.Carteleras.Carteleras;

namespace Forms_Admin.Funciones
{
    public partial class FrUcCartelera : UserControl
    {
        private readonly If_Peliculas api = new If_Peliculas();
        private DataTable tablaPeliculas;
        private string rutaImagenSeleccionada = "";

        public FrUcCartelera()
        {
            InitializeComponent();
            WireEvents();
            CargarFiltro();
            CargarGrilla();
            LimpiarFormulario();
            if(DgvPeliculas.Rows[0]!=null) CargarDesdeFila(DgvPeliculas.Rows[0]);
        }

        private void WireEvents()
        {
            FilePicker.Click += FilePicker_Click;
            BtnActualizar.Click += BtnGuardar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            BtnLimpiar.Click += BtnLimpiar_Click;
            BtnBuscar.Click += BtnBuscar_Click;
            DgvPeliculas.CellClick += DgvPeliculas_CellClick;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CargarFiltro()
        {
            CbFiltro.Items.Clear();
            CbFiltro.Items.Add("ID");
            CbFiltro.Items.Add("Título");
            CbFiltro.Items.Add("Director");
            CbFiltro.Items.Add("Clasificación");
            CbFiltro.Items.Add("Estado");
            CbFiltro.SelectedIndex = 1;
        }

        private void CargarGrilla()
        {
            tablaPeliculas = api.Listar();
            DgvPeliculas.DataSource = tablaPeliculas;
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (DgvPeliculas.Columns.Count == 0) return;

            Ocultar("id_clasificacion");
            Ocultar("id_estado_pelicula");
            Ocultar("trailer_pelicula");
            Ocultar("descripcion_pelicula");
            Ocultar("duracion_pelicula");
            Ocultar("fecha_estreno");

            Encabezado("id_pelicula", "ID");
            Encabezado("titulo_pelicula", "Título");
            Encabezado("nombre_clasificacion", "Clasificación");
            Encabezado("nombre_estado_pelicula", "Estado");
            Encabezado("director_pelicula", "Director");
        }

        private void Ocultar(string columna)
        {
            if (DgvPeliculas.Columns.Contains(columna))
                DgvPeliculas.Columns[columna].Visible = false;
        }

        private void Encabezado(string columna, string texto)
        {
            if (DgvPeliculas.Columns.Contains(columna))
                DgvPeliculas.Columns[columna].HeaderText = texto;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (tablaPeliculas == null) return;

            string texto = TbFiltro.Text.Trim().Replace("'", "''");
            if (texto.Length == 0)
            {
                tablaPeliculas.DefaultView.RowFilter = string.Empty;
                return;
            }

            string columna = ColumnaFiltro();
            tablaPeliculas.DefaultView.RowFilter = columna == "id_pelicula"
                ? "Convert(id_pelicula, 'System.String') LIKE '%" + texto + "%'"
                : columna + " LIKE '%" + texto + "%'";
        }

        private string ColumnaFiltro()
        {
            string sel = CbFiltro.SelectedItem == null ? "Título" : CbFiltro.SelectedItem.ToString();
            switch (sel)
            {
                case "ID": return "id_pelicula";
                case "Director": return "director_pelicula";
                case "Clasificación": return "nombre_clasificacion";
                case "Estado": return "nombre_estado_pelicula";
                default: return "titulo_pelicula";
            }
        }

        private void DgvPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            CargarDesdeFila(DgvPeliculas.Rows[e.RowIndex]);
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (DgvPeliculas.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una película de la tabla primero.", "Cartelera",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CargarDesdeFila(DgvPeliculas.CurrentRow);
        }

        private void CargarDesdeFila(DataGridViewRow fila)
        {
            var drv = fila.DataBoundItem as DataRowView;
            if (drv == null) return;

            int id = Convert.ToInt32(drv.Row["id_pelicula"]);
            customidTextBox1.Text = id.ToString();

            rutaImagenSeleccionada = "";
            FilePicker.Text = "Seleccione una imagen";

            string ruta = new CartelerasImg(id).obtenerUrl();
            if (File.Exists(ruta)) MostrarImagen(ruta);
            else LiberarImagen();
        }

        private void FilePicker_Click(object sender, EventArgs e)
        {
            if (!TryLeerId(out _))
            {
                MessageBox.Show("Selecciona primero una película de la tabla.", "Cartelera",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecciona la imagen de la cartelera";
                ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png|Todos los archivos|*.*";

                if (ofd.ShowDialog() != DialogResult.OK) return;

                string ext = Path.GetExtension(ofd.FileName).ToLowerInvariant();
                if (ext != ".jpg" && ext != ".jpeg" && ext != ".png")
                {
                    MessageBox.Show("Solo se permiten imágenes .jpg o .png.", "Cartelera",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                rutaImagenSeleccionada = ofd.FileName;
                FilePicker.Text = Path.GetFileName(ofd.FileName);
                MostrarImagen(ofd.FileName);
            }
        }

        private void MostrarImagen(string ruta)
        {
            LiberarImagen();
            byte[] bytes = File.ReadAllBytes(ruta);
            using (var ms = new MemoryStream(bytes))
            using (var tmp = Image.FromStream(ms))
                pictureBox1.Image = new Bitmap(tmp);
        }

        private void LiberarImagen()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!TryLeerId(out int id))
            {
                MessageBox.Show("Selecciona una película de la tabla.", "Cartelera",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(rutaImagenSeleccionada) || !File.Exists(rutaImagenSeleccionada))
            {
                MessageBox.Show("Selecciona una imagen con el botón \"Seleccione una imagen\".",
                    "Cartelera", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string destino = new CartelerasImg(id).Guardar(rutaImagenSeleccionada);
                MostrarImagen(destino);
                MessageBox.Show("Imagen guardada como " + Path.GetFileName(destino) + ".",
                    "Cartelera", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar la imagen.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!TryLeerId(out int id))
            {
                MessageBox.Show("Selecciona una película de la tabla.", "Cartelera",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cartelera = new CartelerasImg(id);
            if (!cartelera.TieneImagen())
            {
                MessageBox.Show("Esta película no tiene imagen guardada.", "Cartelera",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show("¿Eliminar la imagen de esta película?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar != DialogResult.Yes) return;

            try
            {
                LiberarImagen();
                cartelera.Eliminar();

                string ruta = new CartelerasImg(id).obtenerUrl();
                if (File.Exists(ruta)) MostrarImagen(ruta);

                MessageBox.Show("Imagen eliminada.", "Cartelera",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la imagen.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbFiltro.Clear();
            CargarGrilla();
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            customidTextBox1.Clear();
            rutaImagenSeleccionada = "";
            FilePicker.Text = "Seleccione una imagen";
            LiberarImagen();
        }

        private bool TryLeerId(out int id)
        {
            return int.TryParse(customidTextBox1.Text.Trim(), out id) && id > 0;
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */