using System;

namespace number1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
