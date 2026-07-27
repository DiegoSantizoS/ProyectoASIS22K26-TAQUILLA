using Plantilla_Admin.Tabs.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Plantilla_Admin.Tabs.Sala;

namespace Plantilla_Admin
{
    public partial class FrUcMainFunciones : UserControl
    {
        public FrUcMainFunciones()
        {
            InitializeComponent();
        }

        private void funcargarpagina(UserControl pagina)
        {
            foreach (Control c in panel1.Controls) c.Dispose();
            panel1.Controls.Clear();
            pagina.Dock = DockStyle.Fill;
            panel1.Controls.Add(pagina);
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrUcMantenimientoFuncion FrUcMantenimientoFuncion1 = new FrUcMantenimientoFuncion();
            funcargarpagina(FrUcMantenimientoFuncion1);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrUcBuscarSala FrUcBuscarSala1 = new FrUcBuscarSala();
            funcargarpagina(FrUcBuscarSala1);
        }
    }
}
