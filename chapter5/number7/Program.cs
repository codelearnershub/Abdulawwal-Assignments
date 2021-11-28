using System;

namespace number7
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number");
                int number = int.Parse(Console.ReadLine());

                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The greatest number is {max}");
        }
    }
}
