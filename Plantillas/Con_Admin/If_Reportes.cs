/* Inicio de Código de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 03/08/2026 */
using System;
using System.Data;
using MySql.Data.MySqlClient;
using clase_conexion;

namespace Con_Admin
{
    public class If_Reportes
    {
        private readonly conexion conexion = new conexion();

        public DataTable PeliculasTaquillerasSemana(int anio, int semana)
        {
            const string sql = @"
                SELECT  anio_semana,
                        inicio_semana,
                        id_pelicula,
                        titulo_pelicula,
                        boletos_vendidos,
                        recaudacion,
                        posicion
                FROM vw_peliculas_taquilleras_semana
                WHERE FLOOR(anio_semana / 100) = @anio
                  AND (@semana = 0 OR MOD(anio_semana, 100) = @semana)
                ORDER BY anio_semana, posicion;";

            return Consultar(sql,
                new MySqlParameter("@anio", anio),
                new MySqlParameter("@semana", semana));
        }

        public DataTable PeliculasTaquillerasMes(int anio, int mes)
        {
            const string sql = @"
                SELECT  anio_mes,
                        anio,
                        mes,
                        id_pelicula,
                        titulo_pelicula,
                        boletos_vendidos,
                        recaudacion,
                        posicion
                FROM vw_peliculas_taquilleras_mes
                WHERE anio = @anio
                  AND (@mes = 0 OR mes = @mes)
                ORDER BY anio_mes, posicion;";

            return Consultar(sql,
                new MySqlParameter("@anio", anio),
                new MySqlParameter("@mes", mes));
        }

        public DataTable GananciasSemana(int anio, int semana)
        {
            const string sql = @"
                SELECT  anio_semana,
                        inicio_semana,
                        boletos_vendidos,
                        peliculas_distintas,
                        ganancia_total
                FROM vw_ganancias_semana
                WHERE FLOOR(anio_semana / 100) = @anio
                  AND (@semana = 0 OR MOD(anio_semana, 100) = @semana)
                ORDER BY anio_semana;";

            return Consultar(sql,
                new MySqlParameter("@anio", anio),
                new MySqlParameter("@semana", semana));
        }

        public DataTable GananciasMes(int anio, int mes)
        {
            const string sql = @"
                SELECT  anio_mes,
                        anio,
                        mes,
                        boletos_vendidos,
                        peliculas_distintas,
                        ganancia_total
                FROM vw_ganancias_mes
                WHERE anio = @anio
                  AND (@mes = 0 OR mes = @mes)
                ORDER BY anio_mes;";

            return Consultar(sql,
                new MySqlParameter("@anio", anio),
                new MySqlParameter("@mes", mes));
        }

        public DataTable RecaudacionBoleto(int anio)
        {
            const string sql = @"
                SELECT  id_boleto,
                        id_pelicula,
                        titulo_pelicula,
                        fecha_funcion,
                        precio_funcion
                FROM vw_recaudacion_boleto
                WHERE (@anio = 0 OR YEAR(fecha_funcion) = @anio)
                ORDER BY fecha_funcion;";

            return Consultar(sql,
                new MySqlParameter("@anio", anio));
        }

        private DataTable Consultar(string sql, params MySqlParameter[] parametros)
        {
            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                if (parametros != null)
                    cmd.Parameters.AddRange(parametros);
                using (var da = new MySqlDataAdapter(cmd))
                    da.Fill(tabla);
            }
            return tabla;
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 03/08/2026 */