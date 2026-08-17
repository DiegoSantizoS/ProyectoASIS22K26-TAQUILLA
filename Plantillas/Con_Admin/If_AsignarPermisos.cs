/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 05/08/2026 */

using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using clase_conexion;

namespace Con_Admin
{
    public class If_AsignarPermisos
    {
        private readonly conexion conexion = new conexion();

        public DataTable ListarPerfiles()
        {
            const string sql = @"
                SELECT id_perfil AS Id,
                       nombre_perfil AS Nombre
                FROM tbl_perfil
                WHERE LOWER(nombre_perfil) <> 'admin'
                ORDER BY nombre_perfil;";

            return Consultar(sql);
        }

        public DataTable ListarAcciones()
        {
            const string sql = @"
                SELECT id_accion_permiso AS Id,
                       nombre_accion_permiso AS Nombre
                FROM tbl_accion_permiso
                ORDER BY nombre_accion_permiso;";

            return Consultar(sql);
        }

        public DataTable ListarAplicaciones()
        {
            const string sql = @"
                SELECT id_aplicacion AS Id,
                       nombre_aplicacion AS Nombre
                FROM tbl_aplicacion
                ORDER BY nombre_aplicacion;";

            return Consultar(sql);
        }

        public DataTable ListarPermisosPerfil(int idPerfil)
        {
            const string sql = @"
                SELECT
                    ap.id_aplicacion AS Id,
                    ap.nombre_aplicacion AS Nombre,

                    EXISTS(
                        SELECT 1
                        FROM tbl_perfil_permiso pp
                        JOIN tbl_permiso pm
                            ON pm.id_permiso = pp.id_permiso
                        JOIN tbl_accion_permiso ac
                            ON ac.id_accion_permiso = pm.id_accion_permiso
                        WHERE pp.id_perfil = @perfil
                          AND pm.id_aplicacion = ap.id_aplicacion
                          AND LOWER(ac.nombre_accion_permiso) = 'mantenimiento'
                    ) AS Mantenimiento,

                    EXISTS(
                        SELECT 1
                        FROM tbl_perfil_permiso pp
                        JOIN tbl_permiso pm
                            ON pm.id_permiso = pp.id_permiso
                        JOIN tbl_accion_permiso ac
                            ON ac.id_accion_permiso = pm.id_accion_permiso
                        WHERE pp.id_perfil = @perfil
                          AND pm.id_aplicacion = ap.id_aplicacion
                          AND LOWER(ac.nombre_accion_permiso) = 'registrar'
                    ) AS Registrar,

                    EXISTS(
                        SELECT 1
                        FROM tbl_perfil_permiso pp
                        JOIN tbl_permiso pm
                            ON pm.id_permiso = pp.id_permiso
                        JOIN tbl_accion_permiso ac
                            ON ac.id_accion_permiso = pm.id_accion_permiso
                        WHERE pp.id_perfil = @perfil
                          AND pm.id_aplicacion = ap.id_aplicacion
                          AND LOWER(ac.nombre_accion_permiso) = 'eliminar'
                    ) AS Eliminar,

                    EXISTS(
                        SELECT 1
                        FROM tbl_perfil_permiso pp
                        JOIN tbl_permiso pm
                            ON pm.id_permiso = pp.id_permiso
                        JOIN tbl_accion_permiso ac
                            ON ac.id_accion_permiso = pm.id_accion_permiso
                        WHERE pp.id_perfil = @perfil
                          AND pm.id_aplicacion = ap.id_aplicacion
                          AND LOWER(ac.nombre_accion_permiso) = 'modificar'
                    ) AS Modificar

                FROM tbl_aplicacion ap
                ORDER BY ap.nombre_aplicacion;";

            return Consultar(
                sql,
                new MySqlParameter("@perfil", idPerfil)
            );
        }

