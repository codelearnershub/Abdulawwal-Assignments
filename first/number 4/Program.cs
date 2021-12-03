using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your No:");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your No:");
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine($" The greatest common divisor between the two number is{Factor( firstNum , secondNum)}");
        }

        static int Factor(int firstNum , int secondNum)
        {
            int maximum = 0;
            int minimum = Math.Min(firstNum , secondNum);
            for(int i = 1; i <= minimum; i++)
            {
                if(firstNum % i == 0 && secondNum % i == 0)
                {
                    int x = i;
                    if(i > maximum)
                    {
                        maximum = i;
                    }
                }
            }

            return maximum;
        }
    }
}
