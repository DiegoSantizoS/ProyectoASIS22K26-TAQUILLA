/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la 
 * fecha de: 30/07/2026 */
using System;
using System.Data;
using MySql.Data.MySqlClient;
using clase_conexion;

namespace Con_Admin
{
    public class If_Usuarios
    {
        private readonly conexion conexion = new conexion();

        public int ObtenerSiguienteId()
        {
            var con = conexion.GetConnection();

            using (var reset = new MySqlCommand("SET SESSION information_schema_stats_expiry = 0;", con))
            {
                try { reset.ExecuteNonQuery(); }
                catch { }
            }

            const string sql = @"
                SELECT AUTO_INCREMENT
                FROM information_schema.TABLES
                WHERE TABLE_SCHEMA = DATABASE()
                  AND TABLE_NAME = 'tbl_usuario';";

            using (var cmd = new MySqlCommand(sql, con))
            {
                object r = cmd.ExecuteScalar();
                return (r == null || r == DBNull.Value) ? 1 : Convert.ToInt32(r);
            }
        }

        public DataTable Listar()
        {
            const string sql = @"
                SELECT  u.id_usuario,
                        u.nombre_usuario,
                        u.id_perfil,
                        p.nombre_perfil
                FROM tbl_usuario u
                LEFT JOIN tbl_perfil p ON p.id_perfil = u.id_perfil
                ORDER BY u.nombre_usuario;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            using (var da = new MySqlDataAdapter(cmd))
            {
                da.Fill(tabla);
            }
            return tabla;
        }

        public DataTable Buscar(string texto)
        {
            const string sql = @"
                SELECT  u.id_usuario,
                        u.nombre_usuario,
                        u.id_perfil,
                        p.nombre_perfil
                FROM tbl_usuario u
                LEFT JOIN tbl_perfil p ON p.id_perfil = u.id_perfil
                WHERE u.nombre_usuario LIKE @texto
                   OR p.nombre_perfil LIKE @texto
                ORDER BY u.nombre_usuario;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@texto", "%" + (texto ?? "") + "%");
                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        public DataTable ObtenerPorId(int idUsuario)
        {
            const string sql = @"
                SELECT  u.id_usuario,
                        u.nombre_usuario,
                        u.id_perfil,
                        p.nombre_perfil
                FROM tbl_usuario u
                LEFT JOIN tbl_perfil p ON p.id_perfil = u.id_perfil
                WHERE u.id_usuario = @id
                LIMIT 1;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idUsuario);
                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        public int Insertar(int idPerfil, string nombreUsuario, string contrasena)
        {
            const string sql = @"
                INSERT INTO tbl_usuario (id_perfil, nombre_usuario, contrasena_usuario)
                VALUES (@perfil, @usuario, SHA2(@contrasena, 256));
                SELECT LAST_INSERT_ID();";

            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@perfil", idPerfil);
                cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool Actualizar(int idUsuario, int idPerfil, string nombreUsuario, string contrasena)
        {
            bool cambiarContrasena = !string.IsNullOrEmpty(contrasena);

            string sql = cambiarContrasena
                ? @"UPDATE tbl_usuario SET
                        id_perfil = @perfil,
                        nombre_usuario = @usuario,
                        contrasena_usuario = SHA2(@contrasena, 256)
                    WHERE id_usuario = @id;"
                : @"UPDATE tbl_usuario SET
                        id_perfil = @perfil,
                        nombre_usuario = @usuario
                    WHERE id_usuario = @id;";

            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@perfil", idPerfil);
                cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
                if (cambiarContrasena)
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                cmd.Parameters.AddWithValue("@id", idUsuario);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Eliminar(int idUsuario)
        {
            const string sql = "DELETE FROM tbl_usuario WHERE id_usuario = @id;";
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idUsuario);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable ListarPerfiles()
        {
            const string sql = "SELECT id_perfil AS Id, nombre_perfil AS Nombre FROM tbl_perfil ORDER BY nombre_perfil;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            using (var da = new MySqlDataAdapter(cmd))
            {
                da.Fill(tabla);
            }
            return tabla;
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 30/07/2026 */
