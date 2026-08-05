using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using Plantilla_Cliente.Clases;


namespace Plantilla_Cliente
{
    public partial class Cartelera : UserControl
    {
        private Con_Cliente gconexion;
        Boolean is2DFilterActive = false;
        Boolean is3DFilterActive = false;
        Boolean is4DFilterActive = false;
        Boolean isIMAXFilterActive = false;
        Boolean isSubFilterActive = false;
        Boolean isDubFilterActive = false;

        public event Action<int, int> CambiaraReserva;
        public Cartelera()
        {
            InitializeComponent();
            gconexion = new Con_Cliente();
            Cargarciudad();
            CargarCines();
            CargarPeliculas();
            CboCiudad.ForeColor = Color.Black;
            CboCiudad.BackColor = Color.White;
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

            CboCiudad.DataSource = null;

            CboCiudad.DisplayMember = "nombre_ciudad";
            CboCiudad.ValueMember = "id_ciudad";

            CboCiudad.DataSource = dtCiudades;

            // Mostrar la opción inicial
            CboCiudad.SelectedIndex = 0;

        }
        private void CargarCines()
        {
            if (CboCiudad.SelectedValue == null)
                return;

            int idCiudad = Convert.ToInt32(CboCiudad.SelectedValue);

            DataTable dtCines = gconexion.mostrarcines(idCiudad);

            CboCine.DataSource = null;

            CboCine.DisplayMember = "nombre_cine";
            CboCine.ValueMember = "id_cine";

            CboCine.DataSource = dtCines;
        }

        private void CargarPeliculas()
        {
            DataTable peliculas = gconexion.mostrarpelicula();
            DgvCartelera.DataSource = peliculas;
            // Desactivar el redimensionamiento por el usuario
            DgvCartelera.AllowUserToResizeColumns = false;
            DgvCartelera.AllowUserToResizeRows = false;

            // Ajustar automáticamente el ancho de las columnas
            DgvCartelera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // Si hay texto largo en una celda
            DgvCartelera.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvCartelera.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            foreach (DataGridViewColumn column in DgvCartelera.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
                // Establecer el color de la letra para las columnas generadas por el DataSource
                column.DefaultCellStyle.ForeColor = Color.FromArgb(112, 27, 40);        

                //DgvCartelera.Columns[2].Visible = false;


            }
        }
        /* fin de Codigo de Miguel David Contreras Jacinto con carnet: 0901-21-3878 en la
 * fecha de: 27/07/2026 */
        private void Cartelera_Load(object sender, EventArgs e)
        {
            RedondearTablePanel(PnlBuscador, 20);
            RedondearBoton(Btn2DFilter, 20);
            RedondearBoton(Btn3DFilter, 20);
            RedondearBoton(Btn4DXFilter, 20);
            RedondearBoton(BtnIMAXFilter, 20);
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

            boton.FlatStyle = FlatStyle.Popup;
            try
            {
                boton.FlatAppearance.BorderSize = 0;
            }
            catch { MessageBox.Show("Error al redondear el botón.", "Error"); }
        }
        private void Btn_2DFilter_Click(object sender, EventArgs e)
        {
            if (is2DFilterActive)
            {
                is2DFilterActive = false;
                Btn2DFilter.BackColor = Color.FromArgb(197, 155, 39);
            }
            else
            {
                is3DFilterActive = false;
                is4DFilterActive = false;
                isIMAXFilterActive = false;
                Btn2DFilter.BackColor = Color.FromArgb(112, 27, 40);
                Btn3DFilter.BackColor = Color.FromArgb(197, 155, 39);
                Btn4DXFilter.BackColor = Color.FromArgb(197, 155, 39);
                BtnIMAXFilter.BackColor = Color.FromArgb(197, 155, 39);
            }
            filtros();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            RedondearTablePanel(PnlBuscador, 20);
            RedondearBoton(Btn3DFilter, 20);
            RedondearBoton(Btn2DFilter, 20);
            RedondearBoton(Btn4DXFilter, 20);
            RedondearBoton(BtnIMAXFilter, 20);
            RedondearBoton(BtnSubFilter, 20);
            RedondearBoton(BtnDobFilter, 20);
        }

        private void Btn_3DFilter_Click(object sender, EventArgs e)
        {
            if (is3DFilterActive)
            {
                is3DFilterActive = false;
                Btn3DFilter.BackColor = Color.FromArgb(197, 155, 39);

            }
            else
            {
                is3DFilterActive = true;
                is2DFilterActive = false;
                is4DFilterActive = false;
                isIMAXFilterActive = false;
                Btn3DFilter.BackColor = Color.FromArgb(112, 27, 40);
                Btn2DFilter.BackColor = Color.FromArgb(197, 155, 39);
                Btn4DXFilter.BackColor = Color.FromArgb(197, 155, 39);
                BtnIMAXFilter.BackColor = Color.FromArgb(197, 155, 39);
            }
        }

