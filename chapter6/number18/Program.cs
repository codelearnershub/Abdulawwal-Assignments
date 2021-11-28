using System;

namespace number18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for n:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.WriteLine($"{j}");
                }
            }
        }
    }
}
