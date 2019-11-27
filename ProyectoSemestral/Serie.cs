using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral
{
    class Serie : Info
    {
        public Serie() { }
        public Serie(string titulo, int ano, string director, string genero,int temporadas, string sinopsis, int rating)
        {
            Titulo = titulo;
            Ano = ano;
            Director = director;
            Genero = genero;
            Temporadas = temporadas;
            Sinopsis = sinopsis;
            Rating = rating;
        }

    }
}
