/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la 
 * fecha de: 30/07/2026 */
using System;
using System.Data;
using System.Windows.Forms;
using Con_Admin;

namespace Formularios_Admin
{
    public partial class FrUcUsuarios : UserControl
    {
        private readonly If_Usuarios api = new If_Usuarios();
        private DataTable tablaUsuarios;

        public FrUcUsuarios()
        {
            InitializeComponent();
            TbContra.UseSystemPasswordChar = true;
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
            CbPerfil.DataSource = api.ListarPerfiles();
            CbPerfil.DisplayMember = "Nombre";
            CbPerfil.ValueMember = "Id";
            CbPerfil.SelectedIndex = -1;
        }

        private void CargarFiltro()
        {
            CbFiltro.Items.Clear();
            CbFiltro.Items.Add("ID");
            CbFiltro.Items.Add("Usuario");
            CbFiltro.Items.Add("Perfil");
            CbFiltro.SelectedIndex = 1;
        }

        private void CargarGrilla()
        {
            tablaUsuarios = api.Listar();
            DgvUsuarios.DataSource = tablaUsuarios;
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (DgvUsuarios.Columns.Count == 0) return;

            Ocultar("id_perfil");

            Encabezado("id_usuario", "ID");
            Encabezado("nombre_usuario", "Usuario");
            Encabezado("nombre_perfil", "Perfil");
        }

        private void Ocultar(string columna)
        {
            if (DgvUsuarios.Columns.Contains(columna))
                DgvUsuarios.Columns[columna].Visible = false;
        }

        private void Encabezado(string columna, string texto)
        {
            if (DgvUsuarios.Columns.Contains(columna))
                DgvUsuarios.Columns[columna].HeaderText = texto;
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
            TbNombreUsuario.Clear();
            TbContra.Clear();
            CbPerfil.SelectedIndex = -1;
        }

        private string LeerUsuario()
        {
            return TbNombreUsuario.Text.Trim();
        }

        private string LeerContrasena()
        {
            return TbContra.Text;
        }

        private int? LeerPerfil()
        {
            return IdDe(CbPerfil.SelectedValue);
        }

        private static int? IdDe(object valor)
        {
            if (valor == null || valor is DBNull) return null;
            if (valor is int i) return i;
            return int.TryParse(valor.ToString(), out int r) ? (int?)r : (int?)null;
        }

        private void PonerTexto(Componentes.CustomTextBox tb, string valor)
        {
            tb.Focus();
            tb.Text = valor;
            tb.ForeColor = System.Drawing.Color.FromArgb(230, 230, 230);
        }

        private bool ValidarComun()
        {
            if (string.IsNullOrWhiteSpace(LeerUsuario()))
            {
                MessageBox.Show("El nombre de usuario es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbNombreUsuario.Focus();
                return false;
            }
            if (LeerPerfil() == null)
            {
                MessageBox.Show("Selecciona un perfil.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbPerfil.Focus();
                return false;
            }
            return true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarComun()) return;

            if (string.IsNullOrEmpty(LeerContrasena()))
            {
                MessageBox.Show("La contraseña es obligatoria para un usuario nuevo.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbContra.Focus();
                return;
            }

            try
            {
                int nuevo = api.Insertar(LeerPerfil().Value, LeerUsuario(), LeerContrasena());
                MessageBox.Show("Usuario agregado correctamente. ID: " + nuevo, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                ModoAgregar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Ya existe un usuario con ese nombre.", "Agregar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el usuario.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona un usuario de la tabla para actualizar.", "Actualizar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidarComun()) return;

            try
            {
                bool ok = api.Actualizar(id, LeerPerfil().Value, LeerUsuario(), LeerContrasena());
                MessageBox.Show(ok ? "Usuario actualizado correctamente." : "No se encontró el usuario.",
                    "Actualizar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Ya existe un usuario con ese nombre.", "Actualizar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el usuario.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona un usuario de la tabla para eliminar.", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Seguro que deseas eliminar el usuario \"" + TbNombreUsuario.Text.Trim() + "\"?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar != DialogResult.Yes) return;

            try
            {
                bool ok = api.Eliminar(id);
                MessageBox.Show(ok ? "Usuario eliminado." : "No se encontró el usuario.",
                    "Eliminar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("No se puede eliminar: el usuario tiene registros asociados.",
                    "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el usuario.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (DgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un usuario de la tabla primero.", "Copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarDesdeFila(DgvUsuarios.CurrentRow);
            ModoEdicion();
        }

        private void CargarDesdeFila(DataGridViewRow fila)
        {
            var enlace = fila.DataBoundItem as DataRowView;
            if (enlace == null) return;

            DataRow row = enlace.Row;

            TbID.Text = row["id_usuario"].ToString();
            PonerTexto(TbNombreUsuario, row["nombre_usuario"].ToString());
            TbContra.Clear();
            CbPerfil.SelectedValue = row["id_perfil"] == DBNull.Value ? -1 : row["id_perfil"];

            DgvUsuarios.Focus();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (tablaUsuarios == null) return;

            string texto = TbFiltro.Text.Trim().Replace("'", "''");
            if (texto.Length == 0)
            {
                tablaUsuarios.DefaultView.RowFilter = string.Empty;
                return;
            }

            string columna = ColumnaFiltro();
            if (columna == "id_usuario")
                tablaUsuarios.DefaultView.RowFilter =
                    "Convert(id_usuario, 'System.String') LIKE '%" + texto + "%'";
            else
                tablaUsuarios.DefaultView.RowFilter = columna + " LIKE '%" + texto + "%'";
        }

        private string ColumnaFiltro()
        {
            string sel = CbFiltro.SelectedItem == null ? "Usuario" : CbFiltro.SelectedItem.ToString();
            switch (sel)
            {
                case "ID": return "id_usuario";
                case "Perfil": return "nombre_perfil";
                default: return "nombre_usuario";
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
