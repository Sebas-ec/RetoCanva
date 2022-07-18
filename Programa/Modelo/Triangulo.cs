using Programa.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Figuras
{
    public class Triangulo : Figura
    {
        public double arista1 { get; set; }

        public double arista2 { get; set; }

        public double arista3 { get; set; }

        public Triangulo()
        {

        }

        public Triangulo(double arista1, double arista2, double arista3)
        {
            this.arista1 = arista1;
            this.arista2 = arista2;
            this.arista3 = arista3;
        }

        public double areaTriangulo()
        {
            return Math.Sqrt(arista1 + arista2 + arista3)/2;
        }

    }
}
