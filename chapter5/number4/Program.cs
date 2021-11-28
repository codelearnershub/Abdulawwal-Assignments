using System;

namespace number4
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

            int min = num1;

            if (num1 < num2 || num2 < num3)
            {
                if (num1 < num2)
                {
                    int d;
                    d = num1;
                    num1 = num2;
                    num2 = d;

                    if (num2 < num3)
                    {
                        int e;
                        e = num2;
                        num2 = num3;
                        num3 = e;
                    }

                    if (num1 < num2)
                    {
                        int f;
                        f = num1;
                        num1 = num2;
                        num2 = f;
                    }
                }
                Console.WriteLine($"{num1}, {num2}, {num3}");
            }

            else
            {
                Console.WriteLine($"{num1}, {num2}, {num3}");
            }
        }
    }
}
