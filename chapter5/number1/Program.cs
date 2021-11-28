using System;

namespace number1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int num3 = 0;

            if(num1 > num2)
            {
                num3 = num1;
                num1 = num2;
                num2 = num3;

            }
            Console.WriteLine($"{num1} {num2}");

        }
    }
}
