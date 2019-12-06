using System;

namespace csharp_exercises_201907_NumericTypesMileage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of miles driven - ");
            float numberOfMiles = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter amount of gas consumed - ");
            float gallonsOfGas = float.Parse(Console.ReadLine());

            float mileage = numberOfMiles / gallonsOfGas;

            Console.WriteLine("Mileage (miles per gallon of gas) is - " + mileage);
            Console.WriteLine("Mileage (miles per gallon of gas) is - " + (numberOfMiles / gallonsOfGas));

            Console.ReadLine();
        }
    }
}
