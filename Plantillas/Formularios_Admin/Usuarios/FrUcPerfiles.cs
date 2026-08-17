<<<<<<< HEAD
﻿/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */
=======
﻿// Diego santizo
//Mishel Loeiza
>>>>>>> main
using System;
using System.Data;
using System.Windows.Forms;
using Con_Admin;

namespace Formularios_Admin
{
    public partial class FrUcPerfiles : UserControl
    {
        private readonly If_Perfiles api = new If_Perfiles();
        private DataTable tablaPerfiles;

        public FrUcPerfiles()
        {
            InitializeComponent();
            WireEvents();
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

        private void CargarFiltro()
        {
            CbFiltro.Items.Clear();
            CbFiltro.Items.Add("ID");
            CbFiltro.Items.Add("Nombre");
            CbFiltro.SelectedIndex = 1;
        }

        private void CargarGrilla()
        {
            tablaPerfiles = api.Listar();
            DgvPerfiles.DataSource = tablaPerfiles;
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (DgvPerfiles.Columns.Count == 0) return;

            Encabezado("id_perfil", "ID");
            Encabezado("nombre_perfil", "Nombre");
        }

        private void Encabezado(string columna, string texto)
        {
            if (DgvPerfiles.Columns.Contains(columna))
                DgvPerfiles.Columns[columna].HeaderText = texto;
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
            TbDirector.Clear();
        }

        private string LeerNombre()
        {
            return TbDirector.Text.Trim();
        }

        private void PonerTexto(Componentes.CustomTextBox tb, string valor)
        {
            tb.Focus();
            tb.Text = valor;
            tb.ForeColor = System.Drawing.Color.FromArgb(230, 230, 230);
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(LeerNombre()))
            {
                MessageBox.Show("El nombre del perfil es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbDirector.Focus();
                return false;
            }
            return true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            try
            {
                int nuevo = api.Insertar(LeerNombre());
                MessageBox.Show("Perfil agregado correctamente. ID: " + nuevo, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                ModoAgregar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Ya existe un perfil con ese nombre.", "Agregar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el perfil.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona un perfil de la tabla para actualizar.", "Actualizar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validar()) return;

            try
            {
                bool ok = api.Actualizar(id, LeerNombre());
                MessageBox.Show(ok ? "Perfil actualizado correctamente." : "No se encontró el perfil.",
                    "Actualizar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Ya existe un perfil con ese nombre.", "Actualizar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el perfil.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona un perfil de la tabla para eliminar.", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Seguro que deseas eliminar el perfil \"" + TbDirector.Text.Trim() + "\"?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar != DialogResult.Yes) return;

            try
            {
                bool ok = api.Eliminar(id);
                MessageBox.Show(ok ? "Perfil eliminado." : "No se encontró el perfil.",
                    "Eliminar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("No se puede eliminar: el perfil está asignado a uno o más usuarios.",
                    "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el perfil.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (DgvPerfiles.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un perfil de la tabla primero.", "Copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarDesdeFila(DgvPerfiles.CurrentRow);
            ModoEdicion();
        }

        private void CargarDesdeFila(DataGridViewRow fila)
        {
            var enlace = fila.DataBoundItem as DataRowView;
            if (enlace == null) return;

            DataRow row = enlace.Row;

            TbID.Text = row["id_perfil"].ToString();
            PonerTexto(TbDirector, row["nombre_perfil"].ToString());

            DgvPerfiles.Focus();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (tablaPerfiles == null) return;

            string texto = TbFiltro.Text.Trim().Replace("'", "''");
            if (texto.Length == 0)
            {
                tablaPerfiles.DefaultView.RowFilter = string.Empty;
                return;
            }

            string columna = ColumnaFiltro();
            if (columna == "id_perfil")
                tablaPerfiles.DefaultView.RowFilter =
                    "Convert(id_perfil, 'System.String') LIKE '%" + texto + "%'";
            else
                tablaPerfiles.DefaultView.RowFilter = columna + " LIKE '%" + texto + "%'";
        }

        private string ColumnaFiltro()
        {
            string sel = CbFiltro.SelectedItem == null ? "Nombre" : CbFiltro.SelectedItem.ToString();
            switch (sel)
            {
                case "ID": return "id_perfil";
                default: return "nombre_perfil";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbFiltro.Clear();
            CargarGrilla();
            ModoAgregar();
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la 
 * fecha de: 30/07/2026 */
