using System;

namespace number11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter 1 to Reverse integers \n Enter 2 to calculate average \n Enter 3 to solve linear equation");
            int option = int.Parse(Console.ReadLine());

            if(option == 1)
            {
                Reverse();
            }

            else if (option == 2)
            {
                Average();
            }

            else if (option == 3)
            {
                Findx();
            }

        }

        public static void Reverse()
        {
            Console.WriteLine("Enter the integer in the range 1 - 50,000,000");
            long num = long.Parse(Console.ReadLine());

            string b = num.ToString();
            for (int i = b.Length - 1; i >= 0; i--)
            {
                Console.Write(b[i]);
            }
        }

        public static void Average()
        {
            int[] numbers = { 2, 4, 6, 8, 10, 12 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            int average = sum / numbers.Length;
            Console.WriteLine($"the average is {average}");

        }

        public static void Findx()
        {
            Console.WriteLine("enter value for a(non-zero):");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter value for b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"find x in the equation: {a}x + {b} = 0");

            double x = (double)-b / a;

            Console.WriteLine($"the value of x is {x}");

        }
    }
}
