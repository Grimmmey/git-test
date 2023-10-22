using System;

namespace test
{
    class Program
    {
        //Metod för omvandling från Fahrenheit till Celsius

        public static int FahrtoCels(int fahr)
        {
            int cel = (fahr - 32) * 5 / 9;
            return cel;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Input temperature in Fahrenheit : ");
            int fahrenheit = int.Parse(Console.ReadLine());
            //Användaren skriver in ett värde som lagras i fahrenheit
            int celsius = FahrtoCels(fahrenheit);
            //I celsius finns nu antal grader omvandlat från Fahrenheit till celsius.
            Console.Write($"Celsius is {celsius} \nPress any key to continue . . . ");
            Console.ReadKey(true);
        
            Console.ReadKey(true);
            Console.ReadKey(true);
            return celsius;
        }

    }
}