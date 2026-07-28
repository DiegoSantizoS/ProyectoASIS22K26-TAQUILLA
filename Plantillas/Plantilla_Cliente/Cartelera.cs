using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using clase_conexion;

namespace Plantilla_Cliente
{
    public partial class Cartelera : UserControl
    {
        Boolean is2DFilterActive = false;
        Boolean is3DFilterActive = false;
        Boolean is4DFilterActive = false;
        Boolean isIMAXFilterActive = false;
        Boolean isSubFilterActive = false;
        Boolean isDubFilterActive = false;
        private conexion gconexion;

        public event Action<int> CambiaraReserva;

        public Cartelera()
        {
            InitializeComponent();
            gconexion = new conexion();
            Cargarciudad();
            CargarPeliculas();
            Cbo_Ciudad.ForeColor = Color.Black;
            Cbo_Ciudad.BackColor = Color.White;
        }
        /* Inicio de Codigo de Miguel David Contreras Jacinto con carnet: 0901-21-3878 en la
 * fecha de: 27/07/2026 */
        private void Cargarciudad()
        {
            DataTable dtCiudades = gconexion.mostrarciudades();

            // Crear una fila para la opción inicial
            DataRow fila = dtCiudades.NewRow();
            fila["id_ciudad"] = 0;
            fila["nombre_ciudad"] = "Seleccionar ciudad";

            // Colocarla al principio
            dtCiudades.Rows.InsertAt(fila, 0);

            Cbo_Ciudad.DataSource = null;

            Cbo_Ciudad.DisplayMember = "nombre_ciudad";
            Cbo_Ciudad.ValueMember = "id_ciudad";

            Cbo_Ciudad.DataSource = dtCiudades;

            // Mostrar la opción inicial
            Cbo_Ciudad.SelectedIndex = 0;

        }
        private void CargarCines()
        {
            if (Cbo_Ciudad.SelectedValue == null)
                return;

            int idCiudad = Convert.ToInt32(Cbo_Ciudad.SelectedValue);

            DataTable dtCines = gconexion.mostrarcines(idCiudad);

            Cbo_Cine.DataSource = null;

            Cbo_Cine.DisplayMember = "nombre_cine";
            Cbo_Cine.ValueMember = "id_cine";

            Cbo_Cine.DataSource = dtCines;
        }

