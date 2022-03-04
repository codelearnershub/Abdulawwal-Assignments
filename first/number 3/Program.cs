using System;

namespace Question_3RETRY
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter students's average: ");
            int element = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your average falls under {studentAverage(element)} category");
        }

        static int studentAverage(int element)
        {
            int i = 65;
            if (element >= 90 && element <= 100)
            {
                i = 4;
            }

            else if (element >= 80 && element <= 89)
            {
                i = 3;
            }

            else if (element >= 70 && element <= 79)
            {
                i = 2;
            }

            else if (element >= 60 && element <= 69)
            {
                i = 1;
            }

            else if (element < 60)
            {
                i = 0;
            }
            return i;
        }
    }
}
