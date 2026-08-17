/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */
using System;
using System.Data;
using MySql.Data.MySqlClient;
using clase_conexion;

namespace Con_Admin
{
    public class If_Peliculas
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
                  AND TABLE_NAME = 'tbl_pelicula';";

            using (var cmd = new MySqlCommand(sql, con))
            {
                object r = cmd.ExecuteScalar();
                return (r == null || r == DBNull.Value) ? 1 : Convert.ToInt32(r);
            }
        }

        public DataTable Listar()
        {
            const string sql = @"
                SELECT  p.id_pelicula,
                        p.titulo_pelicula,
                        p.duracion_pelicula,
                        p.id_clasificacion,
                        c.nombre_clasificacion,
                        p.id_estado_pelicula,
                        e.nombre_estado_pelicula,
                        p.director_pelicula,
                        p.descripcion_pelicula,
                        p.trailer_pelicula,
                        p.fecha_estreno
                FROM tbl_pelicula p
                LEFT JOIN tbl_clasificacion    c ON c.id_clasificacion   = p.id_clasificacion
                LEFT JOIN tbl_estado_pelicula  e ON e.id_estado_pelicula = p.id_estado_pelicula
                ORDER BY p.titulo_pelicula;";

            return Consultar(sql);
        }

        public DataTable Buscar(string texto)
        {
            const string sql = @"
                SELECT  p.id_pelicula,
                        p.titulo_pelicula,
                        p.duracion_pelicula,
                        p.id_clasificacion,
                        c.nombre_clasificacion,
                        p.id_estado_pelicula,
                        e.nombre_estado_pelicula,
                        p.director_pelicula,
                        p.descripcion_pelicula,
                        p.trailer_pelicula,
                        p.fecha_estreno
                FROM tbl_pelicula p
                LEFT JOIN tbl_clasificacion    c ON c.id_clasificacion   = p.id_clasificacion
                LEFT JOIN tbl_estado_pelicula  e ON e.id_estado_pelicula = p.id_estado_pelicula
                WHERE p.titulo_pelicula   LIKE @texto
                   OR p.director_pelicula LIKE @texto
                ORDER BY p.titulo_pelicula;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@texto", "%" + (texto ?? "") + "%");
                using (var da = new MySqlDataAdapter(cmd))
                    da.Fill(tabla);
            }
            return tabla;
        }

        public DataTable ObtenerPorId(int idPelicula)
        {
            const string sql = @"
                SELECT  p.id_pelicula,
                        p.titulo_pelicula,
                        p.duracion_pelicula,
                        p.id_clasificacion,
                        c.nombre_clasificacion,
                        p.id_estado_pelicula,
                        e.nombre_estado_pelicula,
                        p.director_pelicula,
                        p.descripcion_pelicula,
                        p.trailer_pelicula,
                        p.fecha_estreno
                FROM tbl_pelicula p
                LEFT JOIN tbl_clasificacion    c ON c.id_clasificacion   = p.id_clasificacion
                LEFT JOIN tbl_estado_pelicula  e ON e.id_estado_pelicula = p.id_estado_pelicula
                WHERE p.id_pelicula = @id
                LIMIT 1;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idPelicula);
                using (var da = new MySqlDataAdapter(cmd))
                    da.Fill(tabla);
            }
            return tabla;
        }

        public DataTable ListarGenerosDePelicula(int idPelicula)
        {
            const string sql = @"
                SELECT g.id_genero, g.nombre_genero
                FROM tbl_pelicula_genero pg
                JOIN tbl_genero g ON g.id_genero = pg.id_genero
                WHERE pg.id_pelicula = @id;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idPelicula);
                using (var da = new MySqlDataAdapter(cmd))
                    da.Fill(tabla);
            }
            return tabla;
        }

        public DataTable ListarFormatosDePelicula(int idPelicula)
        {
            const string sql = @"
                SELECT f.id_formato_pelicula, f.nombre_formato_pelicula
                FROM tbl_pelicula_formatopelicula pf
                JOIN tbl_formato_pelicula f ON f.id_formato_pelicula = pf.id_formato_pelicula
                WHERE pf.id_pelicula = @id;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idPelicula);
                using (var da = new MySqlDataAdapter(cmd))
                    da.Fill(tabla);
            }
            return tabla;
        }

        public int Insertar(string titulo, int duracion, int? idClasificacion, int idEstado,
                            string director, string descripcion, string trailer,
                            DateTime? fechaEstreno, int[] generos, int[] formatos)
        {
            const string sql = @"
                INSERT INTO tbl_pelicula
                    (titulo_pelicula, duracion_pelicula, id_clasificacion, id_estado_pelicula,
                     director_pelicula, descripcion_pelicula, trailer_pelicula, fecha_estreno)
                VALUES
                    (@titulo, @duracion, @clasificacion, @estado,
                     @director, @descripcion, @trailer, @estreno);
                SELECT LAST_INSERT_ID();";

            var con = conexion.GetConnection();
            using (var tx = con.BeginTransaction())
            {
                try
                {
                    int nuevoId;
                    using (var cmd = new MySqlCommand(sql, con, tx))
                    {
                        CargarParametros(cmd, titulo, duracion, idClasificacion, idEstado,
                                         director, descripcion, trailer, fechaEstreno);
                        nuevoId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    GuardarGeneros(con, tx, nuevoId, generos);
                    GuardarFormatos(con, tx, nuevoId, formatos);

                    tx.Commit();
                    return nuevoId;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        public bool Actualizar(int idPelicula, string titulo, int duracion, int? idClasificacion,
                              int idEstado, string director, string descripcion, string trailer,
                              DateTime? fechaEstreno, int[] generos, int[] formatos)
        {
            const string sql = @"
                UPDATE tbl_pelicula SET
                    titulo_pelicula      = @titulo,
                    duracion_pelicula    = @duracion,
                    id_clasificacion     = @clasificacion,
                    id_estado_pelicula   = @estado,
                    director_pelicula    = @director,
                    descripcion_pelicula = @descripcion,
                    trailer_pelicula     = @trailer,
                    fecha_estreno        = @estreno
                WHERE id_pelicula = @id;";

            var con = conexion.GetConnection();
            using (var tx = con.BeginTransaction())
            {
                try
                {
                    bool ok;
                    using (var cmd = new MySqlCommand(sql, con, tx))
                    {
                        CargarParametros(cmd, titulo, duracion, idClasificacion, idEstado,
                                         director, descripcion, trailer, fechaEstreno);
                        cmd.Parameters.AddWithValue("@id", idPelicula);
                        ok = cmd.ExecuteNonQuery() > 0;
                    }

                    BorrarRelaciones(con, tx, idPelicula);
                    GuardarGeneros(con, tx, idPelicula, generos);
                    GuardarFormatos(con, tx, idPelicula, formatos);

                    tx.Commit();
                    return ok;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        public bool Eliminar(int idPelicula)
        {
            const string sql = "DELETE FROM tbl_pelicula WHERE id_pelicula = @id;";
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idPelicula);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable ListarGeneros()
        {
            return ListarCatalogo(
                "SELECT id_genero AS Id, nombre_genero AS Nombre " +
                "FROM tbl_genero ORDER BY nombre_genero;");
        }

        public DataTable ListarClasificaciones()
        {
            return ListarCatalogo(
                "SELECT id_clasificacion AS Id, nombre_clasificacion AS Nombre " +
                "FROM tbl_clasificacion ORDER BY id_clasificacion;");
        }

        public DataTable ListarFormatos()
        {
            return ListarCatalogo(
                "SELECT id_formato_pelicula AS Id, nombre_formato_pelicula AS Nombre " +
                "FROM tbl_formato_pelicula ORDER BY id_formato_pelicula;");
        }

        public DataTable ListarEstados()
        {
            return ListarCatalogo(
                "SELECT id_estado_pelicula AS Id, nombre_estado_pelicula AS Nombre " +
                "FROM tbl_estado_pelicula ORDER BY id_estado_pelicula;");
        }

        private DataTable Consultar(string sql)
        {
            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            using (var da = new MySqlDataAdapter(cmd))
                da.Fill(tabla);
            return tabla;
        }

        private DataTable ListarCatalogo(string sql)
        {
            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            using (var da = new MySqlDataAdapter(cmd))
                da.Fill(tabla);
            return tabla;
        }

        private void GuardarGeneros(MySqlConnection con, MySqlTransaction tx, int idPelicula, int[] generos)
        {
            if (generos == null) return;
            foreach (int idGenero in generos)
            {
                using (var cmd = new MySqlCommand(
                    "INSERT INTO tbl_pelicula_genero (id_pelicula, id_genero) VALUES (@p, @g);", con, tx))
                {
                    cmd.Parameters.AddWithValue("@p", idPelicula);
                    cmd.Parameters.AddWithValue("@g", idGenero);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void GuardarFormatos(MySqlConnection con, MySqlTransaction tx, int idPelicula, int[] formatos)
        {
            if (formatos == null) return;
            foreach (int idFormato in formatos)
            {
                using (var cmd = new MySqlCommand(
                    "INSERT INTO tbl_pelicula_formatopelicula (id_pelicula, id_formato_pelicula) VALUES (@p, @f);", con, tx))
                {
                    cmd.Parameters.AddWithValue("@p", idPelicula);
                    cmd.Parameters.AddWithValue("@f", idFormato);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void BorrarRelaciones(MySqlConnection con, MySqlTransaction tx, int idPelicula)
        {
            using (var cmd = new MySqlCommand(
                "DELETE FROM tbl_pelicula_genero WHERE id_pelicula = @p;", con, tx))
            {
                cmd.Parameters.AddWithValue("@p", idPelicula);
                cmd.ExecuteNonQuery();
            }
            using (var cmd = new MySqlCommand(
                "DELETE FROM tbl_pelicula_formatopelicula WHERE id_pelicula = @p;", con, tx))
            {
                cmd.Parameters.AddWithValue("@p", idPelicula);
                cmd.ExecuteNonQuery();
            }
        }

        private void CargarParametros(MySqlCommand cmd, string titulo, int duracion, int? idClasificacion,
                                      int idEstado, string director, string descripcion, string trailer,
                                      DateTime? fechaEstreno)
        {
            cmd.Parameters.AddWithValue("@titulo", titulo);
            cmd.Parameters.AddWithValue("@duracion", duracion);
            cmd.Parameters.AddWithValue("@clasificacion", (object)idClasificacion ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@estado", idEstado);
            cmd.Parameters.AddWithValue("@director", (object)director ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@descripcion", (object)descripcion ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@trailer", (object)trailer ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@estreno", (object)fechaEstreno ?? DBNull.Value);
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */