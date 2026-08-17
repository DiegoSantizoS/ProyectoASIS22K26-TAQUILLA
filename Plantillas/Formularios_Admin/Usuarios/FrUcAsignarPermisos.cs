/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 05/08/2026 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Con_Admin;

namespace Formularios_Admin
{
    public partial class FrUcAsignarPermisos : UserControl
    {
        private readonly If_AsignarPermisos api =
            new If_AsignarPermisos();

        private bool cargando;

        public FrUcAsignarPermisos()
        {
            InitializeComponent();
            WireEvents();
            CargarPerfiles();
            LimpiarListas();
        }

        private void WireEvents()
        {
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
                }
            }
        }

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