using System;
using System.Collections.Generic;

namespace number12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number in base 10");
            int num = int.Parse(Console.ReadLine());

            int i;
            int[] binary = new int[10];
            for (i = 0; num > 0; i++)
            {
                binary[i] = num % 2;
                num = num / 2;

            }
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write($"{binary[i]}");
            }

        }
    }
}
