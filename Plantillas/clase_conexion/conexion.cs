using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Inicio de Codigo de Miguel David Contreras Jacinto con carnet: 0901-21-3878 en la
 * fecha de: 26/07/2026 */
namespace clase_conexion
{
    public class conexion
    {
        private MySqlConnection connection;

        private const string database = "taquillas_cine";

        private string server;
        private string user;
        private string password;
        private string pconexion;

        private readonly string archivoConfiguracion;

        public static int SesionIdUsuario { get; set; }
        public static int? SesionIdNombrePc { get; set; }
        public static string SesionIp { get; set; }

        public string Server => server;
        public string User => user;
        public string Password => password;

        public string RutaArchivoConfiguracion =>
            archivoConfiguracion;

        public conexion()
        {
            archivoConfiguracion = Path.Combine(
                AppContext.BaseDirectory,
                "conexion.txt"
            );

            if (!File.Exists(archivoConfiguracion))
            {
                File.WriteAllLines(
                    archivoConfiguracion,
                    new string[]
                    {
                        "Server=localhost",
                        "User=root",
                        "Password=root"
                    }
                );
            }

            CargarCredenciales();
            CrearCadenaConexion();
        }

        private void CargarCredenciales()
        {
            server = "";
            user = "";
            password = "";

            string[] lineas =
                File.ReadAllLines(archivoConfiguracion);

            foreach (string linea in lineas)
            {
                int posicion = linea.IndexOf('=');

                if (posicion <= 0)
                    continue;

                string clave =
                    linea.Substring(0, posicion).Trim();

                string valor =
                    linea.Substring(posicion + 1).Trim();

                switch (clave.ToLower())
                {
                    case "server":
                        server = valor;
                        break;

                    case "user":
                        user = valor;
                        break;

                    case "password":
                        password = valor;
                        break;
                }
            }
        }

        private void CrearCadenaConexion()
        {
            MySqlConnectionStringBuilder builder =
                new MySqlConnectionStringBuilder
                {
                    Server = server,
                    Database = database,
                    UserID = user,
                    Password = password,
                    AllowUserVariables = true
                };

            pconexion = builder.ConnectionString;
        }

        private string CrearCadenaConexion(
            string servidor,
            string usuario,
            string contrasena)
        {
            MySqlConnectionStringBuilder builder =
                new MySqlConnectionStringBuilder
                {
                    Server = servidor,
                    Database = database,
                    UserID = usuario,
                    Password = contrasena,
                    AllowUserVariables = true
                };

            return builder.ConnectionString;
        }

        public bool ProbarConexion()
        {
            return ProbarConexion(pconexion);
        }

        private bool ProbarConexion(string cadena)
        {
            try
            {
                using (MySqlConnection prueba =
                    new MySqlConnection(cadena))
                {
                    prueba.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool GuardarCredenciales(
            string nuevoServer,
            string nuevoUser,
            string nuevoPassword)
        {
            nuevoServer =
                nuevoServer?.Trim() ?? "";

            nuevoUser =
                nuevoUser?.Trim() ?? "";

            nuevoPassword =
                nuevoPassword ?? "";

            if (string.IsNullOrWhiteSpace(nuevoServer) ||
                string.IsNullOrWhiteSpace(nuevoUser))
            {
                return false;
            }

            string nuevaCadena =
                CrearCadenaConexion(
                    nuevoServer,
                    nuevoUser,
                    nuevoPassword
                );

            if (!ProbarConexion(nuevaCadena))
                return false;

            try
            {
                File.WriteAllLines(
                    archivoConfiguracion,
                    new string[]
                    {
                        "Server=" + nuevoServer,
                        "User=" + nuevoUser,
                        "Password=" + nuevoPassword
                    }
                );

                if (connection != null)
                {
                    if (connection.State !=
                        ConnectionState.Closed)
                    {
                        connection.Close();
                    }

                    connection.Dispose();
                    connection = null;
                }

                server = nuevoServer;
                user = nuevoUser;
                password = nuevoPassword;
                pconexion = nuevaCadena;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public MySqlConnection GetConnection()
        {
            if (connection == null ||
                connection.State != ConnectionState.Open)
            {
                connection =
                    new MySqlConnection(pconexion);

                connection.Open();

                if (SesionIdUsuario > 0)
                {
                    using (MySqlCommand cmd =
                        new MySqlCommand(
                            @"SET
                                @bitacora_usuario = @uid,
                                @bitacora_pc = @pcid,
                                @bitacora_ip = @ip;",
                            connection
                        ))
                    {
                        cmd.Parameters.AddWithValue("@uid", SesionIdUsuario);

                        cmd.Parameters.AddWithValue("@pcid",(object)SesionIdNombrePc ?? DBNull.Value );

                        cmd.Parameters.AddWithValue("@ip", SesionIp ?? "0.0.0.0");

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            return connection;
        }
    }
}