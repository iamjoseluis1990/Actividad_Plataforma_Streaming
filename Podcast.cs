using PlataformaStreaming;
using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Plataforma_Streaming
{
    public class Podcast : Contenido
    {
        private string presentador;

        public Podcast(string Presentador, int NumeroEpisodio,
           int Reproducciones, string artista, string numeroepisodio) : base(Presentador, NumeroEpisodio, Reproducciones)
        {
            this.Reproducciones = Reproducciones;
        }

        public String Presentador { get; set; }

        public String NumeroEpisodio { get; set; }
        public void AumentarReproducciones()
        {
            this.Reproducciones += 1;
        }

        public void MostrarCancion()
        {
            Console.WriteLine(
            $"Reproduciendo: {this.NumeroEpisodio}\n" +
            $"Presentador: {this.Presentador}\n" +
            $"Reproducciones: {this.Reproducciones}");
        }
        public override void Reproducir()
        {
            throw new NotImplementedException();
        }
    }
}