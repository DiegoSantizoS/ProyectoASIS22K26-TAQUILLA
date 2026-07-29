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
           
            catch{ return peliculas; }

        
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


        /* fin de Codigo de Miguel David Contreras Jacinto con carnet: 0901-21-3878 en la
     * fecha de: 27/07/2026 */
    }
}
/* Fin de Codigo de Miguel David Contreras Jacinto con carnet: 0901-21-3878 en la
 * fecha de: 26/07/2026 */