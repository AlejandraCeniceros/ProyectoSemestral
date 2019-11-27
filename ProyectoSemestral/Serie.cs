using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral
{
    public class Serie : Info
    {
        public Serie(string titulo, int ano, string genero,int rating, int temporadas, string productor, string descripcion)
        {
            this.Titulo = titulo;
            this.Ano = ano;
            this.Genero = genero;
            this.Rating = rating;
            this.Temporadas = temporadas;
            this.Productor = productor;
            this.Descripcion = descripcion;


            Tipo = "Serie";
        }

        public override string ToString()
        {
            return this.Titulo + "" + this.Ano;
        }
    }
}
