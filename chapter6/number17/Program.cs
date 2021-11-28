using System;
using System.Collections.Generic;

namespace number17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());

            int gcd = Gcd(num1, num2);
            int lcm = Lcm(num1, num2);

            Console.WriteLine($"the greatest common divisor is {gcd}");
            Console.WriteLine($"and the least common multiple is {lcm}");



        }

        public static int Gcd(int a, int b)
        {
            int min = 0;
            if (a < b)
            {
                min = a;
            }
            else
            {
                min = b;
            }

            List<int> factors = new List<int>();

            for (int i = 1; i <= min; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    factors.Add(i);
                }
            }

            int gcd = 0;
            foreach (var item in factors)
            {
                if (item > gcd)
                {
                    gcd = item;
                }
            }
            return gcd;
        }

        public static int Lcm(int a, int b)
        {
            int lcm = Math.Abs(a * b) / Gcd(a, b);
            return lcm;
        }
    }
}
