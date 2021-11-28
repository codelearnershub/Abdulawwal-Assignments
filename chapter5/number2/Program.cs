using System;

namespace number2
{
    class Program
    {
        static void Main(string[] args)
        {
            int negativeCount = 0;
            Console.WriteLine("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 < 0)
            {
                negativeCount++;
            }
            Console.WriteLine("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 < 0)
            {
                negativeCount++;
            }
            Console.WriteLine("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());
            if (num3 < 0)
            {
                negativeCount++;
            }



            if (negativeCount % 2 == 0)
            {
                Console.WriteLine('+');
            }
            else
            {
                Console.WriteLine('-');
            }

        }
    }
}