        public void ActualizarPermisosPerfil(
            int idPerfil,
            IEnumerable<int> mantenimiento,
            IEnumerable<int> registrar,
            IEnumerable<int> eliminar,
            IEnumerable<int> modificar)
        {
            var con = conexion.GetConnection();

            using (var transaccion = con.BeginTransaction())
            {
                try
                {
                    const string validarPerfil = @"
                        SELECT COUNT(*)
                        FROM tbl_perfil
                        WHERE id_perfil = @perfil
                          AND LOWER(nombre_perfil) <> 'admin';";

                    using (var cmd = new MySqlCommand(
                        validarPerfil,
                        con,
                        transaccion))
                    {
                        cmd.Parameters.AddWithValue(
                            "@perfil",
                            idPerfil
                        );

                        if (Convert.ToInt32(
                            cmd.ExecuteScalar()) == 0)
                        {
                            throw new Exception(
                                "El perfil seleccionado no es válido."
                            );
                        }
                    }

                    const string eliminarActuales = @"
                        DELETE pp
                        FROM tbl_perfil_permiso pp
                        JOIN tbl_permiso pm
                            ON pm.id_permiso = pp.id_permiso
                        JOIN tbl_accion_permiso ac
                            ON ac.id_accion_permiso =
                               pm.id_accion_permiso
                        WHERE pp.id_perfil = @perfil
                          AND LOWER(ac.nombre_accion_permiso)
                              IN (
                                  'mantenimiento',
                                  'registrar',
                                  'eliminar',
                                  'modificar'
                              );";

                    using (var cmd = new MySqlCommand(
                        eliminarActuales,
                        con,
                        transaccion))
                    {
                        cmd.Parameters.AddWithValue(
                            "@perfil",
                            idPerfil
                        );

                        cmd.ExecuteNonQuery();
                    }

                    AsignarLista(
                        con,
                        transaccion,
                        idPerfil,
                        ObtenerIdAccion(
                            con,
                            transaccion,
                            "mantenimiento"
                        ),
                        mantenimiento
                    );

                    AsignarLista(
                        con,
                        transaccion,
                        idPerfil,
                        ObtenerIdAccion(
                            con,
                            transaccion,
                            "registrar"
                        ),
                        registrar
                    );

                    AsignarLista(
                        con,
                        transaccion,
                        idPerfil,
                        ObtenerIdAccion(
                            con,
                            transaccion,
                            "eliminar"
                        ),
                        eliminar
                    );

                    AsignarLista(
                        con,
                        transaccion,
                        idPerfil,
                        ObtenerIdAccion(
                            con,
                            transaccion,
                            "modificar"
                        ),
                        modificar
                    );

                    transaccion.Commit();
                }
                catch
                {
                    transaccion.Rollback();
                    throw;
                }
            }
        }

