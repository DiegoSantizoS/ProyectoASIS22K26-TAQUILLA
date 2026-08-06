/* Inicio de código de José Pablo Cano Cóbar 
 * Carnet: 0901-23-1727
 * Fecha: 04/08/2026 */

namespace Plantilla_Cliente
{

    /// Resumen completo de la compra. Concentra la informacion de la funcion, las butacas seleccionadas y el calculo de tarifas.

    public class DetalleCompra
    {
        // ---------- Factores de tarifa (parametrizables) ----------
        public const decimal FactorAdulto = 1.00m;
        public const decimal FactorNino = 0.60m;
        public const decimal FactorAdultoMayor = 0.70m;

        // ---------- Limites del requerimiento ----------
        public const int MaximoBoletos = 10;

        // ---------- Datos de la funcion ----------
        public int IdFuncion { get; set; }
        public string NombreCine { get; set; } = string.Empty;
        public string NombreCiudad { get; set; } = string.Empty;
        public string TituloPelicula { get; set; } = string.Empty;
        public string Clasificacion { get; set; } = string.Empty;
        public int NumeroSala { get; set; }
        public string TipoSala { get; set; } = string.Empty;
        public string TipoFuncion { get; set; } = string.Empty;
        public DateTime FechaFuncion { get; set; }
        public TimeSpan HoraFuncion { get; set; }
        public decimal PrecioBase { get; set; }

        // ---------- Seleccion del usuario ----------
        public List<int> Butacas { get; set; } = new();
        public int CantidadAdultos { get; set; }
        public int CantidadNinos { get; set; }
        public int CantidadAdultosMayores { get; set; }

        // ---------- Precios unitarios calculados ----------
        public decimal PrecioAdulto => decimal.Round(PrecioBase * FactorAdulto, 2);
        public decimal PrecioNino => decimal.Round(PrecioBase * FactorNino, 2);
        public decimal PrecioAdultoMayor => decimal.Round(PrecioBase * FactorAdultoMayor, 2);

        public int TotalBoletos => CantidadAdultos + CantidadNinos + CantidadAdultosMayores;

        public List<LineaTarifa> ObtenerLineas()
        {
            List<LineaTarifa> lineas = new();

            if (CantidadAdultos > 0)
                lineas.Add(new LineaTarifa { Tipo = TipoTarifa.Adulto, Cantidad = CantidadAdultos, PrecioUnitario = PrecioAdulto });

            if (CantidadNinos > 0)
                lineas.Add(new LineaTarifa { Tipo = TipoTarifa.Nino, Cantidad = CantidadNinos, PrecioUnitario = PrecioNino });

            if (CantidadAdultosMayores > 0)
                lineas.Add(new LineaTarifa { Tipo = TipoTarifa.AdultoMayor, Cantidad = CantidadAdultosMayores, PrecioUnitario = PrecioAdultoMayor });

            return lineas;
        }

        public decimal ObtenerSubtotal(TipoTarifa tipo) => tipo switch
        {
            TipoTarifa.Adulto => CantidadAdultos * PrecioAdulto,
            TipoTarifa.Nino => CantidadNinos * PrecioNino,
            TipoTarifa.AdultoMayor => CantidadAdultosMayores * PrecioAdultoMayor,
            _ => 0m
        };

        public decimal Total => decimal.Round(
            (CantidadAdultos * PrecioAdulto) +
            (CantidadNinos * PrecioNino) +
            (CantidadAdultosMayores * PrecioAdultoMayor), 2);

        // ---------- Presentacion ----------

        public static string DecodificarAsiento(int numeroAsiento)
        {
            int fila = (numeroAsiento - 1) / 10;
            int columna = (numeroAsiento - 1) % 10 + 1;
            char letraFila = (char)('A' + fila);
            return $"{letraFila}{columna}";
        }

        public string ButacasFormateadas =>
            string.Join(", ", Butacas.OrderBy(b => b).Select(DecodificarAsiento));

        public string FuncionFormateada =>
            $"{FechaFuncion:dd/MM/yyyy} a las {HoraFuncion:hh\\:mm}";

        public static string Moneda(decimal valor) => $"Q {valor:N2}";
    }
}

/* Fin de Código de José Pablo Cano Cóbar */ 