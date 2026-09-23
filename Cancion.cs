using PlataformaStreaming;
using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Plataforma_Streaming
{
    public class Cancion : Contenido, IDescargable
    {

        public String Artista { get; set; }

        public String Genero { get; set; }

        public Cancion(string titulo, double duracion, int reproducciones,
            string artista, string genero) 
        : base(titulo, duracion, reproducciones)
        {
            this.Artista = artista;
            this.Genero = genero;
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
            this.Reproducciones++;
            this.MostrarCancion();
        }

        public void Descargar()
        {
            throw new NotImplementedException();
        }

        public void EliminarDescarga()
        {
            throw new NotImplementedException();
        }
    }
}

       


