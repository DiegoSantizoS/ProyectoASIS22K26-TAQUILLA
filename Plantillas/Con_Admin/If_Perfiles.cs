/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Con_Admin
{
    public class If_Perfiles
    {
        private readonly Conexion conexion = new Conexion();

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
                  AND TABLE_NAME = 'tbl_perfil';";

            using (var cmd = new MySqlCommand(sql, con))
            {
                object r = cmd.ExecuteScalar();
                return (r == null || r == DBNull.Value) ? 1 : Convert.ToInt32(r);
            }
        }

        public DataTable Listar()
        {
            const string sql = @"
                SELECT id_perfil, nombre_perfil
                FROM tbl_perfil
                ORDER BY nombre_perfil;";

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
                SELECT id_perfil, nombre_perfil
                FROM tbl_perfil
                WHERE nombre_perfil LIKE @texto
                ORDER BY nombre_perfil;";

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

        public DataTable ObtenerPorId(int idPerfil)
        {
            const string sql = @"
                SELECT id_perfil, nombre_perfil
                FROM tbl_perfil
                WHERE id_perfil = @id
                LIMIT 1;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idPerfil);
                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        public int Insertar(string nombrePerfil)
        {
            const string sql = @"
                INSERT INTO tbl_perfil (nombre_perfil)
                VALUES (@nombre);
                SELECT LAST_INSERT_ID();";

            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@nombre", nombrePerfil);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool Actualizar(int idPerfil, string nombrePerfil)
        {
            const string sql = @"
                UPDATE tbl_perfil SET
                    nombre_perfil = @nombre
                WHERE id_perfil = @id;";

            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@nombre", nombrePerfil);
                cmd.Parameters.AddWithValue("@id", idPerfil);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Eliminar(int idPerfil)
        {
            const string sql = "DELETE FROM tbl_perfil WHERE id_perfil = @id;";
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idPerfil);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  *
 * fecha de: 30/07/2026 */
