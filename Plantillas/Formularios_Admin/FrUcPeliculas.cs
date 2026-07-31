/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */
using System;
using System.Data;
using System.Windows.Forms;
using Con_Admin;

namespace Formularios_Admin
{
    public partial class FrUcPeliculas : UserControl
    {
        private readonly If_Peliculas api = new If_Peliculas();
        private DataTable tablaPeliculas;

        public FrUcPeliculas()
        {
            InitializeComponent();
            WireEvents();
            CargarCombos();
            CargarFiltro();
            CargarGrilla();
            ModoAgregar();
        }

        private void WireEvents()
        {
            BtnAgregar.Click += BtnAgregar_Click;
            BtnActualizar.Click += BtnActualizar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            BtnLimpiar.Click += BtnLimpiar_Click;
            BtnCopiar.Click += BtnCopiar_Click;
            BtnBuscar.Click += BtnBuscar_Click;
        }

        private void CargarCombos()
        {
            CbClasificacion.DataSource = api.ListarClasificaciones();
            CbClasificacion.DisplayMember = "Nombre";
            CbClasificacion.ValueMember = "Id";
            CbClasificacion.SelectedIndex = -1;

            CbEstado.DataSource = api.ListarEstados();
            CbEstado.DisplayMember = "Nombre";
            CbEstado.ValueMember = "Id";
            CbEstado.SelectedIndex = -1;

            ListBoxGeneros.Items.Clear();
            ListBoxGeneros.DataSource = api.ListarGeneros();
            ListBoxGeneros.DisplayMember = "Nombre";
            ListBoxGeneros.ValueMember = "Id";
            ListBoxGeneros.ClearSelected();

            ListBoxFormatos.Items.Clear();
            ListBoxFormatos.DataSource = api.ListarTiposPelicula();
            ListBoxFormatos.DisplayMember = "Nombre";
            ListBoxFormatos.ValueMember = "Id";
            ListBoxFormatos.ClearSelected();
        }

        private void CargarFiltro()
        {
            CbFiltro.Items.Clear();
            CbFiltro.Items.Add("ID");
            CbFiltro.Items.Add("Título");
            CbFiltro.Items.Add("Director");
            CbFiltro.Items.Add("Género");
            CbFiltro.Items.Add("Formato");
            CbFiltro.Items.Add("Clasificación");
            CbFiltro.Items.Add("Estado");
            CbFiltro.SelectedIndex = 1;
        }

        private void CargarGrilla()
        {
            tablaPeliculas = api.Listar();
            DgvPelicula.DataSource = tablaPeliculas;
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (DgvPelicula.Columns.Count == 0) return;

            Ocultar("id_clasificacion");
            Ocultar("id_genero");
            Ocultar("id_tipo_pelicula");
            Ocultar("imagen_pelicula");
            Ocultar("trailer_pelicula");

            Encabezado("id_pelicula", "ID");
            Encabezado("titulo_pelicula", "Título");
            Encabezado("duracion_pelicula", "Duración");
            Encabezado("nombre_clasificacion", "Clasificación");
            Encabezado("nombre_genero", "Género");
            Encabezado("nombre_tipo_pelicula", "Formato");
            Encabezado("director_pelicula", "Director");
            Encabezado("estado_pelicula", "Estado");
            Encabezado("fecha_estreno", "Estreno");
        }

        private void Ocultar(string columna)
        {
            if (DgvPelicula.Columns.Contains(columna))
                DgvPelicula.Columns[columna].Visible = false;
        }

        private void Encabezado(string columna, string texto)
        {
            if (DgvPelicula.Columns.Contains(columna))
                DgvPelicula.Columns[columna].HeaderText = texto;
        }

