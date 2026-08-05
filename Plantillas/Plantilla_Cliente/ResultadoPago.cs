/* Inicio de código de José Pablo Cano Cóbar 
 * Carnet: 0901-23-1727
 * Fecha: 04/08/2026 */


namespace Plantilla_Cliente
{
    public enum MotivoFallo
    {
        Ninguno,
        DatosInvalidos,
        TarjetaRechazada,
        ButacaOcupada,
        TiempoAgotado,
        IntentosExcedidos,
        PagoEnProceso,
        ErrorBaseDatos
    }

    /// Resultado del proceso de pago. Permite al formulario decidir que mostrar al usuario sin necesidad de interpretar excepciones ni codigos de error.

    public class ResultadoPago
    {
        public bool Exito { get; init; }
        public MotivoFallo Motivo { get; init; } = MotivoFallo.Ninguno;
        public string Mensaje { get; init; } = string.Empty;

        public int IdVenta { get; init; }

        public int? ButacaEnConflicto { get; init; }

        public bool CorreoEnviado { get; init; }

        public IReadOnlyList<string> Errores { get; init; } = new List<string>();

        public int IntentosRestantes { get; init; }

        // ---------- Constructores semanticos ----------
        public static ResultadoPago Correcto(int idVenta, bool correoEnviado) => new()
        {
            Exito = true,
            IdVenta = idVenta,
            CorreoEnviado = correoEnviado,
            Mensaje = correoEnviado
                ? $"Pago procesado correctamente. La factura No. {idVenta} fue enviada a su correo electrónico."
                : $"Pago procesado correctamente. La factura No. {idVenta} fue generada, pero no se logró enviar al correo electrónico."
        };

        public static ResultadoPago Invalido(IReadOnlyList<string> errores) => new()
        {
            Exito = false,
            Motivo = MotivoFallo.DatosInvalidos,
            Errores = errores,
            Mensaje = "Los datos ingresados presentan errores. Verifique la información."
        };

        public static ResultadoPago Rechazado(string mensaje, int intentosRestantes) => new()
        {
            Exito = false,
            Motivo = MotivoFallo.TarjetaRechazada,
            Mensaje = mensaje,
            IntentosRestantes = intentosRestantes
        };

        public static ResultadoPago Conflicto(int butaca) => new()
        {
            Exito = false,
            Motivo = MotivoFallo.ButacaOcupada,
            ButacaEnConflicto = butaca,
            Mensaje = $"La butaca {DetalleCompra.DecodificarAsiento(butaca)} fue reservada por otro usuario " +
                      "mientras usted completaba el pago. Seleccione una butaca distinta."
        };

        public static ResultadoPago Expirado() => new()
        {
            Exito = false,
            Motivo = MotivoFallo.TiempoAgotado,
            Mensaje = "Se agotó el tiempo disponible para completar el pago. Las butacas fueron liberadas."
        };

        public static ResultadoPago Bloqueado() => new()
        {
            Exito = false,
            Motivo = MotivoFallo.IntentosExcedidos,
            Mensaje = "Ha excedido el número máximo de intentos de pago permitidos. " +
                      "La operación fue cancelada y las butacas fueron liberadas."
        };

        public static ResultadoPago EnProceso() => new()
        {
            Exito = false,
            Motivo = MotivoFallo.PagoEnProceso,
            Mensaje = "Ya existe un pago en proceso. Espere a que la operación finalice."
        };

        public static ResultadoPago ErrorDatos(string mensaje) => new()
        {
            Exito = false,
            Motivo = MotivoFallo.ErrorBaseDatos,
            Mensaje = mensaje
        };
    }
}

/* Fin de Código de José Pablo Cano Cóbar */ 