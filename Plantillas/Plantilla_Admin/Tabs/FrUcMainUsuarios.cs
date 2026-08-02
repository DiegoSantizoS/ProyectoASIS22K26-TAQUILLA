using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Formularios_Admin;

namespace Plantilla_Admin
{
    public partial class FrUcMainUsuarios : UserControl
    {
        public FrUcMainUsuarios()
        {
            InitializeComponent();
            funcargarpagina(new Formularios_Admin.FrUcUsuarios());
        }

        private void funcargarpagina(UserControl pagina)
        {
            foreach (Control c in panel1.Controls) c.Dispose();
            panel1.Controls.Clear();
            pagina.Dock = DockStyle.Fill;
            panel1.Controls.Add(pagina);
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcargarpagina(new Formularios_Admin.FrUcPerfiles());
        }

        private void TsmUsuarios_Click(object sender, EventArgs e)
        {
            funcargarpagina(new Formularios_Admin.FrUcUsuarios());
        }

        private void TsmAsignarPermisos_Click(object sender, EventArgs e)
        {
            funcargarpagina(new Formularios_Admin.FrUcAsignarPermisos());
        }
    }
}
