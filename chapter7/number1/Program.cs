using System;

namespace number1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = new int[20];
            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] = i * 5;
            }
            Console.WriteLine($"{String.Join(',', integers)}");
        }
    }
}
