using System;

namespace Question_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your minutes");
            double minutes = int.Parse(Console.ReadLine());

            Console.WriteLine($"{ConversionYear( minutes)} year = {minutes} minutes");
            Console.WriteLine($"{ConversionDay( minutes)} day = {minutes} minutes");

        }
        static double ConversionYear(double minutes)
        {
            double minutesPerYear = 60 * 24 * 365;
            double year = minutes / minutesPerYear;
            return year;
        }

        static double ConversionDay(double minutes)
        {
            double minutesPerDay = 60 * 24;
            double day = minutes / minutesPerDay;
            return day;
        }
    }
}
