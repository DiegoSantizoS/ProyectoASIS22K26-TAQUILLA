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


        public DataTable mostrarpelicula() 
        { 
            DataTable peliculas =  new DataTable();

            try {
                MySqlConnection con = GetConnection();
                
                string consulta = @"SELECT 
                            id_pelicula as ID,
                            titulo_pelicula as Nombre,
                            duracion_pelicula as duracion,
                            clasificacion_pelicula as clasificacion,
                            genero_pelicula as genero
                            FROM PELICULA";

                MySqlCommand cmd = new MySqlCommand(consulta, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(peliculas);

                return peliculas;

            }
            catch{ return peliculas; }

        
        }
    }
}
/* Fin de Codigo de Miguel David Contreras Jacinto con carnet: 0901-21-3878 en la
 * fecha de: 26/07/2026 */