using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;
using Libreria.Figuras;
using Newtonsoft.Json;
using Programa.Modelo;

namespace Programa
{
    public class Producto
    {
        private static string _path = @"C:\json\figures.json";

       
        static void Main(string[] args)
        {
            Canvas c1 = new Canvas();
            c1.alturaCanvas = 10;
            c1.anchoCanvas = 50;
            Console.WriteLine("area del canvas: " + c1.canvasArea());
            double area = c1.canvasArea();

            string file = @"C:\json\figuras.json";
            string Jsontext = File.ReadAllText(file);
            var informacion = Newtonsoft.Json.JsonConvert.DeserializeObject<Figura[]>(Jsontext);

            //---------Imprimir JSON---------
            //var Newfiguras = ObtenerInfo();
            //Imprimir(Newfiguras);
            //-------------------------------
            //foreach(var figu in informacion)
            //{
            //    Console.WriteLine($"{figu.Nombre}");
            //    Console.WriteLine($"{figu.Texto}");
            //    Console.WriteLine();
            //}

            //-----------------------------
            //Figuras Disponibles
            Console.WriteLine("Figuras Disponibles: ");
            Console.WriteLine(informacion[0].Nombre);
            Console.WriteLine(informacion[1].Nombre);
            Console.WriteLine(informacion[2].Nombre);

            Rectangulo re1 = new Rectangulo();
            re1.Nombre = "Rectangulo";
            re1.Texto = "Rectangulo rojo";
            re1.baseR = 5;
            re1.altR = 2;
            re1.AreaRectangulo();
            double areaR = re1.AreaRectangulo();


            Triangulo tr1 = new Triangulo();
            tr1.Nombre = "Triangulo Isoseles";
            tr1.Texto = "lados iguales";
            tr1.arista1 = 10;
            tr1.arista1 = 10;
            tr1.arista1 = 10;
            tr1.areaTriangulo();
            double areaT = tr1.areaTriangulo();

            Circulo ci1 = new Circulo();
            ci1.Nombre = "Circulo";
            ci1.Texto = "Esferico";
            ci1.radio = 4;
            ci1.areaCirculo();
            double areaC = ci1.areaCirculo();

            double areaResta = area;

           Console.WriteLine();
           if(area > areaR)
            {
                Console.WriteLine("-Se dibujo el rectangulo");
                areaResta = area - areaR;
                Console.WriteLine("Quedan: " + Math.Round(areaResta, 2) + "cm");

            }
            else
            {
                Console.WriteLine("no se puede dibujar, no hay espacio");
            }

            if (areaResta > areaT)
            {
                Console.WriteLine("-Se dibujo el triangulo");
                areaResta = area - areaT;
                Console.WriteLine("Quedan: " + Math.Round(areaResta, 2) + "cm");
            }
            else
            {
                Console.WriteLine("no se puede dibujar, no hay espacio");
            }

            if (areaResta > areaC)
            {
                Console.WriteLine("-Se dibujo el circulo");
                areaResta = area - areaC;
                Console.WriteLine("Quedan: " + Math.Round(areaResta, 2) + "cm");
            }
            else
            {
                Console.WriteLine("no se puede dibujar, no hay espacio");
            }

        }


        public static string ObtenerInfo()
        {
            String ruta = @"C:\json\figuras.json";

            string formaJson;
            using (var reader = new StreamReader(ruta))
            {
                formaJson = reader.ReadToEnd();
            }
            return formaJson;

        }

        public static void Imprimir(String array)
        {
            Console.WriteLine(array);
        }

    }
}