        private void AsignarLista(
            MySqlConnection con,
            MySqlTransaction transaccion,
            int idPerfil,
            int idAccion,
            IEnumerable<int> aplicaciones)
        {
            if (aplicaciones == null)
                return;

            foreach (int idAplicacion in aplicaciones)
            {
                int idPermiso = ObtenerOCrearPermiso(
                    con,
                    transaccion,
                    idAccion,
                    idAplicacion
                );

                const string sql = @"
                    INSERT IGNORE INTO tbl_perfil_permiso
                        (id_perfil, id_permiso)
                    VALUES
                        (@perfil, @permiso);";

                using (var cmd = new MySqlCommand(
                    sql,
                    con,
                    transaccion))
                {
                    cmd.Parameters.AddWithValue(
                        "@perfil",
                        idPerfil
                    );

                    cmd.Parameters.AddWithValue(
                        "@permiso",
                        idPermiso
                    );

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private int ObtenerIdAccion(
            MySqlConnection con,
            MySqlTransaction transaccion,
            string nombre)
        {
            const string sql = @"
                SELECT id_accion_permiso
                FROM tbl_accion_permiso
                WHERE LOWER(nombre_accion_permiso) =
                      LOWER(@nombre)
                LIMIT 1;";

            using (var cmd = new MySqlCommand(
                sql,
                con,
                transaccion))
            {
                cmd.Parameters.AddWithValue(
                    "@nombre",
                    nombre
                );

                object resultado = cmd.ExecuteScalar();

                if (resultado == null ||
                    resultado == DBNull.Value)
                {
                    throw new Exception(
                        "No existe la acción: " + nombre
                    );
                }

                return Convert.ToInt32(resultado);
            }
        }

        private int ObtenerOCrearPermiso(
            MySqlConnection con,
            MySqlTransaction transaccion,
            int idAccion,
            int idAplicacion)
        {
            const string buscar = @"
                SELECT id_permiso
                FROM tbl_permiso
                WHERE id_accion_permiso = @accion
                  AND id_aplicacion = @aplicacion
                LIMIT 1;";

            using (var cmd = new MySqlCommand(
                buscar,
                con,
                transaccion))
            {
                cmd.Parameters.AddWithValue(
                    "@accion",
                    idAccion
                );

                cmd.Parameters.AddWithValue(
                    "@aplicacion",
                    idAplicacion
                );

                object resultado = cmd.ExecuteScalar();

                if (resultado != null &&
                    resultado != DBNull.Value)
                {
                    return Convert.ToInt32(resultado);
                }
            }

            const string crear = @"
                INSERT INTO tbl_permiso
                    (id_accion_permiso, id_aplicacion)
                VALUES
                    (@accion, @aplicacion);";

            using (var cmd = new MySqlCommand(
                crear,
                con,
                transaccion))
            {
                cmd.Parameters.AddWithValue(
                    "@accion",
                    idAccion
                );

                cmd.Parameters.AddWithValue(
                    "@aplicacion",
                    idAplicacion
                );

                cmd.ExecuteNonQuery();

                return Convert.ToInt32(
                    cmd.LastInsertedId
                );
            }
        }

        private DataTable Consultar(
            string sql,
            params MySqlParameter[] parametros)
        {
            var tabla = new DataTable();
            var con = conexion.GetConnection();

            using (var cmd = new MySqlCommand(sql, con))
            {
                if (parametros != null)
                    cmd.Parameters.AddRange(parametros);

                using (var da =
                    new MySqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }

            return tabla;
        }

        public int ContarPermisos(
            string perfil,
            string aplicacion,
            string accion = null)
        {
            var con = conexion.GetConnection();

            string sql = @"
                SELECT COUNT(*)
                FROM tbl_perfil_permiso pp
                JOIN tbl_perfil pe
                    ON pe.id_perfil = pp.id_perfil
                JOIN tbl_permiso pm
                    ON pm.id_permiso = pp.id_permiso
                JOIN tbl_aplicacion ap
                    ON ap.id_aplicacion =
                       pm.id_aplicacion
                JOIN tbl_accion_permiso ac
                    ON ac.id_accion_permiso =
                       pm.id_accion_permiso
                WHERE LOWER(pe.nombre_perfil) =
                      LOWER(@perfil)
                  AND (
                      LOWER(ap.nombre_aplicacion) =
                      LOWER(@app)
                      OR
                      LOWER(ap.codigo_aplicacion) =
                      LOWER(@app)
                  )";

            if (!string.IsNullOrWhiteSpace(accion))
            {
                sql += @"
                    AND LOWER(ac.nombre_accion_permiso) =
                        LOWER(@accion)";
            }

            sql += ";";

            using (var cmd =
                new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue(
                    "@perfil",
                    perfil ?? ""
                );

                cmd.Parameters.AddWithValue(
                    "@app",
                    aplicacion ?? ""
                );

                if (!string.IsNullOrWhiteSpace(accion))
                {
                    cmd.Parameters.AddWithValue(
                        "@accion",
                        accion
                    );
                }

                return Convert.ToInt32(
                    cmd.ExecuteScalar()
                );
            }
        }
    }
}

/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 16/08/2026 */