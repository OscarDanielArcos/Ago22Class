using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ago22Class
{
    internal class Ejercicio1
    {
        public static void ExecuteExercise1() {

            //Diseñar un algoritmo para calcular el porcentaje de hombres y de mujeres que hay en un grupo, dados los totales de hombres y de mujeres.

            Console.WriteLine("Ingrese el número de mujeres del grupo: ");
            int numMujeres;
            numMujeres = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese el número de hombres del grupo: ");
            int numHombres;
            numHombres = int.Parse(Console.ReadLine());


            int numPersonas;
            numPersonas = numHombres + numMujeres;


            double porcentaje;
            porcentaje = (numMujeres*numPersonas)/100;
            Console.WriteLine("El porcentaje de mujeres del grupo es: " + porcentaje + "%");

            double porcentaje2;
            porcentaje2 = (numHombres*numPersonas)/100;
            Console.WriteLine("El porcentaje de hombre del grupo es: " + porcentaje2 + "%");

        }
    }
}
