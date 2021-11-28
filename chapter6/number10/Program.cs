using System;

namespace number10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i ++)
            {
                int k = n + (i - 1);
                for (int j = i; j <= k; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }


        }
    }
}
