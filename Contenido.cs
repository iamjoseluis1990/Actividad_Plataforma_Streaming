using System;

namespace PlataformaStreaming
{
    // PARTE 1 — CLASE ABSTRACTA
    public abstract class Contenido
    {
        // Propiedades: Titulo, Duracion (en minutos) y Reproducciones
        public string Titulo { get; set; }
        public double Duracion { get; set; }
        public int Reproducciones { get; set; }

        public virtual void Reproducir()
        {
            Reproducciones++;
            Console.WriteLine($"Reproduciendo: {Titulo}");
            Console.WriteLine($"Reproducciones: {Reproducciones}");
        }

        // Constructor para establecer los valores
        public Contenido(string titulo, double duracion, int reproducciones)
        {
            Titulo = titulo;
            Duracion = duracion;
            Reproducciones = reproducciones;
        }

        // Método para mostrar los datos básicos
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Duración: {Duracion} min");
            Console.WriteLine($"Reproducciones: {Reproducciones}");
        }

    }
}