        private void Btn_4DXFilter_Click(object sender, EventArgs e)
        {
            if (is4DFilterActive)
            {
                is4DFilterActive = false;
                Btn4DXFilter.BackColor = Color.FromArgb(197, 155, 39);
            }
            else
            {
                is4DFilterActive = true;
                is2DFilterActive = false;
                is3DFilterActive = false;
                isIMAXFilterActive = false;
                Btn4DXFilter.BackColor = Color.FromArgb(112, 27, 40);
                Btn2DFilter.BackColor = Color.FromArgb(197, 155, 39);
                Btn3DFilter.BackColor = Color.FromArgb(197, 155, 39);
                BtnIMAXFilter.BackColor = Color.FromArgb(197, 155, 39);

            }
        }

        private void Btn_IMAXFilter_Click(object sender, EventArgs e)
        {
            if (isIMAXFilterActive)
            {
                isIMAXFilterActive = false;
                BtnIMAXFilter.BackColor = Color.White;
            }
            else
            {
                isIMAXFilterActive = true;
                is2DFilterActive = false;
                is3DFilterActive = false;
                is4DFilterActive = false;
                BtnIMAXFilter.BackColor = Color.FromArgb(112, 27, 40);
                Btn2DFilter.BackColor = Color.FromArgb(197, 155, 39);
                Btn3DFilter.BackColor = Color.FromArgb(197, 155, 39);
                Btn4DXFilter.BackColor = Color.FromArgb(197, 155, 39);
            }
        }
        private void Btn_SubFilter_Click(object sender, EventArgs e)
        {
            if (isSubFilterActive)
            {
                // Desactivar subtitulada
                isSubFilterActive = false;
                BtnSubFilter.BackColor = Color.White;
            }
            else
            {
                // Activar subtitulada y desactivar doblada
                isSubFilterActive = true;
                isDubFilterActive = false;

                BtnSubFilter.BackColor = Color.FromArgb(112, 27, 40);
                BtnDobFilter.BackColor = Color.FromArgb(197, 155, 39);
            }
            filtros();
            //System.Diagnostics.Debug.WriteLine($"Subtitulada: {isSubFilterActive}, Doblada: {isDubFilterActive}");
        }
        private void Btn_DobFilter_Click(object sender, EventArgs e)
        {
            if (isDubFilterActive)
            {
                isDubFilterActive = false;
                BtnDobFilter.BackColor = Color.White;
            }
            else
            {
                isDubFilterActive = true;
                isSubFilterActive = false;

                BtnDobFilter.BackColor = Color.FromArgb(112, 27, 40);
                BtnSubFilter.BackColor = Color.FromArgb(197, 155, 39);
            }
            filtros();
            //System.Diagnostics.Debug.WriteLine($"Subtitulada: {isSubFilterActive}, Doblada: {isDubFilterActive}");
        }
        private void Dgv_Cartelera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
               
                return;
            }
            if (e.ColumnIndex == DgvCartelera.Columns["Reservar"].Index)
            {
                int idPelicula = Convert.ToInt32(
                DgvCartelera.Rows[e.RowIndex].Cells["idPelicula"].Value);
                int ciudad = Convert.ToInt32(CboCine.SelectedValue);
                CambiaraReserva?.Invoke(idPelicula, ciudad);

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
            filtros();
        }

        public void filtros()
        {
            if (CboCiudad.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione una ciudad.");
                return;
            }

            int ciudad = Convert.ToInt32(CboCiudad.SelectedValue);
            int cine = Convert.ToInt32(CboCine.SelectedValue);
            MessageBox.Show($"Ciudad: {ciudad}, Cine: {cine}");

            // Tipo de función
            int tipoFuncion = 0;

            if (is2DFilterActive)
                tipoFuncion = 1;
            else if (is3DFilterActive)
                tipoFuncion = 2;
            else if (is4DFilterActive)
                tipoFuncion = 3;
            else if (isIMAXFilterActive)
                tipoFuncion = 4;

            // Idioma
            int idioma = 0;

            if (isSubFilterActive)
                idioma = 1;
            else if (isDubFilterActive)
                idioma = 2;

            if (tipoFuncion == 0)
            {
                MessageBox.Show("Seleccione un formato.");
                return;
            }

            if (idioma == 0)
            {
                MessageBox.Show("Seleccione un idioma.");
                return;
            }

            DgvCartelera.DataSource = gconexion.FiltrarCartelera(ciudad, cine, tipoFuncion, idioma);
        }

        private void Btn_Cargar_Cartelera_Click_1(object sender, EventArgs e)
        {
            filtros();
        }

        private void Btn_Cargar_Cartelera_Click_2(object sender, EventArgs e)
        {
            filtros();
        }

    }
}