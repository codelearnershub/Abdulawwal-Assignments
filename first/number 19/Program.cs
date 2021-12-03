
using System;

namespace Question_19
{
    class Programn
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your total miles per day");
            int milesPerDay =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your cost per gallon");
            int costPerGallon =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your average miles per gallon");
            int averageMilesPerGallon = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your parking fees per day");
            int parkingPerDay =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your tolls per day");
            int tollsPerDay =int.Parse(Console.ReadLine());

            int drivngCost = (milesPerDay / averageMilesPerGallon) * (costPerGallon + parkingPerDay + tollsPerDay);
            Console.WriteLine(drivngCost);
        }
    }
}
