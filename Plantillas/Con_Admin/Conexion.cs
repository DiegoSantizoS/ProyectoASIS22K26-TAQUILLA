using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Inicio de Codigo de Miguel David Contreras Jacinto con carnet: 0901-21-3878 en la
 * fecha de: 28/07/2026 */
namespace Con_Admin
{
    public class Conexion
    {
        private MySqlConnection connecion;
        private String server = "localhost";
        private String datebase = "taquillas_cine";
        private String user = "root";
        private String password = "root";
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
    }
}

/* Inicio de Codigo de Miguel David Contreras Jacinto con carnet: 0901-21-3878 en la
 * fecha de: 29/07/2026 */