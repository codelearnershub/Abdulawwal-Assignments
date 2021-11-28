using System;

namespace number10
{
    class Program
    {
        static void Main(string[] args)
        {
            double e = 1 + (1 / Factorial(1)) + (1 / Factorial(2)) + (1 / Factorial(3)) + (1/Factorial(4)) + (1/Factorial(5));
            Console.WriteLine(e);
            Console.WriteLine(Math.E);
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
