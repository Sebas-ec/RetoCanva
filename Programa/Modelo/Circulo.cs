using Programa.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Figuras
{
    public class Circulo : Figura
    {
        public double radio { get; set; }

        public Circulo()
        {

        }

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double areaCirculo()
        {
            return Math.PI *(radio *Math.Exp(2));
        }

    }
}
