using System;

namespace number9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for x:");
            int x = int.Parse(Console.ReadLine());
            double s = 1;

            for (int i = 1; i <= n; i++)
            {
                s = s + (Factorial(i) / (Math.Pow(x, i)));
            }

            Console.WriteLine(s);


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
