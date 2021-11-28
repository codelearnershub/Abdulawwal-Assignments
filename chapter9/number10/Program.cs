using System;
using System.Numerics;

namespace number10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number in the range 1-100");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine($"{n}! is {Factorial(n)}");
        }

        public static BigInteger Factorial(BigInteger n)
        {
            BigInteger factorial = 1;
            for (BigInteger i = n; i >= 1; i--)
            {
                factorial *= n;
            }
            return factorial;
        }
    }
}
