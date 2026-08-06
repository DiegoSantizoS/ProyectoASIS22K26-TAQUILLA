/* Inicio de código de José Pablo Cano Cóbar 
 * Carnet: 0901-23-1727
 * Fecha: 04/08/2026 */

using System.Net;
using System.Net.Mail;
using System.Text;

namespace Plantilla_Cliente
{

    /// Construccion y envio por correo electronico de la factura de compra.
    ///
    /// Las credenciales del servidor SMTP NO estan escritas en el codigo. Se leen
    /// del archivo correo.env ubicado junto al ejecutable, el cual se encuentra
    /// excluido del control de versiones mediante .gitignore. De esta forma las
    /// credenciales no quedan expuestas en el repositorio.
    ///
    /// Formato esperado del archivo correo.env:
    ///
    ///     servidor=smtp.gmail.com
    ///     puerto=587
    ///     usuario=cine.taquilla.grupo3@gmail.com
    ///     clave=xxxxxxxxxxxxxxxx
    ///     remitente=Cinema Guatemala
    ///
    /// En el caso de Gmail debe generarse una contrasena de aplicacion desde la
    /// configuracion de seguridad de la cuenta. La contrasena ordinaria no
    /// funciona para autenticacion SMTP.
    /// </summary>
    public class ServicioCorreo
    {
        public string Servidor { get; set; } = "smtp.gmail.com";
        public int Puerto { get; set; } = 587;
        public string Usuario { get; set; } = string.Empty;
        public string Clave { get; set; } = string.Empty;
        public string NombreRemitente { get; set; } = "Cinema Guatemala";
        public int TiempoEsperaSegundos { get; set; } = 20;

        public bool EstaConfigurado =>
            !string.IsNullOrWhiteSpace(Usuario) && !string.IsNullOrWhiteSpace(Clave);

        private static readonly string RutaConfiguracion =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "correo.env");

        public ServicioCorreo()
        {
            CargarConfiguracion();
        }

        // =================================================================
        // CONFIGURACION
        // =================================================================

        private void CargarConfiguracion()
        {
            try
            {
                if (!File.Exists(RutaConfiguracion)) return;

                foreach (string linea in File.ReadAllLines(RutaConfiguracion))
                {
                    string texto = linea.Trim();

                    if (texto.Length == 0 || texto.StartsWith('#')) continue;

                    int separador = texto.IndexOf('=');
                    if (separador <= 0) continue;

                    string clave = texto[..separador].Trim().ToLowerInvariant();
                    string valor = texto[(separador + 1)..].Trim();

                    switch (clave)
                    {
                        case "servidor": Servidor = valor; break;
                        case "puerto": if (int.TryParse(valor, out int p)) Puerto = p; break;
                        case "usuario": Usuario = valor; break;
                        case "clave": Clave = valor; break;
                        case "remitente": NombreRemitente = valor; break;
                    }
                }
            }
            catch (Exception ex)
            {
                Validaciones.Bitacora.RegistrarError(ex, "ServicioCorreo.CargarConfiguracion");
            }
        }

        // =================================================================
        // ENVIO
        // =================================================================

