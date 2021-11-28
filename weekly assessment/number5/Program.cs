using System;

namespace number5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                int factorial = 1;
                for (int j = i; j > 0; j--)
                {
                    factorial = factorial * j;
                }
                Console.WriteLine($"{i}     {factorial}");
            }
        }
    }
}

// Data type int wont contain the value of the factorial of 20.