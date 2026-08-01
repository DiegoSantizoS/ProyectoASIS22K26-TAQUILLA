/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Con_Admin;

namespace Formularios_Admin
{
    public partial class FrUcPermisos : UserControl
    {
        private readonly If_Permisos api = new If_Permisos();
        private DataTable tablaUsuarios;

        private class OpcionPermiso
        {
            public string Columna { get; }
            public string Nombre { get; }
            public OpcionPermiso(string columna, string nombre)
            {
                Columna = columna;
                Nombre = nombre;
            }
            public override string ToString()
            {
                return Nombre;
            }
        }

        public FrUcPermisos()
        {
            InitializeComponent();
            PrepararInterfaz();
            WireEvents();
            CargarFiltro();
            CargarGrilla();
            ModoInicial();
        }

        private void PrepararInterfaz()
        {
            LbID.Text = "ID Usuario";
            LbNombreUsuario.Text = "Usuario";
            LbTipos.Text = "Tipos";
            LbAccion.Text = "Acciones";
            LbAplicacion.Text = "Aplicaciones";

            TbDirector.ReadOnly = true;

            ListBoxTipos.Items.Clear();
            ListBoxTipos.SelectionMode = SelectionMode.MultiSimple;
            ListBoxTipos.Items.Add(new OpcionPermiso("puede_mantenimiento", "Mantenimiento"));
            ListBoxTipos.Items.Add(new OpcionPermiso("puede_procesos", "Procesos"));
            ListBoxTipos.ClearSelected();

            ListBoxAccion.Items.Clear();
            ListBoxAccion.SelectionMode = SelectionMode.MultiSimple;
            ListBoxAccion.Items.Add(new OpcionPermiso("puede_eliminar", "Eliminar"));
            ListBoxAccion.Items.Add(new OpcionPermiso("puede_registrar", "Registrar"));
            ListBoxAccion.Items.Add(new OpcionPermiso("puede_modificar", "Modificar"));
            ListBoxAccion.ClearSelected();

            ListBoxAplicacion.Items.Clear();
            ListBoxAplicacion.SelectionMode = SelectionMode.MultiSimple;
            ListBoxAplicacion.Items.Add(new OpcionPermiso("APL103", "APL103 — Películas"));
            ListBoxAplicacion.Items.Add(new OpcionPermiso("APL104", "APL104 — Usuarios"));
            ListBoxAplicacion.Items.Add(new OpcionPermiso("APL105", "APL105 — Perfiles"));
            ListBoxAplicacion.Items.Add(new OpcionPermiso("APL106", "APL106 — Permisos"));
            ListBoxAplicacion.Items.Add(new OpcionPermiso("APL107", "APL107 — Géneros"));
            ListBoxAplicacion.Items.Add(new OpcionPermiso("APL108", "APL108 — Salas"));
            ListBoxAplicacion.Items.Add(new OpcionPermiso("APL109", "APL109 — Cines"));
            ListBoxAplicacion.Items.Add(new OpcionPermiso("APL110", "APL110 — Funciones"));
            ListBoxAplicacion.Items.Add(new OpcionPermiso("APL111", "APL111 — Ventas"));
            ListBoxAplicacion.Items.Add(new OpcionPermiso("APL112", "APL112 — Promociones"));
            ListBoxAplicacion.ClearSelected();
        }

        private void WireEvents()
        {
            BtnActualizar.Click += BtnGuardar_Click;
            BtnLimpiar.Click += BtnLimpiar_Click;
            BtnSeleccionar.Click += BtnCopiar_Click;
            BtnBuscar.Click += BtnBuscar_Click;
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
            tablaUsuarios = api.ListarUsuarios();
            DgvUsuarios.DataSource = tablaUsuarios;
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (DgvUsuarios.Columns.Count == 0) return;

            Encabezado("id_usuario", "ID");
            Encabezado("nombre_usuario", "Usuario");
            Encabezado("nombre_perfil", "Perfil");
        }

        private void Encabezado(string columna, string texto)
        {
            if (DgvUsuarios.Columns.Contains(columna))
                DgvUsuarios.Columns[columna].HeaderText = texto;
        }

        private void ModoInicial()
        {
            TbID.Clear();
            TbDirector.Clear();
            ListBoxTipos.ClearSelected();
            ListBoxAccion.ClearSelected();
            ListBoxAplicacion.ClearSelected();
            BtnActualizar.Enabled = false;
            BtnSeleccionar.Enabled = true;
        }

        private void ModoEdicion()
        {
            BtnActualizar.Enabled = true;
            BtnSeleccionar.Enabled = true;
        }

        private void PonerTexto(Componentes.CustomTextBox tb, string valor)
        {
            tb.Focus();
            tb.Text = valor;
            tb.ForeColor = System.Drawing.Color.FromArgb(230, 230, 230);
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (DgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un usuario de la tabla primero.", "Copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var enlace = DgvUsuarios.CurrentRow.DataBoundItem as DataRowView;
            if (enlace == null) return;

            DataRow row = enlace.Row;
            int id = Convert.ToInt32(row["id_usuario"]);

            TbID.Text = id.ToString();
            PonerTexto(TbDirector, row["nombre_usuario"].ToString());

            DataTable permisos = api.ObtenerPermisos(id);
            DataRow permRow = permisos.Rows.Count > 0 ? permisos.Rows[0] : null;

            MarcarSeleccion(ListBoxTipos, permRow);
            MarcarSeleccion(ListBoxAccion, permRow);
            MarcarSeleccion(ListBoxAplicacion, permRow);

            DgvUsuarios.Focus();
            ModoEdicion();
        }

        private void MarcarSeleccion(Krypton.Toolkit.KryptonListBox lista, DataRow permisos)
        {
            lista.ClearSelected();
            if (permisos == null) return;

            for (int i = 0; i < lista.Items.Count; i++)
            {
                var op = lista.Items[i] as OpcionPermiso;
                if (op == null) continue;

                if (permisos.Table.Columns.Contains(op.Columna) &&
                    permisos[op.Columna] != DBNull.Value &&
                    Convert.ToInt32(permisos[op.Columna]) == 1)
                {
                    lista.SetSelected(i, true);
                }
            }
        }

        private void AgregarSeleccion(Krypton.Toolkit.KryptonListBox lista, HashSet<string> activas)
        {
            foreach (var item in lista.SelectedItems)
            {
                var op = item as OpcionPermiso;
                if (op != null)
                    activas.Add(op.Columna);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona un usuario con Copiar antes de guardar.", "Guardar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var activas = new HashSet<string>();
            AgregarSeleccion(ListBoxTipos, activas);
            AgregarSeleccion(ListBoxAccion, activas);
            AgregarSeleccion(ListBoxAplicacion, activas);

            try
            {
                api.Guardar(id, activas);
                MessageBox.Show("Permisos guardados correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                ModoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los permisos.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            ModoInicial();
        }

        private void BtnCopiar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */
