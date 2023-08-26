using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ago22Class
{
    internal class Ejercicio2
    {
        public static void ExecuteExercise2() {

            //Diseñar un algoritmo que imprima el área y el perímetro de un rectángulo ingresando su base y altura. 

            int b;
            Console.WriteLine("Ingrese la base del rectangulo: ");
            b=int.Parse(Console.ReadLine());

            int h;
            Console.WriteLine("Ingrese la altura del rectangulo: ");
            h =int.Parse(Console.ReadLine());

            int area;
            area = b*h; 
            Console.WriteLine("La área del rectángulo es: " +  area + " unidades");

            int perimetro;
            perimetro = 2*b + 2*h;
            Console.WriteLine("El perímetro del rectángulo es: " + perimetro + " unidades");
        }
        

    }
}
