using PlataformaStreaming;
using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Plataforma_Streaming
{
    public class Podcast : Contenido
    {
        private string v1;
        private int v2;

        public String Presentador { get; set; }

        public String NumeroEpisodio { get; set; }

        public Podcast(string titulo, double duracion, int reproducciones,
            string presentador, string numEpisodio) 
            : base(titulo, duracion, reproducciones)
        {
            this.Presentador = presentador;
            this.NumeroEpisodio = numEpisodio;    
        }

        public Podcast(string titulo, double duracion, int reproducciones, string v1, int v2) : base(titulo, duracion, reproducciones)
        {
            this.v1 = v1;
            this.v2 = v2;
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
            this.Reproducciones++;
            this.MostrarCancion();
        }
    }
}