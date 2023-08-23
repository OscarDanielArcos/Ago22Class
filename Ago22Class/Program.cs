namespace Ago22Class
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija de 1 - 3 la opcion que desea: ");
            string option; 
            option = Console.ReadLine();
            Console.WriteLine("Ha elegido la opcioón: " + option);
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