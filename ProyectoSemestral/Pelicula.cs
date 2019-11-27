using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral
{
    public class Pelicula : Info
    {
      
        public Pelicula(string titulo, int ano, string director, string genero, string sinopsis, int rating, int temporadas, string productor, string descripcion)
        {
            this.Titulo = titulo;
            this.Ano = ano;
            this.Director = director;
            this.Genero = genero;
            this.Sinopsis = sinopsis;
            this.Rating = rating;
            this.Temporadas = temporadas;
            this.Productor = productor;
            this.Descripcion = descripcion;

            Tipo = "Pelicula";
        }

        public override string ToString()
        {
            return this.Titulo + ("")+ this.Ano;
        }
    }
}