        public bool EnviarFactura(
            DatosCliente cliente, DetalleCompra detalle, int idVenta, DatosTarjeta tarjeta)
        {
            if (!EstaConfigurado)
            {
                Validaciones.Bitacora.RegistrarInfo(
                    "No se envió la factura porque el servicio de correo no está configurado.",
                    "ServicioCorreo");
                return false;
            }

            try
            {
                using MailMessage mensaje = new()
                {
                    From = new MailAddress(Usuario, NombreRemitente),
                    Subject = $"Factura No. {idVenta} — {detalle.TituloPelicula}",
                    Body = ConstruirHtmlFactura(cliente, detalle, idVenta, tarjeta),
                    IsBodyHtml = true,
                    BodyEncoding = Encoding.UTF8,
                    SubjectEncoding = Encoding.UTF8,
                };

                mensaje.To.Add(new MailAddress(cliente.Correo, cliente.NombreCompleto));

                using SmtpClient cliente_smtp = new(Servidor, Puerto)
                {
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(Usuario, Clave),
                    Timeout = TiempoEsperaSegundos * 1000,
                };

                cliente_smtp.Send(mensaje);

                Validaciones.Bitacora.RegistrarInfo(
                    $"Factura No. {idVenta} enviada a {cliente.Correo}.", "ServicioCorreo");

                return true;
            }
            catch (SmtpException ex)
            {
                Validaciones.Bitacora.RegistrarError(ex, "ServicioCorreo.EnviarFactura (SMTP)");
                return false;
            }
            catch (Exception ex)
            {
                Validaciones.Bitacora.RegistrarError(ex, "ServicioCorreo.EnviarFactura");
                return false;
            }
        }

        // =================================================================
        // CONSTRUCCION DE LA FACTURA
        // =================================================================

