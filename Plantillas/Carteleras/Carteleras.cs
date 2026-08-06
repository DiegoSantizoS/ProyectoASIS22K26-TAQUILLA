using System;
using System.IO;
namespace Plantillas.Carteleras
{
    public class Carteleras
    {
        string url;
        int IdPelicula;
        string DirectorioBase;
        string Raiz;
        public Carteleras(int IdPelicula)
        {
            this.DirectorioBase = AppContext.BaseDirectory;
            this.IdPelicula = IdPelicula;
            this.url = "";
            this.Raiz = Directory.GetParent(this.DirectorioBase).Parent.Parent.Parent.Parent.FullName;
        }
        public string obtenerUrl()
        {
            if (string.IsNullOrEmpty(url))
            {
                string Carpeta = Path.Combine(Raiz, "Recursos", "Carteleras");
                string jpg = Path.Combine(Carpeta, $"{IdPelicula}.jpg");
                string png = Path.Combine(Carpeta, $"{IdPelicula}.png");
                if (File.Exists(jpg))
                {
                    url = jpg;
                }
                else if (File.Exists(png))
                {
                    url = png;
                }
                else
                {
                    url = Path.Combine(Raiz, "Recursos", "Carteleras", "default.jpeg");
                }

            }
            return url;
        }

      
    }
}
