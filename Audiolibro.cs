using PlataformaStreaming;
using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Plataforma_Streaming
{
    public class Audiolibro : Contenido
    {
        public string Autor { get; set; }
        public string Narrador { get; set; }

        public Audiolibro(string titulo, double duracion, int reproducciones, string autor, string narrador)
            : base(titulo, duracion, reproducciones)
        {
            Autor = autor;
            Narrador = narrador;
        }

        public void MostrarAudioLibro()
        {
            Console.WriteLine(
                $"Reproduciendo audiolibro: {Titulo}\n" +
                $"Autor: {Autor}\n" +
                $"Narrador: {Narrador}\n" +
                $"Reproducciones: {Reproducciones}");
        }

        public override void Reproducir()
        {
            this.Reproducciones++;
            this.MostrarAudioLibro();
        }
    }
}