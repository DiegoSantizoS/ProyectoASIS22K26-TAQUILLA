/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 19/07/2026 */

using clase_conexion;
using Plantilla_Admin.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Plantilla_Admin
{
    public partial class FrMenuAdmin : Form
    {
        public FrMenuAdmin()
        {
            InitializeComponent();
            //funcargarpagina(new logo());
        }

        private void funcargarpagina(UserControl pagina)
        {
            foreach (Control c in panel1.Controls) c.Dispose();
            panel1.Controls.Clear();
            pagina.Dock = DockStyle.Fill;
            panel1.Controls.Add(pagina);
        }

        private void carteleraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrUcMainCartelera cartelera = new FrUcMainCartelera();
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
            FrUcMainFunciones funciones = new FrUcMainFunciones();
            funcargarpagina(funciones);
        }

        private void promocionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrBorrador FrBorrador1 = new FrBorrador();
            funcargarpagina(FrBorrador1);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logo logo = new logo();
            funcargarpagina(logo);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrMenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnFunciones_Click(object sender, EventArgs e)
        {
            funcargarpagina(new FrUcMainFunciones());
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void PnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            funcargarpagina(new FrUcMainFunciones());
        }
    }
}

/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 20/07/2026 */