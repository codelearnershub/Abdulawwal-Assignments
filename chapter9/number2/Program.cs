using System;

namespace number2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int num3 = int.Parse(Console.ReadLine());

            int minimum = GetMax(GetMax(num1, num2), num3);

            Console.WriteLine($"the minimum number is {minimum}");
        }

        public static int GetMax(int a, int b)
        {
            int min = 0;
            if (a < b)
            {
                min = a;
            }
            else
            {
                min = b;
            }
            return min;
        }
    }
}
