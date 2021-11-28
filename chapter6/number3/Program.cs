using System;

namespace number3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of input");
            int numberOfInput = int.Parse(Console.ReadLine());
            int[] numbers = new int[numberOfInput];
            for (int i = 0; i < numberOfInput; i++)
            {
                Console.WriteLine("Enter the number:");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int max = numbers[0];
            int min = numbers[0];
            foreach (var item in numbers)
            {
                if(item > max)
                {
                    max = item;
                }
            }
            foreach (var item in numbers)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine($"The largest is {max} and the smallest is {min}");
        }
    }
}
