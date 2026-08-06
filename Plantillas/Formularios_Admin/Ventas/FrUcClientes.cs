/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */
using System;
using System.Data;
using System.Windows.Forms;
using Con_Admin;

namespace Forms_Admin.Ventas
{
    public partial class FrUcClientes : UserControl
    {
        private readonly If_Clientes api = new If_Clientes();
        private DataTable tablaClientes;

        public FrUcClientes()
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
            CbFiltro.Items.Add("Apellido");
            CbFiltro.Items.Add("Identificación");
            CbFiltro.Items.Add("Correo");
            CbFiltro.SelectedIndex = 1;
        }

        private void CargarGrilla()
        {
            tablaClientes = api.Listar();
            DgvClientes.DataSource = tablaClientes;
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (DgvClientes.Columns.Count == 0) return;

            Encabezado("id_cliente", "ID");
            Encabezado("nombre_cliente", "Nombres");
            Encabezado("apellido_cliente", "Apellidos");
            Encabezado("identificacion_cliente", "Identificación");
            Encabezado("correo_cliente", "Correo");
        }

        private void Encabezado(string columna, string texto)
        {
            if (DgvClientes.Columns.Contains(columna))
                DgvClientes.Columns[columna].HeaderText = texto;
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
            TbNombre.Clear();
            customTextBox2.Clear();   // Apellidos
            TbIdentificacion.Clear();
            customTextBox3.Clear();   // Correo
        }

        private string LeerNombre() => TbNombre.Text.Trim();
        private string LeerApellido() => customTextBox2.Text.Trim();   // Apellidos
        private string LeerIdentificacion() => TbIdentificacion.Text.Trim();
        private string LeerCorreo() => customTextBox3.Text.Trim();   // Correo

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(LeerNombre()))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbNombre.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(LeerApellido()))
            {
                MessageBox.Show("El apellido es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                customTextBox2.Focus();
                return false;
            }
            return true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            try
            {
                int nuevo = api.Insertar(LeerNombre(), LeerApellido(), LeerIdentificacion(), LeerCorreo());
                MessageBox.Show("Cliente agregado correctamente. ID: " + nuevo, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el cliente.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona un cliente de la tabla para actualizar.", "Actualizar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validar()) return;

            try
            {
                bool ok = api.Actualizar(id, LeerNombre(), LeerApellido(), LeerIdentificacion(), LeerCorreo());
                MessageBox.Show(ok ? "Cliente actualizado correctamente." : "No se encontró el cliente.",
                    "Actualizar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el cliente.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona un cliente de la tabla para eliminar.", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Seguro que deseas eliminar al cliente \"" + LeerNombre() + " " + LeerApellido() + "\"?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar != DialogResult.Yes) return;

            try
            {
                bool ok = api.Eliminar(id);
                MessageBox.Show(ok ? "Cliente eliminado." : "No se encontró el cliente.",
                    "Eliminar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("No se puede eliminar: el cliente tiene ventas registradas.",
                    "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el cliente.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (DgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un cliente de la tabla primero.", "Copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarDesdeFila(DgvClientes.CurrentRow);
            ModoEdicion();
        }

        private void CargarDesdeFila(DataGridViewRow fila)
        {
            var enlace = fila.DataBoundItem as DataRowView;
            if (enlace == null) return;

            DataRow row = enlace.Row;
            TbID.Text = row["id_cliente"].ToString();
            TbNombre.Text = row["nombre_cliente"] == DBNull.Value ? "" : row["nombre_cliente"].ToString();
            customTextBox2.Text = row["apellido_cliente"] == DBNull.Value ? "" : row["apellido_cliente"].ToString();
            TbIdentificacion.Text = row["identificacion_cliente"] == DBNull.Value ? "" : row["identificacion_cliente"].ToString();
            customTextBox3.Text = row["correo_cliente"] == DBNull.Value ? "" : row["correo_cliente"].ToString();

            DgvClientes.Focus();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (tablaClientes == null) return;

            string texto = TbFiltro.Text.Trim().Replace("'", "''");
            if (texto.Length == 0)
            {
                tablaClientes.DefaultView.RowFilter = string.Empty;
                return;
            }

            string columna = ColumnaFiltro();
            if (columna == "id_cliente")
                tablaClientes.DefaultView.RowFilter =
                    "Convert(id_cliente, 'System.String') LIKE '%" + texto + "%'";
            else
                tablaClientes.DefaultView.RowFilter = columna + " LIKE '%" + texto + "%'";
        }

        private string ColumnaFiltro()
        {
            string sel = CbFiltro.SelectedItem == null ? "Nombre" : CbFiltro.SelectedItem.ToString();
            switch (sel)
            {
                case "ID": return "id_cliente";
                case "Apellido": return "apellido_cliente";
                case "Identificación": return "identificacion_cliente";
                case "Correo": return "correo_cliente";
                default: return "nombre_cliente";
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
 * fecha de: 05/08/2026 */