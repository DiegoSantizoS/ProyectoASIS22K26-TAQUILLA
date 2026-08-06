/* Inicio de código de José Pablo Cano Cóbar 
 * Carnet: 0901-23-1727
 * Fecha: 04/08/2026 */

using Validaciones;

namespace Plantilla_Cliente
{
    /// <summary>
    /// Orquestador del proceso de pago. Concentra la totalidad de la logica

    public class ProcesoPago : IDisposable
    {
        // =================================================================
        // CONFIGURACION
        // =================================================================

        public int SegundosLimite { get; set; } = 60;

        public int MaximoIntentos { get; set; } = 3;

        public bool ModoDemostracion { get; set; } = false;

        // =================================================================
        // ESTADO
        // =================================================================

        private readonly Con_Pago _datos;
        private readonly ServicioCorreo _correo;
        private readonly System.Windows.Forms.Timer _temporizador;

        private int _segundosRestantes;
        private bool _pagoEnCurso;
        private bool _operacionCerrada;

        public int IntentosRealizados { get; private set; }
        public int IntentosRestantes => Math.Max(0, MaximoIntentos - IntentosRealizados);
        public bool Bloqueado => IntentosRealizados >= MaximoIntentos;
        public bool TiempoExpirado { get; private set; }
        public TimeSpan TiempoRestante => TimeSpan.FromSeconds(Math.Max(0, _segundosRestantes));

        // =================================================================
        // EVENTOS
        // =================================================================

        public event EventHandler<TimeSpan>? TiempoActualizado;

        public event EventHandler? TiempoAgotado;

        public event EventHandler? IntentosAgotados;

        // =================================================================
        // CONSTRUCCION
        // =================================================================

        public ProcesoPago() : this(new Con_Pago(), new ServicioCorreo()) { }

        public ProcesoPago(Con_Pago datos, ServicioCorreo correo)
        {
            _datos = datos;
            _correo = correo;

            _temporizador = new System.Windows.Forms.Timer { Interval = 1000 };
            _temporizador.Tick += Temporizador_Tick;
        }

        // =================================================================
        // TEMPORIZADOR
        // =================================================================

        public void IniciarTemporizador()
        {
            _segundosRestantes = SegundosLimite;
            TiempoExpirado = false;
            _operacionCerrada = false;

            TiempoActualizado?.Invoke(this, TiempoRestante);
            _temporizador.Start();
        }

        public void DetenerTemporizador() => _temporizador.Stop();

        private void Temporizador_Tick(object? sender, EventArgs e)
        {
            _segundosRestantes--;

            if (_segundosRestantes > 0)
            {
                TiempoActualizado?.Invoke(this, TiempoRestante);
                return;
            }

            _segundosRestantes = 0;
            _temporizador.Stop();
            TiempoExpirado = true;
            _operacionCerrada = true;

            TiempoActualizado?.Invoke(this, TimeSpan.Zero);
            TiempoAgotado?.Invoke(this, EventArgs.Empty);

            Bitacora.RegistrarInfo(
                "Se agotó el tiempo para completar el pago. Butacas liberadas.", "ProcesoPago");
        }

        // =================================================================
        // PREPARACION
        // =================================================================

        public DetalleCompra? PrepararCompra(
            int idFuncion, List<int> butacas,
            int adultos, int ninos, int adultosMayores)
        {
            DetalleCompra? detalle = _datos.ObtenerDetalleFuncion(idFuncion);
            if (detalle is null) return null;

            detalle.Butacas = new List<int>(butacas);
            detalle.CantidadAdultos = adultos;
            detalle.CantidadNinos = ninos;
            detalle.CantidadAdultosMayores = adultosMayores;

            return detalle;
        }

        // =================================================================
        // VALIDACION
        // =================================================================

