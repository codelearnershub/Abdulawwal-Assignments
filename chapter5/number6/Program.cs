using System;

namespace number6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for c");
            double c = double.Parse(Console.ReadLine());

            double choice = Discriminant(a, b, c);

            double x;
            if (choice < 0)
            {
                Console.WriteLine("the quadratic equation has no equal roots");
            }
            else if (choice == 0)
            {
                x = -b / (2 * a);
                Console.WriteLine($"x = {x}");
            }
            else if (choice > 0)
            {
                double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                Console.WriteLine($"x1 = {x1} and x2 = {x2}");
            }
        }

        static double Discriminant(double a, double b, double c)
        {
            double discriminant = Math.Pow(b, 2) - (4 * a * c);
            return discriminant;
        }
    }
}
