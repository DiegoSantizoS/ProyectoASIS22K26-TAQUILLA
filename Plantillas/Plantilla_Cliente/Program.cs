
using Validaciones;

namespace Plantilla_Cliente
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            GestorErrores.RegistrarManejadorGlobal();

            Application.Run(new FrMenu());
        }
    }
}