namespace Ago22Class
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija de 1 - 3 la     opcion que desea: ");
            Console.WriteLine("Opción 1: Porcentaje de hombre y mujeres de un grupo");
            Console.WriteLine("Opción 2: Cálculo del área y perímetro de un rectángulo");
            Console.WriteLine("Opción 3: Conversión de Fahrenheit a Celcius");

            string option;
            option = Console.ReadLine();
            Console.WriteLine("Ha elegido la opción: " + option);
            switch (option)
            {
                case "1":

                    Ejercicio1.ExecuteExercise1();
                    break;

                case "2":

                    Ejercicio2.ExecuteExercise2();
                    break;

                case "3":
                    Ejercicio3.ExecuteExercise3();
                    break;
            }
            
        }
    }
}