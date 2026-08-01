/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Con_Admin
{
    public class If_Peliculas
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
                        p.id_genero,
                        g.nombre_genero,
                        p.id_tipo_pelicula,
                        t.nombre_tipo_pelicula,
                        p.director_pelicula,
                        p.trailer_pelicula,
                        p.imagen_pelicula,
                        p.estado_pelicula,
                        p.fecha_estreno
                FROM tbl_pelicula p
                LEFT JOIN tbl_clasificacion  c ON c.id_clasificacion = p.id_clasificacion
                LEFT JOIN tbl_genero         g ON g.id_genero        = p.id_genero
                LEFT JOIN tbl_tipo_pelicula  t ON t.id_tipo_pelicula = p.id_tipo_pelicula
                ORDER BY p.titulo_pelicula;";

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
                SELECT  p.id_pelicula,
                        p.titulo_pelicula,
                        p.duracion_pelicula,
                        p.id_clasificacion,
                        c.nombre_clasificacion,
                        p.id_genero,
                        g.nombre_genero,
                        p.id_tipo_pelicula,
                        t.nombre_tipo_pelicula,
                        p.director_pelicula,
                        p.trailer_pelicula,
                        p.imagen_pelicula,
                        p.estado_pelicula,
                        p.fecha_estreno
                FROM tbl_pelicula p
                LEFT JOIN tbl_clasificacion  c ON c.id_clasificacion = p.id_clasificacion
                LEFT JOIN tbl_genero         g ON g.id_genero        = p.id_genero
                LEFT JOIN tbl_tipo_pelicula  t ON t.id_tipo_pelicula = p.id_tipo_pelicula
                WHERE p.titulo_pelicula LIKE @texto
                   OR p.director_pelicula LIKE @texto
                ORDER BY p.titulo_pelicula;";

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

        public DataTable ObtenerPorId(int idPelicula)
        {
            const string sql = @"
                SELECT  p.id_pelicula,
                        p.titulo_pelicula,
                        p.duracion_pelicula,
                        p.id_clasificacion,
                        c.nombre_clasificacion,
                        p.id_genero,
                        g.nombre_genero,
                        p.id_tipo_pelicula,
                        t.nombre_tipo_pelicula,
                        p.director_pelicula,
                        p.trailer_pelicula,
                        p.imagen_pelicula,
                        p.estado_pelicula,
                        p.fecha_estreno
                FROM tbl_pelicula p
                LEFT JOIN tbl_clasificacion  c ON c.id_clasificacion = p.id_clasificacion
                LEFT JOIN tbl_genero         g ON g.id_genero        = p.id_genero
                LEFT JOIN tbl_tipo_pelicula  t ON t.id_tipo_pelicula = p.id_tipo_pelicula
                WHERE p.id_pelicula = @id
                LIMIT 1;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idPelicula);
                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        public int Insertar(string titulo, int duracion, int? idClasificacion, int? idGenero,
                            int? idTipoPelicula, string director, string trailer, string imagen,
                            string estado, DateTime? fechaEstreno)
        {
            const string sql = @"
                INSERT INTO tbl_pelicula
                    (titulo_pelicula, duracion_pelicula, id_clasificacion, id_genero,
                     id_tipo_pelicula, director_pelicula, trailer_pelicula,
                     imagen_pelicula, estado_pelicula, fecha_estreno)
                VALUES
                    (@titulo, @duracion, @clasificacion, @genero,
                     @tipo, @director, @trailer,
                     @imagen, @estado, @estreno);
                SELECT LAST_INSERT_ID();";

            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                CargarParametros(cmd, titulo, duracion, idClasificacion, idGenero,
                                  idTipoPelicula, director, trailer, imagen, estado, fechaEstreno);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool Actualizar(int idPelicula, string titulo, int duracion, int? idClasificacion,
                              int? idGenero, int? idTipoPelicula, string director, string trailer,
                              string imagen, string estado, DateTime? fechaEstreno)
        {
            const string sql = @"
                UPDATE tbl_pelicula SET
                    titulo_pelicula   = @titulo,
                    duracion_pelicula = @duracion,
                    id_clasificacion  = @clasificacion,
                    id_genero         = @genero,
                    id_tipo_pelicula  = @tipo,
                    director_pelicula = @director,
                    trailer_pelicula  = @trailer,
                    imagen_pelicula   = @imagen,
                    estado_pelicula   = @estado,
                    fecha_estreno     = @estreno
                WHERE id_pelicula = @id;";

            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                CargarParametros(cmd, titulo, duracion, idClasificacion, idGenero,
                                  idTipoPelicula, director, trailer, imagen, estado, fechaEstreno);
                cmd.Parameters.AddWithValue("@id", idPelicula);
                return cmd.ExecuteNonQuery() > 0;
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

        public DataTable ListarTiposPelicula()
        {
            return ListarCatalogo(
                "SELECT id_tipo_pelicula AS Id, nombre_tipo_pelicula AS Nombre " +
                "FROM tbl_tipo_pelicula ORDER BY id_tipo_pelicula;");
        }

        public DataTable ListarEstados()
        {
            var t = new DataTable();
            t.Columns.Add("Id", typeof(string));
            t.Columns.Add("Nombre", typeof(string));
            t.Rows.Add("cartelera", "En cartelera");
            t.Rows.Add("proximamente", "Próximamente");
            return t;
        }

        private DataTable ListarCatalogo(string sql)
        {
            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            using (var da = new MySqlDataAdapter(cmd))
            {
                da.Fill(tabla);
            }
            return tabla;
        }

        private void CargarParametros(MySqlCommand cmd, string titulo, int duracion, int? idClasificacion,
                                      int? idGenero, int? idTipoPelicula, string director, string trailer,
                                      string imagen, string estado, DateTime? fechaEstreno)
        {
            cmd.Parameters.AddWithValue("@titulo", titulo);
            cmd.Parameters.AddWithValue("@duracion", duracion);
            cmd.Parameters.AddWithValue("@clasificacion", (object)idClasificacion ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@genero", (object)idGenero ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@tipo", (object)idTipoPelicula ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@director", (object)director ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@trailer", (object)trailer ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@imagen", (object)imagen ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@estado", string.IsNullOrEmpty(estado) ? "proximamente" : estado);
            cmd.Parameters.AddWithValue("@estreno", (object)fechaEstreno ?? DBNull.Value);
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */
