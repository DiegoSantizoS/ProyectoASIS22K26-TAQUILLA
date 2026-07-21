/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 19/07/2026 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plantilla_Admin
{
    public partial class FrMenuAdmin : Form
    {
        public FrMenuAdmin()
        {
            InitializeComponent();
            funcargarpagina(new logo());
        }

        private void funcargarpagina(UserControl pagina)
        {
            foreach (Control c in pnlMenuAdmin.Controls) c.Dispose();
            pnlMenuAdmin.Controls.Clear();
            pagina.Dock = DockStyle.Fill;
            pnlMenuAdmin.Controls.Add(pagina);
        }

        private void carteleraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cartelera cartelera = new cartelera();
            funcargarpagina(cartelera);
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportes reportes = new reportes();
            funcargarpagina(reportes);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarios usuarios = new usuarios();
            funcargarpagina(usuarios);
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayuda ayuda = new ayuda();
            funcargarpagina(ayuda);
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sedes sedes = new sedes();
            funcargarpagina(sedes);
        }

        private void funcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funciones funciones = new funciones();
            funcargarpagina(funciones);
        }

        private void promocionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            promociones promociones = new promociones();
            funcargarpagina(promociones);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logo logo = new logo();
            funcargarpagina(logo);
        }
    }
}

/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 20/07/2026 */