﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral
{
    class Pelicula : Info
    {
      
        public Pelicula(string titulo, int ano, string director, string genero, string sinopsis, int rating)
        {
            Titulo = titulo;
            Ano = ano;
            Director = director;
            Genero = genero;
            Sinopsis = sinopsis;
            Rating = rating;
        }
       

    }
}