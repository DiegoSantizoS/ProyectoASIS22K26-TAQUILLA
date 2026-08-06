/* Inicio de código de José Pablo Cano Cóbar 
 * Carnet: 0901-23-1727
 * Fecha: 05/08/2026 */

using MySql.Data.MySqlClient;

namespace Plantilla_Cliente
{

    /// Acceso a datos del proceso de pago.

    public class Con_Pago
    {
        private const int ErrorEntradaDuplicada = 1062;

        private const string EstadoBoletoVendido = "vendido";
        private const string MetodoPagoTarjeta = "tarjeta";

        private readonly string _cadenaConexion;

        public Con_Pago()
        {
            _cadenaConexion = "Server=localhost;Database=taquillas_cine;Uid=root;Pwd=Root;";
        }

        public Con_Pago(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        private MySqlConnection AbrirConexion()
        {
            MySqlConnection con = new(_cadenaConexion);
            con.Open();
            return con;
        }

        // =================================================================
        // CONSULTAS
        // =================================================================

        public DetalleCompra? ObtenerDetalleFuncion(int idFuncion)
        {
            const string consulta = @"
                SELECT
                    f.id_funcion,
                    f.fecha_funcion,
                    f.hora_funcion,
                    f.precio_funcion,
                    p.titulo_pelicula,
                    IFNULL(cl.nombre_clasificacion, '') AS clasificacion,
                    s.numero_sala,
                    ts.nombre_tipo_sala,
                    c.nombre_cine,
                    ci.nombre_ciudad
                FROM tbl_funcion f
                INNER JOIN tbl_pelicula  p  ON p.id_pelicula   = f.id_pelicula
                INNER JOIN tbl_sala      s  ON s.id_sala       = f.id_sala
                INNER JOIN tbl_tipo_sala ts ON ts.id_tipo_sala = s.id_tipo_sala
                INNER JOIN tbl_cine      c  ON c.id_cine       = s.id_cine
                INNER JOIN tbl_ciudad    ci ON ci.id_ciudad    = c.id_ciudad
                LEFT  JOIN tbl_clasificacion cl
                        ON cl.id_clasificacion = p.id_clasificacion
                WHERE f.id_funcion = @idFuncion";

            using MySqlConnection con = AbrirConexion();
            using MySqlCommand cmd = new(consulta, con);
            cmd.Parameters.AddWithValue("@idFuncion", idFuncion);

            using MySqlDataReader lector = cmd.ExecuteReader();

            if (!lector.Read()) return null;

            return new DetalleCompra
            {
                IdFuncion = idFuncion,
                FechaFuncion = lector.GetDateTime("fecha_funcion"),
                HoraFuncion = lector.GetTimeSpan("hora_funcion"),
                PrecioBase = lector.GetDecimal("precio_funcion"),
                TituloPelicula = lector.GetString("titulo_pelicula"),
                Clasificacion = lector.GetString("clasificacion"),
                NumeroSala = lector.GetInt32("numero_sala"),
                TipoSala = lector.GetString("nombre_tipo_sala"),

                // El esquema ya no almacena un formato de proyeccion por funcion.
                // Se deja vacio y la factura omite la linea correspondiente.
                TipoFuncion = string.Empty,

                NombreCine = lector.GetString("nombre_cine"),
                NombreCiudad = lector.GetString("nombre_ciudad"),
            };
        }

        public List<int> ObtenerButacasOcupadas(int idFuncion)
        {
            List<int> ocupadas = new();

            const string consulta = @"
                SELECT numero_boleto
                FROM vw_boletos_vendidos
                WHERE id_funcion = @idFuncion";

            using MySqlConnection con = AbrirConexion();
            using MySqlCommand cmd = new(consulta, con);
            cmd.Parameters.AddWithValue("@idFuncion", idFuncion);

            using MySqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read()) ocupadas.Add(lector.GetInt32("numero_boleto"));

            return ocupadas;
        }

