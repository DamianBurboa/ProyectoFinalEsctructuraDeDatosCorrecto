using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTercerParcial
{
    class Serie1 : ClPadre
    {
        public Serie1(string titulo, int año, string rating, string genero, string descripcion, string director,string temp, string prodiccion)
        {
            Titulo = titulo;
            Año = año;
            Rating = rating;
            Genero = genero;
            Descripcion = descripcion;
            Director = director;
            Temp = temp;
            Produccion = prodiccion;
        }

        public override string ToString()
        {
            return this.Titulo + " " + this.Año;
        }
    }
}
