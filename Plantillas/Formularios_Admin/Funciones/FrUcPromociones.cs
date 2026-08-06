using Con_Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Admin.Funciones
{
    public partial class FrUcPromociones : UserControl

    {
        private readonly If_Promociones api = new If_Promociones();
        private DataTable tablaPromociones;
        public FrUcPromociones()
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
            CbPelicula.DataSource = api.ListarPeliculas();
            CbPelicula.DisplayMember = "Nombre";
            CbPelicula.ValueMember = "Id";
            CbPelicula.SelectedIndex = -1;

            ccb_tipopromocion.DataSource = api.ListarTipos();
            ccb_tipopromocion.DisplayMember = "Nombre";
            ccb_tipopromocion.ValueMember = "Id";
            ccb_tipopromocion.SelectedIndex = -1;
        }

        private void CargarFiltro()
        {
            CbFiltro.Items.Clear();
            CbFiltro.Items.Add("ID");
            CbFiltro.Items.Add("Nombre");
            CbFiltro.Items.Add("Tipo");
            CbFiltro.SelectedIndex = 1;
        }

        private void CargarGrilla()
        {
            tablaPromociones = api.Listar();
            DgvFunciones.DataSource = tablaPromociones;
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (DgvFunciones.Columns.Count == 0) return;

            Ocultar("id_tipo_promocion");
            Ocultar("codigo_tipo_promocion");

            Encabezado("id_promocion", "ID");
            Encabezado("nombre_promocion", "Nombre");
            Encabezado("descripcion_promocion", "Descripción");
            Encabezado("nombre_tipo_promocion", "Tipo");
            Encabezado("valor_promocion", "Valor");
            Encabezado("fecha_inicio_promocion", "Inicio");
            Encabezado("fecha_fin_promocion", "Fin");
            Encabezado("activa_promocion", "Activa");
        }

        private void Ocultar(string columna)
        {
            if (DgvFunciones.Columns.Contains(columna))
                DgvFunciones.Columns[columna].Visible = false;
        }

        private void Encabezado(string columna, string texto)
        {
            if (DgvFunciones.Columns.Contains(columna))
                DgvFunciones.Columns[columna].HeaderText = texto;
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
            ctb_nombre.Clear();
            ctb_descripcion.Clear();
            Tbvalorpromocion.Clear();
            customTextBoxestado.Text = "Activa";
            CbPelicula.SelectedIndex = -1;
            ccb_tipopromocion.SelectedIndex = -1;
            DpFechaincio.Value = DateTime.Today;
            cpfinal.Value = DateTime.Today;
        }

        private string LeerNombre()
        {
            return ctb_nombre.Text.Trim();
        }

        private string LeerDescripcion()
        {
            return ctb_descripcion.Text.Trim();
        }

        private int? LeerTipo()
        {
            return IdDe(ccb_tipopromocion.SelectedValue);
        }

        private decimal LeerValor()
        {
            return decimal.TryParse(Tbvalorpromocion.Text.Trim(), out decimal v) ? v : 0m;
        }

        private DateTime LeerFechaInicio()
        {
            return DpFechaincio.Value.Date;
        }

        private DateTime LeerFechaFin()
        {
            return cpfinal.Value.Date;
        }

        private bool LeerActiva()
        {
            return customTextBoxestado.Text.Trim().Equals("Activa", StringComparison.OrdinalIgnoreCase);
        }

        private int[] LeerPeliculas()
        {
            int? id = IdDe(CbPelicula.SelectedValue);
            return id == null ? new int[0] : new[] { id.Value };
        }

        private void PonerTexto(Componentes.CustomTextBox tb, string valor)
        {
            tb.Focus();
            tb.Text = valor;
            tb.ForeColor = System.Drawing.Color.FromArgb(230, 230, 230);
        }

        private static int? IdDe(object valor)
        {
            if (valor == null || valor is DBNull) return null;
            if (valor is int i) return i;
            return int.TryParse(valor.ToString(), out int r) ? (int?)r : (int?)null;
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(LeerNombre()))
            {
                MessageBox.Show("El nombre de la promoción es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ctb_nombre.Focus();
                return false;
            }
            if (LeerTipo() == null)
            {
                MessageBox.Show("Debes seleccionar un tipo de promoción.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ccb_tipopromocion.Focus();
                return false;
            }
            if (LeerValor() <= 0)
            {
                MessageBox.Show("El valor debe ser un número mayor que cero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Tbvalorpromocion.Focus();
                return false;
            }
            if (LeerFechaFin() < LeerFechaInicio())
            {
                MessageBox.Show("La fecha fin no puede ser anterior a la fecha de inicio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cpfinal.Focus();
                return false;
            }
            return true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            try
            {
                int nuevo = api.Insertar(LeerNombre(), LeerDescripcion(), LeerTipo().Value, LeerValor(),
                    LeerFechaInicio(), LeerFechaFin(), LeerActiva(), LeerPeliculas());

                MessageBox.Show("Promoción agregada correctamente. ID: " + nuevo, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la promoción.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona una promoción de la tabla para actualizar.", "Actualizar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validar()) return;

            try
            {
                bool ok = api.Actualizar(id, LeerNombre(), LeerDescripcion(), LeerTipo().Value, LeerValor(),
                    LeerFechaInicio(), LeerFechaFin(), LeerActiva(), LeerPeliculas());

                MessageBox.Show(ok ? "Promoción actualizada correctamente." : "No se encontró la promoción.",
                    "Actualizar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la promoción.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona una promoción de la tabla para eliminar.", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Seguro que deseas eliminar la promoción \"" + ctb_nombre.Text.Trim() + "\"?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar != DialogResult.Yes) return;

            try
            {
                bool ok = api.Eliminar(id);
                MessageBox.Show(ok ? "Promoción eliminada." : "No se encontró la promoción.",
                    "Eliminar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la promoción.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (DgvFunciones.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una promoción de la tabla primero.", "Copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarDesdeFila(DgvFunciones.CurrentRow);
            ModoEdicion();
        }

        private void CargarDesdeFila(DataGridViewRow fila)
        {
            var enlace = fila.DataBoundItem as DataRowView;
            if (enlace == null) return;

            DataRow row = enlace.Row;
            int id = Convert.ToInt32(row["id_promocion"]);

            TbID.Text = id.ToString();
            PonerTexto(ctb_nombre, row["nombre_promocion"].ToString());
            PonerTexto(ctb_descripcion, row["descripcion_promocion"] == DBNull.Value ? "" : row["descripcion_promocion"].ToString());
            ccb_tipopromocion.SelectedValue = row["id_tipo_promocion"] == DBNull.Value ? -1 : row["id_tipo_promocion"];
            PonerTexto(Tbvalorpromocion, row["valor_promocion"].ToString());

            DpFechaincio.Value = row["fecha_inicio_promocion"] == DBNull.Value
                ? DateTime.Today
                : Convert.ToDateTime(row["fecha_inicio_promocion"]);

            cpfinal.Value = row["fecha_fin_promocion"] == DBNull.Value
                ? DateTime.Today
                : Convert.ToDateTime(row["fecha_fin_promocion"]);

            bool activa = row["activa_promocion"] != DBNull.Value && Convert.ToBoolean(row["activa_promocion"]);
            PonerTexto(customTextBoxestado, activa ? "Activa" : "Inactiva");

            var peliculas = api.ListarPeliculasDePromocion(id);
            CbPelicula.SelectedValue = peliculas.Rows.Count > 0 ? peliculas.Rows[0]["id_pelicula"] : -1;

            DgvFunciones.Focus();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (tablaPromociones == null) return;

            string texto = TbFiltro.Text.Trim().Replace("'", "''");
            if (texto.Length == 0)
            {
                tablaPromociones.DefaultView.RowFilter = string.Empty;
                return;
            }

            string columna = ColumnaFiltro();
            if (columna == "id_promocion")
                tablaPromociones.DefaultView.RowFilter =
                    "Convert(id_promocion, 'System.String') LIKE '%" + texto + "%'";
            else
                tablaPromociones.DefaultView.RowFilter = columna + " LIKE '%" + texto + "%'";
        }

        private string ColumnaFiltro()
        {
            string sel = CbFiltro.SelectedItem == null ? "Nombre" : CbFiltro.SelectedItem.ToString();
            switch (sel)
            {
                case "ID": return "id_promocion";
                case "Tipo": return "nombre_tipo_promocion";
                default: return "nombre_promocion";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbFiltro.Clear();
            CargarGrilla();
            ModoAgregar();
        }




        private void LbSala_Click(object sender, EventArgs e)
        {

        }

        private void customLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LbTipoDeFuncion_Click(object sender, EventArgs e)
        {

        }

        private void customLabel2_Click(object sender, EventArgs e)
        {

        }

        private void customLabel3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
