/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 22/07/2026 */

<<<<<<< HEAD

using Con_Admin;
using Plantilla_Admin;
using Plantilla_Admin.FormulariosPrincipales;
=======
>>>>>>> main
using System;
using System.Data;
<<<<<<< HEAD
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
=======
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
>>>>>>> main
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Con_Admin;
using clase_conexion;
using Plantilla_Admin;
using Plantilla_Admin.FormulariosPrincipales;

namespace Plantilla_Cliente
{
    public partial class FrLogin : Form
    {
        private conexion db;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(
            IntPtr hWnd,
            int Msg,
            int wParam,
            int lParam
        );

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrLogin()
        {
            InitializeComponent();
<<<<<<< HEAD
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

        private void BtnIngresar_Click_1(object sender, EventArgs e)
        {
            string usuario = TbUsuario.Text.Trim();
            string contrasena = TbContra.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Ingresa usuario y contraseña.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                If_Login api = new If_Login();
                DataTable dt = api.ObtenerUsuario(usuario, contrasena);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string perfil = dt.Rows[0]["nombre_perfil"] == DBNull.Value
                    ? "" : dt.Rows[0]["nombre_perfil"].ToString();

                if (!perfil.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Acceso permitido solo a administradores.", "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
            string usuario = TbUsuario.Text.Trim();
            string contrasena = TbContra.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Ingresa usuario y contraseña.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                If_Login api = new If_Login();
                DataTable dt = api.ObtenerUsuario(usuario, contrasena);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string perfil = dt.Rows[0]["nombre_perfil"] == DBNull.Value
                    ? "" : dt.Rows[0]["nombre_perfil"].ToString();

                if (!perfil.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Acceso permitido solo a administradores.", "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
=======

            VerificarConexion();
            ConfigurarEventos();
        }

        private void VerificarConexion()
        {
            db = new conexion();

            if (db.ProbarConexion())
                return;

            MessageBox.Show(
                "No se pudo conectar a la base de datos. Configure la conexión.",
                "Conexión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            using (FrConexion form = new FrConexion())
            {
                if (form.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show(
                        "No se puede iniciar el programa sin una conexión válida.",
                        "Conexión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    Shown += (s, e) => Close();
                    return;
                }
            }

            db = new conexion();

            if (!db.ProbarConexion())
            {
                MessageBox.Show(
                    "La conexión sigue sin ser válida.",
                    "Conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Shown += (s, e) => Close();
            }
        }

        private void ConfigurarEventos()
        {
            KeyPreview = true;

            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BtnIngresar.PerformClick();
                    e.Handled = true;
                }
            };
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = TbUsuario.Text.Trim();
            string contrasena = TbContra.Text;

            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show(
                    "Ingresa usuario y contraseña.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                If_Login api = new If_Login();

                DataTable dt =
                    api.ObtenerUsuario(
                        usuario,
                        contrasena
                    );

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Usuario o contraseña incorrectos.",
                        "Login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                string perfil =
                    dt.Rows[0]["nombre_perfil"] == DBNull.Value
                        ? ""
                        : dt.Rows[0]["nombre_perfil"].ToString();

                int idUsuario =
                    Convert.ToInt32(
                        dt.Rows[0]["id_usuario"]
                    );

                string nombre =
                    dt.Rows[0]["nombre_usuario"].ToString();

                Sesion.Iniciar(
                    nombre,
                    perfil
                );

                RegistrarBitacora(
                    idUsuario
                );

                FrMenu menu =
                    new FrMenu();

                menu.FormClosed +=
                    (s, args) => Close();

                Hide();
                menu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo iniciar sesión.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private static void RegistrarBitacora(
            int idUsuario,
            int? idPermiso = null)
        {
            try
            {
                string ip =
                    ObtenerIpLocal();

                int? idNombrePc =
                    ObtenerOCrearNombrePc(
                        Environment.MachineName
                    );

                conexion.SesionIdUsuario =
                    idUsuario;

                conexion.SesionIdNombrePc =
                    idNombrePc;

                conexion.SesionIp =
                    ip;

                var db =
                    new conexion();

                MySqlConnection cn =
                    db.GetConnection();

                const string sql = @"
                    INSERT INTO tbl_bitacora
                    (
                        id_usuario,
                        id_permiso,
                        id_nombre_pc,
                        ip_bitacora
                    )
                    VALUES
                    (
                        @idUsuario,
                        @idPermiso,
                        @idNombrePc,
                        @ip
                    );";

                using (var cmd =
                    new MySqlCommand(
                        sql,
                        cn
                    ))
                {
                    cmd.Parameters.AddWithValue(
                        "@idUsuario",
                        idUsuario
                    );

                    cmd.Parameters.AddWithValue(
                        "@idPermiso",
                        (object)idPermiso ??
                        DBNull.Value
                    );

                    cmd.Parameters.AddWithValue(
                        "@idNombrePc",
                        (object)idNombrePc ??
                        DBNull.Value
                    );

                    cmd.Parameters.AddWithValue(
                        "@ip",
                        ip
                    );

                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
            }
        }

        private static int? ObtenerOCrearNombrePc(
            string nombrePc)
        {
            var db =
                new conexion();

            MySqlConnection cn =
                db.GetConnection();

            const string sqlBuscar = @"
                SELECT id_nombre_pc
                FROM tbl_nombre_pc
                WHERE nombre_pc = @nombre;";

            using (var cmdBuscar =
                new MySqlCommand(
                    sqlBuscar,
                    cn
                ))
            {
                cmdBuscar.Parameters.AddWithValue(
                    "@nombre",
                    nombrePc
                );

                object resultado =
                    cmdBuscar.ExecuteScalar();

                if (resultado != null &&
                    resultado != DBNull.Value)
                {
                    return Convert.ToInt32(
                        resultado
                    );
                }
            }

            const string sqlInsertar = @"
                INSERT INTO tbl_nombre_pc
                    (nombre_pc)
                VALUES
                    (@nombre);

                SELECT LAST_INSERT_ID();";

            using (var cmdInsertar =
                new MySqlCommand(
                    sqlInsertar,
                    cn
                ))
            {
                cmdInsertar.Parameters.AddWithValue(
                    "@nombre",
                    nombrePc
                );

                object nuevoId =
                    cmdInsertar.ExecuteScalar();

                return Convert.ToInt32(
                    nuevoId
                );
            }
        }

        private static string ObtenerIpLocal()
        {
            try
            {
                string hostName =
                    Dns.GetHostName();

                IPAddress[] ips =
                    Dns.GetHostAddresses(
                        hostName
                    );

                foreach (IPAddress ip in ips)
                {
                    if (ip.AddressFamily ==
                        AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
            }
            catch
            {
            }

            return "0.0.0.0";
        }

        private void MoverVentana(
            MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            ReleaseCapture();

            SendMessage(
                Handle,
                WM_NCLBUTTONDOWN,
                HT_CAPTION,
                0
            );
        }

        private void panel1_MouseMove(
            object sender,
            MouseEventArgs e)
        {
            MoverVentana(e);
        }

        private void panel1_MouseMove_1(
            object sender,
            MouseEventArgs e)
        {
            MoverVentana(e);
        }

        private void BtnDashboard_Click(
            object sender,
            EventArgs e)
        {
        }

        private void PicLogo_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}

/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 16/08/2026 */
>>>>>>> main
