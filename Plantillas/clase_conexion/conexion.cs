using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
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
        private MySqlConnection connecion;
        private String server = "localhost";
        private String datebase = "taquillas_cine";
        private String user = "root";
        private String password = "root";
        private String pconexion;
        public conexion()
        {
            pconexion = "Server=" + server +
               ";Database=" + datebase +
               ";Uid=" + user +
               ";Pwd=" + password + ";"; ;

        }

        public MySqlConnection GetConnection()
        {
            if (connecion == null)
            {
                connecion = new MySqlConnection(pconexion);
                connecion.Open();

            }
            return connecion;
        }

        /* Inicio de Codigo de Miguel David Contreras Jacinto con carnet: 0901-21-3878 en la
         * fecha de: 27/07/2026 */

        public DataTable mostrarpelicula()
        {
            DataTable peliculas = new DataTable();

            try
            {
                MySqlConnection con = GetConnection();

                string consulta = @"
            SELECT
                p.titulo_pelicula AS Titulo,
                p.duracion_pelicula AS Duracion,
                p.clasificacion_pelicula AS Clasificacion,
                g.nombre_genero AS Genero,
                p.fecha_estreno AS `Fecha de estreno`
            FROM PELICULA p
            LEFT JOIN GENERO g
                ON p.id_genero = g.id_genero
            ORDER BY p.titulo_pelicula";

                MySqlCommand cmd = new MySqlCommand(consulta, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(peliculas);

                return peliculas;

            }

            catch { return peliculas; }


        }

        public DataTable mostrarciudades()
        {
            DataTable ciudades = new DataTable();

            MySqlConnection con = GetConnection();

            string consulta = @"SELECT 
                    id_ciudad,
                    nombre_ciudad
                    FROM CIUDAD 
                    ORDER BY nombre_ciudad";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ciudades);

            return ciudades;
        }


        public DataTable mostrarcines(int idCiudad)
        {
            DataTable cines = new DataTable();

            MySqlConnection con = GetConnection();

            string consulta = @"SELECT 
                        id_cine,
                        nombre_cine
                        FROM CINE
                        WHERE id_ciudad = @idCiudad
                        ORDER BY nombre_cine";

            MySqlCommand cmd = new MySqlCommand(consulta, con);

            cmd.Parameters.AddWithValue("@idCiudad", idCiudad);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(cines);

            return cines;
        }


        public DataTable FiltrarCartelera(int idCiudad, int idCine, int idTipo)
        {
            DataTable tabla = new DataTable();

            try
            {
                MySqlConnection con = GetConnection();

                string consulta = @"
        SELECT
            p.titulo_pelicula AS Titulo,
            p.duracion_pelicula AS Duracion,
            p.clasificacion_pelicula AS Clasificacion,
            g.nombre_genero AS Genero,
            p.fecha_estreno AS 'Fecha de Estreno'
        FROM CARTELERA ca

        INNER JOIN CINE c
            ON ca.id_cine = c.id_cine

        INNER JOIN CIUDAD ci
            ON c.id_ciudad = ci.id_ciudad

        INNER JOIN PELICULA p
            ON ca.id_pelicula = p.id_pelicula

        INNER JOIN GENERO g
            ON p.id_genero = g.id_genero

        WHERE
            ci.id_ciudad = @ciudad
            AND c.id_cine = @cine
            AND p.id_tipo_pelicula = @tipo

        ORDER BY p.titulo_pelicula;";

                MySqlCommand cmd = new MySqlCommand(consulta, con);

                cmd.Parameters.AddWithValue("@ciudad", idCiudad);
                cmd.Parameters.AddWithValue("@cine", idCine);
                cmd.Parameters.AddWithValue("@tipo", idTipo);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(tabla);

                return tabla;
            }
            catch
            {

                return tabla;
            }
        }
        public DataTable mostrarGeneros()
        {
            DataTable generos = new DataTable();

            MySqlConnection con = GetConnection();

            string consulta = @"SELECT 
                            id_genero,
                            nombre_genero
                            FROM GENERO
                            ORDER BY nombre_genero";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(generos);

            return generos;
        }

        public DataTable mostrarTipoPelicula()
        {
            DataTable formatos = new DataTable();

            MySqlConnection con = GetConnection();

            string consulta = @"SELECT 
                    id_tipo_pelicula,
                    nombre_tipo_pelicula
                    FROM TIPO_PELICULA
                    ORDER BY id_tipo_pelicula";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(formatos);

            return formatos;
        }

        public DataTable mostrarCartelera(string nombre = "", int idGenero = 0, int idTipoPelicula = 0, int id = 0)
        {
            DataTable dt = new DataTable();

            MySqlConnection con = GetConnection();

            string consulta = @"
                SELECT
                    p.id_pelicula           AS ID,
                    p.titulo_pelicula       AS Nombre,
                    tp.nombre_tipo_pelicula AS Formato,
                    g.nombre_genero         AS Generos,
                    p.fecha_estreno         AS FechaEstreno
                FROM PELICULA p
                LEFT JOIN GENERO g          ON g.id_genero = p.id_genero
                LEFT JOIN TIPO_PELICULA tp  ON tp.id_tipo_pelicula = p.id_tipo_pelicula
                WHERE 1 = 1";

            if (id > 0)
                consulta += " AND p.id_pelicula = @id";
            if (!string.IsNullOrWhiteSpace(nombre))
                consulta += " AND p.titulo_pelicula LIKE @nombre";
            if (idGenero > 0)
                consulta += " AND p.id_genero = @idGenero";
            if (idTipoPelicula > 0)
                consulta += " AND p.id_tipo_pelicula = @idTipoPelicula";

            consulta += " ORDER BY p.fecha_estreno";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            if (id > 0) cmd.Parameters.AddWithValue("@id", id);
            if (!string.IsNullOrWhiteSpace(nombre)) cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
            if (idGenero > 0) cmd.Parameters.AddWithValue("@idGenero", idGenero);
            if (idTipoPelicula > 0) cmd.Parameters.AddWithValue("@idTipoPelicula", idTipoPelicula);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }

        public int insertarPelicula(
                        string titulo,
                        int duracion,
                        string clasificacion,
                        int idGenero,
                        int idTipoPelicula,
                        string director,
                        string trailer,
                        string estado,
                        DateTime fechaEstreno)
        {
            MySqlConnection con = GetConnection();

            string consulta = @"
        INSERT INTO PELICULA
            (titulo_pelicula, duracion_pelicula, clasificacion_pelicula,
             id_genero, id_tipo_pelicula, director_pelicula, trailer_pelicula,
             estado_pelicula, fecha_estreno)
        VALUES
            (@titulo, @duracion, @clasificacion,
             @idGenero, @idTipoPelicula, @director, @trailer,
             @estado, @fechaEstreno)";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@titulo", titulo);
            cmd.Parameters.AddWithValue("@duracion", duracion);
            cmd.Parameters.AddWithValue("@clasificacion", clasificacion);
            cmd.Parameters.AddWithValue("@idGenero", idGenero);
            cmd.Parameters.AddWithValue("@idTipoPelicula", idTipoPelicula);
            cmd.Parameters.AddWithValue("@director", director);
            cmd.Parameters.AddWithValue("@trailer", trailer);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@fechaEstreno", fechaEstreno);

            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }

        public int siguienteIdPelicula()
        {
            MySqlConnection con = GetConnection();

            string consulta = "SELECT IFNULL(MAX(id_pelicula), 0) + 1 FROM PELICULA";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            object resultado = cmd.ExecuteScalar();

            return Convert.ToInt32(resultado);
        }

        public DataTable obtenerPelicula(int id)
        {
            DataTable dt = new DataTable();

            MySqlConnection con = GetConnection();

            string consulta = @"SELECT 
                    id_pelicula,
                    titulo_pelicula,
                    duracion_pelicula,
                    clasificacion_pelicula,
                    id_genero,
                    id_tipo_pelicula,
                    director_pelicula,
                    trailer_pelicula,
                    estado_pelicula,
                    fecha_estreno
                    FROM PELICULA
                    WHERE id_pelicula = @id";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }

        public void actualizarPelicula(
                            int id, string titulo, int duracion, string clasificacion,
                            int idGenero, int idTipoPelicula, string director, string trailer,
                            string estado, DateTime fechaEstreno)
        {
            MySqlConnection con = GetConnection();

            string consulta = @"
        UPDATE PELICULA SET
            titulo_pelicula        = @titulo,
            duracion_pelicula      = @duracion,
            clasificacion_pelicula = @clasificacion,
            id_genero              = @idGenero,
            id_tipo_pelicula       = @idTipoPelicula,
            director_pelicula      = @director,
            trailer_pelicula       = @trailer,
            estado_pelicula        = @estado,
            fecha_estreno          = @fechaEstreno
        WHERE id_pelicula = @id";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@titulo", titulo);
            cmd.Parameters.AddWithValue("@duracion", duracion);
            cmd.Parameters.AddWithValue("@clasificacion", clasificacion);
            cmd.Parameters.AddWithValue("@idGenero", idGenero);
            cmd.Parameters.AddWithValue("@idTipoPelicula", idTipoPelicula);
            cmd.Parameters.AddWithValue("@director", director);
            cmd.Parameters.AddWithValue("@trailer", trailer);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@fechaEstreno", fechaEstreno);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }

        // FUNCIONES

        public DataTable mostrarPeliculasCombo()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = GetConnection();

            string consulta = @"SELECT id_pelicula, titulo_pelicula
                        FROM PELICULA
                        ORDER BY titulo_pelicula";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }

        public DataTable mostrarSalasCombo()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = GetConnection();

            string consulta = @"SELECT 
                            s.id_sala,
                            CONCAT('Sala ', s.numero_sala, ' - ', c.nombre_cine) AS descripcion_sala,
                            s.id_tipo_sala
                        FROM SALA s
                        JOIN CINE c ON c.id_cine = s.id_cine
                        ORDER BY c.nombre_cine, s.numero_sala";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }


        public DataTable obtenerPeliculaParaFuncion(int idPelicula)
        {
            DataTable dt = new DataTable();
            MySqlConnection con = GetConnection();

            string consulta = @"SELECT 
                            p.id_pelicula,
                            p.titulo_pelicula,
                            p.duracion_pelicula,
                            p.imagen_pelicula,
                            tp.nombre_tipo_pelicula AS formato
                        FROM PELICULA p
                        LEFT JOIN TIPO_PELICULA tp ON tp.id_tipo_pelicula = p.id_tipo_pelicula
                        WHERE p.id_pelicula = @id";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@id", idPelicula);
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }


        public int tipoFuncionPorSala(int idSala)
        {
            MySqlConnection con = GetConnection();

            string consulta = @"SELECT tf.id_tipo_funcion
                        FROM SALA s
                        JOIN TIPO_SALA ts   ON ts.id_tipo_sala = s.id_tipo_sala
                        JOIN TIPO_FUNCION tf ON tf.nombre_tipo_funcion = 
                             SUBSTRING_INDEX(ts.nombre_tipo_sala, '/', 1)
                        WHERE s.id_sala = @idSala
                        LIMIT 1";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@idSala", idSala);
            object r = cmd.ExecuteScalar();
            return (r != null && r != DBNull.Value) ? Convert.ToInt32(r) : 1;
        }

        public int insertarFuncion(int idPelicula, int idSala, int idTipoFuncion,
                                   DateTime fecha, TimeSpan hora, decimal precio)
        {
            MySqlConnection con = GetConnection();

            string consulta = @"
        INSERT INTO FUNCION
            (id_pelicula, id_sala, id_tipo_funcion, fecha_funcion, hora_funcion, precio_funcion)
        VALUES
            (@idPelicula, @idSala, @idTipoFuncion, @fecha, @hora, @precio)";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@idPelicula", idPelicula);
            cmd.Parameters.AddWithValue("@idSala", idSala);
            cmd.Parameters.AddWithValue("@idTipoFuncion", idTipoFuncion);
            cmd.Parameters.AddWithValue("@fecha", fecha.Date);
            cmd.Parameters.AddWithValue("@hora", hora);
            cmd.Parameters.AddWithValue("@precio", precio);

            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }


        public void actualizarFuncion(int idFuncion, int idPelicula, int idSala, int idTipoFuncion,
                                      DateTime fecha, TimeSpan hora, decimal precio)
        {
            MySqlConnection con = GetConnection();

            string consulta = @"
        UPDATE FUNCION SET
            id_pelicula     = @idPelicula,
            id_sala         = @idSala,
            id_tipo_funcion = @idTipoFuncion,
            fecha_funcion   = @fecha,
            hora_funcion    = @hora,
            precio_funcion  = @precio
        WHERE id_funcion = @idFuncion";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@idPelicula", idPelicula);
            cmd.Parameters.AddWithValue("@idSala", idSala);
            cmd.Parameters.AddWithValue("@idTipoFuncion", idTipoFuncion);
            cmd.Parameters.AddWithValue("@fecha", fecha.Date);
            cmd.Parameters.AddWithValue("@hora", hora);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.Parameters.AddWithValue("@idFuncion", idFuncion);

            cmd.ExecuteNonQuery();
        }

        public void eliminarFuncion(int idFuncion)
        {
            MySqlConnection con = GetConnection();

            string consulta = "DELETE FROM FUNCION WHERE id_funcion = @id";
            MySqlCommand cmd = new MySqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@id", idFuncion);
            cmd.ExecuteNonQuery();
        }

        public DataTable mostrarFunciones()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = GetConnection();

            string consulta = @"
        SELECT
            f.id_funcion            AS ID,
            p.titulo_pelicula       AS Pelicula,
            tf.nombre_tipo_funcion  AS Formato,
            s.numero_sala           AS Sala,
            ts.nombre_tipo_sala     AS TipoSala,
            f.precio_funcion        AS Precio,
            f.fecha_funcion         AS Fecha,
            f.hora_funcion          AS Hora
        FROM FUNCION f
        JOIN PELICULA p     ON p.id_pelicula = f.id_pelicula
        JOIN SALA s         ON s.id_sala = f.id_sala
        JOIN TIPO_SALA ts   ON ts.id_tipo_sala = s.id_tipo_sala
        JOIN TIPO_FUNCION tf ON tf.id_tipo_funcion = f.id_tipo_funcion
        ORDER BY f.fecha_funcion, f.hora_funcion";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }


        public DataTable horasDeSala(int idSala, DateTime fecha)
        {
            DataTable dt = new DataTable();
            MySqlConnection con = GetConnection();

            string consulta = @"SELECT hora_funcion AS Hora
                        FROM FUNCION
                        WHERE id_sala = @idSala AND fecha_funcion = @fecha
                        ORDER BY hora_funcion";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@idSala", idSala);
            cmd.Parameters.AddWithValue("@fecha", fecha.Date);
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }



        // SALAS

        public DataTable mostrarCiudades()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = GetConnection();
            string q = "SELECT id_ciudad, nombre_ciudad FROM CIUDAD ORDER BY nombre_ciudad";
            new MySqlDataAdapter(new MySqlCommand(q, con)).Fill(dt);
            return dt;
        }

        public DataTable mostrarCinesPorCiudad(int idCiudad)
        {
            DataTable dt = new DataTable();
            MySqlConnection con = GetConnection();
            string q = @"SELECT id_cine, nombre_cine FROM CINE
                 WHERE id_ciudad = @idCiudad ORDER BY nombre_cine";
            MySqlCommand cmd = new MySqlCommand(q, con);
            cmd.Parameters.AddWithValue("@idCiudad", idCiudad);
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }

        public DataTable mostrarTiposSala()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = GetConnection();
            string q = "SELECT id_tipo_sala, nombre_tipo_sala FROM TIPO_SALA ORDER BY id_tipo_sala";
            new MySqlDataAdapter(new MySqlCommand(q, con)).Fill(dt);
            return dt;
        }

        public DataTable mostrarSalas()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = GetConnection();
            string q = @"
        SELECT
            s.id_sala        AS ID,
            s.numero_sala    AS Numero,
            s.capacidad_sala AS Capacidad,
            ts.nombre_tipo_sala AS Tipo,
            c.nombre_cine    AS Cine,
            ci.nombre_ciudad AS Ciudad
        FROM SALA s
        JOIN TIPO_SALA ts ON ts.id_tipo_sala = s.id_tipo_sala
        JOIN CINE c       ON c.id_cine = s.id_cine
        JOIN CIUDAD ci    ON ci.id_ciudad = c.id_ciudad
        ORDER BY ci.nombre_ciudad, c.nombre_cine, s.numero_sala";
            new MySqlDataAdapter(new MySqlCommand(q, con)).Fill(dt);
            return dt;
        }

        public int insertarSala(int numero, int capacidad, int idTipoSala, int idCine)
        {
            MySqlConnection con = GetConnection();
            string q = @"INSERT INTO SALA (numero_sala, capacidad_sala, id_tipo_sala, id_cine)
                 VALUES (@numero, @capacidad, @idTipoSala, @idCine)";
            MySqlCommand cmd = new MySqlCommand(q, con);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@capacidad", capacidad);
            cmd.Parameters.AddWithValue("@idTipoSala", idTipoSala);
            cmd.Parameters.AddWithValue("@idCine", idCine);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }

        public void actualizarSala(int idSala, int numero, int capacidad, int idTipoSala, int idCine)
        {
            MySqlConnection con = GetConnection();
            string q = @"UPDATE SALA SET
                    numero_sala   = @numero,
                    capacidad_sala= @capacidad,
                    id_tipo_sala  = @idTipoSala,
                    id_cine       = @idCine
                 WHERE id_sala = @idSala";
            MySqlCommand cmd = new MySqlCommand(q, con);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@capacidad", capacidad);
            cmd.Parameters.AddWithValue("@idTipoSala", idTipoSala);
            cmd.Parameters.AddWithValue("@idCine", idCine);
            cmd.Parameters.AddWithValue("@idSala", idSala);
            cmd.ExecuteNonQuery();
        }

        public void eliminarSala(int idSala)
        {
            MySqlConnection con = GetConnection();
            string q = "DELETE FROM SALA WHERE id_sala = @id";
            MySqlCommand cmd = new MySqlCommand(q, con);
            cmd.Parameters.AddWithValue("@id", idSala);
            cmd.ExecuteNonQuery();
        }

        public DataTable obtenerSala(int idSala)
        {
            DataTable dt = new DataTable();
            MySqlConnection con = GetConnection();
            string q = @"SELECT s.id_sala, s.numero_sala, s.capacidad_sala,
                        s.id_tipo_sala, s.id_cine, c.id_ciudad
                 FROM SALA s
                 JOIN CINE c ON c.id_cine = s.id_cine
                 WHERE s.id_sala = @id";
            MySqlCommand cmd = new MySqlCommand(q, con);
            cmd.Parameters.AddWithValue("@id", idSala);
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;


            /* fin de Codigo de Miguel David Contreras Jacinto con carnet: 0901-21-3878 en la
         * fecha de: 27/07/2026 */
        }
    }
}
/* Fin de Codigo de Miguel David Contreras Jacinto con carnet: 0901-21-3878 en la
 * fecha de: 26/07/2026 */