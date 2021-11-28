using System;
using System.Collections.Generic;

namespace number16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for N: ");
            int N = int.Parse(Console.ReadLine());
            List<int> store = new List<int>();

            for (int i = 0; i <= N; i++)
            {
                Random numbers = new Random();
                int a = numbers.Next(1, N + 1);
                Console.WriteLine(a);
            }

        }
    }
}
