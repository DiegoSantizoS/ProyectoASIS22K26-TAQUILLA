using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Cartelera()
        {
            InitializeComponent();
        }
        private void Cartelera_Load(object sender, EventArgs e)
        {
            RedondearPanel(Pnl_Buscador, 20);
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
        private void RedondearPanel(System.Windows.Forms.TableLayoutPanel panel, int radio)
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
            
        }
    }
}
