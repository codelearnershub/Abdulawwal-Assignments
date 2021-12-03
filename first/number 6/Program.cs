using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input todays date: ");
            int todaysDay = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number of days: ");
            int numberOfDays = int.Parse(Console.ReadLine());
            int futureDay = (todaysDay + numberOfDays) % 7;
            if (futureDay == 0)
            {
                Console.WriteLine($"the future day is Sunday ");
            }

            else if (futureDay == 1)
            {
                Console.WriteLine($"the future day is Monday ");
            }

            else if (futureDay == 2)
            {
                Console.WriteLine($"the future day is Tuesday ");
            }

            else if (futureDay == 3)
            {
                Console.WriteLine($"the future day is Wednesday ");
            }

            else if (futureDay == 4)
            {
                Console.WriteLine($"the future day is Thursday ");
            }

            else if (futureDay == 5)
            {
                Console.WriteLine($"the future day is Friday ");
            }

            else if (futureDay == 6)
            {
                Console.WriteLine($"the future day is Saturday ");
            }
        }
    }
}
