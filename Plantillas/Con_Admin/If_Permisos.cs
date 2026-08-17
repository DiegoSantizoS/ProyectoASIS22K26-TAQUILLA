/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using clase_conexion;

namespace Con_Admin
{
    public class If_Permisos
    {
        private readonly conexion conexion = new conexion();

        private static readonly string[] Columnas =
        {
            "puede_mantenimiento", "puede_procesos",
            "puede_eliminar", "puede_registrar", "puede_modificar",
            "APL103", "APL104", "APL105", "APL106", "APL107",
            "APL108", "APL109", "APL110", "APL111", "APL112"
        };

        public DataTable ListarUsuarios()
        {
            const string sql = @"
                SELECT  u.id_usuario,
                        u.nombre_usuario,
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

        public DataTable ObtenerPermisos(int idUsuario)
        {
            const string sql = "SELECT * FROM permisos_usuario WHERE id_usuario = @id LIMIT 1;";

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

        public bool Guardar(int idUsuario, ICollection<string> columnasActivas)
        {
            var insertCols = new StringBuilder();
            var insertVals = new StringBuilder();
            var updateSet = new StringBuilder();

            foreach (string c in Columnas)
            {
                insertCols.Append(", ").Append(c);
                insertVals.Append(", @").Append(c);
                if (updateSet.Length > 0) updateSet.Append(", ");
                updateSet.Append(c).Append(" = @").Append(c);
            }

            string sql =
                "INSERT INTO permisos_usuario (id_usuario" + insertCols + ") " +
                "VALUES (@id" + insertVals + ") " +
                "ON DUPLICATE KEY UPDATE " + updateSet + ";";

            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idUsuario);
                foreach (string c in Columnas)
                    cmd.Parameters.AddWithValue("@" + c, columnasActivas.Contains(c) ? 1 : 0);
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public bool Eliminar(int idUsuario)
        {
            const string sql = "DELETE FROM permisos_usuario WHERE id_usuario = @id;";
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idUsuario);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */
