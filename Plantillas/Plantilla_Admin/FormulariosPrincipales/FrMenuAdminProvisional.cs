using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_Admin.FormulariosPrincipales
{
    public partial class FrMenuAdminProvisional : Form
    {
        public FrMenuAdminProvisional()
        {
            InitializeComponent();
            funcargarpagina(new logo());
        }

        private void funcargarpagina(UserControl pagina)
        {
            foreach (Control c in panel1.Controls) c.Dispose();
            panel1.Controls.Clear();
            pagina.Dock = DockStyle.Fill;
            panel1.Controls.Add(pagina);
        }

        private void usuarios_Click(object sender, EventArgs e)
        {
            funcargarpagina(new usuarios());
        }

        private void logo_Click(object sender, EventArgs e)
        {
            funcargarpagina(new logo());
        }   

        }
    }