        private void CargarPeliculas()
        {
            DataTable peliculas = gconexion.mostrarpelicula();

            Dgv_Cartelera.DataSource = peliculas;
        }
        /* fin de Codigo de Miguel David Contreras Jacinto con carnet: 0901-21-3878 en la
 * fecha de: 27/07/2026 */
        private void Cartelera_Load(object sender, EventArgs e)
        {
            RedondearTablePanel(Pnl_Buscador, 20);
            RedondearBoton(Btn_2DFilter, 20);
            RedondearBoton(Btn_3DFilter, 20);
            RedondearBoton(Btn_4DXFilter, 20);
            RedondearBoton(Btn_IMAXFilter, 20);
        }
        private void RedondearPanel(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(panel.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, panel.Height - radio, radio, radio, 90, 90);

            path.CloseFigure();

            panel.Region = new Region(path);
        }
        private void RedondearTablePanel(System.Windows.Forms.TableLayoutPanel panel, int radio)
        {
            if (panel == null) return;

            int w = panel.Width;
            int h = panel.Height;
            if (w <= 0 || h <= 0) return;

            int r = Math.Max(0, Math.Min(radio, Math.Min(w, h)));

            if (r == 0)
            {
                panel.Region?.Dispose();
                panel.Region = null;
                return;
            }

            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(0, 0, r, r, 180, 90);
                path.AddArc(w - r, 0, r, r, 270, 90);
                path.AddArc(w - r, h - r, r, r, 0, 90);
                path.AddArc(0, h - r, r, r, 90, 90);
                path.CloseFigure();

                var old = panel.Region;
                panel.Region = new System.Drawing.Region(path);
                old?.Dispose();
            }
        }
        private void RedondearBoton(Button boton, int radio)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int w = boton.Width;
                int h = boton.Height;
                int r = Math.Min(radio, Math.Min(w, h));
                path.AddArc(0, 0, r, r, 180, 90);
                path.AddArc(w - r, 0, r, r, 270, 90);
                path.AddArc(w - r, h - r, r, r, 0, 90);
                path.AddArc(0, h - r, r, r, 90, 90);
                path.CloseFigure();
                boton.Region = new Region(path);
            }

            boton.FlatStyle = FlatStyle.Flat;
            try
            {
                boton.FlatAppearance.BorderSize = 0;
            }
            catch { MessageBox.Show("Error al redondear el botón.", "Error"); }
        }
        private void Btn_2DFilter_Click(object sender, EventArgs e)
        {
            is2DFilterActive = !is2DFilterActive;
            Btn_2DFilter.BackColor = is2DFilterActive
                ? Color.FromArgb(68, 75, 245) // Color activo
                : Color.FromArgb(255, 255, 255); // Color inactivo
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            RedondearTablePanel(Pnl_Buscador, 20);
            RedondearBoton(Btn_3DFilter, 20);
            RedondearBoton(Btn_2DFilter, 20);
            RedondearBoton(Btn_4DXFilter, 20);
            RedondearBoton(Btn_IMAXFilter, 20);
            RedondearBoton(Btn_SubFilter, 20);
            RedondearBoton(Btn_DobFilter, 20);
        }

        private void Btn_3DFilter_Click(object sender, EventArgs e)
        {
            is3DFilterActive = !is3DFilterActive;
            Btn_3DFilter.BackColor = is3DFilterActive
                ? Color.FromArgb(68, 75, 245) // Color activo
                : Color.FromArgb(255, 255, 255); // Color inactivo
        }

        private void Btn_4DXFilter_Click(object sender, EventArgs e)
        {
            is4DFilterActive = !is4DFilterActive;
            Btn_4DXFilter.BackColor = is4DFilterActive
                ? Color.FromArgb(68, 75, 245) // Color activo
                : Color.FromArgb(255, 255, 255); // Color inactivo
        }

        private void Btn_IMAXFilter_Click(object sender, EventArgs e)
        {
            isIMAXFilterActive = !isIMAXFilterActive;
            Btn_IMAXFilter.BackColor = isIMAXFilterActive
                ? Color.FromArgb(68, 75, 245) // Color activo
                : Color.FromArgb(255, 255, 255); // Color inactivo
        }
        private void Btn_SubFilter_Click(object sender, EventArgs e)
        {
            if (isSubFilterActive)
            {
                // Desactivar subtitulada
                isSubFilterActive = false;
                Btn_SubFilter.BackColor = Color.White;
            }
            else
            {
                // Activar subtitulada y desactivar doblada
                isSubFilterActive = true;
                isDubFilterActive = false;

                Btn_SubFilter.BackColor = Color.FromArgb(68, 75, 245);
                Btn_DobFilter.BackColor = Color.White;
            }
            //System.Diagnostics.Debug.WriteLine($"Subtitulada: {isSubFilterActive}, Doblada: {isDubFilterActive}");
        }
        private void Btn_DobFilter_Click(object sender, EventArgs e)
        {
            if (isDubFilterActive)
            {
                isDubFilterActive = false;
                Btn_DobFilter.BackColor = Color.White;
            }
            else
            {
                isDubFilterActive = true;
                isSubFilterActive = false;

                Btn_DobFilter.BackColor = Color.FromArgb(68, 75, 245);
                Btn_SubFilter.BackColor = Color.White;
            }
            //System.Diagnostics.Debug.WriteLine($"Subtitulada: {isSubFilterActive}, Doblada: {isDubFilterActive}");
        }
        private void Dgv_Cartelera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == Dgv_Cartelera.Columns["Reservar"].Index)
            {
                /*int idPelicula = Convert.ToInt32(
                    Dgv_Cartelera.Rows[e.RowIndex].Cells["IdPelicula"].Value);*/

                CambiaraReserva?.Invoke(10);
            }
        }

        private void Btn_Cargar_Cartelera_Click(object sender, EventArgs e)
        {

        }

        private void Cbo_Ciudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCines();
        }

        private void Cbo_Cine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void filtros()
        {

            if (Cbo_Ciudad.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione una ciudad.");
                return;
            }

            if (Cbo_Cine.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un cine.");
                return;
            }

            int tipo = 0;

            if (is2DFilterActive && isSubFilterActive)
                tipo = 1;

            else if (is2DFilterActive && isDubFilterActive)
                tipo = 2;

            else if (is3DFilterActive && isSubFilterActive)
                tipo = 3;

            else if (is3DFilterActive && isDubFilterActive)
                tipo = 4;

            else if (is4DFilterActive && isSubFilterActive)
                tipo = 5;

            else if (is4DFilterActive && isDubFilterActive)
                tipo = 6;

            else if (isIMAXFilterActive && isSubFilterActive)
                tipo = 7;

            else if (isIMAXFilterActive && isDubFilterActive)
                tipo = 8;

            if (tipo == 0)
            {
                MessageBox.Show("Seleccione un formato y un idioma.");
                return;
            }

            int ciudad = Convert.ToInt32(Cbo_Ciudad.SelectedValue);
            int cine = Convert.ToInt32(Cbo_Cine.SelectedValue);

            Dgv_Cartelera.DataSource = gconexion.FiltrarCartelera(ciudad, cine, tipo);

        }

        private void Btn_Cargar_Cartelera_Click_1(object sender, EventArgs e)
        {
            filtros();
        }
    }
}