using PlataformaStreaming;
using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Plataforma_Streaming
{
    public class Cancion : Contenido
    {
        public Cancion(string Titulo, int Duracion,
           int Reproducciones, string artista, string genero) : base(Titulo, Duracion, Reproducciones)
        {
            Artista = artista;
            Genero = genero;
            this.Reproducciones = Reproducciones;
        }

        public String Artista { get; set; }

        public String Genero { get; set; }
        public void AumentarReproducciones()
        {
            this.Reproducciones += 1;
        }

        public void MostrarCancion()
        {
            Console.WriteLine(
            $"Reproduciendo: {this.Titulo}\n" +
            $"Artista: {this.Artista}\n" +
            $"Reproducciones: {this.Reproducciones}");
        }
        public override void Reproducir()
        {
            throw new NotImplementedException();
        }
    }
}

       


