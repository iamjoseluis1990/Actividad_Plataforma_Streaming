using PlataformaStreaming;
using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Plataforma_Streaming
{
    internal class Class1
    {
    }
}



namespace Actividad_Plataforma_Streaming
{
    public class Audiolibro : Contenido
    {
        public string Autor { get; set; }
        public string Narrador { get; set; }
        public int Reproducciones { get; private set; }

        public Audiolibro(string titulo, double duracion, int reproducciones, string autor, string narrador)
            : base(titulo, duracion, reproducciones)
        {
            Autor = autor;
            Narrador = narrador;
        }

        public override void Reproducir()
        {
            this.Reproducciones++;
            Console.WriteLine(
                $"Reproduciendo audiolibro: {Titulo}\n" +
                $"Autor: {Autor}\n" +
                $"Narrador: {Narrador}\n" +
                $"Reproducciones: {Reproducciones}");
        }
    }
}