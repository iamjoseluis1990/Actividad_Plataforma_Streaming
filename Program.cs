using Actividad_Plataforma_Streaming;
using PlataformaStreaming;

namespace Actividad_Plataforma_Streaming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hola");

            // PARTE 7: Crear objetos
            Cancion cancion1 = new Cancion("Blinding Lights", 3.20, 15, "The Weeknd", "Pop");
            Cancion cancion2 = new Cancion("Espresso", 2.55, 42, "Sabrina Carpenter", "Pop");

            Podcast podcast1 = new Podcast("La tecnología de mañana", 45.0, 8, "Laura Gómez", 12);
            Podcast podcast2 = new Podcast("Historias de internet", 30.5, 23, "Carlos Ruiz", 5);

            Audiolibro audiolibro1 = new Audiolibro("El misterio de la ciudad", 480.0, 4, "Ana López", "Pedro Martín");

            // PARTE 8: Guardar en el array y mostrar
            Contenido[] contenidos = new Contenido[]
            {
                cancion1,
                cancion2,
                podcast1,
                podcast2,
                audiolibro1
            };

            // PARTE 9: Reproducir contenidos
            Console.WriteLine("----------------------------------");
            Console.WriteLine("          REPRODUCCIÓN            ");
            Console.WriteLine("----------------------------------");

            foreach (Contenido c in contenidos)
            {
                c.Reproducir();
            }

            // PARTE 10 — DESCARGAS
            Console.WriteLine("\n=====================================");
            Console.WriteLine("              DESCARGAS              ");
            Console.WriteLine("=====================================\n");

            // Recorremos todos los contenidos para intentar descargarlos
            foreach (Contenido c in contenidos)
            {
                if (c is IDescargable descargable)
                {
                    descargable.Descargar();
                    Console.WriteLine($"{c.Titulo} -> Descargado");
                }
                else
                {
                    Console.WriteLine($"{c.Titulo} -> No disponible para descarga");
                }
            }

        }
    }
}





