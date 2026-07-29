using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using clase_conexion;

namespace Plantilla_Admin
{
    public partial class FrUcMantenimientoCartelera : UserControl
    {
        private DataTable dtGeneros;
        private DataTable dtFormato;
        private int idPelicula;
        public FrUcMantenimientoCartelera()
        {
            InitializeComponent();
            pictureBox2.Image = Properties.Resources.EjemploCartelera;
            conexion conexion = new conexion();
            Cb_genero.DropDownStyle = ComboBoxStyle.DropDownList;
            dtGeneros = conexion.mostrarGeneros();
            Cb_genero.DataSource = null;
            Cb_genero.DisplayMember = "";
            Cb_genero.ValueMember = "";
            Cb_genero.DataSource = dtGeneros;
            Cb_genero.ValueMember = "id_genero";
            Cb_genero.DisplayMember = "nombre_genero";

            Cb_formato.DropDownStyle = ComboBoxStyle.DropDownList;
            dtFormato = conexion.mostrarTipoPelicula();
            Cb_formato.DisplayMember = "";
            Cb_formato.ValueMember = "";
            Cb_formato.DataSource = dtFormato;
            Cb_formato.ValueMember = "id_tipo_pelicula";
            Cb_formato.DisplayMember = "nombre_tipo_pelicula";

            ConfigurarGrid();
            Txt_id.Text = conexion.siguienteIdPelicula().ToString();
            idPelicula = 0;
        }

        public FrUcMantenimientoCartelera(int id)
        {
            InitializeComponent();
            pictureBox2.Image = Properties.Resources.EjemploCartelera;
            conexion conexion = new conexion();
            Cb_genero.DropDownStyle = ComboBoxStyle.DropDownList;
            dtGeneros = conexion.mostrarGeneros();
            Cb_genero.DataSource = null;
            Cb_genero.DisplayMember = "";
            Cb_genero.ValueMember = "";
            Cb_genero.DataSource = dtGeneros;
            Cb_genero.ValueMember = "id_genero";
            Cb_genero.DisplayMember = "nombre_genero";

            Cb_formato.DropDownStyle = ComboBoxStyle.DropDownList;
            dtFormato = conexion.mostrarTipoPelicula();
            Cb_formato.DisplayMember = "";
            Cb_formato.ValueMember = "";
            Cb_formato.DataSource = dtFormato;
            Cb_formato.ValueMember = "id_tipo_pelicula";
            Cb_formato.DisplayMember = "nombre_tipo_pelicula";

            ConfigurarGrid();
            Txt_id.Text = conexion.siguienteIdPelicula().ToString();

            idPelicula = id;
            if (idPelicula > 0)
            {
                Txt_id.Text = idPelicula.ToString();
                CargarPelicula(idPelicula);
                Btn_agregarNuevaCartelera.Text = "ACTUALIZAR";
            }
            else
            {
                Txt_id.Text = conexion.siguienteIdPelicula().ToString();
                Btn_agregarNuevaCartelera.Text = "AGREGAR";
            }
        }

        private void CargarPelicula(int id)
        {
            conexion conexion = new conexion();
            DataTable dt = conexion.obtenerPelicula(id);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró la película con id " + id);
                return;
            }

            DataRow fila = dt.Rows[0];

            Txt_id.Text = fila["id_pelicula"].ToString();
            Txt_titulo.Text = fila["titulo_pelicula"].ToString();
            Txt_duracion.Text = fila["duracion_pelicula"].ToString();
            Txt_director.Text = fila["director_pelicula"].ToString();
            Txt_trailer.Text = fila["trailer_pelicula"].ToString();

            Cb_genero.SelectedValue = fila["id_genero"];
            Cb_formato.SelectedValue = fila["id_tipo_pelicula"];

            Cb_estado.Text = fila["estado_pelicula"].ToString();
            Cb_clasificacion.Text = fila["clasificacion_pelicula"].ToString();

            if (fila["fecha_estreno"] != DBNull.Value)
                dateTimePicker1.Value = Convert.ToDateTime(fila["fecha_estreno"]);
        }

        private void LimpiarFormulario()
        {
            Txt_titulo.Clear();
            Txt_duracion.Clear();
            Txt_director.Clear();
            Txt_trailer.Clear();
            Txt_costo.Clear();
            //Txt_descripcion.Clear();

            if (Cb_estado.Items.Count > 0) Cb_estado.SelectedIndex = 0;
            if (Cb_clasificacion.Items.Count > 0) Cb_clasificacion.SelectedIndex = 0;
            if (Cb_genero.Items.Count > 0) Cb_genero.SelectedIndex = 0;
            if (Cb_formato.Items.Count > 0) Cb_formato.SelectedIndex = 0;

            dateTimePicker1.Value = DateTime.Today;

            conexion conexion = new conexion();
            Txt_id.Text = conexion.siguienteIdPelicula().ToString();

            Txt_titulo.Focus();
        }

        private void ConfigurarGrid()
        {
            Dgv_genero.AutoGenerateColumns = false;
            Dgv_genero.Columns.Clear();
            Dgv_genero.Rows.Clear();

            var colId = new DataGridViewTextBoxColumn();
            colId.Name = "id_genero";
            colId.HeaderText = "Id";
            colId.Visible = false;
            Dgv_genero.Columns.Add(colId);

            var colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "nombre_genero";
            colNombre.HeaderText = "Género";
            Dgv_genero.Columns.Add(colNombre);

            var colBtn = new DataGridViewButtonColumn();
            colBtn.Name = "eliminar";
            colBtn.HeaderText = "";
            colBtn.Text = "Quitar";
            colBtn.UseColumnTextForButtonValue = true;
            Dgv_genero.Columns.Add(colBtn);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string input = Txt_trailer.Text.Trim();

            input = input.Split("v=")[1].Split("&")[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.LoadAsync($"https://img.youtube.com/vi/{input}/hqdefault.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string input = Txt_trailer.Text.Trim();

            input = input.Split("v=")[1].Split("&")[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=" + input,
                UseShellExecute = true
            });
        }

        private void Btn_cambiarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog upload = new OpenFileDialog())
            {
                upload.Filter = "Imágenes |*.png;*.jpg;*.jpeg";
                upload.Title = "Selecciona una imagen";
                upload.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (upload.ShowDialog() != DialogResult.OK)
                    return;
                string filePath = upload.FileName;
                pictureBox2.Image = Image.FromFile(filePath);
            }
        }

        private void Btn_agregarGenero_Click(object sender, EventArgs e)
        {
            if (Cb_genero.SelectedValue == null || dtGeneros.Rows.Count == 0)
                return;

            int idGenero = Convert.ToInt32(Cb_genero.SelectedValue);
            string nombreGenero = Cb_genero.Text;

            Dgv_genero.Rows.Add(idGenero, nombreGenero);

            foreach (DataRow row in dtGeneros.Rows)
            {
                if (Convert.ToInt32(row["id_genero"]) == idGenero)
                {
                    dtGeneros.Rows.Remove(row);
                    break;
                }
            }
        }

        private void Dgv_genero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (Dgv_genero.Columns[e.ColumnIndex].Name != "eliminar") return;

            DataGridViewRow fila = Dgv_genero.Rows[e.RowIndex];

            int idGenero = Convert.ToInt32(fila.Cells["id_genero"].Value);
            string nombreGenero = fila.Cells["nombre_genero"].Value.ToString();

            DataRow nueva = dtGeneros.NewRow();
            nueva["id_genero"] = idGenero;
            nueva["nombre_genero"] = nombreGenero;
            dtGeneros.Rows.Add(nueva);

            Dgv_genero.Rows.RemoveAt(e.RowIndex);
        }

        private void Btn_agregarNuevaCartelera_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_titulo.Text))
            {
                MessageBox.Show("El título es obligatorio.");
                return;
            }

            int duracion;
            if (!int.TryParse(Txt_duracion.Text.Trim(), out duracion) || duracion <= 0)
            {
                MessageBox.Show("La duración debe ser un número válido.");
                return;
            }

            if (Cb_genero.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un género.");
                return;
            }

            if (Cb_formato.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un formato.");
                return;
            }

            int idGenero = Convert.ToInt32(Cb_genero.SelectedValue);
            int idTipoPelicula = Convert.ToInt32(Cb_formato.SelectedValue);

            string titulo = Txt_titulo.Text.Trim();
            string clasificacion = Cb_clasificacion.Text;
            string director = Txt_director.Text.Trim();
            string trailer = Txt_trailer.Text.Trim();
            string estado = Cb_estado.Text.Trim().ToLower();  
            DateTime fecha = dateTimePicker1.Value;

            try
            {
                conexion conexion = new conexion();

                if (idPelicula > 0)
                {
                    conexion.actualizarPelicula(
                        idPelicula, titulo, duracion, clasificacion, idGenero,
                        idTipoPelicula, director, trailer, estado, fecha);
                    MessageBox.Show("Película actualizada.");
                }
                else
                {
                    int nuevoId = conexion.insertarPelicula(
                        titulo, duracion, clasificacion, idGenero,
                        idTipoPelicula, director, trailer, estado, fecha);
                    MessageBox.Show("Película agregada con id " + nuevoId);
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