        public int? ObtenerIdMetodoPago(string nombre)
        {
            const string consulta = @"
                SELECT id_metodo_pago
                FROM tbl_metodo_pago
                WHERE nombre_metodo_pago = @nombre";

            using MySqlConnection con = AbrirConexion();
            using MySqlCommand cmd = new(consulta, con);
            cmd.Parameters.AddWithValue("@nombre", nombre);

            object? resultado = cmd.ExecuteScalar();
            if (resultado is null or DBNull) return null;
            return Convert.ToInt32(resultado);
        }

        // =================================================================
        // REGISTRO DE LA VENTA
        // =================================================================

        public ResultadoPago RegistrarVenta(DatosCliente cliente, DetalleCompra detalle)
        {
            using MySqlConnection con = AbrirConexion();
            using MySqlTransaction transaccion = con.BeginTransaction();

            try
            {
                int idCliente = ObtenerOCrearCliente(con, transaccion, cliente);

                int? idMetodoPago = ObtenerIdCatalogo(
                    con, transaccion,
                    "tbl_metodo_pago", "id_metodo_pago", "nombre_metodo_pago",
                    MetodoPagoTarjeta);

                int? idEstadoBoleto = ObtenerIdCatalogo(
                    con, transaccion,
                    "tbl_estado_boleto", "id_estado_boleto", "nombre_estado_boleto",
                    EstadoBoletoVendido);

                if (idEstadoBoleto is null)
                {
                    Revertir(transaccion);
                    return ResultadoPago.ErrorDatos(
                        "No se encontró el estado de boleto 'vendido' en el catálogo. " +
                        "Verifique que la base de datos se haya creado completa.");
                }

                int idVenta = InsertarVenta(con, transaccion, idCliente, idMetodoPago, detalle);

                foreach (int butaca in detalle.Butacas)
                {
                    InsertarBoleto(con, transaccion,
                                   detalle.IdFuncion, butaca, idVenta, idEstadoBoleto.Value);
                }

                transaccion.Commit();

                return new ResultadoPago { Exito = true, IdVenta = idVenta };
            }
            catch (MySqlException ex) when (ex.Number == ErrorEntradaDuplicada)
            {
                Revertir(transaccion);

                int butacaConflicto = DetectarButacaEnConflicto(detalle);
                return ResultadoPago.Conflicto(butacaConflicto);
            }
            catch (MySqlException ex)
            {
                Revertir(transaccion);
                Validaciones.Bitacora.RegistrarError(ex, "Con_Pago.RegistrarVenta");
                return ResultadoPago.ErrorDatos(Validaciones.Mensajes.ErrorConsulta);
            }
            catch (Exception ex)
            {
                Revertir(transaccion);
                Validaciones.Bitacora.RegistrarError(ex, "Con_Pago.RegistrarVenta");
                return ResultadoPago.ErrorDatos(Validaciones.Mensajes.ErrorInesperado);
            }
        }

        private static void Revertir(MySqlTransaction transaccion)
        {
            try { transaccion.Rollback(); }
            catch { /* La transaccion pudo cerrarse por perdida de conexion. */ }
        }


        private static int? ObtenerIdCatalogo(
            MySqlConnection con, MySqlTransaction tr,
            string tabla, string columnaId, string columnaNombre, string valor)
        {
            // Los nombres de tabla y columna son constantes internas de esta
            // clase, nunca provienen de entrada del usuario.
            string consulta =
                $"SELECT {columnaId} FROM {tabla} WHERE {columnaNombre} = @valor LIMIT 1";

            using MySqlCommand cmd = new(consulta, con, tr);
            cmd.Parameters.AddWithValue("@valor", valor);

            object? resultado = cmd.ExecuteScalar();
            if (resultado is null or DBNull) return null;
            return Convert.ToInt32(resultado);
        }

        private static int ObtenerOCrearCliente(
            MySqlConnection con, MySqlTransaction tr, DatosCliente cliente)
        {
            const string busqueda = @"
                SELECT id_cliente
                FROM tbl_cliente
                WHERE correo_cliente = @correo
                LIMIT 1";

            using (MySqlCommand cmdBuscar = new(busqueda, con, tr))
            {
                cmdBuscar.Parameters.AddWithValue("@correo", cliente.Correo);
                object? existente = cmdBuscar.ExecuteScalar();

                if (existente is not null and not DBNull)
                {
                    return Convert.ToInt32(existente);
                }
            }

            const string insercion = @"
                INSERT INTO tbl_cliente
                    (nombre_cliente, apellido_cliente, identificacion_cliente, correo_cliente)
                VALUES
                    (@nombre, @apellido, @identificacion, @correo)";

            object valorIdentificacion = string.IsNullOrWhiteSpace(cliente.Identificacion)
                ? DBNull.Value
                : cliente.Identificacion;

            using MySqlCommand cmdInsertar = new(insercion, con, tr);
            cmdInsertar.Parameters.AddWithValue("@nombre", cliente.Nombre);
            cmdInsertar.Parameters.AddWithValue("@apellido", cliente.Apellido);
            cmdInsertar.Parameters.AddWithValue("@identificacion", valorIdentificacion);
            cmdInsertar.Parameters.AddWithValue("@correo", cliente.Correo);

            cmdInsertar.ExecuteNonQuery();

            return (int)cmdInsertar.LastInsertedId;
        }

        private static int InsertarVenta(
            MySqlConnection con, MySqlTransaction tr,
            int idCliente, int? idMetodoPago, DetalleCompra detalle)
        {
            const string insercion = @"
                INSERT INTO tbl_venta
                    (id_cliente, id_promocion, id_usuario, id_metodo_pago,
                     fecha_hora_venta, cantidad_boletos_venta, total_venta)
                VALUES
                    (@idCliente, NULL, NULL, @idMetodoPago,
                     @fechaHora, @cantidad, @total)";

            object valorMetodoPago = idMetodoPago.HasValue
                ? idMetodoPago.Value
                : DBNull.Value;

            using MySqlCommand cmd = new(insercion, con, tr);
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            cmd.Parameters.AddWithValue("@idMetodoPago", valorMetodoPago);
            cmd.Parameters.AddWithValue("@fechaHora", DateTime.Now);
            cmd.Parameters.AddWithValue("@cantidad", detalle.Butacas.Count);
            cmd.Parameters.AddWithValue("@total", detalle.Total);

            cmd.ExecuteNonQuery();

            return (int)cmd.LastInsertedId;
        }

        private static void InsertarBoleto(
            MySqlConnection con, MySqlTransaction tr,
            int idFuncion, int numeroButaca, int idVenta, int idEstadoBoleto)
        {
            const string insercion = @"
                INSERT INTO tbl_boleto
                    (id_funcion, id_venta, id_estado_boleto, numero_boleto)
                VALUES
                    (@idFuncion, @idVenta, @idEstadoBoleto, @numero)";

            using MySqlCommand cmd = new(insercion, con, tr);
            cmd.Parameters.AddWithValue("@idFuncion", idFuncion);
            cmd.Parameters.AddWithValue("@idVenta", idVenta);
            cmd.Parameters.AddWithValue("@idEstadoBoleto", idEstadoBoleto);
            cmd.Parameters.AddWithValue("@numero", numeroButaca);

            cmd.ExecuteNonQuery();
        }

        private int DetectarButacaEnConflicto(DetalleCompra detalle)
        {
            try
            {
                List<int> ocupadas = ObtenerButacasOcupadas(detalle.IdFuncion);
                foreach (int butaca in detalle.Butacas)
                {
                    if (ocupadas.Contains(butaca)) return butaca;
                }
            }
            catch
            {
                // Si la consulta falla se informa la primera butaca solicitada.
            }

            return detalle.Butacas.Count > 0 ? detalle.Butacas[0] : 0;
        }
    }
}

/* Fin de Código de José Pablo Cano Cóbar */ 