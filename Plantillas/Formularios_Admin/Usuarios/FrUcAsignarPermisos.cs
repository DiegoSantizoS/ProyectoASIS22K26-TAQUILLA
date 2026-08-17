<<<<<<< HEAD
﻿/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */
=======
/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 05/08/2026 */

>>>>>>> main
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Con_Admin;

namespace Formularios_Admin
{
    public partial class FrUcAsignarPermisos : UserControl
    {
<<<<<<< HEAD
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
=======
        private readonly If_AsignarPermisos api =
            new If_AsignarPermisos();

        private bool cargando;
>>>>>>> main

        public FrUcAsignarPermisos()
        {
            InitializeComponent();
<<<<<<< HEAD
            PrepararInterfaz();
            WireEvents();
            CargarFiltro();
            CargarGrilla();
            ModoInicial();
        }

        private void PrepararInterfaz()
        {
            LbPerfil.Text = "Usuario";
            LbAplicacion.Text = "Aplicaciones";

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
=======
            WireEvents();
            CargarPerfiles();
            LimpiarListas();
>>>>>>> main
        }

        private void WireEvents()
        {
<<<<<<< HEAD
            BtnLimpiar.Click += BtnLimpiar_Click;
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
            DgvAsignarPermisos.DataSource = tablaUsuarios;
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (DgvAsignarPermisos.Columns.Count == 0) return;

            Encabezado("id_usuario", "ID");
            Encabezado("nombre_usuario", "Usuario");
            Encabezado("nombre_perfil", "Perfil");
        }

        private void Encabezado(string columna, string texto)
        {
            if (DgvAsignarPermisos.Columns.Contains(columna))
                DgvAsignarPermisos.Columns[columna].HeaderText = texto;
        }

        private void ModoInicial()
        {
            ListBoxAplicacion.ClearSelected();
        }

        private void ModoEdicion()
        {
        }

        private void PonerTexto(Componentes.CustomTextBox tb, string valor)
        {
            tb.Focus();
            tb.Text = valor;
            tb.ForeColor = System.Drawing.Color.FromArgb(230, 230, 230);
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
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
=======
            CbPerfil.SelectedIndexChanged +=
                CbPerfil_SelectedIndexChanged;

            BtnActualizar.Click +=
                BtnActualizar_Click;
        }

        private void CargarPerfiles()
        {
            cargando = true;

            CbPerfil.DataSource =
                api.ListarPerfiles();

            CbPerfil.DisplayMember =
                "Nombre";

            CbPerfil.ValueMember =
                "Id";

            CbPerfil.SelectedIndex = -1;

            cargando = false;
        }

        private void CbPerfil_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cargando)
                return;

            int? idPerfil =
                IdDe(CbPerfil.SelectedValue);

            if (idPerfil == null)
            {
                LimpiarListas();
                return;
            }

            CargarPermisos(idPerfil.Value);
        }

        private void CargarPermisos(
            int idPerfil)
        {
            try
            {
                cargando = true;

                DataTable tabla =
                    api.ListarPermisosPerfil(
                        idPerfil
                    );

                CargarLista(
                    ListBoxMant,
                    tabla.Copy(),
                    "Mantenimiento"
                );

                CargarLista(
                    ListBoxRegistrar,
                    tabla.Copy(),
                    "Registrar"
                );

                CargarLista(
                    ListBoxEliminar,
                    tabla.Copy(),
                    "Eliminar"
                );

                CargarLista(
                    ListBoxActualizar,
                    tabla.Copy(),
                    "Modificar"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los permisos.\n\n"
                    + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                cargando = false;
            }
        }

        private void CargarLista(
            Componentes.CustomListBox lista,
            DataTable tabla,
            string columnaPermiso)
        {
            lista.DataSource = null;

            lista.DisplayMember = "Nombre";
            lista.ValueMember = "Id";
            lista.DataSource = tabla;

            lista.ClearSelected();

            for (int i = 0;
                 i < tabla.Rows.Count;
                 i++)
            {
                bool seleccionado =
                    Convert.ToBoolean(
                        tabla.Rows[i][columnaPermiso]
                    );

                if (seleccionado)
                {
                    lista.SetSelected(
                        i,
                        true
                    );
>>>>>>> main
                }
            }
        }

<<<<<<< HEAD
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

        private void TlpForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */
=======
        private void BtnActualizar_Click(
            object sender,
            EventArgs e)
        {
            int? idPerfil =
                IdDe(CbPerfil.SelectedValue);

            if (idPerfil == null)
            {
                MessageBox.Show(
                    "Selecciona un perfil.",
                    "Asignar permisos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult confirmar =
                MessageBox.Show(
                    "¿Deseas actualizar los permisos del perfil seleccionado?",
                    "Actualizar permisos",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (confirmar != DialogResult.Yes)
                return;

            try
            {
                int[] mantenimiento =
                    LeerSeleccionados(
                        ListBoxMant
                    );

                int[] registrar =
                    LeerSeleccionados(
                        ListBoxRegistrar
                    );

                int[] eliminar =
                    LeerSeleccionados(
                        ListBoxEliminar
                    );

                int[] modificar =
                    LeerSeleccionados(
                        ListBoxActualizar
                    );

                api.ActualizarPermisosPerfil(
                    idPerfil.Value,
                    mantenimiento,
                    registrar,
                    eliminar,
                    modificar
                );

                MessageBox.Show(
                    "Permisos actualizados correctamente.",
                    "Asignar permisos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarPermisos(
                    idPerfil.Value
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron actualizar los permisos.\n\n"
                    + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private int[] LeerSeleccionados(
            Componentes.CustomListBox lista)
        {
            var ids = new List<int>();

            foreach (object item
                     in lista.SelectedItems)
            {
                if (item is DataRowView fila &&
                    fila["Id"] != DBNull.Value)
                {
                    ids.Add(
                        Convert.ToInt32(
                            fila["Id"]
                        )
                    );
                }
            }

            return ids.ToArray();
        }

        private void LimpiarListas()
        {
            ListBoxMant.DataSource = null;
            ListBoxRegistrar.DataSource = null;
            ListBoxEliminar.DataSource = null;
            ListBoxActualizar.DataSource = null;
        }

        private static int? IdDe(
            object valor)
        {
            if (valor == null ||
                valor is DBNull)
            {
                return null;
            }

            if (valor is int entero)
                return entero;

            if (int.TryParse(
                valor.ToString(),
                out int resultado))
            {
                return resultado;
            }

            return null;
        }

        private void TlpForm_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void TlpAux2_Paint(
            object sender,
            PaintEventArgs e)
        {
        }
    }
}

/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 16/08/2026 */
>>>>>>> main