        private void ModoAgregar()
        {
            LimpiarCampos();
            TbID.Text = api.ObtenerSiguienteId().ToString();
            BtnAgregar.Enabled = true;
            BtnCopiar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ModoEdicion()
        {
            BtnAgregar.Enabled = false;
            BtnCopiar.Enabled = true;
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void LimpiarCampos()
        {
            TbID.Clear();
            TbTitulo.Clear();
            TbDuracion.Clear();
            TbDirector.Clear();
            TbTrailer.Clear();
            TbDescripcion.Clear();
            CbClasificacion.SelectedIndex = -1;
            CbEstado.SelectedIndex = -1;
            ListBoxGeneros.ClearSelected();
            ListBoxFormatos.ClearSelected();
            DatePickerEstreno.Value = DateTime.Today;
        }

        private string LeerTitulo()
        {
            return TbTitulo.Text.Trim();
        }

        private int LeerDuracion()
        {
            return int.TryParse(TbDuracion.Text.Trim(), out int d) ? d : 0;
        }

        private int? LeerClasificacion()
        {
            return IdDe(CbClasificacion.SelectedValue);
        }

        private void PonerTexto(Componentes.CustomTextBox tb, string valor)
        {
            tb.Focus();
            tb.Text = valor;
            tb.ForeColor = System.Drawing.Color.FromArgb(230, 230, 230);
        }

        private void SeleccionarEnLista(Krypton.Toolkit.KryptonListBox lista, object idValor)
        {
            lista.ClearSelected();
            if (idValor == null || idValor == DBNull.Value) return;

            int objetivo = Convert.ToInt32(idValor);
            for (int i = 0; i < lista.Items.Count; i++)
            {
                var drv = lista.Items[i] as DataRowView;
                if (drv == null) continue;
                if (drv["Id"] != DBNull.Value && Convert.ToInt32(drv["Id"]) == objetivo)
                {
                    lista.SetSelected(i, true);
                    break;
                }
            }
        }

        private int? LeerIdLista(Krypton.Toolkit.KryptonListBox lista)
        {
            if (lista.SelectedItems.Count > 0)
            {
                var drv = lista.SelectedItems[0] as DataRowView;
                if (drv != null && drv["Id"] != DBNull.Value)
                    return Convert.ToInt32(drv["Id"]);
            }
            return IdDe(lista.SelectedValue);
        }

        private int? LeerGenero()
        {
            return LeerIdLista(ListBoxGeneros);
        }

        private int? LeerTipo()
        {
            return LeerIdLista(ListBoxFormatos);
        }

        private string LeerEstado()
        {
            return CbEstado.SelectedValue == null ? null : CbEstado.SelectedValue.ToString();
        }

        private DateTime LeerEstreno()
        {
            return DatePickerEstreno.Value.Date;
        }

        private static int? IdDe(object valor)
        {
            if (valor == null || valor is DBNull) return null;
            if (valor is int i) return i;
            return int.TryParse(valor.ToString(), out int r) ? (int?)r : (int?)null;
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(LeerTitulo()))
            {
                MessageBox.Show("El título es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbTitulo.Focus();
                return false;
            }
            if (LeerDuracion() <= 0)
            {
                MessageBox.Show("La duración debe ser un número mayor que cero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbDuracion.Focus();
                return false;
            }
            return true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            try
            {
                int nuevo = api.Insertar(LeerTitulo(), LeerDuracion(), LeerClasificacion(), LeerGenero(),
                    LeerTipo(), TbDirector.Text.Trim(), TbTrailer.Text.Trim(), null,
                    LeerEstado(), LeerEstreno());

                MessageBox.Show("Película agregada correctamente. ID: " + nuevo, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la película.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona una película de la tabla para actualizar.", "Actualizar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validar()) return;

            try
            {
                bool ok = api.Actualizar(id, LeerTitulo(), LeerDuracion(), LeerClasificacion(), LeerGenero(),
                    LeerTipo(), TbDirector.Text.Trim(), TbTrailer.Text.Trim(), null,
                    LeerEstado(), LeerEstreno());

                MessageBox.Show(ok ? "Película actualizada correctamente." : "No se encontró la película.",
                    "Actualizar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la película.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona una película de la tabla para eliminar.", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Seguro que deseas eliminar la película \"" + TbTitulo.Text.Trim() + "\"?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar != DialogResult.Yes) return;

            try
            {
                bool ok = api.Eliminar(id);
                MessageBox.Show(ok ? "Película eliminada." : "No se encontró la película.",
                    "Eliminar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("No se puede eliminar: la película tiene funciones programadas.",
                    "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la película.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (DgvPelicula.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una película de la tabla primero.", "Copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarDesdeFila(DgvPelicula.CurrentRow);
            ModoEdicion();
        }

        private void CargarDesdeFila(DataGridViewRow fila)
        {
            var enlace = fila.DataBoundItem as DataRowView;
            if (enlace == null) return;

            DataRow row = enlace.Row;

            TbID.Text = row["id_pelicula"].ToString();
            PonerTexto(TbTitulo, row["titulo_pelicula"].ToString());
            PonerTexto(TbDuracion, row["duracion_pelicula"].ToString());
            PonerTexto(TbDirector, row["director_pelicula"] == DBNull.Value ? "" : row["director_pelicula"].ToString());
            PonerTexto(TbTrailer, row["trailer_pelicula"] == DBNull.Value ? "" : row["trailer_pelicula"].ToString());

            CbClasificacion.SelectedValue = row["id_clasificacion"] == DBNull.Value ? -1 : row["id_clasificacion"];
            CbEstado.SelectedValue = row["estado_pelicula"] == DBNull.Value ? "" : row["estado_pelicula"].ToString();
            SeleccionarEnLista(ListBoxGeneros, row["id_genero"]);
            SeleccionarEnLista(ListBoxFormatos, row["id_tipo_pelicula"]);

            DatePickerEstreno.Value = row["fecha_estreno"] == DBNull.Value
                ? DateTime.Today
                : Convert.ToDateTime(row["fecha_estreno"]);

            DgvPelicula.Focus();
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
            if (columna == "id_pelicula")
                tablaPeliculas.DefaultView.RowFilter =
                    "Convert(id_pelicula, 'System.String') LIKE '%" + texto + "%'";
            else
                tablaPeliculas.DefaultView.RowFilter = columna + " LIKE '%" + texto + "%'";
        }

        private string ColumnaFiltro()
        {
            string sel = CbFiltro.SelectedItem == null ? "Título" : CbFiltro.SelectedItem.ToString();
            switch (sel)
            {
                case "ID": return "id_pelicula";
                case "Director": return "director_pelicula";
                case "Género": return "nombre_genero";
                case "Formato": return "nombre_tipo_pelicula";
                case "Clasificación": return "nombre_clasificacion";
                case "Estado": return "estado_pelicula";
                default: return "titulo_pelicula";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbFiltro.Clear();
            CargarGrilla();
            ModoAgregar();
        }

        private void kryptonListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */
