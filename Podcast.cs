using PlataformaStreaming;
using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Plataforma_Streaming
{
    public class Podcast : Contenido
    {

        public String Presentador { get; set; }

        public String NumeroEpisodio { get; set; }

        public Podcast(string titulo, double duracion, int reproducciones,
            string presentador, string numEpisodio) 
            : base(titulo, duracion, reproducciones)
        {
            this.Presentador = presentador;
            this.NumeroEpisodio = numEpisodio;    
        }

        public void AumentarReproducciones()
        {
            this.Reproducciones++;
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