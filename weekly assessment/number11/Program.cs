using System;

namespace number11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for x:");
            int num = int.Parse(Console.ReadLine());
            double e = 1 + (Math.Pow(num,1) / Factorial(1)) + (Math.Pow(num, 2) / Factorial(2)) + (Math.Pow(num, 3) / Factorial(3)) + (Math.Pow(num, 4) / Factorial(4)) + (Math.Pow(num, 5) / Factorial(5));
            Console.WriteLine(e);
            Console.WriteLine(Math.Pow(Math.E, num));
        }

        public static double Factorial(int num)
        {
            double factorial = 1;
            for (int i = num; i > 0; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
