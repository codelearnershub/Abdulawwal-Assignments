using System;

namespace number9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i = num; i > 0; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"{num}! = {factorial}");

        }
    }
}
