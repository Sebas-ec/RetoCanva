using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Modelo
{
    public class Canvas
    {
        public double alturaCanvas { get; set; }
        
        public double anchoCanvas { get; set; }


        public Canvas()
        {

        }

        public double canvasArea()
        {
            return alturaCanvas * anchoCanvas;
        }



    }

}
