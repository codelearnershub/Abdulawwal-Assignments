using System;

namespace number5
{
    class Program
    {
        static void Main(string[] args)
        {
            int f0 = 0;
            int f1 = 1;
            int f2 = 0;
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"{f0} {f1} ");
            for (int i = 2; i < n; i++)
            {
                f2 = f0 + f1;
                Console.Write($"{f2} ");
                f0 = f1;
                f1 = f2;
            }
        }
    }
}
