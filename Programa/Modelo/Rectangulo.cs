using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Modelo
{
    public class Rectangulo : Figura
    {
       public double baseR { get; set; }
        public double altR { get; set; }

        public Rectangulo()
        {
        }

        public Rectangulo(double baseR, double altR)
        {
            this.baseR = baseR;
            this.altR = altR;
        }

        public double AreaRectangulo()
        {
            return baseR * altR;
        }
    }
}
