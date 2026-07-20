/* Diego Fernando Santizo Samayoa 0901-22-15950
 * - Funcion para cargar diferentes paginas segun la pestanha seleccionada usando
 *   un panel como contenedor (funcargarpagina)
 * 
*/

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
    }
}
