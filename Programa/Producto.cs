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
            c1.alturaCanvas = 50;
            c1.anchoCanvas = 150;
            Console.WriteLine("area del canvas: " + c1.canvasArea());


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


            Triangulo tr1 = new Triangulo();
            tr1.Nombre = "Triangulo Isoseles";
            tr1.Texto = "lados iguales";
            tr1.arista1 = 10;
            tr1.arista1 = 10;
            tr1.arista1 = 10;
            tr1.areaTriangulo();


            Circulo ci1 = new Circulo();
            ci1.Nombre = "Circulo";
            ci1.Texto = "Esferico";
            ci1.radio = 4;
            ci1.areaCirculo();


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
