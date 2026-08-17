/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 19/07/2026 */

using clase_conexion;
using Formularios_Admin;
using Plantilla_Admin.Tabs;
using Plantilla_Cliente;
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
            /* foreach (Control c in panel1.Controls) c.Dispose();
             panel1.Controls.Clear();
             pagina.Dock = DockStyle.Fill;
             panel1.Controls.Add(pagina);
         */
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void kryptonTableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutSlider1_MouseEnter(object sender, EventArgs e)
        {
            //base.OnMouseEnter(e);
            //Open();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 20/07/2026 */