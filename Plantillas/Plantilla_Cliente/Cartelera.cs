using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Plantilla_Cliente
{
    public partial class Cartelera : UserControl
    {
        Boolean is2DFilterActive = false;
        Boolean is3DFilterActive = false;
        Boolean is4DFilterActive = false;
        Boolean isIMAXFilterActive = false;
        public event EventHandler CambiaraReserva;
        public Cartelera()
        {
            InitializeComponent();
        }
        private void Cartelera_Load(object sender, EventArgs e)
        {
            RedondearTablePanel(Pnl_Buscador, 20);
            RedondearBoton(Btn_3DFilter, 20);
            RedondearBoton(Btn_2DFilter, 20);
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

        private void Dgv_Cartelera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CambiaraReserva?.Invoke(this, EventArgs.Empty);
        }
    }
}
