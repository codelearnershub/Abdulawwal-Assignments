using System;

namespace Question_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your firstday of the month:(0 = sunday), (1 = monday), (2 = Tuesday), (3 = Wednessday), (4 = Thursday), (5 = friday), (0 = saturday),");
            int day = int.Parse(Console.ReadLine());

            int total = 0;
            int totalDay = 0;
            for(int i = 0; i < 12; i++)
            {
                
                if(i == 0)
                {
                    Console.WriteLine($"January 1, {year} is {Day(day)}");
                }
              
                if(i == 1)
                {
                    total = total +  day + 29;
                    totalDay = total%7;
                    Console.WriteLine($"Feburary 1, {year} is {Day(totalDay)}");
                }
              
                if(i == 2)
                {
                    total = totalDay +  31;
                    totalDay = total%7;
                    Console.WriteLine($"March 1, {year} is {Day(totalDay)}");
                }

                if(i == 3)
                {
                    total = totalDay +  30;
                    totalDay = total%7;
                    Console.WriteLine($"April 1, {year} is {Day(totalDay)}");
                }

                if(i == 4)
                {
                    total = totalDay +  31;
                    totalDay = total%7;
                    Console.WriteLine($"May 1, {year} is {Day(totalDay)}");
                }

                if(i == 5)
                {
                    total = totalDay + 30;
                    totalDay = total%7;
                    Console.WriteLine($"June 1, {year} is {Day(totalDay)}");
                }

                if(i == 6)
                {
                    total = totalDay + 31;
                    totalDay = total%7;
                    Console.WriteLine($"July 1, {year} is {Day(totalDay)}");
                }

                if(i == 7)
                {
                    total = totalDay + 31;
                    totalDay = total%7;
                    Console.WriteLine($"August 1, {year} is {Day(totalDay)}");
                }

                if(i == 8)
                {
                    total = totalDay +  30;
                    totalDay = total%7;
                    Console.WriteLine($"September 1, {year} is {Day(totalDay)}");
                }

                if(i == 9)
                {
                    total = totalDay +  31;
                    totalDay = total%7;
                    Console.WriteLine($"March 1, {year} is {Day(totalDay)}");
                }

                if(i == 10)
                {
                    total = totalDay + 30;
                    totalDay = total%7;
                    Console.WriteLine($"November 1, {year} is {Day(totalDay)}");
                }

                if(i == 11)
                {
                    total = totalDay +  31;
                    totalDay = total%7;
                    Console.WriteLine($"December 1, {year} is {Day(totalDay)}");
                }
            }
            
        }
        static string Day(int total)
        {
            string day = " ";

            switch(total)
            {
                case 0:
                day = "Sunday";
                break;

                case 1:
                day = "Monday";
                break;

                case 2:
                day = "Tuesday";
                break;

                case 3:
                day = "Wednessday";
                break;

                case 4:
                day = "Thursday";
                break;

                case 5:
                day = "Friday";
                break;

                case 6:
                day = "Saturday";
                break;
            }

            return day;
        }
    }
}
