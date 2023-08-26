using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ago22Class
{
    internal class Ejercicio3
    {
        public static void ExecuteExercise3() {

            //Diseñar un algoritmo que convierta y muestre la temperatura en Fahrenheit ingresando la temperatura en Celsius. */

            Console.WriteLine("Ingrese una temperatura en grados Celsius");
            int celcius, fahrenheit;
            celcius = int.Parse(Console.ReadLine());
            fahrenheit = (celcius * 9 / 5) + 32;
            Console.WriteLine(celcius + " grado Celsius son equivalentes a " + fahrenheit + " grados Fahrenheit");
        }
    }
}
