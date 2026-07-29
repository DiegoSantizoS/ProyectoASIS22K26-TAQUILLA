using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantilla_Cliente
{
    internal class Conexion
    {
        private MySqlConnection connecion;
        private String server = "localhost";
        private String datebase = "taquillas_cine";
        private String user = "root";
        private String password = "Root";
        private String pconexion;
        public Conexion()
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
        public DataTable mostrarpelicula()
        {
            DataTable peliculas = new DataTable();

            try
            {
                MySqlConnection con = GetConnection();

                string consulta = @"
            SELECT
                p.id_pelicula AS IdPelicula,
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
            p.id_pelicula AS IdPelicula,
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
        /*Inicio de código de Carlos Andres Arriaza Lara 0901-23-13862 el 27/07/2026*/
        public DataTable infopelicula(int idPelicula)
        {
            DataTable peliculas = new DataTable();

            MySqlConnection con = GetConnection();

            string consulta = @"SELECT 
                        director_pelicula,
                        duracion_pelicula,
                        clasificacion_pelicula
                        FROM PELICULA
                        WHERE id_pelicula = @idPelicula";

            MySqlCommand cmd = new MySqlCommand(consulta, con);

            cmd.Parameters.AddWithValue("@idPelicula", idPelicula);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(peliculas);

            return peliculas;
        }
        /*Fin de código de Carlos Andres Arriaza Lara 0901-23-13862 el 27/07/2026*/
        /*Inicio de código de Carlos Andres Arriaza Lara 0901-23-13862 el 28/07/2026*/
        public DataTable cargarfunciones(int idPelicula)
        {
            DataTable funciones = new DataTable();
            MySqlConnection con = GetConnection();
            string consulta = @"SELECT 
                        f.id_funcion,
                        TIME_FORMAT(f.hora_funcion, '%H:%i') AS hora_funcion,
                        f.fecha_funcion
                        FROM FUNCION f
                        WHERE f.id_pelicula = @idPelicula";
            MySqlCommand cmd = new MySqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@idPelicula", idPelicula);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(funciones);
            return funciones;
        }
    }
}

