using System;

namespace number13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in base 2");
            int num = int.Parse(Console.ReadLine());

            string val = num.ToString();
            double product = 0;
            for (int i = val.Length - 1, j = 0; i >= 0; i--)
            {

                double e = (num % 10) * (Math.Pow(2, j));
                j++;
                product = product + e;
                num = num / 10;
            }

            Console.WriteLine($" {val} in binary is {product} in decimal notation");

        }
    }
}
