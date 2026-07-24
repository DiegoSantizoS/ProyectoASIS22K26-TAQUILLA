using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plantilla_Admin
{
    public partial class FrCuMainCartelera : UserControl
    {
        public FrCuMainCartelera()
        {
            InitializeComponent();
            funcargarpagina(new FrCuBuscarCartelera1());
        }

        private void funcargarpagina(UserControl pagina)
        {
            foreach (Control c in panel1.Controls) c.Dispose();
            panel1.Controls.Clear();
            pagina.Dock = DockStyle.Fill;
            panel1.Controls.Add(pagina);
        }

        private void aGREGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrCuMantenimientoCartelera frCuMantenimientoCartelera = new FrCuMantenimientoCartelera();
            funcargarpagina(frCuMantenimientoCartelera);
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrCuBuscarCartelera1 frBuscarCartelera = new FrCuBuscarCartelera1();
            funcargarpagina(frBuscarCartelera);
        }
    }
}
