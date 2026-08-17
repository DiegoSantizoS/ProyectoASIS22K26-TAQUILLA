/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */
using System;
using System.Data;
using MySql.Data.MySqlClient;
using clase_conexion;

namespace Con_Admin
{
    public class If_Login
    {
        private readonly conexion conexion = new conexion();

        public DataTable ObtenerUsuario(string usuario, string contrasena)
        {
            const string sql = @"
                SELECT  u.id_usuario,
                        u.nombre_usuario,
                        u.id_perfil,
                        p.nombre_perfil
                FROM tbl_usuario u
                LEFT JOIN tbl_perfil p ON p.id_perfil = u.id_perfil
                WHERE u.nombre_usuario = @usuario
                  AND u.contrasena_usuario = SHA2(@contrasena, 256)
                LIMIT 1;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);
                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 31/07/2026 */