        public ResultadoValidacion Validar(
            DatosCliente cliente, DatosTarjeta tarjeta, DetalleCompra detalle)
        {
            ResultadoValidacion r = new();

            // ---- Datos del comprador ----
            r.AgregarSiFalla(Validador.EsSoloLetras(cliente.Nombre), Mensajes.NombreInvalido)
             .AgregarSiFalla(Validador.LongitudEntre(cliente.Nombre, 2, 60), Mensajes.NombreInvalido)
             .AgregarSiFalla(Validador.EsSoloLetras(cliente.Apellido), Mensajes.ApellidoInvalido)
             .AgregarSiFalla(Validador.LongitudEntre(cliente.Apellido, 2, 60), Mensajes.ApellidoInvalido)
             .AgregarSiFalla(Validador.EsCorreoValido(cliente.Correo), Mensajes.CorreoInvalido);

            // ---- Tarjeta ----
            r.AgregarSiFalla(Validador.EsRequerido(tarjeta.Titular), Mensajes.TitularRequerido)
             .AgregarSiFalla(Validador.EsTarjetaValida(tarjeta.Numero), Mensajes.TarjetaInvalida)
             .AgregarSiFalla(Validador.EsVencimientoValido(tarjeta.Vencimiento), Mensajes.TarjetaVencida)
             .AgregarSiFalla(Validador.EsCvvValido(tarjeta.Cvv), Mensajes.CvvInvalido);

            // ---- Coherencia de la compra ----
            r.AgregarSiFalla(
                Validador.EsCantidadBoletosValida(
                    detalle.CantidadAdultos, detalle.CantidadNinos, detalle.CantidadAdultosMayores),
                Mensajes.BoletosFueraDeRango);

            r.AgregarSiFalla(
                Validador.ButacasCoincidenConBoletos(detalle.Butacas.Count, detalle.TotalBoletos),
                string.Format(Mensajes.ButacasNoCoinciden, detalle.TotalBoletos));

            r.AgregarSiFalla(
                Validador.EsFechaEnRangoReserva(detalle.FechaFuncion), Mensajes.FechaFueraDeRango);

            r.AgregarSiFalla(detalle.Total > 0, Mensajes.CostoInvalido);

            return r;
        }

        // =================================================================
        // PROCESO DE PAGO
        // =================================================================

        public ResultadoPago Procesar(
            DatosCliente cliente, DatosTarjeta tarjeta, DetalleCompra detalle)
        {
            // ---- 1. Bloqueo de pagos simultaneos ----
            if (_pagoEnCurso) return ResultadoPago.EnProceso();

            // ---- 2. Estado de la operacion ----
            if (TiempoExpirado || _operacionCerrada) return ResultadoPago.Expirado();
            if (Bloqueado) return ResultadoPago.Bloqueado();

            _pagoEnCurso = true;

            try
            {
                // ---- 3. Validacion de datos ----
                ResultadoValidacion validacion = Validar(cliente, tarjeta, detalle);
                if (!validacion.EsValido)
                {
                    return ResultadoPago.Invalido(validacion.Errores);
                }

                // ---- 4. Autorizacion de la transaccion ----
                IntentosRealizados++;

                if (!AutorizarTransaccion(tarjeta))
                {
                    Bitacora.RegistrarIntentoFallido(cliente.Correo, "pago", IntentosRealizados);

                    if (Bloqueado)
                    {
                        CerrarOperacion();
                        IntentosAgotados?.Invoke(this, EventArgs.Empty);
                        return ResultadoPago.Bloqueado();
                    }

                    return ResultadoPago.Rechazado(
                        $"La transacción fue rechazada por la entidad emisora. " +
                        $"Le quedan {IntentosRestantes} intento(s).",
                        IntentosRestantes);
                }

                // ---- 5. Registro de la venta ----
                ResultadoPago registro = _datos.RegistrarVenta(cliente, detalle);

                if (!registro.Exito)
                {
                    IntentosRealizados--;
                    return registro;
                }

                // ---- 6. Envio de la factura ----
                CerrarOperacion();

                bool enviado = _correo.EnviarFactura(cliente, detalle, registro.IdVenta, tarjeta);

                Bitacora.RegistrarInfo(
                    $"Venta No. {registro.IdVenta} registrada. Total: {DetalleCompra.Moneda(detalle.Total)}. " +
                    $"Butacas: {detalle.ButacasFormateadas}.", "ProcesoPago");

                return ResultadoPago.Correcto(registro.IdVenta, enviado);
            }
            catch (Exception ex)
            {
                Bitacora.RegistrarError(ex, "ProcesoPago.Procesar");
                return ResultadoPago.ErrorDatos(Mensajes.ErrorInesperado);
            }
            finally
            {
                // Los datos sensibles se descartan siempre.
                tarjeta.Limpiar();
                _pagoEnCurso = false;
            }
        }

        private bool AutorizarTransaccion(DatosTarjeta tarjeta)
        {
            if (ModoDemostracion && tarjeta.UltimosCuatro.EndsWith('0'))
            {
                return false;
            }

            return true;
        }

        private void CerrarOperacion()
        {
            _operacionCerrada = true;
            _temporizador.Stop();
        }

        public void Reiniciar()
        {
            _temporizador.Stop();
            IntentosRealizados = 0;
            TiempoExpirado = false;
            _pagoEnCurso = false;
            _operacionCerrada = false;
            _segundosRestantes = SegundosLimite;
        }

        public void Dispose()
        {
            _temporizador.Stop();
            _temporizador.Tick -= Temporizador_Tick;
            _temporizador.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

/* Fin de Código de José Pablo Cano Cóbar */ 