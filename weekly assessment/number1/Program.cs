using System;

namespace number1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            Console.WriteLine("Enter year: (e.g., 2012");
            int year = int.Parse(Console.ReadLine());
            int j = year / 100;
            int k = year % 100;
            Console.WriteLine("Enter month: 1-12");
            int m = int.Parse(Console.ReadLine());
            if (m == 1 || m == 2)
            {
                m = m + 12;
                year += 1;
            }
            Console.WriteLine("Enter the day of the month: 1-31");
            int q = int.Parse(Console.ReadLine());
            int h1 = (26 * (m + 1)) / 10;
            int h = (q + h1 + k + (k / 4) + (j / 4) + (5 * j)) % 7;
            for (int i = 0; i < days.Length; i++)
            {
                if (h == i)
                {
                    Console.WriteLine($"Day of the week is {days[i]} {q} {m%12} {year}");
                }
            }

        }
    }
}
