/* Inicio de código de José Pablo Cano Cóbar 
 * Carnet: 0901-23-1727
 * Fecha: 04/08/2026 */

namespace Plantilla_Cliente
{
    public enum TipoTarifa
    {
        Adulto,
        Nino,
        AdultoMayor
    }

    public class DatosCliente
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Identificacion { get; set; } = string.Empty;

        public string NombreCompleto => $"{Nombre} {Apellido}".Trim();
    }

    public class DatosTarjeta
    {
        public string Numero { get; set; } = string.Empty;
        public string Titular { get; set; } = string.Empty;
        public string Vencimiento { get; set; } = string.Empty;   // formato MM/AA
        public string Cvv { get; set; } = string.Empty;

        public string UltimosCuatro
        {
            get
            {
                string digitos = new(Numero.Where(char.IsDigit).ToArray());
                return digitos.Length >= 4 ? digitos[^4..] : string.Empty;
            }
        }

        public string NumeroEnmascarado =>
            string.IsNullOrEmpty(UltimosCuatro) ? "****" : $"**** **** **** {UltimosCuatro}";

        public void Limpiar()
        {
            Numero = string.Empty;
            Cvv = string.Empty;
            Vencimiento = string.Empty;
        }
    }

    public class LineaTarifa
    {
        public TipoTarifa Tipo { get; init; }
        public int Cantidad { get; init; }
        public decimal PrecioUnitario { get; init; }

        public decimal Subtotal => Cantidad * PrecioUnitario;

        public string Descripcion => Tipo switch
        {
            TipoTarifa.Adulto => "Adulto",
            TipoTarifa.Nino => "Niño",
            TipoTarifa.AdultoMayor => "Adulto mayor",
            _ => "Boleto"
        };
    }
}

/* Fin de Código de José Pablo Cano Cóbar */ 