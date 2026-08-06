/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 22/07/2026 */


using Con_Admin;
using Plantilla_Admin;
using Plantilla_Admin.FormulariosPrincipales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;



namespace Plantilla_Cliente
{
    public partial class FrLogin : Form
    {
        public FrLogin()
        {
            InitializeComponent();
            //this.AcceptButton = BtnIngresar;
            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BtnIngresar.PerformClick();
                    e.Handled = true;
                }
            };
        }

        private DataRow? AutenticarYRegistrar()
        {
            string usuario = TbUsuario.Text.Trim();
            string contrasena = TbContra.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Ingresa usuario y contraseña.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            If_Login api = new If_Login();
            DataTable dt = api.ObtenerUsuario(usuario, contrasena);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            DataRow fila = dt.Rows[0];

            string perfil = fila.Table.Columns.Contains("nombre_perfil")
                            && fila["nombre_perfil"] != DBNull.Value
                ? fila["nombre_perfil"].ToString()!
                : "";

            Sesion.Iniciar(usuario, perfil);
            return fila;
        }

        private void BtnIngresar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (AutenticarYRegistrar() == null) return;

                FrMenuAdmin menu = new FrMenuAdmin();
                menu.FormClosed += (s, args) => this.Close();
                this.Hide();
                menu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo iniciar sesión.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            //funcargarpagina(new FrUcMainFunciones());
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (AutenticarYRegistrar() == null) return;

                FrMenu menu = new FrMenu();
                menu.FormClosed += (s, args) => this.Close();
                this.Hide();
                menu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo iniciar sesión.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 31/07/2026 */