        public static string ConstruirHtmlFactura(
            DatosCliente cliente, DetalleCompra detalle, int idVenta, DatosTarjeta tarjeta)
        {
            StringBuilder sb = new();

            sb.Append("<html><body style=\"margin:0;padding:24px;background:#f4f5f7;")
              .Append("font-family:Arial,Helvetica,sans-serif;color:#222;\">");

            sb.Append("<div style=\"max-width:620px;margin:0 auto;background:#ffffff;")
              .Append("border-radius:8px;overflow:hidden;border:1px solid #e0e0e0;\">");

            // ---- Encabezado ----
            sb.Append("<div style=\"background:#1f3864;padding:24px;text-align:center;\">")
              .Append("<h1 style=\"margin:0;color:#ffffff;font-size:22px;\">CINEMA GUATEMALA</h1>")
              .Append("<p style=\"margin:6px 0 0;color:#c9d3ea;font-size:13px;\">")
              .Append("Comprobante electrónico de compra</p>")
              .Append("</div>");

            sb.Append("<div style=\"padding:24px;\">");

            // ---- Datos de la factura ----
            sb.Append($"<p style=\"margin:0 0 4px;font-size:15px;\">Estimado(a) <strong>{Escapar(cliente.NombreCompleto)}</strong>,</p>");
            sb.Append("<p style=\"margin:0 0 20px;font-size:14px;color:#555;\">")
              .Append("Su compra fue procesada correctamente. A continuación el detalle de su reservación.</p>");

            sb.Append("<table style=\"width:100%;border-collapse:collapse;font-size:14px;margin-bottom:20px;\">");
            sb.Append(Fila("Factura No.", idVenta.ToString()));
            sb.Append(Fila("Fecha de compra", DateTime.Now.ToString("dd/MM/yyyy HH:mm")));
            sb.Append(Fila("Correo", Escapar(cliente.Correo)));
            sb.Append("</table>");

            // ---- Detalle de la funcion ----
            sb.Append(Titulo("Detalle de la función"));
            sb.Append("<table style=\"width:100%;border-collapse:collapse;font-size:14px;margin-bottom:20px;\">");
            sb.Append(Fila("Película", Escapar(detalle.TituloPelicula)));
            if (!string.IsNullOrWhiteSpace(detalle.Clasificacion))
                sb.Append(Fila("Clasificación", Escapar(detalle.Clasificacion)));
            sb.Append(Fila("Cine", Escapar($"{detalle.NombreCine} — {detalle.NombreCiudad}")));
            sb.Append(Fila("Sala", $"Sala {detalle.NumeroSala} ({Escapar(detalle.TipoSala)})"));
            sb.Append(Fila("Formato", Escapar(detalle.TipoFuncion)));
            sb.Append(Fila("Función", detalle.FuncionFormateada));
            sb.Append(Fila("Butacas", Escapar(detalle.ButacasFormateadas)));
            sb.Append(Fila("Cantidad de boletos", detalle.Butacas.Count.ToString()));
            sb.Append("</table>");

            // ---- Desglose economico ----
            sb.Append(Titulo("Desglose de la compra"));
            sb.Append("<table style=\"width:100%;border-collapse:collapse;font-size:14px;\">");
            sb.Append("<tr style=\"background:#eef1f8;\">")
              .Append(Celda("Tarifa", true, "left"))
              .Append(Celda("Cantidad", true, "center"))
              .Append(Celda("Precio unitario", true, "right"))
              .Append(Celda("Subtotal", true, "right"))
              .Append("</tr>");

            foreach (LineaTarifa linea in detalle.ObtenerLineas())
            {
                sb.Append("<tr>")
                  .Append(Celda(linea.Descripcion, false, "left"))
                  .Append(Celda(linea.Cantidad.ToString(), false, "center"))
                  .Append(Celda(DetalleCompra.Moneda(linea.PrecioUnitario), false, "right"))
                  .Append(Celda(DetalleCompra.Moneda(linea.Subtotal), false, "right"))
                  .Append("</tr>");
            }

            sb.Append("<tr style=\"background:#1f3864;color:#ffffff;\">")
              .Append("<td colspan=\"3\" style=\"padding:10px;text-align:right;font-weight:bold;\">TOTAL</td>")
              .Append($"<td style=\"padding:10px;text-align:right;font-weight:bold;\">{DetalleCompra.Moneda(detalle.Total)}</td>")
              .Append("</tr>");
            sb.Append("</table>");

            // ---- Forma de pago ----
            sb.Append("<p style=\"margin:18px 0 0;font-size:13px;color:#555;\">")
              .Append($"Forma de pago: tarjeta {Escapar(tarjeta.NumeroEnmascarado)}</p>");

            // ---- Aviso ----
            sb.Append("<div style=\"margin-top:22px;padding:14px;background:#fff8e6;")
              .Append("border-left:4px solid #e0a800;font-size:13px;color:#5c4600;\">")
              .Append("Presente este comprobante en la taquilla del cine. Le recomendamos ")
              .Append("llegar con quince minutos de anticipación al inicio de la función.")
              .Append("</div>");

            sb.Append("</div>");

            // ---- Pie ----
            sb.Append("<div style=\"background:#f0f1f4;padding:16px;text-align:center;")
              .Append("font-size:11px;color:#777;\">")
              .Append("Este es un correo generado automáticamente, por favor no responda a este mensaje.<br>")
              .Append("Cinema Guatemala — Proyecto Didáctico, Análisis de Sistemas II")
              .Append("</div>");

            sb.Append("</div></body></html>");

            return sb.ToString();
        }

        // ---------- Auxiliares de maquetacion ----------

        private static string Titulo(string texto) =>
            $"<h2 style=\"margin:0 0 10px;font-size:15px;color:#1f3864;" +
            $"border-bottom:1px solid #e0e0e0;padding-bottom:6px;\">{texto}</h2>";

        private static string Fila(string etiqueta, string valor) =>
            $"<tr><td style=\"padding:6px 0;color:#666;width:42%;\">{etiqueta}</td>" +
            $"<td style=\"padding:6px 0;font-weight:bold;\">{valor}</td></tr>";

        private static string Celda(string texto, bool encabezado, string alineacion)
        {
            string peso = encabezado ? "bold" : "normal";
            string borde = encabezado ? "none" : "1px solid #eceff4";
            return $"<td style=\"padding:9px;text-align:{alineacion};font-weight:{peso};" +
                   $"border-bottom:{borde};\">{texto}</td>";
        }

        private static string Escapar(string texto) =>
            texto.Replace("&", "&amp;")
                 .Replace("<", "&lt;")
                 .Replace(">", "&gt;")
                 .Replace("\"", "&quot;");
    }
}

/* Fin de Código de José Pablo Cano Cóbar */ 