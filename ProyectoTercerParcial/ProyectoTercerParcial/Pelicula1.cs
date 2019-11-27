using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTercerParcial
{
    class Pelicula1 : ClPadre
    {
        public Pelicula1(string titulo, int año, string rating, string genero, string descripcion, string director, string prodiccion)
        {
            Titulo = titulo;
            Año = año;
            Rating = rating;
            Genero = genero;
            Descripcion = descripcion;
            Director = director;
            Produccion = prodiccion;
        }

        public override string ToString()
        {
            return this.Titulo + " " + this.Año;
        }
    }
}
